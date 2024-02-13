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

        public GameView(NewLayoutForm mainForm, AppData appData, GameData gameData)
        {
            InitializeComponent();
            _mainForm = mainForm;
            userButton.Text = appData.Username.ToUpper();

            gameNameLabel.Text = gameData.Name;
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
    }
}
