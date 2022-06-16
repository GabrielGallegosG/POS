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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            PLLogIn.posicionLogin(encabezadoPanel,encabezadoLabel, inicioSesionLabel, empleadoButton, administradorButton,contenedorPanel);
            PLLogIn.posicionPanel(usuarioLabel, usuarioTextBox, contraseñaLabel, contraseñaTextBox, iniciarSesionButton);
        }

       
        private void empleadoButton_Click_1(object sender, EventArgs e)
        {
            iniciarSesionButton.BackColor = Color.DodgerBlue;
           contenedorPanel.Show();
        }

        private void administradorButton_Click(object sender, EventArgs e)
        {
            iniciarSesionButton.BackColor = Color.FromArgb(0, 87, 158);
           contenedorPanel.Show();
        }

        private void iniciarSesionButton_Click_1(object sender, EventArgs e)
        {
            LogInForm logIn = new LogInForm();
            logIn.Close();
            this.Hide();
            consultaMenuForm consultaMenu = new consultaMenuForm();
            consultaMenu.Show();
            /*consultarUsuariosForm consultaUsuario = new consultarUsuariosForm();
            consultaUsuario.Show(); */
        }
    }
}
