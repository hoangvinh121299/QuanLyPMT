
namespace GUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitBtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.patientBtn = new System.Windows.Forms.Button();
            this.accountBtn = new System.Windows.Forms.Button();
            this.sickBtn = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.drugBtn = new System.Windows.Forms.Button();
            this.examBtn = new System.Windows.Forms.Button();
            this.workPlacePnl = new System.Windows.Forms.Panel();
            this.funcPnel = new System.Windows.Forms.Panel();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.workPlacePnl.SuspendLayout();
            this.funcPnel.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Image = global::GUI.Properties.Resources.exit;
            this.exitBtn.Location = new System.Drawing.Point(1088, 0);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(135, 72);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Thoát";
            this.exitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitBtn.UseVisualStyleBackColor = false;
            // 
            // aboutBtn
            // 
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aboutBtn.ForeColor = System.Drawing.Color.White;
            this.aboutBtn.Image = global::GUI.Properties.Resources.info;
            this.aboutBtn.Location = new System.Drawing.Point(943, 0);
            this.aboutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(141, 72);
            this.aboutBtn.TabIndex = 6;
            this.aboutBtn.Text = "About";
            this.aboutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.aboutBtn.UseVisualStyleBackColor = false;
            // 
            // patientBtn
            // 
            this.patientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patientBtn.ForeColor = System.Drawing.Color.White;
            this.patientBtn.Image = global::GUI.Properties.Resources.people1;
            this.patientBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientBtn.Location = new System.Drawing.Point(0, 0);
            this.patientBtn.Margin = new System.Windows.Forms.Padding(2);
            this.patientBtn.Name = "patientBtn";
            this.patientBtn.Size = new System.Drawing.Size(158, 72);
            this.patientBtn.TabIndex = 0;
            this.patientBtn.Text = "Quản lý bệnh nhân";
            this.patientBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.patientBtn.UseVisualStyleBackColor = false;
            this.patientBtn.Click += new System.EventHandler(this.patientBtn_Click);
            // 
            // accountBtn
            // 
            this.accountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accountBtn.ForeColor = System.Drawing.Color.White;
            this.accountBtn.Image = global::GUI.Properties.Resources.team;
            this.accountBtn.Location = new System.Drawing.Point(789, 0);
            this.accountBtn.Margin = new System.Windows.Forms.Padding(2);
            this.accountBtn.Name = "accountBtn";
            this.accountBtn.Size = new System.Drawing.Size(149, 72);
            this.accountBtn.TabIndex = 5;
            this.accountBtn.Text = "Quản lý tài khoản";
            this.accountBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.accountBtn.UseVisualStyleBackColor = false;
            // 
            // sickBtn
            // 
            this.sickBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sickBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sickBtn.ForeColor = System.Drawing.Color.White;
            this.sickBtn.Image = global::GUI.Properties.Resources.malaria;
            this.sickBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.sickBtn.Location = new System.Drawing.Point(162, 0);
            this.sickBtn.Margin = new System.Windows.Forms.Padding(2);
            this.sickBtn.Name = "sickBtn";
            this.sickBtn.Size = new System.Drawing.Size(164, 72);
            this.sickBtn.TabIndex = 1;
            this.sickBtn.Text = "Quản lý loại bệnh";
            this.sickBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sickBtn.UseVisualStyleBackColor = false;
            // 
            // reportBtn
            // 
            this.reportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reportBtn.ForeColor = System.Drawing.Color.White;
            this.reportBtn.Image = global::GUI.Properties.Resources.business_report;
            this.reportBtn.Location = new System.Drawing.Point(634, 0);
            this.reportBtn.Margin = new System.Windows.Forms.Padding(2);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(151, 72);
            this.reportBtn.TabIndex = 4;
            this.reportBtn.Text = "Báo cáo thống kê";
            this.reportBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reportBtn.UseVisualStyleBackColor = false;
            // 
            // drugBtn
            // 
            this.drugBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drugBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.drugBtn.ForeColor = System.Drawing.Color.White;
            this.drugBtn.Image = global::GUI.Properties.Resources.medicine;
            this.drugBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.drugBtn.Location = new System.Drawing.Point(330, 0);
            this.drugBtn.Margin = new System.Windows.Forms.Padding(2);
            this.drugBtn.Name = "drugBtn";
            this.drugBtn.Size = new System.Drawing.Size(158, 72);
            this.drugBtn.TabIndex = 2;
            this.drugBtn.Text = "Quản lý tồn kho thuốc";
            this.drugBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.drugBtn.UseVisualStyleBackColor = false;
            // 
            // examBtn
            // 
            this.examBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.examBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.examBtn.ForeColor = System.Drawing.Color.White;
            this.examBtn.Image = global::GUI.Properties.Resources.examination;
            this.examBtn.Location = new System.Drawing.Point(492, 0);
            this.examBtn.Margin = new System.Windows.Forms.Padding(2);
            this.examBtn.Name = "examBtn";
            this.examBtn.Size = new System.Drawing.Size(138, 72);
            this.examBtn.TabIndex = 3;
            this.examBtn.Text = "Khám bệnh";
            this.examBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.examBtn.UseVisualStyleBackColor = false;
            // 
            // workPlacePnl
            // 
            this.workPlacePnl.AutoSize = true;
            this.workPlacePnl.Controls.Add(this.displayPanel);
            this.workPlacePnl.Controls.Add(this.funcPnel);
            this.workPlacePnl.Location = new System.Drawing.Point(0, 82);
            this.workPlacePnl.Name = "workPlacePnl";
            this.workPlacePnl.Size = new System.Drawing.Size(1233, 696);
            this.workPlacePnl.TabIndex = 8;
            // 
            // funcPnel
            // 
            this.funcPnel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.funcPnel.Controls.Add(this.drugBtn);
            this.funcPnel.Controls.Add(this.examBtn);
            this.funcPnel.Controls.Add(this.patientBtn);
            this.funcPnel.Controls.Add(this.aboutBtn);
            this.funcPnel.Controls.Add(this.exitBtn);
            this.funcPnel.Controls.Add(this.sickBtn);
            this.funcPnel.Controls.Add(this.accountBtn);
            this.funcPnel.Controls.Add(this.reportBtn);
            this.funcPnel.Location = new System.Drawing.Point(1, 0);
            this.funcPnel.Name = "funcPnel";
            this.funcPnel.Size = new System.Drawing.Size(1222, 72);
            this.funcPnel.TabIndex = 9;
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(1123, 4);
            this.metroSetControlBox1.MaximizeBox = false;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 9;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // displayPanel
            // 
            this.displayPanel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.displayPanel.Location = new System.Drawing.Point(1, 78);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(1229, 615);
            this.displayPanel.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AllowResize = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.BorderColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1224, 775);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.workPlacePnl);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HeaderColor = System.Drawing.Color.MediumSpringGreen;
            this.Name = "MainForm";
            this.ShowBorder = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.SmallLineColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.SmallLineColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.Text = "Quản lý phòng mạch tư";
            this.TextColor = System.Drawing.Color.Black;
            this.workPlacePnl.ResumeLayout(false);
            this.funcPnel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button accountBtn;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.Button examBtn;
        private System.Windows.Forms.Button drugBtn;
        private System.Windows.Forms.Button sickBtn;
        private System.Windows.Forms.Button patientBtn;
        private System.Windows.Forms.Panel workPlacePnl;
        private System.Windows.Forms.Panel funcPnel;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private System.Windows.Forms.Panel displayPanel;
    }
}

