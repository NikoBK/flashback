using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flashback_emulator
{
    public partial class NewLayoutForm : Form
    {
        // TODO: This should be based on some save data that fetches
        // games from some directory of files.
        public int GamesCount { get; private set; } = 0;

        public NewLayoutForm()
        {
            InitializeComponent();

            // The app opens on the games library by default.
            libraryButton.Font = new Font(libraryButton.Font.Name, libraryButton.Font.Size, FontStyle.Bold);

            // Make sure to show an indication of no library games if there are none.
            libLabelNoGames.Visible = GamesCount < 1;
        }
    }
}
