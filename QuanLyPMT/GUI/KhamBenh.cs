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
            
            showDanhSachBenhNhan();
        }
        benhAn_BUS BENHAN_BUS = new benhAn_BUS();
        BenhNhan_BUS BENHNHAN_BUS = new BenhNhan_BUS();
        DanhSachKhamBenh_BUS danhsachkhambenh_BUS = new DanhSachKhamBenh_BUS();
        int MABENHNHAN = 0;
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void KhamBenh_Load(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void examTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void showDataBenhAnByID()
        {
            benAnDGV.DataSource = BENHAN_BUS.getDataByID(MABENHNHAN).Tables[0];
        }
        void showDanhSachBenhNhan()
        {
            benhNhanListDGV.DataSource = danhsachkhambenh_BUS.getDanhSachBenhNhanInDay().Tables[0];
        }

        private void benhNhanListDGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                    MABENHNHAN = int.Parse(benhNhanListDGV.Rows[index].Cells["MABN1"].Value.ToString());
            }
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
    }
}

