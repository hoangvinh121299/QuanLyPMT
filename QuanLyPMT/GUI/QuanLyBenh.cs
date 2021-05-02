﻿using System;
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
        public const int INSERT = 1;
        public const int UPDATE = 2;
        bool isClickBtnSearch;
        int state;
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

            disabledControls();
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
        
        private void disabledControls()
        {
            txtb_TenBenh1.Enabled = false;
            txtb_GhiChu.Enabled = false;
            txtb_TrieuChung.Enabled = false;
            cb_LoaiBenh.Enabled = false;
        }

        private void enableControls()
        {

            txtb_TenBenh1.Enabled = true;
            txtb_GhiChu.Enabled = true;
            txtb_TrieuChung.Enabled = true;
            cb_LoaiBenh.Enabled = true;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                switch (state){
                    case INSERT:
                        Benh benh = new Benh(txtb_TenBenh1.Text.Trim(), cb_LoaiBenh.Text.Trim(), txtb_TrieuChung.Text.Trim(), txtb_GhiChu.Text.Trim());
                        benh_BUS.addBenh(benh);
                        loadData(benh_BUS.GetData());
                    break;
                }
            }
        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            cb_LoaiBenh.SelectedIndex = -1;
            txtb_TenBenh1.Clear();
            txtb_TrieuChung.Clear();
            txtb_GhiChu.Clear();

            addBtn.Visible = true;
            editBtn.Visible = true;

            btn_Save.Visible = false;
            btn_Cancle.Visible = false;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            enableControls();
            state = INSERT;

            addBtn.Visible = false;
            editBtn.Visible = false;

            btn_Save.Visible = true ;
            btn_Cancle.Visible = true;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int maLoaiBenh = (int)dtg_DanhSachBenh.Rows[dtg_DanhSachBenh.CurrentCell.RowIndex].Cells[1].Value;
            Benh benh1 = new Benh(txtb_TenBenh1.Text.Trim(), cb_LoaiBenh.Text.Trim(), txtb_TrieuChung.Text.Trim(), txtb_GhiChu.Text.Trim(), maLoaiBenh);
            benh_BUS.deleteBenh(benh1);
            loadData(benh_BUS.GetData());
        }
        private void setValueToControls()
        {
            txtb_TenBenh1.Text = dtg_DanhSachBenh.CurrentRow.Cells[2].Value.ToString();
            cb_LoaiBenh.SelectedIndex = cb_LoaiBenh.FindStringExact(dtg_DanhSachBenh.CurrentRow.Cells[3].Value.ToString());
            txtb_GhiChu.Text = dtg_DanhSachBenh.CurrentRow.Cells[4].Value.ToString();
            txtb_TrieuChung.Text = dtg_DanhSachBenh.CurrentRow.Cells[5].Value.ToString();
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            enableControls();
            state = UPDATE;
            setValueToControls();

            addBtn.Visible = false;
            editBtn.Visible = false;

            btn_Save.Visible = true;
            btn_Cancle.Visible = true;
        }

        private void dtg_DanhSachBenh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setValueToControls();
        }
    }
}
