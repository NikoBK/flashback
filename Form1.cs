using System.Diagnostics;
using System.Runtime.InteropServices;

namespace flashback_emulator
{
    // Some of the UI is based on this tutorial:
    // https://www.youtube.com/watch?v=N5oZnV3cA64

    public partial class Form1 : Form
    {
        public string BasePath { get; private set; }
        public string ResourcePath { get; private set; }

        // Fields
        private int borderSize = 2;

        // Games collection
        public Dictionary<string, Game> Games { get; private set; }

        // Constructor
        public Form1()
        {
            InitializeComponent();
            BasePath = Path.Combine(Environment.CurrentDirectory);
            ResourcePath = $"{BasePath}/res";
            this.Padding = new Padding(borderSize); // Border size
            this.BackColor = Color.FromArgb(36, 40, 47); // Border color
            Games = new Dictionary<string, Game>();
            GameLibrary.LoadGames();
            Games = GameLibrary.GetGames();
            int spaceX = 129 + 15;
            int spaceY = 196 + 15;
            int lastPosX = 6;
            int lastPosY = 6;
            int count = 0;

            foreach (var game in Games.Values)
            {
                var img = Directory.GetFiles($"{ResourcePath}/img/", $"{game.Id}.png");
                if (img.Length == 0)
                {
                    img = Directory.GetFiles($"{ResourcePath}/img/", "default.png");
                }

                var pic = new PictureBox
                {
                    Name = $"pictureBox{game.Id}",
                    Size = new Size(129, 196),
                    Location = new Point(lastPosX, lastPosY),
                    Image = new Bitmap(img[0]),
                    BackColor = Color.Black,
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                count++;
                lastPosX += spaceX;
                if (count > 5)
                {
                    lastPosY += spaceY;
                    lastPosX = 6;
                    count = 0;
                }
                panelDesktop.Controls.Add(pic);
            }
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void RunGame(string gameName)
        {
            string projector = $"{ResourcePath}\\flashplayer_projector.exe";
            string game_path = $"{ResourcePath}/games/{gameName}.swf";
            var pi = new ProcessStartInfo(game_path)
            {
                Arguments = Path.GetFileName(game_path),
                UseShellExecute = true,
                WorkingDirectory = Path.GetDirectoryName(game_path),
                FileName = projector,
                Verb = "OPEN"
            };
            Process.Start(pi);
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Overriden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;

            const int WM_NCHITTEST = 0x0084;
            const int resizeAreaSize = 10;
            const int HTCLIENT = 1;
            const int HTLEFT = 10;
            const int HTRIGHT = 11;
            const int HTTOP = 12;
            const int HTTOPLEFT = 13;
            const int HTTOPRIGHT = 14;
            const int HTBOTTOM = 15;
            const int HTBOTTOMLEFT = 16;
            const int HTBOTTOMRIGHT = 17;

            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)
                {
                    if ((int)m.Result == HTCLIENT)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = this.PointToClient(screenPoint);

                        if (clientPoint.Y <= resizeAreaSize)
                        {
                            if (clientPoint.X <= resizeAreaSize)
                            {
                                m.Result = (IntPtr)HTTOPLEFT;
                            }
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))
                            {
                                m.Result = (IntPtr)HTTOP;
                            }
                            else
                            {
                                m.Result = (IntPtr)HTTOPRIGHT;
                            }
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize))
                        {
                            if (clientPoint.X <= resizeAreaSize)
                            {
                                m.Result = (IntPtr)HTLEFT;
                            }
                            else if (clientPoint.X > (this.Width - resizeAreaSize))
                            {
                                m.Result = (IntPtr)HTRIGHT;
                            }
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)
                            {
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            }
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))
                            {
                                m.Result = (IntPtr)HTBOTTOM;
                            }
                            else
                            {
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                            }
                        }
                    }
                }
                return;
            }

            // Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        // Event calls
        private void Form1_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        // Private functions
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                    {
                        this.Padding = new Padding(borderSize);
                    }
                    break;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenuToggle_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200)
            { // Collapse Menu
                btnMenuToggle.Text = "SHOW";
                panelMenu.Width = 100;
                pictureBoxPfp.Visible = false;
                btnMenuToggle.Dock = DockStyle.Top;
                foreach (Button btn in panelMenu.Controls.OfType<Button>())
                {
                    btn.Text = btn.Text.Substring(0, 1);
                    btn.ImageAlign = ContentAlignment.MiddleCenter;
                    btn.Padding = new Padding(0);
                }
            }
            else
            { // Expand menu 
                btnMenuToggle.Text = "HIDE";
                panelMenu.Width = 230;
                pictureBoxPfp.Visible = true;
                btnMenuToggle.Dock = DockStyle.None;
                foreach (Button btn in panelMenu.Controls.OfType<Button>())
                {
                    btn.Text = btn.Tag.ToString();
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                    btn.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }
    }
}