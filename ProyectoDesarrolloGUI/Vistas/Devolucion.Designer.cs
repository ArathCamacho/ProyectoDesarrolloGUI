namespace ProyectoDesarrolloGUI
{
    partial class Devolucion
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
            this.txt_IdTicket = new System.Windows.Forms.TextBox();
            this.txt_FechaCompra = new System.Windows.Forms.TextBox();
            this.txt_MetodoPago = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgv_DetallesVenta = new System.Windows.Forms.DataGridView();
            this.ID_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Vendida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Motivo = new System.Windows.Forms.TextBox();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.btn_buscarticket = new System.Windows.Forms.Button();
            this.cmb_TipoDevolucion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DetallesVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_IdTicket
            // 
            this.txt_IdTicket.Location = new System.Drawing.Point(255, 12);
            this.txt_IdTicket.Name = "txt_IdTicket";
            this.txt_IdTicket.Size = new System.Drawing.Size(249, 22);
            this.txt_IdTicket.TabIndex = 30;
            // 
            // txt_FechaCompra
            // 
            this.txt_FechaCompra.Location = new System.Drawing.Point(255, 40);
            this.txt_FechaCompra.Name = "txt_FechaCompra";
            this.txt_FechaCompra.Size = new System.Drawing.Size(249, 22);
            this.txt_FechaCompra.TabIndex = 32;
            // 
            // txt_MetodoPago
            // 
            this.txt_MetodoPago.Location = new System.Drawing.Point(255, 72);
            this.txt_MetodoPago.Name = "txt_MetodoPago";
            this.txt_MetodoPago.Size = new System.Drawing.Size(249, 22);
            this.txt_MetodoPago.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(166, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 39;
            this.label5.Text = "ID Ticket:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(120, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 19);
            this.label6.TabIndex = 41;
            this.label6.Text = "Fecha Compra:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(107, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 19);
            this.label7.TabIndex = 42;
            this.label7.Text = "Método de Pago:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(93, 495);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(204, 49);
            this.btnConfirmar.TabIndex = 48;
            this.btnConfirmar.Text = "Confirmar Devolución";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(336, 495);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(98, 49);
            this.btnLimpiar.TabIndex = 49;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(457, 495);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 49);
            this.btnCancelar.TabIndex = 50;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgv_DetallesVenta
            // 
            this.dgv_DetallesVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DetallesVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Producto,
            this.Descripcion,
            this.Cantidad_Vendida,
            this.Precio_Unitario,
            this.Subtotal});
            this.dgv_DetallesVenta.Location = new System.Drawing.Point(12, 104);
            this.dgv_DetallesVenta.Name = "dgv_DetallesVenta";
            this.dgv_DetallesVenta.RowHeadersWidth = 51;
            this.dgv_DetallesVenta.RowTemplate.Height = 24;
            this.dgv_DetallesVenta.Size = new System.Drawing.Size(675, 294);
            this.dgv_DetallesVenta.TabIndex = 51;
            this.dgv_DetallesVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DetallesVenta_CellClick);
            this.dgv_DetallesVenta.SelectionChanged += new System.EventHandler(this.dgv_DetallesVenta_SelectionChanged);
            // 
            // ID_Producto
            // 
            this.ID_Producto.HeaderText = "ID Producto";
            this.ID_Producto.MinimumWidth = 6;
            this.ID_Producto.Name = "ID_Producto";
            this.ID_Producto.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 125;
            // 
            // Cantidad_Vendida
            // 
            this.Cantidad_Vendida.HeaderText = "Cantidad Vendida";
            this.Cantidad_Vendida.MinimumWidth = 6;
            this.Cantidad_Vendida.Name = "Cantidad_Vendida";
            this.Cantidad_Vendida.Width = 125;
            // 
            // Precio_Unitario
            // 
            this.Precio_Unitario.HeaderText = "Precio Unitario";
            this.Precio_Unitario.MinimumWidth = 6;
            this.Precio_Unitario.Name = "Precio_Unitario";
            this.Precio_Unitario.Width = 125;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 6;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 19);
            this.label1.TabIndex = 57;
            this.label1.Text = "Tipo de devolución:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 19);
            this.label2.TabIndex = 56;
            this.label2.Text = "Motivo de devolución:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 19);
            this.label3.TabIndex = 55;
            this.label3.Text = "Cantidad a devolver:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_Motivo
            // 
            this.txt_Motivo.Location = new System.Drawing.Point(255, 432);
            this.txt_Motivo.Name = "txt_Motivo";
            this.txt_Motivo.Size = new System.Drawing.Size(249, 22);
            this.txt_Motivo.TabIndex = 53;
            this.txt_Motivo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(255, 404);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(249, 22);
            this.txt_Cantidad.TabIndex = 52;
            this.txt_Cantidad.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btn_buscarticket
            // 
            this.btn_buscarticket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btn_buscarticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscarticket.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarticket.Location = new System.Drawing.Point(547, 34);
            this.btn_buscarticket.Name = "btn_buscarticket";
            this.btn_buscarticket.Size = new System.Drawing.Size(140, 40);
            this.btn_buscarticket.TabIndex = 58;
            this.btn_buscarticket.Text = "Buscar Ticket";
            this.btn_buscarticket.UseVisualStyleBackColor = false;
            this.btn_buscarticket.Click += new System.EventHandler(this.btn_buscarticket_Click);
            // 
            // cmb_TipoDevolucion
            // 
            this.cmb_TipoDevolucion.FormattingEnabled = true;
            this.cmb_TipoDevolucion.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.cmb_TipoDevolucion.Location = new System.Drawing.Point(255, 460);
            this.cmb_TipoDevolucion.Name = "cmb_TipoDevolucion";
            this.cmb_TipoDevolucion.Size = new System.Drawing.Size(249, 24);
            this.cmb_TipoDevolucion.TabIndex = 59;
            // 
            // Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 581);
            this.Controls.Add(this.cmb_TipoDevolucion);
            this.Controls.Add(this.btn_buscarticket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Motivo);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.dgv_DetallesVenta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_MetodoPago);
            this.Controls.Add(this.txt_FechaCompra);
            this.Controls.Add(this.txt_IdTicket);
            this.Name = "Devolucion";
            this.Text = "Devolucion";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DetallesVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_IdTicket;
        private System.Windows.Forms.TextBox txt_FechaCompra;
        private System.Windows.Forms.TextBox txt_MetodoPago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgv_DetallesVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Vendida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Motivo;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Button btn_buscarticket;
        private System.Windows.Forms.ComboBox cmb_TipoDevolucion;
    }
}