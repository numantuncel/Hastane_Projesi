namespace Hastane_Projesi
{
    partial class FrmSekreterGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterGiris));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnhastageridön = new System.Windows.Forms.Button();
            this.btnhastagirisyap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.msksekretertc = new System.Windows.Forms.MaskedTextBox();
            this.txtsekeretersifre = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnhastageridön);
            this.groupBox1.Controls.Add(this.btnhastagirisyap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.msksekretertc);
            this.groupBox1.Controls.Add(this.txtsekeretersifre);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 201);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Giriş Formu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(305, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnhastageridön
            // 
            this.btnhastageridön.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnhastageridön.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhastageridön.ForeColor = System.Drawing.Color.Black;
            this.btnhastageridön.Location = new System.Drawing.Point(11, 158);
            this.btnhastageridön.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnhastageridön.Name = "btnhastageridön";
            this.btnhastageridön.Size = new System.Drawing.Size(131, 36);
            this.btnhastageridön.TabIndex = 14;
            this.btnhastageridön.Text = "< Geri Dön";
            this.btnhastageridön.UseVisualStyleBackColor = false;
            this.btnhastageridön.Click += new System.EventHandler(this.btnhastageridön_Click);
            // 
            // btnhastagirisyap
            // 
            this.btnhastagirisyap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhastagirisyap.Location = new System.Drawing.Point(163, 131);
            this.btnhastagirisyap.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnhastagirisyap.Name = "btnhastagirisyap";
            this.btnhastagirisyap.Size = new System.Drawing.Size(124, 38);
            this.btnhastagirisyap.TabIndex = 13;
            this.btnhastagirisyap.Text = "Giriş Yap";
            this.btnhastagirisyap.UseVisualStyleBackColor = true;
            this.btnhastagirisyap.Click += new System.EventHandler(this.btnhastagirisyap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(5, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "TC K No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(41, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şifre:";
            // 
            // msksekretertc
            // 
            this.msksekretertc.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msksekretertc.Location = new System.Drawing.Point(113, 42);
            this.msksekretertc.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.msksekretertc.Mask = "00000000000";
            this.msksekretertc.Name = "msksekretertc";
            this.msksekretertc.Size = new System.Drawing.Size(174, 38);
            this.msksekretertc.TabIndex = 10;
            this.msksekretertc.Text = "123";
            this.msksekretertc.ValidatingType = typeof(int);
            // 
            // txtsekeretersifre
            // 
            this.txtsekeretersifre.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsekeretersifre.Location = new System.Drawing.Point(113, 85);
            this.txtsekeretersifre.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtsekeretersifre.Name = "txtsekeretersifre";
            this.txtsekeretersifre.Size = new System.Drawing.Size(174, 38);
            this.txtsekeretersifre.TabIndex = 11;
            this.txtsekeretersifre.Text = "456";
            this.txtsekeretersifre.UseSystemPasswordChar = true;
            // 
            // FrmSekreterGiris
            // 
            this.AcceptButton = this.btnhastagirisyap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(544, 227);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSekreterGiris";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnhastageridön;
        private System.Windows.Forms.Button btnhastagirisyap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox msksekretertc;
        private System.Windows.Forms.TextBox txtsekeretersifre;
    }
}