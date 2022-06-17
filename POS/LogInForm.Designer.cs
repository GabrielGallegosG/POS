
namespace POS
{
    partial class loginForm
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
            this.contenedorPanel = new System.Windows.Forms.Panel();
            this.contraseñaTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.contraseñaLabel = new System.Windows.Forms.Label();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.inicioSesionLabel = new System.Windows.Forms.Label();
            this.administradorButton = new buttonLogin();
            this.empleadoButton = new buttonLogin();
            this.iniciarSesionButton = new buttonLogin();
            this.encabezadoPanel.SuspendLayout();
            this.contenedorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // encabezadoPanel
            // 
            this.encabezadoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.encabezadoPanel.AutoSize = true;
            this.encabezadoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.encabezadoPanel.Controls.Add(this.encabezadoLabel);
            this.encabezadoPanel.Location = new System.Drawing.Point(0, 0);
            this.encabezadoPanel.Name = "encabezadoPanel";
            this.encabezadoPanel.Size = new System.Drawing.Size(1038, 49);
            this.encabezadoPanel.TabIndex = 0;
            // 
            // encabezadoLabel
            // 
            this.encabezadoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.encabezadoLabel.Font = new System.Drawing.Font("Gadugi", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encabezadoLabel.ForeColor = System.Drawing.Color.White;
            this.encabezadoLabel.Location = new System.Drawing.Point(0, 0);
            this.encabezadoLabel.Name = "encabezadoLabel";
            this.encabezadoLabel.Size = new System.Drawing.Size(1038, 49);
            this.encabezadoLabel.TabIndex = 0;
            this.encabezadoLabel.Text = "BIENVENIDO";
            this.encabezadoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contenedorPanel
            // 
            this.contenedorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            this.contenedorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contenedorPanel.Controls.Add(this.iniciarSesionButton);
            this.contenedorPanel.Controls.Add(this.contraseñaTextBox);
            this.contenedorPanel.Controls.Add(this.usuarioTextBox);
            this.contenedorPanel.Controls.Add(this.contraseñaLabel);
            this.contenedorPanel.Controls.Add(this.usuarioLabel);
            this.contenedorPanel.Location = new System.Drawing.Point(275, 220);
            this.contenedorPanel.Name = "contenedorPanel";
            this.contenedorPanel.Size = new System.Drawing.Size(540, 320);
            this.contenedorPanel.TabIndex = 4;
            // 
            // contraseñaTextBox
            // 
            this.contraseñaTextBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseñaTextBox.Location = new System.Drawing.Point(38, 122);
            this.contraseñaTextBox.Name = "contraseñaTextBox";
            this.contraseñaTextBox.PasswordChar = '*';
            this.contraseñaTextBox.Size = new System.Drawing.Size(360, 29);
            this.contraseñaTextBox.TabIndex = 9;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTextBox.Location = new System.Drawing.Point(38, 51);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(360, 29);
            this.usuarioTextBox.TabIndex = 8;
            // 
            // contraseñaLabel
            // 
            this.contraseñaLabel.AutoSize = true;
            this.contraseñaLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseñaLabel.Location = new System.Drawing.Point(34, 100);
            this.contraseñaLabel.Name = "contraseñaLabel";
            this.contraseñaLabel.Size = new System.Drawing.Size(110, 19);
            this.contraseñaLabel.TabIndex = 7;
            this.contraseñaLabel.Text = "CONTRASEÑA";
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioLabel.Location = new System.Drawing.Point(43, 19);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(168, 19);
            this.usuarioLabel.TabIndex = 6;
            this.usuarioLabel.Text = "NOMBRE DE USUARIO";
            // 
            // inicioSesionLabel
            // 
            this.inicioSesionLabel.AutoSize = true;
            this.inicioSesionLabel.Font = new System.Drawing.Font("Gadugi", 16F, System.Drawing.FontStyle.Bold);
            this.inicioSesionLabel.Location = new System.Drawing.Point(393, 74);
            this.inicioSesionLabel.Name = "inicioSesionLabel";
            this.inicioSesionLabel.Size = new System.Drawing.Size(257, 26);
            this.inicioSesionLabel.TabIndex = 1;
            this.inicioSesionLabel.Text = "¿QUIEN INICIA SESIÓN?";
            this.inicioSesionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // administradorButton
            // 
            this.administradorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.administradorButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.administradorButton.BorderRadius = 20;
            this.administradorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.administradorButton.FlatAppearance.BorderSize = 0;
            this.administradorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(200)))));
            this.administradorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.administradorButton.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Bold);
            this.administradorButton.ForeColor = System.Drawing.Color.White;
            this.administradorButton.Location = new System.Drawing.Point(581, 129);
            this.administradorButton.Name = "administradorButton";
            this.administradorButton.Padding = new System.Windows.Forms.Padding(3);
            this.administradorButton.Size = new System.Drawing.Size(282, 48);
            this.administradorButton.TabIndex = 6;
            this.administradorButton.Text = "SOY ADMINISTRADOR";
            this.administradorButton.UseVisualStyleBackColor = false;
            this.administradorButton.Click += new System.EventHandler(this.administradorButton_Click);
            // 
            // empleadoButton
            // 
            this.empleadoButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.empleadoButton.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.empleadoButton.BorderRadius = 20;
            this.empleadoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empleadoButton.FlatAppearance.BorderSize = 0;
            this.empleadoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(200)))));
            this.empleadoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empleadoButton.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Bold);
            this.empleadoButton.ForeColor = System.Drawing.Color.White;
            this.empleadoButton.Location = new System.Drawing.Point(244, 129);
            this.empleadoButton.Name = "empleadoButton";
            this.empleadoButton.Padding = new System.Windows.Forms.Padding(3);
            this.empleadoButton.Size = new System.Drawing.Size(199, 48);
            this.empleadoButton.TabIndex = 5;
            this.empleadoButton.Text = "SOY EMPLEADO";
            this.empleadoButton.UseVisualStyleBackColor = false;
            this.empleadoButton.Click += new System.EventHandler(this.empleadoButton_Click_1);
            // 
            // iniciarSesionButton
            // 
            this.iniciarSesionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.iniciarSesionButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.iniciarSesionButton.BorderRadius = 20;
            this.iniciarSesionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iniciarSesionButton.FlatAppearance.BorderSize = 0;
            this.iniciarSesionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(200)))));
            this.iniciarSesionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iniciarSesionButton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold);
            this.iniciarSesionButton.ForeColor = System.Drawing.Color.White;
            this.iniciarSesionButton.Location = new System.Drawing.Point(132, 191);
            this.iniciarSesionButton.Name = "iniciarSesionButton";
            this.iniciarSesionButton.Padding = new System.Windows.Forms.Padding(3);
            this.iniciarSesionButton.Size = new System.Drawing.Size(166, 42);
            this.iniciarSesionButton.TabIndex = 10;
            this.iniciarSesionButton.Text = "INICIAR  SESIÓN";
            this.iniciarSesionButton.UseVisualStyleBackColor = false;
            this.iniciarSesionButton.Click += new System.EventHandler(this.iniciarSesionButton_Click_1);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1036, 619);
            this.Controls.Add(this.administradorButton);
            this.Controls.Add(this.empleadoButton);
            this.Controls.Add(this.contenedorPanel);
            this.Controls.Add(this.inicioSesionLabel);
            this.Controls.Add(this.encabezadoPanel);
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.encabezadoPanel.ResumeLayout(false);
            this.contenedorPanel.ResumeLayout(false);
            this.contenedorPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel encabezadoPanel;
        private System.Windows.Forms.Label encabezadoLabel;
        private System.Windows.Forms.Panel contenedorPanel;
        private System.Windows.Forms.TextBox contraseñaTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.Label contraseñaLabel;
        private System.Windows.Forms.Label usuarioLabel;
        private buttonLogin empleadoButton;
        private buttonLogin administradorButton;
        private buttonLogin iniciarSesionButton;
        private System.Windows.Forms.Label inicioSesionLabel;
    }
}