namespace GUI
{
    partial class FormQLSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLSach));
            this.bn_TaoMa = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bn_Xoa = new System.Windows.Forms.Button();
            this.bn_ThemSach = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bn_LuuSach = new System.Windows.Forms.Button();
            this.Bn_File = new System.Windows.Forms.Button();
            this.txt_HinhAnh = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_MoTa = new System.Windows.Forms.TextBox();
            this.txt_Gia = new System.Windows.Forms.TextBox();
            this.txt_TrangThai = new System.Windows.Forms.TextBox();
            this.Txt_SoLuong = new System.Windows.Forms.TextBox();
            this.Txt_TenSach = new System.Windows.Forms.TextBox();
            this.Txt_MaSach = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTG = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNXB = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MaKhuVuc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnhSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_NhaCC = new System.Windows.Forms.ComboBox();
            this.cb_KhuVuc = new System.Windows.Forms.ComboBox();
            this.cb_NXB = new System.Windows.Forms.ComboBox();
            this.cb_TacGia = new System.Windows.Forms.ComboBox();
            this.cb_LoaiSach = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bn_TaoMa
            // 
            this.bn_TaoMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_TaoMa.ForeColor = System.Drawing.Color.Blue;
            this.bn_TaoMa.ImageKey = "Create-New-icon.png";
            this.bn_TaoMa.ImageList = this.imageList1;
            this.bn_TaoMa.Location = new System.Drawing.Point(122, 205);
            this.bn_TaoMa.Name = "bn_TaoMa";
            this.bn_TaoMa.Size = new System.Drawing.Size(68, 63);
            this.bn_TaoMa.TabIndex = 116;
            this.bn_TaoMa.Text = "Tạo Mã";
            this.bn_TaoMa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bn_TaoMa.UseVisualStyleBackColor = true;
            this.bn_TaoMa.Click += new System.EventHandler(this.bn_TaoMa_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Button-Add-icon.png");
            this.imageList1.Images.SetKeyName(1, "Button-Close-icon.png");
            this.imageList1.Images.SetKeyName(2, "Create-New-icon.png");
            this.imageList1.Images.SetKeyName(3, "Save-icon.png");
            // 
            // bn_Xoa
            // 
            this.bn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_Xoa.ForeColor = System.Drawing.Color.MediumBlue;
            this.bn_Xoa.ImageKey = "Button-Close-icon.png";
            this.bn_Xoa.ImageList = this.imageList1;
            this.bn_Xoa.Location = new System.Drawing.Point(468, 207);
            this.bn_Xoa.Name = "bn_Xoa";
            this.bn_Xoa.Size = new System.Drawing.Size(68, 63);
            this.bn_Xoa.TabIndex = 115;
            this.bn_Xoa.Text = "Xóa";
            this.bn_Xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bn_Xoa.UseVisualStyleBackColor = false;
            this.bn_Xoa.Click += new System.EventHandler(this.bn_Xoa_Click);
            // 
            // bn_ThemSach
            // 
            this.bn_ThemSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bn_ThemSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_ThemSach.ForeColor = System.Drawing.Color.MediumBlue;
            this.bn_ThemSach.ImageKey = "Button-Add-icon.png";
            this.bn_ThemSach.ImageList = this.imageList1;
            this.bn_ThemSach.Location = new System.Drawing.Point(235, 206);
            this.bn_ThemSach.Name = "bn_ThemSach";
            this.bn_ThemSach.Size = new System.Drawing.Size(73, 63);
            this.bn_ThemSach.TabIndex = 114;
            this.bn_ThemSach.Text = "Thêm";
            this.bn_ThemSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bn_ThemSach.UseVisualStyleBackColor = false;
            this.bn_ThemSach.Click += new System.EventHandler(this.bn_ThemSach_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bn_LuuSach
            // 
            this.bn_LuuSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bn_LuuSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_LuuSach.ForeColor = System.Drawing.Color.MediumBlue;
            this.bn_LuuSach.ImageKey = "Save-icon.png";
            this.bn_LuuSach.ImageList = this.imageList1;
            this.bn_LuuSach.Location = new System.Drawing.Point(343, 206);
            this.bn_LuuSach.Name = "bn_LuuSach";
            this.bn_LuuSach.Size = new System.Drawing.Size(68, 63);
            this.bn_LuuSach.TabIndex = 113;
            this.bn_LuuSach.Text = "Lưu";
            this.bn_LuuSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bn_LuuSach.UseVisualStyleBackColor = false;
            this.bn_LuuSach.Click += new System.EventHandler(this.bn_LuuSach_Click);
            // 
            // Bn_File
            // 
            this.Bn_File.Location = new System.Drawing.Point(714, 164);
            this.Bn_File.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Bn_File.Name = "Bn_File";
            this.Bn_File.Size = new System.Drawing.Size(39, 25);
            this.Bn_File.TabIndex = 112;
            this.Bn_File.Text = "File";
            this.Bn_File.UseVisualStyleBackColor = true;
            this.Bn_File.Click += new System.EventHandler(this.Bn_File_Click);
            // 
            // txt_HinhAnh
            // 
            this.txt_HinhAnh.Enabled = false;
            this.txt_HinhAnh.Location = new System.Drawing.Point(714, 133);
            this.txt_HinhAnh.Name = "txt_HinhAnh";
            this.txt_HinhAnh.Size = new System.Drawing.Size(120, 20);
            this.txt_HinhAnh.TabIndex = 111;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(889, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 217);
            this.pictureBox1.TabIndex = 110;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(636, 136);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 15);
            this.label13.TabIndex = 109;
            this.label13.Text = "Hình ảnh:";
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.Location = new System.Drawing.Point(714, 24);
            this.txt_MoTa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_MoTa.Multiline = true;
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Size = new System.Drawing.Size(160, 92);
            this.txt_MoTa.TabIndex = 108;
            // 
            // txt_Gia
            // 
            this.txt_Gia.Location = new System.Drawing.Point(442, 169);
            this.txt_Gia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Gia.Name = "txt_Gia";
            this.txt_Gia.Size = new System.Drawing.Size(168, 20);
            this.txt_Gia.TabIndex = 107;
            this.txt_Gia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_SoLuong_KeyPress);
            // 
            // txt_TrangThai
            // 
            this.txt_TrangThai.Location = new System.Drawing.Point(442, 93);
            this.txt_TrangThai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_TrangThai.Name = "txt_TrangThai";
            this.txt_TrangThai.Size = new System.Drawing.Size(168, 20);
            this.txt_TrangThai.TabIndex = 106;
            // 
            // Txt_SoLuong
            // 
            this.Txt_SoLuong.Location = new System.Drawing.Point(122, 129);
            this.Txt_SoLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_SoLuong.Name = "Txt_SoLuong";
            this.Txt_SoLuong.Size = new System.Drawing.Size(168, 20);
            this.Txt_SoLuong.TabIndex = 105;
            this.Txt_SoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_SoLuong_KeyPress);
            // 
            // Txt_TenSach
            // 
            this.Txt_TenSach.Location = new System.Drawing.Point(122, 54);
            this.Txt_TenSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_TenSach.Name = "Txt_TenSach";
            this.Txt_TenSach.Size = new System.Drawing.Size(168, 20);
            this.Txt_TenSach.TabIndex = 104;
            // 
            // Txt_MaSach
            // 
            this.Txt_MaSach.Location = new System.Drawing.Point(122, 23);
            this.Txt_MaSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_MaSach.Name = "Txt_MaSach";
            this.Txt_MaSach.Size = new System.Drawing.Size(168, 20);
            this.Txt_MaSach.TabIndex = 103;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(326, 133);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 15);
            this.label12.TabIndex = 102;
            this.label12.Text = "Nhà cung cấp:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(326, 169);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 15);
            this.label10.TabIndex = 101;
            this.label10.Text = "Giá:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(326, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 15);
            this.label9.TabIndex = 100;
            this.label9.Text = "Khu vực:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 169);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 15);
            this.label8.TabIndex = 99;
            this.label8.Text = "Nhà xuất bản:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(326, 94);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 98;
            this.label7.Text = "Trạng thái:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(326, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 97;
            this.label6.Text = "Tác giả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(640, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 96;
            this.label5.Text = "Mô tả:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(11, 284);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1182, 330);
            this.dataGridView1.TabIndex = 86;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            this.MaSach.Width = 70;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            this.TenSach.Width = 150;
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
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 50;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
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
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Width = 50;
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
            // MaKhuVuc
            // 
            this.MaKhuVuc.DataPropertyName = "MaKhuVuc";
            this.MaKhuVuc.HeaderText = "Khu vực";
            this.MaKhuVuc.Name = "MaKhuVuc";
            this.MaKhuVuc.ReadOnly = true;
            this.MaKhuVuc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaKhuVuc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // HinhAnhSach
            // 
            this.HinhAnhSach.DataPropertyName = "HinhAnhSach";
            this.HinhAnhSach.HeaderText = "Hình ảnh";
            this.HinhAnhSach.Name = "HinhAnhSach";
            this.HinhAnhSach.ReadOnly = true;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 95;
            this.label4.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 94;
            this.label3.Text = "Loại sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 93;
            this.label2.Text = "Tên sách:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 92;
            this.label1.Text = "Mã sách:";
            // 
            // cb_NhaCC
            // 
            this.cb_NhaCC.FormattingEnabled = true;
            this.cb_NhaCC.Location = new System.Drawing.Point(442, 132);
            this.cb_NhaCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_NhaCC.Name = "cb_NhaCC";
            this.cb_NhaCC.Size = new System.Drawing.Size(168, 21);
            this.cb_NhaCC.TabIndex = 91;
            // 
            // cb_KhuVuc
            // 
            this.cb_KhuVuc.FormattingEnabled = true;
            this.cb_KhuVuc.Location = new System.Drawing.Point(442, 21);
            this.cb_KhuVuc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_KhuVuc.Name = "cb_KhuVuc";
            this.cb_KhuVuc.Size = new System.Drawing.Size(168, 21);
            this.cb_KhuVuc.TabIndex = 90;
            // 
            // cb_NXB
            // 
            this.cb_NXB.FormattingEnabled = true;
            this.cb_NXB.Location = new System.Drawing.Point(122, 169);
            this.cb_NXB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_NXB.Name = "cb_NXB";
            this.cb_NXB.Size = new System.Drawing.Size(168, 21);
            this.cb_NXB.TabIndex = 89;
            // 
            // cb_TacGia
            // 
            this.cb_TacGia.FormattingEnabled = true;
            this.cb_TacGia.Location = new System.Drawing.Point(442, 57);
            this.cb_TacGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_TacGia.Name = "cb_TacGia";
            this.cb_TacGia.Size = new System.Drawing.Size(168, 21);
            this.cb_TacGia.TabIndex = 88;
            // 
            // cb_LoaiSach
            // 
            this.cb_LoaiSach.FormattingEnabled = true;
            this.cb_LoaiSach.Location = new System.Drawing.Point(122, 92);
            this.cb_LoaiSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_LoaiSach.Name = "cb_LoaiSach";
            this.cb_LoaiSach.Size = new System.Drawing.Size(168, 21);
            this.cb_LoaiSach.TabIndex = 87;
            // 
            // FormQLSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 571);
            this.Controls.Add(this.bn_TaoMa);
            this.Controls.Add(this.bn_Xoa);
            this.Controls.Add(this.bn_ThemSach);
            this.Controls.Add(this.bn_LuuSach);
            this.Controls.Add(this.Bn_File);
            this.Controls.Add(this.txt_HinhAnh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_MoTa);
            this.Controls.Add(this.txt_Gia);
            this.Controls.Add(this.txt_TrangThai);
            this.Controls.Add(this.Txt_SoLuong);
            this.Controls.Add(this.Txt_TenSach);
            this.Controls.Add(this.Txt_MaSach);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_NhaCC);
            this.Controls.Add(this.cb_KhuVuc);
            this.Controls.Add(this.cb_NXB);
            this.Controls.Add(this.cb_TacGia);
            this.Controls.Add(this.cb_LoaiSach);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormQLSach";
            this.Text = "SÁCH";
            this.Load += new System.EventHandler(this.FormQLSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bn_TaoMa;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button bn_Xoa;
        private System.Windows.Forms.Button bn_ThemSach;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bn_LuuSach;
        private System.Windows.Forms.Button Bn_File;
        private System.Windows.Forms.TextBox txt_HinhAnh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_MoTa;
        private System.Windows.Forms.TextBox txt_Gia;
        private System.Windows.Forms.TextBox txt_TrangThai;
        private System.Windows.Forms.TextBox Txt_SoLuong;
        private System.Windows.Forms.TextBox Txt_TenSach;
        private System.Windows.Forms.TextBox Txt_MaSach;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaNXB;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaKhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhAnhSach;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaNCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_NhaCC;
        private System.Windows.Forms.ComboBox cb_KhuVuc;
        private System.Windows.Forms.ComboBox cb_NXB;
        private System.Windows.Forms.ComboBox cb_TacGia;
        private System.Windows.Forms.ComboBox cb_LoaiSach;
    }
}