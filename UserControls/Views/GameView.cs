/*
*  File: GameView.cs 
*  Date: 13/02/2024
*  Author: NikoBK
*/
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace flashback_emulator.UserControls
{
    public partial class GameView : UserControl
    {
        private static MainForm _mainForm { get; set; }
        private static GameData _gameData { get; set; }
        private bool _gamePlaying = false;

        public GameView(MainForm mainForm, AppData appData, GameData gameData)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _gameData = gameData;

            userButton.Text = appData.Username.ToUpper();
            gameNameLabel.Text = gameData.Name;

            if (_gameData.HasBeenPlayed) {
                lastPlayedCounterLabel.Text = gameData.LastPlayed.ToString("MMM dd");
                playTimeCounterLabel.Text = gameData.TimePlayedS.ToString(@"hh\:mm\:ss");
            }
            else {
                lastPlayedCounterLabel.Text = "Never";
                playTimeCounterLabel.Text = "No Time";
            }

            if (DataManager.Heros.ContainsKey(gameData.Id)) {
                gameCoverPictureBox.BackgroundImage = DataManager.Heros[gameData.Id];
                gameCoverPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (gameData.InLibrary) {
                playButton.Text = "PLAY";
                playButton.Font = new Font(playButton.Font.Name, 14.25f);
                playButton.BackColor = Constants.GreenButton;
            }
            else if (!gameData.Playable) {
                playButton.Text = "NO GAME FILE";
                playButton.Font = new Font(playButton.Font.Name, 10.25f);
                playButton.BackColor = Constants.BlueButton;
                playButton.Enabled = false;
            }
            else {
                playButton.Text = "ADD TO LIBRARY";
                playButton.Font = new Font(playButton.Font.Name, 10.25f);
                playButton.BackColor = Constants.BlueButton;
            }
        }

        private void storeButton_Click(object sender, EventArgs e)
        {
            _mainForm.OpenStore();
        }

        private void libButton_Click(object sender, EventArgs e)
        {
            _mainForm.OpenLibrary();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            // TODO: Implement something here.
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (_gamePlaying) {
                _mainForm.StopGame();
                _gamePlaying = false;
                playButton.Text = "PLAY";
                playButton.BackColor = Constants.GreenButton;
            }
            else if (_gameData.Playable && _gameData.InLibrary) {
                _mainForm.PlayGame(_gameData);
                _gamePlaying = true;
                playButton.Text = "STOP";
                playButton.BackColor = Constants.BlueButton;
            }
            else if (!_gameData.InLibrary) {
                _mainForm.AddGameToLibrary(_gameData);
            }
        }

        public void UpdateLastPlayed(DateTime timestamp)
        {
            lastPlayedCounterLabel.Text = timestamp.ToString("MMM dd");
        }

        public void UpdateTimePlayed(TimeSpan time)
        {
            playTimeCounterLabel.Text = time.ToString(@"hh\:mm\:ss");
        }
    }
}
