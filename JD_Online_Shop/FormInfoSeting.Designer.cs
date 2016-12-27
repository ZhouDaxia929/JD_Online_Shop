namespace JD_Online_Shop {
    partial class FormInfoSeting {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfoSeting));
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPwd1 = new System.Windows.Forms.Label();
            this.txtPwd1 = new System.Windows.Forms.TextBox();
            this.btnChoosePic = new System.Windows.Forms.Button();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.lblPwd2 = new System.Windows.Forms.Label();
            this.txtPwd2 = new System.Windows.Forms.TextBox();
            this.lblPwd3 = new System.Windows.Forms.Label();
            this.txtPwd3 = new System.Windows.Forms.TextBox();
            this.lblEdit = new System.Windows.Forms.Label();
            this.lblSave = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(51, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "邮箱地址：";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(161, 171);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(270, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(65, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "用户名：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(161, 208);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(270, 26);
            this.txtName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(51, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "电话号码：";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(161, 245);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(270, 26);
            this.txtPhone.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(79, 285);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "性别：";
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(161, 282);
            this.txtSex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(270, 26);
            this.txtSex.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(51, 321);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "收货地址：";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(161, 318);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(270, 26);
            this.txtAddress.TabIndex = 15;
            // 
            // lblPwd1
            // 
            this.lblPwd1.AutoSize = true;
            this.lblPwd1.BackColor = System.Drawing.Color.Transparent;
            this.lblPwd1.ForeColor = System.Drawing.Color.Transparent;
            this.lblPwd1.Location = new System.Drawing.Point(37, 358);
            this.lblPwd1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPwd1.Name = "lblPwd1";
            this.lblPwd1.Size = new System.Drawing.Size(93, 20);
            this.lblPwd1.TabIndex = 18;
            this.lblPwd1.Text = "输入原密码：";
            this.lblPwd1.Visible = false;
            // 
            // txtPwd1
            // 
            this.txtPwd1.Location = new System.Drawing.Point(161, 355);
            this.txtPwd1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPwd1.Name = "txtPwd1";
            this.txtPwd1.PasswordChar = '*';
            this.txtPwd1.ReadOnly = true;
            this.txtPwd1.Size = new System.Drawing.Size(270, 26);
            this.txtPwd1.TabIndex = 17;
            this.txtPwd1.Visible = false;
            this.txtPwd1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPwd1_KeyPress);
            // 
            // btnChoosePic
            // 
            this.btnChoosePic.BackColor = System.Drawing.Color.Transparent;
            this.btnChoosePic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChoosePic.BackgroundImage")));
            this.btnChoosePic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChoosePic.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChoosePic.ForeColor = System.Drawing.Color.Transparent;
            this.btnChoosePic.Location = new System.Drawing.Point(209, 122);
            this.btnChoosePic.Name = "btnChoosePic";
            this.btnChoosePic.Size = new System.Drawing.Size(90, 30);
            this.btnChoosePic.TabIndex = 20;
            this.btnChoosePic.Text = "更换头像";
            this.btnChoosePic.UseVisualStyleBackColor = false;
            this.btnChoosePic.Visible = false;
            this.btnChoosePic.Click += new System.EventHandler(this.btnChoosePic_Click);
            // 
            // picUser
            // 
            this.picUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUser.BackgroundImage")));
            this.picUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUser.Location = new System.Drawing.Point(202, 3);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(104, 113);
            this.picUser.TabIndex = 19;
            this.picUser.TabStop = false;
            // 
            // lblPwd2
            // 
            this.lblPwd2.AutoSize = true;
            this.lblPwd2.BackColor = System.Drawing.Color.Transparent;
            this.lblPwd2.ForeColor = System.Drawing.Color.Transparent;
            this.lblPwd2.Location = new System.Drawing.Point(37, 395);
            this.lblPwd2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPwd2.Name = "lblPwd2";
            this.lblPwd2.Size = new System.Drawing.Size(93, 20);
            this.lblPwd2.TabIndex = 22;
            this.lblPwd2.Text = "输入新密码：";
            this.lblPwd2.Visible = false;
            // 
            // txtPwd2
            // 
            this.txtPwd2.Location = new System.Drawing.Point(161, 392);
            this.txtPwd2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPwd2.Name = "txtPwd2";
            this.txtPwd2.PasswordChar = '*';
            this.txtPwd2.ReadOnly = true;
            this.txtPwd2.Size = new System.Drawing.Size(270, 26);
            this.txtPwd2.TabIndex = 21;
            this.txtPwd2.Visible = false;
            // 
            // lblPwd3
            // 
            this.lblPwd3.AutoSize = true;
            this.lblPwd3.BackColor = System.Drawing.Color.Transparent;
            this.lblPwd3.ForeColor = System.Drawing.Color.Transparent;
            this.lblPwd3.Location = new System.Drawing.Point(37, 432);
            this.lblPwd3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPwd3.Name = "lblPwd3";
            this.lblPwd3.Size = new System.Drawing.Size(93, 20);
            this.lblPwd3.TabIndex = 24;
            this.lblPwd3.Text = "确认新密码：";
            this.lblPwd3.Visible = false;
            // 
            // txtPwd3
            // 
            this.txtPwd3.Location = new System.Drawing.Point(161, 429);
            this.txtPwd3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPwd3.Name = "txtPwd3";
            this.txtPwd3.PasswordChar = '*';
            this.txtPwd3.ReadOnly = true;
            this.txtPwd3.Size = new System.Drawing.Size(270, 26);
            this.txtPwd3.TabIndex = 23;
            this.txtPwd3.Visible = false;
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.BackColor = System.Drawing.Color.Transparent;
            this.lblEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEdit.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEdit.ForeColor = System.Drawing.Color.Transparent;
            this.lblEdit.Location = new System.Drawing.Point(352, 23);
            this.lblEdit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(88, 25);
            this.lblEdit.TabIndex = 25;
            this.lblEdit.Text = "编辑信息";
            this.lblEdit.Click += new System.EventHandler(this.lblEdit_Click);
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.BackColor = System.Drawing.Color.Transparent;
            this.lblSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSave.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSave.ForeColor = System.Drawing.Color.Transparent;
            this.lblSave.Location = new System.Drawing.Point(352, 65);
            this.lblSave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(50, 25);
            this.lblSave.TabIndex = 26;
            this.lblSave.Text = "保存";
            this.lblSave.Visible = false;
            this.lblSave.Click += new System.EventHandler(this.lblSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormInfoSeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 553);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.lblPwd3);
            this.Controls.Add(this.txtPwd3);
            this.Controls.Add(this.lblPwd2);
            this.Controls.Add(this.txtPwd2);
            this.Controls.Add(this.btnChoosePic);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.lblPwd1);
            this.Controls.Add(this.txtPwd1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormInfoSeting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInfoSeting";
            this.Load += new System.EventHandler(this.FormInfoSeting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPwd1;
        private System.Windows.Forms.TextBox txtPwd1;
        private System.Windows.Forms.Button btnChoosePic;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Label lblPwd2;
        private System.Windows.Forms.TextBox txtPwd2;
        private System.Windows.Forms.Label lblPwd3;
        private System.Windows.Forms.TextBox txtPwd3;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}