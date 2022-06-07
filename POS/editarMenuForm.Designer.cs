
namespace POS
{
    partial class editarMenuForm
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
            this.encabezadoLabel = new System.Windows.Forms.Label();
            this.encabezadoPanel = new System.Windows.Forms.Panel();
            this.idLabel = new System.Windows.Forms.Label();
            this.idSeleccionadoLabel = new System.Windows.Forms.Label();
            this.descripcionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.seccionComboBox = new System.Windows.Forms.ComboBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.descripcionLabel = new System.Windows.Forms.Label();
            this.precioLabel = new System.Windows.Forms.Label();
            this.seccionLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.guardarCambiosButton = new System.Windows.Forms.Button();
            this.encabezadoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // encabezadoLabel
            // 
            this.encabezadoLabel.AutoSize = true;
            this.encabezadoLabel.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encabezadoLabel.ForeColor = System.Drawing.Color.White;
            this.encabezadoLabel.Location = new System.Drawing.Point(11, 9);
            this.encabezadoLabel.Name = "encabezadoLabel";
            this.encabezadoLabel.Size = new System.Drawing.Size(233, 25);
            this.encabezadoLabel.TabIndex = 0;
            this.encabezadoLabel.Text = "MODIFICAR EN MENÚ";
            // 
            // encabezadoPanel
            // 
            this.encabezadoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.encabezadoPanel.Controls.Add(this.encabezadoLabel);
            this.encabezadoPanel.Location = new System.Drawing.Point(1, 0);
            this.encabezadoPanel.Name = "encabezadoPanel";
            this.encabezadoPanel.Size = new System.Drawing.Size(525, 40);
            this.encabezadoPanel.TabIndex = 1;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Gadugi", 12F);
            this.idLabel.Location = new System.Drawing.Point(42, 84);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(38, 19);
            this.idLabel.TabIndex = 4;
            this.idLabel.Text = "ID - ";
            // 
            // idSeleccionadoLabel
            // 
            this.idSeleccionadoLabel.BackColor = System.Drawing.Color.Transparent;
            this.idSeleccionadoLabel.Font = new System.Drawing.Font("Gadugi", 12F);
            this.idSeleccionadoLabel.Location = new System.Drawing.Point(84, 83);
            this.idSeleccionadoLabel.Name = "idSeleccionadoLabel";
            this.idSeleccionadoLabel.Size = new System.Drawing.Size(100, 23);
            this.idSeleccionadoLabel.TabIndex = 5;
            // 
            // descripcionRichTextBox
            // 
            this.descripcionRichTextBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionRichTextBox.Location = new System.Drawing.Point(45, 250);
            this.descripcionRichTextBox.Name = "descripcionRichTextBox";
            this.descripcionRichTextBox.Size = new System.Drawing.Size(412, 171);
            this.descripcionRichTextBox.TabIndex = 15;
            this.descripcionRichTextBox.Text = "";
            // 
            // seccionComboBox
            // 
            this.seccionComboBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seccionComboBox.FormattingEnabled = true;
            this.seccionComboBox.Items.AddRange(new object[] {
            "PLATILLO",
            "BEBIDA",
            "POSTRE"});
            this.seccionComboBox.Location = new System.Drawing.Point(124, 170);
            this.seccionComboBox.Name = "seccionComboBox";
            this.seccionComboBox.Size = new System.Drawing.Size(121, 27);
            this.seccionComboBox.TabIndex = 14;
            // 
            // precioTextBox
            // 
            this.precioTextBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioTextBox.Location = new System.Drawing.Point(356, 170);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(100, 29);
            this.precioTextBox.TabIndex = 13;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(133, 124);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(323, 29);
            this.nombreTextBox.TabIndex = 12;
            // 
            // descripcionLabel
            // 
            this.descripcionLabel.AutoSize = true;
            this.descripcionLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionLabel.Location = new System.Drawing.Point(41, 228);
            this.descripcionLabel.Name = "descripcionLabel";
            this.descripcionLabel.Size = new System.Drawing.Size(111, 19);
            this.descripcionLabel.TabIndex = 11;
            this.descripcionLabel.Text = "DESCRIPCIÓN:";
            // 
            // precioLabel
            // 
            this.precioLabel.AutoSize = true;
            this.precioLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioLabel.Location = new System.Drawing.Point(285, 178);
            this.precioLabel.Name = "precioLabel";
            this.precioLabel.Size = new System.Drawing.Size(65, 19);
            this.precioLabel.TabIndex = 10;
            this.precioLabel.Text = "PRECIO:";
            // 
            // seccionLabel
            // 
            this.seccionLabel.AutoSize = true;
            this.seccionLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seccionLabel.Location = new System.Drawing.Point(41, 178);
            this.seccionLabel.Name = "seccionLabel";
            this.seccionLabel.Size = new System.Drawing.Size(77, 19);
            this.seccionLabel.TabIndex = 9;
            this.seccionLabel.Text = "SECCIÓN:";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLabel.Location = new System.Drawing.Point(41, 127);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(77, 19);
            this.nombreLabel.TabIndex = 8;
            this.nombreLabel.Text = "NOMBRE:";
            // 
            // cancelarButton
            // 
            this.cancelarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.cancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarButton.Location = new System.Drawing.Point(45, 445);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(87, 23);
            this.cancelarButton.TabIndex = 16;
            this.cancelarButton.Text = "CANCELAR";
            this.cancelarButton.UseVisualStyleBackColor = false;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // guardarCambiosButton
            // 
            this.guardarCambiosButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.guardarCambiosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarCambiosButton.Location = new System.Drawing.Point(289, 445);
            this.guardarCambiosButton.Name = "guardarCambiosButton";
            this.guardarCambiosButton.Size = new System.Drawing.Size(168, 23);
            this.guardarCambiosButton.TabIndex = 17;
            this.guardarCambiosButton.Text = "GUARDAR CAMBIOS";
            this.guardarCambiosButton.UseVisualStyleBackColor = false;
            // 
            // editarMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(525, 540);
            this.Controls.Add(this.guardarCambiosButton);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.descripcionRichTextBox);
            this.Controls.Add(this.seccionComboBox);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.descripcionLabel);
            this.Controls.Add(this.precioLabel);
            this.Controls.Add(this.seccionLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.idSeleccionadoLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.encabezadoPanel);
            this.Name = "editarMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar en menú";
            this.encabezadoPanel.ResumeLayout(false);
            this.encabezadoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label encabezadoLabel;
        private System.Windows.Forms.Panel encabezadoPanel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label idSeleccionadoLabel;
        private System.Windows.Forms.RichTextBox descripcionRichTextBox;
        private System.Windows.Forms.ComboBox seccionComboBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label descripcionLabel;
        private System.Windows.Forms.Label precioLabel;
        private System.Windows.Forms.Label seccionLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button guardarCambiosButton;
    }
}