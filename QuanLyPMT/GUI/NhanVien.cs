﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class NhanVien : UserControl
    {
        Nhanvien fromTable = new Nhanvien();
        Nhanvien fromForm = new Nhanvien();
        Nhanvien_BUS nhanvien_BUS = new Nhanvien_BUS();
        bool isUsingAdd;
        bool isUsingUpdate;
        public NhanVien()
        {
            InitializeComponent();
            showAllData();
            loadForm();
        }

        public void showAllData()
        {
            danhSachNhanVien_DGV.DataSource = nhanvien_BUS.getDataNhanVien().Tables[0];
        }
        public void showHistoryWork(int MANV)
        {
            danhsachBenhAn_DGV.DataSource = nhanvien_BUS.getHistoryWork(MANV).Tables[0];
        }
        private void danhSachNhanVien_DGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            if (index >= 0)
            {
                fromTable.MANV = int.Parse(danhSachNhanVien_DGV.Rows[index].Cells["MANV"].Value.ToString());
                fromForm.MANV = int.Parse(danhSachNhanVien_DGV.Rows[index].Cells["MANV"].Value.ToString());
                fromTable.CMND = danhSachNhanVien_DGV.Rows[index].Cells["CMND"].Value.ToString();
                fromTable.NGAYSINH = DateTime.Parse(danhSachNhanVien_DGV.Rows[index].Cells["NGAYSINH"].Value.ToString());
                fromTable.GIOITINH = danhSachNhanVien_DGV.Rows[index].Cells["GIOITINH"].Value.ToString();
                fromTable.HOTEN = danhSachNhanVien_DGV.Rows[index].Cells["HOTEN"].Value.ToString();
                fromTable.DIACHI = danhSachNhanVien_DGV.Rows[index].Cells["DIACHI"].Value.ToString();
                fromTable.SDT = danhSachNhanVien_DGV.Rows[index].Cells["SDT"].Value.ToString();
                fromTable.CHUCVU = danhSachNhanVien_DGV.Rows[index].Cells["CHUCVU"].Value.ToString();

            }
            showHistoryWork(fromTable.MANV);
            setValueToForm();
            //showHistoryExam(fromForm.MABENHNHAN);
        }

        public void setValueToForm()
        {
            CMNDtextBOX1.Text = fromTable.CMND;

            nameTxtBox.Text = fromTable.HOTEN;
            if (fromTable.GIOITINH == "Nữ")
            {
                femaleBtn.Checked = true;
                maleBtn.Checked = false;
            }
            else
            {
                femaleBtn.Checked = false;
                maleBtn.Checked = true;

            }
            birthDateTimePicker.Text = fromTable.NGAYSINH.ToString();
            addressTextbox.Text = fromTable.DIACHI;
            phoneTxtBox.Text = fromTable.SDT;

            positionCbb.Text = fromTable.CHUCVU;
        }
        public void setValuFromForm()
        {
            fromForm.CMND = CMNDtextBOX1.Text;

            fromForm.HOTEN = nameTxtBox.Text;
            if (femaleBtn.Checked)
            {
                fromForm.GIOITINH = "Nữ";
            }
            else if (maleBtn.Checked)
            {
                fromForm.GIOITINH = "Nam";
            }
            fromForm.NGAYSINH = DateTime.Parse(birthDateTimePicker.Text);
            fromForm.DIACHI = addressTextbox.Text;
            fromForm.SDT = phoneTxtBox.Text;
            fromForm.CHUCVU = positionCbb.Text;

        }
        //Lỗi khoá ngoại không xoá được, phải xoá tất cả bệnh án
        //thêm cờ isDelete cho các hàng
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show
              ("Bạn có chắc chắn muốn xóa thông tin này, dữ liệu có thể sẽ không được khôi phục",
               "Thông báo",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                nhanvien_BUS.deleteNhanvien(fromTable.MANV);
                MessageBox.Show("Xoá thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showAllData();
            }
        }
        public bool checkData()
        {
            if (string.IsNullOrEmpty(nameTxtBox.Text))
            {
                MessageBox.Show("Bạn chưa nhập họ tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nameTxtBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(CMNDtextBOX1.Text))
            {
                MessageBox.Show("Bạn chưa nhập số CMND của nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMNDtextBOX1.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(phoneTxtBox.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phoneTxtBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(addressTextbox.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ cho nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                addressTextbox.Focus();
                return false;
            }
            if (IsNumber(CMNDtextBOX1.Text) == false)
            {
                MessageBox.Show("CMND không hợp lệ, CMND chỉ chứa chữ số ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMNDtextBOX1.Focus();
                return false;
            }
            if (IsNumber(phoneTxtBox.Text) == false)
            {
                MessageBox.Show("Số điện thoại không hợp lệ, SDT chỉ chứa chữ số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phoneTxtBox.Focus();
                return false;
            }
            if (phoneTxtBox.TextLength < 9)
            {
                MessageBox.Show("Số điện thoại không hợp lệ, vui lòng nhập ít nhất 9 chữ số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phoneTxtBox.Focus();
                return false;
            }

            return true;
        }
        private bool IsNumber(string exText)
        {
            Regex regex = new Regex(@"^[-+]?[1-9]*\.?[0-9]+[0-9]$");
            return regex.IsMatch(exText);
        }
        private void clearForm()
        {
            nameTxtBox.Text = null;
            CMNDtextBOX1.Text = null;
            femaleBtn.Checked = false;
            phoneTxtBox.Text = null;
            addressTextbox.Text = null;

        }
        private void loadForm()
        {

            adddBtn.Visible = true;
           
            updateBtn.Visible = true; ;
            saveBtn.Visible = false;
            cancelBtn.Visible = false;
            nameTxtBox.Enabled = false;
            CMNDtextBOX1.Enabled = false;
            femaleBtn.Enabled = false;
            maleBtn.Enabled = false;    
            phoneTxtBox.Enabled = false;
            CMNDtextBox2.Enabled = true;
            addressTextbox.Enabled = false;
            birthDateTimePicker.Enabled = false;
            positionCbb.Enabled = false;


        }
        void unloadForm()
        {
            nameTxtBox.Enabled = true;
            CMNDtextBOX1.Enabled = true;
            femaleBtn.Enabled = true;
            maleBtn.Enabled = true;
            phoneTxtBox.Enabled = true;
            CMNDtextBox2.Enabled = false;
            addressTextbox.Enabled = true;
            birthDateTimePicker.Enabled = true;
            positionCbb.Enabled = true;
        }
        private void adddBtn_Click(object sender, EventArgs e)
        {
            clearForm();
            isUsingAdd = true;
            isUsingUpdate = false;
            adddBtn.Visible = false;
            updateBtn.Visible = false;
            saveBtn.Visible = true;
            cancelBtn.Visible = true;

            unloadForm();

        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            isUsingAdd = false;
            isUsingUpdate = true;
            adddBtn.Visible = false;
            
            updateBtn.Visible = false;
            saveBtn.Visible = true;
            cancelBtn.Visible = true;
            unloadForm();

        }
        private void nameTxtBox_Leave(object sender, EventArgs e)
        {
            TextInfo text = new CultureInfo("en-US", false).TextInfo;
            nameTxtBox.Text = text.ToTitleCase(nameTxtBox.Text);
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy bỏ thao tác đang thực hiện ?",
                                "Thông báo",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                loadForm();
            }
        }
        private void addressTextbox_Leave(object sender, EventArgs e)
        {
            TextInfo text = new CultureInfo("en-US", false).TextInfo;
            addressTextbox.Text = text.ToTitleCase(addressTextbox.Text);
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (isUsingAdd)
            {
                try
                {
                    setValuFromForm();
                    if (checkData())
                    {
                        nhanvien_BUS.addNhanvien(
                                                 fromForm.CMND,
                                                 fromForm.NGAYSINH,
                                                 fromForm.HOTEN,
                                                 fromForm.GIOITINH,
                                                 fromForm.DIACHI,
                                                 fromForm.SDT,
                                                 fromForm.CHUCVU
                                                 );
                        showAllData();
                        loadForm();
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình thêm dữ liệu");
                }
            }
            else if (isUsingUpdate)
            {
                try
                {
                    setValuFromForm();
                    if (checkData())
                    {
                        nhanvien_BUS.updateNhanvien(fromForm.MANV,
                                                 fromForm.CMND,
                                                 fromForm.NGAYSINH,
                                                 fromForm.HOTEN,
                                                 fromForm.GIOITINH,
                                                 fromForm.DIACHI,
                                                 fromForm.SDT,
                                                 fromForm.CHUCVU
                                                 );
                        showAllData();
                        loadForm();
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình cập nhật dữ liệu");
                }

            }

        }

        private void danhSachNhanVien_DGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            danhSachNhanVien_DGV.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }

        private void danhsachBenhAn_DGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            danhsachBenhAn_DGV.Rows[e.RowIndex].Cells["STT1"].Value = (e.RowIndex + 1).ToString();
        }
        public void showSearchResult()
        {
            danhSachNhanVien_DGV.DataSource = nhanvien_BUS.searchNV(CMNDtextBox2.Text).Tables[0];
        }
        private void CMNDtextBox2_TextChanged(object sender, EventArgs e)
        {
            if (CMNDtextBox2.Text == "")
                showAllData();
            else
            {
                showSearchResult();
            }
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroSetLabel11_Click(object sender, EventArgs e)
        {

        }

        private void NhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
