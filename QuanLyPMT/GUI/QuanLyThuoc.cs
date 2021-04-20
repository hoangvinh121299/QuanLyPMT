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
    public partial class QuanLyThuoc : UserControl
    {
        public QuanLyThuoc()
        {
            InitializeComponent();
            showData();
            setValueToForm();
            loadForm();
        }
        Thuoc fromTable = new Thuoc();
        Thuoc fromForm = new Thuoc();
        Thuoc_BUS thuoc_BUS = new Thuoc_BUS();
        bool isUsingAdd = false;
        bool isUsingUpdate = false;
        void showData()
        {
            danhSachThuocDgv.DataSource = thuoc_BUS.getData().Tables[0];
        }
        void showSearchResult(string TENTHUOC)
        {
            danhSachThuocDgv.DataSource = thuoc_BUS.searchThuoc(TENTHUOC).Tables[0];
        }
        private void sexCbbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void loadForm()
        {
            addBtn.Visible = true;
            editBtn.Visible = true;
            saveBtn.Visible = false;
            cancelBtn.Visible = false;
            nameTxtBox.Enabled = false;
            unitCbb.Enabled = false;
            useWayCbb.Enabled = false;
            amountTxtBox.Enabled = false;
            priceInTxtBox.Enabled = false;
            priceOutTxtBox.Enabled= false;
            suppliertxtBox.Enabled = false;
            noteTextbox.Enabled = false;
            danhSachThuocDgv.AutoResizeColumns();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void QuanLyThuoc_Load(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (isUsingAdd)
            {
                try
                {
                    setValueFromForm();
                    if (checkData())
                    {
                       thuoc_BUS.addThuoc(
                                                 fromForm.TENTHUOC,
                                                 fromForm.DONVT,
                                                 fromForm.DUONGDUNG,
                                                 fromForm.TONKHO,
                                                 fromForm.GIANHAP,
                                                 fromForm.GIABAN,
                                                 fromForm.NHACUNGCAP,
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
                    setValueFromForm();
                    if (checkData())
                    {
                        thuoc_BUS.updateThuoc(fromForm.MATHUOC,
                                                 fromForm.TENTHUOC,
                                                 fromForm.DONVT,
                                                 fromForm.DUONGDUNG,
                                                 fromForm.TONKHO,
                                                 fromForm.GIANHAP,
                                                 fromForm.GIABAN,
                                                 fromForm.NHACUNGCAP,
                                                 fromForm.GHICHU);
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show
              ("Bạn có chắc chắn muốn xóa thông tin này, dữ liệu có thể sẽ không được khôi phục",
               "Thông báo",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                thuoc_BUS.deleteThuoc(fromTable.MATHUOC);
                MessageBox.Show("Xoá thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showData();
            }
        }

        private void danhSachThuocDgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                fromTable.MATHUOC   = Convert.ToInt32(danhSachThuocDgv.Rows[index].Cells["MALT"].Value.ToString());
                fromForm.MATHUOC    = Convert.ToInt32(danhSachThuocDgv.Rows[index].Cells["MALT"].Value.ToString());
                fromTable.TENTHUOC  = danhSachThuocDgv.Rows[index].Cells["TENLT"].Value.ToString();
                fromTable.DONVT     = danhSachThuocDgv.Rows[index].Cells["DONVT"].Value.ToString();
                fromTable.DUONGDUNG = danhSachThuocDgv.Rows[index].Cells["DUONGDUNG"].Value.ToString();
                fromTable.TONKHO    = Convert.ToInt32(danhSachThuocDgv.Rows[index].Cells["TONKHO"].Value.ToString());
                fromTable.GHICHU    = danhSachThuocDgv.Rows[index].Cells["GHICHU"].Value.ToString();
                fromTable.GIANHAP   = Convert.ToInt32(danhSachThuocDgv.Rows[index].Cells["GIANHAP"].Value.ToString());
                fromTable.GIABAN    = Convert.ToInt32(danhSachThuocDgv.Rows[index].Cells["GIABAN"].Value.ToString());
                fromTable.NHACUNGCAP= danhSachThuocDgv.Rows[index].Cells["NHACUNGCAP"].Value.ToString();
            }
            setValueToForm();
        }
        private void setValueFromForm()
        {
            fromForm.TENTHUOC = nameTxtBox.Text;
            fromForm.DONVT = unitCbb.Text;
            fromForm.DUONGDUNG = useWayCbb.Text;
            fromForm.TONKHO = Convert.ToInt32(amountTxtBox.Text);
            fromForm.GIANHAP = Convert.ToInt32(priceInTxtBox.Text);
            fromForm.GIABAN = Convert.ToInt32(priceOutTxtBox.Text);
            fromForm.NHACUNGCAP = suppliertxtBox.Text;
            fromForm.GHICHU = noteTextbox.Text;
        }
        private void setValueToForm()
        {
            nameTxtBox.Text = fromTable.TENTHUOC;
            nameTextbox.Text = fromTable.TENTHUOC;
            unitCbb.Text = fromTable.DONVT;
            useWayCbb.Text = fromTable.DUONGDUNG;
            amountTxtBox.Text = fromTable.TONKHO.ToString();
            priceInTxtBox.Text = fromTable.GIANHAP.ToString();
            priceOutTxtBox.Text = fromTable.GIABAN.ToString();
            suppliertxtBox.Text = fromTable.NHACUNGCAP;
            noteTextbox.Text = fromTable.GHICHU;
        }
        private bool IsNumber(string exText)
        {
            Regex regex = new Regex(@"^[-+]?[1-9]*\.?[0-9]+[0-9]$");
            return regex.IsMatch(exText);
        }
        private bool checkData()
        {
            if(string.IsNullOrEmpty(nameTxtBox.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nameTxtBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(unitCbb.Text))
            {
                MessageBox.Show("Bạn chưa nhập đơn vị thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                unitCbb.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(useWayCbb.Text))
            {
                MessageBox.Show("Bạn chưa nhập cách dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                useWayCbb.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(amountTxtBox.Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng tồn kho", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                amountTxtBox.Focus();
                return false;
            }
            if (IsNumber(amountTxtBox.Text) == false)
            {
                MessageBox.Show("Số hàng tồn không hợp lệ, Số hàng tồn chỉ chứa chữ số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                amountTxtBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(priceInTxtBox.Text))
            {
                MessageBox.Show("Bạn chưa nhập giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                priceInTxtBox.Focus();
                return false;
            }
            if (IsNumber(priceInTxtBox.Text) == false)
            {
                MessageBox.Show("Giá nhập không hợp lệ, Giá nhập chỉ chứa chữ số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                priceInTxtBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(priceOutTxtBox.Text))
            {
                MessageBox.Show("Bạn chưa nhập giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                priceOutTxtBox.Focus();
                return false;
            }
            if (IsNumber(priceOutTxtBox.Text) == false)
            {
                MessageBox.Show("Giá bán không hợp lệ, Giá bán chỉ chứa chữ số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                priceOutTxtBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(suppliertxtBox.Text))
            {
                MessageBox.Show("Bạn chưa nhập nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                suppliertxtBox.Focus();
                return false;
            }
            return true;
        }
        private void clearForm()
        {
            nameTxtBox.Text = null;
            unitCbb.Text = null;
            useWayCbb.Text = null;
            amountTxtBox.Text = null;
            priceInTxtBox.Text = null;
            priceOutTxtBox.Text = null;
            suppliertxtBox.Text = null;
            noteTextbox.Text = null;
        }
        void unloadForm()
        {
            nameTxtBox.Enabled = true;
            unitCbb.Enabled = true;
            useWayCbb.Enabled = true;
            amountTxtBox.Enabled = true;
            priceInTxtBox.Enabled = true;
            priceOutTxtBox.Enabled = true;
            suppliertxtBox.Enabled = true;
            noteTextbox.Enabled = true;
        }

        private void danhSachThuocDgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
           danhSachThuocDgv.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            clearForm();
            isUsingAdd = true;
            isUsingUpdate = false;
            addBtn.Visible = false;
            editBtn.Visible = false;
            saveBtn.Visible = true;
            cancelBtn.Visible = true;

            unloadForm();
       
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            isUsingAdd = false;
            isUsingUpdate = true;
            addBtn.Visible = false;
            editBtn.Visible = false;
            saveBtn.Visible = true;
            cancelBtn.Visible = true;
            unloadForm();
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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string tmp;
            tmp = nameTextbox.Text;
            showSearchResult(tmp);
        }
    }
}
