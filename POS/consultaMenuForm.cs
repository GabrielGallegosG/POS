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
            PLConsultaMenu.posicionConsultaMenu(logoPictureBox,encabezadoLabel,platillosPanel,bebidasPanel,postresPanel, platillosDataGridView, bebidasDataGridView,postresDataGridView);
        }
    }
}
