using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    class PLConsultaOrdenes
    {
        public static void posicionEncabezado(Button inicio, Button menu, Button orden, Button venta, Button usuario, DataGridView consulta)
        {
            inicio.Size = new Size(90, 35);
            menu.Size = new Size(90, 35);
            orden.Size = new Size(110, 35);
            venta.Size = new Size(100, 35);
            usuario.Size = new Size(120, 35);
            consulta.Size = new Size(1000, 300);

            inicio.Location = new Point(808, 7);
            menu.Location = new Point(907, 7);
            orden.Location = new Point(1005, 7);
            venta.Location = new Point(1123, 7);
            usuario.Location = new Point(1230, 7);
            consulta.Location = new Point(250, 300);
        }

        public static void etiquetas(Label orden, Label mesa, Label servicio, Label fecha, Label hora, Label total, Label estado, Button actualizar) {
            
            actualizar.Size = new Size(35, 35);
            
            orden.Location = new Point(250, 270);
            mesa.Location = new Point(393, 270);
            servicio.Location = new Point(536, 270);
            fecha.Location = new Point(679, 270);
            hora.Location = new Point(821, 270);
            total.Location = new Point(964, 270);
            estado.Location = new Point(1106, 270);

            actualizar.Location = new Point(1250, 260);
        }

        public static void posisiconConsultaOrdenes(PictureBox logo, Label menu, Label nuevaOrd, Button agregar)
        {
            logo.Size = new Size(155, 120);
            menu.Size = new Size(100, 40);
            agregar.Size = new Size(45, 30);
            logo.Location = new Point(40, 70);
            logo.BringToFront();
            menu.Location = new Point(200, 110);
            nuevaOrd.Location = new Point(1150, 90);
            agregar.Location = new Point(1300, 86);
        }


        public static void dataGridView(DataGridView dataGrid)
        {


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
            dataGrid.ReadOnly = true;
            
            dataGrid.RowHeadersVisible = false;
            dataGrid.ColumnHeadersVisible = false;

        }
    }
}
