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
    public partial class consultarVentas : Form
    {
        public consultarVentas()
        {
            InitializeComponent();

            PLConsultarVentas.posicionEncabezado(inicioBbutton, menuButton, ordenesButton, ventasButton, usuariosButton);
            PLConsultarVentas.posicionConsultaMenu(logoPictureBox, encabezadoLabel, consultarVentasPanel, saldoInicialPanel, saldoFinalPanel,
                                                    consultVentasLabel, saldoInicialLabel, saldoFinalLabel, consultTabla, filtrarLabel, filtroComboBox,
                                                    datoBuscarLabel, datoBuscarComboBox);

        }

        //Botones encabezado
        private void ordenesButton_Click(object sender, EventArgs e)
        {
            inicioVentasForm inicioVentas = new inicioVentasForm();
            inicioVentas.Close();
            this.Hide();
            consultarOrdenesForm frm = new consultarOrdenesForm();
            frm.Show();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            inicioVentasForm inicioVentas = new inicioVentasForm();
            inicioVentas.Close();
            this.Hide();
            consultaMenuForm frm = new consultaMenuForm();
            frm.Show();
        }

        private void usuariosButton_Click(object sender, EventArgs e)
        {
            inicioVentasForm inicioVentas = new inicioVentasForm();
            inicioVentas.Close();
            this.Hide();
            consultarUsuariosForm frm = new consultarUsuariosForm();
            frm.Show();
        }

        private void ventasButton_Click(object sender, EventArgs e)
        {
            inicioVentasForm inicioVentas = new inicioVentasForm();
            inicioVentas.Close();
            this.Hide();
            inicioVentasForm frm = new inicioVentasForm();
            frm.Show();
        }

        private void saldoInicialPanel_Click(object sender, EventArgs e)
        {
            agregarSaldoInicialForm frm = new agregarSaldoInicialForm();
            frm.ShowDialog();
        }

        private void saldoFinalPanel_Click(object sender, EventArgs e)
        {
            agregarSaldoFinalForm frm = new agregarSaldoFinalForm();
            frm.ShowDialog();
        }
    }
}
