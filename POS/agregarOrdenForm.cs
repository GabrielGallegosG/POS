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

            PLAgregarOrden.posicionAgregarOrden(empleadoLabel,empleadoOrdenLabel,tipoServicioLabel,noMesaLabel,fechaLabel,horaLabel,fechaOrdenLabel,horaOrdenLabel,tipoServicioComboBox,noMesaComboBox,
                agregarLabel,platilloCheckBox,postreCheckBox,bebidaCheckBox);
        }

        private void agregarOrdenForm_Load(object sender, EventArgs e)
        {
            
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
