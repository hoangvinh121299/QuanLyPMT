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
    public partial class QuanLyBenh : UserControl
    {
        bool isClickBtnSearch;
        Benh_BUS benh_BUS = new Benh_BUS();
        public QuanLyBenh()
        {
            InitializeComponent();
        }

        private void QuanLyBenh_Load(object sender, EventArgs e)
        {
            loadForm();
            loadData(benh_BUS.GetData());
        }
        private void loadForm()
        {
            isClickBtnSearch = false;

            addBtn.Visible = true;
            editBtn.Visible = true;

            btn_Save.Visible = false;
            btn_Cancle.Visible = false;
        }
        private void loadData(DataSet dataSet)
        {
            dtg_DanhSachBenh.DataSource = null;
            dtg_DanhSachBenh.DataSource = dataSet.Tables[0];
            dtg_DanhSachBenh.Columns[1].Visible = false;
        }

        private void dtg_DanhSachBenh_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dtg_DanhSachBenh.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
        private bool checkData()
        {
            if (string.IsNullOrEmpty(txtb_TenBenh1.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên bệnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtb_TenBenh1.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cb_LoaiBenh.Text))
            {
                MessageBox.Show("Bạn chưa chọn tên loại bệnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_LoaiBenh.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtb_TrieuChung.Text))
            {
                MessageBox.Show("Bạn chưa nhập triệu chứng của bệnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtb_TrieuChung.Focus();
                return false;
            }

            if (isClickBtnSearch)
            {
                if (string.IsNullOrEmpty(txtb_TenBenh2.Text))
                {
                    MessageBox.Show("Bạn chưa nhập tên bệnh cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtb_TenBenh2.Focus();
                    return false;
                }
            }
            return true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                
            }

        }
    }
}
