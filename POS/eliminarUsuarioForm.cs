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
    public partial class eliminarUsuarioForm : Form
    {
        int id_eliminar;
        string nombre_eliminar;
        string apellidoP_eliminar;
        string apellidoM_eliminar;
        consultarUsuariosForm frm = new consultarUsuariosForm();
        public eliminarUsuarioForm(int id, string nombre, string apellidoP, string apellidoM)
        {
            id_eliminar = id;
            nombre_eliminar = nombre;
            apellidoP_eliminar = apellidoP;
            apellidoM_eliminar = apellidoM;

            InitializeComponent();
            PLEliminarUsuario.posicionEliminarUsuario(encabezadoPanel,encabezadoLabel,idUsuarioLabel,idUsLabel,nombreLabel,nombreUsLabel,
                apellidoPaternoLabel,apellidoPLabel,apellidoMaternoLabel,apellidoMLabel,notaRichTextBox,cancelarButton,eliminarButton);
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(idUsLabel.Text);
                BLEliminarUsuario.EliminarUsuarioDT(id);
                MessageBox.Show("¡Se ha eliminado con exito!", "Eliminación de usuario con ID( " + id + " ).", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("¡Ha ocurrido un error al eliminar el usuario!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eliminarUsuarioForm_Load(object sender, EventArgs e)
        {
            ActiveControl = cancelarButton;
            String idUs = Convert.ToString(id_eliminar);
            idUsLabel.Text = idUs;
            nombreUsLabel.Text = nombre_eliminar;
            apellidoPLabel.Text = apellidoP_eliminar;
            apellidoMLabel.Text = apellidoM_eliminar;


        }
    }
}
