
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;

namespace EasyToGoBq.Classes
{
    class ClassGlossaire
    {
        MySqlConnection con = null;
        MySqlCommand cmd = null;
        Connection cnx;
        MySqlDataAdapter dt = null;
        MySqlDataReader dr = null;
        MySqlDataAdapter adpr = null;
        DataSet dste;
        private string server;
        private string database;
        private string uid;
        private string password;

        private string port;
        // private string str, code_isn;
        private static ClassGlossaire _instance = null;
        public static ClassGlossaire Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ClassGlossaire();
                return _instance;
            }
        }

        #region Common

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


        private void SetParameter(IDbCommand cmd, string name, DbType type, int length, object value)
        {
            IDbDataParameter param = cmd.CreateParameter();

            param.ParameterName = name;
            param.DbType = type;
            param.Size = length;

            if (value == null)
            {
                if (!param.IsNullable)
                {
                    param.DbType = DbType.String;
                }

                param.Value = DBNull.Value;
            }
            else
            {
                param.Value = value;
            }

            cmd.Parameters.Add(param);
        }

        public void GetDatas(DataGridView grid, string field, string table)
        {
            InitializeConnection();

            try
            {
                using (cmd = con.CreateCommand())
                {
                    cmd.CommandText = " SELECT " + field + " FROM " + table + " ORDER BY id DESC ";
                    dt = new MySqlDataAdapter((MySqlCommand)cmd);
                    DataSet ds = new DataSet();
                    dt.Fill(ds);
                    grid.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        public void GetCombosData(ComboBox combo, string field, string table)
        {
            combo.Items.Clear();

            InitializeConnection();

            try
            {
                using (cmd = con.CreateCommand())
                {
                    cmd.CommandText = " SELECT " + field + " FROM " + table;

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        combo.Items.Add(dr[field]).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Dispose();
            }
        }
        public string getCommission()
        {

            string c = "";
            try
            {

                InitializeConnection();

                string q = "select SUM(commission) as nb from transaction";
                cmd = new MySqlCommand(q, con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = dr.GetString("nb");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }


            return c;
        }
        public string getTransact()
        {

            string c = "";
            try
            {

                InitializeConnection();

                string q = "select SUM(fraisTransact) as nb from transaction";
                cmd = new MySqlCommand(q, con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = dr.GetString("nb");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }


            return c;
        }
        public string getOperation()
        {

            string c = "";
            try
            {

                InitializeConnection();

                string q = "select SUM(montant) as nb from transaction";
                cmd = new MySqlCommand(q, con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = dr.GetString("nb");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }


            return c;
        }
        public string getCompagnieEtbq()
        {

            string c = "";
            try
            {

                InitializeConnection();

                string q = "select SUM(solde) as nb from compte";
                cmd = new MySqlCommand(q, con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = dr.GetString("nb");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }


            return c;
        }
        public Boolean LoginTest(string username, string password)
        {
            Boolean b = false;

            try
            {
                InitializeConnection();

                cmd = new MySqlCommand("SELECT noms,mot_de_passe  FROM banque where noms ='" + username + "' AND mot_de_passe = '" + password + "'", con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    b = true;
                }

                if (b == true)
                {
                  
                    b = true;

                }
                else
                {
                    MessageBox.Show("Echec de Connexion mot de passe ou utilisateur introuvable");
                    b = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return b;
        }
        #endregion
    }
}