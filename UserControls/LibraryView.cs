/*
*  File: LibraryView.cs 
*  Date: 12/02/2024
*  Author: NikoBK
*/
namespace flashback_emulator.UserControls
{
    public partial class LibraryView : UserControl
    {
        public LibraryView(AppData appData)
        {
            InitializeComponent();
            libUsernameButton.Text = appData.Username.ToUpper();

            libLabelNoGames.Visible = appData.GameCount < 1;
            libLabelNoGamesList.Visible = appData.GameCount < 1;
        }
    }
}
