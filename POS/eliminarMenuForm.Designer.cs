﻿
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
            this.nombreLabel.Location = new System.Drawing.Point(40, 127);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(77, 19);
            this.nombreLabel.TabIndex = 18;
            this.nombreLabel.Text = "NOMBRE:";
            // 
            // idSeleccionadoLabel
            // 
            this.idSeleccionadoLabel.BackColor = System.Drawing.Color.Transparent;
            this.idSeleccionadoLabel.Font = new System.Drawing.Font("Gadugi", 12F);
            this.idSeleccionadoLabel.Location = new System.Drawing.Point(83, 83);
            this.idSeleccionadoLabel.Name = "idSeleccionadoLabel";
            this.idSeleccionadoLabel.Size = new System.Drawing.Size(100, 23);
            this.idSeleccionadoLabel.TabIndex = 17;
            // 
            // encabezadoPanel
            // 
            this.encabezadoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.encabezadoPanel.Controls.Add(this.encabezadoLabel);
            this.encabezadoPanel.Location = new System.Drawing.Point(0, 0);
            this.encabezadoPanel.Name = "encabezadoPanel";
            this.encabezadoPanel.Size = new System.Drawing.Size(574, 40);
            this.encabezadoPanel.TabIndex = 15;
            // 
            // encabezadoLabel
            // 
            this.encabezadoLabel.AutoSize = true;
            this.encabezadoLabel.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encabezadoLabel.ForeColor = System.Drawing.Color.White;
            this.encabezadoLabel.Location = new System.Drawing.Point(11, 9);
            this.encabezadoLabel.Name = "encabezadoLabel";
            this.encabezadoLabel.Size = new System.Drawing.Size(554, 25);
            this.encabezadoLabel.TabIndex = 0;
            this.encabezadoLabel.Text = "¿SE ENCUENTRA SEGURO DE REALIZAR ESTA ACCIÓN?";
            // 
            // notaRichTextBox
            // 
            this.notaRichTextBox.BackColor = System.Drawing.Color.White;
            this.notaRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notaRichTextBox.Font = new System.Drawing.Font("Gadugi", 12F);
            this.notaRichTextBox.Location = new System.Drawing.Point(16, 260);
            this.notaRichTextBox.Name = "notaRichTextBox";
            this.notaRichTextBox.ReadOnly = true;
            this.notaRichTextBox.Size = new System.Drawing.Size(491, 61);
            this.notaRichTextBox.TabIndex = 27;
            this.notaRichTextBox.Text = "*Nota: Se eliminará de manera permanente el elemento seleccionado.\nSeleccione “El" +
    "iminar” para continuar con la acción…";
            // 
            // nombreSeleccionadoLabel
            // 
            this.nombreSeleccionadoLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreSeleccionadoLabel.Location = new System.Drawing.Point(123, 127);
            this.nombreSeleccionadoLabel.Name = "nombreSeleccionadoLabel";
            this.nombreSeleccionadoLabel.Size = new System.Drawing.Size(77, 19);
            this.nombreSeleccionadoLabel.TabIndex = 28;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Gadugi", 12F);
            this.idLabel.Location = new System.Drawing.Point(41, 84);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(38, 19);
            this.idLabel.TabIndex = 16;
            this.idLabel.Text = "ID - ";
            // 
            // seccionSeleccionadoLabel
            // 
            this.seccionSeleccionadoLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seccionSeleccionadoLabel.Location = new System.Drawing.Point(123, 178);
            this.seccionSeleccionadoLabel.Name = "seccionSeleccionadoLabel";
            this.seccionSeleccionadoLabel.Size = new System.Drawing.Size(77, 19);
            this.seccionSeleccionadoLabel.TabIndex = 29;
            // 
            // precioSeleccionadoLabel
            // 
            this.precioSeleccionadoLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioSeleccionadoLabel.Location = new System.Drawing.Point(370, 178);
            this.precioSeleccionadoLabel.Name = "precioSeleccionadoLabel";
            this.precioSeleccionadoLabel.Size = new System.Drawing.Size(65, 19);
            this.precioSeleccionadoLabel.TabIndex = 30;
            // 
            // seccionLabel
            // 
            this.seccionLabel.AutoSize = true;
            this.seccionLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seccionLabel.Location = new System.Drawing.Point(40, 178);
            this.seccionLabel.Name = "seccionLabel";
            this.seccionLabel.Size = new System.Drawing.Size(77, 19);
            this.seccionLabel.TabIndex = 19;
            this.seccionLabel.Text = "SECCIÓN:";
            // 
            // precioLabel
            // 
            this.precioLabel.AutoSize = true;
            this.precioLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioLabel.Location = new System.Drawing.Point(284, 178);
            this.precioLabel.Name = "precioLabel";
            this.precioLabel.Size = new System.Drawing.Size(65, 19);
            this.precioLabel.TabIndex = 20;
            this.precioLabel.Text = "PRECIO:";
            // 
            // cancelarButton
            // 
            this.cancelarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.cancelarButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.cancelarButton.BorderRadius = 20;
            this.cancelarButton.FlatAppearance.BorderSize = 0;
            this.cancelarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(60)))));
            this.cancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarButton.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold);
            this.cancelarButton.ForeColor = System.Drawing.Color.Black;
            this.cancelarButton.Location = new System.Drawing.Point(16, 327);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Padding = new System.Windows.Forms.Padding(3);
            this.cancelarButton.Size = new System.Drawing.Size(121, 39);
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
            this.eliminarButton.FlatAppearance.BorderSize = 0;
            this.eliminarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(60)))));
            this.eliminarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarButton.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold);
            this.eliminarButton.ForeColor = System.Drawing.Color.Black;
            this.eliminarButton.Location = new System.Drawing.Point(386, 327);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Padding = new System.Windows.Forms.Padding(3);
            this.eliminarButton.Size = new System.Drawing.Size(121, 39);
            this.eliminarButton.TabIndex = 32;
            this.eliminarButton.Text = "ELIMINAR";
            this.eliminarButton.UseVisualStyleBackColor = false;
            // 
            // eliminarMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(569, 381);
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