namespace BT8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboLop = new ComboBox();
            label1 = new Label();
            lblMahv = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblThanhTien = new Label();
            txtTenHV = new TextBox();
            txtMaHV = new TextBox();
            grbHocVien = new GroupBox();
            btnThoat = new Button();
            btnTiep = new Button();
            btnDangKi = new Button();
            lstHocVien = new ListBox();
            grbHocVien.SuspendLayout();
            SuspendLayout();
            // 
            // cboLop
            // 
            cboLop.FormattingEnabled = true;
            cboLop.Location = new Point(341, 220);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(315, 37);
            cboLop.TabIndex = 1;
            cboLop.SelectedIndexChanged += cboLop_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Arial", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1314, 109);
            label1.TabIndex = 4;
            label1.Text = "DANH SÁCH SINH VIÊN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMahv
            // 
            lblMahv.ForeColor = Color.Blue;
            lblMahv.Location = new Point(38, 84);
            lblMahv.Name = "lblMahv";
            lblMahv.Size = new Size(219, 30);
            lblMahv.TabIndex = 5;
            lblMahv.Text = "Mã Học Viên";
            // 
            // label3
            // 
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(38, 157);
            label3.Name = "label3";
            label3.Size = new Size(219, 30);
            label3.TabIndex = 5;
            label3.Text = "Họ Tên Học Viên";
            // 
            // label4
            // 
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(38, 230);
            label4.Name = "label4";
            label4.Size = new Size(219, 30);
            label4.TabIndex = 5;
            label4.Text = "Lớp Đăng Kí";
            // 
            // label5
            // 
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(38, 303);
            label5.Name = "label5";
            label5.Size = new Size(219, 30);
            label5.TabIndex = 5;
            label5.Text = "Thành Tiền";
            // 
            // lblThanhTien
            // 
            lblThanhTien.ForeColor = Color.Blue;
            lblThanhTien.Location = new Point(341, 303);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(315, 30);
            lblThanhTien.TabIndex = 5;
            lblThanhTien.Text = "label2";
            // 
            // txtTenHV
            // 
            txtTenHV.Location = new Point(341, 152);
            txtTenHV.Name = "txtTenHV";
            txtTenHV.Size = new Size(315, 35);
            txtTenHV.TabIndex = 6;
            // 
            // txtMaHV
            // 
            txtMaHV.Location = new Point(341, 79);
            txtMaHV.Name = "txtMaHV";
            txtMaHV.ReadOnly = true;
            txtMaHV.Size = new Size(315, 35);
            txtMaHV.TabIndex = 6;
            // 
            // grbHocVien
            // 
            grbHocVien.Controls.Add(btnThoat);
            grbHocVien.Controls.Add(btnTiep);
            grbHocVien.Controls.Add(btnDangKi);
            grbHocVien.Controls.Add(lblMahv);
            grbHocVien.Controls.Add(txtMaHV);
            grbHocVien.Controls.Add(cboLop);
            grbHocVien.Controls.Add(txtTenHV);
            grbHocVien.Controls.Add(label3);
            grbHocVien.Controls.Add(lblThanhTien);
            grbHocVien.Controls.Add(label4);
            grbHocVien.Controls.Add(label5);
            grbHocVien.ForeColor = Color.Blue;
            grbHocVien.Location = new Point(36, 149);
            grbHocVien.Name = "grbHocVien";
            grbHocVien.Size = new Size(682, 480);
            grbHocVien.TabIndex = 7;
            grbHocVien.TabStop = false;
            grbHocVien.Text = "THÔNG TIN HỌC VIÊN";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(488, 383);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(168, 63);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTiep
            // 
            btnTiep.Location = new Point(263, 383);
            btnTiep.Name = "btnTiep";
            btnTiep.Size = new Size(168, 63);
            btnTiep.TabIndex = 7;
            btnTiep.Text = "Tiếp";
            btnTiep.UseVisualStyleBackColor = true;
            btnTiep.Click += btnTiep_Click;
            // 
            // btnDangKi
            // 
            btnDangKi.Location = new Point(38, 383);
            btnDangKi.Name = "btnDangKi";
            btnDangKi.Size = new Size(168, 63);
            btnDangKi.TabIndex = 7;
            btnDangKi.Text = "Đăng Kí";
            btnDangKi.UseVisualStyleBackColor = true;
            btnDangKi.Click += btnDangKi_Click;
            // 
            // lstHocVien
            // 
            lstHocVien.FormattingEnabled = true;
            lstHocVien.ItemHeight = 29;
            lstHocVien.Location = new Point(798, 161);
            lstHocVien.Name = "lstHocVien";
            lstHocVien.Size = new Size(414, 468);
            lstHocVien.TabIndex = 8;
            lstHocVien.SelectedIndexChanged += lstHocVien_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1314, 721);
            Controls.Add(lstHocVien);
            Controls.Add(grbHocVien);
            Controls.Add(label1);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "`";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            grbHocVien.ResumeLayout(false);
            grbHocVien.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cboLop;
        private Label label1;
        private Label lblMahv;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblThanhTien;
        private TextBox txtTenHV;
        private TextBox txtMaHV;
        private GroupBox grbHocVien;
        private ListBox lstHocVien;
        private Button btnThoat;
        private Button btnTiep;
        private Button btnDangKi;
    }
}
