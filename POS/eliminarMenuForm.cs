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
    public partial class eliminarMenuForm : Form
    {

        string id_editar;
        string nombre_editar;
        string precio_editar;
        string descripcion_editar;
        int seccion_editar;
        public eliminarMenuForm(string id, string nombre, string precio, int seccion, string descripcion)
        {
            id_editar = id;
            nombre_editar = nombre;
            precio_editar = precio;
            seccion_editar = seccion;
            descripcion_editar = descripcion;
            InitializeComponent();
            PLEliminarMenu.posicionEliminarMenu(encabezadoPanel, encabezadoLabel, idLabel, idSeleccionadoLabel, nombreLabel,nombreSeleccionadoLabel, seccionLabel, seccionSeleccionadoLabel, precioLabel,
                                            precioSeleccionadoLabel, notaRichTextBox, cancelarButton, eliminarButton);
        }

        private void cancelarButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eliminarMenuForm_Load(object sender, EventArgs e)
        {
            ActiveControl = null;
            idSeleccionadoLabel.Text = id_editar;
            nombreSeleccionadoLabel.Text = nombre_editar;
            precioSeleccionadoLabel.Text = precio_editar;
            
            string seccion = "";
            if (seccion_editar == 0)
                seccionSeleccionadoLabel.Text = "PLATILLO";
            else
                if (seccion_editar == 1)
                    seccionSeleccionadoLabel.Text = "BEBIDA";
            else
                    if (seccion_editar == 2)
                    seccionSeleccionadoLabel.Text = "POSTRE";
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            string resultado = BLEditarElemento.idSeleccionadoDT(nombreSeleccionadoLabel.Text);
            int id = Int32.Parse(resultado);
            BLEliminarElemento.EliminarnDT(id);
            MessageBox.Show("¡Se ha eliminado con exito!", "Eliminación de elemento", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void notaRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
