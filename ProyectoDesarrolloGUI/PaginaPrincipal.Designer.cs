namespace ProyectoDesarrolloGUI
{
    partial class PaginaPrincipal
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
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnDev = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.MenuVertical.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.MenuVertical.Controls.Add(this.btnReporte);
            this.MenuVertical.Controls.Add(this.btnInventario);
            this.MenuVertical.Controls.Add(this.btnConsultar);
            this.MenuVertical.Controls.Add(this.btnDev);
            this.MenuVertical.Controls.Add(this.btnVenta);
            this.MenuVertical.Controls.Add(this.pictureBox3);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(185, 603);
            this.MenuVertical.TabIndex = 3;
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.pictureBox1);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(185, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1097, 50);
            this.panelTitulo.TabIndex = 4;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.pictureBox2);
            this.panelContenedor.Controls.Add(this.lblFechaHora);
            this.panelContenedor.Controls.Add(this.pictureBox4);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(185, 50);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1097, 553);
            this.panelContenedor.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Font = new System.Drawing.Font("Sans Serif Collection", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.lblFechaHora.Location = new System.Drawing.Point(153, 353);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(111, 49);
            this.lblFechaHora.TabIndex = 2;
            this.lblFechaHora.Text = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoDesarrolloGUI.Properties.Resources.Calendario;
            this.pictureBox2.Location = new System.Drawing.Point(62, 353);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProyectoDesarrolloGUI.Properties.Resources.gorramania_removebg_preview;
            this.pictureBox4.Location = new System.Drawing.Point(382, 112);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(320, 239);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoDesarrolloGUI.Properties.Resources.png_transparent_hamburger_button_computer_icons_menu_menu_rectangle_desktop_wallpaper_button;
            this.pictureBox1.Location = new System.Drawing.Point(6, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Image = global::ProyectoDesarrolloGUI.Properties.Resources.pngtree_report_line_icon_vector_png_image_6682859;
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.Location = new System.Drawing.Point(0, 369);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(185, 32);
            this.btnReporte.TabIndex = 6;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            // 
            // btnInventario
            // 
            this.btnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.Image = global::ProyectoDesarrolloGUI.Properties.Resources._4375241;
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(0, 331);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(185, 32);
            this.btnInventario.TabIndex = 5;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Image = global::ProyectoDesarrolloGUI.Properties.Resources.query_icon_216695;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(0, 255);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(185, 32);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnDev
            // 
            this.btnDev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDev.FlatAppearance.BorderSize = 0;
            this.btnDev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnDev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnDev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDev.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDev.ForeColor = System.Drawing.Color.White;
            this.btnDev.Image = global::ProyectoDesarrolloGUI.Properties.Resources._7132913;
            this.btnDev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDev.Location = new System.Drawing.Point(0, 293);
            this.btnDev.Name = "btnDev";
            this.btnDev.Size = new System.Drawing.Size(185, 32);
            this.btnDev.TabIndex = 3;
            this.btnDev.Text = "  Devolución";
            this.btnDev.UseVisualStyleBackColor = true;
            this.btnDev.Click += new System.EventHandler(this.btnDev_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVenta.FlatAppearance.BorderSize = 0;
            this.btnVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.ForeColor = System.Drawing.Color.White;
            this.btnVenta.Image = global::ProyectoDesarrolloGUI.Properties.Resources.computer_iconchico1;
            this.btnVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenta.Location = new System.Drawing.Point(0, 217);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(185, 32);
            this.btnVenta.TabIndex = 2;
            this.btnVenta.Text = "Venta";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProyectoDesarrolloGUI.Properties.Resources.gorramania_logo_blanco;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(185, 89);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 603);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PaginaPrincipal";
            this.Text = "PaginaPrincipal";
            this.Load += new System.EventHandler(this.PaginaPrincipal_Load);
            this.MenuVertical.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnDev;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}