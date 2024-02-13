/*
*  File: StoreView.cs 
*  Date: 13/02/2024
*  Author: NikoBK
*/
using System.Xml.Linq;

namespace flashback_emulator.UserControls
{
    public partial class storeLabel : UserControl
    {
        // Singleton pattern for the main form to do callbacks on button clicks so
        // that the screenview panel can be updated per button click.
        private static MainForm _mainForm { get; set; }
        private static AppData _appData { get; set; }

        public static Dictionary<GameData, GameStoreBox> Games { get; private set; }

        public storeLabel(MainForm mainForm, AppData appData)
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
            Games = new Dictionary<GameData, GameStoreBox>();
            string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/Flashback/games/";

            // Enumerate all files in the games folder. Using enumeratefiles because
            // it is more memory effecient.
            string[] gamesXML = Directory.EnumerateFiles(path, "games.xml", SearchOption.AllDirectories).ToArray();
            XElement xml = XElement.Load(gamesXML[0]); // There should always only be one file in this.

            // Parse every game xml.
            foreach (XElement elem in xml.Elements("Game")) 
            {
                GameData data = new GameData {
                    Id = elem.Attribute("id").Value, // Every game xml must have an id!
                    Name = elem.Element("Name") != null ? elem.Element("Name").Value : "No Name",
                    Description = elem.Element("Description") != null ? elem.Element("Description").Value : "No Description",
                    SupportsMultiplayer = false
                };

                // Save the swf path for later, might be useful for
                // doing a save-data backup for any game.
                data.SWFPath = $"{path}{data.Id}.swf";

                foreach (var game in _appData.Games) { 
                    if (game.Id == data.Id) {
                        data.InLibrary = true;
                    }
                }

                // Instantiate the game as a gamebox on the store view.
                GameStoreBox box = new GameStoreBox(_mainForm, data);
                gameBoxFlowLayoutPanel.Controls.Add(box);
                Games.Add(data, box);
            }
        }
    }
}
