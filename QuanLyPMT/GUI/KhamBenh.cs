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
    public partial class KhamBenh : UserControl
    {

        public KhamBenh()
        {
            InitializeComponent();
           
        }
        DonThuoc_BUS donThuoc_BUS = new DonThuoc_BUS();
        DonThuoc donThuoc = new DonThuoc();
        benhAn_BUS BENHAN_BUS = new benhAn_BUS();
        BenhNhan_BUS BENHNHAN_BUS = new BenhNhan_BUS();
        DanhSachKhamBenh_BUS danhsachkhambenh_BUS = new DanhSachKhamBenh_BUS();
        //Dùng để lấy dữ liệu từ bảng
        BenhAN fromTable = new BenhAN();
        DonThuoc test = new DonThuoc();
        BenhAN fromForm = new BenhAN();
        //Lấy dữ liệu nhập từ form
        bool isUsingAdd, isUsingUpdate = false;
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        
        private void KhamBenh_Load(object sender, EventArgs e)
        {
            showDanhSachBenhNhan();
            loadForm();
            thuoc_cbb.DataSource = donThuoc_BUS.getDataForNametbox().Tables[0];
            thuoc_cbb.ValueMember = "malt";
            thuoc_cbb.DisplayMember = "tenlt";
            
        }

        private void examTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void showDataBenhAnByID()
        {
            benAnDGV.DataSource = BENHAN_BUS.getDataByID(fromTable.MABN).Tables[0];
        }
        void showDanhSachBenhNhan()
        {
            benhNhanListDGV.DataSource = danhsachkhambenh_BUS.getDanhSachBenhNhanInDay().Tables[0];
        }
        void showSearchResult(string CMND)
        {
            benhNhanListDGV.DataSource = danhsachkhambenh_BUS.searchBenhNhanFromDanhSach(CMND).Tables[0];
        }
        private void benhNhanListDGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                    fromTable.MABN = int.Parse(benhNhanListDGV.Rows[index].Cells["MABN1"].Value.ToString());
                    fromTable.HOTEN = benhNhanListDGV.Rows[index].Cells["HOTEN"].Value.ToString();
            }
            nameTxtBox.Text = fromTable.HOTEN;
            fromForm.HOTEN = nameTxtBox.Text;
            fromForm.MABN = fromTable.MABN;
            showDataBenhAnByID();
        }

        private void benAnDGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            benAnDGV.Rows[e.RowIndex].Cells["STT1"].Value = (e.RowIndex + 1).ToString();
        }

        private void benhNhanListDGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            benhNhanListDGV.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }
        void deleteDataBenhAn(int MABA)
        {
            BENHAN_BUS.deleteBenhAn(MABA);
        }
        private void deleteBtn_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show
               ("Bạn có chắc chắn muốn xóa thông tin này, dữ liệu có thể sẽ không được khôi phục",
                "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                    deleteDataBenhAn(fromTable.MABA);
                    MessageBox.Show("Xoá thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showDataBenhAnByID();
            }
        }

        private void benAnDGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                fromTable.MABA = int.Parse(benAnDGV.Rows[index].Cells["MABA"].Value.ToString());
                fromForm.MABA = int.Parse(benAnDGV.Rows[index].Cells["MABA"].Value.ToString());
                //fromForm.MABENHNHAN = int.Parse(benAnDGV.Rows[index].Cells["MABN"].Value.ToString());
                fromTable.NGAYLAP = DateTime.Parse(benAnDGV.Rows[index].Cells["NGAYLAP"].Value.ToString());
                fromTable.NGAYTAIKHAM = DateTime.Parse(benAnDGV.Rows[index].Cells["NGAYTAIKHAM"].Value.ToString());
                fromTable.MABN = int.Parse(benAnDGV.Rows[index].Cells["MABN"].Value.ToString());
                try
                {
                    fromTable.MANV = int.Parse(benAnDGV.Rows[index].Cells["MANV"].Value.ToString());
                }
                catch(Exception )
                {

                }

                //fromTable.TIENSUBENH = benAnDGV.Rows[index].Cells["TIENSUBENH"].Value.ToString();
                //fromTable.TRIEUCHUNG = benAnDGV.Rows[index].Cells["TRIEUCHUNG"].Value.ToString();
                //fromTable.LOAIBENH = benAnDGV.Rows[index].Cells["LOAIBENH"].Value.ToString();
                //fromTable.CHANDOAN = benAnDGV.Rows[index].Cells["CHANDOAN"].Value.ToString();
                //fromTable.HUONGXULY = benAnDGV.Rows[index].Cells["HUONGXULY"].Value.ToString();
               // fromTable.GHICHU = benAnDGV.Rows[index].Cells["GHICHU"].Value.ToString();
            }
            setValueToForm(fromTable);
        }
        //Đổ dữ liệu vào form
        public void setValueToForm(BenhAN benhAN)
        {
            ngayKhamDTPicker.Text = benhAN.NGAYLAP.ToString();
            ngayTaiKhamDTPicker.Text = benhAN.NGAYTAIKHAM.ToString();
            //nameTxtBox.Text = benhAN.HOTEN;
            tienSuBenhTxtBox.Text = benhAN.TIENSUBENH;
            chanDoanCBB.Text = benhAN.CHANDOAN;
            noteTextBox.Text = benhAN.GHICHU;
            trieuchungTxtBox.Text = benhAN.TRIEUCHUNG;
            loaiBenhCBB.Text = benhAN.LOAIBENH;
            huongxulyTxtBox.Text = benhAN.HUONGXULY;
        }
        //Nạp dữ liệu từ form
        public void setValueFromForm()
        {
            fromForm.NGAYLAP = ngayKhamDTPicker.Value;
            fromForm.NGAYTAIKHAM = ngayTaiKhamDTPicker.Value;
            fromForm.HOTEN = nameTxtBox.Text;
            fromForm.TIENSUBENH = tienSuBenhTxtBox.Text;
            fromForm.CHANDOAN = chanDoanCBB.Text;
            fromForm.TRIEUCHUNG = trieuchungTxtBox.Text;
            fromForm.LOAIBENH = loaiBenhCBB.Text;
            fromForm.HUONGXULY = huongxulyTxtBox.Text;
            fromForm.GHICHU = noteTextBox.Text;
        }
        private void adddBtn_Click(object sender, EventArgs e)
        {
            unLoadForm();
            clearForm();
            isUsingAdd = true;
            isUsingUpdate = false;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            unLoadForm();
            isUsingAdd = false;
            isUsingUpdate = true;
        }

        void loadForm()
        {
            ngayKhamDTPicker.Enabled = false;
            ngayTaiKhamDTPicker.Enabled = false;
            tienSuBenhTxtBox.Enabled = false;
            chanDoanCBB.Enabled = false;
            trieuchungTxtBox.Enabled = false;
            loaiBenhCBB.Enabled = false;
            huongxulyTxtBox.Enabled = false;
            noteTextBox.Enabled = false;
            nameTxtBox.Enabled = false;
            adddBtn.Visible = true;
            updateBtn.Visible = true;
            deleteBtn.Visible = true;

            saveBtn.Visible = false;
            cancelBtn.Visible = false;
        }
        void unLoadForm()
        {
            ngayKhamDTPicker.Enabled = true;
            ngayTaiKhamDTPicker.Enabled = true;
            tienSuBenhTxtBox.Enabled = true;
            chanDoanCBB.Enabled = true;
            trieuchungTxtBox.Enabled = true;
            loaiBenhCBB.Enabled = true;
            huongxulyTxtBox.Enabled = true;
            noteTextBox.Enabled = true;
            


            adddBtn.Visible = false;
            updateBtn.Visible = false;
            deleteBtn.Visible = false;

            saveBtn.Visible = true;
            cancelBtn.Visible = true;
        }

        void clearForm()
        {

            tienSuBenhTxtBox.Text = null;
            chanDoanCBB.Text = null;
            trieuchungTxtBox.Text = null;
            loaiBenhCBB.Text = null;
            huongxulyTxtBox.Text = null;
            noteTextBox.Text = null;

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
                        BENHAN_BUS.addBenhan(
                                                 fromForm.NGAYLAP,
                                                 fromForm.NGAYTAIKHAM,
                                                 fromForm.MABN,
                                                 fromForm.MANV=1,
                                                 fromForm.TIENSUBENH,
                                                 fromForm.TRIEUCHUNG,
                                                 fromForm.LOAIBENH,
                                                 fromForm.CHANDOAN,
                                                 fromForm.HUONGXULY,
                                                 fromForm.GHICHU);
                        showDataBenhAnByID();
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
                        BENHAN_BUS.updateBenhAn(fromForm.MABA,
                                                 fromForm.NGAYLAP,
                                                 fromForm.NGAYTAIKHAM,
                                                 fromForm.MANV=1,
                                                 fromForm.TIENSUBENH,
                                                 fromForm.TRIEUCHUNG,
                                                 fromForm.LOAIBENH,
                                                 fromForm.CHANDOAN,
                                                 fromForm.HUONGXULY,
                                                 fromForm.GHICHU);
                        showDataBenhAnByID();
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

        private void deleteBenhNhanTrongDanhSachBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show
               ("Bạn có chắc chắn muốn xóa bệnh nhân này ra khỏi danh sách ?",
                "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                danhsachkhambenh_BUS.deleteBenhNhanFromDanhSach(fromTable.MABN);
                MessageBox.Show("Xoá thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showDanhSachBenhNhan();
            }
        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            string temp;
            temp = searchTextbox.Text;
            showSearchResult(temp);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            donThuoc_BUS.addDonthuoc(fromTable.MABA,fromTable.NGAYLAP);
            donThuoc_BUS.getDataDonThuocforBA(fromTable.MABA);
            int? a;

        }

        private bool checkData()
        {
          
            if (string.IsNullOrEmpty(trieuchungTxtBox.Text))
            {
                MessageBox.Show("Bạn chưa nhập triệu chứng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                trieuchungTxtBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tienSuBenhTxtBox.Text))
            {
                MessageBox.Show("Bạn chưa nhập tiền sử bệnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tienSuBenhTxtBox.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(chanDoanCBB.Text))
            {
                MessageBox.Show("Bạn chưa đưa ra chẩn đoán ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chanDoanCBB.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(loaiBenhCBB.Text))
            {
                MessageBox.Show("Bạn chưa chọn loại bệnh ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loaiBenhCBB.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(huongxulyTxtBox.Text))
            {
                MessageBox.Show("Bạn chưa đưa ra hướng xử lý  ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                huongxulyTxtBox.Focus();
                return false;
            }
            if (ngayTaiKhamDTPicker.Value <=ngayKhamDTPicker.Value )
            {
                MessageBox.Show("Ngày tái khám phải lớn hơn ngày khám ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ngayTaiKhamDTPicker.Focus();
                return false;
            }
            return true;
        }
    }

}

