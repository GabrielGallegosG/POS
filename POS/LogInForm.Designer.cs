
namespace POS
{
    partial class LogInForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.encabezadoLabel = new System.Windows.Forms.Label();
            this.inicioSesionLabel = new System.Windows.Forms.Label();
            this.contenedorPanel = new System.Windows.Forms.Panel();
            this.contraseñaTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.contraseñaLabel = new System.Windows.Forms.Label();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.empleadoButton = new buttonLogin();
            this.administradorButton = new buttonLogin();
            this.iniciarSesionButton = new buttonLogin();
            this.panel1.SuspendLayout();
            this.contenedorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.encabezadoLabel);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 59);
            this.panel1.TabIndex = 0;
            // 
            // encabezadoLabel
            // 
            this.encabezadoLabel.AutoSize = true;
            this.encabezadoLabel.Font = new System.Drawing.Font("Gadugi", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encabezadoLabel.ForeColor = System.Drawing.Color.White;
            this.encabezadoLabel.Location = new System.Drawing.Point(264, 8);
            this.encabezadoLabel.Name = "encabezadoLabel";
            this.encabezadoLabel.Size = new System.Drawing.Size(232, 41);
            this.encabezadoLabel.TabIndex = 0;
            this.encabezadoLabel.Text = "BIENVENIDO";
            // 
            // inicioSesionLabel
            // 
            this.inicioSesionLabel.AutoSize = true;
            this.inicioSesionLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioSesionLabel.Location = new System.Drawing.Point(284, 86);
            this.inicioSesionLabel.Name = "inicioSesionLabel";
            this.inicioSesionLabel.Size = new System.Drawing.Size(188, 19);
            this.inicioSesionLabel.TabIndex = 1;
            this.inicioSesionLabel.Text = "¿QUIEN INICIA SESIÓN?";
            // 
            // contenedorPanel
            // 
            this.contenedorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            this.contenedorPanel.Controls.Add(this.iniciarSesionButton);
            this.contenedorPanel.Controls.Add(this.contraseñaTextBox);
            this.contenedorPanel.Controls.Add(this.usuarioTextBox);
            this.contenedorPanel.Controls.Add(this.contraseñaLabel);
            this.contenedorPanel.Controls.Add(this.usuarioLabel);
            this.contenedorPanel.Location = new System.Drawing.Point(156, 202);
            this.contenedorPanel.Name = "contenedorPanel";
            this.contenedorPanel.Size = new System.Drawing.Size(446, 236);
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
            // empleadoButton
            // 
            this.empleadoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.empleadoButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.empleadoButton.BorderRadius = 20;
            this.empleadoButton.FlatAppearance.BorderSize = 0;
            this.empleadoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(200)))));
            this.empleadoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empleadoButton.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Bold);
            this.empleadoButton.ForeColor = System.Drawing.Color.White;
            this.empleadoButton.Location = new System.Drawing.Point(70, 120);
            this.empleadoButton.Name = "empleadoButton";
            this.empleadoButton.Padding = new System.Windows.Forms.Padding(3);
            this.empleadoButton.Size = new System.Drawing.Size(199, 48);
            this.empleadoButton.TabIndex = 5;
            this.empleadoButton.Text = "SOY EMPLEADO";
            this.empleadoButton.UseVisualStyleBackColor = false;
            this.empleadoButton.Click += new System.EventHandler(this.empleadoButton_Click_1);
            // 
            // administradorButton
            // 
            this.administradorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.administradorButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.administradorButton.BorderRadius = 20;
            this.administradorButton.FlatAppearance.BorderSize = 0;
            this.administradorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(200)))));
            this.administradorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.administradorButton.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Bold);
            this.administradorButton.ForeColor = System.Drawing.Color.White;
            this.administradorButton.Location = new System.Drawing.Point(402, 120);
            this.administradorButton.Name = "administradorButton";
            this.administradorButton.Padding = new System.Windows.Forms.Padding(3);
            this.administradorButton.Size = new System.Drawing.Size(282, 48);
            this.administradorButton.TabIndex = 6;
            this.administradorButton.Text = "SOY ADMINISTRADOR";
            this.administradorButton.UseVisualStyleBackColor = false;
            this.administradorButton.Click += new System.EventHandler(this.administradorButton_Click);
            // 
            // iniciarSesionButton
            // 
            this.iniciarSesionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.iniciarSesionButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.iniciarSesionButton.BorderRadius = 20;
            this.iniciarSesionButton.FlatAppearance.BorderSize = 0;
            this.iniciarSesionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(200)))));
            this.iniciarSesionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iniciarSesionButton.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.administradorButton);
            this.Controls.Add(this.empleadoButton);
            this.Controls.Add(this.contenedorPanel);
            this.Controls.Add(this.inicioSesionLabel);
            this.Controls.Add(this.panel1);
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contenedorPanel.ResumeLayout(false);
            this.contenedorPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label encabezadoLabel;
        private System.Windows.Forms.Label inicioSesionLabel;
        private System.Windows.Forms.Panel contenedorPanel;
        private System.Windows.Forms.TextBox contraseñaTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.Label contraseñaLabel;
        private System.Windows.Forms.Label usuarioLabel;
        private buttonLogin empleadoButton;
        private buttonLogin administradorButton;
        private buttonLogin iniciarSesionButton;
    }
}