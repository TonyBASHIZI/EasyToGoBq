using System;
using System.Drawing;
using System.Windows.Forms;
using EasyToGoBq.Classes;

namespace EasyToGoBq.Forms.Views
{
    public partial class UcReport : UserControl
    {
        private Form form = null;

        public UcReport()
        {
            InitializeComponent();
        }

        private void UcReport_Load(object sender, EventArgs e)
        {
            Glossaire.Instance.GetDatas(GridView, "*", "transaction");
        }


        /// <summary>
        /// Impression de repports
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ControleReport_Click(object sender, EventArgs e)
        {
            switch (((Control)sender).Name.Substring(3))
            {
                case "Transfert":
                    form = new FormReport(1);
                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                    break;

                case "Compte":
                    form = new FormReport(2);
                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                    break;

                default:
                    break;
            }
        }

        private void Menu_MouseEnter(object sender, EventArgs e)
        {
            switch (((Control)sender).Name.Substring(3))
            {
                case "Transfert":
                    LblTransfert.ForeColor = Color.FromArgb(85, 183, 20);
                    break;

                case "Compte":
                    LblCompte.ForeColor = Color.FromArgb(85, 183, 20);
                    break;

                default:
                    break;
            }
        }

        private void Menu_MouseLeave(object sender, EventArgs e)
        {
            switch (((Control)sender).Name.Substring(3))
            {
                case "Transfert":
                    LblTransfert.ForeColor = Color.FromArgb(14, 23, 22);
                    break;

                case "Compte":
                    LblCompte.ForeColor = Color.FromArgb(14, 23, 22);
                    break;

                default:
                    break;
            }
        }
    }
}
