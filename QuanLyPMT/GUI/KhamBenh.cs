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
using Microsoft.Reporting.WinForms;

namespace GUI
{
    public partial class KhamBenh : UserControl
    {
        public KhamBenh()
        {
        }
        TaiKhoan taikhoan = new TaiKhoan();
        public KhamBenh(TaiKhoan references)
        {
            InitializeComponent();
            taikhoan = references;
        }
        DonThuoc_BUS donThuoc_BUS = new DonThuoc_BUS();
        DonThuoc donThuoc = new DonThuoc();
        benhAn_BUS BENHAN_BUS = new benhAn_BUS();
        BenhNhan_BUS BENHNHAN_BUS = new BenhNhan_BUS();
        DanhSachKhamBenh_BUS danhsachkhambenh_BUS = new DanhSachKhamBenh_BUS();
        //Dùng để lấy dữ liệu từ bảng
        BenhAN fromTable = new BenhAN();
        BenhAN fromForm = new BenhAN();
        //Lấy dữ liệu nhập từ form
        bool isUsingAdd, isUsingUpdate = false;
        bool isAdd, isEdit = false;
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        
        private void KhamBenh_Load(object sender, EventArgs e)
        {
            showDanhSachBenhNhan();
            loadForm();
            
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
        private void danhSachThuocDgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            danhSachThuocDgv.Rows[e.RowIndex].Cells["numeric"].Value = (e.RowIndex + 1).ToString();
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
                fromTable.TIENKHAM = double.Parse(benAnDGV.Rows[index].Cells["TIENKHAM"].Value.ToString());
                fromTable.TRIEUCHUNG = benAnDGV.Rows[index].Cells["TRIEUCHUNG"].Value.ToString();
                fromTable.LOAIBENH = benAnDGV.Rows[index].Cells["LOAIBENH"].Value.ToString();
                fromTable.TIENSUBENH = benAnDGV.Rows[index].Cells["TIENSUBENH"].Value.ToString();
                fromTable.CHANDOAN = benAnDGV.Rows[index].Cells["CHANDOAN"].Value.ToString();
                fromTable.HUONGXULY = benAnDGV.Rows[index].Cells["HUONGXULY"].Value.ToString();
                fromTable.GHICHU = benAnDGV.Rows[index].Cells["GHICHU"].Value.ToString();




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
            examFee_textbox.Text = benhAN.TIENKHAM.ToString();
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
            fromForm.TIENKHAM = double.Parse(examFee_textbox.Text.ToString());
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
            examFee_textbox.Enabled = false;
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
            examFee_textbox.Enabled = true;



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
            examFee_textbox.Text = null;
            ngayKhamDTPicker.Value = DateTime.Now;
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
                                                 fromForm.MANV=taikhoan.MANV,
                                                 fromForm.TIENSUBENH,
                                                 fromForm.TRIEUCHUNG,
                                                 fromForm.LOAIBENH,
                                                 fromForm.CHANDOAN,
                                                 fromForm.HUONGXULY,
                                                 fromForm.GHICHU,
                                                 fromForm.TIENKHAM);
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
                                                 fromForm.MANV=taikhoan.MANV,
                                                 fromForm.TIENSUBENH,
                                                 fromForm.TRIEUCHUNG,
                                                 fromForm.LOAIBENH,
                                                 fromForm.CHANDOAN,
                                                 fromForm.HUONGXULY,
                                                 fromForm.GHICHU,
                                                 fromForm.TIENKHAM);
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
            if (MessageBox.Show("Bạn có muốn hủy bỏ thao tác đang thực hiện ?",
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

        private void HOADON_Click(object sender, EventArgs e)
        {

        }

        private void examTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (examTabControl.SelectedTab == DONTHUOC)
            {
                if (donThuoc_BUS.getMADT(fromTable.MABA).Tables[0].Rows.Count == 0)
                    donThuoc_BUS.addDonthuoc(fromTable.MABA, fromTable.NGAYLAP);
                showdatadonthuoc();
                loaddata();
            }
            else if (examTabControl.SelectedTab == HOADON)
            {
                this.reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource rptData = new ReportDataSource("DataSet1", BENHAN_BUS.getDataReport(3).Tables[0]);
                reportViewer1.LocalReport.DataSources.Add(rptData);
                reportViewer1.LocalReport.ReportPath = "../../../Report.rdlc";
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
        }
        void loaddata()
        {
            thuoc_cbb.DataSource = donThuoc_BUS.getDataForNametbox().Tables[0];
            thuoc_cbb.ValueMember = "MALT";
            thuoc_cbb.DisplayMember = "TENLT";
            danhSachThuocDgv.AutoResizeColumns();
            thuoc_cbb.Enabled = false;
            quantitytextBox.Enabled = false;
            unittextBox.Enabled = false;
            luubtn.Enabled = false;
            addBtn.Enabled = true;
            editBtn.Enabled = true;
            button1.Enabled = true;
        }
        void unloaddata()
        {
            thuoc_cbb.Enabled = true;
            quantitytextBox.Enabled = true;
            unittextBox.Enabled = true;
            luubtn.Enabled = true;
            addBtn.Enabled = false;
            editBtn.Enabled = false;
            button1.Enabled = false;
        }
        void cleardata()
        {
            thuoc_cbb.SelectedValue = 1;
            quantitytextBox.Text = null;
            unittextBox.Text = null;
        }
        void showdatadonthuoc()
        {
            danhSachThuocDgv.DataSource = donThuoc_BUS.getDataDonThuoc(fromTable.MABA).Tables[0];
        }
        private void danhSachThuocDgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                donThuoc.MaDT = int.Parse(danhSachThuocDgv.Rows[index].Cells["MaDT"].Value.ToString());
                donThuoc.MaDT = int.Parse(danhSachThuocDgv.Rows[index].Cells["MaDT"].Value.ToString());
                donThuoc.MaLT = int.Parse(danhSachThuocDgv.Rows[index].Cells["MaLT"].Value.ToString());
                donThuoc.MaLT = int.Parse(danhSachThuocDgv.Rows[index].Cells["MALT"].Value.ToString());
                donThuoc.TenLT = danhSachThuocDgv.Rows[index].Cells["namethuoc"].Value.ToString();
                donThuoc.SoLuong = int.Parse(danhSachThuocDgv.Rows[index].Cells["unitthuoc"].Value.ToString());
                donThuoc.LieuDung= int.Parse(danhSachThuocDgv.Rows[index].Cells["LIEUDUNG"].Value.ToString());

            }
            datatoform(donThuoc);
        }
        public void datatoform(DonThuoc donThuoc)
        {
            thuoc_cbb.SelectedValue = donThuoc.MaLT;
            quantitytextBox.Text = donThuoc.SoLuong.ToString();
            unittextBox.Text = donThuoc.LieuDung.ToString();
        }
        public void formtodata()
        {
            donThuoc.MaLT =int.Parse (thuoc_cbb.SelectedValue.ToString());
            donThuoc.SoLuong = int.Parse(quantitytextBox.Text);
            donThuoc.LieuDung = int.Parse(unittextBox.Text);
        }

        public void capnhattonkho(int MADT)
        {
            double giatri = 0;
            donThuoc_BUS.getgiatriDT(MADT);
            for (int i = 0; i < donThuoc_BUS.getgiatriDT(MADT).Tables[0].Rows.Count; i++)
            {
                double gt = Convert.ToDouble(donThuoc_BUS.getgiatriDT(MADT).Tables[0].Rows[i][0].ToString());
                double sl = Convert.ToDouble(donThuoc_BUS.getgiatriDT(MADT).Tables[0].Rows[i][1].ToString());
                giatri += gt*sl;
            }
            donThuoc_BUS.updatedonthuoc(MADT, giatri);
            for(int i=0;i<donThuoc_BUS.tinhtonkho(MADT).Tables[0].Rows.Count;i++)
            {
                int ma = int.Parse(donThuoc_BUS.tinhtonkho(MADT).Tables[0].Rows[i][0].ToString());
                int tonkho= int.Parse(donThuoc_BUS.tinhtonkho(MADT).Tables[0].Rows[i][1].ToString());
                int soluong = int.Parse(donThuoc_BUS.tinhtonkho(MADT).Tables[0].Rows[i][2].ToString());
                donThuoc_BUS.updatetonkho(ma, tonkho - soluong);
            }    
        }
        public void capnhatdonthuoc(int MADT)
        {
            double giatri = 0;
            donThuoc_BUS.getgiatriDT(MADT);
            for (int i = 0; i < donThuoc_BUS.getgiatriDT(MADT).Tables[0].Rows.Count; i++)
            {
                double gt = Convert.ToDouble(donThuoc_BUS.getgiatriDT(MADT).Tables[0].Rows[i][0].ToString());
                double sl = Convert.ToDouble(donThuoc_BUS.getgiatriDT(MADT).Tables[0].Rows[i][1].ToString());
                giatri += gt * sl;
            }
            donThuoc_BUS.updatedonthuoc(MADT, giatri);
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            unloaddata();
            cleardata();
            isAdd = true;
            isEdit = false;
        }
        private void luubtn_Click(object sender, EventArgs e)
        {
            donThuoc.MaDT = int.Parse(donThuoc_BUS.getMADT(fromTable.MABA).Tables[0].Rows[0][0].ToString());
            if (isAdd)
            {
                try
                {
                    formtodata();
                    if (true)
                    {
                        donThuoc_BUS.addCTdonthuoc(donThuoc.MaDT, donThuoc.MaLT, donThuoc.SoLuong, donThuoc.LieuDung);
                        showdatadonthuoc();
                        loaddata();
                        capnhattonkho(donThuoc.MaDT);
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình thêm dữ liệu");
                }
            }    
            else if(isEdit)
            {
                try
                {
                    formtodata();
                    if (true)
                    {
                        donThuoc_BUS.updateCTdonthuoc(donThuoc.MaLT, donThuoc.SoLuong, donThuoc.LieuDung);
                        int tonkho_temp =int.Parse( donThuoc_BUS.gettonkhobyID(donThuoc.MaLT).Tables[0].Rows[0][0].ToString());
                        donThuoc_BUS.updatetonkho(donThuoc.MaLT, tonkho_temp - donThuoc.SoLuong);
                        showdatadonthuoc();
                        loaddata();
                        capnhatdonthuoc(donThuoc.MaDT);
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình cập nhật dữ liệu");
                }
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show
             ("Bạn có chắc chắn muốn xóa loại thuóc này ra khỏi danh sách ?",
              "Thông báo",
              MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                donThuoc_BUS.deletedonthuoc(donThuoc.MaLT);
                MessageBox.Show("Xoá thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showdatadonthuoc();
            }
        }

       

        private void editBtn_Click(object sender, EventArgs e)
        {
            unloaddata();
            cleardata();
            isAdd = false;
            isEdit = true;
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

