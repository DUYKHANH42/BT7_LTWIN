using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BT7
{
    public partial class Form1 : Form
    {
        List<LopHoc> lophocs;
        List<HocVien> hocviens;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DuLieuSan();
            TapHopLH();
            TapHopHV();
        }

        private void TapHopLH()
        {
            cboLop.DataSource = null;
            cboLop.DisplayMember = "TenLopHoc";
            cboLop.ValueMember = "MaLopHoc";
            cboLop.DataSource = lophocs;
        }

        private void DuLieuSan()
        {
            lophocs = new List<LopHoc>()
            {
                new LopHoc{MaLopHoc="L01",TenLopHoc="Lập Trình WinDow"},
                new LopHoc{MaLopHoc="L02",TenLopHoc="Lập Trình Hướng Đối Tượng"},
                new LopHoc{MaLopHoc="L03",TenLopHoc="Lập Trình CSDL"},
            };

            hocviens = new List<HocVien>()
            {
                new HocVien {MaLopHoc="L01",MaHV="A01",TenHV="Nguyễn Văn A",GioiTinh=true,NgaySinh=new DateTime(2005/04/02),DiaChi="74 Đồng Đen" },
                new HocVien {MaLopHoc="L01",MaHV="A02",TenHV="Nguyễn Thị Hạnh",GioiTinh=false,NgaySinh=new DateTime(2005/24/01),DiaChi="144 Hồng Lạc" },
                new HocVien {MaLopHoc="L01",MaHV="A03",TenHV="Nguyễn Thị My",GioiTinh=false,NgaySinh=new DateTime(2005/04/11),DiaChi="1440 Âu Cơ" },
                new HocVien {MaLopHoc="L02",MaHV="A04",TenHV="Nguyễn Hữu Cầu",GioiTinh=true,NgaySinh=new DateTime(2005/06/03),DiaChi="649 Lê Đại Hành" },
                new HocVien {MaLopHoc="L02",MaHV="A05",TenHV="Đặng Nguyễn Duy Khanh",GioiTinh=false,NgaySinh=new DateTime(2005/06/03),DiaChi="649 Lê Lợi" },
                new HocVien {MaLopHoc="L03",MaHV="A06",TenHV="Đặng Nguyễn Minh An",GioiTinh=false,NgaySinh=new DateTime(2005/20/7),DiaChi="123 Trường Sơn" },
                new HocVien {MaLopHoc="L03",MaHV="A07",TenHV=" Nguyễn Minh ",GioiTinh=true,NgaySinh=new DateTime(2005/10/2),DiaChi="145 Âu Dương Lân" }
            };
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maLopHoc = cboLop.SelectedValue.ToString();
            List<HocVien> hocVienTheoLop = new List<HocVien>();

            foreach (HocVien dshocvien in hocviens)

                if (dshocvien.MaLopHoc == maLopHoc)

                    hocVienTheoLop.Add(dshocvien);

            TapHopHV();
        }

        private void TapHopHV()
        {
            lstHocVien.DataSource = null;
            lstHocVien.DisplayMember = "TenHV";
            lstHocVien.ValueMember = "MaHV";
            lstHocVien.DataSource = hocviens;
        }

        private void lstHocVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHocVien.SelectedIndex == -1)
                return;

            HocVien hv = (lstHocVien.SelectedItem) as HocVien;
            GanHocVien(hv);
        }

        private void GanHocVien(HocVien hv)
        {
            txtMaHv.Text = hv.MaHV;
            txtHoTen.Text = hv.TenHV;
            txtGioiTinh.Text = hv.GioiTinh ? "Nam" : "Nữ";
            txtNgaySinh.Text = hv.NgaySinh.ToShortDateString();
            txtDiaChi.Text = hv.DiaChi;
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            foreach (Control c in grpHocVien.Controls)
            {
                if (c is TextBox)

                    (c as TextBox).Clear();
            }

            txtMaHv.Focus();
            txtMaHv.ReadOnly = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            HocVien hv;
            if (!txtMaHv.ReadOnly)
            {
                foreach (HocVien a in lstHocVien.Items)
                {
                    if (a.MaHV == txtMaHv.Text)
                    {
                        MessageBox.Show("Mã học viên đã tồn tại. Vui lòng nhập mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaHv.Focus();
                        return;
                    }
                }
                KiemTraTXT();
                hv = new HocVien();
                hv.MaLopHoc = cboLop.SelectedValue.ToString();
                hv.MaHV = txtMaHv.Text;
                hv.TenHV = txtHoTen.Text;
                hv.GioiTinh = txtGioiTinh.Text.ToUpper() == "NAM" ? true : false;
                hv.NgaySinh = DateTime.Parse(txtNgaySinh.Text);
                hv.DiaChi = txtDiaChi.Text;
                hocviens.Add(hv);
                lstHocVien.SelectedIndex = lstHocVien.Items.IndexOf(hv);
                txtMaHv.ReadOnly = true;
            }
            else
            {
                KiemTraTXT();
                hv = (lstHocVien.SelectedItem) as HocVien;
                hv.TenHV = txtHoTen.Text;
                hv.GioiTinh = txtGioiTinh.Text.ToUpper() == "NAM" ? true : false;
                hv.NgaySinh = DateTime.Parse(txtNgaySinh.Text);
                hv.DiaChi = txtDiaChi.Text;
                lstHocVien.SelectedIndex = lstHocVien.Items.IndexOf(hv);
            }
            cboLop_SelectedIndexChanged(sender, e);
        }
        private void KiemTraTXT()
        {

            if (txtGioiTinh.Text.ToUpper() != "NAM" && txtGioiTinh.Text.ToUpper() != "NỮ")
            {
                MessageBox.Show("Giới tính là Nam hoặc Nữ vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGioiTinh.Focus();
                return;
            }
            if (txtGioiTinh.Text == "" as string)
            {
                MessageBox.Show("Giới tính không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGioiTinh.Focus();
                return;
            }
            if (txtNgaySinh.Text == "" as string)
            {
                MessageBox.Show("Ngày sinh không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGioiTinh.Focus();
                return;
            }
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Tên không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGioiTinh.Focus();
                return;
            }
            if (txtMaHv.Text == "")
            {
                MessageBox.Show("Mã học viên không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGioiTinh.Focus();
                return;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Địa chỉ không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGioiTinh.Focus();
                return;
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstHocVien.SelectedIndex == -1)
                return;
            DialogResult kq = MessageBox.Show("Muốn Xoá Hay Không!(Y/N)", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                HocVien hv = lstHocVien.SelectedItem as HocVien;
                if (hv != null)
                {
                    // Xóa học viên khỏi danh sách dữ liệu (hocviens)
                    hocviens.Remove(hv);

                    // Xóa học viên khỏi ListBox
                    hocviens.Remove(hv);

                    if (lstHocVien.Items.Count != 0)
                    {
                        lstHocVien.SelectedIndex = 0;
                        txtMaHv.Clear();
                        txtHoTen.Clear();
                        txtGioiTinh.Clear();
                        txtNgaySinh.Clear();
                        txtDiaChi.Clear();
                        txtMaHv.Focus();
                    }
                }
                cboLop_SelectedIndexChanged(sender, e);
            }
        }
    }
}


