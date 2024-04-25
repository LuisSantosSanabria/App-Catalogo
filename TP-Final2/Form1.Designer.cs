namespace TP_Final2
{
    partial class Form1
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
            this.dgvTienda = new System.Windows.Forms.DataGridView();
            this.pbxTienda = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTienda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTienda
            // 
            this.dgvTienda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTienda.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTienda.Location = new System.Drawing.Point(36, 31);
            this.dgvTienda.MultiSelect = false;
            this.dgvTienda.Name = "dgvTienda";
            this.dgvTienda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTienda.Size = new System.Drawing.Size(515, 238);
            this.dgvTienda.TabIndex = 0;
            this.dgvTienda.SelectionChanged += new System.EventHandler(this.dgvTienda_SelectionChanged);
            // 
            // pbxTienda
            // 
            this.pbxTienda.Location = new System.Drawing.Point(569, 31);
            this.pbxTienda.Name = "pbxTienda";
            this.pbxTienda.Size = new System.Drawing.Size(262, 238);
            this.pbxTienda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxTienda.TabIndex = 1;
            this.pbxTienda.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(36, 275);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 303);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbxTienda);
            this.Controls.Add(this.dgvTienda);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTienda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTienda;
        private System.Windows.Forms.PictureBox pbxTienda;
        private System.Windows.Forms.Button btnAgregar;
    }
}

