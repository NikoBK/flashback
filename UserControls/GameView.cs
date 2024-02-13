/*
*  File: GameView.cs 
*  Date: 13/02/2024
*  Author: NikoBK
*/
namespace flashback_emulator.UserControls
{
    public partial class GameView : UserControl
    {
        private static NewLayoutForm _mainForm { get; set; }
        private static GameData _gameData { get; set; }

        public GameView(NewLayoutForm mainForm, AppData appData, GameData gameData)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _gameData = gameData;

            userButton.Text = appData.Username.ToUpper();
            gameNameLabel.Text = gameData.Name;

            if (gameData.InLibrary) {
                playButton.Text = "PLAY";
                playButton.Font = new Font(playButton.Font.Name, 14.25f);
                playButton.BackColor = Color.FromArgb(71, 197, 52);
            }
            else {
                playButton.Text = "ADD TO LIBRARY";
                playButton.Font = new Font(playButton.Font.Name, 10.25f);
                playButton.BackColor = Color.FromArgb(39, 79, 135);
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
            _mainForm.AddGameToLibrary(_gameData);
        }
    }
}
