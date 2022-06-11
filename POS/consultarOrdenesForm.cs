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
    public partial class consultarOrdenesForm : Form
    {
        public consultarOrdenesForm()
        {
            InitializeComponent();
            PLConsultaOrdenes.posicionEncabezado(inicioBbutton, menuButton, ordenesButton, ventasButton, usuariosButton);
            PLConsultaOrdenes.posisiconConsultaOrdenes(logoPictureBox, encabezadoLabel, nuevaOrdenLabel, agregarOrdenButton);
        }

        private void ordenesButton_Click(object sender, EventArgs e)
        {
            consultarOrdenesForm frm = new consultarOrdenesForm();
            frm.Show();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            consultaMenuForm frm = new consultaMenuForm();
            frm.Show();
        }

        private void agregarOrdenButton_Click(object sender, EventArgs e)
        {
            agregarOrdenForm frm = new agregarOrdenForm();
            frm.Show();
        }

        private void ventasButton_Click(object sender, EventArgs e)
        {
            eliminarOrdenForm frm = new eliminarOrdenForm();
            frm.Show();
        }

        private void usuariosButton_Click(object sender, EventArgs e)
        {
            editarOrdenForm frm = new editarOrdenForm();
            frm.Show();
        }
    }
}
