using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.DAO;

namespace DoAn
{
    public partial class FHoaDon : Form
    {
        public FHoaDon()
        {
            InitializeComponent();
            XuLyALL a = new XuLyALL();          
            loadHoadon();
        }
        public void loadHoadon()
        {
            lvHoadon.Items.Clear();
            XuLyALL danhsach = new XuLyALL();
            HoaDon[] hoaDons = danhsach.GetListOfHoaDon();
            foreach (HoaDon hoadon in hoaDons)
            {
                ListViewItem lvItem = new ListViewItem(hoadon.Datphong.MaDatPhong.ToString());
                lvItem.SubItems.Add(hoadon.Traphong.MaTraPhong.ToString());
                lvItem.SubItems.Add(hoadon.Datphong.khachhang.Id.ToString());
                lvItem.SubItems.Add(hoadon.Datphong.khachhang.Name.ToString());
                lvItem.SubItems.Add(hoadon.Datphong.phong.Name.ToString());
                lvItem.SubItems.Add(hoadon.Datphong.Ngaydat.ToString());
                lvItem.SubItems.Add(hoadon.Traphong.Ngaytra.ToString());
                lvItem.SubItems.Add(hoadon.tien.ToString());
                lvHoadon.Items.Add(lvItem);
            }
        }
    }
}
