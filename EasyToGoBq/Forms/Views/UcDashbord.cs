using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyToGoBq.Classes;

namespace EasyToGoBq.Forms.Views
{
    public partial class UcDashbord : UserControl
    {
        public UcDashbord()
        {
            InitializeComponent();
        }

        private void UcDashbord_Load(object sender, EventArgs e)
        {
            LblAlohaDynamics.Text = Glossaire.Instance.getCommission();
            LblTransactions.Text = Glossaire.Instance.getTransact();
            LblOpreration.Text = Glossaire.Instance.getOperation();
            LblCompany.Text = Glossaire.Instance.getCompagnieEtbq();
            Glossaire.Instance.GetDatas(GridView, "designation,ref_compagnie,solde,etat", "compte");
            
        }

        private void PnlCountBord_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
