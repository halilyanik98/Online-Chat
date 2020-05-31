namespace OnlineChat
{
    partial class GirisSayfasi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisSayfasi));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.misafir = new System.Windows.Forms.CheckBox();
            this.lb_sifreunuttum = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_giris = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_simge = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_tamekran = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_kapat = new Bunifu.Framework.UI.BunifuImageButton();
            this.tb_sifre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tb_id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_versiyon = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lb_kayit = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_simge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_tamekran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(64, 89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(278, 50);
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // misafir
            // 
            this.misafir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.misafir.AutoSize = true;
            this.misafir.ForeColor = System.Drawing.Color.Gray;
            this.misafir.Location = new System.Drawing.Point(67, 321);
            this.misafir.Name = "misafir";
            this.misafir.Size = new System.Drawing.Size(111, 32);
            this.misafir.TabIndex = 52;
            this.misafir.Text = "Misafir";
            this.misafir.UseVisualStyleBackColor = true;
            this.misafir.CheckedChanged += new System.EventHandler(this.misafir_CheckedChanged);
            // 
            // lb_sifreunuttum
            // 
            this.lb_sifreunuttum.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb_sifreunuttum.AutoSize = true;
            this.lb_sifreunuttum.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_sifreunuttum.ForeColor = System.Drawing.Color.DimGray;
            this.lb_sifreunuttum.Location = new System.Drawing.Point(206, 321);
            this.lb_sifreunuttum.Name = "lb_sifreunuttum";
            this.lb_sifreunuttum.Size = new System.Drawing.Size(192, 28);
            this.lb_sifreunuttum.TabIndex = 51;
            this.lb_sifreunuttum.Text = "Şifremi Unuttum";
            this.lb_sifreunuttum.Click += new System.EventHandler(this.lb_sifreunuttum_Click);
            // 
            // btn_giris
            // 
            this.btn_giris.ActiveBorderThickness = 1;
            this.btn_giris.ActiveCornerRadius = 20;
            this.btn_giris.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btn_giris.ActiveForecolor = System.Drawing.Color.Silver;
            this.btn_giris.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btn_giris.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_giris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btn_giris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_giris.BackgroundImage")));
            this.btn_giris.ButtonText = "Giriş";
            this.btn_giris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_giris.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.ForeColor = System.Drawing.Color.White;
            this.btn_giris.IdleBorderThickness = 1;
            this.btn_giris.IdleCornerRadius = 20;
            this.btn_giris.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btn_giris.IdleForecolor = System.Drawing.Color.White;
            this.btn_giris.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btn_giris.Location = new System.Drawing.Point(114, 387);
            this.btn_giris.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(174, 55);
            this.btn_giris.TabIndex = 49;
            this.btn_giris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(256, 10);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(200, 23);
            this.bunifuCustomLabel2.TabIndex = 48;
            this.bunifuCustomLabel2.Text = "Bağlantını Kontrol Et";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // btn_simge
            // 
            this.btn_simge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btn_simge.Image = ((System.Drawing.Image)(resources.GetObject("btn_simge.Image")));
            this.btn_simge.ImageActive = null;
            this.btn_simge.Location = new System.Drawing.Point(40, 10);
            this.btn_simge.Name = "btn_simge";
            this.btn_simge.Size = new System.Drawing.Size(21, 21);
            this.btn_simge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_simge.TabIndex = 45;
            this.btn_simge.TabStop = false;
            this.btn_simge.Zoom = 10;
            this.btn_simge.Click += new System.EventHandler(this.btn_simge_Click);
            // 
            // btn_tamekran
            // 
            this.btn_tamekran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btn_tamekran.Image = ((System.Drawing.Image)(resources.GetObject("btn_tamekran.Image")));
            this.btn_tamekran.ImageActive = null;
            this.btn_tamekran.Location = new System.Drawing.Point(67, 10);
            this.btn_tamekran.Name = "btn_tamekran";
            this.btn_tamekran.Size = new System.Drawing.Size(21, 21);
            this.btn_tamekran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_tamekran.TabIndex = 44;
            this.btn_tamekran.TabStop = false;
            this.btn_tamekran.Zoom = 10;
            this.btn_tamekran.Click += new System.EventHandler(this.btn_tamekran_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btn_kapat.Image = ((System.Drawing.Image)(resources.GetObject("btn_kapat.Image")));
            this.btn_kapat.ImageActive = null;
            this.btn_kapat.Location = new System.Drawing.Point(13, 10);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(21, 21);
            this.btn_kapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_kapat.TabIndex = 43;
            this.btn_kapat.TabStop = false;
            this.btn_kapat.Zoom = 10;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // tb_sifre
            // 
            this.tb_sifre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_sifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_sifre.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_sifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_sifre.HintForeColor = System.Drawing.Color.DimGray;
            this.tb_sifre.HintText = "Parola";
            this.tb_sifre.isPassword = true;
            this.tb_sifre.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.tb_sifre.LineIdleColor = System.Drawing.Color.Gray;
            this.tb_sifre.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.tb_sifre.LineThickness = 3;
            this.tb_sifre.Location = new System.Drawing.Point(64, 269);
            this.tb_sifre.Margin = new System.Windows.Forms.Padding(4);
            this.tb_sifre.Name = "tb_sifre";
            this.tb_sifre.Size = new System.Drawing.Size(270, 37);
            this.tb_sifre.TabIndex = 47;
            this.tb_sifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_sifre.OnValueChanged += new System.EventHandler(this.tb_sifre_OnValueChanged);
            // 
            // tb_id
            // 
            this.tb_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_id.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_id.HintForeColor = System.Drawing.Color.DimGray;
            this.tb_id.HintText = "Kullanıcı Adınızı Giriniz";
            this.tb_id.isPassword = false;
            this.tb_id.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.tb_id.LineIdleColor = System.Drawing.Color.Gray;
            this.tb_id.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.tb_id.LineThickness = 3;
            this.tb_id.Location = new System.Drawing.Point(64, 190);
            this.tb_id.Margin = new System.Windows.Forms.Padding(4);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(270, 37);
            this.tb_id.TabIndex = 46;
            this.tb_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_id.OnValueChanged += new System.EventHandler(this.tb_id_OnValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(327, 496);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lb_versiyon
            // 
            this.lb_versiyon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lb_versiyon.AutoSize = true;
            this.lb_versiyon.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_versiyon.ForeColor = System.Drawing.Color.DimGray;
            this.lb_versiyon.Location = new System.Drawing.Point(145, 526);
            this.lb_versiyon.Name = "lb_versiyon";
            this.lb_versiyon.Size = new System.Drawing.Size(119, 23);
            this.lb_versiyon.TabIndex = 55;
            this.lb_versiyon.Text = "Versiyon 1.1";
            this.lb_versiyon.Click += new System.EventHandler(this.lb_versiyon_Click);
            // 
            // lb_kayit
            // 
            this.lb_kayit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lb_kayit.AutoSize = true;
            this.lb_kayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_kayit.ForeColor = System.Drawing.Color.White;
            this.lb_kayit.Location = new System.Drawing.Point(107, 482);
            this.lb_kayit.Name = "lb_kayit";
            this.lb_kayit.Size = new System.Drawing.Size(198, 55);
            this.lb_kayit.TabIndex = 54;
            this.lb_kayit.Text = "Kayıt Ol";
            this.lb_kayit.Click += new System.EventHandler(this.lb_kayit_Click);
            // 
            // GirisSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(400, 550);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_versiyon);
            this.Controls.Add(this.lb_kayit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.misafir);
            this.Controls.Add(this.lb_sifreunuttum);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.btn_simge);
            this.Controls.Add(this.btn_tamekran);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.tb_sifre);
            this.Controls.Add(this.tb_id);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GirisSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Sayfası";
            this.Load += new System.EventHandler(this.GirisSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_simge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_tamekran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_versiyon;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_kayit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox misafir;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_sifreunuttum;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_giris;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuImageButton btn_simge;
        private Bunifu.Framework.UI.BunifuImageButton btn_tamekran;
        private Bunifu.Framework.UI.BunifuImageButton btn_kapat;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_sifre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_id;
    }
}

