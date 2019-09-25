using EasyToGoBq.Classes;
using MySql.Data.MySqlClient;
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
    public partial class FormReport : Form
    {
        private MySqlConnection con = null;
        private MySqlCommand cmd = null;
        private Connection cnx;

        public FormReport(int index)
        {
            InitializeComponent();
            LoadReport(index);
        }

        public void InitializeConnection()
        {
            try
            {
                cnx = new Connection(); cnx.Connect();
                con = new MySqlConnection(cnx.path);

                if (!con.State.ToString().ToLower().Equals("open"))
                {
                    con.Open();
                }
            }
            catch (Exception)
            {
                throw new Exception("l'un de vos fichiers de configuration est incorrect");
            }

        }

        private void LoadReport(int index)
        {
            try
            {
                InitializeConnection();

                using (cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT designation,description,ref_compagnie,solde from compte";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter((MySqlCommand)cmd))
                    {
                        using (DataSet ds = new DataSet("DsFicheCompte"))
                        {
                            if (index == 1)
                            {
                                adapter.Fill(ds, "DsFicheCompte");

                                RptViewer.LocalReport.DataSources.Clear();
                                RptViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DsFicheCompte", ds.Tables[0]));
                                RptViewer.LocalReport.ReportEmbeddedResource = "EasyToGoBq.Reports.RptFicheTransfert.rdlc";
                                RptViewer.PrinterSettings.DefaultPageSettings.Landscape = false;
                                RptViewer.RefreshReport();
                            }
                            else if (index == 2)
                            {
                                adapter.Fill(ds, "DsFicheCompte");

                                RptViewer.LocalReport.DataSources.Clear();
                                RptViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DsFicheCompte", ds.Tables[0]));
                                RptViewer.LocalReport.ReportEmbeddedResource = "EasyToGoBq.Reports.RptFicheCompte.rdlc";
                                RptViewer.PrinterSettings.DefaultPageSettings.Landscape = false;
                                RptViewer.RefreshReport();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Une erreur s'est produite lors du chargement du rapport. \n ERROR : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            this.RptViewer.RefreshReport();
        }
    }
}
