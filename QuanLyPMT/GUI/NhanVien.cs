using System;
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
        TaiKhoan output = new TaiKhoan();
        TaiKhoan input = new TaiKhoan();
        TaiKhoan taikhoan = new TaiKhoan();
        Nhanvien_BUS nhanvien_BUS = new Nhanvien_BUS();
        string name = "";
        bool isUsingAdd;
        bool isUsingUpdate;
        bool isVisible = false;
        TaiKhoan_BUS taikhoan_BUS = new TaiKhoan_BUS();
        public NhanVien()
        {
            
        }
        public NhanVien(TaiKhoan references)
        {
            InitializeComponent();
            taikhoan = references;
            showAllData();
            showAllAccount();
            loadForm();
            loadFomr_Account();
        }
        public void showAllData()
        {
            if(taikhoan.CAPBAC ==4)
            danhSachNhanVien_DGV.DataSource = nhanvien_BUS.getDataNhanVien().Tables[0];
            else
            {
                danhSachNhanVien_DGV.DataSource = nhanvien_BUS.getDateNhanVienByMANV(taikhoan.MANV).Tables[0];
                adddBtn.Visible = false;
            }
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
            setValueToForm_Staff();
        }

        public void setValueToForm_Staff()
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
        //Đồng bộ thông tin từ đối tượng bảng sang form (tài khoản)
        public void setValueToForm_Account()
        {
            acc_name_cbb.Text = name;
            acc_username_Textbox.Text = output.TENDANGNHAP;
            acc_pwrd_Textbox.Text = output.MATKHAU;
            switch(output.CAPBAC)
            {
                case 0:
                    acc_permission_Combobox.Text = "Bác sĩ";
                    break;
                case 1:
                    acc_permission_Combobox.Text = "Dược sĩ";
                    break;
                case 2:
                    acc_permission_Combobox.Text = "Thu ngân";
                    break;
                case 3:
                    acc_permission_Combobox.Text = "Kế toán";
                    break;
                case 4:
                    acc_permission_Combobox.Text = "Quản trị viên";
                    break;
            }
        }
        public void setValuefromForm_Account()
        {
            //acc_name_cbb.Text = name;
            //acc_username_Textbox.Text = output.TENDANGNHAP;
            input.TENDANGNHAP = acc_username_Textbox.Text;
            input.MATAIKHOAN = output.MATAIKHOAN;
            input.MATKHAU = acc_pwrd_Textbox.Text;
            switch (acc_permission_Combobox.Text)
            {
                case "Bác sĩ":
                    input.CAPBAC = 0;
                    break;
                case "Dược sĩ":
                    input.CAPBAC = 1;
                    break;
                case "Thu ngân":
                    input.CAPBAC = 2;
                    break;
                case "Kế toán":
                    input.CAPBAC = 3;
                    break;
                case "Quản trị viên":
                    input.CAPBAC = 4;
                    break;
            }
        }
        public void setValuFromForm_Staff()
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

            if (taikhoan.CAPBAC == 4)
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
                    setValuFromForm_Staff();
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
                    setValuFromForm_Staff();
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
        public void showAllAccount()
        {
            if(taikhoan.CAPBAC ==4)
            accountListDGV.DataSource = taikhoan_BUS.showAllTaiKhoan().Tables[0];
            else
            {
                accountListDGV.DataSource = taikhoan_BUS.getTaiKhoanByMATK(taikhoan.MATAIKHOAN).Tables[0];
            }
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            showNameNhanVienInCBB();
            showLoginHistory();
        }

        private void accountListDGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
                int index = e.RowIndex;
                if (index >= 0)
                {
                    output.MATAIKHOAN = int.Parse(accountListDGV.Rows[index].Cells["MATAIKHOAN"].Value.ToString());
                    output.MANV = int.Parse(danhSachNhanVien_DGV.Rows[index].Cells["MANV"].Value.ToString());
                    output.TENDANGNHAP = accountListDGV.Rows[index].Cells["TENDANGNHAP"].Value.ToString();
                    output.MATKHAU = accountListDGV.Rows[index].Cells["MATKHAU"].Value.ToString();
                    output.CAPBAC = int.Parse(accountListDGV.Rows[index].Cells["CAPBAC"].Value.ToString());
                    name = accountListDGV.Rows[index].Cells["HOTEN3"].Value.ToString();
                }
            
            setValueToForm_Account();
        }

        private void acc_add_Btn_Click(object sender, EventArgs e)
        {
            isUsingAdd = true;
            isUsingUpdate = false;
            acc_name_cbb.Enabled = true;
            acc_name_cbb.Text = "";
            acc_username_Textbox.Enabled = true;
            acc_username_Textbox.ReadOnly = false;
            clearForm_Acc();
            unLoadFomr_Account();
            if(taikhoan.CAPBAC == 4)
            {
                acc_add_Btn.Visible = true;
            }
        }
        void loadFomr_Account()
        {
            if (taikhoan.CAPBAC == 4)
                acc_add_Btn.Visible = true;

            acc_update_btn.Visible = true; ;
            acc_save_Btn.Visible = false;
            acc_cancel_Btn.Visible = false;
            acc_name_cbb.Enabled = false;
            acc_pwrd_Textbox.Enabled = false;
            acc_permission_Combobox.Enabled = false;
            acc_username_Textbox.Enabled = false;
            
        }
        void unLoadFomr_Account()
        {
            acc_add_Btn.Visible = false;
            acc_update_btn.Visible = false;
            acc_save_Btn.Visible = true ;
            acc_cancel_Btn.Visible = true ;
            acc_pwrd_Textbox.Enabled = true;
            
        }

        private void acc_cancel_Btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy bỏ thao tác đang thực hiện ?",
                               "Thông báo",
                               MessageBoxButtons.OKCancel,
                               MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                loadFomr_Account();
            }
        }
        private bool checkData_Account()
        {
            if (string.IsNullOrEmpty(acc_username_Textbox.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                acc_username_Textbox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(acc_pwrd_Textbox.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                acc_pwrd_Textbox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(acc_permission_Combobox.Text))
            {
                MessageBox.Show("Bạn chưa chọn quyền quản trị tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                acc_permission_Combobox.Focus();
                return false;
            }
           
            return true;
        }

        private void acc_update_btn_Click(object sender, EventArgs e)
        {
            isUsingAdd = false;
            isUsingUpdate = true;
            
            unLoadFomr_Account();
            if(taikhoan.CAPBAC ==4)
            {
                acc_permission_Combobox.Enabled = true;
            }
        }

        private void acc_save_Btn_Click(object sender, EventArgs e)
        {
            if(isUsingAdd)
            {
                try
                {
                    setValuefromForm_Account();
                    if (checkData_Account())
                    {
                        taikhoan_BUS.addTaiKhoan(input.TENDANGNHAP, input.MATKHAU, input.MANV,input.CAPBAC);
                        showAllAccount();
                        loadFomr_Account();
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình cập nhật dữ liệu");
                }
            }
            else if(isUsingUpdate)
            {
                    try
                    {
                        setValuefromForm_Account();
                        if (checkData_Account())
                        {
                            taikhoan_BUS.updateTaiKhoan(input.MATAIKHOAN, input.MATKHAU, input.CAPBAC);
                            showAllAccount();
                            loadFomr_Account();
                            return;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Xảy ra lỗi trong quá trình cập nhật dữ liệu");
                    }
            }
            
        }
        public void showNameNhanVienInCBB()
        {
            acc_name_cbb.DataSource = nhanvien_BUS.getData().Tables[0];
            acc_name_cbb.ValueMember = "MANV";
            acc_name_cbb.DisplayMember = "HOTEN";
            //acc_name_cbb.SelectedIndex = -1;
        }

        private void acc_name_cbb_TextChanged(object sender, EventArgs e)
        {
            if (acc_name_cbb.Text == "")
            {
                showNameNhanVienInCBB();
            }
            else
            {
                acc_name_cbb.DataSource = nhanvien_BUS.getNameByLikeLy(acc_name_cbb.Text).Tables[0];
                acc_name_cbb.ValueMember = "MANV";
                acc_name_cbb.DisplayMember = "HOTEN";
                //acc_name_cbb.SelectedIndex = -1;
            }
        }
        public void clearForm_Acc()
        {
            acc_name_cbb.Text = "";
            acc_username_Textbox.Text = "";
            acc_pwrd_Textbox.Text = "";
            acc_permission_Combobox.Text = "";
    }

        private void acc_name_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(acc_name_cbb.SelectedValue!= null)
            {
                if (int.Parse(acc_name_cbb.SelectedValue.ToString()) >= 0)
                {
                    try
                    {
                        input.MANV = int.Parse(acc_name_cbb.SelectedValue.ToString());
                    }
                    catch (Exception e1)
                    {

                    }
                }
            }
        }

        private void showPwrd_Btn_Click(object sender, EventArgs e)
        {
            if(isVisible)
            {
                showPwrd_Btn.Image = Properties.Resources.invisible;
                acc_pwrd_Textbox.UseSystemPasswordChar = true;
                isVisible = false;
            }
            else
            {
                showPwrd_Btn.Image = Properties.Resources.visible;
                acc_pwrd_Textbox.UseSystemPasswordChar = false;
                isVisible = true;
            }
        }

        private void acc_search_name_textbox_TextChanged(object sender, EventArgs e)
        {
            if (acc_name_cbb.Text == "")
            {
                showAllAccount();
            }
            else
            {
                accountListDGV.DataSource=  taikhoan_BUS.SearchTaiKhoanByName(acc_search_name_textbox.Text).Tables[0];
            }
        }

        private void accountListDGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            accountListDGV.Rows[e.RowIndex].Cells["STT3"].Value = (e.RowIndex + 1).ToString();
        }

        public void showLoginHistory()
        {
            loginHistoryDGV.DataSource = new HoatDongTaiKhoan_BUS().getHistoryLogin(output.MATAIKHOAN).Tables[0];
        }

        private void loginHistoryDGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            loginHistoryDGV.Rows[e.RowIndex].Cells["STT2"].Value = (e.RowIndex + 1).ToString();

        }
    }
}
