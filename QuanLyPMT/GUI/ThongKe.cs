using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;
namespace GUI
{
    public partial class ThongKe : UserControl
    {
        DonThuoc_BUS donthuoc_BUS = new DonThuoc_BUS();
        benhAn_BUS benhan_BUS = new benhAn_BUS();
        public ThongKe()
        {
            InitializeComponent();
            getDrugAmountInDay();
            getExamAmountInDay();
        }
        
        private void PatienceTab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void getDrugAmountInDay()
        {
            RevenueDGV.DataSource = donthuoc_BUS.getAmountInDay().Tables[0];
        }
        private void getExamAmountInDay()
        {
            examRevenueDGV.DataSource = benhan_BUS.getExamAmountInDay().Tables[0];
        }
    }
}
