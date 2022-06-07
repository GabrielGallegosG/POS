using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace POS
{
    public partial class agregarMenuForm : Form
    {
        public agregarMenuForm()
        {
            InitializeComponent();
            PLAgregarMenuForm.posicionAgregarMenu(encabezadoPanel, encabezadoLabel, nombreLabel, nombreTextBox, seccionLabel, seccionComboBox, precioLabel, 
                                                  precioTextBox,descripcionLabel, descripcionRichTextBox, agregarButton,cancelarButton);
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
