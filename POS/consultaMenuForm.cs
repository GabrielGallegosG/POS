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
    public partial class consultaMenuForm : Form
    {
        public consultaMenuForm()
        {
            InitializeComponent();
            PLConsultaMenu.posicionEncabezado(inicioBbutton,menuButton,ordenesButton,ventasButton,usuariosButton);
            PLConsultaMenu.posicionConsultaMenu(logoPictureBox, encabezadoLabel, platillosPanel, bebidasPanel, postresPanel, platillosDataGridView, bebidasDataGridView, postresDataGridView, platilloLabel, bebidaLabel, postreLabel,
                                                editarPlatilloButton,editarBebidaButton,editarPostreButton,eliminarPlatilloButton,eliminarBebidaButton,eliminarPostreButton,agregarMenuLabel,agregarMenuButton,nombreSeccionLabel,precioSeccionLabel);
            PLConsultaMenu.panelPlatillo(platillosLabel);
            PLConsultaMenu.panelBebida(bebidasLabel);
            PLConsultaMenu.panelPostre(postresLabel);
            PLConsultaMenu.dataGridView(platillosDataGridView);
            PLConsultaMenu.dataGridView(bebidasDataGridView);
            PLConsultaMenu.dataGridView(postresDataGridView);
        }

        private void agregarMenuButton_Click(object sender, EventArgs e)
        {
            agregarMenuForm frm = new agregarMenuForm();
            frm.ShowDialog();
        }

        private void editarPlatilloButton_Click(object sender, EventArgs e)
        {
            string id = BLEditarElemento.idSeleccionadoDT(platilloLabel.Text);
            string precio = BLEditarElemento.precioSeleccionadoDT(platilloLabel.Text);
            int platillo = 0;
            string descripcion = BLEditarElemento.descripcionSeleccionadoDT(platilloLabel.Text);
            editarMenuForm frm = new editarMenuForm(id, platilloLabel.Text, precio, platillo, descripcion);
            frm.ShowDialog();
        }

        private void editarBebidaButton_Click(object sender, EventArgs e)
        {
            string id = BLEditarElemento.idSeleccionadoDT(bebidaLabel.Text);
            string precio = BLEditarElemento.precioSeleccionadoDT(bebidaLabel.Text);
            int platillo = 1;
            string descripcion = BLEditarElemento.descripcionSeleccionadoDT(bebidaLabel.Text);
            editarMenuForm frm = new editarMenuForm(id, bebidaLabel.Text, precio, platillo, descripcion);
            frm.ShowDialog();
        }

        private void editarPostreButton_Click(object sender, EventArgs e)
        {
            string id = BLEditarElemento.idSeleccionadoDT(postreLabel.Text);
            string precio = BLEditarElemento.precioSeleccionadoDT(postreLabel.Text);
            int platillo = 2;
            string descripcion = BLEditarElemento.descripcionSeleccionadoDT(postreLabel.Text);
            editarMenuForm frm = new editarMenuForm(id, postreLabel.Text, precio, platillo, descripcion);
            frm.ShowDialog();
        }

        private void eliminarPlatilloButton_Click(object sender, EventArgs e)
        {
            string id = BLEditarElemento.idSeleccionadoDT(platilloLabel.Text);
            string precio = BLEditarElemento.precioSeleccionadoDT(platilloLabel.Text);
            int platillo = 0;
            string descripcion = BLEditarElemento.descripcionSeleccionadoDT(platilloLabel.Text);
            eliminarMenuForm frm = new eliminarMenuForm(id, platilloLabel.Text, precio, platillo, descripcion);
            frm.ShowDialog();
        }

        private void eliminarBebidaButton_Click(object sender, EventArgs e)
        {
            string id = BLEditarElemento.idSeleccionadoDT(bebidaLabel.Text);
            string precio = BLEditarElemento.precioSeleccionadoDT(bebidaLabel.Text);
            int platillo = 1;
            string descripcion = BLEditarElemento.descripcionSeleccionadoDT(bebidaLabel.Text);
            eliminarMenuForm frm = new eliminarMenuForm(id, bebidaLabel.Text, precio, platillo, descripcion);
            frm.ShowDialog();
        }

        private void eliminarPostreButton_Click(object sender, EventArgs e)
        {
            string id = BLEditarElemento.idSeleccionadoDT(postreLabel.Text);
            string precio = BLEditarElemento.precioSeleccionadoDT(postreLabel.Text);
            int platillo = 2;
            string descripcion = BLEditarElemento.descripcionSeleccionadoDT(postreLabel.Text);
            eliminarMenuForm frm = new eliminarMenuForm(id, postreLabel.Text, precio, platillo, descripcion);
            frm.ShowDialog();
        }

        //Botones encabezado
        private void ordenesButton_Click(object sender, EventArgs e)
        {
            consultaMenuForm consultaMenu = new consultaMenuForm();
            consultaMenu.Close();
            this.Hide();
            consultarOrdenesForm frm = new consultarOrdenesForm();
            frm.Show();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            consultaMenuForm consultaMenu = new consultaMenuForm();
            consultaMenu.Close();
            this.Hide();

            consultaMenuForm frm = new consultaMenuForm();
            frm.Show();
        }

        private void consultaMenuForm_Load(object sender, EventArgs e)
        {
            platillosDataGridView.DataSource = BLConsultaElemento.PlatillosDT();
            platillosPanel.BackColor = Color.DodgerBlue;
            platilloLabel.Visible = true;

            nombreSeccionLabel.Text = "Nombre del Platillo";
            precioSeccionLabel.Text = "Precio por Platillo";
        }

        private void mostrarPlatillosPanel()
        {
            nombreSeccionLabel.Text = "Nombre del Platillo";
            precioSeccionLabel.Text = "Precio";

            platillosDataGridView.Visible = true;
            bebidasDataGridView.Visible = false;
            postresDataGridView.Visible = false;

            platilloLabel.Visible = true;
            bebidaLabel.Visible = false;
            postreLabel.Visible = false;

            editarPlatilloButton.Visible = true;
            editarBebidaButton.Visible = false;
            editarPostreButton.Visible = false;

            eliminarPlatilloButton.Visible = true;
            eliminarPostreButton.Visible = false;
            eliminarBebidaButton.Visible = false;

            platillosDataGridView.DataSource = BLConsultaElemento.PlatillosDT();
            
            platillosPanel.BackColor = Color.DodgerBlue;
            bebidasPanel.BackColor = Color.FromArgb(0, 87, 158);
            postresPanel.BackColor = Color.FromArgb(0, 87, 158);
        }

        private void mostrarBebidasPanel()
        {

            nombreSeccionLabel.Text = "Nombre de la Bebida";
            precioSeccionLabel.Text = "Precio";

            platillosDataGridView.Visible = false;
            bebidasDataGridView.Visible = true;
            postresDataGridView.Visible = false;

            platilloLabel.Visible = false;
            bebidaLabel.Visible = true;
            postreLabel.Visible = false;

            editarPlatilloButton.Visible = false;
            editarBebidaButton.Visible = true;
            editarPostreButton.Visible = false;

            eliminarPlatilloButton.Visible = false;
            eliminarPostreButton.Visible = false;
            eliminarBebidaButton.Visible = true;

            bebidasDataGridView.DataSource = BLConsultaElemento.BebidasDT();

            platillosPanel.BackColor = Color.FromArgb(0, 87, 158);
            bebidasPanel.BackColor = Color.DodgerBlue;
            postresPanel.BackColor = Color.FromArgb(0, 87, 158);
        }

        private void mostrarPostresPanel()
        {

            nombreSeccionLabel.Text = "Nombre del Postre";
            precioSeccionLabel.Text = "Precio";

            platillosDataGridView.Visible = false;
            bebidasDataGridView.Visible = false;
            postresDataGridView.Visible = true;

            platilloLabel.Visible = false;
            bebidaLabel.Visible = false;
            postreLabel.Visible = true;

            editarPlatilloButton.Visible = false;
            editarBebidaButton.Visible = false;
            editarPostreButton.Visible = true;

            eliminarPlatilloButton.Visible = false;
            eliminarPostreButton.Visible = true;
            eliminarBebidaButton.Visible = false;

            postresDataGridView.DataSource = BLConsultaElemento.PostresDT();

            platillosPanel.BackColor = Color.FromArgb(0, 87, 158);
            bebidasPanel.BackColor = Color.FromArgb(0, 87, 158);
            postresPanel.BackColor = Color.DodgerBlue;
        }

        private void platillosPanel_Click(object sender, EventArgs e){mostrarPlatillosPanel();}
        private void bebidasPanel_Click(object sender, EventArgs e){mostrarBebidasPanel();}
        private void postresPanel_Click(object sender, EventArgs e){mostrarPostresPanel();}
        private void platillosLabel_Click(object sender, EventArgs e) { mostrarPlatillosPanel(); }
        private void bebidasLabel_Click(object sender, EventArgs e) { mostrarBebidasPanel(); }
        private void postresLabel_Click(object sender, EventArgs e) { mostrarPostresPanel(); }

        private void platillosDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;
            platilloLabel.Text = row.Cells[0].Value.ToString();
        }

        private void bebidasDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;
            bebidaLabel.Text = row.Cells[0].Value.ToString();
        }

        private void postresDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;
            postreLabel.Text = row.Cells[0].Value.ToString();
        }

        private void usuariosButton_Click(object sender, EventArgs e)
        {
            consultaMenuForm consultaMenu = new consultaMenuForm();
            consultaMenu.Close();
            this.Hide();
            consultarUsuariosForm frm = new consultarUsuariosForm();
            frm.Show();
        }
    }
}
