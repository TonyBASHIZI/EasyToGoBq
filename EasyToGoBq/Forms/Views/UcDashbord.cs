using System;
using System.Windows.Forms;
using EasyToGoBq.Classes;

namespace EasyToGoBq.Forms.Views
{
    public partial class UcDashbord : UserControl
    {
        int cmpt = 0;
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
            LblCompany.Text = Glossaire.Instance.getSoldes();
            LblRecharge.Text = Glossaire.Instance.getTotalRecharge();
            LblCountEspritDeVie.Text = Glossaire.Instance.getAgence("ESPRIT DE VIE");
            LblCountTranskin.Text = Glossaire.Instance.getAgence("TRANSKIN");
            LblCountTranco.Text = Glossaire.Instance.getAgence("TRANSCO");

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

        private void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LblRecharge_Click(object sender, EventArgs e)
        {

        }

        private void timerDash_Tick(object sender, EventArgs e)
        {
            timerDash.Enabled = true;
            cmpt += 1;
            if(cmpt == 3000)
            {
                LblAlohaDynamics.Text = Glossaire.Instance.getCommission();
                LblTransactions.Text = Glossaire.Instance.getTransact();
                LblOpreration.Text = Glossaire.Instance.getOperation();
                LblCompany.Text = Glossaire.Instance.getSoldes();
                LblRecharge.Text = Glossaire.Instance.getTotalRecharge();
                LblCountEspritDeVie.Text = Glossaire.Instance.getAgence("ESPRIT DE VIE");
                LblCountTranskin.Text = Glossaire.Instance.getAgence("TRANSKIN");
                LblCountTranco.Text = Glossaire.Instance.getAgence("TRANSCO");

                Glossaire.Instance.GetDatas(GridView, "designation,ref_compagnie,solde,etat", "compte");

                cmpt = 0;
                     
            }

        }
    }
}
