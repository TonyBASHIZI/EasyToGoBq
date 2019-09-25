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
            LblAlohaDynamics.Text = ClassGlossaire.Instance.getCommission();
            LblTransactions.Text = ClassGlossaire.Instance.getTransact();
            LblOpreration.Text = ClassGlossaire.Instance.getOperation();
            LblCompany.Text = ClassGlossaire.Instance.getCompagnieEtbq();
            ClassGlossaire.Instance.GetDatas(GridView, "*", "compte");
            
        }
    }
}
