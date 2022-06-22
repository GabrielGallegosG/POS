
namespace POS
{
    partial class pagoOrdenForm
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
            this.encabezadoLabel = new System.Windows.Forms.Label();
            this.noOrdenLabel = new System.Windows.Forms.Label();
            this.saldoFavorClienteLabel = new System.Windows.Forms.Label();
            this.metodoPagoLabel = new System.Windows.Forms.Label();
            this.montoPagarLabel = new System.Windows.Forms.Label();
            this.efectivoCheckBox = new System.Windows.Forms.CheckBox();
            this.tarjetaCheckBox = new System.Windows.Forms.CheckBox();
            this.efectivoTextBox = new System.Windows.Forms.TextBox();
            this.tarjetaTextBox = new System.Windows.Forms.TextBox();
            this.divisionLabel = new System.Windows.Forms.Label();
            this.ordenLabel = new System.Windows.Forms.Label();
            this.montoLabel = new System.Windows.Forms.Label();
            this.saldoFavorLabel = new System.Windows.Forms.Label();
            this.ahoraButton = new buttonSystem();
            this.masTardeButton = new buttonSystem();
            this.encabezadoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // encabezadoPanel
            // 
            this.encabezadoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.encabezadoPanel.AutoSize = true;
            this.encabezadoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.encabezadoPanel.Controls.Add(this.encabezadoLabel);
            this.encabezadoPanel.Location = new System.Drawing.Point(-1, -2);
            this.encabezadoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.encabezadoPanel.MaximumSize = new System.Drawing.Size(818, 47);
            this.encabezadoPanel.MinimumSize = new System.Drawing.Size(818, 47);
            this.encabezadoPanel.Name = "encabezadoPanel";
            this.encabezadoPanel.Size = new System.Drawing.Size(818, 47);
            this.encabezadoPanel.TabIndex = 31;
            // 
            // encabezadoLabel
            // 
            this.encabezadoLabel.AutoSize = true;
            this.encabezadoLabel.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encabezadoLabel.ForeColor = System.Drawing.Color.White;
            this.encabezadoLabel.Location = new System.Drawing.Point(181, 10);
            this.encabezadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.encabezadoLabel.Name = "encabezadoLabel";
            this.encabezadoLabel.Size = new System.Drawing.Size(231, 32);
            this.encabezadoLabel.TabIndex = 9;
            this.encabezadoLabel.Text = "PAGO DE ÓRDEN";
            // 
            // noOrdenLabel
            // 
            this.noOrdenLabel.AutoSize = true;
            this.noOrdenLabel.Font = new System.Drawing.Font("Gadugi", 12F);
            this.noOrdenLabel.Location = new System.Drawing.Point(49, 85);
            this.noOrdenLabel.Name = "noOrdenLabel";
            this.noOrdenLabel.Size = new System.Drawing.Size(115, 24);
            this.noOrdenLabel.TabIndex = 32;
            this.noOrdenLabel.Text = "NO. ORDEN";
            // 
            // saldoFavorClienteLabel
            // 
            this.saldoFavorClienteLabel.AutoSize = true;
            this.saldoFavorClienteLabel.Font = new System.Drawing.Font("Gadugi", 12F);
            this.saldoFavorClienteLabel.Location = new System.Drawing.Point(50, 373);
            this.saldoFavorClienteLabel.Name = "saldoFavorClienteLabel";
            this.saldoFavorClienteLabel.Size = new System.Drawing.Size(395, 24);
            this.saldoFavorClienteLabel.TabIndex = 33;
            this.saldoFavorClienteLabel.Text = "SALDO A FAVOR DEL CLIENTE . . . . . . . . . . . . $";
            // 
            // metodoPagoLabel
            // 
            this.metodoPagoLabel.AutoSize = true;
            this.metodoPagoLabel.Font = new System.Drawing.Font("Gadugi", 12F);
            this.metodoPagoLabel.Location = new System.Drawing.Point(49, 188);
            this.metodoPagoLabel.Name = "metodoPagoLabel";
            this.metodoPagoLabel.Size = new System.Drawing.Size(179, 24);
            this.metodoPagoLabel.TabIndex = 34;
            this.metodoPagoLabel.Text = "MÉTODO DE PAGO";
            // 
            // montoPagarLabel
            // 
            this.montoPagarLabel.AutoSize = true;
            this.montoPagarLabel.Font = new System.Drawing.Font("Gadugi", 12F);
            this.montoPagarLabel.Location = new System.Drawing.Point(364, 85);
            this.montoPagarLabel.Name = "montoPagarLabel";
            this.montoPagarLabel.Size = new System.Drawing.Size(169, 24);
            this.montoPagarLabel.TabIndex = 35;
            this.montoPagarLabel.Text = "MONTO A PAGAR";
            // 
            // efectivoCheckBox
            // 
            this.efectivoCheckBox.AutoSize = true;
            this.efectivoCheckBox.Font = new System.Drawing.Font("Gadugi", 12F);
            this.efectivoCheckBox.Location = new System.Drawing.Point(53, 233);
            this.efectivoCheckBox.Name = "efectivoCheckBox";
            this.efectivoCheckBox.Size = new System.Drawing.Size(408, 28);
            this.efectivoCheckBox.TabIndex = 36;
            this.efectivoCheckBox.Text = "EFECTIVO  . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   $";
            this.efectivoCheckBox.UseVisualStyleBackColor = true;
            this.efectivoCheckBox.CheckedChanged += new System.EventHandler(this.efectivoCheckBox_CheckedChanged);
            // 
            // tarjetaCheckBox
            // 
            this.tarjetaCheckBox.AutoSize = true;
            this.tarjetaCheckBox.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tarjetaCheckBox.Location = new System.Drawing.Point(53, 281);
            this.tarjetaCheckBox.Name = "tarjetaCheckBox";
            this.tarjetaCheckBox.Size = new System.Drawing.Size(408, 28);
            this.tarjetaCheckBox.TabIndex = 37;
            this.tarjetaCheckBox.Text = "TARJETA   . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .  $";
            this.tarjetaCheckBox.UseVisualStyleBackColor = true;
            this.tarjetaCheckBox.CheckedChanged += new System.EventHandler(this.tarjetaCheckBox_CheckedChanged);
            // 
            // efectivoTextBox
            // 
            this.efectivoTextBox.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Bold);
            this.efectivoTextBox.Location = new System.Drawing.Point(368, 231);
            this.efectivoTextBox.Name = "efectivoTextBox";
            this.efectivoTextBox.Size = new System.Drawing.Size(138, 41);
            this.efectivoTextBox.TabIndex = 38;
            this.efectivoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tarjetaTextBox
            // 
            this.tarjetaTextBox.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Bold);
            this.tarjetaTextBox.Location = new System.Drawing.Point(368, 279);
            this.tarjetaTextBox.Name = "tarjetaTextBox";
            this.tarjetaTextBox.Size = new System.Drawing.Size(138, 41);
            this.tarjetaTextBox.TabIndex = 39;
            this.tarjetaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // divisionLabel
            // 
            this.divisionLabel.AutoSize = true;
            this.divisionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.divisionLabel.Location = new System.Drawing.Point(359, 334);
            this.divisionLabel.Name = "divisionLabel";
            this.divisionLabel.Size = new System.Drawing.Size(161, 18);
            this.divisionLabel.TabIndex = 42;
            this.divisionLabel.Text = "_________________";
            // 
            // ordenLabel
            // 
            this.ordenLabel.AutoSize = true;
            this.ordenLabel.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordenLabel.Location = new System.Drawing.Point(60, 119);
            this.ordenLabel.Name = "ordenLabel";
            this.ordenLabel.Size = new System.Drawing.Size(82, 28);
            this.ordenLabel.TabIndex = 43;
            this.ordenLabel.Text = "#0000";
            // 
            // montoLabel
            // 
            this.montoLabel.AutoSize = true;
            this.montoLabel.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoLabel.Location = new System.Drawing.Point(396, 119);
            this.montoLabel.Name = "montoLabel";
            this.montoLabel.Size = new System.Drawing.Size(111, 34);
            this.montoLabel.TabIndex = 44;
            this.montoLabel.Text = "$ 00.00";
            // 
            // saldoFavorLabel
            // 
            this.saldoFavorLabel.AutoSize = true;
            this.saldoFavorLabel.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldoFavorLabel.Location = new System.Drawing.Point(399, 373);
            this.saldoFavorLabel.Name = "saldoFavorLabel";
            this.saldoFavorLabel.Size = new System.Drawing.Size(95, 34);
            this.saldoFavorLabel.TabIndex = 45;
            this.saldoFavorLabel.Text = " 00.00";
            this.saldoFavorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ahoraButton
            // 
            this.ahoraButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.ahoraButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.ahoraButton.BorderRadius = 20;
            this.ahoraButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ahoraButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.ahoraButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.ahoraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ahoraButton.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold);
            this.ahoraButton.ForeColor = System.Drawing.Color.Black;
            this.ahoraButton.Location = new System.Drawing.Point(368, 516);
            this.ahoraButton.Name = "ahoraButton";
            this.ahoraButton.Padding = new System.Windows.Forms.Padding(3);
            this.ahoraButton.Size = new System.Drawing.Size(177, 48);
            this.ahoraButton.TabIndex = 41;
            this.ahoraButton.Text = "PAGAR AHORA";
            this.ahoraButton.UseVisualStyleBackColor = false;
            this.ahoraButton.Click += new System.EventHandler(this.ahoraButton_Click);
            // 
            // masTardeButton
            // 
            this.masTardeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.masTardeButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.masTardeButton.BorderRadius = 20;
            this.masTardeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.masTardeButton.FlatAppearance.BorderSize = 0;
            this.masTardeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(60)))));
            this.masTardeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.masTardeButton.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold);
            this.masTardeButton.ForeColor = System.Drawing.Color.Black;
            this.masTardeButton.Location = new System.Drawing.Point(28, 516);
            this.masTardeButton.Name = "masTardeButton";
            this.masTardeButton.Padding = new System.Windows.Forms.Padding(3);
            this.masTardeButton.Size = new System.Drawing.Size(186, 48);
            this.masTardeButton.TabIndex = 40;
            this.masTardeButton.Text = "PAGAR MÁS TARDE";
            this.masTardeButton.UseVisualStyleBackColor = false;
            this.masTardeButton.Click += new System.EventHandler(this.masTardeButton_Click);
            // 
            // pagoOrdenForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(587, 605);
            this.ControlBox = false;
            this.Controls.Add(this.saldoFavorLabel);
            this.Controls.Add(this.montoLabel);
            this.Controls.Add(this.ordenLabel);
            this.Controls.Add(this.divisionLabel);
            this.Controls.Add(this.ahoraButton);
            this.Controls.Add(this.masTardeButton);
            this.Controls.Add(this.tarjetaTextBox);
            this.Controls.Add(this.efectivoTextBox);
            this.Controls.Add(this.tarjetaCheckBox);
            this.Controls.Add(this.efectivoCheckBox);
            this.Controls.Add(this.montoPagarLabel);
            this.Controls.Add(this.metodoPagoLabel);
            this.Controls.Add(this.saldoFavorClienteLabel);
            this.Controls.Add(this.noOrdenLabel);
            this.Controls.Add(this.encabezadoPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pagoOrdenForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago de órden";
            this.TopMost = true;
            this.encabezadoPanel.ResumeLayout(false);
            this.encabezadoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel encabezadoPanel;
        private System.Windows.Forms.Label encabezadoLabel;
        private System.Windows.Forms.Label noOrdenLabel;
        private System.Windows.Forms.Label saldoFavorClienteLabel;
        private System.Windows.Forms.Label metodoPagoLabel;
        private System.Windows.Forms.Label montoPagarLabel;
        private System.Windows.Forms.CheckBox efectivoCheckBox;
        private System.Windows.Forms.CheckBox tarjetaCheckBox;
        private System.Windows.Forms.TextBox efectivoTextBox;
        private System.Windows.Forms.TextBox tarjetaTextBox;
        private buttonSystem masTardeButton;
        private buttonSystem ahoraButton;
        private System.Windows.Forms.Label divisionLabel;
        private System.Windows.Forms.Label ordenLabel;
        private System.Windows.Forms.Label montoLabel;
        private System.Windows.Forms.Label saldoFavorLabel;
    }
}