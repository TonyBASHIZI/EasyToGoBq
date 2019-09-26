using System;
using System.Windows.Forms;
using EasyToGoBq.Classes;

namespace EasyToGoBq.Forms.Views
{
    public partial class UcDashbord : UserControl
    {
        private Form form = null;

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

        private void LoadForms_Click(object sender, EventArgs e)
        {
            switch (((Control)sender).Name.Substring(3))
            {
                case "Operation":

                    break;
                default:
                    break;
            }
        }
    }
}
