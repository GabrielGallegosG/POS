
namespace POS
{
    partial class agregarSaldoFinalForm
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
            this.encabezadoPanel = new System.Windows.Forms.Panel();
            this.encabezadoSaldoFinalLabel = new System.Windows.Forms.Label();
            this.cantidadFinalTextBox = new System.Windows.Forms.TextBox();
            this.cantidadLabel = new System.Windows.Forms.Label();
            this.agregarButton = new buttonSystem();
            this.cancelarButton = new buttonSystem();
            this.encabezadoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // encabezadoPanel
            // 
            this.encabezadoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.encabezadoPanel.Controls.Add(this.encabezadoSaldoFinalLabel);
            this.encabezadoPanel.Location = new System.Drawing.Point(0, 12);
            this.encabezadoPanel.Name = "encabezadoPanel";
            this.encabezadoPanel.Size = new System.Drawing.Size(623, 38);
            this.encabezadoPanel.TabIndex = 19;
            // 
            // encabezadoSaldoFinalLabel
            // 
            this.encabezadoSaldoFinalLabel.AutoSize = true;
            this.encabezadoSaldoFinalLabel.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encabezadoSaldoFinalLabel.ForeColor = System.Drawing.Color.White;
            this.encabezadoSaldoFinalLabel.Location = new System.Drawing.Point(98, 6);
            this.encabezadoSaldoFinalLabel.Name = "encabezadoSaldoFinalLabel";
            this.encabezadoSaldoFinalLabel.Size = new System.Drawing.Size(406, 25);
            this.encabezadoSaldoFinalLabel.TabIndex = 9;
            this.encabezadoSaldoFinalLabel.Text = "INGRESAR CANTIDAD DE SALDO FINAL";
            this.encabezadoSaldoFinalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cantidadFinalTextBox
            // 
            this.cantidadFinalTextBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadFinalTextBox.Location = new System.Drawing.Point(153, 164);
            this.cantidadFinalTextBox.Name = "cantidadFinalTextBox";
            this.cantidadFinalTextBox.Size = new System.Drawing.Size(326, 29);
            this.cantidadFinalTextBox.TabIndex = 18;
            // 
            // cantidadLabel
            // 
            this.cantidadLabel.AutoSize = true;
            this.cantidadLabel.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadLabel.Location = new System.Drawing.Point(180, 104);
            this.cantidadLabel.Name = "cantidadLabel";
            this.cantidadLabel.Size = new System.Drawing.Size(268, 21);
            this.cantidadLabel.TabIndex = 17;
            this.cantidadLabel.Text = "CANTIDAD DE SALDO FINAL:";
            // 
            // agregarButton
            // 
            this.agregarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.agregarButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.agregarButton.BorderRadius = 20;
            this.agregarButton.FlatAppearance.BorderSize = 0;
            this.agregarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(60)))));
            this.agregarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarButton.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold);
            this.agregarButton.ForeColor = System.Drawing.Color.Black;
            this.agregarButton.Location = new System.Drawing.Point(372, 263);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Padding = new System.Windows.Forms.Padding(3);
            this.agregarButton.Size = new System.Drawing.Size(121, 39);
            this.agregarButton.TabIndex = 21;
            this.agregarButton.Text = "AGREGAR";
            this.agregarButton.UseVisualStyleBackColor = false;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
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
            this.cancelarButton.Location = new System.Drawing.Point(167, 263);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Padding = new System.Windows.Forms.Padding(3);
            this.cancelarButton.Size = new System.Drawing.Size(121, 39);
            this.cancelarButton.TabIndex = 20;
            this.cancelarButton.Text = "CANCELAR";
            this.cancelarButton.UseVisualStyleBackColor = false;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // agregarSaldoFinalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 450);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.encabezadoPanel);
            this.Controls.Add(this.cantidadFinalTextBox);
            this.Controls.Add(this.cantidadLabel);
            this.Name = "agregarSaldoFinalForm";
            this.Text = "Saldo Final";
            this.encabezadoPanel.ResumeLayout(false);
            this.encabezadoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private buttonSystem agregarButton;
        private buttonSystem cancelarButton;
        private System.Windows.Forms.Panel encabezadoPanel;
        private System.Windows.Forms.Label encabezadoSaldoFinalLabel;
        private System.Windows.Forms.TextBox cantidadFinalTextBox;
        private System.Windows.Forms.Label cantidadLabel;
    }
}