namespace BT8
{
    public partial class Form1 : Form
    {
        private List<HocVien> hocviens = new List<HocVien>();
        private List<LopHoc> lophocs = new List<LopHoc>();

        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DuLieuSan();
            KhoiTaocomboBox();
            KhoiTaolistBox();

        }
        private void KhoiTaocomboBox()
        {
            cboLop.DataSource = null;
            cboLop.DisplayMember = "TenLopHoc";
            cboLop.ValueMember = "MaLopHoc";
            cboLop.DataSource = lophocs;
        }
        private void KhoiTaolistBox()
        {
            lstHocVien.DataSource = null;
            lstHocVien.DisplayMember = "TenHV";
            lstHocVien.ValueMember = "MaHV";
            lstHocVien.DataSource = hocviens;
        }

        private void DuLieuSan()
        {
            lophocs = new List<LopHoc>()
            {
                new LopHoc{MaLopHoc="L01",TenLopHoc="Lập Trình WinDow",ThanhTien=1200000},
                new LopHoc{MaLopHoc="L02",TenLopHoc="Lập Trình Hướng Đối Tượng",ThanhTien=1500000},
                new LopHoc{MaLopHoc="L03",TenLopHoc="Lập Trình CSDL",ThanhTien=1800000},
            };

            hocviens = new List<HocVien>()
            {
                new HocVien{MaLopHoc="L01",MaHV="A01",TenHV="Nguyễn Minh Anh"},
                new HocVien{MaLopHoc="L01",MaHV="A02",TenHV="Nguyễn Minh Mẫn"},
                new HocVien{MaLopHoc="L02",MaHV="A03",TenHV="Nguyễn Minh Tài"},
                new HocVien{MaLopHoc="L02",MaHV="A04",TenHV="Nguyễn Minh Tấn"},
                new HocVien{MaLopHoc="L03",MaHV="A05",TenHV="Nguyễn Lan"},
                new HocVien{MaLopHoc="L03",MaHV="A06",TenHV="Nguyễn Minh "},

            };
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLop.SelectedIndex == -1 || cboLop.SelectedValue == null)
                return;
            LopHoc lh = cboLop.SelectedItem as LopHoc;
            lblThanhTien.Text = lh.ThanhTien.ToString("#,##0$");

        }

        private void lstHocVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHocVien.SelectedIndex == -1)
                return;

            HocVien hv = lstHocVien.SelectedItem as HocVien;
            GanHocVien(hv); ;


        }

        private void GanHocVien(HocVien hv)
        {

            txtMaHV.Text = hv.MaHV;
            txtTenHV.Text = hv.TenHV;
            cboLop.SelectedValue = hv.MaLopHoc;

        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            HocVien hv;
            if (!txtMaHV.ReadOnly)
            {
                foreach (HocVien a in lstHocVien.Items)
                {
                    if (a.MaHV == txtMaHV.Text)
                    {
                        MessageBox.Show("Mã học viên đã tồn tại. Vui lòng nhập mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaHV.Focus();
                        return;
                    }
                }
                hv = new HocVien();
                hv.MaLopHoc = cboLop.SelectedValue.ToString();
                hv.MaHV = txtMaHV.Text;
                hv.TenHV = txtTenHV.Text;
                hocviens.Add(hv);
                txtMaHV.ReadOnly = true;
            }
            else
            {
                hv = (lstHocVien.SelectedItem) as HocVien;
                hv.TenHV = txtTenHV.Text;
                hv.MaLopHoc = cboLop.SelectedValue.ToString();
            }
            KhoiTaolistBox();

            lstHocVien.SelectedIndex = lstHocVien.Items.IndexOf(hv);

        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            foreach (Control c in grbHocVien.Controls)
            {
                if (c is TextBox)

                    (c as TextBox).Clear();
            }

            txtTenHV.Focus();
            txtMaHV.ReadOnly = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Thoát hay không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.No)
                e.Cancel = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
