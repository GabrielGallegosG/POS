
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
            this.cancelarButton = new buttonSystem();
            this.agregarButton = new buttonSystem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.encabezadoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // encabezadoPanel
            // 
            this.encabezadoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(158)))));
            this.encabezadoPanel.Controls.Add(this.noOrdenLabel);
            this.encabezadoPanel.Location = new System.Drawing.Point(1, 0);
            this.encabezadoPanel.Name = "encabezadoPanel";
            this.encabezadoPanel.Size = new System.Drawing.Size(798, 38);
            this.encabezadoPanel.TabIndex = 11;
            // 
            // noOrdenLabel
            // 
            this.noOrdenLabel.AutoSize = true;
            this.noOrdenLabel.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOrdenLabel.ForeColor = System.Drawing.Color.White;
            this.noOrdenLabel.Location = new System.Drawing.Point(11, 7);
            this.noOrdenLabel.Name = "noOrdenLabel";
            this.noOrdenLabel.Size = new System.Drawing.Size(144, 25);
            this.noOrdenLabel.TabIndex = 9;
            this.noOrdenLabel.Text = "NO.ORDEN - ";
            // 
            // empleadoLabel
            // 
            this.empleadoLabel.AutoSize = true;
            this.empleadoLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empleadoLabel.Location = new System.Drawing.Point(28, 62);
            this.empleadoLabel.Name = "empleadoLabel";
            this.empleadoLabel.Size = new System.Drawing.Size(92, 19);
            this.empleadoLabel.TabIndex = 12;
            this.empleadoLabel.Text = "EMPLEADO:";
            // 
            // tipoServicioLabel
            // 
            this.tipoServicioLabel.AutoSize = true;
            this.tipoServicioLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoServicioLabel.Location = new System.Drawing.Point(28, 117);
            this.tipoServicioLabel.Name = "tipoServicioLabel";
            this.tipoServicioLabel.Size = new System.Drawing.Size(139, 19);
            this.tipoServicioLabel.TabIndex = 13;
            this.tipoServicioLabel.Text = "TIPO DE SERVICIO:";
            // 
            // noMesaLabel
            // 
            this.noMesaLabel.AutoSize = true;
            this.noMesaLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noMesaLabel.Location = new System.Drawing.Point(28, 167);
            this.noMesaLabel.Name = "noMesaLabel";
            this.noMesaLabel.Size = new System.Drawing.Size(107, 19);
            this.noMesaLabel.TabIndex = 14;
            this.noMesaLabel.Text = "NO. DE MESA:";
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaLabel.Location = new System.Drawing.Point(590, 62);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(59, 19);
            this.fechaLabel.TabIndex = 15;
            this.fechaLabel.Text = "FECHA:";
            // 
            // horaLabel
            // 
            this.horaLabel.AutoSize = true;
            this.horaLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaLabel.Location = new System.Drawing.Point(594, 117);
            this.horaLabel.Name = "horaLabel";
            this.horaLabel.Size = new System.Drawing.Size(55, 19);
            this.horaLabel.TabIndex = 16;
            this.horaLabel.Text = "HORA:";
            // 
            // tipoServicioComboBox
            // 
            this.tipoServicioComboBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoServicioComboBox.FormattingEnabled = true;
            this.tipoServicioComboBox.Items.AddRange(new object[] {
            "PARA COMER AQUI",
            "PARA LLEVAR"});
            this.tipoServicioComboBox.Location = new System.Drawing.Point(189, 114);
            this.tipoServicioComboBox.Name = "tipoServicioComboBox";
            this.tipoServicioComboBox.Size = new System.Drawing.Size(121, 27);
            this.tipoServicioComboBox.TabIndex = 17;
            // 
            // noMesaComboBox
            // 
            this.noMesaComboBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.noMesaComboBox.Location = new System.Drawing.Point(189, 164);
            this.noMesaComboBox.Name = "noMesaComboBox";
            this.noMesaComboBox.Size = new System.Drawing.Size(121, 27);
            this.noMesaComboBox.TabIndex = 18;
            // 
            // platilloCheckBox
            // 
            this.platilloCheckBox.AutoSize = true;
            this.platilloCheckBox.Font = new System.Drawing.Font("Gadugi", 12F);
            this.platilloCheckBox.Location = new System.Drawing.Point(33, 250);
            this.platilloCheckBox.Name = "platilloCheckBox";
            this.platilloCheckBox.Size = new System.Drawing.Size(95, 23);
            this.platilloCheckBox.TabIndex = 19;
            this.platilloCheckBox.Text = "PLATILLO";
            this.platilloCheckBox.UseVisualStyleBackColor = true;
            // 
            // postreCheckBox
            // 
            this.postreCheckBox.AutoSize = true;
            this.postreCheckBox.Font = new System.Drawing.Font("Gadugi", 12F);
            this.postreCheckBox.Location = new System.Drawing.Point(134, 250);
            this.postreCheckBox.Name = "postreCheckBox";
            this.postreCheckBox.Size = new System.Drawing.Size(84, 23);
            this.postreCheckBox.TabIndex = 20;
            this.postreCheckBox.Text = "POSTRE";
            this.postreCheckBox.UseVisualStyleBackColor = true;
            // 
            // bebidaCheckBox
            // 
            this.bebidaCheckBox.AutoSize = true;
            this.bebidaCheckBox.Font = new System.Drawing.Font("Gadugi", 12F);
            this.bebidaCheckBox.Location = new System.Drawing.Point(231, 250);
            this.bebidaCheckBox.Name = "bebidaCheckBox";
            this.bebidaCheckBox.Size = new System.Drawing.Size(79, 23);
            this.bebidaCheckBox.TabIndex = 21;
            this.bebidaCheckBox.Text = "BEBIDA";
            this.bebidaCheckBox.UseVisualStyleBackColor = true;
            // 
            // agregarLabel
            // 
            this.agregarLabel.AutoSize = true;
            this.agregarLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarLabel.Location = new System.Drawing.Point(28, 218);
            this.agregarLabel.Name = "agregarLabel";
            this.agregarLabel.Size = new System.Drawing.Size(196, 19);
            this.agregarLabel.TabIndex = 22;
            this.agregarLabel.Text = "¿QUÉ DESEAS AGREGAR?";
            // 
            // comentariosRichTextBox
            // 
            this.comentariosRichTextBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comentariosRichTextBox.Location = new System.Drawing.Point(32, 509);
            this.comentariosRichTextBox.Name = "comentariosRichTextBox";
            this.comentariosRichTextBox.Size = new System.Drawing.Size(729, 126);
            this.comentariosRichTextBox.TabIndex = 26;
            this.comentariosRichTextBox.Text = "";
            // 
            // comentariosLabel
            // 
            this.comentariosLabel.AutoSize = true;
            this.comentariosLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comentariosLabel.Location = new System.Drawing.Point(28, 487);
            this.comentariosLabel.Name = "comentariosLabel";
            this.comentariosLabel.Size = new System.Drawing.Size(121, 19);
            this.comentariosLabel.TabIndex = 25;
            this.comentariosLabel.Text = "COMENTARIOS:";
            // 
            // horaOrdenLabel
            // 
            this.horaOrdenLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.horaOrdenLabel.Font = new System.Drawing.Font("Gadugi", 12F);
            this.horaOrdenLabel.Location = new System.Drawing.Point(655, 114);
            this.horaOrdenLabel.Name = "horaOrdenLabel";
            this.horaOrdenLabel.Size = new System.Drawing.Size(100, 23);
            this.horaOrdenLabel.TabIndex = 27;
            // 
            // fechaOrdenLabel
            // 
            this.fechaOrdenLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fechaOrdenLabel.Font = new System.Drawing.Font("Gadugi", 12F);
            this.fechaOrdenLabel.Location = new System.Drawing.Point(655, 58);
            this.fechaOrdenLabel.Name = "fechaOrdenLabel";
            this.fechaOrdenLabel.Size = new System.Drawing.Size(100, 23);
            this.fechaOrdenLabel.TabIndex = 28;
            // 
            // empleadoOrdenLabel
            // 
            this.empleadoOrdenLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empleadoOrdenLabel.Font = new System.Drawing.Font("Gadugi", 12F);
            this.empleadoOrdenLabel.Location = new System.Drawing.Point(189, 58);
            this.empleadoOrdenLabel.Name = "empleadoOrdenLabel";
            this.empleadoOrdenLabel.Size = new System.Drawing.Size(100, 23);
            this.empleadoOrdenLabel.TabIndex = 29;
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
            this.cancelarButton.Location = new System.Drawing.Point(21, 661);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Padding = new System.Windows.Forms.Padding(3);
            this.cancelarButton.Size = new System.Drawing.Size(114, 41);
            this.cancelarButton.TabIndex = 30;
            this.cancelarButton.Text = "CANCELAR";
            this.cancelarButton.UseVisualStyleBackColor = false;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
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
            this.agregarButton.Location = new System.Drawing.Point(637, 661);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Padding = new System.Windows.Forms.Padding(3);
            this.agregarButton.Size = new System.Drawing.Size(124, 41);
            this.agregarButton.TabIndex = 31;
            this.agregarButton.Text = "AGREGAR";
            this.agregarButton.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // agregarOrdenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 749);
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
            this.Name = "agregarOrdenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar orden";
            this.Load += new System.EventHandler(this.agregarOrdenForm_Load);
            this.encabezadoPanel.ResumeLayout(false);
            this.encabezadoPanel.PerformLayout();
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
        private System.Windows.Forms.Timer timer1;
    }
}