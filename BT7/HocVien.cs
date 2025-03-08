using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class HocVien
    {
    private string malophoc;
    private string mahv;
    private string tenhv;
    private Boolean gioitinh;
    private DateTime ngaysinh;
    private string diachi;
    
    public string MaLopHoc
    {
        get { return malophoc; }
        set { malophoc = value; }
    }
    public string MaHV
    {
        get { return mahv; }
        set { mahv = value; }
    }
    public string TenHV
    {
        get { return tenhv; }
        set { tenhv = value; }
    }
    public Boolean GioiTinh
    {
        get { return gioitinh; }
        set { gioitinh = value; }
    }
    public DateTime NgaySinh
    {
        get { return ngaysinh; }
        set { ngaysinh = value; }
    }
    public string DiaChi
    {
        get { return diachi; }
        set { diachi = value; }
    }
}

