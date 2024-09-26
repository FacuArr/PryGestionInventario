namespace PryGestionInventario
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
            this.panelForms = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnGraficos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.btnAEM = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelForms
            // 
            this.panelForms.BackColor = System.Drawing.Color.BlueViolet;
            this.panelForms.Location = new System.Drawing.Point(219, 0);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(757, 374);
            this.panelForms.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.btnInicio);
            this.panel1.Controls.Add(this.btnGraficos);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnBusqueda);
            this.panel1.Controls.Add(this.btnAEM);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 377);
            this.panel1.TabIndex = 3;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Image = global::PryGestionInventario.Properties.Resources._3643769_building_home_house_main_menu_start_113416;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 142);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(222, 57);
            this.btnInicio.TabIndex = 4;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnGraficos
            // 
            this.btnGraficos.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGraficos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGraficos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet;
            this.btnGraficos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnGraficos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraficos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficos.Image = global::PryGestionInventario.Properties.Resources.list_122348;
            this.btnGraficos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGraficos.Location = new System.Drawing.Point(0, 313);
            this.btnGraficos.Name = "btnGraficos";
            this.btnGraficos.Size = new System.Drawing.Size(222, 57);
            this.btnGraficos.TabIndex = 3;
            this.btnGraficos.Text = "Reportes";
            this.btnGraficos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGraficos.UseVisualStyleBackColor = false;
            this.btnGraficos.Click += new System.EventHandler(this.btnGraficos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Indigo;
            this.pictureBox1.Image = global::PryGestionInventario.Properties.Resources.Inventory_maintenance_25374;
            this.pictureBox1.Location = new System.Drawing.Point(31, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBusqueda.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBusqueda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet;
            this.btnBusqueda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusqueda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqueda.Image = global::PryGestionInventario.Properties.Resources.barcode1_122337;
            this.btnBusqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusqueda.Location = new System.Drawing.Point(0, 256);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(222, 57);
            this.btnBusqueda.TabIndex = 1;
            this.btnBusqueda.Text = "Búsqueda";
            this.btnBusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // btnAEM
            // 
            this.btnAEM.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAEM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAEM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAEM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkViolet;
            this.btnAEM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnAEM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAEM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAEM.Image = global::PryGestionInventario.Properties.Resources.package8_122357;
            this.btnAEM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAEM.Location = new System.Drawing.Point(0, 199);
            this.btnAEM.Name = "btnAEM";
            this.btnAEM.Size = new System.Drawing.Size(222, 57);
            this.btnAEM.TabIndex = 0;
            this.btnAEM.Text = "Agregar - Eliminar - Modificar";
            this.btnAEM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAEM.UseVisualStyleBackColor = false;
            this.btnAEM.Click += new System.EventHandler(this.btnAEM_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(972, 369);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelForms);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Inventario";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelForms;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAEM;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGraficos;
        private System.Windows.Forms.Button btnInicio;
    }
}

