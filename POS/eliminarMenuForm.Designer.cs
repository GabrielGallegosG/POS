
namespace POS
{
    partial class eliminarMenuForm
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
            this.idSeleccionadoLabel = new System.Windows.Forms.Label();
            this.encabezadoPanel = new System.Windows.Forms.Panel();
            this.encabezadoLabel = new System.Windows.Forms.Label();
            this.notaRichTextBox = new System.Windows.Forms.RichTextBox();
            this.nombreSeleccionadoLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.seccionSeleccionadoLabel = new System.Windows.Forms.Label();
            this.precioSeleccionadoLabel = new System.Windows.Forms.Label();
            this.seccionLabel = new System.Windows.Forms.Label();
            this.precioLabel = new System.Windows.Forms.Label();
            this.cancelarButton = new buttonSystem();
            this.eliminarButton = new buttonSystem();
            this.encabezadoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLabel.Location = new System.Drawing.Point(53, 156);
            this.nombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(95, 24);
            this.nombreLabel.TabIndex = 18;
            this.nombreLabel.Text = "NOMBRE:";
            // 
            // idSeleccionadoLabel
            // 
            this.idSeleccionadoLabel.BackColor = System.Drawing.Color.Transparent;
            this.idSeleccionadoLabel.Font = new System.Drawing.Font("Gadugi", 12F);
            this.idSeleccionadoLabel.Location = new System.Drawing.Point(111, 102);
            this.idSeleccionadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idSeleccionadoLabel.Name = "idSeleccionadoLabel";
            this.idSeleccionadoLabel.Size = new System.Drawing.Size(133, 28);
            this.idSeleccionadoLabel.TabIndex = 17;
            // 
            // encabezadoPanel
            // 
            this.encabezadoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.encabezadoPanel.Controls.Add(this.encabezadoLabel);
            this.encabezadoPanel.Location = new System.Drawing.Point(0, 0);
            this.encabezadoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.encabezadoPanel.Name = "encabezadoPanel";
            this.encabezadoPanel.Size = new System.Drawing.Size(765, 49);
            this.encabezadoPanel.TabIndex = 15;
            // 
            // encabezadoLabel
            // 
            this.encabezadoLabel.AutoSize = true;
            this.encabezadoLabel.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encabezadoLabel.ForeColor = System.Drawing.Color.White;
            this.encabezadoLabel.Location = new System.Drawing.Point(15, 11);
            this.encabezadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.encabezadoLabel.Name = "encabezadoLabel";
            this.encabezadoLabel.Size = new System.Drawing.Size(704, 32);
            this.encabezadoLabel.TabIndex = 0;
            this.encabezadoLabel.Text = "¿SE ENCUENTRA SEGURO DE REALIZAR ESTA ACCIÓN?";
            // 
            // notaRichTextBox
            // 
            this.notaRichTextBox.BackColor = System.Drawing.Color.White;
            this.notaRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notaRichTextBox.Font = new System.Drawing.Font("Gadugi", 12F);
            this.notaRichTextBox.Location = new System.Drawing.Point(21, 320);
            this.notaRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.notaRichTextBox.Name = "notaRichTextBox";
            this.notaRichTextBox.ReadOnly = true;
            this.notaRichTextBox.Size = new System.Drawing.Size(655, 75);
            this.notaRichTextBox.TabIndex = 27;
            this.notaRichTextBox.Text = "*Nota: Se eliminará de manera permanente el elemento seleccionado.\nSeleccione “El" +
    "iminar” para continuar con la acción…";
            this.notaRichTextBox.TextChanged += new System.EventHandler(this.notaRichTextBox_TextChanged);
            // 
            // nombreSeleccionadoLabel
            // 
            this.nombreSeleccionadoLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreSeleccionadoLabel.Location = new System.Drawing.Point(164, 156);
            this.nombreSeleccionadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombreSeleccionadoLabel.Name = "nombreSeleccionadoLabel";
            this.nombreSeleccionadoLabel.Size = new System.Drawing.Size(103, 23);
            this.nombreSeleccionadoLabel.TabIndex = 28;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Gadugi", 12F);
            this.idLabel.Location = new System.Drawing.Point(55, 103);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(47, 24);
            this.idLabel.TabIndex = 16;
            this.idLabel.Text = "ID - ";
            // 
            // seccionSeleccionadoLabel
            // 
            this.seccionSeleccionadoLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seccionSeleccionadoLabel.Location = new System.Drawing.Point(164, 219);
            this.seccionSeleccionadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.seccionSeleccionadoLabel.Name = "seccionSeleccionadoLabel";
            this.seccionSeleccionadoLabel.Size = new System.Drawing.Size(103, 23);
            this.seccionSeleccionadoLabel.TabIndex = 29;
            // 
            // precioSeleccionadoLabel
            // 
            this.precioSeleccionadoLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioSeleccionadoLabel.Location = new System.Drawing.Point(493, 219);
            this.precioSeleccionadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.precioSeleccionadoLabel.Name = "precioSeleccionadoLabel";
            this.precioSeleccionadoLabel.Size = new System.Drawing.Size(87, 23);
            this.precioSeleccionadoLabel.TabIndex = 30;
            // 
            // seccionLabel
            // 
            this.seccionLabel.AutoSize = true;
            this.seccionLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seccionLabel.Location = new System.Drawing.Point(53, 219);
            this.seccionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.seccionLabel.Name = "seccionLabel";
            this.seccionLabel.Size = new System.Drawing.Size(94, 24);
            this.seccionLabel.TabIndex = 19;
            this.seccionLabel.Text = "SECCIÓN:";
            // 
            // precioLabel
            // 
            this.precioLabel.AutoSize = true;
            this.precioLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioLabel.Location = new System.Drawing.Point(379, 219);
            this.precioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.precioLabel.Name = "precioLabel";
            this.precioLabel.Size = new System.Drawing.Size(79, 24);
            this.precioLabel.TabIndex = 20;
            this.precioLabel.Text = "PRECIO:";
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
            this.cancelarButton.Location = new System.Drawing.Point(21, 402);
            this.cancelarButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Padding = new System.Windows.Forms.Padding(4);
            this.cancelarButton.Size = new System.Drawing.Size(161, 48);
            this.cancelarButton.TabIndex = 31;
            this.cancelarButton.Text = "CANCELAR";
            this.cancelarButton.UseVisualStyleBackColor = false;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click_1);
            // 
            // eliminarButton
            // 
            this.eliminarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.eliminarButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.eliminarButton.BorderRadius = 20;
            this.eliminarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarButton.FlatAppearance.BorderSize = 0;
            this.eliminarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(60)))));
            this.eliminarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarButton.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold);
            this.eliminarButton.ForeColor = System.Drawing.Color.Black;
            this.eliminarButton.Location = new System.Drawing.Point(515, 402);
            this.eliminarButton.Margin = new System.Windows.Forms.Padding(4);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Padding = new System.Windows.Forms.Padding(4);
            this.eliminarButton.Size = new System.Drawing.Size(161, 48);
            this.eliminarButton.TabIndex = 32;
            this.eliminarButton.Text = "ELIMINAR";
            this.eliminarButton.UseVisualStyleBackColor = false;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // eliminarMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(759, 469);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.precioSeleccionadoLabel);
            this.Controls.Add(this.seccionSeleccionadoLabel);
            this.Controls.Add(this.nombreSeleccionadoLabel);
            this.Controls.Add(this.notaRichTextBox);
            this.Controls.Add(this.precioLabel);
            this.Controls.Add(this.seccionLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.idSeleccionadoLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.encabezadoPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "eliminarMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar";
            this.Load += new System.EventHandler(this.eliminarMenuForm_Load);
            this.encabezadoPanel.ResumeLayout(false);
            this.encabezadoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label idSeleccionadoLabel;
        private System.Windows.Forms.Panel encabezadoPanel;
        private System.Windows.Forms.Label encabezadoLabel;
        private System.Windows.Forms.RichTextBox notaRichTextBox;
        private System.Windows.Forms.Label nombreSeleccionadoLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label seccionSeleccionadoLabel;
        private System.Windows.Forms.Label precioSeleccionadoLabel;
        private System.Windows.Forms.Label seccionLabel;
        private System.Windows.Forms.Label precioLabel;
        private buttonSystem cancelarButton;
        private buttonSystem eliminarButton;
    }
}