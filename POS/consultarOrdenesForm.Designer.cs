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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultarOrdenesForm));
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
            this.ordenesDataGridView = new System.Windows.Forms.DataGridView();
            this.idLabel = new System.Windows.Forms.Label();
            this.noMesaLabel = new System.Windows.Forms.Label();
            this.servicioLabel = new System.Windows.Forms.Label();
            this.fechaLabel = new System.Windows.Forms.Label();
            this.horaLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.estadoELabel = new System.Windows.Forms.Label();
            this.actualizarButton = new System.Windows.Forms.Button();
            this.encabezadoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nuevaOrdenLabel
            // 
            this.nuevaOrdenLabel.AutoSize = true;
            this.nuevaOrdenLabel.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.nuevaOrdenLabel.Location = new System.Drawing.Point(771, 87);
            this.nuevaOrdenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nuevaOrdenLabel.Name = "nuevaOrdenLabel";
            this.nuevaOrdenLabel.Size = new System.Drawing.Size(185, 28);
            this.nuevaOrdenLabel.TabIndex = 27;
            this.nuevaOrdenLabel.Text = "NUEVA ORDEN";
            // 
            // agregarOrdenButton
            // 
            this.agregarOrdenButton.BackColor = System.Drawing.Color.Transparent;
            this.agregarOrdenButton.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.encabezadoPanel.Size = new System.Drawing.Size(1067, 60);
            this.encabezadoPanel.TabIndex = 25;
            // 
            // usuariosButton
            // 
            this.usuariosButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.usuariosButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.usuariosButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usuariosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usuariosButton.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
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
            this.ventasButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ventasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ventasButton.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
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
            this.ordenesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ordenesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordenesButton.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
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
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
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
            this.inicioBbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inicioBbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inicioBbutton.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.inicioBbutton.ForeColor = System.Drawing.Color.White;
            this.inicioBbutton.Location = new System.Drawing.Point(376, 4);
            this.inicioBbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inicioBbutton.Name = "inicioBbutton";
            this.inicioBbutton.Size = new System.Drawing.Size(120, 37);
            this.inicioBbutton.TabIndex = 9;
            this.inicioBbutton.Text = "INICIO";
            this.inicioBbutton.UseVisualStyleBackColor = false;
            this.inicioBbutton.Click += new System.EventHandler(this.inicioBbutton_Click);
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
            // ordenesDataGridView
            // 
            this.ordenesDataGridView.AllowUserToAddRows = false;
            this.ordenesDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            this.ordenesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ordenesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ordenesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ordenesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.ordenesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordenesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ordenesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordenesDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ordenesDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ordenesDataGridView.Location = new System.Drawing.Point(105, 316);
            this.ordenesDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.ordenesDataGridView.Name = "ordenesDataGridView";
            this.ordenesDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.ordenesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ordenesDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.ordenesDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ordenesDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ordenesDataGridView.Size = new System.Drawing.Size(791, 224);
            this.ordenesDataGridView.TabIndex = 28;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.idLabel.Location = new System.Drawing.Point(120, 257);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(116, 28);
            this.idLabel.TabIndex = 29;
            this.idLabel.Text = "ID Orden";
            // 
            // noMesaLabel
            // 
            this.noMesaLabel.AutoSize = true;
            this.noMesaLabel.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noMesaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.noMesaLabel.Location = new System.Drawing.Point(257, 257);
            this.noMesaLabel.Name = "noMesaLabel";
            this.noMesaLabel.Size = new System.Drawing.Size(113, 28);
            this.noMesaLabel.TabIndex = 30;
            this.noMesaLabel.Text = "No.Mesa";
            // 
            // servicioLabel
            // 
            this.servicioLabel.AutoSize = true;
            this.servicioLabel.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicioLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.servicioLabel.Location = new System.Drawing.Point(413, 257);
            this.servicioLabel.Name = "servicioLabel";
            this.servicioLabel.Size = new System.Drawing.Size(102, 28);
            this.servicioLabel.TabIndex = 32;
            this.servicioLabel.Text = "Servicio";
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.fechaLabel.Location = new System.Drawing.Point(548, 257);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(76, 28);
            this.fechaLabel.TabIndex = 33;
            this.fechaLabel.Text = "Fecha";
            // 
            // horaLabel
            // 
            this.horaLabel.AutoSize = true;
            this.horaLabel.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.horaLabel.Location = new System.Drawing.Point(656, 257);
            this.horaLabel.Name = "horaLabel";
            this.horaLabel.Size = new System.Drawing.Size(68, 28);
            this.horaLabel.TabIndex = 34;
            this.horaLabel.Text = "Hora";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.totalLabel.Location = new System.Drawing.Point(771, 257);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(70, 28);
            this.totalLabel.TabIndex = 35;
            this.totalLabel.Text = "Total";
            // 
            // estadoELabel
            // 
            this.estadoELabel.AutoSize = true;
            this.estadoELabel.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoELabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.estadoELabel.Location = new System.Drawing.Point(870, 257);
            this.estadoELabel.Name = "estadoELabel";
            this.estadoELabel.Size = new System.Drawing.Size(88, 28);
            this.estadoELabel.TabIndex = 36;
            this.estadoELabel.Text = "Estado";
            // 
            // actualizarButton
            // 
            this.actualizarButton.BackColor = System.Drawing.Color.White;
            this.actualizarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("actualizarButton.BackgroundImage")));
            this.actualizarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.actualizarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.actualizarButton.FlatAppearance.BorderSize = 0;
            this.actualizarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.actualizarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.actualizarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actualizarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.actualizarButton.Location = new System.Drawing.Point(983, 248);
            this.actualizarButton.Margin = new System.Windows.Forms.Padding(4);
            this.actualizarButton.Name = "actualizarButton";
            this.actualizarButton.Size = new System.Drawing.Size(53, 37);
            this.actualizarButton.TabIndex = 37;
            this.actualizarButton.UseVisualStyleBackColor = false;
            this.actualizarButton.Click += new System.EventHandler(this.actualizarButton_Click);
            // 
            // consultarOrdenesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 654);
            this.Controls.Add(this.actualizarButton);
            this.Controls.Add(this.estadoELabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.horaLabel);
            this.Controls.Add(this.fechaLabel);
            this.Controls.Add(this.servicioLabel);
            this.Controls.Add(this.noMesaLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.ordenesDataGridView);
            this.Controls.Add(this.nuevaOrdenLabel);
            this.Controls.Add(this.agregarOrdenButton);
            this.Controls.Add(this.encabezadoPanel);
            this.Controls.Add(this.encabezadoLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "consultarOrdenesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta ordenes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.consultarOrdenesForm_Load);
            this.encabezadoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView ordenesDataGridView;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label noMesaLabel;
        private System.Windows.Forms.Label servicioLabel;
        private System.Windows.Forms.Label fechaLabel;
        private System.Windows.Forms.Label horaLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label estadoELabel;
        private System.Windows.Forms.Button actualizarButton;
    }
}
