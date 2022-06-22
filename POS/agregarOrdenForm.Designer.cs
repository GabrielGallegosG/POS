
namespace POS
{
    partial class agregarOrdenForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregarOrdenForm));
            this.encabezadoPanel = new System.Windows.Forms.Panel();
            this.noOrdenLabel = new System.Windows.Forms.Label();
            this.empleadoLabel = new System.Windows.Forms.Label();
            this.tipoServicioLabel = new System.Windows.Forms.Label();
            this.noMesaLabel = new System.Windows.Forms.Label();
            this.fechaLabel = new System.Windows.Forms.Label();
            this.horaLabel = new System.Windows.Forms.Label();
            this.tipoServicioComboBox = new System.Windows.Forms.ComboBox();
            this.noMesaComboBox = new System.Windows.Forms.ComboBox();
            this.platilloCheckBox = new System.Windows.Forms.CheckBox();
            this.postreCheckBox = new System.Windows.Forms.CheckBox();
            this.bebidaCheckBox = new System.Windows.Forms.CheckBox();
            this.agregarLabel = new System.Windows.Forms.Label();
            this.comentariosRichTextBox = new System.Windows.Forms.RichTextBox();
            this.comentariosLabel = new System.Windows.Forms.Label();
            this.horaOrdenLabel = new System.Windows.Forms.Label();
            this.fechaOrdenLabel = new System.Windows.Forms.Label();
            this.empleadoOrdenLabel = new System.Windows.Forms.Label();
            this.platillosDataGridView = new System.Windows.Forms.DataGridView();
            this.bebidasDataGridView = new System.Windows.Forms.DataGridView();
            this.postresDataGridView = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ordenDataGridView = new System.Windows.Forms.DataGridView();
            this.actualizarButton = new System.Windows.Forms.Button();
            this.precioElementoLabel = new System.Windows.Forms.Label();
            this.nombreElementoLabel = new System.Windows.Forms.Label();
            this.cantidadElementoLabel = new System.Windows.Forms.Label();
            this.subtotalElementoLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalElementosLabel = new System.Windows.Forms.Label();
            this.agregarButton = new buttonSystem();
            this.cancelarButton = new buttonSystem();
            this.encabezadoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.platillosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bebidasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // encabezadoPanel
            // 
            this.encabezadoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.encabezadoPanel.AutoSize = true;
            this.encabezadoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.encabezadoPanel.Controls.Add(this.noOrdenLabel);
            this.encabezadoPanel.Location = new System.Drawing.Point(2, 0);
            this.encabezadoPanel.Margin = new System.Windows.Forms.Padding(7);
            this.encabezadoPanel.Name = "encabezadoPanel";
            this.encabezadoPanel.Size = new System.Drawing.Size(2212, 49);
            this.encabezadoPanel.TabIndex = 11;
            // 
            // noOrdenLabel
            // 
            this.noOrdenLabel.AutoSize = true;
            this.noOrdenLabel.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOrdenLabel.ForeColor = System.Drawing.Color.White;
            this.noOrdenLabel.Location = new System.Drawing.Point(24, 15);
            this.noOrdenLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.noOrdenLabel.Name = "noOrdenLabel";
            this.noOrdenLabel.Size = new System.Drawing.Size(144, 25);
            this.noOrdenLabel.TabIndex = 9;
            this.noOrdenLabel.Text = "NO.ORDEN - ";
            // 
            // empleadoLabel
            // 
            this.empleadoLabel.AutoSize = true;
            this.empleadoLabel.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empleadoLabel.Location = new System.Drawing.Point(39, 109);
            this.empleadoLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.empleadoLabel.Name = "empleadoLabel";
            this.empleadoLabel.Size = new System.Drawing.Size(110, 22);
            this.empleadoLabel.TabIndex = 12;
            this.empleadoLabel.Text = "EMPLEADO:";
            // 
            // tipoServicioLabel
            // 
            this.tipoServicioLabel.AutoSize = true;
            this.tipoServicioLabel.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoServicioLabel.Location = new System.Drawing.Point(23, 170);
            this.tipoServicioLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.tipoServicioLabel.Name = "tipoServicioLabel";
            this.tipoServicioLabel.Size = new System.Drawing.Size(166, 22);
            this.tipoServicioLabel.TabIndex = 13;
            this.tipoServicioLabel.Text = "TIPO DE SERVICIO:";
            // 
            // noMesaLabel
            // 
            this.noMesaLabel.AutoSize = true;
            this.noMesaLabel.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noMesaLabel.Location = new System.Drawing.Point(14, 244);
            this.noMesaLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.noMesaLabel.Name = "noMesaLabel";
            this.noMesaLabel.Size = new System.Drawing.Size(128, 22);
            this.noMesaLabel.TabIndex = 14;
            this.noMesaLabel.Text = "NO. DE MESA:";
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaLabel.Location = new System.Drawing.Point(1129, 99);
            this.fechaLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(70, 22);
            this.fechaLabel.TabIndex = 15;
            this.fechaLabel.Text = "FECHA:";
            // 
            // horaLabel
            // 
            this.horaLabel.AutoSize = true;
            this.horaLabel.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaLabel.Location = new System.Drawing.Point(1136, 214);
            this.horaLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.horaLabel.Name = "horaLabel";
            this.horaLabel.Size = new System.Drawing.Size(64, 22);
            this.horaLabel.TabIndex = 16;
            this.horaLabel.Text = "HORA:";
            // 
            // tipoServicioComboBox
            // 
            this.tipoServicioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoServicioComboBox.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoServicioComboBox.FormattingEnabled = true;
            this.tipoServicioComboBox.Items.AddRange(new object[] {
            "PARA COMER AQUI",
            "PARA LLEVAR"});
            this.tipoServicioComboBox.Location = new System.Drawing.Point(248, 163);
            this.tipoServicioComboBox.Margin = new System.Windows.Forms.Padding(7);
            this.tipoServicioComboBox.Name = "tipoServicioComboBox";
            this.tipoServicioComboBox.Size = new System.Drawing.Size(257, 29);
            this.tipoServicioComboBox.TabIndex = 17;
            // 
            // noMesaComboBox
            // 
            this.noMesaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.noMesaComboBox.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noMesaComboBox.FormattingEnabled = true;
            this.noMesaComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.noMesaComboBox.Location = new System.Drawing.Point(239, 237);
            this.noMesaComboBox.Margin = new System.Windows.Forms.Padding(7);
            this.noMesaComboBox.Name = "noMesaComboBox";
            this.noMesaComboBox.Size = new System.Drawing.Size(257, 29);
            this.noMesaComboBox.TabIndex = 18;
            // 
            // platilloCheckBox
            // 
            this.platilloCheckBox.AutoSize = true;
            this.platilloCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.platilloCheckBox.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platilloCheckBox.Location = new System.Drawing.Point(28, 397);
            this.platilloCheckBox.Margin = new System.Windows.Forms.Padding(7);
            this.platilloCheckBox.Name = "platilloCheckBox";
            this.platilloCheckBox.Size = new System.Drawing.Size(108, 26);
            this.platilloCheckBox.TabIndex = 19;
            this.platilloCheckBox.Text = "PLATILLO";
            this.platilloCheckBox.UseVisualStyleBackColor = true;
            this.platilloCheckBox.CheckedChanged += new System.EventHandler(this.platilloCheckBox_CheckedChanged);
            // 
            // postreCheckBox
            // 
            this.postreCheckBox.AutoSize = true;
            this.postreCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.postreCheckBox.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postreCheckBox.Location = new System.Drawing.Point(252, 397);
            this.postreCheckBox.Margin = new System.Windows.Forms.Padding(7);
            this.postreCheckBox.Name = "postreCheckBox";
            this.postreCheckBox.Size = new System.Drawing.Size(95, 26);
            this.postreCheckBox.TabIndex = 20;
            this.postreCheckBox.Text = "POSTRE";
            this.postreCheckBox.UseVisualStyleBackColor = true;
            this.postreCheckBox.CheckedChanged += new System.EventHandler(this.postreCheckBox_CheckedChanged);
            // 
            // bebidaCheckBox
            // 
            this.bebidaCheckBox.AutoSize = true;
            this.bebidaCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bebidaCheckBox.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bebidaCheckBox.Location = new System.Drawing.Point(458, 397);
            this.bebidaCheckBox.Margin = new System.Windows.Forms.Padding(7);
            this.bebidaCheckBox.Name = "bebidaCheckBox";
            this.bebidaCheckBox.Size = new System.Drawing.Size(91, 26);
            this.bebidaCheckBox.TabIndex = 21;
            this.bebidaCheckBox.Text = "BEBIDA";
            this.bebidaCheckBox.UseVisualStyleBackColor = true;
            this.bebidaCheckBox.CheckedChanged += new System.EventHandler(this.bebidaCheckBox_CheckedChanged);
            // 
            // agregarLabel
            // 
            this.agregarLabel.AutoSize = true;
            this.agregarLabel.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarLabel.Location = new System.Drawing.Point(16, 329);
            this.agregarLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.agregarLabel.Name = "agregarLabel";
            this.agregarLabel.Size = new System.Drawing.Size(222, 22);
            this.agregarLabel.TabIndex = 22;
            this.agregarLabel.Text = "¿QUÉ DESEAS AGREGAR?";
            // 
            // comentariosRichTextBox
            // 
            this.comentariosRichTextBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comentariosRichTextBox.Location = new System.Drawing.Point(32, 742);
            this.comentariosRichTextBox.Margin = new System.Windows.Forms.Padding(7);
            this.comentariosRichTextBox.Name = "comentariosRichTextBox";
            this.comentariosRichTextBox.Size = new System.Drawing.Size(794, 90);
            this.comentariosRichTextBox.TabIndex = 26;
            this.comentariosRichTextBox.Text = "";
            // 
            // comentariosLabel
            // 
            this.comentariosLabel.AutoSize = true;
            this.comentariosLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comentariosLabel.Location = new System.Drawing.Point(20, 697);
            this.comentariosLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.comentariosLabel.Name = "comentariosLabel";
            this.comentariosLabel.Size = new System.Drawing.Size(121, 19);
            this.comentariosLabel.TabIndex = 25;
            this.comentariosLabel.Text = "COMENTARIOS:";
            // 
            // horaOrdenLabel
            // 
            this.horaOrdenLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.horaOrdenLabel.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaOrdenLabel.Location = new System.Drawing.Point(1268, 207);
            this.horaOrdenLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.horaOrdenLabel.Name = "horaOrdenLabel";
            this.horaOrdenLabel.Size = new System.Drawing.Size(216, 46);
            this.horaOrdenLabel.TabIndex = 27;
            // 
            // fechaOrdenLabel
            // 
            this.fechaOrdenLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fechaOrdenLabel.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaOrdenLabel.Location = new System.Drawing.Point(1268, 91);
            this.fechaOrdenLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.fechaOrdenLabel.Name = "fechaOrdenLabel";
            this.fechaOrdenLabel.Size = new System.Drawing.Size(216, 46);
            this.fechaOrdenLabel.TabIndex = 28;
            // 
            // empleadoOrdenLabel
            // 
            this.empleadoOrdenLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empleadoOrdenLabel.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empleadoOrdenLabel.Location = new System.Drawing.Point(257, 91);
            this.empleadoOrdenLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.empleadoOrdenLabel.Name = "empleadoOrdenLabel";
            this.empleadoOrdenLabel.Size = new System.Drawing.Size(216, 46);
            this.empleadoOrdenLabel.TabIndex = 29;
            // 
            // platillosDataGridView
            // 
            this.platillosDataGridView.AllowUserToAddRows = false;
            this.platillosDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            this.platillosDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.platillosDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.platillosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.platillosDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.platillosDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.platillosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.platillosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.platillosDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.platillosDataGridView.Location = new System.Drawing.Point(22, 440);
            this.platillosDataGridView.Margin = new System.Windows.Forms.Padding(7);
            this.platillosDataGridView.Name = "platillosDataGridView";
            this.platillosDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.platillosDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.platillosDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.platillosDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.platillosDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.platillosDataGridView.Size = new System.Drawing.Size(708, 60);
            this.platillosDataGridView.TabIndex = 32;
            this.platillosDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPlatillos_CellMouseClick);
            this.platillosDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.platillosDataGridView_EditingControlShowing);
            this.platillosDataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Columns_KeyPress);
            // 
            // bebidasDataGridView
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            this.bebidasDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.bebidasDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.bebidasDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bebidasDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.bebidasDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bebidasDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.bebidasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bebidasDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bebidasDataGridView.Location = new System.Drawing.Point(22, 514);
            this.bebidasDataGridView.Margin = new System.Windows.Forms.Padding(7);
            this.bebidasDataGridView.Name = "bebidasDataGridView";
            this.bebidasDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.bebidasDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.bebidasDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.bebidasDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bebidasDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bebidasDataGridView.Size = new System.Drawing.Size(708, 63);
            this.bebidasDataGridView.TabIndex = 33;
            this.bebidasDataGridView.Visible = false;
            this.bebidasDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewBebidas_CellMouseClick);
            this.bebidasDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.bebidasDataGridView_EditingControlShowing);
            this.bebidasDataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeros_KeyPress);
            // 
            // postresDataGridView
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            this.postresDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.postresDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.postresDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.postresDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.postresDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.postresDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.postresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.postresDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.postresDataGridView.Location = new System.Drawing.Point(22, 591);
            this.postresDataGridView.Margin = new System.Windows.Forms.Padding(7);
            this.postresDataGridView.Name = "postresDataGridView";
            this.postresDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.postresDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.postresDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.postresDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.postresDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.postresDataGridView.Size = new System.Drawing.Size(704, 78);
            this.postresDataGridView.TabIndex = 34;
            this.postresDataGridView.Visible = false;
            this.postresDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPostres_CellMouseClick);
            this.postresDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.postresDataGridView_EditingControlShowing);
            this.postresDataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeros_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // ordenDataGridView
            // 
            this.ordenDataGridView.AllowUserToAddRows = false;
            this.ordenDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            this.ordenDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.ordenDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ordenDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ordenDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.ordenDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordenDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.ordenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordenDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ordenDataGridView.Location = new System.Drawing.Point(744, 440);
            this.ordenDataGridView.Margin = new System.Windows.Forms.Padding(7);
            this.ordenDataGridView.Name = "ordenDataGridView";
            this.ordenDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.ordenDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.ordenDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.ordenDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ordenDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ordenDataGridView.Size = new System.Drawing.Size(631, 229);
            this.ordenDataGridView.TabIndex = 35;
            this.ordenDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ordenDataGridView_CellMouseClick);
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
            this.actualizarButton.Location = new System.Drawing.Point(1286, 392);
            this.actualizarButton.Margin = new System.Windows.Forms.Padding(4);
            this.actualizarButton.Name = "actualizarButton";
            this.actualizarButton.Size = new System.Drawing.Size(53, 37);
            this.actualizarButton.TabIndex = 38;
            this.actualizarButton.UseVisualStyleBackColor = false;
            this.actualizarButton.Visible = false;
            // 
            // precioElementoLabel
            // 
            this.precioElementoLabel.AutoSize = true;
            this.precioElementoLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold);
            this.precioElementoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.precioElementoLabel.Location = new System.Drawing.Point(863, 397);
            this.precioElementoLabel.Name = "precioElementoLabel";
            this.precioElementoLabel.Size = new System.Drawing.Size(57, 19);
            this.precioElementoLabel.TabIndex = 37;
            this.precioElementoLabel.Text = "Precio";
            // 
            // nombreElementoLabel
            // 
            this.nombreElementoLabel.AutoSize = true;
            this.nombreElementoLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold);
            this.nombreElementoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nombreElementoLabel.Location = new System.Drawing.Point(739, 397);
            this.nombreElementoLabel.Name = "nombreElementoLabel";
            this.nombreElementoLabel.Size = new System.Drawing.Size(72, 19);
            this.nombreElementoLabel.TabIndex = 36;
            this.nombreElementoLabel.Text = "Nombre";
            // 
            // cantidadElementoLabel
            // 
            this.cantidadElementoLabel.AutoSize = true;
            this.cantidadElementoLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold);
            this.cantidadElementoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cantidadElementoLabel.Location = new System.Drawing.Point(966, 397);
            this.cantidadElementoLabel.Name = "cantidadElementoLabel";
            this.cantidadElementoLabel.Size = new System.Drawing.Size(48, 19);
            this.cantidadElementoLabel.TabIndex = 39;
            this.cantidadElementoLabel.Text = "Cant.";
            // 
            // subtotalElementoLabel
            // 
            this.subtotalElementoLabel.AutoSize = true;
            this.subtotalElementoLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold);
            this.subtotalElementoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.subtotalElementoLabel.Location = new System.Drawing.Point(1074, 397);
            this.subtotalElementoLabel.Name = "subtotalElementoLabel";
            this.subtotalElementoLabel.Size = new System.Drawing.Size(74, 19);
            this.subtotalElementoLabel.TabIndex = 40;
            this.subtotalElementoLabel.Text = "Subtotal";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.totalLabel.Location = new System.Drawing.Point(1116, 693);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(55, 21);
            this.totalLabel.TabIndex = 41;
            this.totalLabel.Text = "Total";
            // 
            // totalElementosLabel
            // 
            this.totalElementosLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalElementosLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.totalElementosLabel.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalElementosLabel.Location = new System.Drawing.Point(1196, 688);
            this.totalElementosLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.totalElementosLabel.Name = "totalElementosLabel";
            this.totalElementosLabel.Size = new System.Drawing.Size(179, 46);
            this.totalElementosLabel.TabIndex = 42;
            this.totalElementosLabel.Text = "$$.$$";
            this.totalElementosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // agregarButton
            // 
            this.agregarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.agregarButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.agregarButton.BorderRadius = 20;
            this.agregarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarButton.FlatAppearance.BorderSize = 0;
            this.agregarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(60)))));
            this.agregarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarButton.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold);
            this.agregarButton.ForeColor = System.Drawing.Color.Black;
            this.agregarButton.Location = new System.Drawing.Point(1193, 835);
            this.agregarButton.Margin = new System.Windows.Forms.Padding(7);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Padding = new System.Windows.Forms.Padding(7);
            this.agregarButton.Size = new System.Drawing.Size(182, 49);
            this.agregarButton.TabIndex = 31;
            this.agregarButton.Text = "AGREGAR";
            this.agregarButton.UseVisualStyleBackColor = false;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click_1);
            // 
            // cancelarButton
            // 
            this.cancelarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.cancelarButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(89)))));
            this.cancelarButton.BorderRadius = 20;
            this.cancelarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarButton.FlatAppearance.BorderSize = 0;
            this.cancelarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(60)))));
            this.cancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarButton.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold);
            this.cancelarButton.ForeColor = System.Drawing.Color.Black;
            this.cancelarButton.Location = new System.Drawing.Point(32, 866);
            this.cancelarButton.Margin = new System.Windows.Forms.Padding(7);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Padding = new System.Windows.Forms.Padding(7);
            this.cancelarButton.Size = new System.Drawing.Size(162, 49);
            this.cancelarButton.TabIndex = 30;
            this.cancelarButton.Text = "CANCELAR";
            this.cancelarButton.UseVisualStyleBackColor = false;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // agregarOrdenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.totalElementosLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.subtotalElementoLabel);
            this.Controls.Add(this.cantidadElementoLabel);
            this.Controls.Add(this.actualizarButton);
            this.Controls.Add(this.precioElementoLabel);
            this.Controls.Add(this.nombreElementoLabel);
            this.Controls.Add(this.ordenDataGridView);
            this.Controls.Add(this.postresDataGridView);
            this.Controls.Add(this.bebidasDataGridView);
            this.Controls.Add(this.platillosDataGridView);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.empleadoOrdenLabel);
            this.Controls.Add(this.fechaOrdenLabel);
            this.Controls.Add(this.horaOrdenLabel);
            this.Controls.Add(this.comentariosRichTextBox);
            this.Controls.Add(this.comentariosLabel);
            this.Controls.Add(this.agregarLabel);
            this.Controls.Add(this.bebidaCheckBox);
            this.Controls.Add(this.postreCheckBox);
            this.Controls.Add(this.platilloCheckBox);
            this.Controls.Add(this.noMesaComboBox);
            this.Controls.Add(this.tipoServicioComboBox);
            this.Controls.Add(this.horaLabel);
            this.Controls.Add(this.fechaLabel);
            this.Controls.Add(this.noMesaLabel);
            this.Controls.Add(this.tipoServicioLabel);
            this.Controls.Add(this.empleadoLabel);
            this.Controls.Add(this.encabezadoPanel);
            this.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "agregarOrdenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar orden";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.agregarOrdenForm_Load);
            this.encabezadoPanel.ResumeLayout(false);
            this.encabezadoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.platillosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bebidasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel encabezadoPanel;
        private System.Windows.Forms.Label noOrdenLabel;
        private System.Windows.Forms.Label empleadoLabel;
        private System.Windows.Forms.Label tipoServicioLabel;
        private System.Windows.Forms.Label noMesaLabel;
        private System.Windows.Forms.Label fechaLabel;
        private System.Windows.Forms.Label horaLabel;
        private System.Windows.Forms.ComboBox tipoServicioComboBox;
        private System.Windows.Forms.ComboBox noMesaComboBox;
        private System.Windows.Forms.CheckBox platilloCheckBox;
        private System.Windows.Forms.CheckBox postreCheckBox;
        private System.Windows.Forms.CheckBox bebidaCheckBox;
        private System.Windows.Forms.Label agregarLabel;
        private System.Windows.Forms.RichTextBox comentariosRichTextBox;
        private System.Windows.Forms.Label comentariosLabel;
        private System.Windows.Forms.Label horaOrdenLabel;
        private System.Windows.Forms.Label fechaOrdenLabel;
        private System.Windows.Forms.Label empleadoOrdenLabel;
        private buttonSystem cancelarButton;
        private buttonSystem agregarButton;
        private System.Windows.Forms.DataGridView platillosDataGridView;
        private System.Windows.Forms.DataGridView bebidasDataGridView;
        private System.Windows.Forms.DataGridView postresDataGridView;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView ordenDataGridView;
        private System.Windows.Forms.Button actualizarButton;
        private System.Windows.Forms.Label precioElementoLabel;
        private System.Windows.Forms.Label nombreElementoLabel;
        private System.Windows.Forms.Label cantidadElementoLabel;
        private System.Windows.Forms.Label subtotalElementoLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalElementosLabel;
    }
}