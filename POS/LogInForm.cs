﻿using System;
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
    public partial class loginForm : Form
    {
        consultarUsuariosForm frm = new consultarUsuariosForm();
        DataTable data = new DataTable();

        int us = 0, contra = 0;
        
        public loginForm()
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
            frm.usuariosDataGridView.DataSource = BLConsultarUsuarios.UsuariosDT();
            data = frm.usuariosDataGridView.DataSource as DataTable;

            foreach (DataRow row in data.Rows)
            {
                if (usuarioTextBox.Text.Equals(row[6]) && contraseñaTextBox.Text.Equals(row[7]))
                {
                    us = 1;
                    contra = 1;
                }
            }

            if (us == 1 && contra ==1)
            {
                loginForm logIn = new loginForm();
                logIn.Close();
                this.Hide();
                consultaMenuForm consultaMenu = new consultaMenuForm();
                consultaMenu.Show();
            }
            else
            {
                usuarioTextBox.Text = "";
                contraseñaTextBox.Text = "";
                MessageBox.Show("¡Usuario o contraseña incorrectos, intente nuevamente!", "Usuario o contraseña incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
