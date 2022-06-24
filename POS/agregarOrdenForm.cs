using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        public DataGridViewButtonColumn GOrd = new DataGridViewButtonColumn();
        int pla = 0;
        int beb = 0;
        int pos = 0;
        int ord = 0;

        public agregarOrdenForm()
        {
            InitializeComponent();

            PLAgregarOrden.posicionAgregarOrden(empleadoLabel, empleadoOrdenLabel, tipoServicioLabel, noMesaLabel, fechaLabel, horaLabel, fechaOrdenLabel, horaOrdenLabel, tipoServicioComboBox, noMesaComboBox,
                agregarLabel, platilloCheckBox, postreCheckBox, bebidaCheckBox, comentariosLabel, comentariosRichTextBox, cancelarButton, agregarButton);

            PLAgregarOrden.dataGridView(platillosDataGridView);
            PLAgregarOrden.dataGridView(bebidasDataGridView);
            PLAgregarOrden.dataGridView(postresDataGridView);
            PLAgregarOrden.dataGridView_2(ordenDataGridView);
            PLAgregarOrden.posicionrOrden(nombreElementoLabel, precioElementoLabel, cantidadElementoLabel, subtotalElementoLabel, totalLabel, totalElementosLabel, actualizarButton);

            ordenDataGridView.AutoResizeColumns();
        }

        private void agregarOrdenForm_Load(object sender, EventArgs e)
        {
            fechaOrdenLabel.Text = DateTime.Now.ToShortDateString();
            horaOrdenLabel.Text = DateTime.Now.ToShortTimeString();
        }

        private void ReadDataGrid(DataGridView dataGrid)
        {
            dataGrid.Columns[0].Width = 500;
            dataGrid.Columns[0].ReadOnly = true;
            dataGrid.Columns[1].Width = 70;
            dataGrid.Columns[1].ReadOnly = true;
            dataGrid.Columns[2].Width = 70;
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


                if (pla == 0)
                {
                    //DataGridPlatillos

                    GPla.Name = "agregar";
                    GPla.Text = "Agregar";
                    GPla.HeaderText = "agregar";
                    GPla.FlatStyle = FlatStyle.Flat;
                    GPla.UseColumnTextForButtonValue = true;
                    platillosDataGridView.DataSource = BLConsultaElemento.PlatillosDT();

                    platillosDataGridView.Columns.Add("cantidad", "cantidad");
                    ReadDataGrid(platillosDataGridView);

                    platillosDataGridView.Sort(platillosDataGridView.Columns[0], ListSortDirection.Ascending);
                    platillosDataGridView.AllowUserToAddRows = false;
                    platillosDataGridView.Columns.Add(GPla);
                    pla++;
                }
            }
        }

        private void platillosDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Columns_KeyPress);
            if (platillosDataGridView.CurrentCell.ColumnIndex == platillosDataGridView.Columns["cantidad"].Index) //Columnas deseadas
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Columns_KeyPress);
                }
            }
        }

        private void Columns_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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

                    bebidasDataGridView.Sort(bebidasDataGridView.Columns[0], ListSortDirection.Ascending);
                    bebidasDataGridView.AllowUserToAddRows = false;
                    beb++;
                    bebidasDataGridView.Columns.Add(GBeb);
                }
            }
        }

        private void bebidasDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Columns_KeyPress);
            if (bebidasDataGridView.CurrentCell.ColumnIndex == bebidasDataGridView.Columns["cantidad"].Index) //Columnas deseadas
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Columns_KeyPress);
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

                    postresDataGridView.Sort(postresDataGridView.Columns[0], ListSortDirection.Ascending);
                    postresDataGridView.AllowUserToAddRows = false;
                    postresDataGridView.Columns.Add(GPos);
                    pos++;
                }

            }
        }

        private void postresDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Columns_KeyPress);
            if (postresDataGridView.CurrentCell.ColumnIndex == postresDataGridView.Columns["cantidad"].Index) //Columnas deseadas
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Columns_KeyPress);
                }
            }
        }


        private void agregarButton_Click(object sender, EventArgs e)
        {
            try
            {
                int numMesa;
                numMesa = noMesaComboBox.SelectedIndex;
                //BLAgregarOrden.agregarOrden(tipoServicioComboBox.Text, numMesa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("¡Ha ocurrido un error al dar de alta la orden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class elementosSeleccionados
        {
            public string nombre { get; set; }
            public float precioUnitario { get; set; }
            public int cantidad { get; set; }
            public float subTotal { get; set; }
        }

        public List<elementosSeleccionados> Lista = new List<elementosSeleccionados>();
        String nombreElemento;
        float subTotal, precioUnitario, total;
        int cantidad;
        private void dataGridViewPlatillos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.ColumnIndex == platillosDataGridView.Columns.IndexOf(GPla))
            {
                if (platillosDataGridView.CurrentRow.Cells["cantidad"].Value == null)
                {
                    MessageBox.Show("No se ha ingresado la cantidad", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    platillosDataGridView.CurrentRow.Cells[e.ColumnIndex].Style.SelectionBackColor = Color.FromArgb(255, 205, 89);
                    platillosDataGridView.CurrentRow.Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(255, 128, 0);
                    platillosDataGridView.CurrentRow.Cells[e.ColumnIndex].Style.ForeColor = Color.White;
                    platillosDataGridView.CurrentRow.Cells["cantidad"].Style.ForeColor = Color.FromArgb(255, 128, 0);
                    platillosDataGridView.CurrentRow.Cells[e.ColumnIndex].Style.Font = new Font("Gadugi", 15, FontStyle.Bold);

                    nombreElemento = platillosDataGridView.CurrentRow.Cells["nombre_elemento"].Value.ToString();
                    cantidad = Convert.ToInt32(platillosDataGridView.CurrentRow.Cells["cantidad"].Value.ToString());
                    precioUnitario = Convert.ToSingle(platillosDataGridView.CurrentRow.Cells["precio"].Value.ToString());
                    subTotal = precioUnitario * cantidad;

                    Lista.Add(new elementosSeleccionados() { nombre = nombreElemento, precioUnitario = precioUnitario, cantidad = cantidad, subTotal = subTotal });

                    actualizarOrdenDataGrid();


                    //string test = ordenDataGridView.Rows[0].Cells[4].Value.ToString();
                    //MessageBox.Show(test, "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    float sum = 0;
                    //for (int i = 1; i < ordenDataGridView.Rows.Count; ++i)
                    for (int i = 0; i < Lista.Count; ++i)
                    {
                        //sum += Convert.ToSingle(ordenDataGridView.Rows[i].Cells[4].Value);
                        sum = Lista.Sum(lista => lista.subTotal);
                    }

                    totalElementosLabel.Text = sum.ToString();
                    total = Convert.ToSingle(totalElementosLabel.Text);
                }
            }

        }

        private void actualizarOrdenDataGrid()
        {

            foreach (elementosSeleccionados element in Lista)
            {
                ordenDataGridView.DataSource = Lista.ToList();
            }
            if (ord == 0)
            {
                //DataGridOrden
                GOrd.Name = "eliminar";
                GOrd.Text = "Quitar";
                GOrd.HeaderText = "eliminar";
                GOrd.FlatStyle = FlatStyle.Flat;
                GOrd.UseColumnTextForButtonValue = true;
                ordenDataGridView.Columns.Add(GOrd);
                ord++;
                ordenDataGridView.Columns[0].Width = 380;
                ordenDataGridView.Columns[0].ReadOnly = true;
                ordenDataGridView.Columns[1].Width = 70;
                ordenDataGridView.Columns[1].ReadOnly = true;
                ordenDataGridView.Columns[2].Width = 70;
                ordenDataGridView.Columns[3].Width = 70;
            }
            ordenDataGridView.AllowUserToAddRows = false;
            OrdenReadDataGrid(ordenDataGridView);

        }

        private void OrdenReadDataGrid(DataGridView dataGrid)
        {

        }

        //OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        private void ordenDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == ordenDataGridView.Columns.IndexOf(GOrd))
            {
                Lista.RemoveAt(ordenDataGridView.CurrentRow.Index);

                float operacion = Convert.ToSingle(ordenDataGridView.CurrentRow.Cells[4].Value);
                totalElementosLabel.Text = Convert.ToString(total - operacion);
                total = Convert.ToSingle(totalElementosLabel.Text);

                actualizarOrdenDataGrid();
                //ordenDataGridView.Rows.RemoveAt(ordenDataGridView.CurrentRow.Index);
            }
        }

        private void dataGridViewBebidas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == bebidasDataGridView.Columns.IndexOf(GBeb))
                {
                    if (bebidasDataGridView.CurrentRow.Cells["cantidad"].Value == null)
                    {
                        MessageBox.Show("No se ha ingresado la cantidad", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        bebidasDataGridView.CurrentRow.Cells[e.ColumnIndex].Style.SelectionBackColor = Color.FromArgb(255, 205, 89);
                        bebidasDataGridView.CurrentRow.Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(255, 128, 0);
                        bebidasDataGridView.CurrentRow.Cells[e.ColumnIndex].Style.ForeColor = Color.White;
                        bebidasDataGridView.CurrentRow.Cells["cantidad"].Style.ForeColor = Color.FromArgb(255, 128, 0);
                        bebidasDataGridView.CurrentRow.Cells[e.ColumnIndex].Style.Font = new Font("Gadugi", 15, FontStyle.Bold);

                        nombreElemento = bebidasDataGridView.CurrentRow.Cells["nombre_elemento"].Value.ToString();
                        cantidad = Convert.ToInt32(bebidasDataGridView.CurrentRow.Cells["cantidad"].Value.ToString());
                        precioUnitario = Convert.ToSingle(bebidasDataGridView.CurrentRow.Cells["precio"].Value.ToString());
                        subTotal = precioUnitario * cantidad;

                        Lista.Add(new elementosSeleccionados() { nombre = nombreElemento, precioUnitario = precioUnitario, cantidad = cantidad, subTotal = subTotal });

                        actualizarOrdenDataGrid();

                        float sum = 0;
                        //for (int i = 1; i < ordenDataGridView.Rows.Count; ++i)
                        for (int i = 0; i < Lista.Count; ++i)
                        {
                            //sum += Convert.ToSingle(ordenDataGridView.Rows[i].Cells[4].Value);
                            sum = Lista.Sum(lista => lista.subTotal);
                        }

                        totalElementosLabel.Text = sum.ToString();
                        total = Convert.ToSingle(totalElementosLabel.Text);
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        private void dataGridViewPostres_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == postresDataGridView.Columns.IndexOf(GPos))
            {
                if (postresDataGridView.CurrentRow.Cells["cantidad"].Value == null)
                {
                    MessageBox.Show("No se ha ingresado la cantidad", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    postresDataGridView.CurrentRow.Cells[e.ColumnIndex].Style.SelectionBackColor = Color.FromArgb(255, 205, 89);
                    postresDataGridView.CurrentRow.Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(255, 128, 0);
                    postresDataGridView.CurrentRow.Cells[e.ColumnIndex].Style.ForeColor = Color.White;
                    postresDataGridView.CurrentRow.Cells["cantidad"].Style.ForeColor = Color.FromArgb(255, 128, 0);


                    nombreElemento = postresDataGridView.CurrentRow.Cells["nombre_elemento"].Value.ToString();
                    cantidad = Convert.ToInt32(postresDataGridView.CurrentRow.Cells["cantidad"].Value.ToString());
                    precioUnitario = Convert.ToSingle(postresDataGridView.CurrentRow.Cells["precio"].Value.ToString());
                    subTotal = precioUnitario * cantidad;

                    Lista.Add(new elementosSeleccionados() { nombre = nombreElemento, precioUnitario = precioUnitario, cantidad = cantidad, subTotal = subTotal });


                    postresDataGridView.CurrentRow.Cells[e.ColumnIndex].Style.Font = new Font("Gadugi", 15, FontStyle.Bold);
                    actualizarOrdenDataGrid();

                    float sum = 0;
                    //for (int i = 1; i < ordenDataGridView.Rows.Count; ++i)
                    for (int i = 0; i < Lista.Count; ++i)
                    {
                        //sum += Convert.ToSingle(ordenDataGridView.Rows[i].Cells[4].Value);
                        sum = Lista.Sum(lista => lista.subTotal);
                    }

                    totalElementosLabel.Text = sum.ToString();
                    total = Convert.ToSingle(totalElementosLabel.Text);
                }
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

        private void agregarButton_Click_1(object sender, EventArgs e)
        {
            int empleado = 1;
            float total = float.Parse(totalElementosLabel.Text);
            BLAgregarOrden.agregarOrden(empleado, noMesaComboBox.SelectedItem.ToString(),tipoServicioComboBox.SelectedItem.ToString(), fechaOrdenLabel.Text,
                                        horaOrdenLabel.Text, total, "En Espera", "No Pagado", "Indefinido",comentariosRichTextBox.Text);

        }
    }
}


