using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Eden
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            lbWelcome.Text += Config.name + " !";
            lbDateTime.Text = "";
            timerDateTime.Start();
        }

        #region EVENTS
        private void label_MouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            Styles.label_MouseEnter(label);
        }
        private void label_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            Styles.label_MouseLeave(label);
        }
        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            // Actualizar el texto del Label con la fecha y hora actual
            DateTime now = DateTime.Now;
            lbDateTime.Text = now.Day.ToString().PadLeft(2, '0') + "/" + now.Month.ToString().PadLeft(2, '0') + "/" + now.Year.ToString().PadLeft(2, '0') + " " + now.Hour.ToString().PadLeft(2, '0') + ":" + now.Minute.ToString().PadLeft(2, '0') + ":" + now.Second.ToString().PadLeft(2, '0');
        }
        private void lbClientes_Click(object sender, EventArgs e)
        {
            Forms.Clients.ClientsMenu clientsMenu = new Forms.Clients.ClientsMenu();
            this.Visible = false;
            clientsMenu.ShowDialog();
            this.Visible = true;
        }
        #endregion

        #region UPPER TOOL
        private void pnlUpperTool_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Permitir arrastrar el formulario
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // P/Invoke para permitir el arrastre del formulario
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LogIn logIn = new LogIn();
            logIn.ShowDialog();
        }
        #endregion

        private void MainMenu_VisibleChanged(object sender, EventArgs e)
        {
        }
    }
}
