namespace OnlineChat
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_guncelle = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.K_id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.K_parola = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.K_ad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.K_cinsiyet = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.K_eposta = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.K_soyad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_simge = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_tamekran = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_kapat = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_simge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_tamekran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(666, 172);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(276, 275);
            this.dataGridView2.TabIndex = 84;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.ActiveBorderThickness = 1;
            this.btn_guncelle.ActiveCornerRadius = 20;
            this.btn_guncelle.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btn_guncelle.ActiveForecolor = System.Drawing.Color.Silver;
            this.btn_guncelle.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btn_guncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btn_guncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_guncelle.BackgroundImage")));
            this.btn_guncelle.ButtonText = "Verileri Güncelle";
            this.btn_guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guncelle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.ForeColor = System.Drawing.Color.White;
            this.btn_guncelle.IdleBorderThickness = 1;
            this.btn_guncelle.IdleCornerRadius = 20;
            this.btn_guncelle.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btn_guncelle.IdleForecolor = System.Drawing.Color.White;
            this.btn_guncelle.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btn_guncelle.Location = new System.Drawing.Point(695, 35);
            this.btn_guncelle.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(243, 55);
            this.btn_guncelle.TabIndex = 83;
            this.btn_guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(669, 275);
            this.dataGridView1.TabIndex = 82;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // K_id
            // 
            this.K_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.K_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.K_id.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.K_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.K_id.HintForeColor = System.Drawing.Color.DimGray;
            this.K_id.HintText = "Kullanıcı Adı";
            this.K_id.isPassword = false;
            this.K_id.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.K_id.LineIdleColor = System.Drawing.Color.Gray;
            this.K_id.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.K_id.LineThickness = 3;
            this.K_id.Location = new System.Drawing.Point(28, 113);
            this.K_id.Margin = new System.Windows.Forms.Padding(4);
            this.K_id.Name = "K_id";
            this.K_id.Size = new System.Drawing.Size(122, 37);
            this.K_id.TabIndex = 81;
            this.K_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.K_id.OnValueChanged += new System.EventHandler(this.K_id_OnValueChanged);
            // 
            // K_parola
            // 
            this.K_parola.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.K_parola.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.K_parola.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.K_parola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.K_parola.HintForeColor = System.Drawing.Color.DimGray;
            this.K_parola.HintText = "Parola";
            this.K_parola.isPassword = false;
            this.K_parola.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.K_parola.LineIdleColor = System.Drawing.Color.Gray;
            this.K_parola.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.K_parola.LineThickness = 3;
            this.K_parola.Location = new System.Drawing.Point(159, 113);
            this.K_parola.Margin = new System.Windows.Forms.Padding(4);
            this.K_parola.Name = "K_parola";
            this.K_parola.Size = new System.Drawing.Size(119, 37);
            this.K_parola.TabIndex = 80;
            this.K_parola.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.K_parola.OnValueChanged += new System.EventHandler(this.K_parola_OnValueChanged);
            // 
            // K_ad
            // 
            this.K_ad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.K_ad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.K_ad.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.K_ad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.K_ad.HintForeColor = System.Drawing.Color.DimGray;
            this.K_ad.HintText = "Adı";
            this.K_ad.isPassword = false;
            this.K_ad.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.K_ad.LineIdleColor = System.Drawing.Color.Gray;
            this.K_ad.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.K_ad.LineThickness = 3;
            this.K_ad.Location = new System.Drawing.Point(286, 113);
            this.K_ad.Margin = new System.Windows.Forms.Padding(4);
            this.K_ad.Name = "K_ad";
            this.K_ad.Size = new System.Drawing.Size(119, 37);
            this.K_ad.TabIndex = 79;
            this.K_ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.K_ad.OnValueChanged += new System.EventHandler(this.K_ad_OnValueChanged);
            // 
            // K_cinsiyet
            // 
            this.K_cinsiyet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.K_cinsiyet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.K_cinsiyet.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.K_cinsiyet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.K_cinsiyet.HintForeColor = System.Drawing.Color.DimGray;
            this.K_cinsiyet.HintText = "Cinsiyeti";
            this.K_cinsiyet.isPassword = false;
            this.K_cinsiyet.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.K_cinsiyet.LineIdleColor = System.Drawing.Color.Gray;
            this.K_cinsiyet.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.K_cinsiyet.LineThickness = 3;
            this.K_cinsiyet.Location = new System.Drawing.Point(828, 113);
            this.K_cinsiyet.Margin = new System.Windows.Forms.Padding(4);
            this.K_cinsiyet.Name = "K_cinsiyet";
            this.K_cinsiyet.Size = new System.Drawing.Size(112, 37);
            this.K_cinsiyet.TabIndex = 78;
            this.K_cinsiyet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.K_cinsiyet.OnValueChanged += new System.EventHandler(this.K_cinsiyet_OnValueChanged);
            // 
            // K_eposta
            // 
            this.K_eposta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.K_eposta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.K_eposta.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.K_eposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.K_eposta.HintForeColor = System.Drawing.Color.DimGray;
            this.K_eposta.HintText = "E-Posta Adresi";
            this.K_eposta.isPassword = false;
            this.K_eposta.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.K_eposta.LineIdleColor = System.Drawing.Color.Gray;
            this.K_eposta.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.K_eposta.LineThickness = 3;
            this.K_eposta.Location = new System.Drawing.Point(560, 113);
            this.K_eposta.Margin = new System.Windows.Forms.Padding(4);
            this.K_eposta.Name = "K_eposta";
            this.K_eposta.Size = new System.Drawing.Size(260, 37);
            this.K_eposta.TabIndex = 77;
            this.K_eposta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.K_eposta.OnValueChanged += new System.EventHandler(this.K_eposta_OnValueChanged);
            // 
            // K_soyad
            // 
            this.K_soyad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.K_soyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.K_soyad.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.K_soyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.K_soyad.HintForeColor = System.Drawing.Color.DimGray;
            this.K_soyad.HintText = "Soyadı";
            this.K_soyad.isPassword = false;
            this.K_soyad.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.K_soyad.LineIdleColor = System.Drawing.Color.Gray;
            this.K_soyad.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.K_soyad.LineThickness = 3;
            this.K_soyad.Location = new System.Drawing.Point(413, 113);
            this.K_soyad.Margin = new System.Windows.Forms.Padding(4);
            this.K_soyad.Name = "K_soyad";
            this.K_soyad.Size = new System.Drawing.Size(139, 37);
            this.K_soyad.TabIndex = 76;
            this.K_soyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.K_soyad.OnValueChanged += new System.EventHandler(this.K_soyad_OnValueChanged);
            // 
            // btn_simge
            // 
            this.btn_simge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btn_simge.Image = ((System.Drawing.Image)(resources.GetObject("btn_simge.Image")));
            this.btn_simge.ImageActive = null;
            this.btn_simge.Location = new System.Drawing.Point(36, 12);
            this.btn_simge.Name = "btn_simge";
            this.btn_simge.Size = new System.Drawing.Size(21, 21);
            this.btn_simge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_simge.TabIndex = 75;
            this.btn_simge.TabStop = false;
            this.btn_simge.Zoom = 10;
            this.btn_simge.Click += new System.EventHandler(this.btn_simge_Click);
            // 
            // btn_tamekran
            // 
            this.btn_tamekran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btn_tamekran.Image = ((System.Drawing.Image)(resources.GetObject("btn_tamekran.Image")));
            this.btn_tamekran.ImageActive = null;
            this.btn_tamekran.Location = new System.Drawing.Point(63, 12);
            this.btn_tamekran.Name = "btn_tamekran";
            this.btn_tamekran.Size = new System.Drawing.Size(21, 21);
            this.btn_tamekran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_tamekran.TabIndex = 74;
            this.btn_tamekran.TabStop = false;
            this.btn_tamekran.Zoom = 10;
            this.btn_tamekran.Click += new System.EventHandler(this.btn_tamekran_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btn_kapat.Image = ((System.Drawing.Image)(resources.GetObject("btn_kapat.Image")));
            this.btn_kapat.ImageActive = null;
            this.btn_kapat.Location = new System.Drawing.Point(9, 12);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(21, 21);
            this.btn_kapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_kapat.TabIndex = 73;
            this.btn_kapat.TabStop = false;
            this.btn_kapat.Zoom = 10;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(940, 420);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.K_id);
            this.Controls.Add(this.K_parola);
            this.Controls.Add(this.K_ad);
            this.Controls.Add(this.K_cinsiyet);
            this.Controls.Add(this.K_eposta);
            this.Controls.Add(this.K_soyad);
            this.Controls.Add(this.btn_simge);
            this.Controls.Add(this.btn_tamekran);
            this.Controls.Add(this.btn_kapat);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_simge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_tamekran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_guncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox K_id;
        private Bunifu.Framework.UI.BunifuMaterialTextbox K_parola;
        private Bunifu.Framework.UI.BunifuMaterialTextbox K_ad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox K_cinsiyet;
        private Bunifu.Framework.UI.BunifuMaterialTextbox K_eposta;
        private Bunifu.Framework.UI.BunifuMaterialTextbox K_soyad;
        private Bunifu.Framework.UI.BunifuImageButton btn_simge;
        private Bunifu.Framework.UI.BunifuImageButton btn_tamekran;
        private Bunifu.Framework.UI.BunifuImageButton btn_kapat;
    }
}