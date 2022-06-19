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
                agregarLabel,platilloCheckBox,postreCheckBox,bebidaCheckBox, comentariosLabel, comentariosRichTextBox,cancelarButton,agregarButton);

            PLAgregarOrden.dataGridView(platillosDataGridView);
            PLAgregarOrden.dataGridView(bebidasDataGridView);
            PLAgregarOrden.dataGridView(postresDataGridView);
        }

        private void agregarOrdenForm_Load(object sender, EventArgs e)
        {
            fechaOrdenLabel.Text = DateTime.Now.ToShortDateString();
            horaOrdenLabel.Text = DateTime.Now.ToShortTimeString();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void platilloCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (platilloCheckBox.Checked == true) {
                platillosDataGridView.Visible = true;
                bebidasDataGridView.Visible = false;
                postresDataGridView.Visible = false;
                
                platillosDataGridView.DataSource = BLConsultaElemento.PlatillosDT();
                
                bebidaCheckBox.Checked = false;
                postreCheckBox.Checked = false;
            }
        }

        private void postreCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (postreCheckBox.Checked == true)
            {
                platillosDataGridView.Visible = false;
                bebidasDataGridView.Visible = false;
                postresDataGridView.Visible = true;

                postresDataGridView.DataSource = BLConsultaElemento.PostresDT();

                platilloCheckBox.Checked = false;
                bebidaCheckBox.Checked = false;
            }
        }
        
        private void bebidaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (bebidaCheckBox.Checked == true)
            {
                platillosDataGridView.Visible = false;
                bebidasDataGridView.Visible = true;
                postresDataGridView.Visible = false;
                
                bebidasDataGridView.DataSource = BLConsultaElemento.BebidasDT();
                
                platilloCheckBox.Checked = false;
                postreCheckBox.Checked = false;
            }
        }

        private void tipoServicioComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void empleadoLabel_Click(object sender, EventArgs e)
        {

        }

        private void noMesaLabel_Click(object sender, EventArgs e)
        {

        }

        private void agregarLabel_Click(object sender, EventArgs e)
        {

        }

        private void noMesaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tipoServicioLabel_Click(object sender, EventArgs e)
        {

        }

        private void empleadoOrdenLabel_Click(object sender, EventArgs e)
        {

        }

        private void fechaLabel_Click(object sender, EventArgs e)
        {

        }

        private void fechaOrdenLabel_Click(object sender, EventArgs e)
        {

        }

        private void horaOrdenLabel_Click(object sender, EventArgs e)
        {

        }

        private void horaLabel_Click(object sender, EventArgs e)
        {

        }
        
        private void agregarButton_Click(object sender, EventArgs e)
        {
            try {
                int numMesa;
                numMesa = Convert.ToInt32(noMesaComboBox.Text);
                BLAgregarOrden.agregarOrden(tipoServicioComboBox.Text, numMesa);
            }
            catch (Exception ex) {
                MessageBox.Show("¡Ha ocurrido un error al dar de alta la orden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
