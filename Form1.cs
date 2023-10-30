using System.Diagnostics;
using System.Runtime.InteropServices;

namespace flashback_emulator
{
    public partial class Form1 : Form
    {
        public string BasePath { get; private set; }
        public string ResourcePath { get; private set; }

        // Fields
        private int borderSize = 2;

        // Constructor
        public Form1()
        {
            InitializeComponent();
            BasePath = Path.Combine(Environment.CurrentDirectory);
            ResourcePath = $"{BasePath}/res";
            this.Padding = new Padding(borderSize); // Border size
            this.BackColor = Color.FromArgb(36, 40, 47); // Border color
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
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }
    }
}