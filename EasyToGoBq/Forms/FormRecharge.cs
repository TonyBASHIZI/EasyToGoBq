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
    public partial class FormRecharge : Form
    {
        public FormRecharge()
        {
            InitializeComponent();
        }

        private void FormRecharge_Load(object sender, EventArgs e)
        {

        }

        private void RechargeControles_Click(object sender, EventArgs e)
        {
            switch (((Control)sender).Name.Substring(3))
            {
                case "Valider":
                    /// TODO : Function to search agent to recharge
                    break;

                case "Recharge":
                    /// TODO : Function to validate recharge
                    break;


                default:
                    break;
            }
        }
    }
}
