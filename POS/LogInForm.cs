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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            PLLogIn.posicionLogin(encabezadoLabel, inicioSesionLabel, empleadoButton, administradorButton,contenedorPanel);
            PLLogIn.posicionPanel(usuarioLabel, usuarioTextBox, contraseñaLabel, contraseñaTextBox, iniciarSesionButton);
        }

        private void iniciarSesionButton_Click(object sender, EventArgs e)
        {
           consultaMenuForm frm = new consultaMenuForm();
            frm.Show();
        }

        private void empleadoButton_Click(object sender, EventArgs e)
        {
            contenedorPanel.Show();
        }

        private void administradorButton_Click(object sender, EventArgs e)
        {
            contenedorPanel.Show();
        }
    }
}