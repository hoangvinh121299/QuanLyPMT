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
           
            
        }
        public MainForm(TaiKhoan references)
        {
            InitializeComponent();
            taikhoan = references;
        }
        TaiKhoan taikhoan = new TaiKhoan();
        HoatDongTaiKhoan hoatdongtaikhoan = new HoatDongTaiKhoan();
        About about = new About();
        HoatDongTaiKhoan_BUS hoatdongtaikhoan_BUS = new HoatDongTaiKhoan_BUS();
        private void patientBtn_Click(object sender, EventArgs e)
        {
            if (taikhoan.CAPBAC == 0 || taikhoan.CAPBAC == 1 || taikhoan.CAPBAC == 2 || taikhoan.CAPBAC == 4)         
            {
                QuanLyBenhNhan quanLyBenhNhan = new QuanLyBenhNhan();
                displayPanel.Controls.Clear();
                displayPanel.Controls.Add(quanLyBenhNhan);
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void drugBtn_Click(object sender, EventArgs e)
        {
            if (taikhoan.CAPBAC == 0 || taikhoan.CAPBAC == 1 || taikhoan.CAPBAC == 2 || taikhoan.CAPBAC == 3 ||taikhoan.CAPBAC==4)
            {
                QuanLyThuoc quanLyThuoc = new QuanLyThuoc();
                displayPanel.Controls.Clear();
                displayPanel.Controls.Add(quanLyThuoc);
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sickBtn_Click(object sender, EventArgs e)
        {
            if (taikhoan.CAPBAC == 0 || taikhoan.CAPBAC == 1 )
            {
                QuanLyBenh quanLyBenh = new QuanLyBenh();
                displayPanel.Controls.Clear();
                displayPanel.Controls.Add(quanLyBenh);
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void examBtn_Click(object sender, EventArgs e)
        {
            if (taikhoan.CAPBAC == 0 || taikhoan.CAPBAC == 1)
            {
                KhamBenh khamBenh = new KhamBenh(taikhoan);
                displayPanel.Controls.Clear();
                displayPanel.Controls.Add(khamBenh);
            }
            else
            {
                    MessageBox.Show("Bạn không có quyền truy cập vào chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void accountBtn_Click(object sender, EventArgs e)
        {
            if (taikhoan.CAPBAC == 0 || taikhoan.CAPBAC == 1 || taikhoan.CAPBAC == 2 || taikhoan.CAPBAC == 3 || taikhoan.CAPBAC == 4)
            {
                NhanVien nhanvien = new NhanVien(taikhoan);
                displayPanel.Controls.Clear();
                displayPanel.Controls.Add(nhanvien);
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                hoatdongtaikhoan_BUS.insertHoatDong(taikhoan.MATAIKHOAN, hoatdongtaikhoan.DANGNHAP, hoatdongtaikhoan.DANGXUAT, hoatdongtaikhoan.THOILUONG);
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            ThongKe thongke = new ThongKe();
            displayPanel.Controls.Clear();
            displayPanel.Controls.Add(thongke);
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            about.Dock = DockStyle.Fill;
            displayPanel.Controls.Add(about);
        }
    }
}