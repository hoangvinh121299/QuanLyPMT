using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GUI
{
    public partial class About : UserControl
    {
        public About()
        {
            InitializeComponent();
            try
            {
                string text = File.ReadAllText(@"..\..\..\..\about.txt");
                labelAbout.Text = text;
            }catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }

}
