using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            benhNhan_BUS.deleteBenhNhan(fromTable.MABENHNHAN);
            MessageBox.Show("Xoá thông tin thành công");
            showData();
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
        }
        private void setValueToForm()
        {
            CMNDtextBOX1.Text = fromTable.CMND;
            CMNDtextBox2.Text = fromTable.CMND;
            nameTxtBox.Text = fromTable.HOTEN;
            if(fromTable.GIOITINH=="Nữ")
            {
                femaleBtn.Checked = true;
            }
            birthDateTimePicker.Text = fromTable.NGAYSINH.ToString();
            addressTextbox.Text = fromTable.DIACHI;
            phoneTxtBox.Text = fromTable.SDT;
            noteCbbox.Text = fromTable.GHICHU;
        }
        private void setValuefromForm()
        {
           
            fromForm.CMND = CMNDtextBOX1.Text;
            
            fromForm.HOTEN = nameTxtBox.Text;
            if (femaleBtn.Checked)
            {
                fromForm.GIOITINH = "Nữ";
            }
            else
            {
                fromForm.GIOITINH = "Nam";
            }
            fromForm.NGAYSINH = DateTime.Parse(birthDateTimePicker.Text);
            fromForm.DIACHI = addressTextbox.Text;
            fromForm.SDT = phoneTxtBox.Text;
            fromForm.GHICHU = noteCbbox.Text;
        }
        private void adddBtn_Click(object sender, EventArgs e)
        {
            isUsingAdd = true;
            isUsingUpdate = false;
            adddBtn.Visible = false;
            examBtn.Visible = false;
            updateBtn.Visible = false;
            saveBtn.Visible = true;
            cancelBtn.Visible = true;
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
        }
        private void loadForm()
        {
            
            adddBtn.Visible = true;
            examBtn.Visible = true;
            updateBtn.Visible = true; ;
            saveBtn.Visible = false ;
            cancelBtn.Visible = false;
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(isUsingAdd)
            {
                try
                {
                    setValuefromForm();
                    benhNhan_BUS.addBenhNhan(
                                             fromForm.CMND,
                                             fromForm.NGAYSINH,
                                             fromForm.HOTEN,
                                             fromForm.GIOITINH,
                                             fromForm.DIACHI,
                                             fromForm.SDT,
                                             fromForm.GHICHU);
                    showData();
                    return;
                }
                catch(Exception)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình thêm dữ liệu");
                }
            }
            else if(isUsingUpdate)
            {
                try
                {
                    setValuefromForm();
                    
                    benhNhan_BUS.updateBenhNhan(fromForm.MABENHNHAN,
                                             fromForm.CMND,
                                             fromForm.NGAYSINH,
                                             fromForm.HOTEN,
                                             fromForm.GIOITINH,
                                             fromForm.DIACHI,
                                             fromForm.SDT,
                                             fromForm.GHICHU);
                    showData();
                    return;
                }
                catch (Exception)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình thêm dữ liệu");

                }

            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string temp;
            temp = CMNDtextBox2.Text;
            showSearchResult(temp);
        }
    }
}
