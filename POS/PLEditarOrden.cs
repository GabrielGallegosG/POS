using System.Drawing;
using System.Windows.Forms;


namespace POS
{
    class PLEditarOrden
    {

        public static void posicionEditarOrden(Label empleado, Label empleadoOrd, Label tipoServ, Label noMesa, Label fecha, Label hora, Label fechaOrd, Label horaOrd, ComboBox servicio, ComboBox mesa,
            Label agregar, CheckBox platillo, CheckBox postre, CheckBox bebida, Label comentarios, RichTextBox comentarioRTB, Button cancelar, Button guardarB)
        {
            empleado.Size = new Size(100, 30);
            empleadoOrd.Size = new Size(400, 30);
            tipoServ.Size = new Size(100, 30);
            noMesa.Size = new Size(100, 30);
            fecha.Size = new Size(100, 30);
            hora.Size = new Size(100, 3);
            fechaOrd.Size = new Size(250, 30);
            horaOrd.Size = new Size(250, 30);
            servicio.Size = new Size(220, 30);
            mesa.Size = new Size(80, 20);
            comentarios.Size = new Size(40, 35);
            comentarioRTB.Size = new Size(700, 80);

            empleado.Location = new Point(50, 70);
            empleadoOrd.Location = new Point(230, 70);
            tipoServ.Location = new Point(50, 120);
            noMesa.Location = new Point(50, 170);
            servicio.Location = new Point(230, 120);
            mesa.Location = new Point(230, 170);

            fecha.Location = new Point(1140, 70);
            hora.Location = new Point(1140, 120);
            fechaOrd.Location = new Point(1220, 70);
            horaOrd.Location = new Point(1220, 120);

            agregar.Location = new Point(50, 250);
            platillo.Location = new Point(50, 300);
            bebida.Location = new Point(180, 300);
            postre.Location = new Point(300, 300);

            comentarios.Location = new Point(50, 620);
            comentarioRTB.Location = new Point(50, 650);

            guardarB.Location = new Point(1230, 740);
            cancelar.Location = new Point(50, 740);
            guardarB.Size = new Size(180, 40);
            cancelar.Size = new Size(120, 40);

        }

        public static void posicionrOrden(Label nombre, Label precio, Label cantidad, Label subtotal, Label total, Label totalLB, Button actualizar)
        {

            nombre.Location = new Point(760, 300);
            precio.Location = new Point(1140, 300);
            cantidad.Location = new Point(1210, 300);
            subtotal.Location = new Point(1279, 300);
            total.Location = new Point(1210, 629);

            totalLB.Size = new Size(110, 40);
            totalLB.Location = new Point(1279, 620);
        }


        public static void dataGridView(DataGridView dataGrid)
        {
            dataGrid.Size = new Size(700, 270);
            dataGrid.Location = new Point(50, 330);

            dataGrid.AllowUserToOrderColumns = true;
            dataGrid.AllowUserToResizeColumns = true;

            dataGrid.RowsDefaultCellStyle.Padding = new Padding(2, 2, 2, 2);
            dataGrid.RowsDefaultCellStyle.Font = new Font("Gadugi", 15);
            dataGrid.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dataGrid.AlternatingRowsDefaultCellStyle.Padding = new Padding(2, 2, 2, 2);
            dataGrid.AlternatingRowsDefaultCellStyle.Font = new Font("Gadugi", 15);
            dataGrid.AlternatingRowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGrid.AlternatingRowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGrid.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 0, 0, 0);
            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Gadugi", 15);
            dataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGrid.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGrid.DefaultCellStyle.Padding = new Padding(0, 0, 0, 0);
            dataGrid.DefaultCellStyle.Font = new Font("Gadugi", 15);
            dataGrid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGrid.RowHeadersDefaultCellStyle.Padding = new Padding(0, 0, 0, 0);
            dataGrid.RowHeadersDefaultCellStyle.Font = new Font("Gadugi", 15);
            dataGrid.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGrid.RowHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGrid.AutoResizeColumns();
            dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGrid.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            dataGrid.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            dataGrid.RowHeadersVisible = false;
            dataGrid.ColumnHeadersVisible = false;


        }

        public static void dataGridView_2(DataGridView dataGrid)
        {
            dataGrid.Visible = true;
            dataGrid.Size = new Size(715, 270);
            dataGrid.Location = new Point(760, 330);

            dataGrid.AllowUserToOrderColumns = true;
            dataGrid.AllowUserToResizeColumns = true;

            dataGrid.RowsDefaultCellStyle.Padding = new Padding(2, 2, 2, 2);
            dataGrid.RowsDefaultCellStyle.Font = new Font("Gadugi", 15);
            dataGrid.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dataGrid.AlternatingRowsDefaultCellStyle.Padding = new Padding(2, 2, 2, 2);
            dataGrid.AlternatingRowsDefaultCellStyle.Font = new Font("Gadugi", 15);
            dataGrid.AlternatingRowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGrid.AlternatingRowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGrid.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 0, 0, 0);
            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Gadugi", 15);
            dataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGrid.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGrid.DefaultCellStyle.Padding = new Padding(0, 0, 0, 0);
            dataGrid.DefaultCellStyle.Font = new Font("Gadugi", 15);
            dataGrid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGrid.RowHeadersDefaultCellStyle.Padding = new Padding(0, 0, 0, 0);
            dataGrid.RowHeadersDefaultCellStyle.Font = new Font("Gadugi", 15);
            dataGrid.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGrid.RowHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGrid.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            dataGrid.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            dataGrid.RowHeadersVisible = false;
            dataGrid.ColumnHeadersVisible = false;
            dataGrid.AutoResizeColumns();

        }
    }
}
