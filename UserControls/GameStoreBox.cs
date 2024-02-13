/*
*  File: GameStoreBox.cs 
*  Date: 13/02/2024
*  Author: NikoBK
*/
namespace flashback_emulator.UserControls
{
    public partial class GameStoreBox : UserControl
    {
        private NewLayoutForm _mainForm { get; set; }

        public GameData GameData { get; private set; }

        public GameStoreBox(NewLayoutForm mainForm, GameData gameData)
        {
            InitializeComponent();
            _mainForm = mainForm;
            GameData = gameData;

            gameBoxNameLabel.Text = gameData.Name;
        }

        private void gameBoxArtButton_Click(object sender, EventArgs e)
        {
            // TODO: Dispatch the gameview from the main form.
        }
    }
}
