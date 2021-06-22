
namespace GUI
{
    partial class QuanLyBenh
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
            this.txtb_GhiChu = new System.Windows.Forms.TextBox();
            this.txtb_TrieuChung = new System.Windows.Forms.TextBox();
            this.txtb_TenBenh1 = new System.Windows.Forms.TextBox();
            this.metroSetLabel8 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtg_DanhSachBenh = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txtb_TenBenh2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Cancle = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.cb_LoaiBenh = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.numeric = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENBENH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRIEUCHUNG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GHICHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachBenh)).BeginInit();
            this.SuspendLayout();
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.White;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editBtn.ForeColor = System.Drawing.Color.Black;
            this.editBtn.Image = global::GUI.Properties.Resources.edit;
            this.editBtn.Location = new System.Drawing.Point(425, 78);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(125, 41);
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
            this.addBtn.Location = new System.Drawing.Point(425, 19);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(125, 41);
            this.addBtn.TabIndex = 46;
            this.addBtn.Text = "Thêm";
            this.addBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // txtb_GhiChu
            // 
            this.txtb_GhiChu.Location = new System.Drawing.Point(14, 371);
            this.txtb_GhiChu.Multiline = true;
            this.txtb_GhiChu.Name = "txtb_GhiChu";
            this.txtb_GhiChu.Size = new System.Drawing.Size(598, 223);
            this.txtb_GhiChu.TabIndex = 39;
            // 
            // txtb_TrieuChung
            // 
            this.txtb_TrieuChung.Location = new System.Drawing.Point(14, 166);
            this.txtb_TrieuChung.Multiline = true;
            this.txtb_TrieuChung.Name = "txtb_TrieuChung";
            this.txtb_TrieuChung.Size = new System.Drawing.Size(598, 176);
            this.txtb_TrieuChung.TabIndex = 36;
            // 
            // txtb_TenBenh1
            // 
            this.txtb_TenBenh1.BackColor = System.Drawing.SystemColors.Window;
            this.txtb_TenBenh1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_TenBenh1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtb_TenBenh1.Location = new System.Drawing.Point(139, 52);
            this.txtb_TenBenh1.Name = "txtb_TenBenh1";
            this.txtb_TenBenh1.Size = new System.Drawing.Size(203, 25);
            this.txtb_TenBenh1.TabIndex = 35;
            // 
            // metroSetLabel8
            // 
            this.metroSetLabel8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel8.IsDerivedStyle = true;
            this.metroSetLabel8.Location = new System.Drawing.Point(14, 345);
            this.metroSetLabel8.Name = "metroSetLabel8";
            this.metroSetLabel8.Size = new System.Drawing.Size(86, 23);
            this.metroSetLabel8.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel8.StyleManager = null;
            this.metroSetLabel8.TabIndex = 34;
            this.metroSetLabel8.Text = "Ghi chú ";
            this.metroSetLabel8.ThemeAuthor = "Narwin";
            this.metroSetLabel8.ThemeName = "MetroLite";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(14, 138);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(127, 23);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 29;
            this.metroSetLabel3.Text = "Triệu chứng ";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(14, 54);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(94, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 28;
            this.metroSetLabel2.Text = "Tên bệnh";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(4, 4);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(175, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 27;
            this.metroSetLabel1.Text = "Thông tin bệnh";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtg_DanhSachBenh);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(629, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 483);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách bệnh";
            // 
            // dtg_DanhSachBenh
            // 
            this.dtg_DanhSachBenh.AllowUserToAddRows = false;
            this.dtg_DanhSachBenh.AllowUserToDeleteRows = false;
            this.dtg_DanhSachBenh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_DanhSachBenh.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtg_DanhSachBenh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DanhSachBenh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeric,
            this.TENBENH,
            this.TENLB,
            this.TRIEUCHUNG,
            this.GHICHU});
            this.dtg_DanhSachBenh.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtg_DanhSachBenh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_DanhSachBenh.Location = new System.Drawing.Point(3, 25);
            this.dtg_DanhSachBenh.MultiSelect = false;
            this.dtg_DanhSachBenh.Name = "dtg_DanhSachBenh";
            this.dtg_DanhSachBenh.ReadOnly = true;
            this.dtg_DanhSachBenh.RowHeadersVisible = false;
            this.dtg_DanhSachBenh.RowHeadersWidth = 51;
            this.dtg_DanhSachBenh.RowTemplate.Height = 25;
            this.dtg_DanhSachBenh.Size = new System.Drawing.Size(566, 455);
            this.dtg_DanhSachBenh.TabIndex = 0;
            this.dtg_DanhSachBenh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DanhSachBenh_CellClick);
            this.dtg_DanhSachBenh.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtg_DanhSachBenh_RowPostPaint);
            // 
            // btn_Search
            // 
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Search.ForeColor = System.Drawing.Color.Black;
            this.btn_Search.Image = global::GUI.Properties.Resources.search__1_;
            this.btn_Search.Location = new System.Drawing.Point(1007, 19);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(113, 41);
            this.btn_Search.TabIndex = 52;
            this.btn_Search.Text = "Tìm kiếm ";
            this.btn_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // txtb_TenBenh2
            // 
            this.txtb_TenBenh2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtb_TenBenh2.Location = new System.Drawing.Point(771, 35);
            this.txtb_TenBenh2.Name = "txtb_TenBenh2";
            this.txtb_TenBenh2.Size = new System.Drawing.Size(181, 30);
            this.txtb_TenBenh2.TabIndex = 51;
            this.txtb_TenBenh2.TextChanged += new System.EventHandler(this.txtb_TenBenh2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(657, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 50;
            this.label2.Text = "Tên bệnh ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(627, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "Tìm kiếm bệnh ";
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Delete.Image = global::GUI.Properties.Resources.delete;
            this.btn_Delete.Location = new System.Drawing.Point(1007, 66);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(113, 41);
            this.btn_Delete.TabIndex = 54;
            this.btn_Delete.Text = "Xoá";
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Cancle
            // 
            this.btn_Cancle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(161)))), ((int)(((byte)(32)))));
            this.btn_Cancle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancle.ForeColor = System.Drawing.Color.White;
            this.btn_Cancle.Image = global::GUI.Properties.Resources.logout;
            this.btn_Cancle.Location = new System.Drawing.Point(425, 78);
            this.btn_Cancle.Name = "btn_Cancle";
            this.btn_Cancle.Size = new System.Drawing.Size(125, 41);
            this.btn_Cancle.TabIndex = 56;
            this.btn_Cancle.Text = "Huỷ bỏ ";
            this.btn_Cancle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Cancle.UseVisualStyleBackColor = false;
            this.btn_Cancle.Click += new System.EventHandler(this.btn_Cancle_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Image = global::GUI.Properties.Resources.save;
            this.btn_Save.Location = new System.Drawing.Point(425, 19);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(125, 41);
            this.btn_Save.TabIndex = 55;
            this.btn_Save.Text = "Xác nhận";
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // cb_LoaiBenh
            // 
            this.cb_LoaiBenh.AllowDrop = true;
            this.cb_LoaiBenh.ArrowColor = System.Drawing.Color.Black;
            this.cb_LoaiBenh.BackColor = System.Drawing.Color.Transparent;
            this.cb_LoaiBenh.BackgroundColor = System.Drawing.Color.White;
            this.cb_LoaiBenh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cb_LoaiBenh.CausesValidation = false;
            this.cb_LoaiBenh.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cb_LoaiBenh.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cb_LoaiBenh.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cb_LoaiBenh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_LoaiBenh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_LoaiBenh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_LoaiBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_LoaiBenh.IsDerivedStyle = true;
            this.cb_LoaiBenh.ItemHeight = 20;
            this.cb_LoaiBenh.Items.AddRange(new object[] {
            "Xương khớp",
            "Da liễu",
            "Hệ bài tiết"});
            this.cb_LoaiBenh.Location = new System.Drawing.Point(139, 93);
            this.cb_LoaiBenh.Name = "cb_LoaiBenh";
            this.cb_LoaiBenh.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cb_LoaiBenh.SelectedItemForeColor = System.Drawing.Color.White;
            this.cb_LoaiBenh.Size = new System.Drawing.Size(203, 26);
            this.cb_LoaiBenh.Style = MetroSet_UI.Enums.Style.Custom;
            this.cb_LoaiBenh.StyleManager = null;
            this.cb_LoaiBenh.TabIndex = 57;
            this.cb_LoaiBenh.ThemeAuthor = "";
            this.cb_LoaiBenh.ThemeName = "MetroLite";
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel4.IsDerivedStyle = true;
            this.metroSetLabel4.Location = new System.Drawing.Point(14, 96);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(94, 23);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 58;
            this.metroSetLabel4.Text = "Loại bệnh";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLite";
            // 
            // numeric
            // 
            this.numeric.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.numeric.FillWeight = 53.47594F;
            this.numeric.HeaderText = "STT";
            this.numeric.MinimumWidth = 10;
            this.numeric.Name = "numeric";
            this.numeric.ReadOnly = true;
            this.numeric.Width = 76;
            // 
            // TENBENH
            // 
            this.TENBENH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TENBENH.DataPropertyName = "TENBENH";
            this.TENBENH.FillWeight = 146.5241F;
            this.TENBENH.HeaderText = "Tên bệnh";
            this.TENBENH.MinimumWidth = 10;
            this.TENBENH.Name = "TENBENH";
            this.TENBENH.ReadOnly = true;
            this.TENBENH.Width = 119;
            // 
            // TENLB
            // 
            this.TENLB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TENLB.DataPropertyName = "TENLB";
            this.TENLB.HeaderText = "Loại Bệnh";
            this.TENLB.MinimumWidth = 6;
            this.TENLB.Name = "TENLB";
            this.TENLB.ReadOnly = true;
            this.TENLB.Width = 124;
            // 
            // TRIEUCHUNG
            // 
            this.TRIEUCHUNG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.TRIEUCHUNG.DataPropertyName = "TRIEUCHUNG";
            this.TRIEUCHUNG.HeaderText = "Triệu Chứng";
            this.TRIEUCHUNG.MinimumWidth = 6;
            this.TRIEUCHUNG.Name = "TRIEUCHUNG";
            this.TRIEUCHUNG.ReadOnly = true;
            this.TRIEUCHUNG.Width = 6;
            // 
            // GHICHU
            // 
            this.GHICHU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GHICHU.DataPropertyName = "GHICHU";
            this.GHICHU.HeaderText = "Ghi Chú";
            this.GHICHU.MinimumWidth = 6;
            this.GHICHU.Name = "GHICHU";
            this.GHICHU.ReadOnly = true;
            // 
            // QuanLyBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.metroSetLabel4);
            this.Controls.Add(this.cb_LoaiBenh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txtb_TenBenh2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.txtb_GhiChu);
            this.Controls.Add(this.txtb_TrieuChung);
            this.Controls.Add(this.txtb_TenBenh1);
            this.Controls.Add(this.metroSetLabel8);
            this.Controls.Add(this.metroSetLabel3);
            this.Controls.Add(this.metroSetLabel2);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Cancle);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "QuanLyBenh";
            this.Size = new System.Drawing.Size(1207, 606);
            this.Load += new System.EventHandler(this.QuanLyBenh_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachBenh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox noteCbbox;
        private System.Windows.Forms.TextBox txtb_TrieuChung;
        private System.Windows.Forms.TextBox txtb_TenBenh1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel8;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtg_DanhSachBenh;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txtb_TenBenh2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Cancle;
        private System.Windows.Forms.Button btn_Save;
        private MetroSet_UI.Controls.MetroSetComboBox cb_LoaiBenh;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private System.Windows.Forms.TextBox txtb_GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeric;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENBENH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRIEUCHUNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn GHICHU;
    }
}
