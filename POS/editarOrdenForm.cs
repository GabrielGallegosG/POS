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
    public partial class editarOrdenForm : Form
    {
        public editarOrdenForm()
        {
            InitializeComponent();
           
            PLEditarOrden.posicionEditarOrden(empleadoLabel, empleadoOrdenLabel,tipoServicioLabel,noMesaLabel, fechaLabel,horaLabel, 
                                fechaOrdenLabel, horaOrdenLabel,tipoServicioComboBox,noMesaComboBox,agregarLabel,platilloCheckBox, 
                                postreCheckBox, bebidaCheckBox, comentariosLabel,comentariosRichTextBox, cancelarButton,guardarButton);

            PLEditarOrden.dataGridView(platillosDataGridView);
            PLEditarOrden.dataGridView(bebidasDataGridView);
            PLEditarOrden.dataGridView(postresDataGridView);
            PLEditarOrden.dataGridView_2(ordenDataGridView);
            PLEditarOrden.posicionrOrden(nombreElementoLabel, precioElementoLabel, cantidadElementoLabel, subtotalElementoLabel, totalLabel, totalElementosLabel, actualizarButton);

            ordenDataGridView.AutoResizeColumns();
        }

        private void cancelarButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
