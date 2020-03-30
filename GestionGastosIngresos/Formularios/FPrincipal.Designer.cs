namespace GestionGastosIngresos.Formularios
{
    partial class FPrincipal
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
            this.cboxMes = new System.Windows.Forms.ComboBox();
            this.tabla = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataListadoIngresoR = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtGastos = new System.Windows.Forms.TextBox();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataListadoGastoR = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.dataListadoIngresoGasto = new System.Windows.Forms.DataGridView();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.pbQuitar = new System.Windows.Forms.PictureBox();
            this.pcAgregar = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabla.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoIngresoR)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoGastoR)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoIngresoGasto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuitar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcAgregar)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboxMes
            // 
            this.cboxMes.FormattingEnabled = true;
            this.cboxMes.Items.AddRange(new object[] {
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE"});
            this.cboxMes.Location = new System.Drawing.Point(10, 16);
            this.cboxMes.Name = "cboxMes";
            this.cboxMes.Size = new System.Drawing.Size(107, 21);
            this.cboxMes.TabIndex = 0;
            this.cboxMes.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabla
            // 
            this.tabla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabla.Controls.Add(this.tabPage1);
            this.tabla.Controls.Add(this.tabPage2);
            this.tabla.Controls.Add(this.tabPage3);
            this.tabla.Location = new System.Drawing.Point(12, 12);
            this.tabla.Name = "tabla";
            this.tabla.SelectedIndex = 0;
            this.tabla.Size = new System.Drawing.Size(495, 161);
            this.tabla.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataListadoIngresoR);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(487, 135);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingresos";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataListadoIngresoR
            // 
            this.dataListadoIngresoR.AllowUserToAddRows = false;
            this.dataListadoIngresoR.AllowUserToDeleteRows = false;
            this.dataListadoIngresoR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataListadoIngresoR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListadoIngresoR.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataListadoIngresoR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadoIngresoR.Location = new System.Drawing.Point(8, 6);
            this.dataListadoIngresoR.Name = "dataListadoIngresoR";
            this.dataListadoIngresoR.ReadOnly = true;
            this.dataListadoIngresoR.Size = new System.Drawing.Size(473, 123);
            this.dataListadoIngresoR.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtSaldo);
            this.tabPage2.Controls.Add(this.txtGastos);
            this.tabPage2.Controls.Add(this.txtIngreso);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(487, 135);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Saldos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtSaldo
            // 
            this.txtSaldo.BackColor = System.Drawing.Color.White;
            this.txtSaldo.Location = new System.Drawing.Point(146, 84);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(189, 20);
            this.txtSaldo.TabIndex = 5;
            this.txtSaldo.Text = "0";
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGastos
            // 
            this.txtGastos.BackColor = System.Drawing.Color.White;
            this.txtGastos.Location = new System.Drawing.Point(146, 53);
            this.txtGastos.Name = "txtGastos";
            this.txtGastos.ReadOnly = true;
            this.txtGastos.Size = new System.Drawing.Size(189, 20);
            this.txtGastos.TabIndex = 4;
            this.txtGastos.Text = "0";
            this.txtGastos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIngreso
            // 
            this.txtIngreso.BackColor = System.Drawing.Color.White;
            this.txtIngreso.Location = new System.Drawing.Point(146, 23);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.ReadOnly = true;
            this.txtIngreso.Size = new System.Drawing.Size(189, 20);
            this.txtIngreso.TabIndex = 3;
            this.txtIngreso.Text = "0";
            this.txtIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gastos:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresos:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataListadoGastoR);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(487, 135);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Gastos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataListadoGastoR
            // 
            this.dataListadoGastoR.AllowUserToAddRows = false;
            this.dataListadoGastoR.AllowUserToDeleteRows = false;
            this.dataListadoGastoR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataListadoGastoR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListadoGastoR.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataListadoGastoR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadoGastoR.Location = new System.Drawing.Point(8, 6);
            this.dataListadoGastoR.Name = "dataListadoGastoR";
            this.dataListadoGastoR.ReadOnly = true;
            this.dataListadoGastoR.Size = new System.Drawing.Size(470, 123);
            this.dataListadoGastoR.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAño);
            this.groupBox1.Controls.Add(this.cboxMes);
            this.groupBox1.Location = new System.Drawing.Point(17, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 46);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mes de Saldo";
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(124, 16);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(57, 20);
            this.txtAño.TabIndex = 1;
            // 
            // dataListadoIngresoGasto
            // 
            this.dataListadoIngresoGasto.AllowUserToAddRows = false;
            this.dataListadoIngresoGasto.AllowUserToDeleteRows = false;
            this.dataListadoIngresoGasto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataListadoIngresoGasto.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataListadoIngresoGasto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadoIngresoGasto.ContextMenuStrip = this.contextMenuStrip1;
            this.dataListadoIngresoGasto.Location = new System.Drawing.Point(17, 237);
            this.dataListadoIngresoGasto.Name = "dataListadoIngresoGasto";
            this.dataListadoIngresoGasto.ReadOnly = true;
            this.dataListadoIngresoGasto.Size = new System.Drawing.Size(490, 222);
            this.dataListadoIngresoGasto.TabIndex = 0;
            this.dataListadoIngresoGasto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // pbBuscar
            // 
            this.pbBuscar.BackgroundImage = global::GestionGastosIngresos.Properties.Resources.Buscar;
            this.pbBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBuscar.Location = new System.Drawing.Point(215, 194);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(54, 28);
            this.pbBuscar.TabIndex = 7;
            this.pbBuscar.TabStop = false;
            this.pbBuscar.Click += new System.EventHandler(this.pbBuscar_Click);
            // 
            // pbQuitar
            // 
            this.pbQuitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbQuitar.BackgroundImage = global::GestionGastosIngresos.Properties.Resources.Menos;
            this.pbQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbQuitar.Location = new System.Drawing.Point(444, 194);
            this.pbQuitar.Name = "pbQuitar";
            this.pbQuitar.Size = new System.Drawing.Size(50, 28);
            this.pbQuitar.TabIndex = 4;
            this.pbQuitar.TabStop = false;
            this.pbQuitar.Click += new System.EventHandler(this.pbQuitar_Click);
            // 
            // pcAgregar
            // 
            this.pcAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcAgregar.BackgroundImage = global::GestionGastosIngresos.Properties.Resources.agregar1;
            this.pcAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcAgregar.Location = new System.Drawing.Point(384, 193);
            this.pcAgregar.Name = "pcAgregar";
            this.pcAgregar.Size = new System.Drawing.Size(50, 28);
            this.pcAgregar.TabIndex = 3;
            this.pcAgregar.TabStop = false;
            this.pcAgregar.Click += new System.EventHandler(this.pcAgregar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(516, 470);
            this.Controls.Add(this.dataListadoIngresoGasto);
            this.Controls.Add(this.pbBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbQuitar);
            this.Controls.Add(this.pcAgregar);
            this.Controls.Add(this.tabla);
            this.Name = "FPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de gastos";
            this.Load += new System.EventHandler(this.FPrincipal_Load);
            this.tabla.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoIngresoR)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoGastoR)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoIngresoGasto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuitar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcAgregar)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxMes;
        private System.Windows.Forms.TabControl tabla;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pcAgregar;
        private System.Windows.Forms.PictureBox pbQuitar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataListadoIngresoGasto;
        private System.Windows.Forms.DataGridView dataListadoIngresoR;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtGastos;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataListadoGastoR;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
    }
}