﻿/*
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

            // TODO: Parse through all added games.
            if (appData.Games.Count > 0)
            {
                foreach (var game in appData.Games)
                {
                    SimpleGameLibraryButton simpleBtn = new SimpleGameLibraryButton(game);
                    simpleLibListFlowLayoutPanel.Controls.Add(simpleBtn);
                }
            }
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
