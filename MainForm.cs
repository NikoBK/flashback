/*
*  File: NewLayoutForm.cs 
*  Date: 11/02/2024
*  Author: NikoBK
*/
using flashback_emulator.UserControls;
using System.Diagnostics;

namespace flashback_emulator
{
    public partial class MainForm : Form
    {
        // TODO: This should be based on some save data that fetches
        // games from some directory of files.
        public int GamesCount { get; private set; } = 0;
        private AppData AppData { get; set; }
        private UserControl? CurrentScreenView { get; set; }
        
        // Game stats
        private System.Windows.Forms.Timer _gameProcessTimer;
        private DateTime _gameStartTime;
        private TimeSpan _elapsedGameTime;
        private Process _gameProcess;
        private string _currentGameId;

        public MainForm()
        {
            InitializeComponent();
            LoadAppData();
            CurrentScreenView = null;

            _gameProcessTimer = new System.Windows.Forms.Timer();
            _gameProcessTimer.Interval = 1000; // Update every second
            _gameProcessTimer.Tick += GameTimer_Tick;

            // Start parsing games for caching.
            DataManager.Init();
            
            if (!AppData.Registered) {
                // If the user for the existing appdata is not registered display the
                // introductory view.
                UpdateScreenView(new NewUserView(this));
            }
            else {
                if (AppData.Games.Count > 0) {
                    UpdateScreenView(new LibraryView(this, AppData));
                }
                else {
                    UpdateScreenView(new EmptyLibrary(this, AppData));
                }
            }
        }

        /// <summary>
        /// Load the appdata for flashback using the <see cref="DataManager"/>.
        /// </summary>
        private void LoadAppData()
        {
            AppData = DataManager.LoadAppData(DataManager.GetAppDataPath());
        }

        /// <summary>
        /// Update the current screenview by removing and disposing the old one
        /// to then display the new screenview.
        /// </summary>
        /// <param name="screenView"></param>
        private void UpdateScreenView(UserControl screenView)
        {
            // Remove and dispose the current screenview before updating.
            if (CurrentScreenView != null) { 
                screenViewPanel.Controls.Remove(CurrentScreenView);
                CurrentScreenView.Dispose();
            }
            // Update the current screenview.
            CurrentScreenView = screenView;
            CurrentScreenView.Dock = DockStyle.Fill;
            screenViewPanel.Controls.Add(CurrentScreenView);
        }

        /// <summary>
        /// Function call for the <see cref="NewUserView"/> when the confirm button is clicked.
        /// Loads Flashback's appdata and feeds it to the <see cref="LibraryView"/>.
        /// </summary>
        public void OpenLibrary()
        {
            LoadAppData();
            if (AppData.Games.Count > 0) {
                UpdateScreenView(new LibraryView(this, AppData));
            }
            else {
                UpdateScreenView(new EmptyLibrary(this, AppData));
            }
        }

        /// <summary>
        /// Function call for the <see cref="LibraryView"/> wehn the 'ADD GAME' button is clicked.
        /// Loads Flashback's appdata and feeds it to the <see cref="StoreView"/>.
        /// </summary>
        public void OpenStore()
        {
            LoadAppData();
            UpdateScreenView(new StoreView(this, AppData));
        }

        public void ShowGameView(GameData data)
        {
            LoadAppData();
            UpdateScreenView(new GameView(this, AppData, data));
        }

        public void AddGameToLibrary(GameData game)
        {
            // Get the latest application data.
            LoadAppData();

            // Add the game.
            AppData.Games.Add(game);

            // Save the addition of the game.
            game.InLibrary = true;
            DataManager.SaveData(AppData);

            // Refresh the library.
            OpenLibrary();
        }

        public void PlayGame(GameData game)
        {
            LoadAppData();

            if (File.Exists(game.SWFPath))
            {
                // MessageBox.Show(game.SWFPath);
                var pi = new ProcessStartInfo(game.SWFPath)
                {              
                    Arguments = Path.GetFileName(game.SWFPath),
                    UseShellExecute = true,
                    WorkingDirectory = Path.GetDirectoryName(game.SWFPath),
                    FileName = game.SWFPath,
                    Verb = "OPEN"
                };
                _gameProcess = Process.Start(pi);

                // Record the start time.
                _gameStartTime = DateTime.Now;

                // Update last played.
                DateTime today = DateTime.Today;

                // Start the time.
                _gameProcessTimer.Start();

                foreach (var savedGame in AppData.Games) { 
                    if (savedGame.Id == game.Id) {
                        savedGame.LastPlayed = today;
                        _currentGameId = savedGame.Id;

                        if (!savedGame.HasBeenPlayed) {
                            savedGame.HasBeenPlayed = true;
                        }

                        var gameview = (CurrentScreenView as GameView);
                        if (gameview != null) {
                            gameview.UpdateLastPlayed(savedGame.LastPlayed);
                        }
                    }
                }
            }
            else {
                // This should not happen as we do a files check in the GameView for the game.
                // Keeping this here just in case though.
                // TODO: Check and remove if redundant.
                MessageBox.Show($"Unable to find the game files for {game.Name}", "Game not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // Calculate elapsed time.
            TimeSpan elapsedTime = DateTime.Now - _gameStartTime;
            _elapsedGameTime = elapsedTime;
        }

        /// <summary>
        /// Kills the process of the current game that is being played.
        /// </summary>
        public void StopGame()
        {
            _gameProcessTimer.Stop();

            // Stop the flashplayer process.
            if (_gameProcess != null && !_gameProcess.HasExited) {
                _gameProcess.Kill(); // Close the process forcefully.
                _gameProcess.Dispose(); // Release resources.

                foreach(var game in AppData.Games) { 
                    if (game.Id == _currentGameId) {
                        game.TimePlayedS += _elapsedGameTime;

                        var gameview = (CurrentScreenView as GameView);
                        if (gameview != null) {
                            gameview.UpdateTimePlayed(game.TimePlayedS);
                        }
                    }
                }

                _currentGameId = string.Empty;

                // Save game stats such as total time played and last played.
                DataManager.SaveData(AppData);
            }
        }
    }
}
