
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
            this.guardarButton = new buttonSystem();
            this.cancelarButton = new buttonSystem();
            this.encabezadoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // encabezadoLabel
            // 
            this.encabezadoLabel.AutoSize = true;
            this.encabezadoLabel.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encabezadoLabel.ForeColor = System.Drawing.Color.White;
            this.encabezadoLabel.Location = new System.Drawing.Point(15, 11);
            this.encabezadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.encabezadoLabel.Name = "encabezadoLabel";
            this.encabezadoLabel.Size = new System.Drawing.Size(297, 32);
            this.encabezadoLabel.TabIndex = 0;
            this.encabezadoLabel.Text = "MODIFICAR EN MENÚ";
            // 
            // encabezadoPanel
            // 
            this.encabezadoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.encabezadoPanel.Controls.Add(this.encabezadoLabel);
            this.encabezadoPanel.Location = new System.Drawing.Point(1, 0);
            this.encabezadoPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.encabezadoPanel.Name = "encabezadoPanel";
            this.encabezadoPanel.Size = new System.Drawing.Size(700, 49);
            this.encabezadoPanel.TabIndex = 1;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Gadugi", 12F);
            this.idLabel.Location = new System.Drawing.Point(56, 103);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(47, 24);
            this.idLabel.TabIndex = 4;
            this.idLabel.Text = "ID - ";
            // 
            // idSeleccionadoLabel
            // 
            this.idSeleccionadoLabel.BackColor = System.Drawing.Color.Transparent;
            this.idSeleccionadoLabel.Font = new System.Drawing.Font("Gadugi", 12F);
            this.idSeleccionadoLabel.Location = new System.Drawing.Point(112, 102);
            this.idSeleccionadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idSeleccionadoLabel.Name = "idSeleccionadoLabel";
            this.idSeleccionadoLabel.Size = new System.Drawing.Size(133, 28);
            this.idSeleccionadoLabel.TabIndex = 5;
            // 
            // descripcionRichTextBox
            // 
            this.descripcionRichTextBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionRichTextBox.Location = new System.Drawing.Point(60, 308);
            this.descripcionRichTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descripcionRichTextBox.Name = "descripcionRichTextBox";
            this.descripcionRichTextBox.Size = new System.Drawing.Size(548, 210);
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
            this.seccionComboBox.Location = new System.Drawing.Point(165, 209);
            this.seccionComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.seccionComboBox.Name = "seccionComboBox";
            this.seccionComboBox.Size = new System.Drawing.Size(160, 32);
            this.seccionComboBox.TabIndex = 14;
            // 
            // precioTextBox
            // 
            this.precioTextBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioTextBox.Location = new System.Drawing.Point(475, 209);
            this.precioTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(132, 34);
            this.precioTextBox.TabIndex = 13;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(177, 153);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(429, 34);
            this.nombreTextBox.TabIndex = 12;
            // 
            // descripcionLabel
            // 
            this.descripcionLabel.AutoSize = true;
            this.descripcionLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionLabel.Location = new System.Drawing.Point(55, 281);
            this.descripcionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descripcionLabel.Name = "descripcionLabel";
            this.descripcionLabel.Size = new System.Drawing.Size(136, 24);
            this.descripcionLabel.TabIndex = 11;
            this.descripcionLabel.Text = "DESCRIPCIÓN:";
            // 
            // precioLabel
            // 
            this.precioLabel.AutoSize = true;
            this.precioLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioLabel.Location = new System.Drawing.Point(380, 219);
            this.precioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.precioLabel.Name = "precioLabel";
            this.precioLabel.Size = new System.Drawing.Size(79, 24);
            this.precioLabel.TabIndex = 10;
            this.precioLabel.Text = "PRECIO:";
            // 
            // seccionLabel
            // 
            this.seccionLabel.AutoSize = true;
            this.seccionLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seccionLabel.Location = new System.Drawing.Point(55, 219);
            this.seccionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.seccionLabel.Name = "seccionLabel";
            this.seccionLabel.Size = new System.Drawing.Size(94, 24);
            this.seccionLabel.TabIndex = 9;
            this.seccionLabel.Text = "SECCIÓN:";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLabel.Location = new System.Drawing.Point(55, 156);
            this.nombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(95, 24);
            this.nombreLabel.TabIndex = 8;
            this.nombreLabel.Text = "NOMBRE:";
            // 
            // guardarButton
            // 
            this.guardarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.guardarButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.guardarButton.BorderRadius = 20;
            this.guardarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardarButton.FlatAppearance.BorderSize = 0;
            this.guardarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(60)))));
            this.guardarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarButton.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold);
            this.guardarButton.ForeColor = System.Drawing.Color.Black;
            this.guardarButton.Location = new System.Drawing.Point(475, 583);
            this.guardarButton.Margin = new System.Windows.Forms.Padding(4);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Padding = new System.Windows.Forms.Padding(4);
            this.guardarButton.Size = new System.Drawing.Size(133, 43);
            this.guardarButton.TabIndex = 19;
            this.guardarButton.Text = "GUARDAR";
            this.guardarButton.UseVisualStyleBackColor = false;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.cancelarButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.cancelarButton.BorderRadius = 20;
            this.cancelarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarButton.FlatAppearance.BorderSize = 0;
            this.cancelarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(60)))));
            this.cancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarButton.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold);
            this.cancelarButton.ForeColor = System.Drawing.Color.Black;
            this.cancelarButton.Location = new System.Drawing.Point(60, 585);
            this.cancelarButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Padding = new System.Windows.Forms.Padding(4);
            this.cancelarButton.Size = new System.Drawing.Size(131, 42);
            this.cancelarButton.TabIndex = 18;
            this.cancelarButton.Text = "CANCELAR";
            this.cancelarButton.UseVisualStyleBackColor = false;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click_1);
            // 
            // editarMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 665);
            this.Controls.Add(this.guardarButton);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "editarMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar en menú";
            this.Load += new System.EventHandler(this.editarMenuForm_Load);
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
        private buttonSystem cancelarButton;
        private buttonSystem guardarButton;
    }
}