namespace Hastane_Projesi
{
    partial class FrmHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaGiris));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskhastatc = new System.Windows.Forms.MaskedTextBox();
            this.txthastasifre = new System.Windows.Forms.TextBox();
            this.linkhastaüye = new System.Windows.Forms.LinkLabel();
            this.btnhastagirisyap = new System.Windows.Forms.Button();
            this.btnhastageridön = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC K No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(44, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // mskhastatc
            // 
            this.mskhastatc.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskhastatc.Location = new System.Drawing.Point(118, 44);
            this.mskhastatc.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.mskhastatc.Mask = "00000000000";
            this.mskhastatc.Name = "mskhastatc";
            this.mskhastatc.Size = new System.Drawing.Size(197, 38);
            this.mskhastatc.TabIndex = 3;
            this.mskhastatc.Text = "21212121211";
            this.mskhastatc.ValidatingType = typeof(int);
            // 
            // txthastasifre
            // 
            this.txthastasifre.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txthastasifre.Location = new System.Drawing.Point(118, 90);
            this.txthastasifre.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txthastasifre.MaxLength = 13;
            this.txthastasifre.Name = "txthastasifre";
            this.txthastasifre.Size = new System.Drawing.Size(197, 38);
            this.txthastasifre.TabIndex = 4;
            this.txthastasifre.Text = "123";
            this.txthastasifre.UseSystemPasswordChar = true;
            // 
            // linkhastaüye
            // 
            this.linkhastaüye.AutoSize = true;
            this.linkhastaüye.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkhastaüye.Location = new System.Drawing.Point(134, 145);
            this.linkhastaüye.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkhastaüye.Name = "linkhastaüye";
            this.linkhastaüye.Size = new System.Drawing.Size(73, 28);
            this.linkhastaüye.TabIndex = 5;
            this.linkhastaüye.TabStop = true;
            this.linkhastaüye.Text = "Üye Ol";
            this.linkhastaüye.Click += new System.EventHandler(this.linkhastaüye_Click);
            // 
            // btnhastagirisyap
            // 
            this.btnhastagirisyap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhastagirisyap.Location = new System.Drawing.Point(211, 136);
            this.btnhastagirisyap.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnhastagirisyap.Name = "btnhastagirisyap";
            this.btnhastagirisyap.Size = new System.Drawing.Size(104, 44);
            this.btnhastagirisyap.TabIndex = 6;
            this.btnhastagirisyap.Text = "Giriş Yap";
            this.btnhastagirisyap.UseVisualStyleBackColor = true;
            this.btnhastagirisyap.Click += new System.EventHandler(this.btnhastagirisyap_Click);
            // 
            // btnhastageridön
            // 
            this.btnhastageridön.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnhastageridön.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhastageridön.ForeColor = System.Drawing.Color.Black;
            this.btnhastageridön.Location = new System.Drawing.Point(4, 152);
            this.btnhastageridön.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnhastageridön.Name = "btnhastageridön";
            this.btnhastageridön.Size = new System.Drawing.Size(126, 38);
            this.btnhastageridön.TabIndex = 7;
            this.btnhastageridön.Text = "< Geri Dön";
            this.btnhastageridön.UseVisualStyleBackColor = false;
            this.btnhastageridön.Click += new System.EventHandler(this.btngeridön_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnhastageridön);
            this.groupBox1.Controls.Add(this.btnhastagirisyap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.linkhastaüye);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mskhastatc);
            this.groupBox1.Controls.Add(this.txthastasifre);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox1.Size = new System.Drawing.Size(543, 198);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Giriş Formu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(320, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FrmHastaGiris
            // 
            this.AcceptButton = this.btnhastagirisyap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(562, 222);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHastaGiris";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskhastatc;
        private System.Windows.Forms.TextBox txthastasifre;
        private System.Windows.Forms.LinkLabel linkhastaüye;
        private System.Windows.Forms.Button btnhastagirisyap;
        private System.Windows.Forms.Button btnhastageridön;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}