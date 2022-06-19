
namespace POS
{
    partial class consultarElementoMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultarElementoMenuForm));
            this.descripcionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.descripcionLabel = new System.Windows.Forms.Label();
            this.precioLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.encabezadoPanel = new System.Windows.Forms.Panel();
            this.encabezadoLabel = new System.Windows.Forms.Label();
            this.editarButton = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.idSeleccionadoLabel = new System.Windows.Forms.Label();
            this.regresarButton = new buttonSystem();
            this.encabezadoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // descripcionRichTextBox
            // 
            this.descripcionRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descripcionRichTextBox.BackColor = System.Drawing.Color.White;
            this.descripcionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descripcionRichTextBox.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionRichTextBox.ForeColor = System.Drawing.Color.Black;
            this.descripcionRichTextBox.Location = new System.Drawing.Point(59, 307);
            this.descripcionRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descripcionRichTextBox.Name = "descripcionRichTextBox";
            this.descripcionRichTextBox.ReadOnly = true;
            this.descripcionRichTextBox.Size = new System.Drawing.Size(549, 210);
            this.descripcionRichTextBox.TabIndex = 25;
            this.descripcionRichTextBox.Text = "";
            // 
            // descripcionLabel
            // 
            this.descripcionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descripcionLabel.AutoSize = true;
            this.descripcionLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionLabel.Location = new System.Drawing.Point(54, 280);
            this.descripcionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descripcionLabel.Name = "descripcionLabel";
            this.descripcionLabel.Size = new System.Drawing.Size(136, 24);
            this.descripcionLabel.TabIndex = 24;
            this.descripcionLabel.Text = "DESCRIPCIÓN:";
            // 
            // precioLabel
            // 
            this.precioLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.precioLabel.AutoSize = true;
            this.precioLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioLabel.Location = new System.Drawing.Point(405, 103);
            this.precioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.precioLabel.Name = "precioLabel";
            this.precioLabel.Size = new System.Drawing.Size(100, 24);
            this.precioLabel.TabIndex = 23;
            this.precioLabel.Text = "PRECIO:  $";
            // 
            // nombreLabel
            // 
            this.nombreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLabel.Location = new System.Drawing.Point(54, 155);
            this.nombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(95, 24);
            this.nombreLabel.TabIndex = 21;
            this.nombreLabel.Text = "NOMBRE:";
            // 
            // idLabel
            // 
            this.idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Gadugi", 12F);
            this.idLabel.Location = new System.Drawing.Point(54, 103);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(47, 24);
            this.idLabel.TabIndex = 20;
            this.idLabel.Text = "ID - ";
            // 
            // encabezadoPanel
            // 
            this.encabezadoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.encabezadoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.encabezadoPanel.Controls.Add(this.encabezadoLabel);
            this.encabezadoPanel.Location = new System.Drawing.Point(0, -1);
            this.encabezadoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.encabezadoPanel.Name = "encabezadoPanel";
            this.encabezadoPanel.Size = new System.Drawing.Size(701, 49);
            this.encabezadoPanel.TabIndex = 19;
            // 
            // encabezadoLabel
            // 
            this.encabezadoLabel.AutoSize = true;
            this.encabezadoLabel.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encabezadoLabel.ForeColor = System.Drawing.Color.White;
            this.encabezadoLabel.Location = new System.Drawing.Point(13, 10);
            this.encabezadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.encabezadoLabel.Name = "encabezadoLabel";
            this.encabezadoLabel.Size = new System.Drawing.Size(128, 32);
            this.encabezadoLabel.TabIndex = 0;
            this.encabezadoLabel.Text = "SECCION";
            // 
            // editarButton
            // 
            this.editarButton.BackColor = System.Drawing.Color.Transparent;
            this.editarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editarButton.BackgroundImage")));
            this.editarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editarButton.FlatAppearance.BorderSize = 0;
            this.editarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarButton.Location = new System.Drawing.Point(555, 588);
            this.editarButton.Margin = new System.Windows.Forms.Padding(4);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(53, 37);
            this.editarButton.TabIndex = 29;
            this.editarButton.UseVisualStyleBackColor = false;
            this.editarButton.Click += new System.EventHandler(this.editarButton_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.BackColor = System.Drawing.Color.Transparent;
            this.eliminarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eliminarButton.BackgroundImage")));
            this.eliminarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eliminarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarButton.FlatAppearance.BorderSize = 0;
            this.eliminarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarButton.Location = new System.Drawing.Point(599, 588);
            this.eliminarButton.Margin = new System.Windows.Forms.Padding(4);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(53, 37);
            this.eliminarButton.TabIndex = 28;
            this.eliminarButton.UseVisualStyleBackColor = false;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // precioTextBox
            // 
            this.precioTextBox.BackColor = System.Drawing.Color.White;
            this.precioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.precioTextBox.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioTextBox.ForeColor = System.Drawing.Color.Black;
            this.precioTextBox.Location = new System.Drawing.Point(533, 103);
            this.precioTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(107, 31);
            this.precioTextBox.TabIndex = 32;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.BackColor = System.Drawing.Color.White;
            this.nombreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombreTextBox.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.ForeColor = System.Drawing.Color.Black;
            this.nombreTextBox.Location = new System.Drawing.Point(162, 152);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(464, 31);
            this.nombreTextBox.TabIndex = 31;
            // 
            // idSeleccionadoLabel
            // 
            this.idSeleccionadoLabel.BackColor = System.Drawing.Color.White;
            this.idSeleccionadoLabel.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idSeleccionadoLabel.ForeColor = System.Drawing.Color.Black;
            this.idSeleccionadoLabel.Location = new System.Drawing.Point(101, 101);
            this.idSeleccionadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idSeleccionadoLabel.Name = "idSeleccionadoLabel";
            this.idSeleccionadoLabel.Size = new System.Drawing.Size(133, 28);
            this.idSeleccionadoLabel.TabIndex = 30;
            // 
            // regresarButton
            // 
            this.regresarButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regresarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.regresarButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.regresarButton.BorderRadius = 20;
            this.regresarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regresarButton.FlatAppearance.BorderSize = 0;
            this.regresarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(60)))));
            this.regresarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regresarButton.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold);
            this.regresarButton.ForeColor = System.Drawing.Color.Black;
            this.regresarButton.Location = new System.Drawing.Point(59, 584);
            this.regresarButton.Margin = new System.Windows.Forms.Padding(4);
            this.regresarButton.Name = "regresarButton";
            this.regresarButton.Padding = new System.Windows.Forms.Padding(4);
            this.regresarButton.Size = new System.Drawing.Size(131, 42);
            this.regresarButton.TabIndex = 26;
            this.regresarButton.Text = "REGRESAR";
            this.regresarButton.UseVisualStyleBackColor = false;
            this.regresarButton.Click += new System.EventHandler(this.regresarButton_Click);
            // 
            // consultarElementoMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 665);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.idSeleccionadoLabel);
            this.Controls.Add(this.editarButton);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.regresarButton);
            this.Controls.Add(this.descripcionRichTextBox);
            this.Controls.Add(this.descripcionLabel);
            this.Controls.Add(this.precioLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.encabezadoPanel);
            this.MaximizeBox = false;
            this.Name = "consultarElementoMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elemento de Menú";
            this.Load += new System.EventHandler(this.consultarElementoMenuForm_Load);
            this.encabezadoPanel.ResumeLayout(false);
            this.encabezadoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private buttonSystem regresarButton;
        private System.Windows.Forms.RichTextBox descripcionRichTextBox;
        private System.Windows.Forms.Label descripcionLabel;
        private System.Windows.Forms.Label precioLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Panel encabezadoPanel;
        private System.Windows.Forms.Label encabezadoLabel;
        private System.Windows.Forms.Button editarButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label idSeleccionadoLabel;
    }
}