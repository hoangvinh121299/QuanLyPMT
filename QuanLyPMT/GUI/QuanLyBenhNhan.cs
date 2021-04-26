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
    public partial class QuanLyBenhNhan : UserControl
    {
        public QuanLyBenhNhan()
        {
            InitializeComponent();
            showData();
            setValueToForm();
            loadForm();
        }
        BenhNhan fromTable = new BenhNhan();
        BenhNhan fromForm = new BenhNhan();
        BenhNhan_BUS benhNhan_BUS = new BenhNhan_BUS();
        bool isUsingAdd = false;
        bool isUsingUpdate = false;
        void showData()
        {
            danhSachBenhNhanDgv.DataSource = benhNhan_BUS.getData().Tables[0];
        }
        void showSearchResult(string CMND)
        {
            danhSachBenhNhanDgv.DataSource = benhNhan_BUS.searchBenhNhan(CMND).Tables[0];
        }
        void showHistoryExam(int MABENHNHAN)
        {
            historyExamDgv.DataSource= benhNhan_BUS.getHistoryExam(MABENHNHAN).Tables[0];
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show
               ("Bạn có chắc chắn muốn xóa thông tin này, dữ liệu có thể sẽ không được khôi phục",
                "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                benhNhan_BUS.deleteBenhNhan(fromTable.MABENHNHAN);
                MessageBox.Show("Xoá thông tin thành công","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                showData();
            }
        }

        private void danhSachBenhNhanDgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                fromTable.MABENHNHAN = int.Parse(danhSachBenhNhanDgv.Rows[index].Cells["MABN"].Value.ToString());
                fromForm.MABENHNHAN = int.Parse(danhSachBenhNhanDgv.Rows[index].Cells["MABN"].Value.ToString());
                fromTable.CMND = danhSachBenhNhanDgv.Rows[index].Cells["CMND"].Value.ToString();
                fromTable.NGAYSINH = DateTime.Parse(danhSachBenhNhanDgv.Rows[index].Cells["NGAYSINH"].Value.ToString());
                fromTable.GIOITINH = danhSachBenhNhanDgv.Rows[index].Cells["GIOITINH"].Value.ToString();
                fromTable.HOTEN = danhSachBenhNhanDgv.Rows[index].Cells["HOTEN"].Value.ToString();
                fromTable.DIACHI = danhSachBenhNhanDgv.Rows[index].Cells["DIACHI"].Value.ToString();
                fromTable.SDT = danhSachBenhNhanDgv.Rows[index].Cells["SDT"].Value.ToString();
               
            }
            setValueToForm();
            showHistoryExam(fromForm.MABENHNHAN);
        }
        private void setValueToForm()
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
           
        }
        private void setValuefromForm()
        {

            fromForm.CMND = CMNDtextBOX1.Text;

            fromForm.HOTEN = nameTxtBox.Text;
            if (femaleBtn.Checked)
            {
                fromForm.GIOITINH = "Nữ";
            }
            else if(maleBtn.Checked)
            {
                fromForm.GIOITINH = "Nam";
            }
            fromForm.NGAYSINH = DateTime.Parse(birthDateTimePicker.Text);
            fromForm.DIACHI = addressTextbox.Text;
            fromForm.SDT = phoneTxtBox.Text;
           
        }
        private void adddBtn_Click(object sender, EventArgs e)
        {
            clearForm();
            isUsingAdd = true;
            isUsingUpdate = false;
            adddBtn.Visible = false;
            examBtn.Visible = false;
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
            examBtn.Visible = false;
            updateBtn.Visible = false;
            saveBtn.Visible = true;
            cancelBtn.Visible = true;
            unloadForm();
           
        }
        private void loadForm()
        {

            adddBtn.Visible = true;
            examBtn.Visible = true;
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
            danhSachBenhNhanDgv.AutoResizeColumns();

        }

        void unloadForm()
        {
            nameTxtBox.Enabled = true;
            CMNDtextBOX1.Enabled = true;
            femaleBtn.Enabled = true;
            phoneTxtBox.Enabled = true;
            CMNDtextBox2.Enabled = false;
            addressTextbox.Enabled = true;
            birthDateTimePicker.Enabled = true;

        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (isUsingAdd)
            {
                try
                {
                    setValuefromForm();
                    if (checkData())
                    {
                        benhNhan_BUS.addBenhNhan(
                                                 fromForm.CMND,
                                                 fromForm.NGAYSINH,
                                                 fromForm.HOTEN,
                                                 fromForm.GIOITINH,
                                                 fromForm.DIACHI,
                                                 fromForm.SDT,
                                                 fromForm.GHICHU);
                        showData();
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
                    setValuefromForm();
                    if (checkData())
                    {
                        benhNhan_BUS.updateBenhNhan(fromForm.MABENHNHAN,
                                                 fromForm.CMND,
                                                 fromForm.NGAYSINH,
                                                 fromForm.HOTEN,
                                                 fromForm.GIOITINH,
                                                 fromForm.DIACHI,
                                                 fromForm.SDT
                                                 );
                        showData();
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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string temp;
            temp = CMNDtextBox2.Text;
            showSearchResult(temp);
        }
        private bool checkData()
        {
            if (string.IsNullOrEmpty(nameTxtBox.Text))
            {
                MessageBox.Show("Bạn chưa nhập họ tên bệnh nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nameTxtBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(CMNDtextBOX1.Text))
            {
                MessageBox.Show("Bạn chưa nhập số CMND của bệnh nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CMNDtextBOX1.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(phoneTxtBox.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại bệnh nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phoneTxtBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(addressTextbox.Text))
            {
                MessageBox.Show("Bạn chưa nhập danh mục cho sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        //Hàm kiểm tra có phải là số hay không 
        private bool IsNumber(string exText)
        {
            Regex regex = new Regex(@"^[-+]?[1-9]*\.?[0-9]+[0-9]$");
            return regex.IsMatch(exText);
        }

        private void nameTxtBox_Leave(object sender, EventArgs e)
        {
            TextInfo text = new CultureInfo("en-US", false).TextInfo;
            nameTxtBox.Text = text.ToTitleCase(nameTxtBox.Text);
        }

        private void clearForm()
        {
            nameTxtBox.Text = null;
            CMNDtextBOX1.Text = null;
            femaleBtn.Checked = false;
            phoneTxtBox.Text = null;
            addressTextbox.Text = null;
      
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy bỏ thao tác đang thực hiện", 
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

        private void danhSachBenhNhanDgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            danhSachBenhNhanDgv.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }

        private void CMNDtextBox2_TextChanged(object sender, EventArgs e)
        {
            string temp;
            temp = CMNDtextBox2.Text;
            showSearchResult(temp);
        }

        private void historyExamDgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            historyExamDgv.Rows[e.RowIndex].Cells["numericID"].Value = (e.RowIndex + 1).ToString();
        }
        //Something new here to test QuanLyBenhNhan branch
    }
}
