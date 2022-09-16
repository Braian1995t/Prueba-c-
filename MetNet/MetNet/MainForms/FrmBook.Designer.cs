namespace MetNet.MainForms
{
    partial class FrmBook
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
            this.DgvLibros = new System.Windows.Forms.DataGridView();
            this.BlbtId = new System.Windows.Forms.Label();
            this.BlbTitulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtGenero = new System.Windows.Forms.TextBox();
            this.TxtNumeroP = new System.Windows.Forms.TextBox();
            this.TxtAño = new System.Windows.Forms.TextBox();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.AgregarLibros = new System.Windows.Forms.Button();
            this.BtEliminar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtSelectall = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvLibros
            // 
            this.DgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.DgvLibros.Location = new System.Drawing.Point(12, 153);
            this.DgvLibros.Name = "DgvLibros";
            this.DgvLibros.RowHeadersWidth = 62;
            this.DgvLibros.RowTemplate.Height = 28;
            this.DgvLibros.Size = new System.Drawing.Size(760, 285);
            this.DgvLibros.TabIndex = 0;
            this.DgvLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLibros_CellContentClick);
            // 
            // BlbtId
            // 
            this.BlbtId.AutoSize = true;
            this.BlbtId.Location = new System.Drawing.Point(66, 18);
            this.BlbtId.Name = "BlbtId";
            this.BlbtId.Size = new System.Drawing.Size(23, 20);
            this.BlbtId.TabIndex = 1;
            this.BlbtId.Text = "Id";
            // 
            // BlbTitulo
            // 
            this.BlbTitulo.AutoSize = true;
            this.BlbTitulo.Location = new System.Drawing.Point(173, 18);
            this.BlbTitulo.Name = "BlbTitulo";
            this.BlbTitulo.Size = new System.Drawing.Size(47, 20);
            this.BlbTitulo.TabIndex = 2;
            this.BlbTitulo.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Año";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Genero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Numero de paginas";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(26, 43);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 26);
            this.TxtId.TabIndex = 6;
            // 
            // TxtGenero
            // 
            this.TxtGenero.Location = new System.Drawing.Point(382, 44);
            this.TxtGenero.Name = "TxtGenero";
            this.TxtGenero.Size = new System.Drawing.Size(100, 26);
            this.TxtGenero.TabIndex = 7;
            // 
            // TxtNumeroP
            // 
            this.TxtNumeroP.Location = new System.Drawing.Point(507, 46);
            this.TxtNumeroP.Name = "TxtNumeroP";
            this.TxtNumeroP.Size = new System.Drawing.Size(100, 26);
            this.TxtNumeroP.TabIndex = 8;
            // 
            // TxtAño
            // 
            this.TxtAño.Location = new System.Drawing.Point(262, 43);
            this.TxtAño.Name = "TxtAño";
            this.TxtAño.Size = new System.Drawing.Size(100, 26);
            this.TxtAño.TabIndex = 9;
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Location = new System.Drawing.Point(141, 43);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(100, 26);
            this.TxtTitulo.TabIndex = 10;
            // 
            // AgregarLibros
            // 
            this.AgregarLibros.Location = new System.Drawing.Point(676, 41);
            this.AgregarLibros.Name = "AgregarLibros";
            this.AgregarLibros.Size = new System.Drawing.Size(84, 36);
            this.AgregarLibros.TabIndex = 11;
            this.AgregarLibros.Text = "Agregar";
            this.AgregarLibros.UseVisualStyleBackColor = true;
            this.AgregarLibros.Click += new System.EventHandler(this.AgregarLibros_Click);
            // 
            // BtEliminar
            // 
            this.BtEliminar.Location = new System.Drawing.Point(676, 94);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Size = new System.Drawing.Size(90, 38);
            this.BtEliminar.TabIndex = 12;
            this.BtEliminar.Text = "Eliminar";
            this.BtEliminar.UseVisualStyleBackColor = true;
            this.BtEliminar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 8;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 70;
            // 
            // BtSelectall
            // 
            this.BtSelectall.Location = new System.Drawing.Point(317, 94);
            this.BtSelectall.Name = "BtSelectall";
            this.BtSelectall.Size = new System.Drawing.Size(152, 38);
            this.BtSelectall.TabIndex = 13;
            this.BtSelectall.Text = "Seleccionar todo";
            this.BtSelectall.UseVisualStyleBackColor = true;
            this.BtSelectall.Click += new System.EventHandler(this.BtSelectall_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 38);
            this.button1.TabIndex = 14;
            this.button1.Text = "Quitar Seleccion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // FrmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtSelectall);
            this.Controls.Add(this.BtEliminar);
            this.Controls.Add(this.AgregarLibros);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.TxtAño);
            this.Controls.Add(this.TxtNumeroP);
            this.Controls.Add(this.TxtGenero);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BlbTitulo);
            this.Controls.Add(this.BlbtId);
            this.Controls.Add(this.DgvLibros);
            this.Name = "FrmBook";
            this.Text = "FrmBook";
            this.Load += new System.EventHandler(this.FrmBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvLibros;
        private System.Windows.Forms.Label BlbtId;
        private System.Windows.Forms.Label BlbTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtGenero;
        private System.Windows.Forms.TextBox TxtNumeroP;
        private System.Windows.Forms.TextBox TxtAño;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.Button AgregarLibros;
        private System.Windows.Forms.Button BtEliminar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Button BtSelectall;
        private System.Windows.Forms.Button button1;
    }
}