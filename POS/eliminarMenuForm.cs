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
    public partial class eliminarMenuForm : Form
    {
        public eliminarMenuForm()
        {
            InitializeComponent();
            PLEliminarMenu.posicionEliminarMenu(encabezadoPanel, encabezadoLabel, idLabel, idSeleccionadoLabel, nombreLabel,nombreSeleccionadoLabel, seccionLabel, seccionSeleccionadoLabel, precioLabel,
                                            precioSeleccionadoLabel, notaRichTextBox, cancelarButton, eliminarButton);
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
