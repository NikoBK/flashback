﻿using System;
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

            screenViewPanel.Controls.Add(new NewUserView());
        }
    }
}
