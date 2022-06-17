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
    public partial class consultarUsuariosForm : Form
    {
        public consultarUsuariosForm()
        {
            InitializeComponent();
            PLConsultarUsuarios.posicionEncabezado(inicioBbutton,menuButton,ordenesButton,ventasButton,usuariosButton);
            PLConsultarUsuarios.posicionConsultaUsuarios(logoPictureBox, encabezadoLabel,agregarUsuarioLabel,agregarUsuarioButton,
                consultaPanel,dataGridView,buscarPanel,usuarioLabel,editarUsuarioButton,eliminarUsuarioButton,buscarTextBox,buscarPictureBox);
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            consultaMenuForm frm = new consultaMenuForm();
            frm.Show();
        }

        private void ordenesButton_Click(object sender, EventArgs e)
        {
            consultarOrdenesForm frm = new consultarOrdenesForm();
            frm.Show();
        }

        private void usuariosButton_Click(object sender, EventArgs e)
        {
            consultarUsuariosForm frm = new consultarUsuariosForm();
            frm.Show();
        }

        private void eliminarUsuarioButton_Click(object sender, EventArgs e)
        {
            eliminarUsuarioForm frm = new eliminarUsuarioForm();
            frm.Show();
        }

        private void agregarUsuarioButton_Click(object sender, EventArgs e)
        {
            agregarUsuarioForm frm = new agregarUsuarioForm();
            frm.Show();
        }
    }
}
