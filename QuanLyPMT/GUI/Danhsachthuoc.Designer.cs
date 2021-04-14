
namespace GUI
{
    partial class Danhsachthuoc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.danhSachThuocDgv = new System.Windows.Forms.DataGridView();
            this.numeric = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useWay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBtn = new System.Windows.Forms.Button();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachThuocDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.danhSachThuocDgv);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(-1, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 483);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách thuốc";
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
            this.priceOut});
            this.danhSachThuocDgv.Location = new System.Drawing.Point(0, 24);
            this.danhSachThuocDgv.Name = "danhSachThuocDgv";
            this.danhSachThuocDgv.ReadOnly = true;
            this.danhSachThuocDgv.RowTemplate.Height = 25;
            this.danhSachThuocDgv.Size = new System.Drawing.Size(566, 458);
            this.danhSachThuocDgv.TabIndex = 0;
            // 
            // numeric
            // 
            this.numeric.HeaderText = "STT";
            this.numeric.Name = "numeric";
            this.numeric.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Tên thuốc";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // useWay
            // 
            this.useWay.HeaderText = "Đường dùng";
            this.useWay.Name = "useWay";
            this.useWay.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.HeaderText = "Số lượng tồn ";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.HeaderText = "Đơn vị tính ";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // priceIn
            // 
            this.priceIn.HeaderText = "Giá nhập";
            this.priceIn.Name = "priceIn";
            this.priceIn.ReadOnly = true;
            // 
            // priceOut
            // 
            this.priceOut.HeaderText = "Giá bán";
            this.priceOut.Name = "priceOut";
            this.priceOut.ReadOnly = true;
            // 
            // searchBtn
            // 
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBtn.ForeColor = System.Drawing.Color.Black;
            this.searchBtn.Image = global::GUI.Properties.Resources.search__1_;
            this.searchBtn.Location = new System.Drawing.Point(438, 22);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(99, 36);
            this.searchBtn.TabIndex = 30;
            this.searchBtn.Text = "Tìm kiếm ";
            this.searchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTextbox.Location = new System.Drawing.Point(143, 35);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(181, 26);
            this.nameTextbox.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tên thuốc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tìm kiếm thuốc\r\n";
            // 
            // deleteBtn
            // 
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBtn.Image = global::GUI.Properties.Resources.delete;
            this.deleteBtn.Location = new System.Drawing.Point(438, 73);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(99, 37);
            this.deleteBtn.TabIndex = 32;
            this.deleteBtn.Text = "Xoá";
            this.deleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // Danhsachthuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteBtn);
            this.Name = "Danhsachthuoc";
            this.Size = new System.Drawing.Size(568, 596);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.danhSachThuocDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView danhSachThuocDgv;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeric;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn useWay;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceOut;
    }
}
