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
            PLConsultaOrdenes.posicionEncabezado(inicioBbutton, menuButton, ordenesButton, ventasButton, usuariosButton, ordenesDataGridView);
            PLConsultaOrdenes.posisiconConsultaOrdenes(logoPictureBox, encabezadoLabel, nuevaOrdenLabel, agregarOrdenButton);
            PLConsultaOrdenes.dataGridView(ordenesDataGridView);
            PLConsultaOrdenes.etiquetas(idLabel, noMesaLabel, servicioLabel, fechaLabel,horaLabel,totalLabel, estadoELabel, actualizarButton);
        }

        private void ordenesButton_Click(object sender, EventArgs e)
        {
            consultarOrdenesForm frmOrd = new consultarOrdenesForm();
            frmOrd.Close();
            this.Hide();
            consultarOrdenesForm frm = new consultarOrdenesForm();
            frm.Show();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            consultarOrdenesForm frmOrd = new consultarOrdenesForm();
            frmOrd.Close();
            this.Hide();
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
            consultarOrdenesForm frmOrd = new consultarOrdenesForm();
            frmOrd.Close();
            this.Hide();
            consultarVentas frm = new consultarVentas();
            frm.Show();
        }

        private void usuariosButton_Click(object sender, EventArgs e)
        {
            consultarOrdenesForm frmOrd = new consultarOrdenesForm();
            frmOrd.Close();
            this.Hide();
            consultarUsuariosForm frm = new consultarUsuariosForm();
            frm.Show();
        }

        private void inicioBbutton_Click(object sender, EventArgs e)
        {
            consultarOrdenesForm frmOrd = new consultarOrdenesForm();
            frmOrd.Close();
            this.Hide(); 
            inicioSaldosForm frm = new inicioSaldosForm();
            frm.Show();
        }

        private void consultarOrdenesForm_Load(object sender, EventArgs e)
        {
            ordenesDataGridView.DataSource = BLConsultarOrden.OrdenesDT();
        }

        private void actualizarButton_Click(object sender, EventArgs e)
        {
            ordenesDataGridView.DataSource = BLConsultarOrden.OrdenesDT();
        }
    }
}
