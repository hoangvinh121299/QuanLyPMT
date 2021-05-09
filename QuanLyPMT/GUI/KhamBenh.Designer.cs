
namespace GUI
{
    partial class KhamBenh
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
            this.examTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.BENHAN = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ngayTaiKhamDTPicker = new System.Windows.Forms.DateTimePicker();
            this.ngayKhamDTPicker = new System.Windows.Forms.DateTimePicker();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.huongxulyTxtBox = new System.Windows.Forms.TextBox();
            this.adddBtn = new System.Windows.Forms.Button();
            this.chanDoanCBB = new System.Windows.Forms.ComboBox();
            this.loaiBenhCBB = new System.Windows.Forms.ComboBox();
            this.trieuchungTxtBox = new System.Windows.Forms.TextBox();
            this.tienSuBenhTxtBox = new System.Windows.Forms.TextBox();
            this.metroSetLabel9 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel8 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.metroSetLabel7 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel6 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.benAnDGV = new System.Windows.Forms.DataGridView();
            this.STT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MABA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYLAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYTAIKHAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MABN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENSUBENH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRIEUCHUNG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAIBENH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHANDOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HUONGXULY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GHICHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroSetLabel10 = new MetroSet_UI.Controls.MetroSetLabel();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.deleteBenhNhanTrongDanhSachBtn = new System.Windows.Forms.Button();
            this.benhNhanListDGV = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MABN1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONTHUOC = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.examTabControl.SuspendLayout();
            this.BENHAN.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.benAnDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.benhNhanListDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // examTabControl
            // 
            this.examTabControl.Controls.Add(this.BENHAN);
            this.examTabControl.Controls.Add(this.DONTHUOC);
            this.examTabControl.Depth = 0;
            this.examTabControl.HotTrack = true;
            this.examTabControl.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.examTabControl.Location = new System.Drawing.Point(0, 29);
            this.examTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.examTabControl.Name = "examTabControl";
            this.examTabControl.SelectedIndex = 0;
            this.examTabControl.Size = new System.Drawing.Size(1218, 590);
            this.examTabControl.TabIndex = 66;
            this.examTabControl.SelectedIndexChanged += new System.EventHandler(this.examTabControl_SelectedIndexChanged);
            // 
            // BENHAN
            // 
            this.BENHAN.Controls.Add(this.groupBox2);
            this.BENHAN.Controls.Add(this.groupBox3);
            this.BENHAN.Controls.Add(this.groupBox1);
            this.BENHAN.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BENHAN.Location = new System.Drawing.Point(4, 24);
            this.BENHAN.Name = "BENHAN";
            this.BENHAN.Padding = new System.Windows.Forms.Padding(3);
            this.BENHAN.Size = new System.Drawing.Size(1210, 562);
            this.BENHAN.TabIndex = 0;
            this.BENHAN.Text = "Bệnh án";
            this.BENHAN.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ngayTaiKhamDTPicker);
            this.groupBox2.Controls.Add(this.ngayKhamDTPicker);
            this.groupBox2.Controls.Add(this.deleteBtn);
            this.groupBox2.Controls.Add(this.cancelBtn);
            this.groupBox2.Controls.Add(this.noteTextBox);
            this.groupBox2.Controls.Add(this.saveBtn);
            this.groupBox2.Controls.Add(this.updateBtn);
            this.groupBox2.Controls.Add(this.huongxulyTxtBox);
            this.groupBox2.Controls.Add(this.adddBtn);
            this.groupBox2.Controls.Add(this.chanDoanCBB);
            this.groupBox2.Controls.Add(this.loaiBenhCBB);
            this.groupBox2.Controls.Add(this.trieuchungTxtBox);
            this.groupBox2.Controls.Add(this.tienSuBenhTxtBox);
            this.groupBox2.Controls.Add(this.metroSetLabel9);
            this.groupBox2.Controls.Add(this.metroSetLabel8);
            this.groupBox2.Controls.Add(this.metroSetLabel1);
            this.groupBox2.Controls.Add(this.nameTxtBox);
            this.groupBox2.Controls.Add(this.metroSetLabel7);
            this.groupBox2.Controls.Add(this.metroSetLabel6);
            this.groupBox2.Controls.Add(this.metroSetLabel5);
            this.groupBox2.Controls.Add(this.metroSetLabel4);
            this.groupBox2.Controls.Add(this.metroSetLabel3);
            this.groupBox2.Controls.Add(this.metroSetLabel2);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(885, 380);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết bệnh án";
            // 
            // ngayTaiKhamDTPicker
            // 
            this.ngayTaiKhamDTPicker.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ngayTaiKhamDTPicker.Location = new System.Drawing.Point(555, 22);
            this.ngayTaiKhamDTPicker.Name = "ngayTaiKhamDTPicker";
            this.ngayTaiKhamDTPicker.Size = new System.Drawing.Size(163, 21);
            this.ngayTaiKhamDTPicker.TabIndex = 4;
            // 
            // ngayKhamDTPicker
            // 
            this.ngayKhamDTPicker.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ngayKhamDTPicker.Location = new System.Drawing.Point(172, 24);
            this.ngayKhamDTPicker.Name = "ngayKhamDTPicker";
            this.ngayKhamDTPicker.Size = new System.Drawing.Size(163, 21);
            this.ngayKhamDTPicker.TabIndex = 0;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.White;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.Image = global::GUI.Properties.Resources.delete;
            this.deleteBtn.Location = new System.Drawing.Point(767, 142);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(112, 37);
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.Text = "Xoá";
            this.deleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click_1);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(161)))), ((int)(((byte)(32)))));
            this.cancelBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Image = global::GUI.Properties.Resources.logout;
            this.cancelBtn.Location = new System.Drawing.Point(767, 96);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(112, 40);
            this.cancelBtn.TabIndex = 15;
            this.cancelBtn.Text = "Huỷ bỏ ";
            this.cancelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // noteTextBox
            // 
            this.noteTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noteTextBox.Location = new System.Drawing.Point(0, 219);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(885, 161);
            this.noteTextBox.TabIndex = 8;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Image = global::GUI.Properties.Resources.save;
            this.saveBtn.Location = new System.Drawing.Point(767, 50);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(110, 40);
            this.saveBtn.TabIndex = 14;
            this.saveBtn.Text = "Xác nhận";
            this.saveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.White;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateBtn.ForeColor = System.Drawing.Color.Black;
            this.updateBtn.Image = global::GUI.Properties.Resources.edit;
            this.updateBtn.Location = new System.Drawing.Point(767, 96);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(110, 40);
            this.updateBtn.TabIndex = 12;
            this.updateBtn.Text = "Cập nhật";
            this.updateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // huongxulyTxtBox
            // 
            this.huongxulyTxtBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.huongxulyTxtBox.Location = new System.Drawing.Point(555, 163);
            this.huongxulyTxtBox.Name = "huongxulyTxtBox";
            this.huongxulyTxtBox.Size = new System.Drawing.Size(163, 25);
            this.huongxulyTxtBox.TabIndex = 7;
            // 
            // adddBtn
            // 
            this.adddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(211)))), ((int)(((byte)(149)))));
            this.adddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adddBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adddBtn.ForeColor = System.Drawing.Color.White;
            this.adddBtn.Image = global::GUI.Properties.Resources.add;
            this.adddBtn.Location = new System.Drawing.Point(767, 50);
            this.adddBtn.Name = "adddBtn";
            this.adddBtn.Size = new System.Drawing.Size(110, 40);
            this.adddBtn.TabIndex = 11;
            this.adddBtn.Text = "Thêm";
            this.adddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.adddBtn.UseVisualStyleBackColor = false;
            this.adddBtn.Click += new System.EventHandler(this.adddBtn_Click);
            // 
            // chanDoanCBB
            // 
            this.chanDoanCBB.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chanDoanCBB.FormattingEnabled = true;
            this.chanDoanCBB.Location = new System.Drawing.Point(172, 165);
            this.chanDoanCBB.Name = "chanDoanCBB";
            this.chanDoanCBB.Size = new System.Drawing.Size(163, 25);
            this.chanDoanCBB.TabIndex = 3;
            // 
            // loaiBenhCBB
            // 
            this.loaiBenhCBB.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loaiBenhCBB.FormattingEnabled = true;
            this.loaiBenhCBB.ItemHeight = 17;
            this.loaiBenhCBB.Location = new System.Drawing.Point(555, 111);
            this.loaiBenhCBB.Name = "loaiBenhCBB";
            this.loaiBenhCBB.Size = new System.Drawing.Size(163, 25);
            this.loaiBenhCBB.TabIndex = 57;
            // 
            // trieuchungTxtBox
            // 
            this.trieuchungTxtBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trieuchungTxtBox.Location = new System.Drawing.Point(555, 65);
            this.trieuchungTxtBox.Name = "trieuchungTxtBox";
            this.trieuchungTxtBox.Size = new System.Drawing.Size(163, 25);
            this.trieuchungTxtBox.TabIndex = 5;
            // 
            // tienSuBenhTxtBox
            // 
            this.tienSuBenhTxtBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tienSuBenhTxtBox.Location = new System.Drawing.Point(172, 116);
            this.tienSuBenhTxtBox.Name = "tienSuBenhTxtBox";
            this.tienSuBenhTxtBox.Size = new System.Drawing.Size(163, 25);
            this.tienSuBenhTxtBox.TabIndex = 2;
            // 
            // metroSetLabel9
            // 
            this.metroSetLabel9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel9.IsDerivedStyle = true;
            this.metroSetLabel9.Location = new System.Drawing.Point(6, 195);
            this.metroSetLabel9.Name = "metroSetLabel9";
            this.metroSetLabel9.Size = new System.Drawing.Size(84, 21);
            this.metroSetLabel9.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel9.StyleManager = null;
            this.metroSetLabel9.TabIndex = 54;
            this.metroSetLabel9.Text = "Ghi chú";
            this.metroSetLabel9.ThemeAuthor = "Narwin";
            this.metroSetLabel9.ThemeName = "MetroLite";
            // 
            // metroSetLabel8
            // 
            this.metroSetLabel8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel8.IsDerivedStyle = true;
            this.metroSetLabel8.Location = new System.Drawing.Point(389, 167);
            this.metroSetLabel8.Name = "metroSetLabel8";
            this.metroSetLabel8.Size = new System.Drawing.Size(96, 23);
            this.metroSetLabel8.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel8.StyleManager = null;
            this.metroSetLabel8.TabIndex = 53;
            this.metroSetLabel8.Text = "Hướng xử lý ";
            this.metroSetLabel8.ThemeAuthor = "Narwin";
            this.metroSetLabel8.ThemeName = "MetroLite";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(6, 165);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(96, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 52;
            this.metroSetLabel1.Text = "Chẩn đoán ";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTxtBox.Location = new System.Drawing.Point(172, 65);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(163, 25);
            this.nameTxtBox.TabIndex = 1;
            // 
            // metroSetLabel7
            // 
            this.metroSetLabel7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel7.IsDerivedStyle = true;
            this.metroSetLabel7.Location = new System.Drawing.Point(389, 121);
            this.metroSetLabel7.Name = "metroSetLabel7";
            this.metroSetLabel7.Size = new System.Drawing.Size(96, 23);
            this.metroSetLabel7.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel7.StyleManager = null;
            this.metroSetLabel7.TabIndex = 44;
            this.metroSetLabel7.Text = "Loại bệnh";
            this.metroSetLabel7.ThemeAuthor = "Narwin";
            this.metroSetLabel7.ThemeName = "MetroLite";
            // 
            // metroSetLabel6
            // 
            this.metroSetLabel6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel6.IsDerivedStyle = true;
            this.metroSetLabel6.Location = new System.Drawing.Point(389, 71);
            this.metroSetLabel6.Name = "metroSetLabel6";
            this.metroSetLabel6.Size = new System.Drawing.Size(96, 23);
            this.metroSetLabel6.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel6.StyleManager = null;
            this.metroSetLabel6.TabIndex = 43;
            this.metroSetLabel6.Text = "Triệu chứng ";
            this.metroSetLabel6.ThemeAuthor = "Narwin";
            this.metroSetLabel6.ThemeName = "MetroLite";
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel5.IsDerivedStyle = true;
            this.metroSetLabel5.Location = new System.Drawing.Point(6, 121);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(96, 23);
            this.metroSetLabel5.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.TabIndex = 42;
            this.metroSetLabel5.Text = "Tiền sử bệnh ";
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroLite";
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel4.IsDerivedStyle = true;
            this.metroSetLabel4.Location = new System.Drawing.Point(389, 24);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(104, 23);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 41;
            this.metroSetLabel4.Text = "Ngày tái khám ";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLite";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(6, 26);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(84, 23);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 40;
            this.metroSetLabel3.Text = "Ngày khám ";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(6, 71);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(59, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 39;
            this.metroSetLabel2.Text = "Họ tên";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.benAnDGV);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(2, 386);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(883, 197);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách bệnh án";
            // 
            // benAnDGV
            // 
            this.benAnDGV.AllowUserToAddRows = false;
            this.benAnDGV.AllowUserToDeleteRows = false;
            this.benAnDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.benAnDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.benAnDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT1,
            this.HOTEN1,
            this.MABA,
            this.NGAYLAP,
            this.NGAYTAIKHAM,
            this.MABN,
            this.TIENSUBENH,
            this.TRIEUCHUNG,
            this.LOAIBENH,
            this.CHANDOAN,
            this.HUONGXULY,
            this.GHICHU,
            this.MANV});
            this.benAnDGV.Location = new System.Drawing.Point(0, 20);
            this.benAnDGV.Name = "benAnDGV";
            this.benAnDGV.RowHeadersVisible = false;
            this.benAnDGV.RowTemplate.Height = 25;
            this.benAnDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.benAnDGV.Size = new System.Drawing.Size(882, 177);
            this.benAnDGV.TabIndex = 0;
            this.benAnDGV.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.benAnDGV_RowEnter);
            this.benAnDGV.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.benAnDGV_RowPostPaint);
            // 
            // STT1
            // 
            this.STT1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.STT1.HeaderText = "STT";
            this.STT1.Name = "STT1";
            this.STT1.Width = 61;
            // 
            // HOTEN1
            // 
            this.HOTEN1.DataPropertyName = "HOTEN";
            this.HOTEN1.HeaderText = "Họ tên";
            this.HOTEN1.Name = "HOTEN1";
            this.HOTEN1.Visible = false;
            // 
            // MABA
            // 
            this.MABA.DataPropertyName = "MABA";
            this.MABA.HeaderText = "Mã bệnh án";
            this.MABA.Name = "MABA";
            this.MABA.Visible = false;
            // 
            // NGAYLAP
            // 
            this.NGAYLAP.DataPropertyName = "NGAYLAP";
            this.NGAYLAP.HeaderText = "Ngày lập";
            this.NGAYLAP.Name = "NGAYLAP";
            // 
            // NGAYTAIKHAM
            // 
            this.NGAYTAIKHAM.DataPropertyName = "NGAYTAIKHAM";
            this.NGAYTAIKHAM.HeaderText = "Ngày tái khám ";
            this.NGAYTAIKHAM.Name = "NGAYTAIKHAM";
            // 
            // MABN
            // 
            this.MABN.DataPropertyName = "MABN";
            this.MABN.HeaderText = "Mã bệnh nhân";
            this.MABN.Name = "MABN";
            this.MABN.Visible = false;
            // 
            // TIENSUBENH
            // 
            this.TIENSUBENH.DataPropertyName = "TIENSUBENH";
            this.TIENSUBENH.HeaderText = "Tiền sử bệnh";
            this.TIENSUBENH.Name = "TIENSUBENH";
            this.TIENSUBENH.Visible = false;
            // 
            // TRIEUCHUNG
            // 
            this.TRIEUCHUNG.DataPropertyName = "TRIEUCHUNG";
            this.TRIEUCHUNG.HeaderText = " Triệu chứng ";
            this.TRIEUCHUNG.Name = "TRIEUCHUNG";
            this.TRIEUCHUNG.Visible = false;
            // 
            // LOAIBENH
            // 
            this.LOAIBENH.DataPropertyName = "LOAIBENH";
            this.LOAIBENH.HeaderText = "Loại bệnh";
            this.LOAIBENH.Name = "LOAIBENH";
            // 
            // CHANDOAN
            // 
            this.CHANDOAN.DataPropertyName = "CHANDOAN";
            this.CHANDOAN.HeaderText = "Chẩn đoán ";
            this.CHANDOAN.Name = "CHANDOAN";
            // 
            // HUONGXULY
            // 
            this.HUONGXULY.DataPropertyName = "HUONGXULY";
            this.HUONGXULY.HeaderText = "Hướng xử lý ";
            this.HUONGXULY.Name = "HUONGXULY";
            // 
            // GHICHU
            // 
            this.GHICHU.DataPropertyName = "GHICHU";
            this.GHICHU.HeaderText = "Ghi chú ";
            this.GHICHU.Name = "GHICHU";
            this.GHICHU.Visible = false;
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "MÃ NHÂN VIEN";
            this.MANV.Name = "MANV";
            this.MANV.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroSetLabel10);
            this.groupBox1.Controls.Add(this.searchTextbox);
            this.groupBox1.Controls.Add(this.deleteBenhNhanTrongDanhSachBtn);
            this.groupBox1.Controls.Add(this.benhNhanListDGV);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(891, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 583);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách bệnh nhân";
            // 
            // metroSetLabel10
            // 
            this.metroSetLabel10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel10.IsDerivedStyle = true;
            this.metroSetLabel10.Location = new System.Drawing.Point(0, 504);
            this.metroSetLabel10.Name = "metroSetLabel10";
            this.metroSetLabel10.Size = new System.Drawing.Size(125, 23);
            this.metroSetLabel10.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel10.StyleManager = null;
            this.metroSetLabel10.TabIndex = 63;
            this.metroSetLabel10.Text = "Tìm kiếm CMND";
            this.metroSetLabel10.ThemeAuthor = "Narwin";
            this.metroSetLabel10.ThemeName = "MetroLite";
            // 
            // searchTextbox
            // 
            this.searchTextbox.Location = new System.Drawing.Point(131, 504);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(185, 25);
            this.searchTextbox.TabIndex = 9;
            this.searchTextbox.TextChanged += new System.EventHandler(this.searchTextbox_TextChanged);
            // 
            // deleteBenhNhanTrongDanhSachBtn
            // 
            this.deleteBenhNhanTrongDanhSachBtn.BackColor = System.Drawing.Color.White;
            this.deleteBenhNhanTrongDanhSachBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBenhNhanTrongDanhSachBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteBenhNhanTrongDanhSachBtn.Image = global::GUI.Properties.Resources.delete;
            this.deleteBenhNhanTrongDanhSachBtn.Location = new System.Drawing.Point(239, 538);
            this.deleteBenhNhanTrongDanhSachBtn.Name = "deleteBenhNhanTrongDanhSachBtn";
            this.deleteBenhNhanTrongDanhSachBtn.Size = new System.Drawing.Size(77, 39);
            this.deleteBenhNhanTrongDanhSachBtn.TabIndex = 10;
            this.deleteBenhNhanTrongDanhSachBtn.Text = "Xoá";
            this.deleteBenhNhanTrongDanhSachBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteBenhNhanTrongDanhSachBtn.UseVisualStyleBackColor = false;
            this.deleteBenhNhanTrongDanhSachBtn.Click += new System.EventHandler(this.deleteBenhNhanTrongDanhSachBtn_Click);
            // 
            // benhNhanListDGV
            // 
            this.benhNhanListDGV.AllowUserToAddRows = false;
            this.benhNhanListDGV.AllowUserToDeleteRows = false;
            this.benhNhanListDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.benhNhanListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.benhNhanListDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.CMND,
            this.MABN1,
            this.HOTEN,
            this.GT,
            this.DIACHI,
            this.SDT});
            this.benhNhanListDGV.Location = new System.Drawing.Point(-1, 20);
            this.benhNhanListDGV.Name = "benhNhanListDGV";
            this.benhNhanListDGV.RowHeadersVisible = false;
            this.benhNhanListDGV.RowTemplate.Height = 25;
            this.benhNhanListDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.benhNhanListDGV.Size = new System.Drawing.Size(324, 473);
            this.benhNhanListDGV.TabIndex = 0;
            this.benhNhanListDGV.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.benhNhanListDGV_RowEnter);
            this.benhNhanListDGV.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.benhNhanListDGV_RowPostPaint);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 61;
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            // 
            // MABN1
            // 
            this.MABN1.DataPropertyName = "MABN";
            this.MABN1.HeaderText = "Mã bệnh nhân";
            this.MABN1.Name = "MABN1";
            this.MABN1.Visible = false;
            // 
            // HOTEN
            // 
            this.HOTEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Họ tên";
            this.HOTEN.Name = "HOTEN";
            // 
            // GT
            // 
            this.GT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.GT.DataPropertyName = "GT";
            this.GT.HeaderText = "Giới tính";
            this.GT.Name = "GT";
            this.GT.Width = 5;
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa chỉ ";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Visible = false;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại ";
            this.SDT.Name = "SDT";
            this.SDT.Visible = false;
            // 
            // DONTHUOC
            // 
            this.DONTHUOC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DONTHUOC.Location = new System.Drawing.Point(4, 24);
            this.DONTHUOC.Name = "DONTHUOC";
            this.DONTHUOC.Padding = new System.Windows.Forms.Padding(3);
            this.DONTHUOC.Size = new System.Drawing.Size(1210, 562);
            this.DONTHUOC.TabIndex = 1;
            this.DONTHUOC.Text = "Đơn thuốc";
            this.DONTHUOC.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.examTabControl;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1218, 23);
            this.materialTabSelector1.TabIndex = 67;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // KhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.examTabControl);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "KhamBenh";
            this.Size = new System.Drawing.Size(1218, 619);
            this.Load += new System.EventHandler(this.KhamBenh_Load);
            this.examTabControl.ResumeLayout(false);
            this.BENHAN.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.benAnDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.benhNhanListDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage DONTHUOC;
        private System.Windows.Forms.TabPage BENHAN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.TextBox huongxulyTxtBox;
        private System.Windows.Forms.ComboBox chanDoanCBB;
        private System.Windows.Forms.ComboBox loaiBenhCBB;
        private System.Windows.Forms.TextBox trieuchungTxtBox;
        private System.Windows.Forms.TextBox tienSuBenhTxtBox;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel9;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel8;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private System.Windows.Forms.TextBox nameTxtBox;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel7;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel6;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView benAnDGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView benhNhanListDGV;
        private MaterialSkin.Controls.MaterialTabControl examTabControl;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button adddBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button deleteBenhNhanTrongDanhSachBtn;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel10;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.DataGridView danhSA;
        private System.Windows.Forms.Button e;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker ngayKhamDTPicker;
        private System.Windows.Forms.DateTimePicker ngayTaiKhamDTPicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn MABN1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MABA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYLAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTAIKHAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MABN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENSUBENH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRIEUCHUNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAIBENH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHANDOAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn HUONGXULY;
        private System.Windows.Forms.DataGridViewTextBoxColumn GHICHU;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
    }
}
