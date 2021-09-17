namespace GUI
{
    partial class FormTraSach
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
            this.btdangky = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_MaSach = new System.Windows.Forms.TextBox();
            this.bn_LuuCTTra = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.MaPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TinhTrangSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiPhiDenBu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_DenBu = new System.Windows.Forms.Label();
            this.txt_TinhTrang = new System.Windows.Forms.TextBox();
            this.txt_SLTra = new System.Windows.Forms.TextBox();
            this.txt_MaPM = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bn_LuuPhieuTra = new System.Windows.Forms.Button();
            this.txt_TienBoiThuong = new System.Windows.Forms.Label();
            this.txt_NgayTra = new System.Windows.Forms.DateTimePicker();
            this.txt_TongSLTra = new System.Windows.Forms.TextBox();
            this.txt_MaPT = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.MaPTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTraSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTraSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTienDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SoLuongMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sach = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btdangky
            // 
            this.btdangky.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btdangky.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btdangky.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdangky.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btdangky.Image = global::GUI.Properties.Resources.Icons8_Windows_8_Ecommerce_Bill;
            this.btdangky.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btdangky.Location = new System.Drawing.Point(330, 25);
            this.btdangky.Name = "btdangky";
            this.btdangky.Size = new System.Drawing.Size(75, 63);
            this.btdangky.TabIndex = 26;
            this.btdangky.Text = "Tạo phiếu";
            this.btdangky.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btdangky.UseVisualStyleBackColor = false;
            this.btdangky.Click += new System.EventHandler(this.btdangky_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_MaSach);
            this.groupBox3.Controls.Add(this.bn_LuuCTTra);
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.Controls.Add(this.txt_DenBu);
            this.groupBox3.Controls.Add(this.txt_TinhTrang);
            this.groupBox3.Controls.Add(this.txt_SLTra);
            this.groupBox3.Controls.Add(this.txt_MaPM);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(10, 272);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(657, 330);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết trả";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(161, 121);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 19);
            this.label12.TabIndex = 32;
            this.label12.Text = "VND";
            // 
            // txt_MaSach
            // 
            this.txt_MaSach.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_MaSach.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.txt_MaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaSach.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_MaSach.Location = new System.Drawing.Point(120, 56);
            this.txt_MaSach.Name = "txt_MaSach";
            this.txt_MaSach.Size = new System.Drawing.Size(377, 21);
            this.txt_MaSach.TabIndex = 31;
            // 
            // bn_LuuCTTra
            // 
            this.bn_LuuCTTra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bn_LuuCTTra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_LuuCTTra.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_LuuCTTra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bn_LuuCTTra.Image = global::GUI.Properties.Resources.UpdateIco;
            this.bn_LuuCTTra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bn_LuuCTTra.Location = new System.Drawing.Point(525, 25);
            this.bn_LuuCTTra.Name = "bn_LuuCTTra";
            this.bn_LuuCTTra.Size = new System.Drawing.Size(75, 63);
            this.bn_LuuCTTra.TabIndex = 30;
            this.bn_LuuCTTra.Text = "Update";
            this.bn_LuuCTTra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bn_LuuCTTra.UseVisualStyleBackColor = false;
            this.bn_LuuCTTra.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPT,
            this.MaPMuon,
            this.MaSach,
            this.TinhTrangSach,
            this.SoLuongTra,
            this.ChiPhiDenBu});
            this.dataGridView3.Location = new System.Drawing.Point(12, 162);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(636, 150);
            this.dataGridView3.TabIndex = 26;
            // 
            // MaPT
            // 
            this.MaPT.DataPropertyName = "MaPT";
            this.MaPT.HeaderText = "Mã phiếu trả";
            this.MaPT.Name = "MaPT";
            this.MaPT.ReadOnly = true;
            // 
            // MaPMuon
            // 
            this.MaPMuon.DataPropertyName = "MaPM";
            this.MaPMuon.HeaderText = "Mã phiếu mượn";
            this.MaPMuon.Name = "MaPMuon";
            this.MaPMuon.ReadOnly = true;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Tên sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            this.MaSach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaSach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TinhTrangSach
            // 
            this.TinhTrangSach.DataPropertyName = "TinhTrangSach";
            this.TinhTrangSach.HeaderText = "Tình trạng";
            this.TinhTrangSach.Name = "TinhTrangSach";
            this.TinhTrangSach.ReadOnly = true;
            // 
            // SoLuongTra
            // 
            this.SoLuongTra.DataPropertyName = "SoLuongTra";
            this.SoLuongTra.HeaderText = "Số lượng trả";
            this.SoLuongTra.Name = "SoLuongTra";
            this.SoLuongTra.ReadOnly = true;
            // 
            // ChiPhiDenBu
            // 
            this.ChiPhiDenBu.DataPropertyName = "ChiPhiDenBu";
            this.ChiPhiDenBu.HeaderText = "Chi phí đền bù";
            this.ChiPhiDenBu.Name = "ChiPhiDenBu";
            this.ChiPhiDenBu.ReadOnly = true;
            // 
            // txt_DenBu
            // 
            this.txt_DenBu.AutoSize = true;
            this.txt_DenBu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DenBu.Location = new System.Drawing.Point(123, 120);
            this.txt_DenBu.Name = "txt_DenBu";
            this.txt_DenBu.Size = new System.Drawing.Size(17, 19);
            this.txt_DenBu.TabIndex = 29;
            this.txt_DenBu.Text = "0";
            // 
            // txt_TinhTrang
            // 
            this.txt_TinhTrang.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_TinhTrang.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.txt_TinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TinhTrang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TinhTrang.Location = new System.Drawing.Point(120, 87);
            this.txt_TinhTrang.Name = "txt_TinhTrang";
            this.txt_TinhTrang.Size = new System.Drawing.Size(377, 21);
            this.txt_TinhTrang.TabIndex = 28;
            // 
            // txt_SLTra
            // 
            this.txt_SLTra.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_SLTra.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.txt_SLTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SLTra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_SLTra.Location = new System.Drawing.Point(376, 26);
            this.txt_SLTra.Name = "txt_SLTra";
            this.txt_SLTra.Size = new System.Drawing.Size(121, 21);
            this.txt_SLTra.TabIndex = 27;
            this.txt_SLTra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MaSV_KeyPress);
            // 
            // txt_MaPM
            // 
            this.txt_MaPM.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_MaPM.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.txt_MaPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaPM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_MaPM.Location = new System.Drawing.Point(120, 29);
            this.txt_MaPM.Name = "txt_MaPM";
            this.txt_MaPM.Size = new System.Drawing.Size(176, 21);
            this.txt_MaPM.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = "Chi phí đền bù:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(303, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Số lượng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tình trạng sách:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sách:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mã phiếu mượn:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.bn_LuuPhieuTra);
            this.groupBox2.Controls.Add(this.btdangky);
            this.groupBox2.Controls.Add(this.txt_TienBoiThuong);
            this.groupBox2.Controls.Add(this.txt_NgayTra);
            this.groupBox2.Controls.Add(this.txt_TongSLTra);
            this.groupBox2.Controls.Add(this.txt_MaPT);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(673, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 395);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TRẢ SÁCH";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(281, 125);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 19);
            this.label11.TabIndex = 28;
            this.label11.Text = "VND";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // bn_LuuPhieuTra
            // 
            this.bn_LuuPhieuTra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bn_LuuPhieuTra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_LuuPhieuTra.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_LuuPhieuTra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bn_LuuPhieuTra.Image = global::GUI.Properties.Resources.SAVEADD;
            this.bn_LuuPhieuTra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bn_LuuPhieuTra.Location = new System.Drawing.Point(330, 94);
            this.bn_LuuPhieuTra.Name = "bn_LuuPhieuTra";
            this.bn_LuuPhieuTra.Size = new System.Drawing.Size(75, 63);
            this.bn_LuuPhieuTra.TabIndex = 27;
            this.bn_LuuPhieuTra.Text = "Lưu";
            this.bn_LuuPhieuTra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bn_LuuPhieuTra.UseVisualStyleBackColor = false;
            this.bn_LuuPhieuTra.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_TienBoiThuong
            // 
            this.txt_TienBoiThuong.AutoSize = true;
            this.txt_TienBoiThuong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TienBoiThuong.ForeColor = System.Drawing.Color.Red;
            this.txt_TienBoiThuong.Location = new System.Drawing.Point(232, 125);
            this.txt_TienBoiThuong.Name = "txt_TienBoiThuong";
            this.txt_TienBoiThuong.Size = new System.Drawing.Size(20, 22);
            this.txt_TienBoiThuong.TabIndex = 25;
            this.txt_TienBoiThuong.Text = "0";
            // 
            // txt_NgayTra
            // 
            this.txt_NgayTra.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.txt_NgayTra.CalendarTitleBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_NgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_NgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_NgayTra.Location = new System.Drawing.Point(168, 57);
            this.txt_NgayTra.Name = "txt_NgayTra";
            this.txt_NgayTra.Size = new System.Drawing.Size(86, 21);
            this.txt_NgayTra.TabIndex = 24;
            // 
            // txt_TongSLTra
            // 
            this.txt_TongSLTra.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_TongSLTra.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.txt_TongSLTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TongSLTra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TongSLTra.Location = new System.Drawing.Point(168, 84);
            this.txt_TongSLTra.Name = "txt_TongSLTra";
            this.txt_TongSLTra.Size = new System.Drawing.Size(156, 21);
            this.txt_TongSLTra.TabIndex = 12;
            // 
            // txt_MaPT
            // 
            this.txt_MaPT.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_MaPT.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.txt_MaPT.Enabled = false;
            this.txt_MaPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaPT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_MaPT.Location = new System.Drawing.Point(168, 30);
            this.txt_MaPT.Name = "txt_MaPT";
            this.txt_MaPT.Size = new System.Drawing.Size(156, 21);
            this.txt_MaPT.TabIndex = 11;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPTra,
            this.NgayTraSach,
            this.SoLuongTraSach,
            this.TongTienDB});
            this.dataGridView2.Location = new System.Drawing.Point(15, 221);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(443, 150);
            this.dataGridView2.TabIndex = 11;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // MaPTra
            // 
            this.MaPTra.DataPropertyName = "MaPT";
            this.MaPTra.HeaderText = "Mã phiếu trả";
            this.MaPTra.Name = "MaPTra";
            this.MaPTra.ReadOnly = true;
            // 
            // NgayTraSach
            // 
            this.NgayTraSach.DataPropertyName = "NgayTra";
            this.NgayTraSach.HeaderText = "Ngày trả";
            this.NgayTraSach.Name = "NgayTraSach";
            this.NgayTraSach.ReadOnly = true;
            // 
            // SoLuongTraSach
            // 
            this.SoLuongTraSach.DataPropertyName = "SoLuongTra";
            this.SoLuongTraSach.HeaderText = "Số lượng";
            this.SoLuongTraSach.Name = "SoLuongTraSach";
            this.SoLuongTraSach.ReadOnly = true;
            // 
            // TongTienDB
            // 
            this.TongTienDB.DataPropertyName = "TongTienDB";
            this.TongTienDB.HeaderText = "Tổng tiền";
            this.TongTienDB.Name = "TongTienDB";
            this.TongTienDB.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(26, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tổng tiền bồi thường:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(26, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng số lượng trả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày trả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phiếu trả:";
            // 
            // SoLuongMuon
            // 
            this.SoLuongMuon.DataPropertyName = "SoLuongMuon";
            this.SoLuongMuon.HeaderText = "Số lượng mượn";
            this.SoLuongMuon.Name = "SoLuongMuon";
            this.SoLuongMuon.ReadOnly = true;
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_MaSV.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.txt_MaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaSV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_MaSV.Location = new System.Drawing.Point(117, 28);
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.Size = new System.Drawing.Size(382, 21);
            this.txt_MaSV.TabIndex = 8;
            this.txt_MaSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MaSV_KeyPress);
            this.txt_MaSV.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_MaSV_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_MaSV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 257);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin mượn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPM,
            this.Sach,
            this.NgayMuon,
            this.NgayTra,
            this.SoLuongMuon});
            this.dataGridView1.Location = new System.Drawing.Point(15, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(595, 150);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // MaPM
            // 
            this.MaPM.DataPropertyName = "MaPM";
            this.MaPM.HeaderText = "Mã Phiếu mượn";
            this.MaPM.Name = "MaPM";
            this.MaPM.ReadOnly = true;
            // 
            // Sach
            // 
            this.Sach.DataPropertyName = "MaSach";
            this.Sach.HeaderText = "Tên sách";
            this.Sach.Name = "Sach";
            this.Sach.ReadOnly = true;
            this.Sach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Sach.Width = 150;
            // 
            // NgayMuon
            // 
            this.NgayMuon.DataPropertyName = "NgayMuon";
            this.NgayMuon.HeaderText = "Ngày mượn";
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.ReadOnly = true;
            // 
            // NgayTra
            // 
            this.NgayTra.DataPropertyName = "NgayTra";
            this.NgayTra.HeaderText = "Ngày trả";
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::GUI.Properties.Resources.checkicon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(527, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "check";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên:";
            // 
            // FormTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 609);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormTraSach";
            this.Text = "Trả sách";
            this.Load += new System.EventHandler(this.FormTraSach_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btdangky;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_MaSach;
        private System.Windows.Forms.Button bn_LuuCTTra;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPMuon;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrangSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiPhiDenBu;
        private System.Windows.Forms.Label txt_DenBu;
        private System.Windows.Forms.TextBox txt_TinhTrang;
        private System.Windows.Forms.TextBox txt_SLTra;
        private System.Windows.Forms.TextBox txt_MaPM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bn_LuuPhieuTra;
        private System.Windows.Forms.Label txt_TienBoiThuong;
        private System.Windows.Forms.DateTimePicker txt_NgayTra;
        private System.Windows.Forms.TextBox txt_TongSLTra;
        private System.Windows.Forms.TextBox txt_MaPT;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTraSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTraSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienDB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongMuon;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPM;
        private System.Windows.Forms.DataGridViewComboBoxColumn Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}