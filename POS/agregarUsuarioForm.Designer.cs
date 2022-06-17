
namespace POS
{
    partial class agregarUsuarioForm
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
            this.tipoComboBox = new System.Windows.Forms.ComboBox();
            this.apellidoMLabel = new System.Windows.Forms.Label();
            this.apellidoPLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.contraseñaLabel = new System.Windows.Forms.Label();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.contraseñaTextBox = new System.Windows.Forms.TextBox();
            this.apellidoMTextBox = new System.Windows.Forms.TextBox();
            this.apellidoPTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.tipoUsuarioLabel = new System.Windows.Forms.Label();
            this.cargoLabel = new System.Windows.Forms.Label();
            this.cargoTextBox = new System.Windows.Forms.TextBox();
            this.agregarButton = new buttonSystem();
            this.cancelarButton = new buttonSystem();
            this.encabezadoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // encabezadoPanel
            // 
            this.encabezadoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.encabezadoPanel.Controls.Add(this.encabezadoLabel);
            this.encabezadoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.encabezadoPanel.Location = new System.Drawing.Point(0, 0);
            this.encabezadoPanel.Name = "encabezadoPanel";
            this.encabezadoPanel.Size = new System.Drawing.Size(800, 38);
            this.encabezadoPanel.TabIndex = 23;
            // 
            // encabezadoLabel
            // 
            this.encabezadoLabel.AutoSize = true;
            this.encabezadoLabel.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encabezadoLabel.ForeColor = System.Drawing.Color.White;
            this.encabezadoLabel.Location = new System.Drawing.Point(12, 9);
            this.encabezadoLabel.Name = "encabezadoLabel";
            this.encabezadoLabel.Size = new System.Drawing.Size(211, 25);
            this.encabezadoLabel.TabIndex = 9;
            this.encabezadoLabel.Text = "AGREGAR USUARIO";
            // 
            // tipoComboBox
            // 
            this.tipoComboBox.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tipoComboBox.FormattingEnabled = true;
            this.tipoComboBox.Items.AddRange(new object[] {
            "EMPLEADO",
            "ADMINISTRADOR"});
            this.tipoComboBox.Location = new System.Drawing.Point(588, 272);
            this.tipoComboBox.Name = "tipoComboBox";
            this.tipoComboBox.Size = new System.Drawing.Size(121, 27);
            this.tipoComboBox.TabIndex = 21;
            // 
            // apellidoMLabel
            // 
            this.apellidoMLabel.AutoSize = true;
            this.apellidoMLabel.Font = new System.Drawing.Font("Gadugi", 12F);
            this.apellidoMLabel.Location = new System.Drawing.Point(25, 164);
            this.apellidoMLabel.Name = "apellidoMLabel";
            this.apellidoMLabel.Size = new System.Drawing.Size(160, 19);
            this.apellidoMLabel.TabIndex = 70;
            this.apellidoMLabel.Text = "APELLIDO MATERNO:";
            // 
            // apellidoPLabel
            // 
            this.apellidoPLabel.AutoSize = true;
            this.apellidoPLabel.Font = new System.Drawing.Font("Gadugi", 12F);
            this.apellidoPLabel.Location = new System.Drawing.Point(25, 121);
            this.apellidoPLabel.Name = "apellidoPLabel";
            this.apellidoPLabel.Size = new System.Drawing.Size(155, 19);
            this.apellidoPLabel.TabIndex = 69;
            this.apellidoPLabel.Text = "APELLIDO PATERNO:";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Font = new System.Drawing.Font("Gadugi", 12F);
            this.nombreLabel.Location = new System.Drawing.Point(25, 60);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(77, 19);
            this.nombreLabel.TabIndex = 68;
            this.nombreLabel.Text = "NOMBRE:";
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.Font = new System.Drawing.Font("Gadugi", 12F);
            this.usuarioLabel.Location = new System.Drawing.Point(25, 274);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(79, 19);
            this.usuarioLabel.TabIndex = 73;
            this.usuarioLabel.Text = "USUARIO:";
            // 
            // contraseñaLabel
            // 
            this.contraseñaLabel.AutoSize = true;
            this.contraseñaLabel.Font = new System.Drawing.Font("Gadugi", 12F);
            this.contraseñaLabel.Location = new System.Drawing.Point(25, 319);
            this.contraseñaLabel.Name = "contraseñaLabel";
            this.contraseñaLabel.Size = new System.Drawing.Size(113, 19);
            this.contraseñaLabel.TabIndex = 74;
            this.contraseñaLabel.Text = "CONTRASEÑA:";
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.Font = new System.Drawing.Font("Gadugi", 12F);
            this.usuarioTextBox.Location = new System.Drawing.Point(113, 274);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(100, 29);
            this.usuarioTextBox.TabIndex = 75;
            // 
            // contraseñaTextBox
            // 
            this.contraseñaTextBox.Font = new System.Drawing.Font("Gadugi", 12F);
            this.contraseñaTextBox.Location = new System.Drawing.Point(155, 318);
            this.contraseñaTextBox.Name = "contraseñaTextBox";
            this.contraseñaTextBox.Size = new System.Drawing.Size(100, 29);
            this.contraseñaTextBox.TabIndex = 76;
            // 
            // apellidoMTextBox
            // 
            this.apellidoMTextBox.Font = new System.Drawing.Font("Gadugi", 12F);
            this.apellidoMTextBox.Location = new System.Drawing.Point(191, 163);
            this.apellidoMTextBox.Name = "apellidoMTextBox";
            this.apellidoMTextBox.Size = new System.Drawing.Size(100, 29);
            this.apellidoMTextBox.TabIndex = 77;
            // 
            // apellidoPTextBox
            // 
            this.apellidoPTextBox.Font = new System.Drawing.Font("Gadugi", 12F);
            this.apellidoPTextBox.Location = new System.Drawing.Point(191, 120);
            this.apellidoPTextBox.Name = "apellidoPTextBox";
            this.apellidoPTextBox.Size = new System.Drawing.Size(100, 29);
            this.apellidoPTextBox.TabIndex = 78;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Font = new System.Drawing.Font("Gadugi", 12F);
            this.nombreTextBox.Location = new System.Drawing.Point(113, 59);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 29);
            this.nombreTextBox.TabIndex = 79;
            // 
            // tipoUsuarioLabel
            // 
            this.tipoUsuarioLabel.AutoSize = true;
            this.tipoUsuarioLabel.Font = new System.Drawing.Font("Gadugi", 12F);
            this.tipoUsuarioLabel.Location = new System.Drawing.Point(426, 275);
            this.tipoUsuarioLabel.Name = "tipoUsuarioLabel";
            this.tipoUsuarioLabel.Size = new System.Drawing.Size(139, 19);
            this.tipoUsuarioLabel.TabIndex = 80;
            this.tipoUsuarioLabel.Text = "TIPO DE USUARIO:";
            // 
            // cargoLabel
            // 
            this.cargoLabel.AutoSize = true;
            this.cargoLabel.Font = new System.Drawing.Font("Gadugi", 12F);
            this.cargoLabel.Location = new System.Drawing.Point(426, 319);
            this.cargoLabel.Name = "cargoLabel";
            this.cargoLabel.Size = new System.Drawing.Size(65, 19);
            this.cargoLabel.TabIndex = 81;
            this.cargoLabel.Text = "CARGO:";
            // 
            // cargoTextBox
            // 
            this.cargoTextBox.Font = new System.Drawing.Font("Gadugi", 12F);
            this.cargoTextBox.Location = new System.Drawing.Point(506, 318);
            this.cargoTextBox.Name = "cargoTextBox";
            this.cargoTextBox.Size = new System.Drawing.Size(100, 29);
            this.cargoTextBox.TabIndex = 82;
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
            this.agregarButton.Location = new System.Drawing.Point(645, 425);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Padding = new System.Windows.Forms.Padding(3);
            this.agregarButton.Size = new System.Drawing.Size(121, 39);
            this.agregarButton.TabIndex = 25;
            this.agregarButton.Text = "AGREGAR";
            this.agregarButton.UseVisualStyleBackColor = false;
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
            this.cancelarButton.Location = new System.Drawing.Point(10, 425);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Padding = new System.Windows.Forms.Padding(3);
            this.cancelarButton.Size = new System.Drawing.Size(121, 39);
            this.cancelarButton.TabIndex = 24;
            this.cancelarButton.Text = "CANCELAR";
            this.cancelarButton.UseVisualStyleBackColor = false;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // agregarUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.cargoTextBox);
            this.Controls.Add(this.cargoLabel);
            this.Controls.Add(this.tipoUsuarioLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.apellidoPTextBox);
            this.Controls.Add(this.apellidoMTextBox);
            this.Controls.Add(this.contraseñaTextBox);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(this.contraseñaLabel);
            this.Controls.Add(this.usuarioLabel);
            this.Controls.Add(this.apellidoMLabel);
            this.Controls.Add(this.apellidoPLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.encabezadoPanel);
            this.Controls.Add(this.tipoComboBox);
            this.Name = "agregarUsuarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar usuario";
            this.Load += new System.EventHandler(this.agregarUsuarioForm_Load);
            this.encabezadoPanel.ResumeLayout(false);
            this.encabezadoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private buttonSystem agregarButton;
        private buttonSystem cancelarButton;
        private System.Windows.Forms.Panel encabezadoPanel;
        private System.Windows.Forms.Label encabezadoLabel;
        private System.Windows.Forms.ComboBox tipoComboBox;
        private System.Windows.Forms.Label apellidoMLabel;
        private System.Windows.Forms.Label apellidoPLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.Label contraseñaLabel;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox contraseñaTextBox;
        private System.Windows.Forms.TextBox apellidoMTextBox;
        private System.Windows.Forms.TextBox apellidoPTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label tipoUsuarioLabel;
        private System.Windows.Forms.Label cargoLabel;
        private System.Windows.Forms.TextBox cargoTextBox;
    }
}