
namespace GUI
{
    partial class danhSachBenh
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
            this.searchBtn = new System.Windows.Forms.Button();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.numeric = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachThuocDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.danhSachThuocDgv);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 483);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách bệnh";
            // 
            // danhSachThuocDgv
            // 
            this.danhSachThuocDgv.AllowUserToAddRows = false;
            this.danhSachThuocDgv.AllowUserToDeleteRows = false;
            this.danhSachThuocDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.danhSachThuocDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhSachThuocDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeric,
            this.name});
            this.danhSachThuocDgv.Location = new System.Drawing.Point(0, 24);
            this.danhSachThuocDgv.Name = "danhSachThuocDgv";
            this.danhSachThuocDgv.ReadOnly = true;
            this.danhSachThuocDgv.RowTemplate.Height = 25;
            this.danhSachThuocDgv.Size = new System.Drawing.Size(566, 458);
            this.danhSachThuocDgv.TabIndex = 0;
            // 
            // searchBtn
            // 
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBtn.ForeColor = System.Drawing.Color.Black;
            this.searchBtn.Image = global::GUI.Properties.Resources.search__1_;
            this.searchBtn.Location = new System.Drawing.Point(433, 21);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(99, 36);
            this.searchBtn.TabIndex = 36;
            this.searchBtn.Text = "Tìm kiếm ";
            this.searchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTextbox.Location = new System.Drawing.Point(142, 34);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(181, 26);
            this.nameTextbox.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "Tên bệnh ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-2, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tìm kiếm bệnh ";
            // 
            // deleteBtn
            // 
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.Image = global::GUI.Properties.Resources.delete;
            this.deleteBtn.Location = new System.Drawing.Point(433, 72);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(99, 37);
            this.deleteBtn.TabIndex = 38;
            this.deleteBtn.Text = "Xoá";
            this.deleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // numeric
            // 
            this.numeric.HeaderText = "STT";
            this.numeric.Name = "numeric";
            this.numeric.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Tên bệnh";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // danhSachBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteBtn);
            this.Name = "danhSachBenh";
            this.Size = new System.Drawing.Size(568, 596);
            this.Load += new System.EventHandler(this.danhSachBenh_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.danhSachThuocDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView danhSachThuocDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeric;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteBtn;
    }
}
