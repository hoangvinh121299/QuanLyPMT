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
    public partial class QuanLyBenh : UserControl
    {
        public QuanLyBenh()
        {
            InitializeComponent();
        }

        private void QuanLyBenh_Load(object sender, EventArgs e)
        {
            loadForm();
        }
        private void loadForm()
        {
            addBtn.Visible = true;
            editBtn.Visible = true;

            saveBtn.Visible = false;
            cancelBtn.Visible = false;
        }

    }
}
