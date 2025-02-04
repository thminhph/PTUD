namespace DoAnPTUD
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.txtDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lbDangNhap = new System.Windows.Forms.Label();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lkDangKy = new System.Windows.Forms.LinkLabel();
            this.btnDangNhap = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHide = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDangNhap
            // 
            this.txtDangNhap.BackColor = System.Drawing.Color.RosyBrown;
            this.txtDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDangNhap.Location = new System.Drawing.Point(404, 584);
            this.txtDangNhap.Multiline = true;
            this.txtDangNhap.Name = "txtDangNhap";
            this.txtDangNhap.Size = new System.Drawing.Size(418, 48);
            this.txtDangNhap.TabIndex = 0;
            this.txtDangNhap.TextChanged += new System.EventHandler(this.txtDangNhap_TextChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.RosyBrown;
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(404, 706);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(418, 48);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // lbDangNhap
            // 
            this.lbDangNhap.AutoSize = true;
            this.lbDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangNhap.ForeColor = System.Drawing.Color.Black;
            this.lbDangNhap.Location = new System.Drawing.Point(398, 552);
            this.lbDangNhap.Name = "lbDangNhap";
            this.lbDangNhap.Size = new System.Drawing.Size(175, 29);
            this.lbDangNhap.TabIndex = 2;
            this.lbDangNhap.Text = "Tên đăng nhập";
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhau.ForeColor = System.Drawing.Color.Black;
            this.lbMatKhau.Location = new System.Drawing.Point(398, 672);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(109, 29);
            this.lbMatKhau.TabIndex = 3;
            this.lbMatKhau.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(320, 473);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(936, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "CHÀO MỪNG BẠN ĐẾN VỚI MKP BANK";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lkDangKy
            // 
            this.lkDangKy.AutoSize = true;
            this.lkDangKy.LinkColor = System.Drawing.Color.Red;
            this.lkDangKy.Location = new System.Drawing.Point(399, 758);
            this.lkDangKy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lkDangKy.Name = "lkDangKy";
            this.lkDangKy.Size = new System.Drawing.Size(105, 20);
            this.lkDangKy.TabIndex = 7;
            this.lkDangKy.TabStop = true;
            this.lkDangKy.Text = "Tạo tài khoản";
            this.lkDangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkDangKy_LinkClicked);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BorderRadius = 20;
            this.btnDangNhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangNhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.Black;
            this.btnDangNhap.Location = new System.Drawing.Point(495, 802);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(207, 66);
            this.btnDangNhap.TabIndex = 9;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::DoAnPTUD.Properties.Resources.LoGo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(18, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1164, 432);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.Transparent;
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.ForeColor = System.Drawing.Color.Transparent;
            this.btnHide.ImageIndex = 8;
            this.btnHide.ImageList = this.imageList1;
            this.btnHide.Location = new System.Drawing.Point(816, 706);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(53, 48);
            this.btnHide.TabIndex = 10;
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Finance-Bank-Cards-icon.png");
            this.imageList1.Images.SetKeyName(1, "Aniket-Suvarna-Box-Regular-Bx-user.512.png");
            this.imageList1.Images.SetKeyName(2, "Colebemis-Feather-Delete.512.png");
            this.imageList1.Images.SetKeyName(3, "Custom-Icon-Design-Pretty-Office-2-Search.256.png");
            this.imageList1.Images.SetKeyName(4, "Custom-Icon-Design-Pretty-Office-8-Accept.256.png");
            this.imageList1.Images.SetKeyName(5, "Fa-Team-Fontawesome-FontAwesome-Money-Bill-Transfer.512.png");
            this.imageList1.Images.SetKeyName(6, "Github-Octicons-Clock-24.512.png");
            this.imageList1.Images.SetKeyName(7, "Github-Octicons-Eye-24.512.png");
            this.imageList1.Images.SetKeyName(8, "Github-Octicons-Eye-closed-24.512.png");
            this.imageList1.Images.SetKeyName(9, "Github-Octicons-Globe-16.512.png");
            this.imageList1.Images.SetKeyName(10, "Github-Octicons-Graph-16.512.png");
            this.imageList1.Images.SetKeyName(11, "Icons8-Ios7-Finance-Money-Bag.512.png");
            this.imageList1.Images.SetKeyName(12, "Icons8-Windows-8-Animals-Dinosaur.512.png");
            this.imageList1.Images.SetKeyName(13, "Icons8-Windows-8-Finance-Bank-Cards.512.png");
            this.imageList1.Images.SetKeyName(14, "Icons8-Windows-8-Food-List-Ingredients.512.png");
            this.imageList1.Images.SetKeyName(15, "Icons8-Windows-8-Very-Basic-Menu.512.png");
            this.imageList1.Images.SetKeyName(16, "Iconsmind-Outline-Arrow-Back-3.512.png");
            this.imageList1.Images.SetKeyName(17, "Iconsmind-Outline-Bank.512.png");
            this.imageList1.Images.SetKeyName(18, "Ionic-Ionicons-Camera-outline.512.png");
            this.imageList1.Images.SetKeyName(19, "Ionic-Ionicons-Log-out-outline.512.png");
            this.imageList1.Images.SetKeyName(20, "logo.jpg");
            this.imageList1.Images.SetKeyName(21, "mau-hinh-trong-chung-khoan-7.jpg");
            this.imageList1.Images.SetKeyName(22, "Microsoft-Fluentui-Emoji-Mono-Mobile-Phone-With-Arrow.512.png");
            this.imageList1.Images.SetKeyName(23, "Papirus-Team-Papirus-Apps-Preferences-desktop-notification-bell.512.png");
            this.imageList1.Images.SetKeyName(24, "Pictogrammers-Material-Card-account-details.512.png");
            this.imageList1.Images.SetKeyName(25, "Pictogrammers-Material-Crown-circle-outline.512.png");
            this.imageList1.Images.SetKeyName(26, "Pictogrammers-Material-Information.512.png");
            this.imageList1.Images.SetKeyName(27, "Pictogrammers-Material-Light-Chevron-right.512.png");
            this.imageList1.Images.SetKeyName(28, "Pictogrammers-Material-Light-Settings.512.png");
            this.imageList1.Images.SetKeyName(29, "Pictogrammers-Material-Qrcode-scan.512.png");
            this.imageList1.Images.SetKeyName(30, "user.jpg");
            this.imageList1.Images.SetKeyName(31, "z5881071855756_8a0244d0603e51520488a519a5f1ae24.jpg");
            // 
            // DangNhap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1200, 932);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.lkDangKy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.lbDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtDangNhap);
            this.ForeColor = System.Drawing.Color.Cyan;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lbDangNhap;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lkDangKy;
        private Guna.UI2.WinForms.Guna2Button btnDangNhap;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.ImageList imageList1;
    }
}