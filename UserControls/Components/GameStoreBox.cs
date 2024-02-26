/*
*  File: GameStoreBox.cs 
*  Date: 13/02/2024
*  Author: NikoBK
*/
namespace flashback_emulator.UserControls
{
    public partial class GameStoreBox : UserControl
    {
        private MainForm _mainForm { get; set; }
        public GameData GameData { get; private set; }

        public GameStoreBox(MainForm mainForm, GameData gameData, Image img = null)
        {
            InitializeComponent();
            _mainForm = mainForm;
            GameData = gameData;

            gameBoxNameLabel.Text = gameData.Name;
            if (img != null)
            {
                gameBoxArtButton.BackgroundImageLayout = ImageLayout.Stretch;
                gameBoxArtButton.BackgroundImage = img;
            }
        }

        private void gameBoxArtButton_Click(object sender, EventArgs e)
        {
            _mainForm.ShowGameView(GameData);
        }
    }
}
