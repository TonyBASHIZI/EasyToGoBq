using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using EasyToGoBq.Classes;
=======
>>>>>>> ab255756f7385a16265ac778b9199dfb1ae78ece

namespace EasyToGoBq.Forms
{
    public partial class FormRecharge : Form
    {
        public FormRecharge()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void initial()
        {
            TxtMatricule.Text = "";
            TxtNom.Text = "";
            TxtPostnom.Text = "";
            TxtPrenom.Text = "";
            TxtRecherche.Text = "";
            TxtSolde.Text = "";
            TxtEmail.Text = "";
            TxtAdresse.Text = "";
            
        }

        private void FormRecharge_Load(object sender, EventArgs e)
        {
            Glossaire.Instance.GetDatas(GridView, "matricule,nom,postnom,prenom,tel,email,adresse,solde", "agent");
            
=======
        private void FormRecharge_Load(object sender, EventArgs e)
        {

>>>>>>> ab255756f7385a16265ac778b9199dfb1ae78ece
        }

        private void RechargeControles_Click(object sender, EventArgs e)
        {
            switch (((Control)sender).Name.Substring(3))
            {
                case "Valider":
                    /// TODO : Function to search agent to recharge
<<<<<<< HEAD
                    Glossaire.Instance.Recherche(GridView, TxtRecherche.Text);
=======
>>>>>>> ab255756f7385a16265ac778b9199dfb1ae78ece
                    break;

                case "Recharge":
                    /// TODO : Function to validate recharge
<<<<<<< HEAD
                    Glossaire.Instance.Recharge(TxtMatricule.Text, TxtSolde.Text);
                    Glossaire.Instance.GetDatas(GridView, "matricule,nom,postnom,prenom,tel,email,adresse,solde", "agent");
                    initial();
=======
>>>>>>> ab255756f7385a16265ac778b9199dfb1ae78ece
                    break;


                default:
                    break;
            }
        }
<<<<<<< HEAD

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            TxtMatricule.Text = GridView.SelectedRows[0].Cells["matricule"].Value.ToString();
            TxtPostnom.Text = GridView.SelectedRows[0].Cells["postnom"].Value.ToString();
            TxtNom.Text = GridView.SelectedRows[0].Cells["nom"].Value.ToString();
            TxtPrenom.Text = GridView.SelectedRows[0].Cells["prenom"].Value.ToString();
            TxtAdresse.Text = GridView.SelectedRows[0].Cells["adresse"].Value.ToString();
            TxtTelephone.Text = GridView.SelectedRows[0].Cells["tel"].Value.ToString();
            TxtEmail.Text = GridView.SelectedRows[0].Cells["email"].Value.ToString();
            TxtSolde.Text = GridView.SelectedRows[0].Cells["solde"].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Glossaire.Instance.GetDatas(GridView, "matricule,nom,postnom,prenom,tel,email,adresse,solde", "agent");
        }
=======
>>>>>>> ab255756f7385a16265ac778b9199dfb1ae78ece
    }
}
