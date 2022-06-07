
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
            this.empleadoButton = new System.Windows.Forms.Button();
            this.administradorButton = new System.Windows.Forms.Button();
            this.contenedorPanel = new System.Windows.Forms.Panel();
            this.contraseñaTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.contraseñaLabel = new System.Windows.Forms.Label();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.iniciarSesionButton = new System.Windows.Forms.Button();
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
            // empleadoButton
            // 
            this.empleadoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.empleadoButton.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empleadoButton.ForeColor = System.Drawing.Color.White;
            this.empleadoButton.Location = new System.Drawing.Point(64, 118);
            this.empleadoButton.Name = "empleadoButton";
            this.empleadoButton.Size = new System.Drawing.Size(168, 44);
            this.empleadoButton.TabIndex = 2;
            this.empleadoButton.Text = "SOY EMPLEADO";
            this.empleadoButton.UseVisualStyleBackColor = false;
            // 
            // administradorButton
            // 
            this.administradorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.administradorButton.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administradorButton.ForeColor = System.Drawing.Color.White;
            this.administradorButton.Location = new System.Drawing.Point(456, 120);
            this.administradorButton.Name = "administradorButton";
            this.administradorButton.Size = new System.Drawing.Size(231, 42);
            this.administradorButton.TabIndex = 3;
            this.administradorButton.Text = "SOY ADMINISTRADOR";
            this.administradorButton.UseVisualStyleBackColor = false;
            // 
            // contenedorPanel
            // 
            this.contenedorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            this.contenedorPanel.Controls.Add(this.contraseñaTextBox);
            this.contenedorPanel.Controls.Add(this.usuarioTextBox);
            this.contenedorPanel.Controls.Add(this.contraseñaLabel);
            this.contenedorPanel.Controls.Add(this.usuarioLabel);
            this.contenedorPanel.Controls.Add(this.iniciarSesionButton);
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
            // iniciarSesionButton
            // 
            this.iniciarSesionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.iniciarSesionButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciarSesionButton.ForeColor = System.Drawing.Color.White;
            this.iniciarSesionButton.Location = new System.Drawing.Point(143, 201);
            this.iniciarSesionButton.Name = "iniciarSesionButton";
            this.iniciarSesionButton.Size = new System.Drawing.Size(134, 32);
            this.iniciarSesionButton.TabIndex = 5;
            this.iniciarSesionButton.Text = "INICIAR  SESIÓN";
            this.iniciarSesionButton.UseVisualStyleBackColor = false;
            this.iniciarSesionButton.Click += new System.EventHandler(this.iniciarSesionButton_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contenedorPanel);
            this.Controls.Add(this.administradorButton);
            this.Controls.Add(this.empleadoButton);
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
        private System.Windows.Forms.Button empleadoButton;
        private System.Windows.Forms.Button administradorButton;
        private System.Windows.Forms.Panel contenedorPanel;
        private System.Windows.Forms.TextBox contraseñaTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.Label contraseñaLabel;
        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.Button iniciarSesionButton;
    }
}