namespace CordobaVuela.Presentacion
{
    partial class ConsultarAeropuerto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarAeropuerto));
            this.lblNombreAeropuerto = new System.Windows.Forms.Label();
            this.chkOrdenado = new System.Windows.Forms.CheckBox();
            this.txtNombreAeropuerto = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvConsultarAeropuerto = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarAeropuerto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreAeropuerto
            // 
            this.lblNombreAeropuerto.AutoSize = true;
            this.lblNombreAeropuerto.Location = new System.Drawing.Point(26, 37);
            this.lblNombreAeropuerto.Name = "lblNombreAeropuerto";
            this.lblNombreAeropuerto.Size = new System.Drawing.Size(116, 13);
            this.lblNombreAeropuerto.TabIndex = 0;
            this.lblNombreAeropuerto.Text = "Nombre del Aeropuerto";
            // 
            // chkOrdenado
            // 
            this.chkOrdenado.AutoSize = true;
            this.chkOrdenado.Location = new System.Drawing.Point(148, 60);
            this.chkOrdenado.Name = "chkOrdenado";
            this.chkOrdenado.Size = new System.Drawing.Size(155, 17);
            this.chkOrdenado.TabIndex = 1;
            this.chkOrdenado.Text = "Mostrar en orden alfabetico";
            this.chkOrdenado.UseVisualStyleBackColor = true;
            // 
            // txtNombreAeropuerto
            // 
            this.txtNombreAeropuerto.Location = new System.Drawing.Point(148, 34);
            this.txtNombreAeropuerto.Name = "txtNombreAeropuerto";
            this.txtNombreAeropuerto.Size = new System.Drawing.Size(206, 20);
            this.txtNombreAeropuerto.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(397, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvConsultarAeropuerto
            // 
            this.dgvConsultarAeropuerto.AllowUserToAddRows = false;
            this.dgvConsultarAeropuerto.AllowUserToDeleteRows = false;
            this.dgvConsultarAeropuerto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsultarAeropuerto.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvConsultarAeropuerto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvConsultarAeropuerto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultarAeropuerto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultarAeropuerto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarAeropuerto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colNombreCiudad,
            this.colId,
            this.colIdCiudad});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsultarAeropuerto.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsultarAeropuerto.Location = new System.Drawing.Point(74, 116);
            this.dgvConsultarAeropuerto.Name = "dgvConsultarAeropuerto";
            this.dgvConsultarAeropuerto.ReadOnly = true;
            this.dgvConsultarAeropuerto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultarAeropuerto.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgvConsultarAeropuerto.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvConsultarAeropuerto.Size = new System.Drawing.Size(398, 150);
            this.dgvConsultarAeropuerto.TabIndex = 4;
            this.dgvConsultarAeropuerto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultarAeropuerto_CellContentClick);
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colNombreCiudad
            // 
            this.colNombreCiudad.HeaderText = "Ciudad";
            this.colNombreCiudad.Name = "colNombreCiudad";
            this.colNombreCiudad.ReadOnly = true;
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colIdCiudad
            // 
            this.colIdCiudad.HeaderText = "ID Ciudad";
            this.colIdCiudad.Name = "colIdCiudad";
            this.colIdCiudad.ReadOnly = true;
            this.colIdCiudad.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(397, 355);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(279, 355);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ConsultarAeropuerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(548, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvConsultarAeropuerto);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNombreAeropuerto);
            this.Controls.Add(this.chkOrdenado);
            this.Controls.Add(this.lblNombreAeropuerto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarAeropuerto";
            this.Text = "Consultar Aeropuerto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarAeropuerto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreAeropuerto;
        private System.Windows.Forms.CheckBox chkOrdenado;
        private System.Windows.Forms.TextBox txtNombreAeropuerto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvConsultarAeropuerto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdCiudad;
    }
}