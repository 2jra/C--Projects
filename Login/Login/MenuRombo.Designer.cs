namespace Login
{
    partial class MenuRombo
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
            this.btRegresar = new System.Windows.Forms.Button();
            this.btArea = new System.Windows.Forms.Button();
            this.btPerimetro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.txtLadod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLadoDd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btRegresar
            // 
            this.btRegresar.Location = new System.Drawing.Point(158, 311);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(83, 39);
            this.btRegresar.TabIndex = 14;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // btArea
            // 
            this.btArea.Location = new System.Drawing.Point(252, 256);
            this.btArea.Name = "btArea";
            this.btArea.Size = new System.Drawing.Size(75, 39);
            this.btArea.TabIndex = 13;
            this.btArea.Text = "Area";
            this.btArea.UseVisualStyleBackColor = true;
            this.btArea.Click += new System.EventHandler(this.btArea_Click);
            // 
            // btPerimetro
            // 
            this.btPerimetro.Location = new System.Drawing.Point(62, 256);
            this.btPerimetro.Name = "btPerimetro";
            this.btPerimetro.Size = new System.Drawing.Size(98, 39);
            this.btPerimetro.TabIndex = 12;
            this.btPerimetro.Text = "Perimetro";
            this.btPerimetro.UseVisualStyleBackColor = true;
            this.btPerimetro.Click += new System.EventHandler(this.btPerimetro_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login.Properties.Resources.rombo;
            this.pictureBox1.Location = new System.Drawing.Point(113, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Lado";
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(12, 73);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(100, 22);
            this.txtLado.TabIndex = 17;
            // 
            // txtLadod
            // 
            this.txtLadod.Location = new System.Drawing.Point(141, 179);
            this.txtLadod.Name = "txtLadod";
            this.txtLadod.Size = new System.Drawing.Size(100, 22);
            this.txtLadod.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Lado d";
            // 
            // txtLadoDd
            // 
            this.txtLadoDd.Location = new System.Drawing.Point(273, 73);
            this.txtLadoDd.Name = "txtLadoDd";
            this.txtLadoDd.Size = new System.Drawing.Size(100, 22);
            this.txtLadoDd.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Lado D";
            // 
            // MenuRombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 369);
            this.Controls.Add(this.txtLadoDd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLadod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.btArea);
            this.Controls.Add(this.btPerimetro);
            this.Name = "MenuRombo";
            this.Text = "MenuRombo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Button btArea;
        private System.Windows.Forms.Button btPerimetro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.TextBox txtLadod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLadoDd;
        private System.Windows.Forms.Label label3;
    }
}