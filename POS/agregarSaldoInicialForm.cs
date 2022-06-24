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
    public partial class agregarSaldoInicialForm : Form
    {
        public agregarSaldoInicialForm()
        {
            InitializeComponent();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            if (cantidadInicialTextBox.Text.Equals(""))
            {
                MessageBox.Show("¡No se ha ingresado el saldo inicial!", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    BLAgregarSaldo.agregarSaldoInicial(cantidadInicialTextBox.Text);
                    MessageBox.Show("¡Se ha guardado el saldo inicial con exito!", "Alta de Saldo Inicial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("¡Ha ocurrido un error al guardar el saldo inicial!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
