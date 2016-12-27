namespace JD_Online_Shop {
    partial class FormWelcome {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent () {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdminCancel = new System.Windows.Forms.Button();
            this.btnAdminDefin = new System.Windows.Forms.Button();
            this.tbAdminPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnForgetPwd = new System.Windows.Forms.Button();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnUserLogin = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnForgetPwd);
            this.panel1.Controls.Add(this.btnAdminLogin);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.btnUserLogin);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 125);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAdminCancel);
            this.panel2.Controls.Add(this.btnAdminDefin);
            this.panel2.Controls.Add(this.tbAdminPwd);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(52, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 90);
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
            // 
            // btnAdminCancel
            // 
            this.btnAdminCancel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdminCancel.Location = new System.Drawing.Point(120, 57);
            this.btnAdminCancel.Name = "btnAdminCancel";
            this.btnAdminCancel.Size = new System.Drawing.Size(82, 30);
            this.btnAdminCancel.TabIndex = 3;
            this.btnAdminCancel.Text = "取  消";
            this.btnAdminCancel.UseVisualStyleBackColor = true;
            this.btnAdminCancel.Click += new System.EventHandler(this.btnAdminCancel_Click);
            // 
            // btnAdminDefin
            // 
            this.btnAdminDefin.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdminDefin.Location = new System.Drawing.Point(18, 57);
            this.btnAdminDefin.Name = "btnAdminDefin";
            this.btnAdminDefin.Size = new System.Drawing.Size(82, 30);
            this.btnAdminDefin.TabIndex = 2;
            this.btnAdminDefin.Text = "确  定";
            this.btnAdminDefin.UseVisualStyleBackColor = true;
            // 
            // tbAdminPwd
            // 
            this.tbAdminPwd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbAdminPwd.Location = new System.Drawing.Point(120, 18);
            this.tbAdminPwd.Name = "tbAdminPwd";
            this.tbAdminPwd.PasswordChar = '*';
            this.tbAdminPwd.Size = new System.Drawing.Size(100, 26);
            this.tbAdminPwd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入管理员密码：";
            // 
            // btnForgetPwd
            // 
            this.btnForgetPwd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnForgetPwd.Location = new System.Drawing.Point(52, 76);
            this.btnForgetPwd.Name = "btnForgetPwd";
            this.btnForgetPwd.Size = new System.Drawing.Size(93, 30);
            this.btnForgetPwd.TabIndex = 3;
            this.btnForgetPwd.Text = "忘记密码";
            this.btnForgetPwd.UseVisualStyleBackColor = true;
            this.btnForgetPwd.Click += new System.EventHandler(this.btnForgetPwd_Click);
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdminLogin.Location = new System.Drawing.Point(194, 76);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(93, 30);
            this.btnAdminLogin.TabIndex = 2;
            this.btnAdminLogin.Text = "管理员登录";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRegister.Location = new System.Drawing.Point(194, 24);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(93, 30);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnUserLogin
            // 
            this.btnUserLogin.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUserLogin.Location = new System.Drawing.Point(52, 24);
            this.btnUserLogin.Name = "btnUserLogin";
            this.btnUserLogin.Size = new System.Drawing.Size(93, 30);
            this.btnUserLogin.TabIndex = 0;
            this.btnUserLogin.Text = "用户登录";
            this.btnUserLogin.UseVisualStyleBackColor = true;
            this.btnUserLogin.Click += new System.EventHandler(this.btnUserLogin_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuit.Location = new System.Drawing.Point(113, 144);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(131, 30);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "退出商城";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTest.Location = new System.Drawing.Point(250, 144);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(94, 30);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "初始化测试";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // FormWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 181);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormWelcome";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "欢迎";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnForgetPwd;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnUserLogin;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdminCancel;
        private System.Windows.Forms.Button btnAdminDefin;
        private System.Windows.Forms.TextBox tbAdminPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTest;
    }
}

