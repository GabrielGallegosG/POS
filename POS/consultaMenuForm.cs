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

        private void inicioBbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            inicioForm frm = new inicioForm();
            frm.Show();
        }
    }
}
