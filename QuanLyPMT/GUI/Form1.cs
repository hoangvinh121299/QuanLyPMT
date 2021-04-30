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
            displayPanel.Controls.Clear();
            displayPanel.Controls.Add(quanLyBenhNhan);
        }

        private void drugBtn_Click(object sender, EventArgs e)
        {
            QuanLyThuoc quanLyThuoc = new QuanLyThuoc();
            displayPanel.Controls.Clear();
            displayPanel.Controls.Add(quanLyThuoc);
        }

        private void sickBtn_Click(object sender, EventArgs e)
        {
            QuanLyBenh quanLyBenh = new QuanLyBenh();
            displayPanel.Controls.Clear();
            displayPanel.Controls.Add(quanLyBenh);
        }

        private void examBtn_Click(object sender, EventArgs e)
        {
            KhamBenh khamBenh = new KhamBenh();
            displayPanel.Controls.Clear();
            displayPanel.Controls.Add(khamBenh);
        }
    }
}