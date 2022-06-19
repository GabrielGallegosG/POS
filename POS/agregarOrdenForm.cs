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
    public partial class agregarOrdenForm : Form
    {
        public agregarOrdenForm()
        {
            InitializeComponent();

            PLAgregarOrden.posicionAgregarOrden(empleadoLabel,empleadoOrdenLabel,tipoServicioLabel,noMesaLabel,fechaLabel,horaLabel,fechaOrdenLabel,horaOrdenLabel,tipoServicioComboBox,noMesaComboBox,
                agregarLabel,platilloCheckBox,postreCheckBox,bebidaCheckBox);
        }

        private void agregarOrdenForm_Load(object sender, EventArgs e)
        {
            fechaOrdenLabel.Text = DateTime.Now.ToShortDateString();
            horaOrdenLabel.Text = DateTime.Now.ToShortTimeString();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            try {
                int numMesa;
                numMesa = Convert.ToInt32(noMesaComboBox.Text);
                BLAgregarOrden.agregarOrden(tipoServicioComboBox.Text, numMesa);
            }
            catch (Exception ex) {
                MessageBox.Show("¡Ha ocurrido un error al dar de alta la orden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
