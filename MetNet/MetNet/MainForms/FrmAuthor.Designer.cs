namespace MetNet.MainForms
{
    partial class FrmAuthor
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
            this.DgvAutores = new System.Windows.Forms.DataGridView();
            this.TxtCiudad = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ListaLibros = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LblAutor = new System.Windows.Forms.Label();
            this.LibrosE = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvAutores
            // 
            this.DgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAutores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LibrosE});
            this.DgvAutores.Location = new System.Drawing.Point(12, 208);
            this.DgvAutores.Name = "DgvAutores";
            this.DgvAutores.RowHeadersWidth = 62;
            this.DgvAutores.RowTemplate.Height = 28;
            this.DgvAutores.Size = new System.Drawing.Size(776, 230);
            this.DgvAutores.TabIndex = 0;
            this.DgvAutores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAutores_CellContentClick);
            // 
            // TxtCiudad
            // 
            this.TxtCiudad.Location = new System.Drawing.Point(39, 167);
            this.TxtCiudad.Name = "TxtCiudad";
            this.TxtCiudad.Size = new System.Drawing.Size(125, 26);
            this.TxtCiudad.TabIndex = 2;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(39, 35);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(125, 26);
            this.TxtNombre.TabIndex = 3;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(39, 103);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(125, 26);
            this.TxtApellido.TabIndex = 4;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(196, 35);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(154, 26);
            this.TxtCorreo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ciudad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Correo Electronico";
            // 
            // DtpFechaNacimiento
            // 
            this.DtpFechaNacimiento.Location = new System.Drawing.Point(196, 103);
            this.DtpFechaNacimiento.Name = "DtpFechaNacimiento";
            this.DtpFechaNacimiento.Size = new System.Drawing.Size(202, 26);
            this.DtpFechaNacimiento.TabIndex = 11;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(483, 70);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(98, 30);
            this.BtnAgregar.TabIndex = 12;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // ListaLibros
            // 
            this.ListaLibros.Location = new System.Drawing.Point(641, 70);
            this.ListaLibros.Name = "ListaLibros";
            this.ListaLibros.Size = new System.Drawing.Size(130, 30);
            this.ListaLibros.TabIndex = 15;
            this.ListaLibros.Text = "Lista de Libros";
            this.ListaLibros.UseVisualStyleBackColor = true;
            this.ListaLibros.Click += new System.EventHandler(this.ListaLibros_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "ID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // LblAutor
            // 
            this.LblAutor.AutoSize = true;
            this.LblAutor.Location = new System.Drawing.Point(515, 8);
            this.LblAutor.Name = "LblAutor";
            this.LblAutor.Size = new System.Drawing.Size(51, 20);
            this.LblAutor.TabIndex = 17;
            this.LblAutor.Text = "label6";
            // 
            // LibrosE
            // 
            this.LibrosE.HeaderText = "Eliminar";
            this.LibrosE.MinimumWidth = 8;
            this.LibrosE.Name = "LibrosE";
            this.LibrosE.Text = "";
            this.LibrosE.Width = 70;
            // 
            // FrmAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblAutor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ListaLibros);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DtpFechaNacimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtCiudad);
            this.Controls.Add(this.DgvAutores);
            this.Name = "FrmAuthor";
            this.Text = "FrmAuthor";
            this.Load += new System.EventHandler(this.FrmAuthor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAutores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAutores;
        private System.Windows.Forms.TextBox TxtCiudad;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtpFechaNacimiento;
        private System.Windows.Forms.Button BtnAgregar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button ListaLibros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblAutor;
        private System.Windows.Forms.DataGridViewButtonColumn LibrosE;
    }
}