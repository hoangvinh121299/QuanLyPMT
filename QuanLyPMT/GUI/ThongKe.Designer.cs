
namespace GUI
{
    partial class ThongKe
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.revenueTab = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.examRevenueDGV = new System.Windows.Forms.DataGridView();
            this.RevenueDGV = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYTHONGKE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIATRI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.patienceTab = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.STT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGATHONGKE1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIATRI1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.revenueTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examRevenueDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RevenueDGV)).BeginInit();
            this.patienceTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.revenueTab);
            this.tabControl.Controls.Add(this.patienceTab);
            this.tabControl.Depth = 0;
            this.tabControl.Location = new System.Drawing.Point(0, 29);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1218, 585);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.PatienceTab_SelectedIndexChanged);
            // 
            // revenueTab
            // 
            this.revenueTab.Controls.Add(this.groupBox5);
            this.revenueTab.Controls.Add(this.groupBox2);
            this.revenueTab.Controls.Add(this.groupBox1);
            this.revenueTab.Location = new System.Drawing.Point(4, 25);
            this.revenueTab.Name = "revenueTab";
            this.revenueTab.Padding = new System.Windows.Forms.Padding(3);
            this.revenueTab.Size = new System.Drawing.Size(1210, 556);
            this.revenueTab.TabIndex = 0;
            this.revenueTab.Text = "Doanh thu";
            this.revenueTab.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(409, 256);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(798, 300);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doanh thu bán thuốc ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.examRevenueDGV);
            this.groupBox2.Controls.Add(this.RevenueDGV);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 553);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết doanh thu";
            // 
            // examRevenueDGV
            // 
            this.examRevenueDGV.AllowUserToAddRows = false;
            this.examRevenueDGV.AllowUserToDeleteRows = false;
            this.examRevenueDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.examRevenueDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examRevenueDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT1,
            this.NGATHONGKE1,
            this.GIATRI1});
            this.examRevenueDGV.Location = new System.Drawing.Point(0, 21);
            this.examRevenueDGV.Name = "examRevenueDGV";
            this.examRevenueDGV.ReadOnly = true;
            this.examRevenueDGV.RowHeadersVisible = false;
            this.examRevenueDGV.RowTemplate.Height = 25;
            this.examRevenueDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.examRevenueDGV.Size = new System.Drawing.Size(400, 226);
            this.examRevenueDGV.TabIndex = 1;
            // 
            // RevenueDGV
            // 
            this.RevenueDGV.AllowUserToAddRows = false;
            this.RevenueDGV.AllowUserToDeleteRows = false;
            this.RevenueDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RevenueDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RevenueDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.NGAYTHONGKE,
            this.GIATRI});
            this.RevenueDGV.Location = new System.Drawing.Point(0, 265);
            this.RevenueDGV.Name = "RevenueDGV";
            this.RevenueDGV.ReadOnly = true;
            this.RevenueDGV.RowHeadersVisible = false;
            this.RevenueDGV.RowTemplate.Height = 25;
            this.RevenueDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RevenueDGV.Size = new System.Drawing.Size(400, 288);
            this.RevenueDGV.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // NGAYTHONGKE
            // 
            this.NGAYTHONGKE.DataPropertyName = "NGAYLAP";
            this.NGAYTHONGKE.HeaderText = "Ngày thống kê";
            this.NGAYTHONGKE.Name = "NGAYTHONGKE";
            this.NGAYTHONGKE.ReadOnly = true;
            // 
            // GIATRI
            // 
            this.GIATRI.DataPropertyName = "doanhthu";
            this.GIATRI.HeaderText = "Giá trị ";
            this.GIATRI.Name = "GIATRI";
            this.GIATRI.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(409, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doanh thu khám bệnh";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // patienceTab
            // 
            this.patienceTab.Controls.Add(this.groupBox4);
            this.patienceTab.Controls.Add(this.groupBox3);
            this.patienceTab.Location = new System.Drawing.Point(4, 25);
            this.patienceTab.Name = "patienceTab";
            this.patienceTab.Padding = new System.Windows.Forms.Padding(3);
            this.patienceTab.Size = new System.Drawing.Size(1210, 556);
            this.patienceTab.TabIndex = 1;
            this.patienceTab.Text = "Bệnh nhân";
            this.patienceTab.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(3, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(400, 550);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết bệnh nhân";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(409, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(798, 550);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Biểu đồ bệnh nhân";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabControl;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1218, 23);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // STT1
            // 
            this.STT1.HeaderText = "STT";
            this.STT1.Name = "STT1";
            this.STT1.ReadOnly = true;
            // 
            // NGATHONGKE1
            // 
            this.NGATHONGKE1.DataPropertyName = "NGAYLAP";
            this.NGATHONGKE1.HeaderText = "Ngày thống kê";
            this.NGATHONGKE1.Name = "NGATHONGKE1";
            this.NGATHONGKE1.ReadOnly = true;
            // 
            // GIATRI1
            // 
            this.GIATRI1.DataPropertyName = "doanhthu";
            this.GIATRI1.HeaderText = "Giá trị ";
            this.GIATRI1.Name = "GIATRI1";
            this.GIATRI1.ReadOnly = true;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "ThongKe";
            this.Size = new System.Drawing.Size(1218, 614);
            this.tabControl.ResumeLayout(false);
            this.revenueTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.examRevenueDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RevenueDGV)).EndInit();
            this.patienceTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage revenueTab;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl PatienceTab;
        private System.Windows.Forms.TabPage patienceTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView RevenueDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTHONGKE;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIATRI;
        private System.Windows.Forms.DataGridView examRevenueDGV;
        private System.Windows.Forms.DataGridView drugRevenueDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGATHONGKE1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIATRI1;
    }
}
