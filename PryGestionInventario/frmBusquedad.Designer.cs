namespace PryGestionInventario
{
    partial class frmBusquedad
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvRegistro = new System.Windows.Forms.DataGridView();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optNombre = new System.Windows.Forms.RadioButton();
            this.optCodigo = new System.Windows.Forms.RadioButton();
            this.optCategoria = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(120, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(192, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // dgvRegistro
            // 
            this.dgvRegistro.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistro.Location = new System.Drawing.Point(68, 202);
            this.dgvRegistro.Name = "dgvRegistro";
            this.dgvRegistro.Size = new System.Drawing.Size(644, 263);
            this.dgvRegistro.TabIndex = 6;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Enabled = false;
            this.txtCategoria.Location = new System.Drawing.Point(120, 114);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(192, 20);
            this.txtCategoria.TabIndex = 7;
            this.txtCategoria.TextChanged += new System.EventHandler(this.txtCategoria_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(120, 73);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(192, 20);
            this.txtCodigo.TabIndex = 8;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "CÓDIGO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "CATEGORIA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCategoria);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(230, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 159);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busquedad";
            // 
            // optNombre
            // 
            this.optNombre.AutoSize = true;
            this.optNombre.Location = new System.Drawing.Point(21, 28);
            this.optNombre.Name = "optNombre";
            this.optNombre.Size = new System.Drawing.Size(62, 17);
            this.optNombre.TabIndex = 13;
            this.optNombre.TabStop = true;
            this.optNombre.Text = "Nombre";
            this.optNombre.UseVisualStyleBackColor = true;
            this.optNombre.CheckedChanged += new System.EventHandler(this.optNombre_CheckedChanged);
            // 
            // optCodigo
            // 
            this.optCodigo.AutoSize = true;
            this.optCodigo.Location = new System.Drawing.Point(21, 63);
            this.optCodigo.Name = "optCodigo";
            this.optCodigo.Size = new System.Drawing.Size(58, 17);
            this.optCodigo.TabIndex = 14;
            this.optCodigo.TabStop = true;
            this.optCodigo.Text = "Código";
            this.optCodigo.UseVisualStyleBackColor = true;
            this.optCodigo.CheckedChanged += new System.EventHandler(this.optCodigo_CheckedChanged);
            // 
            // optCategoria
            // 
            this.optCategoria.AutoSize = true;
            this.optCategoria.Location = new System.Drawing.Point(21, 98);
            this.optCategoria.Name = "optCategoria";
            this.optCategoria.Size = new System.Drawing.Size(70, 17);
            this.optCategoria.TabIndex = 15;
            this.optCategoria.TabStop = true;
            this.optCategoria.Text = "Categoria";
            this.optCategoria.UseVisualStyleBackColor = true;
            this.optCategoria.CheckedChanged += new System.EventHandler(this.optCategoria_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optNombre);
            this.groupBox2.Controls.Add(this.optCategoria);
            this.groupBox2.Controls.Add(this.optCodigo);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 141);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccione Tipo de Busquedad";
            // 
            // frmBusquedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(764, 485);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvRegistro);
            this.Name = "frmBusquedad";
            this.Text = "Gestion de Invetario: Busquedad";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvRegistro;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optNombre;
        private System.Windows.Forms.RadioButton optCodigo;
        private System.Windows.Forms.RadioButton optCategoria;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}