namespace QLSV
{
    partial class MainFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.txtSoTiet = new System.Windows.Forms.TextBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.comboMaMH = new System.Windows.Forms.ComboBox();
            this.btnTimMHTheoMa = new System.Windows.Forms.Button();
            this.btnTuKhoa = new System.Windows.Forms.Button();
            this.btnHienThiTatCa = new System.Windows.Forms.Button();
            this.dtgvMH = new System.Windows.Forms.DataGridView();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXemDSSV = new System.Windows.Forms.Button();
            this.btnXemDSSVTheoKhoa = new System.Windows.Forms.Button();
            this.btnXemDiem = new System.Windows.Forms.Button();
            this.btnXemDiemTheoMon = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã MH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên MH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số tiết:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chọn mã MH cần tìm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(753, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tìm kiếm thông tin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(680, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nhập từ khóa:";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(147, 63);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(233, 27);
            this.txtMaMH.TabIndex = 6;
            // 
            // txtSoTiet
            // 
            this.txtSoTiet.Location = new System.Drawing.Point(147, 165);
            this.txtSoTiet.Name = "txtSoTiet";
            this.txtSoTiet.Size = new System.Drawing.Size(233, 27);
            this.txtSoTiet.TabIndex = 7;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(147, 113);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(233, 27);
            this.txtTenMH.TabIndex = 8;
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(798, 63);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(143, 27);
            this.txtTuKhoa.TabIndex = 9;
            // 
            // comboMaMH
            // 
            this.comboMaMH.FormattingEnabled = true;
            this.comboMaMH.Location = new System.Drawing.Point(425, 100);
            this.comboMaMH.Name = "comboMaMH";
            this.comboMaMH.Size = new System.Drawing.Size(251, 28);
            this.comboMaMH.TabIndex = 10;
            this.comboMaMH.SelectedIndexChanged += new System.EventHandler(this.cbbMaMH_SelectedIndexChanged);
            this.comboMaMH.Click += new System.EventHandler(this.comboMaMH_Click);
            // 
            // btnTimMHTheoMa
            // 
            this.btnTimMHTheoMa.Location = new System.Drawing.Point(425, 146);
            this.btnTimMHTheoMa.Name = "btnTimMHTheoMa";
            this.btnTimMHTheoMa.Size = new System.Drawing.Size(89, 27);
            this.btnTimMHTheoMa.TabIndex = 11;
            this.btnTimMHTheoMa.Text = "Tìm kiếm";
            this.btnTimMHTheoMa.UseVisualStyleBackColor = true;
            this.btnTimMHTheoMa.Click += new System.EventHandler(this.btnTimMHTheoMa_Click);
            // 
            // btnTuKhoa
            // 
            this.btnTuKhoa.Location = new System.Drawing.Point(798, 101);
            this.btnTuKhoa.Name = "btnTuKhoa";
            this.btnTuKhoa.Size = new System.Drawing.Size(89, 27);
            this.btnTuKhoa.TabIndex = 12;
            this.btnTuKhoa.Text = "Tìm kiếm";
            this.btnTuKhoa.UseVisualStyleBackColor = true;
            this.btnTuKhoa.Click += new System.EventHandler(this.btnTuKhoa_Click);
            // 
            // btnHienThiTatCa
            // 
            this.btnHienThiTatCa.Location = new System.Drawing.Point(46, 219);
            this.btnHienThiTatCa.Name = "btnHienThiTatCa";
            this.btnHienThiTatCa.Size = new System.Drawing.Size(153, 30);
            this.btnHienThiTatCa.TabIndex = 13;
            this.btnHienThiTatCa.Text = "Hiển thị tất cả";
            this.btnHienThiTatCa.UseVisualStyleBackColor = true;
            this.btnHienThiTatCa.Click += new System.EventHandler(this.btnHienThiTatCa_Click);
            // 
            // dtgvMH
            // 
            this.dtgvMH.AllowUserToAddRows = false;
            this.dtgvMH.AllowUserToDeleteRows = false;
            this.dtgvMH.AllowUserToOrderColumns = true;
            this.dtgvMH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMH.Location = new System.Drawing.Point(27, 267);
            this.dtgvMH.Name = "dtgvMH";
            this.dtgvMH.ReadOnly = true;
            this.dtgvMH.RowHeadersWidth = 51;
            this.dtgvMH.RowTemplate.Height = 24;
            this.dtgvMH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMH.Size = new System.Drawing.Size(932, 202);
            this.dtgvMH.TabIndex = 14;
            this.dtgvMH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMH_CellContentClick);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(47, 489);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(98, 28);
            this.btnThemMoi.TabIndex = 15;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(150, 489);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(63, 28);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(286, 489);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(63, 28);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXemDSSV
            // 
            this.btnXemDSSV.Location = new System.Drawing.Point(354, 490);
            this.btnXemDSSV.Name = "btnXemDSSV";
            this.btnXemDSSV.Size = new System.Drawing.Size(110, 28);
            this.btnXemDSSV.TabIndex = 19;
            this.btnXemDSSV.Text = "Xem DSSV";
            this.btnXemDSSV.UseVisualStyleBackColor = true;
            // 
            // btnXemDSSVTheoKhoa
            // 
            this.btnXemDSSVTheoKhoa.Location = new System.Drawing.Point(469, 489);
            this.btnXemDSSVTheoKhoa.Name = "btnXemDSSVTheoKhoa";
            this.btnXemDSSVTheoKhoa.Size = new System.Drawing.Size(192, 28);
            this.btnXemDSSVTheoKhoa.TabIndex = 20;
            this.btnXemDSSVTheoKhoa.Text = "Xem DSSV theo khoa";
            this.btnXemDSSVTheoKhoa.UseVisualStyleBackColor = true;
            // 
            // btnXemDiem
            // 
            this.btnXemDiem.Location = new System.Drawing.Point(666, 489);
            this.btnXemDiem.Name = "btnXemDiem";
            this.btnXemDiem.Size = new System.Drawing.Size(98, 28);
            this.btnXemDiem.TabIndex = 21;
            this.btnXemDiem.Text = "Xem điểm";
            this.btnXemDiem.UseVisualStyleBackColor = true;
            // 
            // btnXemDiemTheoMon
            // 
            this.btnXemDiemTheoMon.Location = new System.Drawing.Point(769, 489);
            this.btnXemDiemTheoMon.Name = "btnXemDiemTheoMon";
            this.btnXemDiemTheoMon.Size = new System.Drawing.Size(173, 28);
            this.btnXemDiemTheoMon.TabIndex = 22;
            this.btnXemDiemTheoMon.Text = "Xem điểm theo môn";
            this.btnXemDiemTheoMon.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(219, 489);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(63, 28);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 538);
            this.Controls.Add(this.btnXemDiemTheoMon);
            this.Controls.Add(this.btnXemDiem);
            this.Controls.Add(this.btnXemDSSVTheoKhoa);
            this.Controls.Add(this.btnXemDSSV);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.dtgvMH);
            this.Controls.Add(this.btnHienThiTatCa);
            this.Controls.Add(this.btnTuKhoa);
            this.Controls.Add(this.btnTimMHTheoMa);
            this.Controls.Add(this.comboMaMH);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.txtSoTiet);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainFrm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.TextBox txtSoTiet;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.ComboBox comboMaMH;
        private System.Windows.Forms.Button btnTimMHTheoMa;
        private System.Windows.Forms.Button btnTuKhoa;
        private System.Windows.Forms.Button btnHienThiTatCa;
        private System.Windows.Forms.DataGridView dtgvMH;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXemDSSV;
        private System.Windows.Forms.Button btnXemDSSVTheoKhoa;
        private System.Windows.Forms.Button btnXemDiem;
        private System.Windows.Forms.Button btnXemDiemTheoMon;
        private System.Windows.Forms.Button btnSua;
    }
}