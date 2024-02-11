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
    public partial class NewUserView : UserControl
    {
        public NewUserView()
        {
            InitializeComponent();
            invalidUsernameLabel.Visible = false;
        }

        private void introExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void introUsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            invalidUsernameLabel.Visible = false;
        }

        private void introConfirmButton_Click(object sender, EventArgs e)
        {
            introConfirmButton.Enabled = false;

            // Make sure a username is selected.
            if (string.IsNullOrEmpty(introUsernameTextBox.Text)) {
                invalidUsernameLabel.Visible = true;
                introConfirmButton.Enabled = true;
                return;
            }

            // Save the username through the DataManager.
            DataManager.SaveUsername(introUsernameTextBox.Text);
        }
    }
}
