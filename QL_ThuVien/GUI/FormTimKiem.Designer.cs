namespace GUI
{
    partial class FormTimKiem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MaNCC = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhuVuc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MaNXB = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTG = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnhSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rd_LoaiSach = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.bn_Tim = new System.Windows.Forms.Button();
            this.rd_TacGia = new System.Windows.Forms.RadioButton();
            this.rd_TenSach = new System.Windows.Forms.RadioButton();
            this.txt_TenTK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Nhà cung cấp";
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.ReadOnly = true;
            this.MaNCC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaNCC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MaNCC.Width = 120;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // MaKhuVuc
            // 
            this.MaKhuVuc.DataPropertyName = "MaKhuVuc";
            this.MaKhuVuc.HeaderText = "Khu vực";
            this.MaKhuVuc.Name = "MaKhuVuc";
            this.MaKhuVuc.ReadOnly = true;
            this.MaKhuVuc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaKhuVuc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // MaNXB
            // 
            this.MaNXB.DataPropertyName = "MaNXB";
            this.MaNXB.HeaderText = "Nhà xuất bản";
            this.MaNXB.Name = "MaNXB";
            this.MaNXB.ReadOnly = true;
            this.MaNXB.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaNXB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Width = 50;
            // 
            // MaTG
            // 
            this.MaTG.DataPropertyName = "MaTG";
            this.MaTG.HeaderText = "Tác giả";
            this.MaTG.Name = "MaTG";
            this.MaTG.ReadOnly = true;
            this.MaTG.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaTG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 50;
            // 
            // MaLoai
            // 
            this.MaLoai.DataPropertyName = "MaLoai";
            this.MaLoai.HeaderText = "Loại Sách";
            this.MaLoai.Name = "MaLoai";
            this.MaLoai.ReadOnly = true;
            this.MaLoai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaLoai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            this.TenSach.Width = 150;
            // 
            // HinhAnhSach
            // 
            this.HinhAnhSach.DataPropertyName = "HinhAnhSach";
            this.HinhAnhSach.HeaderText = "Hình ảnh";
            this.HinhAnhSach.Name = "HinhAnhSach";
            this.HinhAnhSach.ReadOnly = true;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            this.MaSach.Width = 70;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1198, 273);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tìm kiếm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.MaLoai,
            this.SoLuong,
            this.MoTa,
            this.MaTG,
            this.TrangThai,
            this.MaNXB,
            this.MaKhuVuc,
            this.Gia,
            this.HinhAnhSach,
            this.MaNCC});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1172, 228);
            this.dataGridView1.TabIndex = 1;
            // 
            // rd_LoaiSach
            // 
            this.rd_LoaiSach.AutoSize = true;
            this.rd_LoaiSach.Location = new System.Drawing.Point(735, 94);
            this.rd_LoaiSach.Name = "rd_LoaiSach";
            this.rd_LoaiSach.Size = new System.Drawing.Size(85, 23);
            this.rd_LoaiSach.TabIndex = 15;
            this.rd_LoaiSach.TabStop = true;
            this.rd_LoaiSach.Text = "Loại sách";
            this.rd_LoaiSach.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = global::GUI.Properties.Resources.btHuy;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(846, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 63);
            this.button1.TabIndex = 14;
            this.button1.Text = "Thoát";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // bn_Tim
            // 
            this.bn_Tim.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bn_Tim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_Tim.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_Tim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bn_Tim.Image = global::GUI.Properties.Resources.Zerode_Plump_Search;
            this.bn_Tim.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bn_Tim.Location = new System.Drawing.Point(846, 38);
            this.bn_Tim.Name = "bn_Tim";
            this.bn_Tim.Size = new System.Drawing.Size(124, 57);
            this.bn_Tim.TabIndex = 13;
            this.bn_Tim.Text = "Tìm kiếm";
            this.bn_Tim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bn_Tim.UseVisualStyleBackColor = false;
            this.bn_Tim.Click += new System.EventHandler(this.bn_Tim_Click);
            // 
            // rd_TacGia
            // 
            this.rd_TacGia.AutoSize = true;
            this.rd_TacGia.Location = new System.Drawing.Point(547, 94);
            this.rd_TacGia.Name = "rd_TacGia";
            this.rd_TacGia.Size = new System.Drawing.Size(71, 23);
            this.rd_TacGia.TabIndex = 12;
            this.rd_TacGia.TabStop = true;
            this.rd_TacGia.Text = "Tác giả";
            this.rd_TacGia.UseVisualStyleBackColor = true;
            // 
            // rd_TenSach
            // 
            this.rd_TenSach.AutoSize = true;
            this.rd_TenSach.Location = new System.Drawing.Point(638, 94);
            this.rd_TenSach.Name = "rd_TenSach";
            this.rd_TenSach.Size = new System.Drawing.Size(81, 23);
            this.rd_TenSach.TabIndex = 11;
            this.rd_TenSach.TabStop = true;
            this.rd_TenSach.Text = "Tên sách";
            this.rd_TenSach.UseVisualStyleBackColor = true;
            // 
            // txt_TenTK
            // 
            this.txt_TenTK.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_TenTK.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.txt_TenTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenTK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TenTK.Location = new System.Drawing.Point(539, 54);
            this.txt_TenTK.Name = "txt_TenTK";
            this.txt_TenTK.Size = new System.Drawing.Size(281, 21);
            this.txt_TenTK.TabIndex = 8;
            this.txt_TenTK.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_TenTK_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(456, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GUI.Properties.Resources.sachTim;
            this.panel1.Location = new System.Drawing.Point(31, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 237);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_LoaiSach);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.bn_Tim);
            this.groupBox1.Controls.Add(this.rd_TacGia);
            this.groupBox1.Controls.Add(this.rd_TenSach);
            this.groupBox1.Controls.Add(this.txt_TenTK);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1004, 277);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm thông tin";
            // 
            // FormTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormTimKiem";
            this.Text = "TÌM KIẾM";
            this.Load += new System.EventHandler(this.FormTimKiem_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewComboBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaKhuVuc;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhAnhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rd_LoaiSach;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bn_Tim;
        private System.Windows.Forms.RadioButton rd_TacGia;
        private System.Windows.Forms.RadioButton rd_TenSach;
        private System.Windows.Forms.TextBox txt_TenTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}