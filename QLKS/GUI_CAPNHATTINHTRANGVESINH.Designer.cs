namespace QLKS
{
    partial class GUI_CAPNHATTINHTRANGVESINH
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
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbtn_ChuaDonVeSinh = new System.Windows.Forms.RadioButton();
            this.rdbtn_DaDonVeSinh = new System.Windows.Forms.RadioButton();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtSoPhong = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(25, 24);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(148, 60);
            this.btnQuayLai.TabIndex = 0;
            this.btnQuayLai.Text = "QUAY LẠI";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "CẬP NHẬT TÌNH TRẠNG VỆ SINH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tình trạng vệ sinh";
            // 
            // rdbtn_ChuaDonVeSinh
            // 
            this.rdbtn_ChuaDonVeSinh.AutoSize = true;
            this.rdbtn_ChuaDonVeSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_ChuaDonVeSinh.Location = new System.Drawing.Point(374, 343);
            this.rdbtn_ChuaDonVeSinh.Name = "rdbtn_ChuaDonVeSinh";
            this.rdbtn_ChuaDonVeSinh.Size = new System.Drawing.Size(206, 30);
            this.rdbtn_ChuaDonVeSinh.TabIndex = 5;
            this.rdbtn_ChuaDonVeSinh.Text = "Chưa dọn vệ sinh";
            this.rdbtn_ChuaDonVeSinh.UseVisualStyleBackColor = true;
            // 
            // rdbtn_DaDonVeSinh
            // 
            this.rdbtn_DaDonVeSinh.AutoSize = true;
            this.rdbtn_DaDonVeSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_DaDonVeSinh.Location = new System.Drawing.Point(374, 391);
            this.rdbtn_DaDonVeSinh.Name = "rdbtn_DaDonVeSinh";
            this.rdbtn_DaDonVeSinh.Size = new System.Drawing.Size(182, 30);
            this.rdbtn_DaDonVeSinh.TabIndex = 6;
            this.rdbtn_DaDonVeSinh.Text = "Đã dọn vệ sinh";
            this.rdbtn_DaDonVeSinh.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(240, 491);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(182, 64);
            this.btnCapNhat.TabIndex = 7;
            this.btnCapNhat.Text = "CẬP NHẬT";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoPhong.Location = new System.Drawing.Point(374, 246);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(40, 35);
            this.txtSoPhong.TabIndex = 4;
            // 
            // GUI_CAPNHATTINHTRANGVESINH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 644);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.rdbtn_DaDonVeSinh);
            this.Controls.Add(this.rdbtn_ChuaDonVeSinh);
            this.Controls.Add(this.txtSoPhong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuayLai);
            this.Name = "GUI_CAPNHATTINHTRANGVESINH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CẬP NHẬT TÌNH TRẠNG VỆ SINH";
            this.Load += new System.EventHandler(this.GUI_CAPNHATTINHTRANGVESINH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbtn_ChuaDonVeSinh;
        private System.Windows.Forms.RadioButton rdbtn_DaDonVeSinh;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtSoPhong;
    }
}