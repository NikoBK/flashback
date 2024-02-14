/*
*  File: LibraryGameArtBox.cs 
*  Date: 14/02/2024
*  Author: NikoBK
*/
namespace flashback_emulator.UserControls.Components
{
    public partial class LibraryGameArtBox : UserControl
    {
        private MainForm _mainForm { get; set; }
        private GameData _gameData { get; set; }

        public LibraryGameArtBox(MainForm mainform, GameData game)
        {
            InitializeComponent();
            _mainForm = mainform;
            _gameData = game;
        }

        private void artworkButton_Click(object sender, EventArgs e)
        {
            _mainForm.ShowGameView(_gameData);
        }
    }
}
