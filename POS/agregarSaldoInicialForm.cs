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
                MessageBox.Show("¡No se ha ingresado el nombre del elemento!", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    /*BLAgregarElemento.agregarElemento(nombreTextBox.Text, seccionComboBox.Text, precio, descripcionRichTextBox.Text);
                    MessageBox.Show("¡Se ha dado de alta con exito!", "Alta de elemento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();*/

                }
                catch (Exception ex)
                {
                    MessageBox.Show("¡Ha ocurrido un error al guardar el saldo inicial!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
