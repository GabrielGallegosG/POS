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
    public partial class editarMenuForm : Form
    {
        string id_editar;
        string nombre_editar;
        string precio_editar;
        string descripcion_editar;
        int seccion_editar;
        public editarMenuForm(string id, string nombre, string precio, int seccion,string descripcion)
        {
            id_editar = id;
            nombre_editar = nombre;
            precio_editar = precio;
            seccion_editar = seccion;
            descripcion_editar = descripcion;
            InitializeComponent();
            PLEditarMenu.posicionEditarMenu(encabezadoPanel, encabezadoLabel, idLabel, idSeleccionadoLabel,nombreLabel, nombreTextBox, seccionLabel, seccionComboBox, precioLabel,
                                            precioTextBox, descripcionLabel, descripcionRichTextBox,guardarButton, cancelarButton);
        }

        private void cancelarButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editarMenuForm_Load(object sender, EventArgs e)
        {
            idSeleccionadoLabel.Text = id_editar;
            nombreTextBox.Text = nombre_editar;
            precioTextBox.Text = precio_editar;
            descripcionRichTextBox.Text = descripcion_editar;
            seccionComboBox.SelectedIndex = seccion_editar;
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text.Equals(""))
            {
                MessageBox.Show("¡No se ha ingresado el nombre del elemento!", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (seccionComboBox.Text.Equals(""))
                {
                    MessageBox.Show("¡No se ha ingresado la sección del elemento!", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (precioTextBox.Text.Equals(""))
                    {
                        MessageBox.Show("¡No se ha ingresado el precio del elemento!", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        try
                        {
                           string seccion = "";
                            if (seccionComboBox.SelectedIndex == 0)
                                seccion = "1";
                            else
                                if (seccionComboBox.SelectedIndex == 1)
                                    seccion = "2";
                                else
                                    if (seccionComboBox.SelectedIndex == 2)
                                        seccion = "3";
                            
                            string descripcion = descripcionRichTextBox.Text;
                            
                            string nombre = nombreTextBox.Text;
                            string precio = precioTextBox.Text;
                            
                            int id = Int32.Parse(idSeleccionadoLabel.Text);
                            BLEditarElemento.guardarEdicionDT(id, nombre, seccion, descripcion, precio );
                            this.Close();


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("¡Ha ocurrido un error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
