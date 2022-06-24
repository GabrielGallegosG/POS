using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    class PLConsultarVentas
    {
        public static void posicionEncabezado(Button inicio, Button menu, Button orden, Button venta, Button usuario)
        {
            inicio.Size = new Size(90, 30);
            menu.Size = new Size(90, 30);
            orden.Size = new Size(110, 30);
            venta.Size = new Size(90, 30);
            usuario.Size = new Size(110, 30);

            inicio.Location = new Point(808, 7);
            menu.Location = new Point(907, 7);
            orden.Location = new Point(1005, 7);
            venta.Location = new Point(1123, 7);
            usuario.Location = new Point(1230, 7);
        }

        public static void posicionConsultaMenu(PictureBox logo, Label ventas, DataGridView consultTabla,
                                                    Label filtrarL, ComboBox filtrarCB, Label datoBuscarL, TextBox datoBuscar)
        {
            logo.Size = new Size(115, 100);
            ventas.Size = new Size(110, 30);
            consultTabla.Size = new Size(1036, 410);
            filtrarL.Size = new Size(132, 21);
            filtrarCB.Size = new Size(199, 21);
            datoBuscarL.Size = new Size(164, 21);
            datoBuscar.Size = new Size(197, 20);

            logo.Location = new Point(12, 48);
            logo.BringToFront();
            ventas.Location = new Point(133, 87);
            consultTabla.Location = new Point(13, 198);
            filtrarL.Location = new Point(295, 62);
            filtrarCB.Location = new Point(299, 97);
            datoBuscarL.Location = new Point(595, 62);
            datoBuscar.Location = new Point(602, 97);

        }

        public static void etiquetas(Label idOrd, Label usuario, Label mesa, Label servicio, Label fecha, Label hora, Label total, Label metoPago)
        {
            idOrd.Location = new Point(23, 174);
            usuario.Location = new Point(133, 174);
            mesa.Location = new Point(240, 174);
            servicio.Location = new Point(351, 174);
            fecha.Location = new Point(532, 174);
            hora.Location = new Point(670, 174);
            total.Location = new Point(785, 174);
            metoPago.Location = new Point(892, 174);
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
