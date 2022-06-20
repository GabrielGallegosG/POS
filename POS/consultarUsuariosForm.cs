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
        int id,tipo;
        string nombre, apellidoP, apellidoM, usuario, contraseña, cargo;
        public consultarUsuariosForm()
        {
            InitializeComponent();
            PLConsultarUsuarios.posicionEncabezado(inicioBbutton,menuButton,ordenesButton,ventasButton,usuariosButton);
            PLConsultarUsuarios.posicionConsultaUsuarios(logoPictureBox, encabezadoLabel,agregarUsuarioLabel,agregarUsuarioButton,
                consultaPanel,usuariosDataGridView,buscarPanel,usuarioLabel,editarUsuarioButton,eliminarUsuarioButton,buscarTextBox,buscarPictureBox);
            PLConsultarUsuarios.encabezadosTabla(idUsuarioLabel,nombreUsuarioLabel,apellidoPUsuarioLabel,apellidoMUsuarioLabel,cargoUsuarioLabel);
            PLConsultarUsuarios.dataGridView(usuariosDataGridView);

            var tt = new ToolTip();
            tt.SetToolTip(buscarTextBox, "Buscar usuario");
            tt.SetToolTip(eliminarUsuarioButton, "Eliminar usuario");
            tt.SetToolTip(editarUsuarioButton, "Modificar usuario");
            tt.SetToolTip(agregarUsuarioButton, "Agregar un nuevo usuario");

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            consultarUsuariosForm frmUs = new consultarUsuariosForm();
            frmUs.Close();
            this.Hide();
            consultaMenuForm frm = new consultaMenuForm();
            frm.Show();
        }

        private void ordenesButton_Click(object sender, EventArgs e)
        {
            consultarUsuariosForm frmUs = new consultarUsuariosForm();
            frmUs.Close();
            this.Hide();
            consultarOrdenesForm frm = new consultarOrdenesForm();
            frm.Show();
        }

        private void usuariosButton_Click(object sender, EventArgs e)
        {
            consultarUsuariosForm frmUs = new consultarUsuariosForm();
            frmUs.Close();
            this.Hide();
            consultarUsuariosForm frm = new consultarUsuariosForm();
            frm.Show();
        }

        private void eliminarUsuarioButton_Click(object sender, EventArgs e)
        {
            eliminarUsuarioForm frm = new eliminarUsuarioForm(id,nombre,apellidoP,apellidoM);
            frm.Show();
        }

        private void agregarUsuarioButton_Click(object sender, EventArgs e)
        {
            agregarUsuarioForm frm = new agregarUsuarioForm();
            frm.Show();
        }

        private void editarUsuarioButton_Click(object sender, EventArgs e)
        {           
            editarUsuarioForm frm = new editarUsuarioForm(id, nombre, apellidoP, apellidoM, tipo, cargo, usuario, contraseña);
            frm.Show();
        }

        private void consultarUsuariosForm_Load(object sender, EventArgs e)
        {
            ActiveControl = null;
            usuariosDataGridView.DataSource = BLConsultarUsuarios.UsuariosDT();
            usuariosDataGridView.Columns["usuario"].Visible = false;
            usuariosDataGridView.Columns["contraseña"].Visible = false;
            usuariosDataGridView.Columns["tipo_usuario"].Visible = false;
        }

        private void usuariosDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;
            usuarioLabel.Text = row.Cells[1].Value.ToString() +" " + row.Cells[2].Value.ToString() + " " + row.Cells[3].Value.ToString();
            
            id = Int32.Parse(row.Cells[0].Value.ToString());
            nombre = row.Cells[1].Value.ToString();
            apellidoP = row.Cells[2].Value.ToString();
            apellidoM = row.Cells[3].Value.ToString();
            tipo = Int32.Parse(row.Cells[4].Value.ToString());
            cargo = row.Cells[5].Value.ToString();
            usuario = row.Cells[6].Value.ToString();
            contraseña = row.Cells[7].Value.ToString();


        }

    }
}
