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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvTienda = new System.Windows.Forms.DataGridView();
            this.pbxTienda = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lbliltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblDes = new System.Windows.Forms.Label();
            this.lblNada = new System.Windows.Forms.Label();
            this.lblNmbr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTienda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTienda
            // 
            this.dgvTienda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTienda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTienda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvTienda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTienda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTienda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTienda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTienda.ColumnHeadersHeight = 30;
            this.dgvTienda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTienda.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTienda.EnableHeadersVisualStyles = false;
            this.dgvTienda.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvTienda.Location = new System.Drawing.Point(31, 61);
            this.dgvTienda.MultiSelect = false;
            this.dgvTienda.Name = "dgvTienda";
            this.dgvTienda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTienda.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTienda.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTienda.Size = new System.Drawing.Size(511, 238);
            this.dgvTienda.TabIndex = 0;
            this.dgvTienda.SelectionChanged += new System.EventHandler(this.dgvTienda_SelectionChanged);
            // 
            // pbxTienda
            // 
            this.pbxTienda.Location = new System.Drawing.Point(31, 305);
            this.pbxTienda.Name = "pbxTienda";
            this.pbxTienda.Size = new System.Drawing.Size(282, 250);
            this.pbxTienda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxTienda.TabIndex = 1;
            this.pbxTienda.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(321, 492);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(63, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(401, 492);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(63, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(479, 492);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(63, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lbliltro
            // 
            this.lbliltro.AutoSize = true;
            this.lbliltro.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliltro.ForeColor = System.Drawing.Color.White;
            this.lbliltro.Location = new System.Drawing.Point(319, 535);
            this.lbliltro.Name = "lbliltro";
            this.lbliltro.Size = new System.Drawing.Size(60, 19);
            this.lbliltro.TabIndex = 5;
            this.lbliltro.Text = "Buscar:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(384, 535);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(158, 20);
            this.txtFiltro.TabIndex = 6;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.ForeColor = System.Drawing.Color.White;
            this.lblDes.Location = new System.Drawing.Point(318, 432);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(50, 18);
            this.lblDes.TabIndex = 9;
            this.lblDes.Text = "label1";
            this.lblDes.Click += new System.EventHandler(this.lblPrueba_Click);
            // 
            // lblNada
            // 
            this.lblNada.AutoSize = true;
            this.lblNada.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNada.ForeColor = System.Drawing.Color.White;
            this.lblNada.Location = new System.Drawing.Point(317, 413);
            this.lblNada.Name = "lblNada";
            this.lblNada.Size = new System.Drawing.Size(118, 19);
            this.lblNada.TabIndex = 10;
            this.lblNada.Text = "DESCRIPCION:";
            // 
            // lblNmbr
            // 
            this.lblNmbr.AutoSize = true;
            this.lblNmbr.Font = new System.Drawing.Font("Atakana Sarif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNmbr.ForeColor = System.Drawing.Color.White;
            this.lblNmbr.Location = new System.Drawing.Point(314, 341);
            this.lblNmbr.Name = "lblNmbr";
            this.lblNmbr.Size = new System.Drawing.Size(105, 37);
            this.lblNmbr.TabIndex = 11;
            this.lblNmbr.Text = "lblNmbr";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Multicolore Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(163, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "CATALOGO CANE:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(581, 567);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNmbr);
            this.Controls.Add(this.lblNada);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lbliltro);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbxTienda);
            this.Controls.Add(this.dgvTienda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTienda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTienda;
        private System.Windows.Forms.PictureBox pbxTienda;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lbliltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label lblNada;
        private System.Windows.Forms.Label lblNmbr;
        private System.Windows.Forms.Label label1;
    }
}

