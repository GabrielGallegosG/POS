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
            PLConsultarVentas.posicionConsultaMenu(logoPictureBox, encabezadoLabel, consultTabla, filtrarLabel, filtroComboBox,
                                                    datoBuscarLabel, textBox1);
            //PLConsultarVentas.dataGridView(consultTabla);
            consultTabla.AutoResizeColumns();
        }

        //Botones encabezado
        private void ordenesButton_Click(object sender, EventArgs e)
        {
            consultarVentas consultVentas = new consultarVentas();
            consultVentas.Close();
            this.Hide();
            consultarOrdenesForm frm = new consultarOrdenesForm();
            frm.Show();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            consultarVentas consultVentas = new consultarVentas();
            consultVentas.Close();
            this.Hide();
            consultaMenuForm frm = new consultaMenuForm();
            frm.Show();
        }

        private void usuariosButton_Click(object sender, EventArgs e)
        {
            consultarVentas consultVentas = new consultarVentas();
            consultVentas.Close();
            this.Hide();
            consultarUsuariosForm frm = new consultarUsuariosForm();
            frm.Show();
        }

        private void ventasButton_Click(object sender, EventArgs e)
        {
            consultarVentas consultVentas = new consultarVentas();
            consultVentas.Close();
            this.Hide();
            consultarVentas consultVentasfrm = new consultarVentas();
            consultVentasfrm.Show();
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

        private void consultarVentas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOS_BDDataSet.orden' table. You can move, or remove it, as needed.
            this.ordenTableAdapter.Fill(this.pOS_BDDataSet.orden);

        }

        private void inicioBbutton_Click(object sender, EventArgs e)
        {
            consultarVentas consultVentas = new consultarVentas();
            consultVentas.Close();
            this.Hide();
            inicioSaldosForm frm = new inicioSaldosForm();
            frm.Show();
        }

        private void filtroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*try
            {
                if (filtroComboBox.SelectedItem.Equals("Dia"))
                {
                    
                }
                else if (filtroComboBox.SelectedItem.Equals("Empleado"))
                {

                }
                else if (filtroComboBox.SelectedItem.Equals("Tipo de Servicio"))
                {

                }
                else if (filtroComboBox.SelectedItem.Equals("Tipo de Pago"))
                {

                }
            }
            catch (Exception e)
            {

            }*/
        }
    }
}
