using EasyToGoBq.Forms.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyToGoBq.Forms
{
    public partial class FormMain : Form
    {
        private UserControl uc = null;
        private Form form = null;

        public FormMain()
        {
            InitializeComponent();
            FormLogin lo = new FormLogin();
            lo.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            uc = new UcHome();
            LoadUserControles(uc);
            
        }

        /// <summary>
        /// Charge les User Control sur le Panel Main
        /// </summary>
        /// <param name="uc"></param>
        private void LoadUserControles(UserControl uc)
        {
            Cursor = Cursors.WaitCursor;
            PnlMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            PnlMain.Controls.Add(uc);
            uc.Show();

            if (uc.Visible == true)
            {
                Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Naviger dans différents User Control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NavigationControles_Click(object sender, EventArgs e)
        {
            switch (((Control)sender).Name.Substring(3))
            {
                case "Dashbord":
                    uc = new UcDashbord();
                    LoadUserControles(uc);
                    break;

                case "Report":
                    uc = new UcReport();
                    LoadUserControles(uc);
                    break;

                case "Settings":
                    //uc = new UcReport();
                    //LoadUserControles(uc);
                    break;

                case "User":
                    form = new FormLogin
                    {
                        Icon = Icon
                    };
                    form.ShowDialog();
                    break;

                default:
                    uc = new UcHome();
                    LoadUserControles(uc);
                    break;
            }
        }

        private void Menu_MouseEnter(object sender, EventArgs e)
        {
            switch (((Control)sender).Name.Substring(3))
            {
                case "Dashbord":
                    LblDashbord.ForeColor = Color.FromArgb(85, 183, 20);
                    break;

                case "Report":
                    LblReport.ForeColor = Color.FromArgb(85, 183, 20);
                    break;

                case "Settings":
                    LblSettings.ForeColor = Color.FromArgb(85, 183, 20);
                    break;

                default:
                    break;
            }
        }

        private void Menu_MouseLeave(object sender, EventArgs e)
        {
            switch (((Control)sender).Name.Substring(3))
            {
                case "Dashbord":
                    LblDashbord.ForeColor = Color.FromArgb(14, 23, 22);
                    break;

                case "Report":
                    LblReport.ForeColor = Color.FromArgb(14, 23, 22);
                    break;

                case "Settings":
                    LblSettings.ForeColor = Color.FromArgb(14, 23, 22);
                    break;

                default:
                    break;
            }
        }
    }
}
