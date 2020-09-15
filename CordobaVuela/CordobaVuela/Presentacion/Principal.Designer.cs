namespace CordobaVuela.Presentacion
{
    public partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.lblCordovaVuela = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pasajerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aeropuertosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarAeropuertoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opRegAeropuerto = new System.Windows.Forms.ToolStripMenuItem();
            this.tarifasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imlNoticias = new System.Windows.Forms.ImageList(this.components);
            this.tmrFotos = new System.Windows.Forms.Timer(this.components);
            this.pbxNoticias = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.tmfFecha = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNoticias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCordovaVuela
            // 
            this.lblCordovaVuela.AutoSize = true;
            this.lblCordovaVuela.Font = new System.Drawing.Font("Eras Bold ITC", 18F);
            this.lblCordovaVuela.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblCordovaVuela.Location = new System.Drawing.Point(597, 24);
            this.lblCordovaVuela.Name = "lblCordovaVuela";
            this.lblCordovaVuela.Size = new System.Drawing.Size(187, 28);
            this.lblCordovaVuela.TabIndex = 7;
            this.lblCordovaVuela.Text = "CordobaVuela";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.Location = new System.Drawing.Point(29, 435);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(110, 13);
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.Text = "Usuario Logueado";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(688, 420);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 29);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            this.lblVersion.Location = new System.Drawing.Point(603, 52);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(54, 9);
            this.lblVersion.TabIndex = 13;
            this.lblVersion.Text = "Version 1.0";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Location = new System.Drawing.Point(573, 420);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(84, 29);
            this.btnCerrarSesion.TabIndex = 14;
            this.btnCerrarSesion.Text = "Cerrar Sesión\r\n";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // pasajerosToolStripMenuItem
            // 
            this.pasajerosToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pasajerosToolStripMenuItem.Name = "pasajerosToolStripMenuItem";
            this.pasajerosToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.pasajerosToolStripMenuItem.Text = "Pasajeros";
            this.pasajerosToolStripMenuItem.Click += new System.EventHandler(this.pasajerosToolStripMenuItem_Click);
            // 
            // vuelosToolStripMenuItem
            // 
            this.vuelosToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.vuelosToolStripMenuItem.Name = "vuelosToolStripMenuItem";
            this.vuelosToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.vuelosToolStripMenuItem.Text = "Mis Vuelos";
            this.vuelosToolStripMenuItem.Click += new System.EventHandler(this.vuelosToolStripMenuItem_Click);
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.reservasToolStripMenuItem.Text = "Mis Reservas";
            this.reservasToolStripMenuItem.Click += new System.EventHandler(this.reservasToolStripMenuItem_Click);
            // 
            // soporteToolStripMenuItem
            // 
            this.soporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avionesToolStripMenuItem,
            this.clasesToolStripMenuItem,
            this.paisesToolStripMenuItem,
            this.aeropuertosToolStripMenuItem1,
            this.tarifasToolStripMenuItem});
            this.soporteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            this.soporteToolStripMenuItem.Size = new System.Drawing.Size(160, 20);
            this.soporteToolStripMenuItem.Text = "Administracion de Soporte";
            this.soporteToolStripMenuItem.Click += new System.EventHandler(this.soporteToolStripMenuItem_Click);
            // 
            // avionesToolStripMenuItem
            // 
            this.avionesToolStripMenuItem.Name = "avionesToolStripMenuItem";
            this.avionesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.avionesToolStripMenuItem.Text = "Aviones";
            // 
            // clasesToolStripMenuItem
            // 
            this.clasesToolStripMenuItem.Name = "clasesToolStripMenuItem";
            this.clasesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.clasesToolStripMenuItem.Text = "Clases";
            // 
            // paisesToolStripMenuItem
            // 
            this.paisesToolStripMenuItem.Name = "paisesToolStripMenuItem";
            this.paisesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.paisesToolStripMenuItem.Text = "Paises";
            // 
            // aeropuertosToolStripMenuItem1
            // 
            this.aeropuertosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarAeropuertoToolStripMenuItem,
            this.opRegAeropuerto});
            this.aeropuertosToolStripMenuItem1.Name = "aeropuertosToolStripMenuItem1";
            this.aeropuertosToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.aeropuertosToolStripMenuItem1.Text = "Aeropuertos";
            // 
            // consultarAeropuertoToolStripMenuItem
            // 
            this.consultarAeropuertoToolStripMenuItem.Name = "consultarAeropuertoToolStripMenuItem";
            this.consultarAeropuertoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.consultarAeropuertoToolStripMenuItem.Text = "Consultar Aeropuerto";
            this.consultarAeropuertoToolStripMenuItem.Click += new System.EventHandler(this.consultarAeropuertoToolStripMenuItem_Click);
            // 
            // opRegAeropuerto
            // 
            this.opRegAeropuerto.Name = "opRegAeropuerto";
            this.opRegAeropuerto.Size = new System.Drawing.Size(188, 22);
            this.opRegAeropuerto.Text = "Registrar Aeropuerto";
            this.opRegAeropuerto.Click += new System.EventHandler(this.registrarAeropuertoToolStripMenuItem_Click);
            // 
            // tarifasToolStripMenuItem
            // 
            this.tarifasToolStripMenuItem.Name = "tarifasToolStripMenuItem";
            this.tarifasToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.tarifasToolStripMenuItem.Text = "Tarifas";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasajerosToolStripMenuItem,
            this.vuelosToolStripMenuItem,
            this.reservasToolStripMenuItem,
            this.soporteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.menuStrip1.FontChanged += new System.EventHandler(this.Principal_Load);
            // 
            // imlNoticias
            // 
            this.imlNoticias.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlNoticias.ImageStream")));
            this.imlNoticias.TransparentColor = System.Drawing.Color.Transparent;
            this.imlNoticias.Images.SetKeyName(0, "Foto.jpg");
            this.imlNoticias.Images.SetKeyName(1, "avioncovid.jpg");
            this.imlNoticias.Images.SetKeyName(2, "avion3.jpg");
            // 
            // tmrFotos
            // 
            this.tmrFotos.Enabled = true;
            this.tmrFotos.Interval = 5000;
            this.tmrFotos.Tick += new System.EventHandler(this.tmrFotos_Tick);
            // 
            // pbxNoticias
            // 
            this.pbxNoticias.Image = global::CordobaVuela.Properties.Resources.covid_avion1;
            this.pbxNoticias.Location = new System.Drawing.Point(32, 118);
            this.pbxNoticias.Name = "pbxNoticias";
            this.pbxNoticias.Size = new System.Drawing.Size(232, 236);
            this.pbxNoticias.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxNoticias.TabIndex = 15;
            this.pbxNoticias.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblFecha.Location = new System.Drawing.Point(29, 52);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(72, 14);
            this.lblFecha.TabIndex = 16;
            this.lblFecha.Text = "Fecha y Hora";
            // 
            // tmfFecha
            // 
            this.tmfFecha.Enabled = true;
            this.tmfFecha.Tick += new System.EventHandler(this.tmfFecha_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(393, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "AVISO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(294, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Debido a las razones de público conocimiento desde ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(282, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "nuestra agencia lamentamos informar que todos los vuelos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(326, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "estan suspendidos hasta nuevo aviso.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(282, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Desde ya muchas gracias. ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(420, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Personal de CordobaVuela";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.pbxNoticias);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblCordovaVuela);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNoticias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCordovaVuela;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem pasajerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vuelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aeropuertosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarAeropuertoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opRegAeropuerto;
        private System.Windows.Forms.ToolStripMenuItem tarifasToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ImageList imlNoticias;
        private System.Windows.Forms.Timer tmrFotos;
        private System.Windows.Forms.PictureBox pbxNoticias;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer tmfFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}