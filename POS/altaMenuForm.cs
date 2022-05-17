using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class altaMenuForm : Form
    {
        public altaMenuForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            agregarMenuForm frm = new agregarMenuForm();
            frm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            consultaMenuForm frm2 = new consultaMenuForm();
            frm2.Show();
        }
    }
}
