namespace POS
{
    partial class consultarOrdenesForm
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
            this.nuevaOrdenLabel = new System.Windows.Forms.Label();
            this.agregarOrdenButton = new System.Windows.Forms.Button();
            this.encabezadoPanel = new System.Windows.Forms.Panel();
            this.usuariosButton = new System.Windows.Forms.Button();
            this.ventasButton = new System.Windows.Forms.Button();
            this.ordenesButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.inicioBbutton = new System.Windows.Forms.Button();
            this.encabezadoLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.encabezadoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nuevaOrdenLabel
            // 
            this.nuevaOrdenLabel.AutoSize = true;
            this.nuevaOrdenLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevaOrdenLabel.Location = new System.Drawing.Point(817, 92);
            this.nuevaOrdenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nuevaOrdenLabel.Name = "nuevaOrdenLabel";
            this.nuevaOrdenLabel.Size = new System.Drawing.Size(154, 24);
            this.nuevaOrdenLabel.TabIndex = 27;
            this.nuevaOrdenLabel.Text = "NUEVA ORDEN";
            // 
            // agregarOrdenButton
            // 
            this.agregarOrdenButton.BackColor = System.Drawing.Color.Transparent;
            this.agregarOrdenButton.FlatAppearance.BorderSize = 0;
            this.agregarOrdenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarOrdenButton.Image = global::POS.Properties.Resources.agregar;
            this.agregarOrdenButton.Location = new System.Drawing.Point(992, 87);
            this.agregarOrdenButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.agregarOrdenButton.Name = "agregarOrdenButton";
            this.agregarOrdenButton.Size = new System.Drawing.Size(44, 36);
            this.agregarOrdenButton.TabIndex = 26;
            this.agregarOrdenButton.UseVisualStyleBackColor = false;
            this.agregarOrdenButton.Click += new System.EventHandler(this.agregarOrdenButton_Click);
            // 
            // encabezadoPanel
            // 
            this.encabezadoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.encabezadoPanel.Controls.Add(this.usuariosButton);
            this.encabezadoPanel.Controls.Add(this.ventasButton);
            this.encabezadoPanel.Controls.Add(this.ordenesButton);
            this.encabezadoPanel.Controls.Add(this.menuButton);
            this.encabezadoPanel.Controls.Add(this.inicioBbutton);
            this.encabezadoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.encabezadoPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.encabezadoPanel.Location = new System.Drawing.Point(0, 0);
            this.encabezadoPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.encabezadoPanel.Name = "encabezadoPanel";
            this.encabezadoPanel.Size = new System.Drawing.Size(1067, 46);
            this.encabezadoPanel.TabIndex = 25;
            // 
            // usuariosButton
            // 
            this.usuariosButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.usuariosButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.usuariosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usuariosButton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold);
            this.usuariosButton.ForeColor = System.Drawing.Color.White;
            this.usuariosButton.Location = new System.Drawing.Point(904, 5);
            this.usuariosButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usuariosButton.Name = "usuariosButton";
            this.usuariosButton.Size = new System.Drawing.Size(147, 37);
            this.usuariosButton.TabIndex = 11;
            this.usuariosButton.Text = "USUARIOS";
            this.usuariosButton.UseVisualStyleBackColor = false;
            this.usuariosButton.Click += new System.EventHandler(this.usuariosButton_Click);
            // 
            // ventasButton
            // 
            this.ventasButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ventasButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ventasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ventasButton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold);
            this.ventasButton.ForeColor = System.Drawing.Color.White;
            this.ventasButton.Location = new System.Drawing.Point(776, 5);
            this.ventasButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ventasButton.Name = "ventasButton";
            this.ventasButton.Size = new System.Drawing.Size(120, 37);
            this.ventasButton.TabIndex = 12;
            this.ventasButton.Text = "VENTAS";
            this.ventasButton.UseVisualStyleBackColor = false;
            this.ventasButton.Click += new System.EventHandler(this.ventasButton_Click);
            // 
            // ordenesButton
            // 
            this.ordenesButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ordenesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ordenesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordenesButton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold);
            this.ordenesButton.ForeColor = System.Drawing.Color.White;
            this.ordenesButton.Location = new System.Drawing.Point(632, 4);
            this.ordenesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ordenesButton.Name = "ordenesButton";
            this.ordenesButton.Size = new System.Drawing.Size(135, 37);
            this.ordenesButton.TabIndex = 11;
            this.ordenesButton.Text = "ORDENES";
            this.ordenesButton.UseVisualStyleBackColor = false;
            this.ordenesButton.Click += new System.EventHandler(this.ordenesButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold);
            this.menuButton.ForeColor = System.Drawing.Color.White;
            this.menuButton.Location = new System.Drawing.Point(504, 4);
            this.menuButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(120, 37);
            this.menuButton.TabIndex = 10;
            this.menuButton.Text = "MENÚ";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // inicioBbutton
            // 
            this.inicioBbutton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.inicioBbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.inicioBbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.inicioBbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inicioBbutton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold);
            this.inicioBbutton.ForeColor = System.Drawing.Color.White;
            this.inicioBbutton.Location = new System.Drawing.Point(376, 4);
            this.inicioBbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inicioBbutton.Name = "inicioBbutton";
            this.inicioBbutton.Size = new System.Drawing.Size(120, 37);
            this.inicioBbutton.TabIndex = 9;
            this.inicioBbutton.Text = "INICIO";
            this.inicioBbutton.UseVisualStyleBackColor = false;
            // 
            // encabezadoLabel
            // 
            this.encabezadoLabel.AutoSize = true;
            this.encabezadoLabel.Font = new System.Drawing.Font("Gadugi", 18.75F, System.Drawing.FontStyle.Bold);
            this.encabezadoLabel.Location = new System.Drawing.Point(165, 92);
            this.encabezadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.encabezadoLabel.Name = "encabezadoLabel";
            this.encabezadoLabel.Size = new System.Drawing.Size(163, 38);
            this.encabezadoLabel.TabIndex = 24;
            this.encabezadoLabel.Text = "ORDENES";
            this.encabezadoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPictureBox.Image = global::POS.Properties.Resources.LOGO;
            this.logoPictureBox.Location = new System.Drawing.Point(4, 53);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(153, 123);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 23;
            this.logoPictureBox.TabStop = false;
            // 
            // consultarOrdenesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 653);
            this.Controls.Add(this.nuevaOrdenLabel);
            this.Controls.Add(this.agregarOrdenButton);
            this.Controls.Add(this.encabezadoPanel);
            this.Controls.Add(this.encabezadoLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "consultarOrdenesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta ordenes";
            this.encabezadoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nuevaOrdenLabel;
        private System.Windows.Forms.Button agregarOrdenButton;
        private System.Windows.Forms.Panel encabezadoPanel;
        private System.Windows.Forms.Button usuariosButton;
        private System.Windows.Forms.Button ventasButton;
        private System.Windows.Forms.Button ordenesButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button inicioBbutton;
        private System.Windows.Forms.Label encabezadoLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
    }
}
