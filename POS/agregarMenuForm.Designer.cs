using System.Drawing.Drawing2D;

namespace POS
{
    partial class agregarMenuForm
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
            this.nombreLabel = new System.Windows.Forms.Label();
            this.seccionLabel = new System.Windows.Forms.Label();
            this.precioLabel = new System.Windows.Forms.Label();
            this.descripcionLabel = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.seccionComboBox = new System.Windows.Forms.ComboBox();
            this.descripcionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.encabezadoLabel = new System.Windows.Forms.Label();
            this.encabezadoPanel = new System.Windows.Forms.Panel();
            this.agregarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.encabezadoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLabel.Location = new System.Drawing.Point(52, 94);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(77, 19);
            this.nombreLabel.TabIndex = 0;
            this.nombreLabel.Text = "NOMBRE:";
            // 
            // seccionLabel
            // 
            this.seccionLabel.AutoSize = true;
            this.seccionLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seccionLabel.Location = new System.Drawing.Point(52, 145);
            this.seccionLabel.Name = "seccionLabel";
            this.seccionLabel.Size = new System.Drawing.Size(77, 19);
            this.seccionLabel.TabIndex = 1;
            this.seccionLabel.Text = "SECCIÓN:";
            // 
            // precioLabel
            // 
            this.precioLabel.AutoSize = true;
            this.precioLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioLabel.Location = new System.Drawing.Point(296, 145);
            this.precioLabel.Name = "precioLabel";
            this.precioLabel.Size = new System.Drawing.Size(65, 19);
            this.precioLabel.TabIndex = 2;
            this.precioLabel.Text = "PRECIO:";
            // 
            // descripcionLabel
            // 
            this.descripcionLabel.AutoSize = true;
            this.descripcionLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionLabel.Location = new System.Drawing.Point(52, 195);
            this.descripcionLabel.Name = "descripcionLabel";
            this.descripcionLabel.Size = new System.Drawing.Size(111, 19);
            this.descripcionLabel.TabIndex = 3;
            this.descripcionLabel.Text = "DESCRIPCIÓN:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(144, 91);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(323, 29);
            this.nombreTextBox.TabIndex = 4;
            this.nombreTextBox.TextChanged += new System.EventHandler(this.nombreTextBox_TextChanged);
            // 
            // precioTextBox
            // 
            this.precioTextBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioTextBox.Location = new System.Drawing.Point(367, 137);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(100, 29);
            this.precioTextBox.TabIndex = 5;
            // 
            // seccionComboBox
            // 
            this.seccionComboBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seccionComboBox.FormattingEnabled = true;
            this.seccionComboBox.Items.AddRange(new object[] {
            "PLATILLO",
            "BEBIDA",
            "POSTRE"});
            this.seccionComboBox.Location = new System.Drawing.Point(135, 137);
            this.seccionComboBox.Name = "seccionComboBox";
            this.seccionComboBox.Size = new System.Drawing.Size(121, 27);
            this.seccionComboBox.TabIndex = 6;
            // 
            // descripcionRichTextBox
            // 
            this.descripcionRichTextBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionRichTextBox.Location = new System.Drawing.Point(56, 217);
            this.descripcionRichTextBox.Name = "descripcionRichTextBox";
            this.descripcionRichTextBox.Size = new System.Drawing.Size(412, 171);
            this.descripcionRichTextBox.TabIndex = 7;
            this.descripcionRichTextBox.Text = "";
            // 
            // encabezadoLabel
            // 
            this.encabezadoLabel.AutoSize = true;
            this.encabezadoLabel.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encabezadoLabel.ForeColor = System.Drawing.Color.White;
            this.encabezadoLabel.Location = new System.Drawing.Point(139, 0);
            this.encabezadoLabel.Name = "encabezadoLabel";
            this.encabezadoLabel.Size = new System.Drawing.Size(201, 25);
            this.encabezadoLabel.TabIndex = 9;
            this.encabezadoLabel.Text = "AGREGAR A MENÚ";
            // 
            // encabezadoPanel
            // 
            this.encabezadoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.encabezadoPanel.Controls.Add(this.encabezadoLabel);
            this.encabezadoPanel.Location = new System.Drawing.Point(0, 12);
            this.encabezadoPanel.Name = "encabezadoPanel";
            this.encabezadoPanel.Size = new System.Drawing.Size(525, 38);
            this.encabezadoPanel.TabIndex = 10;
            // 
            // agregarButton
            // 
            this.agregarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.agregarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarButton.Location = new System.Drawing.Point(393, 400);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(75, 23);
            this.agregarButton.TabIndex = 11;
            this.agregarButton.Text = "AGREGAR";
            this.agregarButton.UseVisualStyleBackColor = false;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.cancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarButton.Location = new System.Drawing.Point(11, 400);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(87, 23);
            this.cancelarButton.TabIndex = 12;
            this.cancelarButton.Text = "CANCELAR";
            this.cancelarButton.UseVisualStyleBackColor = false;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // agregarMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 490);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.encabezadoPanel);
            this.Controls.Add(this.descripcionRichTextBox);
            this.Controls.Add(this.seccionComboBox);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.descripcionLabel);
            this.Controls.Add(this.precioLabel);
            this.Controls.Add(this.seccionLabel);
            this.Controls.Add(this.nombreLabel);
            this.Name = "agregarMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar a Menu";
            this.Load += new System.EventHandler(this.agregarMenuForm_Load);
            this.encabezadoPanel.ResumeLayout(false);
            this.encabezadoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label seccionLabel;
        private System.Windows.Forms.Label precioLabel;
        private System.Windows.Forms.Label descripcionLabel;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.ComboBox seccionComboBox;
        private System.Windows.Forms.RichTextBox descripcionRichTextBox;
        private System.Windows.Forms.Label encabezadoLabel;
        private System.Windows.Forms.Panel encabezadoPanel;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.Button cancelarButton;
    }
}