
namespace POS
{
    partial class eliminarOrdenForm
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
            this.notaRichTextBox = new System.Windows.Forms.RichTextBox();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.encabezadoPanel = new System.Windows.Forms.Panel();
            this.encabezadoLabel = new System.Windows.Forms.Label();
            this.noMesaOrdenLabel = new System.Windows.Forms.Label();
            this.fechaOrdenLabel = new System.Windows.Forms.Label();
            this.horaOrdenLabel = new System.Windows.Forms.Label();
            this.horaLabel = new System.Windows.Forms.Label();
            this.fechaLabel = new System.Windows.Forms.Label();
            this.noMesaLabel = new System.Windows.Forms.Label();
            this.tipoServicioLabel = new System.Windows.Forms.Label();
            this.servicioOrdenLabel = new System.Windows.Forms.Label();
            this.noOrdenLabel = new System.Windows.Forms.Label();
            this.noOrdenSeleccionadoLabel = new System.Windows.Forms.Label();
            this.encabezadoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // notaRichTextBox
            // 
            this.notaRichTextBox.BackColor = System.Drawing.Color.White;
            this.notaRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notaRichTextBox.Font = new System.Drawing.Font("Gadugi", 12F);
            this.notaRichTextBox.Location = new System.Drawing.Point(29, 249);
            this.notaRichTextBox.Name = "notaRichTextBox";
            this.notaRichTextBox.ReadOnly = true;
            this.notaRichTextBox.Size = new System.Drawing.Size(491, 61);
            this.notaRichTextBox.TabIndex = 39;
            this.notaRichTextBox.Text = "*Nota: Se eliminará de manera permanente el elemento seleccionado.\nSeleccione “El" +
    "iminar” para continuar con la acción…";
            // 
            // eliminarButton
            // 
            this.eliminarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.eliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarButton.Location = new System.Drawing.Point(406, 326);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(100, 23);
            this.eliminarButton.TabIndex = 38;
            this.eliminarButton.Text = "ELIMINAR";
            this.eliminarButton.UseVisualStyleBackColor = false;
            // 
            // cancelarButton
            // 
            this.cancelarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.cancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarButton.Location = new System.Drawing.Point(29, 326);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(87, 23);
            this.cancelarButton.TabIndex = 37;
            this.cancelarButton.Text = "CANCELAR";
            this.cancelarButton.UseVisualStyleBackColor = false;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // encabezadoPanel
            // 
            this.encabezadoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.encabezadoPanel.Controls.Add(this.encabezadoLabel);
            this.encabezadoPanel.Location = new System.Drawing.Point(-1, -1);
            this.encabezadoPanel.Name = "encabezadoPanel";
            this.encabezadoPanel.Size = new System.Drawing.Size(574, 40);
            this.encabezadoPanel.TabIndex = 31;
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
            // noMesaOrdenLabel
            // 
            this.noMesaOrdenLabel.Font = new System.Drawing.Font("Gadugi", 12F);
            this.noMesaOrdenLabel.Location = new System.Drawing.Point(150, 170);
            this.noMesaOrdenLabel.Name = "noMesaOrdenLabel";
            this.noMesaOrdenLabel.Size = new System.Drawing.Size(77, 19);
            this.noMesaOrdenLabel.TabIndex = 52;
            // 
            // fechaOrdenLabel
            // 
            this.fechaOrdenLabel.Font = new System.Drawing.Font("Gadugi", 12F);
            this.fechaOrdenLabel.Location = new System.Drawing.Point(451, 70);
            this.fechaOrdenLabel.Name = "fechaOrdenLabel";
            this.fechaOrdenLabel.Size = new System.Drawing.Size(100, 23);
            this.fechaOrdenLabel.TabIndex = 51;
            // 
            // horaOrdenLabel
            // 
            this.horaOrdenLabel.Font = new System.Drawing.Font("Gadugi", 12F);
            this.horaOrdenLabel.Location = new System.Drawing.Point(451, 126);
            this.horaOrdenLabel.Name = "horaOrdenLabel";
            this.horaOrdenLabel.Size = new System.Drawing.Size(100, 23);
            this.horaOrdenLabel.TabIndex = 50;
            // 
            // horaLabel
            // 
            this.horaLabel.AutoSize = true;
            this.horaLabel.Font = new System.Drawing.Font("Gadugi", 12F);
            this.horaLabel.Location = new System.Drawing.Point(390, 129);
            this.horaLabel.Name = "horaLabel";
            this.horaLabel.Size = new System.Drawing.Size(55, 19);
            this.horaLabel.TabIndex = 49;
            this.horaLabel.Text = "HORA:";
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Font = new System.Drawing.Font("Gadugi", 12F);
            this.fechaLabel.Location = new System.Drawing.Point(386, 74);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(59, 19);
            this.fechaLabel.TabIndex = 48;
            this.fechaLabel.Text = "FECHA:";
            // 
            // noMesaLabel
            // 
            this.noMesaLabel.AutoSize = true;
            this.noMesaLabel.Font = new System.Drawing.Font("Gadugi", 12F);
            this.noMesaLabel.Location = new System.Drawing.Point(25, 170);
            this.noMesaLabel.Name = "noMesaLabel";
            this.noMesaLabel.Size = new System.Drawing.Size(107, 19);
            this.noMesaLabel.TabIndex = 47;
            this.noMesaLabel.Text = "NO. DE MESA:";
            // 
            // tipoServicioLabel
            // 
            this.tipoServicioLabel.AutoSize = true;
            this.tipoServicioLabel.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tipoServicioLabel.Location = new System.Drawing.Point(25, 127);
            this.tipoServicioLabel.Name = "tipoServicioLabel";
            this.tipoServicioLabel.Size = new System.Drawing.Size(139, 19);
            this.tipoServicioLabel.TabIndex = 46;
            this.tipoServicioLabel.Text = "TIPO DE SERVICIO:";
            // 
            // servicioOrdenLabel
            // 
            this.servicioOrdenLabel.Font = new System.Drawing.Font("Gadugi", 12F);
            this.servicioOrdenLabel.Location = new System.Drawing.Point(170, 126);
            this.servicioOrdenLabel.Name = "servicioOrdenLabel";
            this.servicioOrdenLabel.Size = new System.Drawing.Size(77, 19);
            this.servicioOrdenLabel.TabIndex = 45;
            // 
            // noOrdenLabel
            // 
            this.noOrdenLabel.AutoSize = true;
            this.noOrdenLabel.Font = new System.Drawing.Font("Gadugi", 12F);
            this.noOrdenLabel.Location = new System.Drawing.Point(25, 73);
            this.noOrdenLabel.Name = "noOrdenLabel";
            this.noOrdenLabel.Size = new System.Drawing.Size(96, 19);
            this.noOrdenLabel.TabIndex = 41;
            this.noOrdenLabel.Text = "NO. ORDEN:";
            // 
            // noOrdenSeleccionadoLabel
            // 
            this.noOrdenSeleccionadoLabel.BackColor = System.Drawing.Color.Transparent;
            this.noOrdenSeleccionadoLabel.Font = new System.Drawing.Font("Gadugi", 12F);
            this.noOrdenSeleccionadoLabel.Location = new System.Drawing.Point(127, 74);
            this.noOrdenSeleccionadoLabel.Name = "noOrdenSeleccionadoLabel";
            this.noOrdenSeleccionadoLabel.Size = new System.Drawing.Size(100, 23);
            this.noOrdenSeleccionadoLabel.TabIndex = 40;
            // 
            // eliminarOrdenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(573, 374);
            this.Controls.Add(this.noMesaOrdenLabel);
            this.Controls.Add(this.fechaOrdenLabel);
            this.Controls.Add(this.horaOrdenLabel);
            this.Controls.Add(this.horaLabel);
            this.Controls.Add(this.fechaLabel);
            this.Controls.Add(this.noMesaLabel);
            this.Controls.Add(this.tipoServicioLabel);
            this.Controls.Add(this.servicioOrdenLabel);
            this.Controls.Add(this.noOrdenLabel);
            this.Controls.Add(this.noOrdenSeleccionadoLabel);
            this.Controls.Add(this.notaRichTextBox);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.encabezadoPanel);
            this.Name = "eliminarOrdenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar orden";
            this.encabezadoPanel.ResumeLayout(false);
            this.encabezadoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox notaRichTextBox;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Panel encabezadoPanel;
        private System.Windows.Forms.Label encabezadoLabel;
        private System.Windows.Forms.Label noMesaOrdenLabel;
        private System.Windows.Forms.Label fechaOrdenLabel;
        private System.Windows.Forms.Label horaOrdenLabel;
        private System.Windows.Forms.Label horaLabel;
        private System.Windows.Forms.Label fechaLabel;
        private System.Windows.Forms.Label noMesaLabel;
        private System.Windows.Forms.Label tipoServicioLabel;
        private System.Windows.Forms.Label servicioOrdenLabel;
        private System.Windows.Forms.Label noOrdenLabel;
        private System.Windows.Forms.Label noOrdenSeleccionadoLabel;
    }
}