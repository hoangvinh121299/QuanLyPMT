using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;
using DTO;
using BUS;
namespace GUI
{
    public partial class MainForm : MetroSetForm
    {
        public MainForm()
        {
            InitializeComponent();
            
        }
        HoatDongTaiKhoan hoatdongtaikhoan = new HoatDongTaiKhoan();
        HoatDongTaiKhoan_BUS hoatdongtaikhoan_BUS = new HoatDongTaiKhoan_BUS();
        private void patientBtn_Click(object sender, EventArgs e)
        {
            QuanLyBenhNhan quanLyBenhNhan = new QuanLyBenhNhan();
            displayPanel.Controls.Clear();
            displayPanel.Controls.Add(quanLyBenhNhan);
        }

        private void drugBtn_Click(object sender, EventArgs e)
        {
            QuanLyThuoc quanLyThuoc = new QuanLyThuoc();
            displayPanel.Controls.Clear();
            displayPanel.Controls.Add(quanLyThuoc);
        }

        private void sickBtn_Click(object sender, EventArgs e)
        {
            QuanLyBenh quanLyBenh = new QuanLyBenh();
            displayPanel.Controls.Clear();
            displayPanel.Controls.Add(quanLyBenh);
        }

        private void examBtn_Click(object sender, EventArgs e)
        {
            KhamBenh khamBenh = new KhamBenh();
            displayPanel.Controls.Clear();
            displayPanel.Controls.Add(khamBenh);
        }

        private void accountBtn_Click(object sender, EventArgs e)
        {
            NhanVien nhanvien = new NhanVien();
            displayPanel.Controls.Clear();
            displayPanel.Controls.Add(nhanvien);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ra khỏi chương trình không ?",
                               "Thông báo",
                               MessageBoxButtons.OKCancel,
                               MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                hoatdongtaikhoan.DANGXUAT = DateTime.Now;
                CalculateTimeForLogin();
                hoatdongtaikhoan_BUS.insertHoatDong(1, hoatdongtaikhoan.DANGNHAP, hoatdongtaikhoan.DANGXUAT, hoatdongtaikhoan.THOILUONG);
                this.Close();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            hoatdongtaikhoan.DANGNHAP = DateTime.Now;
        }

        public void CalculateTimeForLogin()
        {
            hoatdongtaikhoan.THOILUONG = hoatdongtaikhoan.DANGXUAT - hoatdongtaikhoan.DANGNHAP;
        }
    }
}