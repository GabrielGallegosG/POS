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
    public partial class inicioSaldosForm : Form
    {
        public inicioSaldosForm()
        {
            InitializeComponent();
            PLInicioSaldos.posicionEncabezado(inicioBbutton, menuButton, ordenesButton, ventasButton, usuariosButton);
            PLInicioSaldos.posicionSaldosInicio(logoPictureBox, encabezadoLabel, saldoInicialPanel, saldoFinalPanel, saldoInicialLabel, saldoFinalLabel);
        }

        private void inicioBbutton_Click(object sender, EventArgs e)
        {
            inicioSaldosForm inicioSFrm = new inicioSaldosForm();
            inicioSFrm.Close();
            this.Hide();
            inicioSaldosForm frm = new inicioSaldosForm();
            frm.Show();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            inicioSaldosForm inicioSFrm = new inicioSaldosForm();
            inicioSFrm.Close();
            this.Hide();
            consultaMenuForm frm = new consultaMenuForm();
            frm.Show();
        }

        private void ordenesButton_Click(object sender, EventArgs e)
        {
            inicioSaldosForm inicioSFrm = new inicioSaldosForm();
            inicioSFrm.Close();
            this.Hide();
            consultarOrdenesForm frm = new consultarOrdenesForm();
            frm.Show();
        }

        private void ventasButton_Click(object sender, EventArgs e)
        {
            inicioSaldosForm inicioSFrm = new inicioSaldosForm();
            inicioSFrm.Close();
            this.Hide();
            consultarVentas consultVentasfrm = new consultarVentas();
            consultVentasfrm.Show();
        }

        private void usuariosButton_Click(object sender, EventArgs e)
        {
            inicioSaldosForm inicioSFrm = new inicioSaldosForm();
            inicioSFrm.Close();
            this.Hide();
            consultarUsuariosForm frm = new consultarUsuariosForm();
            frm.Show();
        }

        private void saldoInicialPanel_Click(object sender, EventArgs e)
        {
            agregarSaldoInicialForm SIfrm = new agregarSaldoInicialForm();
            SIfrm.ShowDialog();
        }

        private void saldoFinalPanel_Click(object sender, EventArgs e)
        {
            agregarSaldoFinalForm SFfrm = new agregarSaldoFinalForm();
            SFfrm.ShowDialog();
        }
    }
}
