namespace OnlineChat
{
    partial class kayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayit));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_devam = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tb_soyad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tb_ad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_simge = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.rb_kadın = new System.Windows.Forms.RadioButton();
            this.btn_kapat = new Bunifu.Framework.UI.BunifuImageButton();
            this.rb_erkek = new System.Windows.Forms.RadioButton();
            this.lb_cinsiyet = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tb_epostanelirle = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tb_parolabelirle2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tb_parolabelirle = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tb_idbelirle = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_simge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btn_devam
            // 
            this.btn_devam.ActiveBorderThickness = 1;
            this.btn_devam.ActiveCornerRadius = 20;
            this.btn_devam.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btn_devam.ActiveForecolor = System.Drawing.Color.Silver;
            this.btn_devam.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btn_devam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_devam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btn_devam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_devam.BackgroundImage")));
            this.btn_devam.ButtonText = "Devam Et";
            this.btn_devam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_devam.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_devam.ForeColor = System.Drawing.Color.White;
            this.btn_devam.IdleBorderThickness = 1;
            this.btn_devam.IdleCornerRadius = 20;
            this.btn_devam.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btn_devam.IdleForecolor = System.Drawing.Color.White;
            this.btn_devam.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btn_devam.Location = new System.Drawing.Point(119, 435);
            this.btn_devam.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_devam.Name = "btn_devam";
            this.btn_devam.Size = new System.Drawing.Size(174, 55);
            this.btn_devam.TabIndex = 57;
            this.btn_devam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_devam.Click += new System.EventHandler(this.btn_devam_Click);
            // 
            // tb_soyad
            // 
            this.tb_soyad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_soyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_soyad.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_soyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_soyad.HintForeColor = System.Drawing.Color.DimGray;
            this.tb_soyad.HintText = "Soyadınızı Giriniz";
            this.tb_soyad.isPassword = false;
            this.tb_soyad.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.tb_soyad.LineIdleColor = System.Drawing.Color.Gray;
            this.tb_soyad.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.tb_soyad.LineThickness = 3;
            this.tb_soyad.Location = new System.Drawing.Point(75, 285);
            this.tb_soyad.Margin = new System.Windows.Forms.Padding(4);
            this.tb_soyad.Name = "tb_soyad";
            this.tb_soyad.Size = new System.Drawing.Size(277, 37);
            this.tb_soyad.TabIndex = 51;
            this.tb_soyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_soyad.OnValueChanged += new System.EventHandler(this.tb_soyad_OnValueChanged);
            // 
            // tb_ad
            // 
            this.tb_ad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_ad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_ad.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_ad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_ad.HintForeColor = System.Drawing.Color.DimGray;
            this.tb_ad.HintText = "Adınızı Giriniz";
            this.tb_ad.isPassword = false;
            this.tb_ad.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.tb_ad.LineIdleColor = System.Drawing.Color.Gray;
            this.tb_ad.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.tb_ad.LineThickness = 3;
            this.tb_ad.Location = new System.Drawing.Point(75, 228);
            this.tb_ad.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ad.Name = "tb_ad";
            this.tb_ad.Size = new System.Drawing.Size(277, 37);
            this.tb_ad.TabIndex = 50;
            this.tb_ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_ad.OnValueChanged += new System.EventHandler(this.tb_ad_OnValueChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(73, 409);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(63, 19);
            this.bunifuCustomLabel1.TabIndex = 55;
            this.bunifuCustomLabel1.Text = "Cinsiyet";
            // 
            // btn_simge
            // 
            this.btn_simge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btn_simge.Image = ((System.Drawing.Image)(resources.GetObject("btn_simge.Image")));
            this.btn_simge.ImageActive = null;
            this.btn_simge.Location = new System.Drawing.Point(43, 8);
            this.btn_simge.Name = "btn_simge";
            this.btn_simge.Size = new System.Drawing.Size(21, 21);
            this.btn_simge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_simge.TabIndex = 46;
            this.btn_simge.TabStop = false;
            this.btn_simge.Zoom = 10;
            this.btn_simge.Click += new System.EventHandler(this.btn_simge_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(70, 8);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(21, 21);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton2.TabIndex = 45;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // rb_kadın
            // 
            this.rb_kadın.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_kadın.AutoSize = true;
            this.rb_kadın.ForeColor = System.Drawing.Color.DimGray;
            this.rb_kadın.Location = new System.Drawing.Point(252, 404);
            this.rb_kadın.Name = "rb_kadın";
            this.rb_kadın.Size = new System.Drawing.Size(67, 23);
            this.rb_kadın.TabIndex = 54;
            this.rb_kadın.TabStop = true;
            this.rb_kadın.Text = "Kadın";
            this.rb_kadın.UseVisualStyleBackColor = true;
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btn_kapat.Image = ((System.Drawing.Image)(resources.GetObject("btn_kapat.Image")));
            this.btn_kapat.ImageActive = null;
            this.btn_kapat.Location = new System.Drawing.Point(16, 8);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(21, 21);
            this.btn_kapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_kapat.TabIndex = 44;
            this.btn_kapat.TabStop = false;
            this.btn_kapat.Zoom = 10;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // rb_erkek
            // 
            this.rb_erkek.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_erkek.AutoSize = true;
            this.rb_erkek.ForeColor = System.Drawing.Color.DimGray;
            this.rb_erkek.Location = new System.Drawing.Point(167, 405);
            this.rb_erkek.Name = "rb_erkek";
            this.rb_erkek.Size = new System.Drawing.Size(67, 23);
            this.rb_erkek.TabIndex = 53;
            this.rb_erkek.TabStop = true;
            this.rb_erkek.Text = "Erkek";
            this.rb_erkek.UseVisualStyleBackColor = true;
            // 
            // lb_cinsiyet
            // 
            this.lb_cinsiyet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_cinsiyet.AutoSize = true;
            this.lb_cinsiyet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.lb_cinsiyet.Location = new System.Drawing.Point(73, 386);
            this.lb_cinsiyet.Name = "lb_cinsiyet";
            this.lb_cinsiyet.Size = new System.Drawing.Size(63, 19);
            this.lb_cinsiyet.TabIndex = 56;
            this.lb_cinsiyet.Text = "Cinsiyet";
            // 
            // tb_epostanelirle
            // 
            this.tb_epostanelirle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_epostanelirle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_epostanelirle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_epostanelirle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_epostanelirle.HintForeColor = System.Drawing.Color.DimGray;
            this.tb_epostanelirle.HintText = "E-Posta Adresinizi Giriniz";
            this.tb_epostanelirle.isPassword = false;
            this.tb_epostanelirle.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.tb_epostanelirle.LineIdleColor = System.Drawing.Color.Gray;
            this.tb_epostanelirle.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.tb_epostanelirle.LineThickness = 3;
            this.tb_epostanelirle.Location = new System.Drawing.Point(75, 342);
            this.tb_epostanelirle.Margin = new System.Windows.Forms.Padding(4);
            this.tb_epostanelirle.Name = "tb_epostanelirle";
            this.tb_epostanelirle.Size = new System.Drawing.Size(277, 37);
            this.tb_epostanelirle.TabIndex = 52;
            this.tb_epostanelirle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_epostanelirle.OnValueChanged += new System.EventHandler(this.tb_epostanelirle_OnValueChanged);
            // 
            // tb_parolabelirle2
            // 
            this.tb_parolabelirle2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_parolabelirle2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_parolabelirle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_parolabelirle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_parolabelirle2.HintForeColor = System.Drawing.Color.DimGray;
            this.tb_parolabelirle2.HintText = "Parolayı Tekrar Giriniz";
            this.tb_parolabelirle2.isPassword = false;
            this.tb_parolabelirle2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.tb_parolabelirle2.LineIdleColor = System.Drawing.Color.Gray;
            this.tb_parolabelirle2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.tb_parolabelirle2.LineThickness = 3;
            this.tb_parolabelirle2.Location = new System.Drawing.Point(75, 171);
            this.tb_parolabelirle2.Margin = new System.Windows.Forms.Padding(4);
            this.tb_parolabelirle2.Name = "tb_parolabelirle2";
            this.tb_parolabelirle2.Size = new System.Drawing.Size(277, 37);
            this.tb_parolabelirle2.TabIndex = 49;
            this.tb_parolabelirle2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_parolabelirle2.OnValueChanged += new System.EventHandler(this.tb_parolabelirle2_OnValueChanged);
            // 
            // tb_parolabelirle
            // 
            this.tb_parolabelirle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_parolabelirle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_parolabelirle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_parolabelirle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_parolabelirle.HintForeColor = System.Drawing.Color.DimGray;
            this.tb_parolabelirle.HintText = "Parola Belirleyiniz";
            this.tb_parolabelirle.isPassword = false;
            this.tb_parolabelirle.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.tb_parolabelirle.LineIdleColor = System.Drawing.Color.Gray;
            this.tb_parolabelirle.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.tb_parolabelirle.LineThickness = 3;
            this.tb_parolabelirle.Location = new System.Drawing.Point(75, 114);
            this.tb_parolabelirle.Margin = new System.Windows.Forms.Padding(4);
            this.tb_parolabelirle.Name = "tb_parolabelirle";
            this.tb_parolabelirle.Size = new System.Drawing.Size(277, 37);
            this.tb_parolabelirle.TabIndex = 48;
            this.tb_parolabelirle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_parolabelirle.OnValueChanged += new System.EventHandler(this.tb_parolabelirle_OnValueChanged);
            // 
            // tb_idbelirle
            // 
            this.tb_idbelirle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_idbelirle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_idbelirle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_idbelirle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_idbelirle.HintForeColor = System.Drawing.Color.DimGray;
            this.tb_idbelirle.HintText = "Kullanıcı Adı Belirleyiniz";
            this.tb_idbelirle.isPassword = false;
            this.tb_idbelirle.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.tb_idbelirle.LineIdleColor = System.Drawing.Color.Gray;
            this.tb_idbelirle.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.tb_idbelirle.LineThickness = 3;
            this.tb_idbelirle.Location = new System.Drawing.Point(75, 57);
            this.tb_idbelirle.Margin = new System.Windows.Forms.Padding(4);
            this.tb_idbelirle.Name = "tb_idbelirle";
            this.tb_idbelirle.Size = new System.Drawing.Size(277, 37);
            this.tb_idbelirle.TabIndex = 47;
            this.tb_idbelirle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_idbelirle.OnValueChanged += new System.EventHandler(this.tb_idbelirle_OnValueChanged);
            // 
            // kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(400, 550);
            this.Controls.Add(this.btn_devam);
            this.Controls.Add(this.tb_soyad);
            this.Controls.Add(this.tb_ad);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btn_simge);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.rb_kadın);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.rb_erkek);
            this.Controls.Add(this.lb_cinsiyet);
            this.Controls.Add(this.tb_epostanelirle);
            this.Controls.Add(this.tb_parolabelirle2);
            this.Controls.Add(this.tb_parolabelirle);
            this.Controls.Add(this.tb_idbelirle);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "kayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kayit";
            this.Load += new System.EventHandler(this.kayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_simge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_devam;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_soyad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_ad;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton btn_simge;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.RadioButton rb_kadın;
        private Bunifu.Framework.UI.BunifuImageButton btn_kapat;
        private System.Windows.Forms.RadioButton rb_erkek;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_cinsiyet;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_epostanelirle;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_parolabelirle2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_parolabelirle;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_idbelirle;
    }
}