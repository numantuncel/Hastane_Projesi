﻿namespace Hastane_Projesi
{
    partial class FrmHastaBilgiDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaBilgiDüzenle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textüyesoyad = new System.Windows.Forms.TextBox();
            this.btnbilgigüncelle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboüyecinsiyet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedtelefon = new System.Windows.Forms.MaskedTextBox();
            this.msküyetc = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textüyesifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textüyead = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnhastageridön = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnhastageridön);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.textüyesoyad);
            this.groupBox1.Controls.Add(this.btnbilgigüncelle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboüyecinsiyet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.maskedtelefon);
            this.groupBox1.Controls.Add(this.msküyetc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textüyesifre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textüyead);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 314);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgileri Güncelle";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(293, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // textüyesoyad
            // 
            this.textüyesoyad.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textüyesoyad.Location = new System.Drawing.Point(114, 83);
            this.textüyesoyad.Name = "textüyesoyad";
            this.textüyesoyad.Size = new System.Drawing.Size(174, 38);
            this.textüyesoyad.TabIndex = 2;
            // 
            // btnbilgigüncelle
            // 
            this.btnbilgigüncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbilgigüncelle.Location = new System.Drawing.Point(293, 216);
            this.btnbilgigüncelle.Name = "btnbilgigüncelle";
            this.btnbilgigüncelle.Size = new System.Drawing.Size(206, 38);
            this.btnbilgigüncelle.TabIndex = 31;
            this.btnbilgigüncelle.Text = "Güncelle";
            this.btnbilgigüncelle.UseVisualStyleBackColor = true;
            this.btnbilgigüncelle.Click += new System.EventHandler(this.btnbilgigüncelle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(4, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 31);
            this.label2.TabIndex = 19;
            this.label2.Text = "TC K No:";
            // 
            // comboüyecinsiyet
            // 
            this.comboüyecinsiyet.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboüyecinsiyet.FormattingEnabled = true;
            this.comboüyecinsiyet.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.comboüyecinsiyet.Location = new System.Drawing.Point(114, 127);
            this.comboüyecinsiyet.Name = "comboüyecinsiyet";
            this.comboüyecinsiyet.Size = new System.Drawing.Size(174, 39);
            this.comboüyecinsiyet.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(40, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 31);
            this.label3.TabIndex = 20;
            this.label3.Text = "Şifre:";
            // 
            // maskedtelefon
            // 
            this.maskedtelefon.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedtelefon.Location = new System.Drawing.Point(114, 172);
            this.maskedtelefon.Mask = "(999) 000-0000";
            this.maskedtelefon.Name = "maskedtelefon";
            this.maskedtelefon.Size = new System.Drawing.Size(174, 38);
            this.maskedtelefon.TabIndex = 4;
            // 
            // msküyetc
            // 
            this.msküyetc.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msküyetc.Location = new System.Drawing.Point(114, 216);
            this.msküyetc.Mask = "00000000000";
            this.msküyetc.Name = "msküyetc";
            this.msküyetc.Size = new System.Drawing.Size(174, 38);
            this.msküyetc.TabIndex = 5;
            this.msküyetc.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 31);
            this.label6.TabIndex = 28;
            this.label6.Text = "Telefon:";
            // 
            // textüyesifre
            // 
            this.textüyesifre.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textüyesifre.Location = new System.Drawing.Point(114, 260);
            this.textüyesifre.MaxLength = 13;
            this.textüyesifre.Name = "textüyesifre";
            this.textüyesifre.Size = new System.Drawing.Size(174, 38);
            this.textüyesifre.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(7, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 31);
            this.label5.TabIndex = 27;
            this.label5.Text = "Cinsiyet:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(59, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ad:";
            // 
            // textüyead
            // 
            this.textüyead.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textüyead.Location = new System.Drawing.Point(114, 39);
            this.textüyead.Name = "textüyead";
            this.textüyead.Size = new System.Drawing.Size(174, 38);
            this.textüyead.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(23, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 31);
            this.label4.TabIndex = 25;
            this.label4.Text = "Soyad:";
            // 
            // btnhastageridön
            // 
            this.btnhastageridön.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnhastageridön.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhastageridön.ForeColor = System.Drawing.Color.Black;
            this.btnhastageridön.Location = new System.Drawing.Point(294, 261);
            this.btnhastageridön.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnhastageridön.Name = "btnhastageridön";
            this.btnhastageridön.Size = new System.Drawing.Size(206, 37);
            this.btnhastageridön.TabIndex = 33;
            this.btnhastageridön.Text = "< Geri Dön";
            this.btnhastageridön.UseVisualStyleBackColor = false;
            this.btnhastageridön.Click += new System.EventHandler(this.btnhastageridön_Click);
            // 
            // FrmHastaBilgiDüzenle
            // 
            this.AcceptButton = this.btnbilgigüncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(530, 338);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHastaBilgiDüzenle";
            this.Load += new System.EventHandler(this.FrmHastaBilgiDüzenle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textüyesoyad;
        private System.Windows.Forms.Button btnbilgigüncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboüyecinsiyet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedtelefon;
        private System.Windows.Forms.MaskedTextBox msküyetc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textüyesifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textüyead;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnhastageridön;
    }
}