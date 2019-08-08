using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceTool2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// calls pagesbtnEventHandler to toggle selected page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            string pageTitle = "Dashboard";
            pagesBtnEventHandler(sender, pageTitle);
        }
        /// <summary>
        /// calls pagesbtnEventHandler to toggle selected page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBudgetTool_Click(object sender, EventArgs e)
        {
            string pageTitle = "Budget Tool";
            pagesBtnEventHandler(sender, pageTitle);
        }
        /// <summary>
        /// calls pagesbtnEventHandler to toggle selected page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnInvestmentCalc_Click(object sender, EventArgs e)
        {
            string pageTitle = "Investment Calculator";
            pagesBtnEventHandler(sender, pageTitle);
        }
        /// <summary>
        /// Handles select events, changing Header title and toggling
        /// on appropriate page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="pageTitle"></param>
        public void pagesBtnEventHandler(object sender, string pageTitle)
        {
            this.lblHeader.Text = pageTitle;
        }
    }
}
