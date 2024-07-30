namespace QLKS
{
    partial class GUI_DANGNHAP
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_username = new System.Windows.Forms.TextBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Btn_login = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btxExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHÀO MỪNG BẠN QUAY TRỞ LẠI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "ĐĂNG NHẬP ĐỂ TIẾP TỤC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "TÊN ĐĂNG NHẬP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 539);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "MẬT KHẨU";
            // 
            // Txt_username
            // 
            this.Txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_username.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Txt_username.Location = new System.Drawing.Point(24, 479);
            this.Txt_username.Name = "Txt_username";
            this.Txt_username.Size = new System.Drawing.Size(505, 29);
            this.Txt_username.TabIndex = 6;
            // 
            // Txt_Password
            // 
            this.Txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Password.Location = new System.Drawing.Point(24, 591);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '*';
            this.Txt_Password.Size = new System.Drawing.Size(505, 36);
            this.Txt_Password.TabIndex = 7;
            // 
            // Btn_login
            // 
            this.Btn_login.Image = global::QLKS.Properties.Resources.login_button_alt;
            this.Btn_login.InitialImage = global::QLKS.Properties.Resources.login_hover;
            this.Btn_login.Location = new System.Drawing.Point(65, 662);
            this.Btn_login.Name = "Btn_login";
            this.Btn_login.Size = new System.Drawing.Size(437, 126);
            this.Btn_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Btn_login.TabIndex = 10;
            this.Btn_login.TabStop = false;
            this.Btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // logo
            // 
            this.logo.Image = global::QLKS.Properties.Resources.logo_only;
            this.logo.Location = new System.Drawing.Point(199, 115);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(140, 140);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            // 
            // btxExit
            // 
            this.btxExit.BackgroundImage = global::QLKS.Properties.Resources.close;
            this.btxExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btxExit.Location = new System.Drawing.Point(488, 12);
            this.btxExit.Name = "btxExit";
            this.btxExit.Size = new System.Drawing.Size(71, 51);
            this.btxExit.TabIndex = 11;
            this.btxExit.Text = "\\";
            this.btxExit.UseVisualStyleBackColor = true;
            this.btxExit.Click += new System.EventHandler(this.btxExit_Click);
            // 
            // GUI_DANGNHAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 874);
            this.ControlBox = false;
            this.Controls.Add(this.btxExit);
            this.Controls.Add(this.Btn_login);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Txt_username);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GUI_DANGNHAP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP ";
            this.Load += new System.EventHandler(this.GUI_DANGNHAP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_username;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.PictureBox Btn_login;
        private System.Windows.Forms.Button btxExit;
    }
}