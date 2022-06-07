
namespace POS
{
    partial class inicioForm
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
            this.encabezadoLabel = new System.Windows.Forms.Label();
            this.agregarMenuLabel = new System.Windows.Forms.Label();
            this.consultaLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // encabezadoLabel
            // 
            this.encabezadoLabel.AutoSize = true;
            this.encabezadoLabel.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encabezadoLabel.Location = new System.Drawing.Point(173, 45);
            this.encabezadoLabel.Name = "encabezadoLabel";
            this.encabezadoLabel.Size = new System.Drawing.Size(414, 39);
            this.encabezadoLabel.TabIndex = 0;
            this.encabezadoLabel.Text = "Bienvenido. Elija una opción";
            // 
            // agregarMenuLabel
            // 
            this.agregarMenuLabel.AutoSize = true;
            this.agregarMenuLabel.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarMenuLabel.Location = new System.Drawing.Point(49, 214);
            this.agregarMenuLabel.Name = "agregarMenuLabel";
            this.agregarMenuLabel.Size = new System.Drawing.Size(162, 25);
            this.agregarMenuLabel.TabIndex = 1;
            this.agregarMenuLabel.Text = "Agregar a menú";
            this.agregarMenuLabel.Click += new System.EventHandler(this.agregarMenuLabel_Click);
            // 
            // consultaLabel
            // 
            this.consultaLabel.AutoSize = true;
            this.consultaLabel.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaLabel.Location = new System.Drawing.Point(286, 214);
            this.consultaLabel.Name = "consultaLabel";
            this.consultaLabel.Size = new System.Drawing.Size(159, 25);
            this.consultaLabel.TabIndex = 2;
            this.consultaLabel.Text = "Consultar menú";
            this.consultaLabel.Click += new System.EventHandler(this.consultaLabel_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(52, 301);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(134, 25);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "Iniciar Sesión";
            this.loginLabel.Click += new System.EventHandler(this.loginLabel_Click);
            // 
            // inicioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.consultaLabel);
            this.Controls.Add(this.agregarMenuLabel);
            this.Controls.Add(this.encabezadoLabel);
            this.Name = "inicioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label encabezadoLabel;
        private System.Windows.Forms.Label agregarMenuLabel;
        private System.Windows.Forms.Label consultaLabel;
        private System.Windows.Forms.Label loginLabel;
    }
}