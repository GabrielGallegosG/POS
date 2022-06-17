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
    public partial class inicioForm : Form
    {
        public inicioForm()
        {
            InitializeComponent();
            PLInicio.posicionInicio(encabezadoLabel, agregarMenuLabel, consultaLabel, loginLabel);
        }

        private void agregarMenuLabel_Click(object sender, EventArgs e)
        {
            agregarMenuForm frm = new agregarMenuForm();
            frm.Show();
        }

        private void consultaLabel_Click(object sender, EventArgs e)
        {
            consultaMenuForm frm = new consultaMenuForm();
            frm.Show();
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            loginForm frm = new loginForm();
            frm.Show();
        }
    }
}
