﻿namespace Login
{
    partial class MenuPoliReg
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btRegresar
            // 
            this.btRegresar.Location = new System.Drawing.Point(157, 308);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(83, 39);
            this.btRegresar.TabIndex = 18;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // btArea
            // 
            this.btArea.Location = new System.Drawing.Point(251, 253);
            this.btArea.Name = "btArea";
            this.btArea.Size = new System.Drawing.Size(75, 39);
            this.btArea.TabIndex = 17;
            this.btArea.Text = "Area";
            this.btArea.UseVisualStyleBackColor = true;
            this.btArea.Click += new System.EventHandler(this.btArea_Click);
            // 
            // btPerimetro
            // 
            this.btPerimetro.Location = new System.Drawing.Point(61, 253);
            this.btPerimetro.Name = "btPerimetro";
            this.btPerimetro.Size = new System.Drawing.Size(98, 39);
            this.btPerimetro.TabIndex = 16;
            this.btPerimetro.Text = "Perimetro";
            this.btPerimetro.UseVisualStyleBackColor = true;
            this.btPerimetro.Click += new System.EventHandler(this.btPerimetro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Lado 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Lado 1";
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(294, 22);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(100, 22);
            this.txtLado2.TabIndex = 13;
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(13, 22);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(100, 22);
            this.txtLado1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login.Properties.Resources.PoligonoReg;
            this.pictureBox1.Location = new System.Drawing.Point(117, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // MenuPoliReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 370);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.btArea);
            this.Controls.Add(this.btPerimetro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLado2);
            this.Controls.Add(this.txtLado1);
            this.Name = "MenuPoliReg";
            this.Text = "MenuPoliReg";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Button btArea;
        private System.Windows.Forms.Button btPerimetro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}