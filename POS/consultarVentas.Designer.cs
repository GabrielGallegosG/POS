
namespace POS
{
    partial class consultarVentas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultarVentas));
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.encabezadoPanel = new System.Windows.Forms.Panel();
            this.usuariosButton = new System.Windows.Forms.Button();
            this.ventasButton = new System.Windows.Forms.Button();
            this.ordenesButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.inicioBbutton = new System.Windows.Forms.Button();
            this.encabezadoLabel = new System.Windows.Forms.Label();
            this.consultTabla = new System.Windows.Forms.DataGridView();
            this.ordenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOS_BDDataSet = new POS.POS_BDDataSet();
            this.filtroComboBox = new System.Windows.Forms.ComboBox();
            this.filtrarLabel = new System.Windows.Forms.Label();
            this.datoBuscarLabel = new System.Windows.Forms.Label();
            this.ordenTableAdapter = new POS.POS_BDDataSetTableAdapters.ordenTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentariosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodoPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoServicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numMesaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMenuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOrdenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.encabezadoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOS_BDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(12, 48);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(115, 100);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 53;
            this.logoPictureBox.TabStop = false;
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
            this.encabezadoPanel.Name = "encabezadoPanel";
            this.encabezadoPanel.Size = new System.Drawing.Size(1061, 49);
            this.encabezadoPanel.TabIndex = 52;
            // 
            // usuariosButton
            // 
            this.usuariosButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.usuariosButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.usuariosButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usuariosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usuariosButton.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.usuariosButton.ForeColor = System.Drawing.Color.White;
            this.usuariosButton.Location = new System.Drawing.Point(902, 3);
            this.usuariosButton.Name = "usuariosButton";
            this.usuariosButton.Size = new System.Drawing.Size(110, 30);
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
            this.ventasButton.Location = new System.Drawing.Point(806, 3);
            this.ventasButton.Name = "ventasButton";
            this.ventasButton.Size = new System.Drawing.Size(90, 30);
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
            this.ordenesButton.Location = new System.Drawing.Point(698, 3);
            this.ordenesButton.Name = "ordenesButton";
            this.ordenesButton.Size = new System.Drawing.Size(101, 30);
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
            this.menuButton.Location = new System.Drawing.Point(602, 3);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(90, 30);
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
            this.inicioBbutton.Location = new System.Drawing.Point(506, 3);
            this.inicioBbutton.Name = "inicioBbutton";
            this.inicioBbutton.Size = new System.Drawing.Size(90, 30);
            this.inicioBbutton.TabIndex = 9;
            this.inicioBbutton.Text = "INICIO";
            this.inicioBbutton.UseVisualStyleBackColor = false;
            this.inicioBbutton.Click += new System.EventHandler(this.inicioBbutton_Click);
            // 
            // encabezadoLabel
            // 
            this.encabezadoLabel.AutoSize = true;
            this.encabezadoLabel.Font = new System.Drawing.Font("Gadugi", 18.75F, System.Drawing.FontStyle.Bold);
            this.encabezadoLabel.Location = new System.Drawing.Point(133, 87);
            this.encabezadoLabel.Name = "encabezadoLabel";
            this.encabezadoLabel.Size = new System.Drawing.Size(110, 30);
            this.encabezadoLabel.TabIndex = 56;
            this.encabezadoLabel.Text = "VENTAS";
            this.encabezadoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // consultTabla
            // 
            this.consultTabla.AllowUserToDeleteRows = false;
            this.consultTabla.AutoGenerateColumns = false;
            this.consultTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrdenDataGridViewTextBoxColumn,
            this.idMenuDataGridViewTextBoxColumn,
            this.numMesaDataGridViewTextBoxColumn,
            this.tipoServicioDataGridViewTextBoxColumn,
            this.metodoPagoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.comentariosDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.consultTabla.DataSource = this.ordenBindingSource;
            this.consultTabla.Location = new System.Drawing.Point(13, 171);
            this.consultTabla.Name = "consultTabla";
            this.consultTabla.ReadOnly = true;
            this.consultTabla.Size = new System.Drawing.Size(915, 334);
            this.consultTabla.TabIndex = 60;
            // 
            // ordenBindingSource
            // 
            this.ordenBindingSource.DataMember = "orden";
            this.ordenBindingSource.DataSource = this.pOS_BDDataSet;
            // 
            // pOS_BDDataSet
            // 
            this.pOS_BDDataSet.DataSetName = "POS_BDDataSet";
            this.pOS_BDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filtroComboBox
            // 
            this.filtroComboBox.FormattingEnabled = true;
            this.filtroComboBox.Items.AddRange(new object[] {
            "Dia",
            "Empleado",
            "Tipo de Servicio",
            "Tipo de Pago"});
            this.filtroComboBox.Location = new System.Drawing.Point(299, 97);
            this.filtroComboBox.Name = "filtroComboBox";
            this.filtroComboBox.Size = new System.Drawing.Size(199, 21);
            this.filtroComboBox.TabIndex = 61;
            this.filtroComboBox.SelectedIndexChanged += new System.EventHandler(this.filtroComboBox_SelectedIndexChanged);
            // 
            // filtrarLabel
            // 
            this.filtrarLabel.AutoSize = true;
            this.filtrarLabel.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtrarLabel.Location = new System.Drawing.Point(295, 62);
            this.filtrarLabel.Name = "filtrarLabel";
            this.filtrarLabel.Size = new System.Drawing.Size(132, 21);
            this.filtrarLabel.TabIndex = 62;
            this.filtrarLabel.Text = "FILTRAR POR:";
            // 
            // datoBuscarLabel
            // 
            this.datoBuscarLabel.AutoSize = true;
            this.datoBuscarLabel.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datoBuscarLabel.Location = new System.Drawing.Point(595, 62);
            this.datoBuscarLabel.Name = "datoBuscarLabel";
            this.datoBuscarLabel.Size = new System.Drawing.Size(164, 21);
            this.datoBuscarLabel.TabIndex = 63;
            this.datoBuscarLabel.Text = "DATO A BUSCAR:";
            // 
            // ordenTableAdapter
            // 
            this.ordenTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(602, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 64;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comentariosDataGridViewTextBoxColumn
            // 
            this.comentariosDataGridViewTextBoxColumn.DataPropertyName = "comentarios";
            this.comentariosDataGridViewTextBoxColumn.HeaderText = "comentarios";
            this.comentariosDataGridViewTextBoxColumn.Name = "comentariosDataGridViewTextBoxColumn";
            this.comentariosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            this.horaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // metodoPagoDataGridViewTextBoxColumn
            // 
            this.metodoPagoDataGridViewTextBoxColumn.DataPropertyName = "metodoPago";
            this.metodoPagoDataGridViewTextBoxColumn.HeaderText = "metodoPago";
            this.metodoPagoDataGridViewTextBoxColumn.Name = "metodoPagoDataGridViewTextBoxColumn";
            this.metodoPagoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoServicioDataGridViewTextBoxColumn
            // 
            this.tipoServicioDataGridViewTextBoxColumn.DataPropertyName = "tipoServicio";
            this.tipoServicioDataGridViewTextBoxColumn.HeaderText = "tipoServicio";
            this.tipoServicioDataGridViewTextBoxColumn.Name = "tipoServicioDataGridViewTextBoxColumn";
            this.tipoServicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numMesaDataGridViewTextBoxColumn
            // 
            this.numMesaDataGridViewTextBoxColumn.DataPropertyName = "numMesa";
            this.numMesaDataGridViewTextBoxColumn.HeaderText = "numMesa";
            this.numMesaDataGridViewTextBoxColumn.Name = "numMesaDataGridViewTextBoxColumn";
            this.numMesaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idMenuDataGridViewTextBoxColumn
            // 
            this.idMenuDataGridViewTextBoxColumn.DataPropertyName = "idMenu";
            this.idMenuDataGridViewTextBoxColumn.HeaderText = "idMenu";
            this.idMenuDataGridViewTextBoxColumn.Name = "idMenuDataGridViewTextBoxColumn";
            this.idMenuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idOrdenDataGridViewTextBoxColumn
            // 
            this.idOrdenDataGridViewTextBoxColumn.DataPropertyName = "idOrden";
            this.idOrdenDataGridViewTextBoxColumn.HeaderText = "idOrden";
            this.idOrdenDataGridViewTextBoxColumn.Name = "idOrdenDataGridViewTextBoxColumn";
            this.idOrdenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // consultarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 620);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.datoBuscarLabel);
            this.Controls.Add(this.filtrarLabel);
            this.Controls.Add(this.filtroComboBox);
            this.Controls.Add(this.consultTabla);
            this.Controls.Add(this.encabezadoLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.encabezadoPanel);
            this.Name = "consultarVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.consultarVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.encabezadoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.consultTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOS_BDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Panel encabezadoPanel;
        private System.Windows.Forms.Button usuariosButton;
        private System.Windows.Forms.Button ventasButton;
        private System.Windows.Forms.Button ordenesButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button inicioBbutton;
        private System.Windows.Forms.Label encabezadoLabel;
        private System.Windows.Forms.DataGridView consultTabla;
        private System.Windows.Forms.ComboBox filtroComboBox;
        private System.Windows.Forms.Label filtrarLabel;
        private System.Windows.Forms.Label datoBuscarLabel;
        private POS_BDDataSet pOS_BDDataSet;
        private System.Windows.Forms.BindingSource ordenBindingSource;
        private POS_BDDataSetTableAdapters.ordenTableAdapter ordenTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrdenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMenuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numMesaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoServicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metodoPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentariosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}