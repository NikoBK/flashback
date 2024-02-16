/*
*  File: SimpleGameLibraryButton.cs 
*  Date: 11/02/2024
*  Author: NikoBK
*/
namespace flashback_emulator.UserControls
{
    public partial class SimpleGameLibraryButton : UserControl
    {
        private MainForm _mainForm { get; set; }
        private GameData _gameData { get; set; }

        public SimpleGameLibraryButton(MainForm mainform, GameData game, Image icon = null)
        {
            InitializeComponent();
            displayNameButton.Text = game.Name;
            _mainForm = mainform;
            _gameData = game;

            if (icon != null)
            {
                logoPicturebox.BackgroundImage = icon;
                logoPicturebox.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void displayNameButton_Click(object sender, EventArgs e)
        {
            _mainForm.ShowGameView(_gameData);
        }
    }
}
