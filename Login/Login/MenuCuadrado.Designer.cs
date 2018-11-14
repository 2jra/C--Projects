namespace Login
{
    partial class MenuCuadrado
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
            this.txtLado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btRegresar
            // 
            this.btRegresar.Location = new System.Drawing.Point(190, 348);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(83, 39);
            this.btRegresar.TabIndex = 14;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // btArea
            // 
            this.btArea.Location = new System.Drawing.Point(284, 293);
            this.btArea.Name = "btArea";
            this.btArea.Size = new System.Drawing.Size(75, 39);
            this.btArea.TabIndex = 13;
            this.btArea.Text = "Area";
            this.btArea.UseVisualStyleBackColor = true;
            this.btArea.Click += new System.EventHandler(this.btArea_Click);
            // 
            // btPerimetro
            // 
            this.btPerimetro.Location = new System.Drawing.Point(94, 293);
            this.btPerimetro.Name = "btPerimetro";
            this.btPerimetro.Size = new System.Drawing.Size(98, 39);
            this.btPerimetro.TabIndex = 12;
            this.btPerimetro.Text = "Perimetro";
            this.btPerimetro.UseVisualStyleBackColor = true;
            this.btPerimetro.Click += new System.EventHandler(this.btPerimetro_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login.Properties.Resources.cuadrado;
            this.pictureBox1.Location = new System.Drawing.Point(156, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(187, 239);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(100, 22);
            this.txtLado.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Valor de los Lados";
            // 
            // MenuCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.btArea);
            this.Controls.Add(this.btPerimetro);
            this.Name = "MenuCuadrado";
            this.Text = "MenuCuadrado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Button btArea;
        private System.Windows.Forms.Button btPerimetro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Label label1;
    }
}