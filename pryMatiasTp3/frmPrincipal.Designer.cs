namespace pryMatiasTp3
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tbl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtIngreseCantidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregarP = new System.Windows.Forms.Button();
            this.txtProfesion = new System.Windows.Forms.TextBox();
            this.txtNombreProfesion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarL = new System.Windows.Forms.Button();
            this.txtNombreLocalidad = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnRenovar = new System.Windows.Forms.Button();
            this.dgvEncuestas = new System.Windows.Forms.DataGridView();
            this.cbLocalidad = new System.Windows.Forms.ComboBox();
            this.cbProfesion = new System.Windows.Forms.ComboBox();
            this.tbl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncuestas)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl
            // 
            this.tbl.Controls.Add(this.tabPage1);
            this.tbl.Controls.Add(this.tabPage3);
            this.tbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl.ItemSize = new System.Drawing.Size(150, 25);
            this.tbl.Location = new System.Drawing.Point(0, 0);
            this.tbl.Name = "tbl";
            this.tbl.SelectedIndex = 0;
            this.tbl.Size = new System.Drawing.Size(668, 392);
            this.tbl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbl.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(660, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbProfesion);
            this.groupBox4.Controls.Add(this.cbLocalidad);
            this.groupBox4.Controls.Add(this.btnRegistrar);
            this.groupBox4.Controls.Add(this.txtIngreseCantidad);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(452, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(177, 264);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Registrar cantidad";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(22, 210);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(88, 27);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtIngreseCantidad
            // 
            this.txtIngreseCantidad.Location = new System.Drawing.Point(22, 173);
            this.txtIngreseCantidad.Name = "txtIngreseCantidad";
            this.txtIngreseCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtIngreseCantidad.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Ingrese cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Profesion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Localidad";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregarP);
            this.groupBox2.Controls.Add(this.txtProfesion);
            this.groupBox2.Controls.Add(this.txtNombreProfesion);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(242, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 264);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Profesion";
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.Location = new System.Drawing.Point(26, 149);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(88, 27);
            this.btnAgregarP.TabIndex = 6;
            this.btnAgregarP.Text = "Agregar";
            this.btnAgregarP.UseVisualStyleBackColor = true;
            this.btnAgregarP.Click += new System.EventHandler(this.btnAgregarP_Click);
            // 
            // txtProfesion
            // 
            this.txtProfesion.Location = new System.Drawing.Point(26, 47);
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.Size = new System.Drawing.Size(100, 20);
            this.txtProfesion.TabIndex = 4;
            // 
            // txtNombreProfesion
            // 
            this.txtNombreProfesion.Location = new System.Drawing.Point(26, 109);
            this.txtNombreProfesion.Name = "txtNombreProfesion";
            this.txtNombreProfesion.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProfesion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id Profesion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre Profesion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregarL);
            this.groupBox1.Controls.Add(this.txtNombreLocalidad);
            this.groupBox1.Controls.Add(this.txtLocalidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 264);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Localidad";
            // 
            // btnAgregarL
            // 
            this.btnAgregarL.Location = new System.Drawing.Point(25, 149);
            this.btnAgregarL.Name = "btnAgregarL";
            this.btnAgregarL.Size = new System.Drawing.Size(88, 27);
            this.btnAgregarL.TabIndex = 4;
            this.btnAgregarL.Text = "Agregar";
            this.btnAgregarL.UseVisualStyleBackColor = true;
            this.btnAgregarL.Click += new System.EventHandler(this.btnAgregarL_Click);
            // 
            // txtNombreLocalidad
            // 
            this.txtNombreLocalidad.Location = new System.Drawing.Point(25, 109);
            this.txtNombreLocalidad.Name = "txtNombreLocalidad";
            this.txtNombreLocalidad.Size = new System.Drawing.Size(100, 20);
            this.txtNombreLocalidad.TabIndex = 3;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(25, 47);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(100, 20);
            this.txtLocalidad.TabIndex = 2;
            this.txtLocalidad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Localidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Localidad";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnRenovar);
            this.tabPage3.Controls.Add(this.dgvEncuestas);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(660, 359);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Resulttados";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnRenovar
            // 
            this.btnRenovar.Location = new System.Drawing.Point(536, 317);
            this.btnRenovar.Name = "btnRenovar";
            this.btnRenovar.Size = new System.Drawing.Size(84, 21);
            this.btnRenovar.TabIndex = 2;
            this.btnRenovar.Text = "Renovar";
            this.btnRenovar.UseVisualStyleBackColor = true;
            this.btnRenovar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvEncuestas
            // 
            this.dgvEncuestas.AllowUserToAddRows = false;
            this.dgvEncuestas.AllowUserToDeleteRows = false;
            this.dgvEncuestas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEncuestas.Location = new System.Drawing.Point(42, 30);
            this.dgvEncuestas.Name = "dgvEncuestas";
            this.dgvEncuestas.ReadOnly = true;
            this.dgvEncuestas.Size = new System.Drawing.Size(578, 281);
            this.dgvEncuestas.TabIndex = 1;
            // 
            // cbLocalidad
            // 
            this.cbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocalidad.FormattingEnabled = true;
            this.cbLocalidad.Location = new System.Drawing.Point(22, 47);
            this.cbLocalidad.Name = "cbLocalidad";
            this.cbLocalidad.Size = new System.Drawing.Size(100, 21);
            this.cbLocalidad.TabIndex = 21;
            // 
            // cbProfesion
            // 
            this.cbProfesion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfesion.FormattingEnabled = true;
            this.cbProfesion.Location = new System.Drawing.Point(22, 108);
            this.cbProfesion.Name = "cbProfesion";
            this.cbProfesion.Size = new System.Drawing.Size(100, 21);
            this.cbProfesion.TabIndex = 22;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 392);
            this.Controls.Add(this.tbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Encuesta";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tbl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncuestas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAgregarP;
        private System.Windows.Forms.TextBox txtProfesion;
        private System.Windows.Forms.TextBox txtNombreProfesion;
        private System.Windows.Forms.Button btnAgregarL;
        private System.Windows.Forms.TextBox txtNombreLocalidad;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtIngreseCantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgvEncuestas;
        private System.Windows.Forms.Button btnRenovar;
        private System.Windows.Forms.ComboBox cbProfesion;
        private System.Windows.Forms.ComboBox cbLocalidad;
    }
}

