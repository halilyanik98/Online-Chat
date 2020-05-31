namespace OnlineChat
{
    partial class onay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(onay));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_kapat = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_onay = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_talep = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btn_kapat.Image = ((System.Drawing.Image)(resources.GetObject("btn_kapat.Image")));
            this.btn_kapat.ImageActive = null;
            this.btn_kapat.Location = new System.Drawing.Point(14, 9);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(21, 21);
            this.btn_kapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_kapat.TabIndex = 45;
            this.btn_kapat.TabStop = false;
            this.btn_kapat.Zoom = 10;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(76, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 15);
            this.label1.TabIndex = 44;
            this.label1.Text = "E-Posta Adresinize Gelen Onay Kodunu Giriniz";
            // 
            // tb_onay
            // 
            this.tb_onay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_onay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_onay.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_onay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_onay.HintForeColor = System.Drawing.Color.DimGray;
            this.tb_onay.HintText = "Onay Kodu";
            this.tb_onay.isPassword = false;
            this.tb_onay.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.tb_onay.LineIdleColor = System.Drawing.Color.Gray;
            this.tb_onay.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.tb_onay.LineThickness = 3;
            this.tb_onay.Location = new System.Drawing.Point(119, 78);
            this.tb_onay.Margin = new System.Windows.Forms.Padding(4);
            this.tb_onay.Name = "tb_onay";
            this.tb_onay.Size = new System.Drawing.Size(174, 37);
            this.tb_onay.TabIndex = 43;
            this.tb_onay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_onay.OnValueChanged += new System.EventHandler(this.tb_onay_OnValueChanged);
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
            this.btn_talep.ButtonText = "Kaydı Tamamla";
            this.btn_talep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_talep.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_talep.ForeColor = System.Drawing.Color.White;
            this.btn_talep.IdleBorderThickness = 1;
            this.btn_talep.IdleCornerRadius = 20;
            this.btn_talep.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btn_talep.IdleForecolor = System.Drawing.Color.White;
            this.btn_talep.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.btn_talep.Location = new System.Drawing.Point(119, 126);
            this.btn_talep.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_talep.Name = "btn_talep";
            this.btn_talep.Size = new System.Drawing.Size(174, 55);
            this.btn_talep.TabIndex = 42;
            this.btn_talep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_talep.Click += new System.EventHandler(this.btn_talep_Click);
            // 
            // onay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_onay);
            this.Controls.Add(this.btn_talep);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "onay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "onay";
            this.Load += new System.EventHandler(this.onay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_kapat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton btn_kapat;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_onay;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_talep;
    }
}