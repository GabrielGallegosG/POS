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
    public partial class agregarOrdenForm : Form
    {
        public agregarOrdenForm()
        {
            InitializeComponent();

            PLAgregarOrden.posicionAgregarOrden(empleadoLabel,tipoServicioLabel,noMesaLabel,fechaLabel,horaLabel,tipoServicioComboBox,noMesaComboBox,
                agregarLabel,platilloCheckBox,postreCheckBox,bebidaCheckBox);
        }

        private void platilloCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
