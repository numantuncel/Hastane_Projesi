namespace Hastane_Projesi
{
    partial class FrmDoktorGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorGiris));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnhastageridön = new System.Windows.Forms.Button();
            this.btnhastagirisyap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskdoktortc = new System.Windows.Forms.MaskedTextBox();
            this.txtdoktorsifre = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.mskdoktortc);
            this.groupBox1.Controls.Add(this.txtdoktorsifre);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Giriş Formu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(342, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnhastageridön
            // 
            this.btnhastageridön.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnhastageridön.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhastageridön.ForeColor = System.Drawing.Color.Black;
            this.btnhastageridön.Location = new System.Drawing.Point(5, 137);
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
            this.btnhastagirisyap.Location = new System.Drawing.Point(206, 134);
            this.btnhastagirisyap.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnhastagirisyap.Name = "btnhastagirisyap";
            this.btnhastagirisyap.Size = new System.Drawing.Size(111, 42);
            this.btnhastagirisyap.TabIndex = 13;
            this.btnhastagirisyap.Text = "Giriş Yap";
            this.btnhastagirisyap.UseVisualStyleBackColor = true;
            this.btnhastagirisyap.Click += new System.EventHandler(this.btnhastagirisyap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 45);
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
            this.label3.Location = new System.Drawing.Point(71, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şifre:";
            // 
            // mskdoktortc
            // 
            this.mskdoktortc.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskdoktortc.Location = new System.Drawing.Point(143, 42);
            this.mskdoktortc.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.mskdoktortc.Mask = "00000000000";
            this.mskdoktortc.Name = "mskdoktortc";
            this.mskdoktortc.Size = new System.Drawing.Size(174, 38);
            this.mskdoktortc.TabIndex = 10;
            this.mskdoktortc.Text = "17566067750";
            this.mskdoktortc.ValidatingType = typeof(int);
            // 
            // txtdoktorsifre
            // 
            this.txtdoktorsifre.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdoktorsifre.Location = new System.Drawing.Point(143, 88);
            this.txtdoktorsifre.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtdoktorsifre.Name = "txtdoktorsifre";
            this.txtdoktorsifre.Size = new System.Drawing.Size(174, 38);
            this.txtdoktorsifre.TabIndex = 11;
            this.txtdoktorsifre.Text = "147";
            this.txtdoktorsifre.UseSystemPasswordChar = true;
            // 
            // FrmDoktorGiris
            // 
            this.AcceptButton = this.btnhastagirisyap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(554, 219);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDoktorGiris";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnhastageridön;
        private System.Windows.Forms.Button btnhastagirisyap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskdoktortc;
        private System.Windows.Forms.TextBox txtdoktorsifre;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}