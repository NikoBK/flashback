/*
*  File: LibraryView.cs 
*  Date: 12/02/2024
*  Author: NikoBK
*/
using flashback_emulator.UserControls.Components;

namespace flashback_emulator.UserControls
{
    public partial class LibraryView : UserControl
    {
        // Singleton pattern for the main form to do callbacks on button clicks so
        // that the screenview panel can be updated per button click.
        private static MainForm _mainForm { get; set; }

        public LibraryView(MainForm mainForm, AppData appData)
        {
            InitializeComponent();
            _mainForm = mainForm;
            libUsernameButton.Text = appData.Username.ToUpper();
            simpleLibListFlowLayoutPanel.AutoScroll = true;
            simpleLibListFlowLayoutPanel.HorizontalScroll.Enabled = false;
            simpleLibListFlowLayoutPanel.HorizontalScroll.Visible = false;
            simpleLibListFlowLayoutPanel.HorizontalScroll.Maximum = 0;
            simpleLibListFlowLayoutPanel.AutoScrollMinSize = new Size(0, 630);
            simpleLibListFlowLayoutPanel.WrapContents = false;

            // TODO: Parse through all added games.
            if (appData.Games.Count > 0)
            {
                foreach (var game in appData.Games)
                {
                    // Add the simple buttons in the left-most panel.
                    SimpleGameLibraryButton simpleBtn;
                    if (DataManager.Icons.ContainsKey(game.Id))
                    {
                        simpleBtn = new SimpleGameLibraryButton(_mainForm, game, DataManager.Icons[game.Id]);
                    }
                    else
                    {
                        simpleBtn = new SimpleGameLibraryButton(_mainForm, game);
                    }
                    simpleLibListFlowLayoutPanel.Controls.Add(simpleBtn);

                    // Add the artwork buttons.
                    LibraryGameArtBox artBtn;
                    if (DataManager.LibraryGrids.ContainsKey(game.Id))
                    {
                        artBtn = new LibraryGameArtBox(_mainForm, game, DataManager.LibraryGrids[game.Id]);
                    }
                    else
                    {
                        artBtn = new LibraryGameArtBox(_mainForm, game);
                    }
                    gamesFlowLayoutPanel.Controls.Add(artBtn);
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
