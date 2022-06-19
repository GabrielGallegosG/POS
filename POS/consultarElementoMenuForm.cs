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
    public partial class consultarElementoMenuForm : Form
    {

        string id_editar;
        string nombre_editar;
        string precio_editar;
        string descripcion_editar;
        string seccion_editar;
        public consultarElementoMenuForm(string id, string nombre, string precio, int seccion, string descripcion)
        {
            InitializeComponent();
            PLConsultarElementoMenu.posicionConsultarElementorMenu(encabezadoPanel, encabezadoLabel, idLabel, idSeleccionadoLabel, nombreLabel
                                    ,nombreTextBox, precioLabel, precioTextBox, descripcionLabel, descripcionRichTextBox, editarButton, eliminarButton, regresarButton);
            id_editar = id;
            nombre_editar = nombre;

            if (seccion == 1)
                seccion_editar = "PLATILLO";
            else
                if (seccion == 2)
                    seccion_editar = "BEBIDA";
                else
                    if (seccion == 3)
                        seccion_editar = "POSTRE";

            precio_editar = precio;
            descripcion_editar = descripcion;
        }


        private void consultarElementoMenuForm_Load(object sender, EventArgs e)
        {

            idSeleccionadoLabel.Text = id_editar;
            nombreTextBox.Text = nombre_editar;
            precioTextBox.Text = precio_editar;
            descripcionRichTextBox.Text = descripcion_editar;
            encabezadoLabel.Text = seccion_editar;
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            string id = BLEditarElemento.idSeleccionadoDT(nombreTextBox.Text);
            string precio = BLEditarElemento.precioSeleccionadoDT(nombreTextBox.Text);
            int platillo = 0;
            string descripcion = BLEditarElemento.descripcionSeleccionadoDT(nombreTextBox.Text);

            editarMenuForm frmEd = new editarMenuForm(id, nombreTextBox.Text, precio, platillo, descripcion);
            this.Hide();
            frmEd.ShowDialog();
            this.Close();
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            string id = BLEditarElemento.idSeleccionadoDT(nombreTextBox.Text);
            string precio = BLEditarElemento.precioSeleccionadoDT(nombreTextBox.Text);
            int platillo = 0;
            string descripcion = BLEditarElemento.descripcionSeleccionadoDT(nombreTextBox.Text);

            eliminarMenuForm frm = new eliminarMenuForm(id, nombreTextBox.Text, precio, platillo, descripcion);
            this.Hide();
            frm.ShowDialog();
            this.Close();

        }

        private void regresarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
