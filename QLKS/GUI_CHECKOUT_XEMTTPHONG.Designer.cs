namespace QLKS
{
    partial class GUI_CHECKOUT_XEMTTPHONG
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
            this.headingCheckOut = new System.Windows.Forms.Label();
            this.lbIDKH = new System.Windows.Forms.Label();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.lbTTPhong = new System.Windows.Forms.Label();
            this.lbTinhTrangPhong = new System.Windows.Forms.Label();
            this.lbDVPhong = new System.Windows.Forms.Label();
            this.dsPhong = new System.Windows.Forms.DataGridView();
            this.dsTinhTrangPhong = new System.Windows.Forms.DataGridView();
            this.dsDVPhong = new System.Windows.Forms.DataGridView();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.BtnQuayLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTinhTrangPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDVPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // headingCheckOut
            // 
            this.headingCheckOut.AutoSize = true;
            this.headingCheckOut.BackColor = System.Drawing.SystemColors.Control;
            this.headingCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.headingCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingCheckOut.Location = new System.Drawing.Point(452, 31);
            this.headingCheckOut.Name = "headingCheckOut";
            this.headingCheckOut.Size = new System.Drawing.Size(466, 51);
            this.headingCheckOut.TabIndex = 2;
            this.headingCheckOut.Text = "Check Out Khách Sạn";
            this.headingCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbIDKH
            // 
            this.lbIDKH.AutoSize = true;
            this.lbIDKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDKH.Location = new System.Drawing.Point(526, 101);
            this.lbIDKH.Name = "lbIDKH";
            this.lbIDKH.Size = new System.Drawing.Size(178, 29);
            this.lbIDKH.TabIndex = 4;
            this.lbIDKH.Text = "ID Khách Hàng:";
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKH.Location = new System.Drawing.Point(710, 101);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(52, 29);
            this.lbMaKH.TabIndex = 5;
            this.lbMaKH.Text = "001";
            this.lbMaKH.Click += new System.EventHandler(this.lbMaKH_Click);
            // 
            // lbTTPhong
            // 
            this.lbTTPhong.AutoSize = true;
            this.lbTTPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTTPhong.Location = new System.Drawing.Point(12, 177);
            this.lbTTPhong.Name = "lbTTPhong";
            this.lbTTPhong.Size = new System.Drawing.Size(196, 25);
            this.lbTTPhong.TabIndex = 6;
            this.lbTTPhong.Text = "Thông tin các phòng:";
            // 
            // lbTinhTrangPhong
            // 
            this.lbTinhTrangPhong.AutoSize = true;
            this.lbTinhTrangPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTinhTrangPhong.Location = new System.Drawing.Point(12, 399);
            this.lbTinhTrangPhong.Name = "lbTinhTrangPhong";
            this.lbTinhTrangPhong.Size = new System.Drawing.Size(202, 25);
            this.lbTinhTrangPhong.TabIndex = 7;
            this.lbTinhTrangPhong.Text = "Tình trạng các phòng:";
            // 
            // lbDVPhong
            // 
            this.lbDVPhong.AutoSize = true;
            this.lbDVPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDVPhong.Location = new System.Drawing.Point(675, 177);
            this.lbDVPhong.Name = "lbDVPhong";
            this.lbDVPhong.Size = new System.Drawing.Size(179, 25);
            this.lbDVPhong.TabIndex = 8;
            this.lbDVPhong.Text = "Dịch vụ các phòng:";
            // 
            // dsPhong
            // 
            this.dsPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsPhong.Location = new System.Drawing.Point(220, 177);
            this.dsPhong.Name = "dsPhong";
            this.dsPhong.RowHeadersWidth = 51;
            this.dsPhong.RowTemplate.Height = 24;
            this.dsPhong.Size = new System.Drawing.Size(418, 182);
            this.dsPhong.TabIndex = 9;
            this.dsPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsPhong_CellContentClick);
            // 
            // dsTinhTrangPhong
            // 
            this.dsTinhTrangPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsTinhTrangPhong.Location = new System.Drawing.Point(220, 399);
            this.dsTinhTrangPhong.Name = "dsTinhTrangPhong";
            this.dsTinhTrangPhong.RowHeadersWidth = 51;
            this.dsTinhTrangPhong.RowTemplate.Height = 24;
            this.dsTinhTrangPhong.Size = new System.Drawing.Size(414, 196);
            this.dsTinhTrangPhong.TabIndex = 10;
            this.dsTinhTrangPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsTinhTrangPhong_CellContentClick);
            // 
            // dsDVPhong
            // 
            this.dsDVPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsDVPhong.Location = new System.Drawing.Point(860, 177);
            this.dsDVPhong.Name = "dsDVPhong";
            this.dsDVPhong.RowHeadersWidth = 51;
            this.dsDVPhong.RowTemplate.Height = 24;
            this.dsDVPhong.Size = new System.Drawing.Size(455, 418);
            this.dsDVPhong.TabIndex = 11;
            this.dsDVPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsDVPhong_CellContentClick);
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTiepTuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiepTuc.Image = global::QLKS.Properties.Resources.continue_button;
            this.btnTiepTuc.Location = new System.Drawing.Point(647, 640);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(193, 47);
            this.btnTiepTuc.TabIndex = 3;
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // BtnQuayLai
            // 
            this.BtnQuayLai.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuayLai.Location = new System.Drawing.Point(26, 31);
            this.BtnQuayLai.Name = "BtnQuayLai";
            this.BtnQuayLai.Size = new System.Drawing.Size(163, 40);
            this.BtnQuayLai.TabIndex = 22;
            this.BtnQuayLai.Text = "Quay lại ";
            this.BtnQuayLai.UseVisualStyleBackColor = true;
            this.BtnQuayLai.Click += new System.EventHandler(this.BtnQuayLai_Click);
            // 
            // GUI_CHECKOUT_XEMTTPHONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.BtnQuayLai);
            this.Controls.Add(this.dsDVPhong);
            this.Controls.Add(this.dsTinhTrangPhong);
            this.Controls.Add(this.dsPhong);
            this.Controls.Add(this.lbDVPhong);
            this.Controls.Add(this.lbTinhTrangPhong);
            this.Controls.Add(this.lbTTPhong);
            this.Controls.Add(this.lbMaKH);
            this.Controls.Add(this.lbIDKH);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.headingCheckOut);
            this.Name = "GUI_CHECKOUT_XEMTTPHONG";
            this.Text = "GUI_CHECKOUT_XEMTTPHONG";
            ((System.ComponentModel.ISupportInitialize)(this.dsPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTinhTrangPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDVPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headingCheckOut;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Label lbIDKH;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Label lbTTPhong;
        private System.Windows.Forms.Label lbTinhTrangPhong;
        private System.Windows.Forms.Label lbDVPhong;
        private System.Windows.Forms.DataGridView dsPhong;
        private System.Windows.Forms.DataGridView dsTinhTrangPhong;
        private System.Windows.Forms.DataGridView dsDVPhong;
        private System.Windows.Forms.Button BtnQuayLai;
    }
}