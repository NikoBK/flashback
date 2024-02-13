/*
*  File: LibraryView.cs 
*  Date: 12/02/2024
*  Author: NikoBK
*/
namespace flashback_emulator.UserControls
{
    public partial class LibraryView : UserControl
    {
        // Singleton pattern for the main form to do callbacks on button clicks so
        // that the screenview panel can be updated per button click.
        private static NewLayoutForm _mainForm { get; set; }

        public LibraryView(NewLayoutForm mainForm, AppData appData)
        {
            InitializeComponent();
            _mainForm = mainForm;
            libUsernameButton.Text = appData.Username.ToUpper();

            libLabelNoGames.Visible = appData.GameCount < 1;
            libLabelNoGamesList.Visible = appData.GameCount < 1;
        }

        private void libAddGameButton_Click(object sender, EventArgs e)
        {
            _mainForm.OpenStore();
        }

        private void LibraryView_Load(object sender, EventArgs e)
        {

        }
    }
}
