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
                                                    Label agregarMenuL, Button agregarMenuBtn, Label nombre, Label precio, 
                                                    Button verPlatillo, Button verBebida, Button verPostre, Button actualizar)
        {
            logo.Size = new Size(155, 120);
            menu.Size = new Size(100,40);

            platillos.Size = new Size(300, 45);
            bebidas.Size = new Size(300, 45);
            postres.Size = new Size(300, 45);

            nombre.Size = new Size(450, 35);
            precio.Size = new Size(450, 35);
            actualizar.Size = new Size(35, 35);

            platillosDGV.Size = new Size(900, 300);
            bebidasDGV.Size = new Size(900, 300);
            postresDGV.Size = new Size(900, 300);

            platillo.Size = new Size(700, 30);
            bebida.Size = new Size(700, 30);
            postre.Size = new Size(700, 30);

            modiPlatillo.Size = new Size(35,35);
            modiBebida.Size = new Size(35, 35);
            modiPostre.Size = new Size(35, 35);
            eliPlatillo.Size = new Size(35, 35);
            eliBebida.Size = new Size(35, 35);
            eliPostre.Size = new Size(35, 35);
            verPlatillo.Size = new Size(29, 29);
            verBebida.Size = new Size(29, 29);
            verPostre.Size = new Size(29, 29);


            agregarMenuBtn.Size = new Size(45, 30);

            logo.Location = new Point(40,70);
            logo.BringToFront();
            menu.Location = new Point(200, 110);

            platillos.Location = new Point(250, 215);
            bebidas.Location = new Point(550, 215);
            postres.Location = new Point(850, 215);

            nombre.Location = new Point(250, 270);
            precio.Location = new Point(700, 270);
            actualizar.Location = new Point(1105, 265);

            platillosDGV.Location = new Point(250, 300);
            bebidasDGV.Location = new Point(250, 300);
            postresDGV.Location = new Point(250, 300);

            platillo.Location = new Point(250, 625);
            bebida.Location = new Point(250, 625);
            postre.Location = new Point(240, 625);

            modiPlatillo.Location = new Point(1080, 620);
            modiBebida.Location = new Point(1080, 620);
            modiPostre.Location = new Point(1080, 620);

            eliPlatillo.Location = new Point(1115, 620);
            eliBebida.Location = new Point(1115, 620);
            eliPostre.Location = new Point(1115,620);

            verPlatillo.Location = new Point(1042, 625);
            verBebida.Location = new Point(1042, 625);
            verPostre.Location = new Point(1042, 625);

            agregarMenuL.Location = new Point(1120, 90);
            agregarMenuBtn.Location = new Point(1300, 85);

            var tt = new ToolTip();
            tt.SetToolTip(modiPlatillo, "Modificar platillo");
            tt.SetToolTip(modiBebida, "Modificar bebida");
            tt.SetToolTip(modiPostre, "Modificar postre");
            tt.SetToolTip(verPlatillo, "Ver contenido del platillo");
            tt.SetToolTip(verBebida, "Ver contenido de la bebida");
            tt.SetToolTip(verPostre, "Ver contenido del postre");
            tt.SetToolTip(eliPlatillo, "Eliminar platillo");
            tt.SetToolTip(eliBebida, "Eliminar bebida");
            tt.SetToolTip(eliPostre, "Eliminar postre");
            tt.SetToolTip(actualizar, "Actualizar menú");
            tt.SetToolTip(agregarMenuBtn, "Agregar nuevo elemento al menú");
            tt.SetToolTip(platillos, "Ver todos los platillos");
            tt.SetToolTip(bebidas, "Ver todas las bebidas");
            tt.SetToolTip(postres, "Ver todos los postres");
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
