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
        public eliminarUsuarioForm()
        {
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

        }
    }
}
