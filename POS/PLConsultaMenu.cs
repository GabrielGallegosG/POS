using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    class PLConsultaMenu
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

        public  static void posicionConsultaMenu(PictureBox logo, Label menu, Panel platillos, Panel bebidas, Panel postres,
                                                    DataGridView platillosDGV, DataGridView bebidasDGV, DataGridView postresDGV,
                                                    Label platillo, Label bebida, Label postre, Button modiPlatillo, Button modiBebida, 
                                                    Button modiPostre, Button eliPlatillo, Button eliBebida, Button eliPostre,
                                                    Label agregarMenuL, Button agregarMenuBtn, Label nombre, Label precio)
        {
            logo.Size = new Size(155, 120);
            menu.Size = new Size(100,40);

            platillos.Size = new Size(300, 45);
            bebidas.Size = new Size(300, 45);
            postres.Size = new Size(300, 45);

            nombre.Size = new Size(450, 35);
            nombre.Size = new Size(450, 35);

            platillosDGV.Size = new Size(900, 300);
            bebidasDGV.Size = new Size(900, 300);
            postresDGV.Size = new Size(900, 300);

            platillo.Size = new Size(600, 30);
            bebida.Size = new Size(600, 30);
            postre.Size = new Size(600, 30);

            modiPlatillo.Size = new Size(35,35);
            modiBebida.Size = new Size(35, 35);
            modiPostre.Size = new Size(35, 35);
            eliPlatillo.Size = new Size(35, 35);
            eliBebida.Size = new Size(35, 35);
            eliPostre.Size = new Size(35, 35);
            agregarMenuBtn.Size = new Size(45, 30);

            logo.Location = new Point(40,70);
            logo.BringToFront();
            menu.Location = new Point(200, 110);

            platillos.Location = new Point(250, 215);
            bebidas.Location = new Point(550, 215);
            postres.Location = new Point(850, 215);

            nombre.Location = new Point(250, 270);
            precio.Location = new Point(700, 270);

            platillosDGV.Location = new Point(250, 300);
            bebidasDGV.Location = new Point(250, 300);
            postresDGV.Location = new Point(250, 300);

            platillo.Location = new Point(250, 625);
            bebida.Location = new Point(250, 625);
            postre.Location = new Point(240, 625);

            modiPlatillo.Location = new Point(915, 620);
            modiBebida.Location = new Point(915, 620);
            modiPostre.Location = new Point(915, 620);

            eliPlatillo.Location = new Point(955, 620);
            eliBebida.Location = new Point(955, 620);
            eliPostre.Location = new Point(955,620);

            agregarMenuL.Location = new Point(1100, 90);
            agregarMenuBtn.Location = new Point(1300, 80);
        }

        public static void dataGridView(DataGridView dataGrid) {


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

            dataGrid.RowHeadersWidth = 100;
            dataGrid.RowHeadersVisible = false;
            dataGrid.ColumnHeadersVisible = false;

        }

        public static void panelPlatillo(Label platillos)
        {
            platillos.Location = new Point(50, 10);
        }

        public static void panelBebida(Label bebida)
        {
            bebida.Location = new Point(60, 10);
        }

        public static void panelPostre(Label postre)
        {
            postre.Location = new Point(60, 10);
        }
    }
}
