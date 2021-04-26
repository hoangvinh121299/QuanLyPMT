
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.danhSachThuocDgv = new System.Windows.Forms.DataGridView();
            this.searchBtn = new System.Windows.Forms.Button();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.numeric = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useWay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GHICHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NHACUNGCAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachThuocDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.White;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editBtn.ForeColor = System.Drawing.Color.Black;
            this.editBtn.Image = global::GUI.Properties.Resources.edit;
            this.editBtn.Location = new System.Drawing.Point(488, 68);
            this.editBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(118, 40);
            this.editBtn.TabIndex = 47;
            this.editBtn.Text = "Cập nhật";
            this.editBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(211)))), ((int)(((byte)(149)))));
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Image = global::GUI.Properties.Resources.add;
            this.addBtn.Location = new System.Drawing.Point(488, 18);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(118, 42);
            this.addBtn.TabIndex = 46;
            this.addBtn.Text = "Thêm";
            this.addBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // useWayCbb
            // 
            this.useWayCbb.FormattingEnabled = true;
            this.useWayCbb.Items.AddRange(new object[] {
            "uống ",
            "tiêm",
            "nhét hậu môn"});
            this.useWayCbb.Location = new System.Drawing.Point(168, 137);
            this.useWayCbb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.useWayCbb.Name = "useWayCbb";
            this.useWayCbb.Size = new System.Drawing.Size(121, 25);
            this.useWayCbb.TabIndex = 40;
            this.useWayCbb.SelectedIndexChanged += new System.EventHandler(this.sexCbbox_SelectedIndexChanged);
            // 
            // priceOutTxtBox
            // 
            this.priceOutTxtBox.Location = new System.Drawing.Point(168, 261);
            this.priceOutTxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.priceOutTxtBox.Name = "priceOutTxtBox";
            this.priceOutTxtBox.Size = new System.Drawing.Size(171, 25);
            this.priceOutTxtBox.TabIndex = 38;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(168, 39);
            this.nameTxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(171, 25);
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
            this.metroSetLabel4.Size = new System.Drawing.Size(105, 23);
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
            "viên",
            "ống ",
            "lọ",
            "gói"});
            this.unitCbb.Location = new System.Drawing.Point(168, 85);
            this.unitCbb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unitCbb.Name = "unitCbb";
            this.unitCbb.Size = new System.Drawing.Size(121, 25);
            this.unitCbb.TabIndex = 50;
            // 
            // amountTxtBox
            // 
            this.amountTxtBox.Location = new System.Drawing.Point(168, 181);
            this.amountTxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.amountTxtBox.Name = "amountTxtBox";
            this.amountTxtBox.Size = new System.Drawing.Size(171, 25);
            this.amountTxtBox.TabIndex = 51;
            // 
            // priceInTxtBox
            // 
            this.priceInTxtBox.Location = new System.Drawing.Point(168, 222);
            this.priceInTxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.priceInTxtBox.Name = "priceInTxtBox";
            this.priceInTxtBox.Size = new System.Drawing.Size(171, 25);
            this.priceInTxtBox.TabIndex = 52;
            // 
            // suppliertxtBox
            // 
            this.suppliertxtBox.Location = new System.Drawing.Point(168, 305);
            this.suppliertxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.suppliertxtBox.Name = "suppliertxtBox";
            this.suppliertxtBox.Size = new System.Drawing.Size(171, 25);
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
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.noteTextbox.Location = new System.Drawing.Point(1, 18);
            this.noteTextbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.noteTextbox.Multiline = true;
            this.noteTextbox.Name = "noteTextbox";
            this.noteTextbox.Size = new System.Drawing.Size(607, 235);
            this.noteTextbox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.danhSachThuocDgv);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(619, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 483);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách thuốc";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // danhSachThuocDgv
            // 
            this.danhSachThuocDgv.AllowUserToAddRows = false;
            this.danhSachThuocDgv.AllowUserToDeleteRows = false;
            this.danhSachThuocDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.danhSachThuocDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhSachThuocDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeric,
            this.name,
            this.useWay,
            this.amount,
            this.unit,
            this.priceIn,
            this.priceOut,
            this.MALT,
            this.GHICHU,
            this.NHACUNGCAP});
            this.danhSachThuocDgv.Location = new System.Drawing.Point(0, 19);
            this.danhSachThuocDgv.Name = "danhSachThuocDgv";
            this.danhSachThuocDgv.ReadOnly = true;
            this.danhSachThuocDgv.RowHeadersWidth = 51;
            this.danhSachThuocDgv.RowTemplate.Height = 25;
            this.danhSachThuocDgv.Size = new System.Drawing.Size(572, 464);
            this.danhSachThuocDgv.TabIndex = 0;
            this.danhSachThuocDgv.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhSachThuocDgv_RowEnter);
            this.danhSachThuocDgv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.danhSachThuocDgv_RowPostPaint);
            // 
            // searchBtn
            // 
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBtn.ForeColor = System.Drawing.Color.Black;
            this.searchBtn.Image = global::GUI.Properties.Resources.search__1_;
            this.searchBtn.Location = new System.Drawing.Point(1064, 26);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(99, 36);
            this.searchBtn.TabIndex = 59;
            this.searchBtn.Text = "Tìm kiếm ";
            this.searchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // nameTextbox
            // 
            this.nameTextbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTextbox.Location = new System.Drawing.Point(769, 39);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(181, 30);
            this.nameTextbox.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(655, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 57;
            this.label2.Text = "Tên thuốc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(625, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 56;
            this.label1.Text = "Tìm kiếm thuốc\r\n";
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.ForeColor = System.Drawing.Color.Black;
            this.deleteButton.Image = global::GUI.Properties.Resources.delete;
            this.deleteButton.Location = new System.Drawing.Point(1064, 77);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(99, 37);
            this.deleteButton.TabIndex = 61;
            this.deleteButton.Text = "Xoá";
            this.deleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(161)))), ((int)(((byte)(32)))));
            this.cancelBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Image = global::GUI.Properties.Resources.logout;
            this.cancelBtn.Location = new System.Drawing.Point(488, 160);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(118, 40);
            this.cancelBtn.TabIndex = 63;
            this.cancelBtn.Text = "Huỷ bỏ ";
            this.cancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Image = global::GUI.Properties.Resources.save;
            this.saveBtn.Location = new System.Drawing.Point(488, 114);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(118, 40);
            this.saveBtn.TabIndex = 62;
            this.saveBtn.Text = "Xác nhận";
            this.saveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // numeric
            // 
            this.numeric.DataPropertyName = "STT";
            this.numeric.HeaderText = "STT";
            this.numeric.MinimumWidth = 6;
            this.numeric.Name = "numeric";
            this.numeric.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "TENLT";
            this.name.HeaderText = "Tên thuốc";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // useWay
            // 
            this.useWay.DataPropertyName = "DUONGDUNG";
            this.useWay.HeaderText = "Đường dùng";
            this.useWay.MinimumWidth = 6;
            this.useWay.Name = "useWay";
            this.useWay.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "TONKHO";
            this.amount.HeaderText = "Số lượng tồn ";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.DataPropertyName = "DONVT";
            this.unit.HeaderText = "Đơn vị tính ";
            this.unit.MinimumWidth = 6;
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // priceIn
            // 
            this.priceIn.DataPropertyName = "GIANHAP";
            this.priceIn.HeaderText = "Giá nhập";
            this.priceIn.MinimumWidth = 6;
            this.priceIn.Name = "priceIn";
            this.priceIn.ReadOnly = true;
            // 
            // priceOut
            // 
            this.priceOut.DataPropertyName = "GIABAN";
            this.priceOut.HeaderText = "Giá bán";
            this.priceOut.MinimumWidth = 6;
            this.priceOut.Name = "priceOut";
            this.priceOut.ReadOnly = true;
            // 
            // MALT
            // 
            this.MALT.DataPropertyName = "MALT";
            this.MALT.HeaderText = "Mã Thuốc";
            this.MALT.MinimumWidth = 6;
            this.MALT.Name = "MALT";
            this.MALT.ReadOnly = true;
            this.MALT.Visible = false;
            // 
            // GHICHU
            // 
            this.GHICHU.DataPropertyName = "GHICHU";
            this.GHICHU.HeaderText = "Ghi chú";
            this.GHICHU.MinimumWidth = 6;
            this.GHICHU.Name = "GHICHU";
            this.GHICHU.ReadOnly = true;
            this.GHICHU.Visible = false;
            // 
            // NHACUNGCAP
            // 
            this.NHACUNGCAP.DataPropertyName = "NHACUNGCAP";
            this.NHACUNGCAP.HeaderText = "Nhà cung cấp";
            this.NHACUNGCAP.MinimumWidth = 6;
            this.NHACUNGCAP.Name = "NHACUNGCAP";
            this.NHACUNGCAP.ReadOnly = true;
            this.NHACUNGCAP.Visible = false;
            // 
            // QuanLyThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.suppliertxtBox);
            this.Controls.Add(this.metroSetLabel9);
            this.Controls.Add(this.priceInTxtBox);
            this.Controls.Add(this.amountTxtBox);
            this.Controls.Add(this.unitCbb);
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
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QuanLyThuoc";
            this.Size = new System.Drawing.Size(1207, 606);
            this.Load += new System.EventHandler(this.QuanLyThuoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.danhSachThuocDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView danhSachThuocDgv;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeric;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn useWay;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GHICHU;
        private System.Windows.Forms.DataGridViewTextBoxColumn NHACUNGCAP;
    }
}
