namespace GUI
{
    partial class FormMuonPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMuonPhong));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bttraphong = new System.Windows.Forms.Button();
            this.btdangky = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSSV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MaP = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Phòng = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbox_KhuVuc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TgSuDung = new System.Windows.Forms.TextBox();
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NgayMuon = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_maTT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Phòng.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox1.Location = new System.Drawing.Point(592, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 21);
            this.textBox1.TabIndex = 73;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // bttraphong
            // 
            this.bttraphong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttraphong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttraphong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttraphong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bttraphong.Image = global::GUI.Properties.Resources.Hopstarter_Soft_Scraps_Button_Refresh;
            this.bttraphong.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttraphong.Location = new System.Drawing.Point(706, 185);
            this.bttraphong.Name = "bttraphong";
            this.bttraphong.Size = new System.Drawing.Size(87, 63);
            this.bttraphong.TabIndex = 71;
            this.bttraphong.Text = "Trả phòng";
            this.bttraphong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttraphong.UseVisualStyleBackColor = false;
            this.bttraphong.Click += new System.EventHandler(this.button1_Click);
            // 
            // btdangky
            // 
            this.btdangky.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btdangky.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btdangky.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdangky.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btdangky.Image = global::GUI.Properties.Resources.SAVEADD;
            this.btdangky.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btdangky.Location = new System.Drawing.Point(600, 185);
            this.btdangky.Name = "btdangky";
            this.btdangky.Size = new System.Drawing.Size(87, 63);
            this.btdangky.TabIndex = 66;
            this.btdangky.Text = "Lưu";
            this.btdangky.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btdangky.UseVisualStyleBackColor = false;
            this.btdangky.Click += new System.EventHandler(this.btdangky_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Ban.png");
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // ThoiGianSD
            // 
            this.ThoiGianSD.DataPropertyName = "ThoiGianSD";
            this.ThoiGianSD.HeaderText = "Thời gian sử dụng";
            this.ThoiGianSD.Name = "ThoiGianSD";
            this.ThoiGianSD.ReadOnly = true;
            this.ThoiGianSD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ThoiGianSD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NgayMuon
            // 
            this.NgayMuon.DataPropertyName = "NgayMuon";
            this.NgayMuon.HeaderText = "Ngày mượn";
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.ReadOnly = true;
            this.NgayMuon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NgayMuon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MSSV
            // 
            this.MSSV.DataPropertyName = "MSSV";
            this.MSSV.HeaderText = "Tên sinh viên";
            this.MSSV.Name = "MSSV";
            this.MSSV.ReadOnly = true;
            // 
            // MaP
            // 
            this.MaP.DataPropertyName = "MaPhong";
            this.MaP.HeaderText = "Mã phòng";
            this.MaP.Name = "MaP";
            this.MaP.ReadOnly = true;
            this.MaP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaP,
            this.MSSV,
            this.NgayMuon,
            this.ThoiGianSD,
            this.TrangThai});
            this.dataGridView1.Location = new System.Drawing.Point(11, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(546, 214);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(489, 276);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(571, 255);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin mượn phòng";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = global::GUI.Properties.Resources.btHuy;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(811, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 63);
            this.button3.TabIndex = 68;
            this.button3.Text = "Thoát";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 17);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(440, 394);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Phòng
            // 
            this.Phòng.Controls.Add(this.flowLayoutPanel1);
            this.Phòng.Location = new System.Drawing.Point(11, 11);
            this.Phòng.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Phòng.Name = "Phòng";
            this.Phòng.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Phòng.Size = new System.Drawing.Size(474, 438);
            this.Phòng.TabIndex = 70;
            this.Phòng.TabStop = false;
            this.Phòng.Text = "Phòng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(508, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 28);
            this.label7.TabIndex = 69;
            this.label7.Text = "Mượn phòng";
            // 
            // cbox_KhuVuc
            // 
            this.cbox_KhuVuc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbox_KhuVuc.Enabled = false;
            this.cbox_KhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbox_KhuVuc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbox_KhuVuc.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbox_KhuVuc.Location = new System.Drawing.Point(886, 61);
            this.cbox_KhuVuc.Name = "cbox_KhuVuc";
            this.cbox_KhuVuc.Size = new System.Drawing.Size(123, 23);
            this.cbox_KhuVuc.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(976, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 15);
            this.label6.TabIndex = 65;
            this.label6.Text = "giờ";
            // 
            // txt_TgSuDung
            // 
            this.txt_TgSuDung.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_TgSuDung.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.txt_TgSuDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TgSuDung.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TgSuDung.Location = new System.Drawing.Point(886, 142);
            this.txt_TgSuDung.Name = "txt_TgSuDung";
            this.txt_TgSuDung.Size = new System.Drawing.Size(84, 21);
            this.txt_TgSuDung.TabIndex = 64;
            this.txt_TgSuDung.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TgSuDung_KeyPress);
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_MaSV.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.txt_MaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaSV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_MaSV.Location = new System.Drawing.Point(592, 92);
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.Size = new System.Drawing.Size(417, 21);
            this.txt_MaSV.TabIndex = 63;
            this.txt_MaSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MaSV_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(772, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 15);
            this.label5.TabIndex = 62;
            this.label5.Text = "Thời gian sử dụng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(503, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 61;
            this.label4.Text = "Ngày mượn:";
            // 
            // txt_NgayMuon
            // 
            this.txt_NgayMuon.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.txt_NgayMuon.CalendarTitleBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_NgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_NgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_NgayMuon.Location = new System.Drawing.Point(592, 146);
            this.txt_NgayMuon.Name = "txt_NgayMuon";
            this.txt_NgayMuon.Size = new System.Drawing.Size(174, 21);
            this.txt_NgayMuon.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(503, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 59;
            this.label3.Text = "Mã sinh viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(824, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 58;
            this.label2.Text = "Khu vực:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(503, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 57;
            this.label1.Text = "Phòng:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(677, 17);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(503, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 75;
            this.label8.Text = "Thủ thư:";
            // 
            // txt_maTT
            // 
            this.txt_maTT.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_maTT.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.txt_maTT.Enabled = false;
            this.txt_maTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_maTT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_maTT.Location = new System.Drawing.Point(592, 119);
            this.txt_maTT.Name = "txt_maTT";
            this.txt_maTT.Size = new System.Drawing.Size(417, 21);
            this.txt_maTT.TabIndex = 76;
            // 
            // FormMuonPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 609);
            this.Controls.Add(this.txt_maTT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bttraphong);
            this.Controls.Add(this.btdangky);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Phòng);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbox_KhuVuc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_TgSuDung);
            this.Controls.Add(this.txt_MaSV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_NgayMuon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMuonPhong";
            this.Text = "MƯỢN PHÒNG";
            this.Load += new System.EventHandler(this.MuonPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.Phòng.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bttraphong;
        private System.Windows.Forms.Button btdangky;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewComboBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaP;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox Phòng;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbox_KhuVuc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TgSuDung;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txt_NgayMuon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_maTT;
    }
}