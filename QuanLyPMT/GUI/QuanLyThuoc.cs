using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class QuanLyThuoc : UserControl
    {
        public QuanLyThuoc()
        {
            InitializeComponent();
            loadForm();
        }

        private void sexCbbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void loadForm()
        {
            addBtn.Visible = true;
            editBtn.Visible = true;
           
            saveBtn.Visible = false;
            cancelBtn.Visible = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void QuanLyThuoc_Load(object sender, EventArgs e)
        {

        }
    }
}
