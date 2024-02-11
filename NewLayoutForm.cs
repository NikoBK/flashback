/*
*  File: NewLayoutForm.cs 
*  Date: 11/02/2024
*  Author: NikoBK
*/
using flashback_emulator.UserControls;

namespace flashback_emulator
{
    public partial class NewLayoutForm : Form
    {
        // TODO: This should be based on some save data that fetches
        // games from some directory of files.
        public int GamesCount { get; private set; } = 0;
        private AppData AppData { get; set; }
        private UserControl? CurrentScreenView { get; set; }

        public NewLayoutForm()
        {
            InitializeComponent();
            LoadAppData();
            CurrentScreenView = null;
            
            if (!AppData.Registered) {
                // If the user for the existing appdata is not registered display the
                // introductory view.
                UpdateScreenView(new NewUserView(this));
            }
            else {
                UpdateScreenView(new LibraryView(AppData));
            }
        }

        /// <summary>
        /// Load the appdata for flashback using the <see cref="DataManager"/>.
        /// </summary>
        private void LoadAppData()
        {
            AppData = DataManager.LoadAppData(DataManager.GetAppDataPath());
        }

        /// <summary>
        /// Update the current screenview by removing and disposing the old one
        /// to then display the new screenview.
        /// </summary>
        /// <param name="screenView"></param>
        private void UpdateScreenView(UserControl screenView)
        {
            // Remove and dispose the current screenview before updating.
            if (CurrentScreenView != null) { 
                screenViewPanel.Controls.Remove(CurrentScreenView);
                CurrentScreenView.Dispose();
            }
            // Update the current screenview.
            CurrentScreenView = screenView;
            CurrentScreenView.Dock = DockStyle.Fill;
            screenViewPanel.Controls.Add(CurrentScreenView);
        }

        /// <summary>
        /// Function call for the <see cref="NewUserView"/> when the confirm button is called.
        /// Loads Flashback's appdata and feed it to the libraryview.
        /// </summary>
        public void OpenLibrary()
        {
            LoadAppData();
            UpdateScreenView(new LibraryView(AppData));
        }
    }
}
