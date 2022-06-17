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
        public editarUsuarioForm()
        {
            InitializeComponent();
            PLEditarUsuario.posicionEditarUsuario(encabezadoLabel,idLabel,idUsuarioLabel,nombreLabel, nombreTextBox, apellidoPLabel, apellidoPTextBox, apellidoMLabel, apellidoMTextBox,
                usuarioLabel, usuarioTextBox, contraseñaLabel, contraseñaTextBox, tipoUsuarioLabel, tipoComboBox, cargoLabel, cargoTextBox, cancelarButton, guardarButton);
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editarUsuarioForm_Load(object sender, EventArgs e)
        {
            ActiveControl = nombreTextBox;
        }
    }
}
