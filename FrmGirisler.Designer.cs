namespace Hastane_Projesi
{
    partial class FrmGirisler
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btndoktorgiris = new System.Windows.Forms.Button();
            this.btnsekretergiris = new System.Windows.Forms.Button();
            this.btnhastagiris = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(564, 54);
            this.label4.TabIndex = 15;
            this.label4.Text = "Polatlı Devlet Hastanesi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(710, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(826, 547);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sekreter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(488, 547);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "Doktor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(145, 547);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hasta";
            // 
            // btndoktorgiris
            // 
            this.btndoktorgiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndoktorgiris.BackgroundImage")));
            this.btndoktorgiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndoktorgiris.Location = new System.Drawing.Point(361, 298);
            this.btndoktorgiris.Name = "btndoktorgiris";
            this.btndoktorgiris.Size = new System.Drawing.Size(343, 247);
            this.btndoktorgiris.TabIndex = 10;
            this.btndoktorgiris.UseVisualStyleBackColor = true;
            this.btndoktorgiris.Click += new System.EventHandler(this.btndoktorgiris_Click);
            // 
            // btnsekretergiris
            // 
            this.btnsekretergiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsekretergiris.BackgroundImage")));
            this.btnsekretergiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsekretergiris.Location = new System.Drawing.Point(710, 298);
            this.btnsekretergiris.Name = "btnsekretergiris";
            this.btnsekretergiris.Size = new System.Drawing.Size(343, 247);
            this.btnsekretergiris.TabIndex = 9;
            this.btnsekretergiris.UseVisualStyleBackColor = true;
            this.btnsekretergiris.Click += new System.EventHandler(this.btnsekretergiris_Click);
            // 
            // btnhastagiris
            // 
            this.btnhastagiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhastagiris.BackgroundImage")));
            this.btnhastagiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhastagiris.Location = new System.Drawing.Point(12, 298);
            this.btnhastagiris.Name = "btnhastagiris";
            this.btnhastagiris.Size = new System.Drawing.Size(343, 247);
            this.btnhastagiris.TabIndex = 8;
            this.btnhastagiris.UseVisualStyleBackColor = true;
            this.btnhastagiris.Click += new System.EventHandler(this.btnhastagiris_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnsekretergiris);
            this.groupBox1.Controls.Add(this.btnhastagiris);
            this.groupBox1.Controls.Add(this.btndoktorgiris);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1066, 579);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Türü Seç";
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1066, 579);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGirisler";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndoktorgiris;
        private System.Windows.Forms.Button btnsekretergiris;
        private System.Windows.Forms.Button btnhastagiris;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

