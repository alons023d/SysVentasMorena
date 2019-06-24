namespace SistemaVentas.views
{
    partial class frmFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactura));
            this.label6 = new System.Windows.Forms.Label();
            this.textNomCli = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridBusqueda = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdmorenaDataSet2 = new SistemaVentas.bdmorenaDataSet2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelBuscarCliente = new System.Windows.Forms.Panel();
            this.dataGridCliente = new System.Windows.Forms.DataGridView();
            this.cli01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col02 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL03 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col05 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col04 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col06 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnMosrarNew = new System.Windows.Forms.Button();
            this.btnRegisCliente = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textApeCli = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textDNICli = new System.Windows.Forms.TextBox();
            this.textFonoCli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textDirecCli = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBuscarProduc02 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnBuscartProd = new System.Windows.Forms.Button();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.productoTableAdapter = new SistemaVentas.bdmorenaDataSet2TableAdapters.ProductoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdmorenaDataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelBuscarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Nombre";
            // 
            // textNomCli
            // 
            this.textNomCli.Location = new System.Drawing.Point(36, 50);
            this.textNomCli.Margin = new System.Windows.Forms.Padding(4);
            this.textNomCli.Multiline = true;
            this.textNomCli.Name = "textNomCli";
            this.textNomCli.Size = new System.Drawing.Size(202, 33);
            this.textNomCli.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGray;
            this.groupBox3.Location = new System.Drawing.Point(738, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(600, 352);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de Factura";
            // 
            // dataGridBusqueda
            // 
            this.dataGridBusqueda.AllowUserToAddRows = false;
            this.dataGridBusqueda.AllowUserToDeleteRows = false;
            this.dataGridBusqueda.AllowUserToOrderColumns = true;
            this.dataGridBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridBusqueda.Location = new System.Drawing.Point(8, 82);
            this.dataGridBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridBusqueda.Name = "dataGridBusqueda";
            this.dataGridBusqueda.ReadOnly = true;
            this.dataGridBusqueda.Size = new System.Drawing.Size(656, 248);
            this.dataGridBusqueda.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 83;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Marca";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 76;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 78;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Stock";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 72;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "Talla";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 69;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column6.Frozen = true;
            this.Column6.HeaderText = "Categoria";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 101;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.bdmorenaDataSet2;
            // 
            // bdmorenaDataSet2
            // 
            this.bdmorenaDataSet2.DataSetName = "bdmorenaDataSet2";
            this.bdmorenaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelBuscarCliente);
            this.groupBox1.Controls.Add(this.btnRegisCliente);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textApeCli);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textDNICli);
            this.groupBox1.Controls.Add(this.textFonoCli);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textDirecCli);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textNomCli);
            this.groupBox1.Location = new System.Drawing.Point(22, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(688, 214);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Cliente";
            // 
            // panelBuscarCliente
            // 
            this.panelBuscarCliente.Controls.Add(this.dataGridCliente);
            this.panelBuscarCliente.Controls.Add(this.txtCliente);
            this.panelBuscarCliente.Controls.Add(this.pictureBox1);
            this.panelBuscarCliente.Controls.Add(this.btnBuscarCliente);
            this.panelBuscarCliente.Controls.Add(this.btnMosrarNew);
            this.panelBuscarCliente.Location = new System.Drawing.Point(9, 22);
            this.panelBuscarCliente.Name = "panelBuscarCliente";
            this.panelBuscarCliente.Size = new System.Drawing.Size(679, 185);
            this.panelBuscarCliente.TabIndex = 26;
            // 
            // dataGridCliente
            // 
            this.dataGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cli01,
            this.col02,
            this.COL03,
            this.col05,
            this.col04,
            this.col06});
            this.dataGridCliente.Location = new System.Drawing.Point(4, 68);
            this.dataGridCliente.Name = "dataGridCliente";
            this.dataGridCliente.Size = new System.Drawing.Size(651, 105);
            this.dataGridCliente.TabIndex = 41;
            // 
            // cli01
            // 
            this.cli01.HeaderText = "Codigo";
            this.cli01.Name = "cli01";
            // 
            // col02
            // 
            this.col02.HeaderText = "DNI";
            this.col02.Name = "col02";
            // 
            // COL03
            // 
            this.COL03.HeaderText = "Nombre";
            this.COL03.Name = "COL03";
            // 
            // col05
            // 
            this.col05.HeaderText = "Apellido";
            this.col05.Name = "col05";
            // 
            // col04
            // 
            this.col04.HeaderText = "Direccion";
            this.col04.Name = "col04";
            // 
            // col06
            // 
            this.col06.HeaderText = "Telefono";
            this.col06.Name = "col06";
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(49, 19);
            this.txtCliente.Multiline = true;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(346, 33);
            this.txtCliente.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Location = new System.Drawing.Point(436, 19);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(104, 33);
            this.btnBuscarCliente.TabIndex = 38;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnMosrarNew
            // 
            this.btnMosrarNew.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMosrarNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMosrarNew.Location = new System.Drawing.Point(560, 19);
            this.btnMosrarNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnMosrarNew.Name = "btnMosrarNew";
            this.btnMosrarNew.Size = new System.Drawing.Size(95, 33);
            this.btnMosrarNew.TabIndex = 37;
            this.btnMosrarNew.Text = "Nuevo";
            this.btnMosrarNew.UseVisualStyleBackColor = true;
            this.btnMosrarNew.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRegisCliente
            // 
            this.btnRegisCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegisCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisCliente.Location = new System.Drawing.Point(321, 165);
            this.btnRegisCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegisCliente.Name = "btnRegisCliente";
            this.btnRegisCliente.Size = new System.Drawing.Size(95, 33);
            this.btnRegisCliente.TabIndex = 37;
            this.btnRegisCliente.Text = "Agregar";
            this.btnRegisCliente.UseVisualStyleBackColor = true;
            this.btnRegisCliente.Click += new System.EventHandler(this.btnRegisCliente_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 87);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Apellido";
            // 
            // textApeCli
            // 
            this.textApeCli.Location = new System.Drawing.Point(36, 108);
            this.textApeCli.Margin = new System.Windows.Forms.Padding(4);
            this.textApeCli.Multiline = true;
            this.textApeCli.Name = "textApeCli";
            this.textApeCli.Size = new System.Drawing.Size(202, 33);
            this.textApeCli.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(274, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "DNI";
            // 
            // textDNICli
            // 
            this.textDNICli.Location = new System.Drawing.Point(277, 50);
            this.textDNICli.Margin = new System.Windows.Forms.Padding(4);
            this.textDNICli.Multiline = true;
            this.textDNICli.Name = "textDNICli";
            this.textDNICli.Size = new System.Drawing.Size(202, 33);
            this.textDNICli.TabIndex = 22;
            // 
            // textFonoCli
            // 
            this.textFonoCli.Location = new System.Drawing.Point(36, 165);
            this.textFonoCli.Margin = new System.Windows.Forms.Padding(4);
            this.textFonoCli.Multiline = true;
            this.textFonoCli.Name = "textFonoCli";
            this.textFonoCli.Size = new System.Drawing.Size(202, 33);
            this.textFonoCli.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Telefono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Dirección";
            // 
            // textDirecCli
            // 
            this.textDirecCli.Location = new System.Drawing.Point(277, 108);
            this.textDirecCli.Margin = new System.Windows.Forms.Padding(4);
            this.textDirecCli.Multiline = true;
            this.textDirecCli.Name = "textDirecCli";
            this.textDirecCli.Size = new System.Drawing.Size(202, 33);
            this.textDirecCli.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridBusqueda);
            this.groupBox2.Controls.Add(this.txtBuscarProduc02);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.btnBuscartProd);
            this.groupBox2.Controls.Add(this.btnAddProd);
            this.groupBox2.Location = new System.Drawing.Point(22, 249);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(688, 337);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle Produto";
            // 
            // txtBuscarProduc02
            // 
            this.txtBuscarProduc02.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProduc02.Location = new System.Drawing.Point(57, 30);
            this.txtBuscarProduc02.Multiline = true;
            this.txtBuscarProduc02.Name = "txtBuscarProduc02";
            this.txtBuscarProduc02.Size = new System.Drawing.Size(347, 33);
            this.txtBuscarProduc02.TabIndex = 36;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // btnBuscartProd
            // 
            this.btnBuscartProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscartProd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscartProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscartProd.Location = new System.Drawing.Point(445, 30);
            this.btnBuscartProd.Name = "btnBuscartProd";
            this.btnBuscartProd.Size = new System.Drawing.Size(104, 33);
            this.btnBuscartProd.TabIndex = 34;
            this.btnBuscartProd.Text = "Buscar";
            this.btnBuscartProd.UseVisualStyleBackColor = true;
            this.btnBuscartProd.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddProd
            // 
            this.btnAddProd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProd.Location = new System.Drawing.Point(569, 30);
            this.btnAddProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(95, 33);
            this.btnAddProd.TabIndex = 33;
            this.btnAddProd.Text = "Agregar";
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.button1_Click);
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1338, 599);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFactura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdmorenaDataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelBuscarCliente.ResumeLayout(false);
            this.panelBuscarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textNomCli;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridBusqueda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textFonoCli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textDirecCli;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textDNICli;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textApeCli;
        private System.Windows.Forms.TextBox txtBuscarProduc02;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnBuscartProd;
        private bdmorenaDataSet2 bdmorenaDataSet2;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private bdmorenaDataSet2TableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.Panel panelBuscarCliente;
        private System.Windows.Forms.DataGridView dataGridCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnMosrarNew;
        private System.Windows.Forms.Button btnRegisCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli01;
        private System.Windows.Forms.DataGridViewTextBoxColumn col02;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL03;
        private System.Windows.Forms.DataGridViewTextBoxColumn col05;
        private System.Windows.Forms.DataGridViewTextBoxColumn col04;
        private System.Windows.Forms.DataGridViewTextBoxColumn col06;
    }
}