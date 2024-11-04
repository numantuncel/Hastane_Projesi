namespace Hastane_Projesi
{
    partial class FrmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
            this.textüyesifre = new System.Windows.Forms.TextBox();
            this.msküyetc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textüyead = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textüyesoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedtelefon = new System.Windows.Forms.MaskedTextBox();
            this.comboüyecinsiyet = new System.Windows.Forms.ComboBox();
            this.btnuyekaydet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnhastageridön = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textüyesifre
            // 
            this.textüyesifre.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textüyesifre.Location = new System.Drawing.Point(113, 258);
            this.textüyesifre.MaxLength = 13;
            this.textüyesifre.Name = "textüyesifre";
            this.textüyesifre.Size = new System.Drawing.Size(174, 38);
            this.textüyesifre.TabIndex = 20;
            this.textüyesifre.UseSystemPasswordChar = true;
            // 
            // msküyetc
            // 
            this.msküyetc.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msküyetc.Location = new System.Drawing.Point(113, 214);
            this.msküyetc.Mask = "00000000000";
            this.msküyetc.Name = "msküyetc";
            this.msküyetc.Size = new System.Drawing.Size(174, 38);
            this.msküyetc.TabIndex = 18;
            this.msküyetc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(50, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "TC K No:";
            // 
            // textüyead
            // 
            this.textüyead.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textüyead.Location = new System.Drawing.Point(113, 36);
            this.textüyead.Name = "textüyead";
            this.textüyead.Size = new System.Drawing.Size(174, 38);
            this.textüyead.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(58, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ad:";
            // 
            // textüyesoyad
            // 
            this.textüyesoyad.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textüyesoyad.Location = new System.Drawing.Point(113, 81);
            this.textüyesoyad.Name = "textüyesoyad";
            this.textüyesoyad.Size = new System.Drawing.Size(174, 38);
            this.textüyesoyad.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(36, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(17, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cinsiyet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(22, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 31);
            this.label6.TabIndex = 15;
            this.label6.Text = "Telefon:";
            // 
            // maskedtelefon
            // 
            this.maskedtelefon.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedtelefon.Location = new System.Drawing.Point(113, 170);
            this.maskedtelefon.Mask = "(999) 000-0000";
            this.maskedtelefon.Name = "maskedtelefon";
            this.maskedtelefon.Size = new System.Drawing.Size(174, 38);
            this.maskedtelefon.TabIndex = 16;
            // 
            // comboüyecinsiyet
            // 
            this.comboüyecinsiyet.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboüyecinsiyet.FormattingEnabled = true;
            this.comboüyecinsiyet.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.comboüyecinsiyet.Location = new System.Drawing.Point(113, 125);
            this.comboüyecinsiyet.Name = "comboüyecinsiyet";
            this.comboüyecinsiyet.Size = new System.Drawing.Size(174, 39);
            this.comboüyecinsiyet.TabIndex = 14;
            // 
            // btnuyekaydet
            // 
            this.btnuyekaydet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnuyekaydet.Location = new System.Drawing.Point(176, 302);
            this.btnuyekaydet.Name = "btnuyekaydet";
            this.btnuyekaydet.Size = new System.Drawing.Size(111, 44);
            this.btnuyekaydet.TabIndex = 22;
            this.btnuyekaydet.Text = "Kaydet";
            this.btnuyekaydet.UseVisualStyleBackColor = true;
            this.btnuyekaydet.Click += new System.EventHandler(this.btnuyekaydet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnhastageridön);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.textüyesoyad);
            this.groupBox1.Controls.Add(this.btnuyekaydet);
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
            this.groupBox1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 356);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Kayıt Formu";
            // 
            // btnhastageridön
            // 
            this.btnhastageridön.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnhastageridön.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhastageridön.ForeColor = System.Drawing.Color.Black;
            this.btnhastageridön.Location = new System.Drawing.Point(5, 311);
            this.btnhastageridön.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnhastageridön.Name = "btnhastageridön";
            this.btnhastageridön.Size = new System.Drawing.Size(126, 38);
            this.btnhastageridön.TabIndex = 23;
            this.btnhastageridön.Text = "< Geri Dön";
            this.btnhastageridön.UseVisualStyleBackColor = false;
            this.btnhastageridön.Click += new System.EventHandler(this.btnhastageridön_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(293, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.btnuyekaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(613, 380);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHastaKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textüyesifre;
        private System.Windows.Forms.MaskedTextBox msküyetc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textüyead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textüyesoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedtelefon;
        private System.Windows.Forms.ComboBox comboüyecinsiyet;
        private System.Windows.Forms.Button btnuyekaydet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnhastageridön;
    }
}