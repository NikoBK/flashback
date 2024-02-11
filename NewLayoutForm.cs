/*
*  File: NewLayoutForm.cs 
*  Date: 11/02/2024
*  Author: NikoBK
*/
namespace flashback_emulator
{
    public partial class NewLayoutForm : Form
    {
        // TODO: This should be based on some save data that fetches
        // games from some directory of files.
        public int GamesCount { get; private set; } = 0;
        private AppData AppData { get; set; }

        public NewLayoutForm()
        {
            InitializeComponent();
            LoadAppData();
            
            if (!AppData.Registered) {
                // If the user for the existing appdata is not registered display the
                // introductory view.
                screenViewPanel.Controls.Add(new NewUserView());
            }
        }

        /// <summary>
        /// Load the appdata for flashback using the <see cref="DataManager"/>.
        /// </summary>
        private void LoadAppData()
        {
            AppData = DataManager.LoadAppData(DataManager.GetAppDataPath());
        }
    }
}
