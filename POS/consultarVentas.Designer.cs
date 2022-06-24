
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
            this.idOrdenLabel = new System.Windows.Forms.Label();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.numMesaLabel = new System.Windows.Forms.Label();
            this.tipoServLabel = new System.Windows.Forms.Label();
            this.fechaLabel = new System.Windows.Forms.Label();
            this.horaLabel = new System.Windows.Forms.Label();
            this.totalOrdenLabel = new System.Windows.Forms.Label();
            this.metodoPagoLabel = new System.Windows.Forms.Label();
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
            this.ordenesButton.Size = new System.Drawing.Size(110, 30);
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
            this.consultTabla.BackgroundColor = System.Drawing.Color.White;
            this.consultTabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consultTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultTabla.Location = new System.Drawing.Point(13, 198);
            this.consultTabla.Name = "consultTabla";
            this.consultTabla.ReadOnly = true;
            this.consultTabla.Size = new System.Drawing.Size(942, 410);
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
            this.filtroComboBox.DropDownWidth = 121;
            this.filtroComboBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroComboBox.FormattingEnabled = true;
            this.filtroComboBox.ItemHeight = 19;
            this.filtroComboBox.Items.AddRange(new object[] {
            "DIA",
            "EMPLEADO",
            "TIPO DE SERVICIO",
            "TIPO DE PAGO"});
            this.filtroComboBox.Location = new System.Drawing.Point(299, 97);
            this.filtroComboBox.Name = "filtroComboBox";
            this.filtroComboBox.Size = new System.Drawing.Size(199, 27);
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
            // idOrdenLabel
            // 
            this.idOrdenLabel.AutoSize = true;
            this.idOrdenLabel.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idOrdenLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.idOrdenLabel.Location = new System.Drawing.Point(23, 174);
            this.idOrdenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idOrdenLabel.Name = "idOrdenLabel";
            this.idOrdenLabel.Size = new System.Drawing.Size(30, 21);
            this.idOrdenLabel.TabIndex = 65;
            this.idOrdenLabel.Text = "ID";
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.usuarioLabel.Location = new System.Drawing.Point(88, 174);
            this.usuarioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(79, 21);
            this.usuarioLabel.TabIndex = 66;
            this.usuarioLabel.Text = "Usuario";
            // 
            // numMesaLabel
            // 
            this.numMesaLabel.AutoSize = true;
            this.numMesaLabel.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMesaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.numMesaLabel.Location = new System.Drawing.Point(203, 174);
            this.numMesaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numMesaLabel.Name = "numMesaLabel";
            this.numMesaLabel.Size = new System.Drawing.Size(93, 21);
            this.numMesaLabel.TabIndex = 67;
            this.numMesaLabel.Text = "No. Mesa";
            // 
            // tipoServLabel
            // 
            this.tipoServLabel.AutoSize = true;
            this.tipoServLabel.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoServLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tipoServLabel.Location = new System.Drawing.Point(322, 174);
            this.tipoServLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tipoServLabel.Name = "tipoServLabel";
            this.tipoServLabel.Size = new System.Drawing.Size(152, 21);
            this.tipoServLabel.TabIndex = 68;
            this.tipoServLabel.Text = "Tipo de Servicio";
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.fechaLabel.Location = new System.Drawing.Point(511, 174);
            this.fechaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(60, 21);
            this.fechaLabel.TabIndex = 69;
            this.fechaLabel.Text = "Fecha";
            // 
            // horaLabel
            // 
            this.horaLabel.AutoSize = true;
            this.horaLabel.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.horaLabel.Location = new System.Drawing.Point(615, 174);
            this.horaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.horaLabel.Name = "horaLabel";
            this.horaLabel.Size = new System.Drawing.Size(55, 21);
            this.horaLabel.TabIndex = 70;
            this.horaLabel.Text = "Hora";
            // 
            // totalOrdenLabel
            // 
            this.totalOrdenLabel.AutoSize = true;
            this.totalOrdenLabel.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOrdenLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.totalOrdenLabel.Location = new System.Drawing.Point(704, 174);
            this.totalOrdenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalOrdenLabel.Name = "totalOrdenLabel";
            this.totalOrdenLabel.Size = new System.Drawing.Size(55, 21);
            this.totalOrdenLabel.TabIndex = 71;
            this.totalOrdenLabel.Text = "Total";
            // 
            // metodoPagoLabel
            // 
            this.metodoPagoLabel.AutoSize = true;
            this.metodoPagoLabel.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metodoPagoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.metodoPagoLabel.Location = new System.Drawing.Point(796, 174);
            this.metodoPagoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metodoPagoLabel.Name = "metodoPagoLabel";
            this.metodoPagoLabel.Size = new System.Drawing.Size(159, 21);
            this.metodoPagoLabel.TabIndex = 72;
            this.metodoPagoLabel.Text = "Metodo de Pago";
            // 
            // consultarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1061, 620);
            this.Controls.Add(this.metodoPagoLabel);
            this.Controls.Add(this.totalOrdenLabel);
            this.Controls.Add(this.horaLabel);
            this.Controls.Add(this.fechaLabel);
            this.Controls.Add(this.tipoServLabel);
            this.Controls.Add(this.numMesaLabel);
            this.Controls.Add(this.usuarioLabel);
            this.Controls.Add(this.idOrdenLabel);
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
        private System.Windows.Forms.Label idOrdenLabel;
        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.Label numMesaLabel;
        private System.Windows.Forms.Label tipoServLabel;
        private System.Windows.Forms.Label fechaLabel;
        private System.Windows.Forms.Label horaLabel;
        private System.Windows.Forms.Label totalOrdenLabel;
        private System.Windows.Forms.Label metodoPagoLabel;
    }
}