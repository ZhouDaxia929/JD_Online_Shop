namespace JD_Online_Shop {
    partial class FormRegister {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtPwd2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVerify = new System.Windows.Forms.TextBox();
            this.picVerify = new System.Windows.Forms.PictureBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChoosePic = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVerify)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(125, 167);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(203, 26);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(125, 216);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(203, 26);
            this.txtName.TabIndex = 1;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(125, 265);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(203, 26);
            this.txtPwd.TabIndex = 2;
            // 
            // txtPwd2
            // 
            this.txtPwd2.Location = new System.Drawing.Point(125, 314);
            this.txtPwd2.Name = "txtPwd2";
            this.txtPwd2.PasswordChar = '*';
            this.txtPwd2.Size = new System.Drawing.Size(203, 26);
            this.txtPwd2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "输入邮箱地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "输入用户昵称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(40, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "输入密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(40, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "确认密码：";
            // 
            // picUser
            // 
            this.picUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUser.BackgroundImage")));
            this.picUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUser.Location = new System.Drawing.Point(151, 12);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(104, 113);
            this.picUser.TabIndex = 8;
            this.picUser.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(26, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "输入验证码：";
            // 
            // txtVerify
            // 
            this.txtVerify.Location = new System.Drawing.Point(125, 356);
            this.txtVerify.Name = "txtVerify";
            this.txtVerify.Size = new System.Drawing.Size(90, 26);
            this.txtVerify.TabIndex = 10;
            // 
            // picVerify
            // 
            this.picVerify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picVerify.Location = new System.Drawing.Point(221, 356);
            this.picVerify.Name = "picVerify";
            this.picVerify.Size = new System.Drawing.Size(102, 27);
            this.picVerify.TabIndex = 12;
            this.picVerify.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOK.BackgroundImage")));
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.ForeColor = System.Drawing.Color.Transparent;
            this.btnOK.Location = new System.Drawing.Point(140, 393);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 30);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "注    册";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(238, 393);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "取    消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChoosePic
            // 
            this.btnChoosePic.BackColor = System.Drawing.Color.Transparent;
            this.btnChoosePic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChoosePic.BackgroundImage")));
            this.btnChoosePic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChoosePic.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChoosePic.ForeColor = System.Drawing.Color.Transparent;
            this.btnChoosePic.Location = new System.Drawing.Point(156, 131);
            this.btnChoosePic.Name = "btnChoosePic";
            this.btnChoosePic.Size = new System.Drawing.Size(90, 30);
            this.btnChoosePic.TabIndex = 15;
            this.btnChoosePic.Text = "上传头像";
            this.btnChoosePic.UseVisualStyleBackColor = false;
            this.btnChoosePic.Click += new System.EventHandler(this.btnChoosePic_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(329, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "换一张";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(379, 435);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnChoosePic);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.picVerify);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVerify);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPwd2);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmail);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVerify)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtPwd2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVerify;
        private System.Windows.Forms.PictureBox picVerify;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChoosePic;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label5;
    }
}