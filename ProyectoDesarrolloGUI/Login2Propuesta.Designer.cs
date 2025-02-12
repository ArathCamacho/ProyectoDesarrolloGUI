namespace ProyectoDesarrolloGUI
{
    partial class Login2Propuesta
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtbox_1 = new System.Windows.Forms.TextBox();
            this.txtbox_2 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::ProyectoDesarrolloGUI.Properties.Resources.gorramania;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 283);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(299, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 1);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(299, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 1);
            this.panel2.TabIndex = 9;
            // 
            // txtbox_1
            // 
            this.txtbox_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txtbox_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtbox_1.Location = new System.Drawing.Point(299, 66);
            this.txtbox_1.Name = "txtbox_1";
            this.txtbox_1.Size = new System.Drawing.Size(380, 25);
            this.txtbox_1.TabIndex = 10;
            this.txtbox_1.Text = "USUARIO";
            this.txtbox_1.TextChanged += new System.EventHandler(this.txtbox_1_TextChanged);
            this.txtbox_1.Enter += new System.EventHandler(this.txtbox_1_Enter);
            this.txtbox_1.Leave += new System.EventHandler(this.txtbox_1_Leave);
            // 
            // txtbox_2
            // 
            this.txtbox_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txtbox_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtbox_2.Location = new System.Drawing.Point(299, 136);
            this.txtbox_2.Name = "txtbox_2";
            this.txtbox_2.Size = new System.Drawing.Size(380, 25);
            this.txtbox_2.TabIndex = 11;
            this.txtbox_2.Text = "Contraseña";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Location = new System.Drawing.Point(299, 195);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(380, 49);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "ACCEDER";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Login2Propuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(739, 283);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtbox_2);
            this.Controls.Add(this.txtbox_1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login2Propuesta";
            this.Text = "Login2Propuesta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtbox_1;
        private System.Windows.Forms.TextBox txtbox_2;
        private System.Windows.Forms.Button btn1;
    }
}