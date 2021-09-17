namespace GUI
{
    partial class FormGiaHan
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
            this.txt_CTNgayGH = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaSach = new System.Windows.Forms.TextBox();
            this.txt_MaPM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sach = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btdangky = new System.Windows.Forms.Button();
            this.txt_NgayGH = new System.Windows.Forms.DateTimePicker();
            this.txt_TongSLGH = new System.Windows.Forms.TextBox();
            this.txt_MaGH = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.MaPhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuonSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.MaPGH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayGiaHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongGH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txt_SLGH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_CTNgayGH
            // 
            this.txt_CTNgayGH.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.txt_CTNgayGH.CalendarTitleBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_CTNgayGH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_CTNgayGH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_CTNgayGH.Location = new System.Drawing.Point(117, 68);
            this.txt_CTNgayGH.Name = "txt_CTNgayGH";
            this.txt_CTNgayGH.Size = new System.Drawing.Size(139, 21);
            this.txt_CTNgayGH.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 36;
            this.label5.Text = "Ngày gia hạn:";
            // 
            // txt_MaSach
            // 
            this.txt_MaSach.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_MaSach.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.txt_MaSach.Enabled = false;
            this.txt_MaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaSach.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_MaSach.Location = new System.Drawing.Point(249, 39);
            this.txt_MaSach.Name = "txt_MaSach";
            this.txt_MaSach.Size = new System.Drawing.Size(209, 21);
            this.txt_MaSach.TabIndex = 35;
            // 
            // txt_MaPM
            // 
            this.txt_MaPM.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_MaPM.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.txt_MaPM.Enabled = false;
            this.txt_MaPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaPM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_MaPM.Location = new System.Drawing.Point(117, 39);
            this.txt_MaPM.Name = "txt_MaPM";
            this.txt_MaPM.Size = new System.Drawing.Size(67, 21);
            this.txt_MaPM.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(201, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 19);
            this.label7.TabIndex = 33;
            this.label7.Text = "Sách:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(109, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng số lượng gia hạn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày gia hạn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(109, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phiếu gia hạn:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.txt_MaSV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 257);
            this.groupBox1.TabIndex = 46;
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
            this.dataGridView1.Size = new System.Drawing.Size(557, 150);
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
            // SoLuongMuon
            // 
            this.SoLuongMuon.DataPropertyName = "SoLuongMuon";
            this.SoLuongMuon.HeaderText = "Số lượng mượn";
            this.SoLuongMuon.Name = "SoLuongMuon";
            this.SoLuongMuon.ReadOnly = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::GUI.Properties.Resources.checkicon;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(508, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 40);
            this.button4.TabIndex = 9;
            this.button4.Text = "check";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_MaSV.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.txt_MaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaSV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_MaSV.Location = new System.Drawing.Point(135, 36);
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.Size = new System.Drawing.Size(351, 21);
            this.txt_MaSV.TabIndex = 8;
            this.txt_MaSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SLGH_KeyPress);
            this.txt_MaSV.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_MaSV_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btdangky);
            this.groupBox2.Controls.Add(this.txt_NgayGH);
            this.groupBox2.Controls.Add(this.txt_TongSLGH);
            this.groupBox2.Controls.Add(this.txt_MaGH);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(620, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 295);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phiếu Gia Hạn";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Image = global::GUI.Properties.Resources.SAVEADD;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(429, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 63);
            this.button2.TabIndex = 27;
            this.button2.Text = "Lưu";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btdangky
            // 
            this.btdangky.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btdangky.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btdangky.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdangky.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btdangky.Image = global::GUI.Properties.Resources.Icons8_Windows_8_Ecommerce_Bill;
            this.btdangky.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btdangky.Location = new System.Drawing.Point(15, 30);
            this.btdangky.Name = "btdangky";
            this.btdangky.Size = new System.Drawing.Size(88, 62);
            this.btdangky.TabIndex = 26;
            this.btdangky.Text = "Tạo phiếu";
            this.btdangky.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btdangky.UseVisualStyleBackColor = false;
            this.btdangky.Click += new System.EventHandler(this.btdangky_Click);
            // 
            // txt_NgayGH
            // 
            this.txt_NgayGH.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.txt_NgayGH.CalendarTitleBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_NgayGH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_NgayGH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_NgayGH.Location = new System.Drawing.Point(277, 60);
            this.txt_NgayGH.Name = "txt_NgayGH";
            this.txt_NgayGH.Size = new System.Drawing.Size(132, 21);
            this.txt_NgayGH.TabIndex = 24;
            // 
            // txt_TongSLGH
            // 
            this.txt_TongSLGH.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_TongSLGH.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.txt_TongSLGH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TongSLGH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TongSLGH.Location = new System.Drawing.Point(277, 88);
            this.txt_TongSLGH.Name = "txt_TongSLGH";
            this.txt_TongSLGH.Size = new System.Drawing.Size(132, 21);
            this.txt_TongSLGH.TabIndex = 12;
            // 
            // txt_MaGH
            // 
            this.txt_MaGH.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_MaGH.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.txt_MaGH.Enabled = false;
            this.txt_MaGH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaGH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_MaGH.Location = new System.Drawing.Point(277, 26);
            this.txt_MaGH.Name = "txt_MaGH";
            this.txt_MaGH.Size = new System.Drawing.Size(132, 21);
            this.txt_MaGH.TabIndex = 11;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuMuon,
            this.NgayMuonSach,
            this.TongMuon});
            this.dataGridView2.Location = new System.Drawing.Point(15, 115);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(504, 150);
            this.dataGridView2.TabIndex = 11;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // MaPhieuMuon
            // 
            this.MaPhieuMuon.DataPropertyName = "MaPGH";
            this.MaPhieuMuon.HeaderText = "Mã phiếu gia hạn";
            this.MaPhieuMuon.Name = "MaPhieuMuon";
            this.MaPhieuMuon.ReadOnly = true;
            // 
            // NgayMuonSach
            // 
            this.NgayMuonSach.DataPropertyName = "NgayGH";
            this.NgayMuonSach.HeaderText = "Ngày gia hạn";
            this.NgayMuonSach.Name = "NgayMuonSach";
            this.NgayMuonSach.ReadOnly = true;
            // 
            // TongMuon
            // 
            this.TongMuon.DataPropertyName = "TongSLGH";
            this.TongMuon.HeaderText = "Tổng số lượng gia hạn";
            this.TongMuon.Name = "TongMuon";
            this.TongMuon.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "Mã phiếu mượn:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Image = global::GUI.Properties.Resources.UpdateIco;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(479, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 63);
            this.button3.TabIndex = 30;
            this.button3.Text = "Update";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPGH,
            this.NgayGiaHan,
            this.SoLuongGH,
            this.MaMuon,
            this.TenSach});
            this.dataGridView3.Location = new System.Drawing.Point(22, 111);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(550, 150);
            this.dataGridView3.TabIndex = 26;
            this.dataGridView3.SelectionChanged += new System.EventHandler(this.dataGridView3_SelectionChanged);
            // 
            // MaPGH
            // 
            this.MaPGH.DataPropertyName = "MaPGH";
            this.MaPGH.HeaderText = "Mã phiếu GH";
            this.MaPGH.Name = "MaPGH";
            this.MaPGH.ReadOnly = true;
            // 
            // NgayGiaHan
            // 
            this.NgayGiaHan.DataPropertyName = "NgayGiaHan";
            this.NgayGiaHan.HeaderText = "Ngày gia hạn";
            this.NgayGiaHan.Name = "NgayGiaHan";
            this.NgayGiaHan.ReadOnly = true;
            // 
            // SoLuongGH
            // 
            this.SoLuongGH.DataPropertyName = "SoLuongGH";
            this.SoLuongGH.HeaderText = "Số lượng";
            this.SoLuongGH.Name = "SoLuongGH";
            this.SoLuongGH.ReadOnly = true;
            // 
            // MaMuon
            // 
            this.MaMuon.DataPropertyName = "MaPM";
            this.MaMuon.HeaderText = "Mã phiếu mượn";
            this.MaMuon.Name = "MaMuon";
            this.MaMuon.ReadOnly = true;
            this.MaMuon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "MaSach";
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            this.TenSach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenSach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txt_SLGH
            // 
            this.txt_SLGH.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_SLGH.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.txt_SLGH.Enabled = false;
            this.txt_SLGH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SLGH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_SLGH.Location = new System.Drawing.Point(344, 70);
            this.txt_SLGH.Name = "txt_SLGH";
            this.txt_SLGH.Size = new System.Drawing.Size(114, 21);
            this.txt_SLGH.TabIndex = 27;
            this.txt_SLGH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SLGH_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(271, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Số lượng:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_CTNgayGH);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_MaSach);
            this.groupBox3.Controls.Add(this.txt_MaPM);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.Controls.Add(this.txt_SLGH);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(26, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(588, 282);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết gia hạn";
            // 
            // FormGiaHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 564);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormGiaHan";
            this.Text = "GIA HẠN SÁCH";
            this.Load += new System.EventHandler(this.FormGiaHan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker txt_CTNgayGH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_MaSach;
        private System.Windows.Forms.TextBox txt_MaPM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPM;
        private System.Windows.Forms.DataGridViewComboBoxColumn Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongMuon;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btdangky;
        private System.Windows.Forms.DateTimePicker txt_NgayGH;
        private System.Windows.Forms.TextBox txt_TongSLGH;
        private System.Windows.Forms.TextBox txt_MaGH;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPGH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayGiaHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongGH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMuon;
        private System.Windows.Forms.DataGridViewComboBoxColumn TenSach;
        private System.Windows.Forms.TextBox txt_SLGH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuonSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongMuon;
    }
}