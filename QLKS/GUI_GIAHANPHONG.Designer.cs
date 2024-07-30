namespace QLKS
{
    partial class GUI_GIAHANPHONG
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
            this.btnXemDSGiaHanPhong = new System.Windows.Forms.Button();
            this.btnLapPhieuGiaHanPhong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXemDSGiaHanPhong
            // 
            this.btnXemDSGiaHanPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDSGiaHanPhong.Location = new System.Drawing.Point(51, 174);
            this.btnXemDSGiaHanPhong.Name = "btnXemDSGiaHanPhong";
            this.btnXemDSGiaHanPhong.Size = new System.Drawing.Size(255, 160);
            this.btnXemDSGiaHanPhong.TabIndex = 0;
            this.btnXemDSGiaHanPhong.Text = "XEM DANH SÁCH GIA HẠN PHÒNG";
            this.btnXemDSGiaHanPhong.UseVisualStyleBackColor = true;
            this.btnXemDSGiaHanPhong.Click += new System.EventHandler(this.btnXemDSGiaHanPhong_Click);
            // 
            // btnLapPhieuGiaHanPhong
            // 
            this.btnLapPhieuGiaHanPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapPhieuGiaHanPhong.Location = new System.Drawing.Point(363, 174);
            this.btnLapPhieuGiaHanPhong.Name = "btnLapPhieuGiaHanPhong";
            this.btnLapPhieuGiaHanPhong.Size = new System.Drawing.Size(255, 160);
            this.btnLapPhieuGiaHanPhong.TabIndex = 1;
            this.btnLapPhieuGiaHanPhong.Text = "LẬP PHIẾU GIA HẠN PHÒNG";
            this.btnLapPhieuGiaHanPhong.UseVisualStyleBackColor = true;
            this.btnLapPhieuGiaHanPhong.Click += new System.EventHandler(this.btnLapPhieuGiaHanPhong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "CHỌN CHỨC NĂNG";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(12, 12);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(184, 46);
            this.btnQuayLai.TabIndex = 3;
            this.btnQuayLai.Text = "QUAY LẠI";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // GUI_GIAHANPHONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 394);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLapPhieuGiaHanPhong);
            this.Controls.Add(this.btnXemDSGiaHanPhong);
            this.Name = "GUI_GIAHANPHONG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GIA HẠN PHÒNG";
            this.Load += new System.EventHandler(this.GUI_GIAHANPHONG_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXemDSGiaHanPhong;
        private System.Windows.Forms.Button btnLapPhieuGiaHanPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuayLai;
    }
}