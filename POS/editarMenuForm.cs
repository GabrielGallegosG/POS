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
    public partial class editarMenuForm : Form
    {
        public editarMenuForm()
        {
            InitializeComponent();
            PLEditarMenu.posicionEditarMenu(encabezadoPanel, encabezadoLabel, idLabel, idSeleccionadoLabel,nombreLabel, nombreTextBox, seccionLabel, seccionComboBox, precioLabel,
                                            precioTextBox, descripcionLabel, descripcionRichTextBox,guardarCambiosButton, cancelarButton);
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
