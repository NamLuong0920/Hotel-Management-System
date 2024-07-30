namespace QLKS
{
    partial class GUI_CHECKIN_PHIEUNHANPHONG
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
            this.label8 = new System.Windows.Forms.Label();
            this.dsPhong = new System.Windows.Forms.DataGridView();
            this.dsnguoinhan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dsPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsnguoinhan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Location = new System.Drawing.Point(12, 12);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(134, 47);
            this.btnQuayLai.TabIndex = 18;
            this.btnQuayLai.Text = "QUAY LẠI";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(308, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(343, 38);
            this.label8.TabIndex = 17;
            this.label8.Text = "PHIẾU NHẬN PHÒNG";
            // 
            // dsPhong
            // 
            this.dsPhong.AllowUserToAddRows = false;
            this.dsPhong.AllowUserToDeleteRows = false;
            this.dsPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsPhong.Location = new System.Drawing.Point(55, 155);
            this.dsPhong.Name = "dsPhong";
            this.dsPhong.ReadOnly = true;
            this.dsPhong.RowHeadersWidth = 51;
            this.dsPhong.RowTemplate.Height = 24;
            this.dsPhong.Size = new System.Drawing.Size(191, 223);
            this.dsPhong.TabIndex = 19;
            this.dsPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsPhong_CellContentClick);
            // 
            // dsnguoinhan
            // 
            this.dsnguoinhan.AllowUserToAddRows = false;
            this.dsnguoinhan.AllowUserToDeleteRows = false;
            this.dsnguoinhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsnguoinhan.Location = new System.Drawing.Point(332, 155);
            this.dsnguoinhan.Name = "dsnguoinhan";
            this.dsnguoinhan.ReadOnly = true;
            this.dsnguoinhan.RowHeadersWidth = 51;
            this.dsnguoinhan.RowTemplate.Height = 24;
            this.dsnguoinhan.Size = new System.Drawing.Size(556, 223);
            this.dsnguoinhan.TabIndex = 20;
            // 
            // GUI_CHECKIN_PHIEUNHANPHONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.dsnguoinhan);
            this.Controls.Add(this.dsPhong);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.label8);
            this.Name = "GUI_CHECKIN_PHIEUNHANPHONG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_CHECKIN_PHIEUNHANPHONG";
            this.Load += new System.EventHandler(this.GUI_CHECKIN_PHIEUNHANPHONG_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dsPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsnguoinhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dsPhong;
        private System.Windows.Forms.DataGridView dsnguoinhan;
    }
}