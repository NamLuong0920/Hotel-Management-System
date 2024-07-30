namespace QLKS
{
    partial class GUI_PHIEUTRAPHONG
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
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.headingCheckOut = new System.Windows.Forms.Label();
            this.lbMaPhong = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.BtnQuayLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTiepTuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiepTuc.Image = global::QLKS.Properties.Resources.continue_button;
            this.btnTiepTuc.Location = new System.Drawing.Point(597, 578);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(208, 58);
            this.btnTiepTuc.TabIndex = 0;
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // headingCheckOut
            // 
            this.headingCheckOut.AutoSize = true;
            this.headingCheckOut.BackColor = System.Drawing.SystemColors.Control;
            this.headingCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.headingCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingCheckOut.Location = new System.Drawing.Point(474, 39);
            this.headingCheckOut.Name = "headingCheckOut";
            this.headingCheckOut.Size = new System.Drawing.Size(466, 51);
            this.headingCheckOut.TabIndex = 1;
            this.headingCheckOut.Text = "Check Out Khách Sạn";
            this.headingCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMaPhong
            // 
            this.lbMaPhong.AutoSize = true;
            this.lbMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPhong.Location = new System.Drawing.Point(331, 307);
            this.lbMaPhong.Name = "lbMaPhong";
            this.lbMaPhong.Size = new System.Drawing.Size(126, 29);
            this.lbMaPhong.TabIndex = 2;
            this.lbMaPhong.Text = "Mã phòng:";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhong.Location = new System.Drawing.Point(483, 307);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(462, 34);
            this.txtMaPhong.TabIndex = 3;
            // 
            // BtnQuayLai
            // 
            this.BtnQuayLai.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuayLai.Location = new System.Drawing.Point(48, 39);
            this.BtnQuayLai.Name = "BtnQuayLai";
            this.BtnQuayLai.Size = new System.Drawing.Size(163, 40);
            this.BtnQuayLai.TabIndex = 21;
            this.BtnQuayLai.Text = "Quay lại ";
            this.BtnQuayLai.UseVisualStyleBackColor = true;
            this.BtnQuayLai.Click += new System.EventHandler(this.BtnQuayLai_Click);
            // 
            // GUI_PHIEUTRAPHONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.BtnQuayLai);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.lbMaPhong);
            this.Controls.Add(this.headingCheckOut);
            this.Controls.Add(this.btnTiepTuc);
            this.Name = "GUI_PHIEUTRAPHONG";
            this.Text = "GUI_PHIEUTRAPHONG";
            this.Load += new System.EventHandler(this.GUI_PHIEUTRAPHONG_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Label headingCheckOut;
        private System.Windows.Forms.Label lbMaPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Button BtnQuayLai;
    }
}