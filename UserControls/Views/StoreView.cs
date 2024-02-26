/*
*  File: StoreView.cs 
*  Date: 13/02/2024
*  Author: NikoBK
*/
using System.Xml.Linq;

namespace flashback_emulator.UserControls
{
    public partial class StoreView : UserControl
    {
        // Singleton pattern for the main form to do callbacks on button clicks so
        // that the screenview panel can be updated per button click.
        private static MainForm _mainForm { get; set; }
        private static AppData _appData { get; set; }

        public StoreView(MainForm mainForm, AppData appData)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _appData = appData;

            usernameButton.Text = appData.Username.ToUpper();

            // Center the search bar/panel.
            int centerX = (storePanel.Width - storeSortPanel.Width) / 2;
            storeSortPanel.Location = new Point(centerX, storeSortPanel.Location.Y);

            // Start parsing all games in the installed
            // flashback directory.
            ParseGames();
        }

        private void libraryButton_Click(object sender, EventArgs e)
        {
            _mainForm.OpenLibrary();
        }

        private void ParseGames()
        {
            foreach (var game in DataManager.Games) 
            {
                // Instantiate the game as a gamebox on the store view.
                GameStoreBox box;

                // If there is a storegrid cached for the game in the datamanger
                // use it.
                if (DataManager.StoreGrids.ContainsKey(game.Key)) { 
                    box = new GameStoreBox(_mainForm, game.Value, DataManager.StoreGrids[game.Key]);
                }
                else {
                    box = new GameStoreBox(_mainForm, game.Value);
                }
                gameBoxFlowLayoutPanel.Controls.Add(box);
            }
        }
    }
}
