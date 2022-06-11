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
        }

        private void agregarMenuButton_Click(object sender, EventArgs e)
        {
            agregarMenuForm frm = new agregarMenuForm();
            frm.Show();
        }

        private void editarPlatilloButton_Click(object sender, EventArgs e)
        {
            editarMenuForm frm = new editarMenuForm();
            frm.Show();
        }

        private void editarBebidaButton_Click(object sender, EventArgs e)
        {
            editarMenuForm frm = new editarMenuForm();
            frm.Show();
        }

        private void editarPostreButton_Click(object sender, EventArgs e)
        {
            editarMenuForm frm = new editarMenuForm();
            frm.Show();
        }

        private void eliminarPlatilloButton_Click(object sender, EventArgs e)
        {
            eliminarMenuForm frm = new eliminarMenuForm();
            frm.Show();
        }

        private void eliminarBebidaButton_Click(object sender, EventArgs e)
        {
            eliminarMenuForm frm = new eliminarMenuForm();
            frm.Show();
        }

        private void eliminarPostreButton_Click(object sender, EventArgs e)
        {
            eliminarMenuForm frm = new eliminarMenuForm();
            frm.Show();
        }

        //Botones encabezado
        private void ordenesButton_Click(object sender, EventArgs e)
        {
            //consultaOrdenesForm frm = new consultaOrdenesForm();
            //frm.Show();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            consultaMenuForm frm = new consultaMenuForm();
            frm.Show();
        }
    }
}
