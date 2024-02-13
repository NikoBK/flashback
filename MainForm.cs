/*
*  File: NewLayoutForm.cs 
*  Date: 11/02/2024
*  Author: NikoBK
*/
using flashback_emulator.UserControls;

namespace flashback_emulator
{
    public partial class MainForm : Form
    {
        // TODO: This should be based on some save data that fetches
        // games from some directory of files.
        public int GamesCount { get; private set; } = 0;
        private AppData AppData { get; set; }
        private UserControl? CurrentScreenView { get; set; }

        public MainForm()
        {
            InitializeComponent();
            LoadAppData();
            CurrentScreenView = null;
            
            if (!AppData.Registered) {
                // If the user for the existing appdata is not registered display the
                // introductory view.
                UpdateScreenView(new NewUserView(this));
            }
            else {
                UpdateScreenView(new LibraryView(this, AppData));
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
            UpdateScreenView(new LibraryView(this, AppData));
        }

        /// <summary>
        /// Function call for the <see cref="LibraryView"/> wehn the 'ADD GAME' button is clicked.
        /// Loads Flashback's appdata and feeds it to the <see cref="storeLabel"/>.
        /// </summary>
        public void OpenStore()
        {
            LoadAppData();
            UpdateScreenView(new storeLabel(this, AppData));
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
    }
}
