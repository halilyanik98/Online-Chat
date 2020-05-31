namespace OnlineChat
{
    partial class sifre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sifre));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_simge = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_tamekran = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_kapat = new Bunifu.Framework.UI.BunifuImageButton();
            this.tb_eposta = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_talep = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tb_id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
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
            // btn_simge
            // 
            this.btn_simge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btn_simge.Image = ((System.Drawing.Image)(resources.GetObject("btn_simge.Image")));
            this.btn_simge.ImageActive = null;
            this.btn_simge.Location = new System.Drawing.Point(42, 7);
            this.btn_simge.Name = "btn_simge";
            this.btn_simge.Size = new System.Drawing.Size(21, 21);
            this.btn_simge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_simge.TabIndex = 49;
            this.btn_simge.TabStop = false;
            this.btn_simge.Zoom = 10;
            this.btn_simge.Click += new System.EventHandler(this.btn_simge_Click);
            // 
            // btn_tamekran
            // 
            this.btn_tamekran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btn_tamekran.Image = ((System.Drawing.Image)(resources.GetObject("btn_tamekran.Image")));
            this.btn_tamekran.ImageActive = null;
            this.btn_tamekran.Location = new System.Drawing.Point(69, 7);
            this.btn_tamekran.Name = "btn_tamekran";
            this.btn_tamekran.Size = new System.Drawing.Size(21, 21);
            this.btn_tamekran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_tamekran.TabIndex = 48;
            this.btn_tamekran.TabStop = false;
            this.btn_tamekran.Zoom = 10;
            this.btn_tamekran.Click += new System.EventHandler(this.btn_tamekran_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btn_kapat.Image = ((System.Drawing.Image)(resources.GetObject("btn_kapat.Image")));
            this.btn_kapat.ImageActive = null;
            this.btn_kapat.Location = new System.Drawing.Point(15, 7);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(21, 21);
            this.btn_kapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_kapat.TabIndex = 47;
            this.btn_kapat.TabStop = false;
            this.btn_kapat.Zoom = 10;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // tb_eposta
            // 
            this.tb_eposta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_eposta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_eposta.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_eposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_eposta.HintForeColor = System.Drawing.Color.DimGray;
            this.tb_eposta.HintText = "E-Posta Adresiniz";
            this.tb_eposta.isPassword = false;
            this.tb_eposta.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.tb_eposta.LineIdleColor = System.Drawing.Color.Gray;
            this.tb_eposta.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.tb_eposta.LineThickness = 3;
            this.tb_eposta.Location = new System.Drawing.Point(63, 153);
            this.tb_eposta.Margin = new System.Windows.Forms.Padding(4);
            this.tb_eposta.Name = "tb_eposta";
            this.tb_eposta.Size = new System.Drawing.Size(277, 37);
            this.tb_eposta.TabIndex = 44;
            this.tb_eposta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_eposta.OnValueChanged += new System.EventHandler(this.tb_eposta_OnValueChanged);
            // 
            // btn_talep
            // 
            this.btn_talep.ActiveBorderThickness = 1;
            this.btn_talep.ActiveCornerRadius = 20;
            this.btn_talep.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btn_talep.ActiveForecolor = System.Drawing.Color.Silver;
            this.btn_talep.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btn_talep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_talep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btn_talep.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_talep.BackgroundImage")));
            this.btn_talep.ButtonText = "Şifreyi İste";
            this.btn_talep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_talep.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_talep.ForeColor = System.Drawing.Color.White;
            this.btn_talep.IdleBorderThickness = 1;
            this.btn_talep.IdleCornerRadius = 20;
            this.btn_talep.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btn_talep.IdleForecolor = System.Drawing.Color.White;
            this.btn_talep.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btn_talep.Location = new System.Drawing.Point(116, 222);
            this.btn_talep.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_talep.Name = "btn_talep";
            this.btn_talep.Size = new System.Drawing.Size(174, 55);
            this.btn_talep.TabIndex = 45;
            this.btn_talep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_talep.Click += new System.EventHandler(this.btn_talep_Click);
            // 
            // tb_id
            // 
            this.tb_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_id.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_id.HintForeColor = System.Drawing.Color.DimGray;
            this.tb_id.HintText = "Kullanıcı Adınız";
            this.tb_id.isPassword = false;
            this.tb_id.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.tb_id.LineIdleColor = System.Drawing.Color.Gray;
            this.tb_id.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.tb_id.LineThickness = 3;
            this.tb_id.Location = new System.Drawing.Point(63, 80);
            this.tb_id.Margin = new System.Windows.Forms.Padding(4);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(277, 37);
            this.tb_id.TabIndex = 43;
            this.tb_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_id.OnValueChanged += new System.EventHandler(this.tb_id_OnValueChanged);
            // 
            // sifre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(400, 325);
            this.Controls.Add(this.btn_simge);
            this.Controls.Add(this.btn_tamekran);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.tb_eposta);
            this.Controls.Add(this.btn_talep);
            this.Controls.Add(this.tb_id);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "sifre";
            this.Text = "sifre";
            this.Load += new System.EventHandler(this.sifre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_simge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_tamekran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton btn_simge;
        private Bunifu.Framework.UI.BunifuImageButton btn_tamekran;
        private Bunifu.Framework.UI.BunifuImageButton btn_kapat;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_eposta;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_talep;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_id;
    }
}