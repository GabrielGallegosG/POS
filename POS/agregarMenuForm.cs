using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace POS
{
    public partial class agregarMenuForm : Form
    {
        public agregarMenuForm()
        {
            InitializeComponent();
            PLAgregarMenuForm.posicionAgregarMenu(encabezadoPanel, encabezadoLabel, nombreLabel, nombreTextBox, seccionLabel, seccionComboBox, precioLabel, 
                                                  precioTextBox,descripcionLabel, descripcionRichTextBox, agregarButton,cancelarButton);
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text.Equals(""))
            {
                MessageBox.Show("¡No se ha ingresado el nombre del elemento!", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                if (seccionComboBox.Text.Equals(""))
                {
                    MessageBox.Show("¡No se ha ingresado la sección del elemento!", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    if (precioTextBox.Text.Equals(""))
                    {
                        MessageBox.Show("¡No se ha ingresado el precio del elemento!", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else {
                        double precio;
                        precio = Convert.ToDouble(precioTextBox.Text);
                        try
                        {
                            BLAgregarElemento.agregarElemento(nombreTextBox.Text, seccionComboBox.Text, precio, descripcionRichTextBox.Text);
                            MessageBox.Show("¡Se ha dado de alta con exito!", "Alta de elemento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch(Exception ex) {
                            MessageBox.Show("¡Ha ocurrido un error al dar de alta el elemento!", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        } 
                    }
                }
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
