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
using BUS;
using DTO;
using Org.BouncyCastle.Crypto.Generators;

namespace GUI
{
    public partial class loginForm : MetroSetForm
    {
        public loginForm()
        {
            InitializeComponent();

        }
        TaiKhoan taikhoan = new TaiKhoan();
        TaiKhoan_BUS taikhoan_BUS = new TaiKhoan_BUS();
        string TENDANGNHAP = "";
        string MATKHAU = "";
        private void validateAccount()
        {
            setValueFromForm();
            if (taikhoan_BUS.validateAccount(TENDANGNHAP, MATKHAU))
            //if(true)
            {
                taikhoan = taikhoan_BUS.getLoginAccount(TENDANGNHAP, MATKHAU);
                MainForm mainForm = new MainForm(taikhoan);
                mainForm.ShowDialog();
                forgetPwrd_Label.Visible = false;
                pwrd_Txttbox.Text = null;
            }
            else
            {
                errorPwrd_Label.Visible = true;                
            }
        }
       public void setValueFromForm()
        {
            TENDANGNHAP = username_Txtbox.Text;
            MATKHAU = pwrd_Txttbox.Text;
        }
        public bool checkData()
        {
            if(string.IsNullOrEmpty(username_Txtbox.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                username_Txtbox.Focus();
                return false;
            }
            if(string.IsNullOrEmpty(pwrd_Txttbox.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pwrd_Txttbox.Focus();
                return false;
            }
            return true;
        }
        private void login_btn_Click(object sender, EventArgs e)
        {
            if(checkData())
            {
                validateAccount();
            }
        }

        private void showPwrd_Btn_Click(object sender, EventArgs e)
        {
            if(pwrd_Txttbox.UseSystemPasswordChar)
            {
                pwrd_Txttbox.UseSystemPasswordChar = false;
                showPwrd_Btn.Image = Properties.Resources.visible;

            }
            else
            {
                pwrd_Txttbox.UseSystemPasswordChar = true;
                showPwrd_Btn.Image = Properties.Resources.invisible;

            }
        }

        private void forgetPwrd_linklable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            errorPwrd_Label.Visible = false;
            forgetPwrd_Label.Visible = true;
            
        }

     
    }
}
