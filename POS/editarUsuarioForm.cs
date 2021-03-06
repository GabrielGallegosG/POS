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
    public partial class editarUsuarioForm : Form
    {
        int id_editar, tipo_editar;
        string nombre_editar, apellidoP_editar, apellidoM_editar, usuario_editar, contraseña_editar, cargo_editar;
        consultarUsuariosForm frm = new consultarUsuariosForm();
        DataTable data = new DataTable();
        public editarUsuarioForm(int id, string nombre, string apellidoP, string apellidoM, int tipo, string cargo, string usuario, string contraseña)
        {
            id_editar = id;
            tipo_editar = tipo;
            nombre_editar = nombre;
            apellidoP_editar = apellidoP;
            apellidoM_editar = apellidoM;
            usuario_editar = usuario;
            contraseña_editar = contraseña;
            cargo_editar = cargo;

            InitializeComponent();
            frm.usuariosDataGridView.DataSource = BLConsultarUsuarios.UsuariosDT();
            PLEditarUsuario.posicionEditarUsuario(encabezadoLabel, idLabel, idUsuarioLabel, nombreLabel, nombreTextBox, apellidoPLabel, apellidoPTextBox, apellidoMLabel, apellidoMTextBox,
                usuarioLabel, usuarioTextBox, contraseñaLabel, contraseñaTextBox, tipoUsuarioLabel, tipoComboBox, cargoLabel, cargoTextBox, cancelarButton, guardarButton);
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editarUsuarioForm_Load(object sender, EventArgs e)
        {
            ActiveControl = nombreTextBox;
            idUsuarioLabel.Text = Convert.ToString(id_editar);
            nombreTextBox.Text = nombre_editar;
            apellidoPTextBox.Text = apellidoP_editar;
            apellidoMTextBox.Text = apellidoM_editar;
            usuarioTextBox.Text = usuario_editar;
            contraseñaTextBox.Text = contraseña_editar;
            tipoComboBox.SelectedIndex = tipo_editar;
            cargoTextBox.Text = cargo_editar;
        }

        private void guardarButton_Click(object sender, EventArgs e)
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
                        int cont = 0, idUs;
                        idUs = Convert.ToInt32(idUsuarioLabel.Text);
                        data = frm.usuariosDataGridView.DataSource as DataTable;
                        foreach (DataRow row in data.Rows)
                        {

                            if (usuarioTextBox.Text.Equals(row[6]) && idUs.Equals(row[0]) == false)
                                cont = 1;
                        }
                        if (cont == 1)
                    {
                            MessageBox.Show("¡Este usuario ya existe, por favor ingrese otro!", "Dato duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            usuarioTextBox.Text = "";
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

                                                string tipo = "";
                                                if (tipoComboBox.SelectedIndex == 0)
                                                    tipo = "0";
                                                else
                                                    if (tipoComboBox.SelectedIndex == 1)
                                                    tipo = "1";

                                                string nombre = nombreTextBox.Text;
                                                string apellidoP = apellidoPTextBox.Text;
                                                string apellidoM = apellidoMTextBox.Text;
                                                string usuario = usuarioTextBox.Text;
                                                string contraseña = contraseñaTextBox.Text;
                                                string cargo = cargoTextBox.Text;


                                                int id = Int32.Parse(idUsuarioLabel.Text);
                                                BLEditarUsuario.guardarEdicionDT(id, nombre, apellidoP, apellidoM, tipo, cargo, usuario, contraseña);
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
}
