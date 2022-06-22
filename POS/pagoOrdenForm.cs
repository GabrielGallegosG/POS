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
    public partial class pagoOrdenForm : Form
    {
        public pagoOrdenForm()
        {
            InitializeComponent();
            this.Size = new Size(560, 520);
            PLPagoOrden.datosPago(noOrdenLabel, ordenLabel, montoPagarLabel, montoLabel);
            PLPagoOrden.metodoPago(metodoPagoLabel, efectivoCheckBox,tarjetaCheckBox,
                            efectivoTextBox,tarjetaTextBox,saldoFavorLabel,divisionLabel, saldoFavorClienteLabel);
            PLPagoOrden.botonesPago(masTardeButton, ahoraButton);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ahoraButton_Click(object sender, EventArgs e)
        {

        }

        private void tarjetaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tarjetaCheckBox.Checked)
            {
                tarjetaTextBox.Enabled = true;
            }
            else
                tarjetaTextBox.Enabled = false;
        }

        private void efectivoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (efectivoCheckBox.Checked) {
                efectivoTextBox.Enabled = true;
            }else
                efectivoTextBox.Enabled = false;
        }

        private void masTardeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
