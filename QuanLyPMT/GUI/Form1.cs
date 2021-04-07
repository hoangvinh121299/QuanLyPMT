using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;
namespace GUI
{
    public partial class MainForm : MetroSetForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void patientBtn_Click(object sender, EventArgs e)
        {
            QuanLyBenhNhan quanLyBenhNhan = new QuanLyBenhNhan();
            column1FlowlayoytPanel.Controls.Clear();
            column1FlowlayoytPanel.Controls.Add(quanLyBenhNhan);
            danhSachBenhNhan danhSachBenhNhan = new danhSachBenhNhan();
            column2FlowlayoytPanel.Controls.Clear();
            column2FlowlayoytPanel.Controls.Add(danhSachBenhNhan);
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void drugBtn_Click(object sender, EventArgs e)
        {
            QuanLyThuoc quanLyThuoc = new QuanLyThuoc();
            column1FlowlayoytPanel.Controls.Clear();
            column1FlowlayoytPanel.Controls.Add(quanLyThuoc);
            Danhsachthuoc danhsachthuoc = new Danhsachthuoc();
            column2FlowlayoytPanel.Controls.Clear();
            column2FlowlayoytPanel.Controls.Add(danhsachthuoc);
        }

        private void sickBtn_Click(object sender, EventArgs e)
        {
            QuanLyBenh quanLyBenh = new QuanLyBenh();
            column1FlowlayoytPanel.Controls.Clear();
            column1FlowlayoytPanel.Controls.Add(quanLyBenh);
            danhSachBenh danhSachBenh = new danhSachBenh();
            column2FlowlayoytPanel.Controls.Clear();
            column2FlowlayoytPanel.Controls.Add(danhSachBenh);
        }
    }
}
