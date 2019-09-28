using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyToGoBq.Classes;

namespace EasyToGoBq.Forms
{
    public partial class FormListener : Form
    {
        public FormListener()
        {
            InitializeComponent();
        }

        private void FormListener_Load(object sender, EventArgs e)
        {

            lbope.Text  =  Glossaire.Instance.getOperation();
            lab500.Text = Glossaire.Instance.getOperas("500");
            lab1000.Text = Glossaire.Instance.getOperas("1000");

        }
    }
}
