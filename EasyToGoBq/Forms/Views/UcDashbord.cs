using System;
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
    }
}
