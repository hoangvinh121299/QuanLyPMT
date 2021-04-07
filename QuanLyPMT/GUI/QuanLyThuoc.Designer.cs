
namespace GUI
{
    partial class QuanLyThuoc
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
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.useWayCbb = new System.Windows.Forms.ComboBox();
            this.priceOutTxtBox = new System.Windows.Forms.TextBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.metroSetLabel7 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel6 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.unitCbb = new System.Windows.Forms.ComboBox();
            this.amountTxtBox = new System.Windows.Forms.TextBox();
            this.priceInTxtBox = new System.Windows.Forms.TextBox();
            this.suppliertxtBox = new System.Windows.Forms.TextBox();
            this.metroSetLabel9 = new MetroSet_UI.Controls.MetroSetLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noteTextbox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.White;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBtn.Image = global::GUI.Properties.Resources.delete;
            this.deleteBtn.Location = new System.Drawing.Point(488, 216);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(118, 45);
            this.deleteBtn.TabIndex = 48;
            this.deleteBtn.Text = "Xoá";
            this.deleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.White;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editBtn.ForeColor = System.Drawing.Color.Black;
            this.editBtn.Image = global::GUI.Properties.Resources.edit;
            this.editBtn.Location = new System.Drawing.Point(488, 153);
            this.editBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(118, 40);
            this.editBtn.TabIndex = 47;
            this.editBtn.Text = "Cập nhật";
            this.editBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editBtn.UseVisualStyleBackColor = false;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(211)))), ((int)(((byte)(149)))));
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Image = global::GUI.Properties.Resources.add;
            this.addBtn.Location = new System.Drawing.Point(488, 86);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(118, 42);
            this.addBtn.TabIndex = 46;
            this.addBtn.Text = "Thêm";
            this.addBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addBtn.UseVisualStyleBackColor = false;
            // 
            // useWayCbb
            // 
            this.useWayCbb.FormattingEnabled = true;
            this.useWayCbb.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.useWayCbb.Location = new System.Drawing.Point(168, 137);
            this.useWayCbb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.useWayCbb.Name = "useWayCbb";
            this.useWayCbb.Size = new System.Drawing.Size(121, 23);
            this.useWayCbb.TabIndex = 40;
            this.useWayCbb.SelectedIndexChanged += new System.EventHandler(this.sexCbbox_SelectedIndexChanged);
            // 
            // priceOutTxtBox
            // 
            this.priceOutTxtBox.Location = new System.Drawing.Point(168, 261);
            this.priceOutTxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.priceOutTxtBox.Name = "priceOutTxtBox";
            this.priceOutTxtBox.Size = new System.Drawing.Size(171, 21);
            this.priceOutTxtBox.TabIndex = 38;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(168, 39);
            this.nameTxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(171, 21);
            this.nameTxtBox.TabIndex = 35;
            // 
            // metroSetLabel7
            // 
            this.metroSetLabel7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel7.IsDerivedStyle = true;
            this.metroSetLabel7.Location = new System.Drawing.Point(14, 261);
            this.metroSetLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroSetLabel7.Name = "metroSetLabel7";
            this.metroSetLabel7.Size = new System.Drawing.Size(70, 23);
            this.metroSetLabel7.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel7.StyleManager = null;
            this.metroSetLabel7.TabIndex = 33;
            this.metroSetLabel7.Text = "Giá bán ";
            this.metroSetLabel7.ThemeAuthor = "Narwin";
            this.metroSetLabel7.ThemeName = "MetroLite";
            // 
            // metroSetLabel6
            // 
            this.metroSetLabel6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel6.IsDerivedStyle = true;
            this.metroSetLabel6.Location = new System.Drawing.Point(14, 222);
            this.metroSetLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroSetLabel6.Name = "metroSetLabel6";
            this.metroSetLabel6.Size = new System.Drawing.Size(84, 23);
            this.metroSetLabel6.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel6.StyleManager = null;
            this.metroSetLabel6.TabIndex = 32;
            this.metroSetLabel6.Text = "Giá nhập";
            this.metroSetLabel6.ThemeAuthor = "Narwin";
            this.metroSetLabel6.ThemeName = "MetroLite";
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel5.IsDerivedStyle = true;
            this.metroSetLabel5.Location = new System.Drawing.Point(14, 181);
            this.metroSetLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(120, 23);
            this.metroSetLabel5.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.TabIndex = 31;
            this.metroSetLabel5.Text = "Số lượng tồn kho";
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroLite";
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel4.IsDerivedStyle = true;
            this.metroSetLabel4.Location = new System.Drawing.Point(14, 137);
            this.metroSetLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(96, 23);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 30;
            this.metroSetLabel4.Text = "Đường dùng";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLite";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(14, 85);
            this.metroSetLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(84, 23);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 29;
            this.metroSetLabel3.Text = "Đơn vị tính ";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(14, 39);
            this.metroSetLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(84, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 28;
            this.metroSetLabel2.Text = "Tên thuốc";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(4, 4);
            this.metroSetLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(175, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 27;
            this.metroSetLabel1.Text = "Thông tin thuốc";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // unitCbb
            // 
            this.unitCbb.FormattingEnabled = true;
            this.unitCbb.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.unitCbb.Location = new System.Drawing.Point(168, 85);
            this.unitCbb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unitCbb.Name = "unitCbb";
            this.unitCbb.Size = new System.Drawing.Size(121, 23);
            this.unitCbb.TabIndex = 50;
            // 
            // amountTxtBox
            // 
            this.amountTxtBox.Location = new System.Drawing.Point(168, 181);
            this.amountTxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.amountTxtBox.Name = "amountTxtBox";
            this.amountTxtBox.Size = new System.Drawing.Size(171, 21);
            this.amountTxtBox.TabIndex = 51;
            // 
            // priceInTxtBox
            // 
            this.priceInTxtBox.Location = new System.Drawing.Point(168, 222);
            this.priceInTxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.priceInTxtBox.Name = "priceInTxtBox";
            this.priceInTxtBox.Size = new System.Drawing.Size(171, 21);
            this.priceInTxtBox.TabIndex = 52;
            // 
            // suppliertxtBox
            // 
            this.suppliertxtBox.Location = new System.Drawing.Point(168, 305);
            this.suppliertxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.suppliertxtBox.Name = "suppliertxtBox";
            this.suppliertxtBox.Size = new System.Drawing.Size(171, 21);
            this.suppliertxtBox.TabIndex = 54;
            // 
            // metroSetLabel9
            // 
            this.metroSetLabel9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel9.IsDerivedStyle = true;
            this.metroSetLabel9.Location = new System.Drawing.Point(14, 305);
            this.metroSetLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroSetLabel9.Name = "metroSetLabel9";
            this.metroSetLabel9.Size = new System.Drawing.Size(105, 23);
            this.metroSetLabel9.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel9.StyleManager = null;
            this.metroSetLabel9.TabIndex = 53;
            this.metroSetLabel9.Text = "Nhà cung cấp ";
            this.metroSetLabel9.ThemeAuthor = "Narwin";
            this.metroSetLabel9.ThemeName = "MetroLite";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.groupBox1.Controls.Add(this.noteTextbox);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(4, 345);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(608, 253);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ghi chú ";
            // 
            // noteTextbox
            // 
            this.noteTextbox.Location = new System.Drawing.Point(1, 25);
            this.noteTextbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.noteTextbox.Multiline = true;
            this.noteTextbox.Name = "noteTextbox";
            this.noteTextbox.Size = new System.Drawing.Size(601, 212);
            this.noteTextbox.TabIndex = 0;
            // 
            // QuanLyThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.suppliertxtBox);
            this.Controls.Add(this.metroSetLabel9);
            this.Controls.Add(this.priceInTxtBox);
            this.Controls.Add(this.amountTxtBox);
            this.Controls.Add(this.unitCbb);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.useWayCbb);
            this.Controls.Add(this.priceOutTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.metroSetLabel7);
            this.Controls.Add(this.metroSetLabel6);
            this.Controls.Add(this.metroSetLabel5);
            this.Controls.Add(this.metroSetLabel4);
            this.Controls.Add(this.metroSetLabel3);
            this.Controls.Add(this.metroSetLabel2);
            this.Controls.Add(this.metroSetLabel1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QuanLyThuoc";
            this.Size = new System.Drawing.Size(610, 588);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ComboBox useWayCbb;
        private System.Windows.Forms.TextBox priceOutTxtBox;
        private System.Windows.Forms.TextBox nameTxtBox;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel7;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel6;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private System.Windows.Forms.ComboBox unitCbb;
        private System.Windows.Forms.TextBox amountTxtBox;
        private System.Windows.Forms.TextBox priceInTxtBox;
        private System.Windows.Forms.TextBox suppliertxtBox;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox noteTextbox;
    }
}
