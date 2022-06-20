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
    public partial class agregarUsuarioForm : Form
    {
        public agregarUsuarioForm()
        {
            InitializeComponent();
            PLAgregarUsuario.posicionAgregarUsuario(encabezadoLabel, nombreLabel, nombreTextBox, apellidoPLabel, apellidoPTextBox, apellidoMLabel, apellidoMTextBox,
                usuarioLabel, usuarioTextBox, contraseñaLabel, contraseñaTextBox, tipoUsuarioLabel, tipoComboBox, cargoLabel, cargoTextBox, cancelarButton, agregarButton);
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarUsuarioForm_Load(object sender, EventArgs e)
        {
            ActiveControl = nombreTextBox;
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text.Equals(""))
                MessageBox.Show("¡No se ha ingresado el nombre del usuario!", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (apellidoPTextBox.Text.Equals(""))
                {
                    MessageBox.Show("¡No se ha ingresado el apellido paterno del usuario!", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (apellidoMTextBox.Text.Equals(""))
                    {
                        MessageBox.Show("¡No se ha ingresado el apellido materno del usuario!", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (usuarioTextBox.Text.Equals(""))
                        {
                            MessageBox.Show("¡No se ha ingresado el usuario!", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (contraseñaTextBox.Text.Equals(""))
                            {
                                MessageBox.Show("¡No se ha ingresado la contraseña!", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                if (tipoComboBox.Text.Equals(""))
                                {
                                    MessageBox.Show("¡No se ha ingresado el tipo de usuario!", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    if (cargoTextBox.Text.Equals(""))
                                    {
                                        MessageBox.Show("¡No se ha ingresado el cargo del usuario!", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else
                                    {
                                        try
                                        {
                                            BLAgregarUsuario.agregarUsuario(nombreTextBox.Text, apellidoPTextBox.Text, apellidoMTextBox.Text, tipoComboBox.Text, cargoTextBox.Text, usuarioTextBox.Text, contraseñaTextBox.Text);
                                            MessageBox.Show("¡Se ha dado de alta con exito!", "Alta de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            this.Close();
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("¡Ha ocurrido un error al dar de alta a el usuario!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
