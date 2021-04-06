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
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
