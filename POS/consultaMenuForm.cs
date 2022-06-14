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
                                                editarPlatilloButton,editarBebidaButton,editarPostreButton,eliminarPlatilloButton,eliminarBebidaButton,eliminarPostreButton,agregarMenuLabel,agregarMenuButton);
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
            editarMenuForm frm = new editarMenuForm();
            frm.ShowDialog();
        }

        private void editarBebidaButton_Click(object sender, EventArgs e)
        {
            editarMenuForm frm = new editarMenuForm();
            frm.ShowDialog();
        }

        private void editarPostreButton_Click(object sender, EventArgs e)
        {
            editarMenuForm frm = new editarMenuForm();
            frm.ShowDialog();
        }

        private void eliminarPlatilloButton_Click(object sender, EventArgs e)
        {
            eliminarMenuForm frm = new eliminarMenuForm();
            frm.ShowDialog();
        }

        private void eliminarBebidaButton_Click(object sender, EventArgs e)
        {
            eliminarMenuForm frm = new eliminarMenuForm();
            frm.ShowDialog();
        }

        private void eliminarPostreButton_Click(object sender, EventArgs e)
        {
            eliminarMenuForm frm = new eliminarMenuForm();
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
        }

        private void mostrarPlatillosPanel()
        {
            platillosDataGridView.Visible = true;
            bebidasDataGridView.Visible = false;
            postresDataGridView.Visible = false;
            platillosDataGridView.DataSource = BLConsultaElemento.PlatillosDT();
            
            platillosPanel.BackColor = Color.DodgerBlue;
            bebidasPanel.BackColor = Color.FromArgb(0, 87, 158);
            postresPanel.BackColor = Color.FromArgb(0, 87, 158);
        }

        private void mostrarBebidasPanel()
        {
            platillosDataGridView.Visible = false;
            bebidasDataGridView.Visible = true;
            postresDataGridView.Visible = false;
            bebidasDataGridView.DataSource = BLConsultaElemento.BebidasDT();

            platillosPanel.BackColor = Color.FromArgb(0, 87, 158);
            bebidasPanel.BackColor = Color.DodgerBlue;
            postresPanel.BackColor = Color.FromArgb(0, 87, 158);
        }

        private void mostrarPostresPanel()
        {
            platillosDataGridView.Visible = false;
            bebidasDataGridView.Visible = false;
            postresDataGridView.Visible = true;
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
        
    }
}
