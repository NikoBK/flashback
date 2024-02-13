/*
*  File: StoreView.cs 
*  Date: 13/02/2024
*  Author: NikoBK
*/
namespace flashback_emulator.UserControls
{
    public partial class storeLabel : UserControl
    {
        // Singleton pattern for the main form to do callbacks on button clicks so
        // that the screenview panel can be updated per button click.
        private static NewLayoutForm _mainForm { get; set; }

        public storeLabel(NewLayoutForm mainForm, AppData appData)
        {
            InitializeComponent();
            _mainForm = mainForm;
            usernameButton.Text = appData.Username.ToUpper();

            int centerX = (storePanel.Width - storeSortPanel.Width) / 2;
            storeSortPanel.Location = new Point(centerX, storeSortPanel.Location.Y);

            // Use this for later.
            //for (int i = 0; i < 25; i++)
            //{
            //    // Instantiate a gamebox for each game.
            //    GameStoreBox gameBox = new GameStoreBox();

            //    // Add the game to the store.
            //    gameBoxFlowLayoutPanel.Controls.Add(gameBox);
            //}
        }

        private void libraryButton_Click(object sender, EventArgs e)
        {
            _mainForm.OpenLibrary();
        }
    }
}
