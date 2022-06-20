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
        public DataGridViewButtonColumn GPla = new DataGridViewButtonColumn();
        public DataGridViewButtonColumn GBeb = new DataGridViewButtonColumn();
        public DataGridViewButtonColumn GPos = new DataGridViewButtonColumn();
        int pla = 0;
        int beb = 0;
        int pos = 0;
        public agregarOrdenForm()
        {
            InitializeComponent();

            PLAgregarOrden.posicionAgregarOrden(empleadoLabel, empleadoOrdenLabel, tipoServicioLabel, noMesaLabel, fechaLabel, horaLabel, fechaOrdenLabel, horaOrdenLabel, tipoServicioComboBox, noMesaComboBox,
                agregarLabel, platilloCheckBox, postreCheckBox, bebidaCheckBox, comentariosLabel, comentariosRichTextBox, cancelarButton, agregarButton);

            PLAgregarOrden.dataGridView(platillosDataGridView);
            PLAgregarOrden.dataGridView(bebidasDataGridView);
            PLAgregarOrden.dataGridView(postresDataGridView);
            PLAgregarOrden.dataGridView_2(ordenDataGridView);
        }

        private void agregarOrdenForm_Load(object sender, EventArgs e)
        {
            fechaOrdenLabel.Text = DateTime.Now.ToShortDateString();
            horaOrdenLabel.Text = DateTime.Now.ToShortTimeString();
        }

        private void ReadDataGrid(DataGridView dataGrid)
        {
            dataGrid.Columns[0].Width = 650;
            dataGrid.Columns[0].ReadOnly = true;
            dataGrid.Columns[1].Width = 120;
            dataGrid.Columns[1].ReadOnly = true;
            dataGrid.Columns[2].Width = 120;
            if (dataGrid.Rows.Count > 0)
            {
                foreach (DataGridViewColumn col in dataGrid.Columns)
                {
                    if (col.Name == "cantidad") col.ReadOnly = false;
                }
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void platilloCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (platilloCheckBox.Checked == true)
            {
                platillosDataGridView.Visible = true;
                bebidasDataGridView.Visible = false;
                postresDataGridView.Visible = false;

                bebidaCheckBox.Checked = false;
                postreCheckBox.Checked = false;

                
                if (pla == 0) {
                    //DataGridPlatillos

                    GPla.Name = "agregar";
                    GPla.Text = "Agregar";
                    GPla.HeaderText = "agregar";
                    GPla.FlatStyle = FlatStyle.Flat;
                    GPla.UseColumnTextForButtonValue = true;
                    platillosDataGridView.DataSource = BLConsultaElemento.PlatillosDT();

                    platillosDataGridView.Columns.Add("cantidad", "cantidad");
                    ReadDataGrid(platillosDataGridView);
                    platillosDataGridView.Columns.Add(GPla);
                    pla++;
                }
            }
        }
        
        private void bebidaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (bebidaCheckBox.Checked == true)
            {
                platillosDataGridView.Visible = false;
                bebidasDataGridView.Visible = true;
                postresDataGridView.Visible = false;

                platilloCheckBox.Checked = false;
                postreCheckBox.Checked = false;
                if (beb == 0)
                {
                    //DataGridBebidas
                    GBeb.Name = "agregar";
                    GBeb.Text = "Agregar";
                    GBeb.HeaderText = "agregar";
                    GBeb.FlatStyle = FlatStyle.Flat;
                    GBeb.UseColumnTextForButtonValue = true;
                    bebidasDataGridView.DataSource = BLConsultaElemento.BebidasDT();

                    bebidasDataGridView.Columns.Add("cantidad", "cantidad");
                    ReadDataGrid(bebidasDataGridView);

                    beb++;
                    bebidasDataGridView.Columns.Add(GBeb);
                }
            }
        }

        private void postreCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (postreCheckBox.Checked == true)
            {
                platillosDataGridView.Visible = false;
                bebidasDataGridView.Visible = false;
                postresDataGridView.Visible = true;

                platilloCheckBox.Checked = false;
                bebidaCheckBox.Checked = false;
                
                if (pos == 0)
                {
                    //DataGridPostres
                    GPos.Name = "agregar";
                    GPos.Text = "Agregar";
                    GPos.HeaderText = "agregar";
                    GPos.FlatStyle = FlatStyle.Flat;
                    GPos.UseColumnTextForButtonValue = true;
                    postresDataGridView.DataSource = BLConsultaElemento.PostresDT();

                    postresDataGridView.Columns.Add("cantidad", "cantidad");
                    ReadDataGrid(postresDataGridView);
                    postresDataGridView.Columns.Add(GPos);
                    pos++;
                }
                
            }
        }

        

        private void agregarButton_Click(object sender, EventArgs e)
        {
            try
            {
                int numMesa;
                numMesa = Convert.ToInt32(noMesaComboBox.Text);
                BLAgregarOrden.agregarOrden(tipoServicioComboBox.Text, numMesa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("¡Ha ocurrido un error al dar de alta la orden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewPlatillos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == platillosDataGridView.Columns.IndexOf(GPla))
            {
                platillosDataGridView.CurrentRow.Cells[e.ColumnIndex].Style.SelectionBackColor = Color.FromArgb(255, 205, 89);
                platillosDataGridView.CurrentRow.Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(255, 128, 0);
                platillosDataGridView.CurrentRow.Cells[e.ColumnIndex].Style.ForeColor = Color.White;
                platillosDataGridView.CurrentRow.Cells["cantidad"].Style.ForeColor = Color.FromArgb(255, 128, 0);
                platillosDataGridView.CurrentRow.Cells[e.ColumnIndex].Style.Font = new Font("Gadugi", 15, FontStyle.Bold);
                var box = "Platillo: " + platillosDataGridView.CurrentRow.Cells["nombre_elemento"].Value + "   Precio: " + platillosDataGridView.CurrentRow.Cells["precio"].Value;
                MessageBox.Show(box, "Agregando al carrito", MessageBoxButtons.OK);
            }
        }

        private void dataGridViewBebidas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == bebidasDataGridView.Columns.IndexOf(GBeb))
                {
                    
                        bebidasDataGridView.CurrentRow.Cells[e.ColumnIndex].Style.SelectionBackColor = Color.FromArgb(255, 205, 89);
                        bebidasDataGridView.CurrentRow.Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(255, 128, 0);
                        bebidasDataGridView.CurrentRow.Cells[e.ColumnIndex].Style.ForeColor = Color.White;
                        bebidasDataGridView.CurrentRow.Cells["cantidad"].Style.ForeColor = Color.FromArgb(255, 128, 0);
                        bebidasDataGridView.CurrentRow.Cells[e.ColumnIndex].Style.Font = new Font("Gadugi", 15, FontStyle.Bold);

                        var box = "Platillo: " + bebidasDataGridView.CurrentRow.Cells["nombre_elemento"].Value + "   Precio: " + bebidasDataGridView.CurrentRow.Cells["precio"].Value;
                        MessageBox.Show(box, "Agregando al carrito", MessageBoxButtons.OK);

                        int rowEscribir = ordenDataGridView.Rows.Count - 1;

                        ordenDataGridView.Rows.Add(1);

                        ordenDataGridView.Rows[rowEscribir].Cells[0].Value = bebidasDataGridView.CurrentRow.Cells["nombre_elemento"].Value;
                        ordenDataGridView.Rows[rowEscribir].Cells[1].Value = bebidasDataGridView.CurrentRow.Cells["precio"].Value;
                        ordenDataGridView.Rows[rowEscribir].Cells[2].Value = bebidasDataGridView.CurrentRow.Cells["precio"].Value;
                        ordenDataGridView.Rows[rowEscribir].Cells[4].Value = "$$.$$";
                }
            }
            catch {
                throw;
            }
        }

        private void dataGridViewPostres_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == postresDataGridView.Columns.IndexOf(GPos))
            {
                postresDataGridView.CurrentRow.Cells[e.ColumnIndex].Style.SelectionBackColor = Color.FromArgb(255, 205, 89);
                postresDataGridView.CurrentRow.Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(255, 128, 0);
                postresDataGridView.CurrentRow.Cells[e.ColumnIndex].Style.ForeColor = Color.White;
                postresDataGridView.CurrentRow.Cells["cantidad"].Style.ForeColor = Color.FromArgb(255, 128, 0);
                postresDataGridView.CurrentRow.Cells[e.ColumnIndex].Style.Font = new Font("Gadugi", 15, FontStyle.Bold);
                var box = "Platillo: " + postresDataGridView.CurrentRow.Cells["nombre_elemento"].Value + "   Precio: " + postresDataGridView.CurrentRow.Cells["precio"].Value;
                MessageBox.Show(box, "Agregando al carrito", MessageBoxButtons.OK);
            }
        }

        private void numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
    

