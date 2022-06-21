using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    class PLConsultarUsuarios
    {
        public static void posicionEncabezado(Button inicio, Button menu, Button orden, Button venta, Button usuario)
        {
            inicio.Size = new Size(90, 35);
            menu.Size = new Size(90, 35);
            orden.Size = new Size(110, 35);
            venta.Size = new Size(100, 35);
            usuario.Size = new Size(120, 35);

            inicio.Location = new Point(808, 7);
            menu.Location = new Point(907, 7);
            orden.Location = new Point(1005, 7);
            venta.Location = new Point(1123, 7);
            usuario.Location = new Point(1230, 7);
        }

        public static void posicionConsultaUsuarios(PictureBox logo, Label menu, Label agregar, Button agregarUs, Panel panel, DataGridView tabla,
                                                     Panel buscar, Label usuario, Button editar, Button baja, TextBox buscarU, PictureBox lupa)
        {
            logo.Size = new Size(135, 120);
            menu.Size = new Size(110, 40);
            panel.Size = new Size(1000, 40);
            tabla.Size = new Size(1000, 300);
            buscar.Size = new Size(350, 40);
            buscarU.Size = new Size(310, 40);
            usuario.Size = new Size(550, 30);
            lupa.Size = new Size(25, 25);

            logo.Location = new Point(40, 70);
            logo.BringToFront();
            menu.Location = new Point(200, 110);

            agregar.Location = new Point(1100, 90);
            agregarUs.Location = new Point(1300, 80);

            panel.Location = new Point(200, 220);
            tabla.Location = new Point(200, 300);

            buscar.Location = new Point(850, 170);
            buscarU.Location = new Point(35, 9);
            lupa.Location = new Point(5, 5);

            usuario.Location = new Point(200, 620);
            editar.Location = new Point(780, 620);
            baja.Location = new Point(820, 620);
        }

        public static void encabezadosTabla(Label id, Label nombre, Label apellidoP, Label apellidoM, Label cargo, Button actualizar)
        {
            id.Location = new Point(210, 262);
            nombre.Location = new Point(400, 262);
            apellidoP.Location = new Point(600, 262);
            apellidoM.Location = new Point(790, 262);
            cargo.Location = new Point(990, 262);
            actualizar.Location = new Point(1150, 262);
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

            dataGrid.ColumnHeadersDefaultCellStyle.Padding = new Padding(2, 2, 2, 2);
            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Gadugi", 15);
            dataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGrid.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGrid.DefaultCellStyle.Padding = new Padding(2, 2, 2, 2);
            dataGrid.DefaultCellStyle.Font = new Font("Gadugi", 15);
            dataGrid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGrid.RowHeadersDefaultCellStyle.Padding = new Padding(2, 2, 2, 2);
            dataGrid.RowHeadersDefaultCellStyle.Font = new Font("Gadugi", 15);
            dataGrid.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGrid.RowHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGrid.AutoResizeColumns();
            dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGrid.ReadOnly = true;

            dataGrid.RowHeadersWidth = 150;
            dataGrid.RowHeadersVisible = false;
            dataGrid.ColumnHeadersVisible = false;

        }

    }
}
