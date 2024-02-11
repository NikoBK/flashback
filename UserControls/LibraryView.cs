using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flashback_emulator.UserControls
{
    public partial class LibraryView : UserControl
    {
        public LibraryView(AppData appData)
        {
            InitializeComponent();
            libUsernameButton.Text = appData.Username.ToUpper();
        }
    }
}
