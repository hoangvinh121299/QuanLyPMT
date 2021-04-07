
namespace GUI
{
    partial class danhSachBenhNhan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.danhSachBenhNhanDgv = new System.Windows.Forms.DataGridView();
            this.numeric = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNumeric = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachBenhNhanDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm bệnh nhân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số CMND";
            // 
            // idTxtBox
            // 
            this.idTxtBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idTxtBox.Location = new System.Drawing.Point(144, 36);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.Size = new System.Drawing.Size(181, 26);
            this.idTxtBox.TabIndex = 2;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.White;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBtn.ForeColor = System.Drawing.Color.Black;
            this.searchBtn.Image = global::GUI.Properties.Resources.search__1_;
            this.searchBtn.Location = new System.Drawing.Point(439, 23);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(99, 36);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Tìm kiếm ";
            this.searchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchBtn.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.danhSachBenhNhanDgv);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 483);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách bệnh nhân";
            // 
            // danhSachBenhNhanDgv
            // 
            this.danhSachBenhNhanDgv.AllowUserToAddRows = false;
            this.danhSachBenhNhanDgv.AllowUserToDeleteRows = false;
            this.danhSachBenhNhanDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.danhSachBenhNhanDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhSachBenhNhanDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeric,
            this.name,
            this.idNumeric,
            this.birth,
            this.sex});
            this.danhSachBenhNhanDgv.Location = new System.Drawing.Point(0, 24);
            this.danhSachBenhNhanDgv.Name = "danhSachBenhNhanDgv";
            this.danhSachBenhNhanDgv.ReadOnly = true;
            this.danhSachBenhNhanDgv.RowTemplate.Height = 25;
            this.danhSachBenhNhanDgv.Size = new System.Drawing.Size(566, 458);
            this.danhSachBenhNhanDgv.TabIndex = 0;
            // 
            // numeric
            // 
            this.numeric.HeaderText = "STT";
            this.numeric.Name = "numeric";
            this.numeric.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Họ và tên";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // idNumeric
            // 
            this.idNumeric.HeaderText = "Số CMND";
            this.idNumeric.Name = "idNumeric";
            this.idNumeric.ReadOnly = true;
            // 
            // birth
            // 
            this.birth.HeaderText = "Ngày sinh";
            this.birth.Name = "birth";
            this.birth.ReadOnly = true;
            // 
            // sex
            // 
            this.sex.HeaderText = "Giới tính";
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.White;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.Image = global::GUI.Properties.Resources.delete;
            this.deleteBtn.Location = new System.Drawing.Point(439, 74);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(99, 37);
            this.deleteBtn.TabIndex = 26;
            this.deleteBtn.Text = "Xoá";
            this.deleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // danhSachBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "danhSachBenhNhan";
            this.Size = new System.Drawing.Size(570, 598);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.danhSachBenhNhanDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView danhSachBenhNhanDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeric;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNumeric;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.Button deleteBtn;
    }
}
