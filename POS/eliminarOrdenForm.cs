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
    public partial class eliminarOrdenForm : Form
    {
        public eliminarOrdenForm()
        {
            InitializeComponent();
            PLEliminarOrden.posicionEliminarOrden(encabezadoPanel,encabezadoLabel,noOrdenLabel,noOrdenSeleccionadoLabel,tipoServicioLabel,servicioOrdenLabel,noMesaLabel,noMesaOrdenLabel,
                fechaLabel,fechaOrdenLabel,horaLabel,horaOrdenLabel,notaRichTextBox,cancelarButton,eliminarButton);
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
