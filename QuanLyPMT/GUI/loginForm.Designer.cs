
namespace GUI
{
    partial class loginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.username_Txtbox = new System.Windows.Forms.TextBox();
            this.pwrd_Txttbox = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.forgetPwrd_linklable = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginError = new System.Windows.Forms.Label();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.showPwrd_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // username_Txtbox
            // 
            this.username_Txtbox.BackColor = System.Drawing.Color.White;
            this.username_Txtbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username_Txtbox.ForeColor = System.Drawing.Color.Black;
            this.username_Txtbox.Location = new System.Drawing.Point(379, 343);
            this.username_Txtbox.Name = "username_Txtbox";
            this.username_Txtbox.PlaceholderText = "Tên đăng nhập";
            this.username_Txtbox.Size = new System.Drawing.Size(245, 26);
            this.username_Txtbox.TabIndex = 1;
            // 
            // pwrd_Txttbox
            // 
            this.pwrd_Txttbox.BackColor = System.Drawing.Color.White;
            this.pwrd_Txttbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pwrd_Txttbox.ForeColor = System.Drawing.Color.Black;
            this.pwrd_Txttbox.Location = new System.Drawing.Point(379, 390);
            this.pwrd_Txttbox.Name = "pwrd_Txttbox";
            this.pwrd_Txttbox.PlaceholderText = "Mật khẩu ";
            this.pwrd_Txttbox.Size = new System.Drawing.Size(245, 26);
            this.pwrd_Txttbox.TabIndex = 2;
            this.pwrd_Txttbox.UseSystemPasswordChar = true;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(379, 433);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(104, 39);
            this.login_btn.TabIndex = 3;
            this.login_btn.Text = "Đăng nhập";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // forgetPwrd_linklable
            // 
            this.forgetPwrd_linklable.AutoSize = true;
            this.forgetPwrd_linklable.BackColor = System.Drawing.Color.White;
            this.forgetPwrd_linklable.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.forgetPwrd_linklable.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.forgetPwrd_linklable.Location = new System.Drawing.Point(489, 450);
            this.forgetPwrd_linklable.Name = "forgetPwrd_linklable";
            this.forgetPwrd_linklable.Size = new System.Drawing.Size(122, 22);
            this.forgetPwrd_linklable.TabIndex = 4;
            this.forgetPwrd_linklable.TabStop = true;
            this.forgetPwrd_linklable.Text = "Quên mật khẩu ?";
            this.forgetPwrd_linklable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::GUI.Properties.Resources.hospital;
            this.pictureBox1.Location = new System.Drawing.Point(373, 74);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 234);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loginError
            // 
            this.loginError.AutoSize = true;
            this.loginError.BackColor = System.Drawing.Color.White;
            this.loginError.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.loginError.ForeColor = System.Drawing.Color.Red;
            this.loginError.Location = new System.Drawing.Point(343, 475);
            this.loginError.Name = "loginError";
            this.loginError.Size = new System.Drawing.Size(316, 16);
            this.loginError.TabIndex = 5;
            this.loginError.Text = "Sai tên đăng nhập và mật khẩu. Vui lòng kiểm tra lại ";
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(855, -1);
            this.metroSetControlBox1.MaximizeBox = true;
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
            this.metroSetControlBox1.TabIndex = 6;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // showPwrd_Btn
            // 
            this.showPwrd_Btn.BackColor = System.Drawing.Color.White;
            this.showPwrd_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPwrd_Btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.showPwrd_Btn.Image = global::GUI.Properties.Resources.invisible;
            this.showPwrd_Btn.Location = new System.Drawing.Point(630, 390);
            this.showPwrd_Btn.Name = "showPwrd_Btn";
            this.showPwrd_Btn.Size = new System.Drawing.Size(26, 26);
            this.showPwrd_Btn.TabIndex = 34;
            this.showPwrd_Btn.UseVisualStyleBackColor = false;
            this.showPwrd_Btn.Click += new System.EventHandler(this.showPwrd_Btn_Click);
            // 
            // loginForm
            // 
            this.AllowResize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(954, 544);
            this.Controls.Add(this.showPwrd_Btn);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.loginError);
            this.Controls.Add(this.forgetPwrd_linklable);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.pwrd_Txttbox);
            this.Controls.Add(this.username_Txtbox);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.Name = "loginForm";
            this.SmallLineColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.SmallLineColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox username_Txtbox;
        private System.Windows.Forms.TextBox pwrd_Txttbox;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.LinkLabel forgetPwrd_linklable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label loginError;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private System.Windows.Forms.Button showPwrd_Btn;
    }
}