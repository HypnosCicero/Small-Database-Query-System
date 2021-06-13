
namespace WindowsForDatabase
{
    partial class Form_Register
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
            this.label_ID = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label_PassWord = new System.Windows.Forms.Label();
            this.textBox_PassWord = new System.Windows.Forms.TextBox();
            this.label_RePassword = new System.Windows.Forms.Label();
            this.textBox_RePassword = new System.Windows.Forms.TextBox();
            this.button_Register = new System.Windows.Forms.Button();
            this.label_showReslut = new System.Windows.Forms.Label();
            this.checkBox_Password = new System.Windows.Forms.CheckBox();
            this.checkBox_RePassword = new System.Windows.Forms.CheckBox();
            this.label_IDNULL = new System.Windows.Forms.Label();
            this.label_PasswordNULL = new System.Windows.Forms.Label();
            this.label_RePasswordNULL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(40, 56);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(104, 17);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "请输入你的账号：";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(40, 92);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(213, 23);
            this.textBox_ID.TabIndex = 1;
            // 
            // label_PassWord
            // 
            this.label_PassWord.AutoSize = true;
            this.label_PassWord.Location = new System.Drawing.Point(40, 149);
            this.label_PassWord.Name = "label_PassWord";
            this.label_PassWord.Size = new System.Drawing.Size(80, 17);
            this.label_PassWord.TabIndex = 2;
            this.label_PassWord.Text = "请输入密码：";
            // 
            // textBox_PassWord
            // 
            this.textBox_PassWord.Location = new System.Drawing.Point(40, 186);
            this.textBox_PassWord.Name = "textBox_PassWord";
            this.textBox_PassWord.Size = new System.Drawing.Size(213, 23);
            this.textBox_PassWord.TabIndex = 3;
            // 
            // label_RePassword
            // 
            this.label_RePassword.AutoSize = true;
            this.label_RePassword.Location = new System.Drawing.Point(40, 246);
            this.label_RePassword.Name = "label_RePassword";
            this.label_RePassword.Size = new System.Drawing.Size(104, 17);
            this.label_RePassword.TabIndex = 4;
            this.label_RePassword.Text = "请再次输入密码：";
            // 
            // textBox_RePassword
            // 
            this.textBox_RePassword.Location = new System.Drawing.Point(40, 283);
            this.textBox_RePassword.Name = "textBox_RePassword";
            this.textBox_RePassword.Size = new System.Drawing.Size(213, 23);
            this.textBox_RePassword.TabIndex = 5;
            // 
            // button_Register
            // 
            this.button_Register.Location = new System.Drawing.Point(207, 377);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(133, 51);
            this.button_Register.TabIndex = 6;
            this.button_Register.Text = "注册";
            this.button_Register.UseVisualStyleBackColor = true;
            this.button_Register.Click += new System.EventHandler(this.button_Register_Click);
            // 
            // label_showReslut
            // 
            this.label_showReslut.AutoSize = true;
            this.label_showReslut.Location = new System.Drawing.Point(68, 343);
            this.label_showReslut.Name = "label_showReslut";
            this.label_showReslut.Size = new System.Drawing.Size(20, 17);
            this.label_showReslut.TabIndex = 7;
            this.label_showReslut.Text = "无";
            // 
            // checkBox_Password
            // 
            this.checkBox_Password.AutoSize = true;
            this.checkBox_Password.Location = new System.Drawing.Point(259, 188);
            this.checkBox_Password.Name = "checkBox_Password";
            this.checkBox_Password.Size = new System.Drawing.Size(75, 21);
            this.checkBox_Password.TabIndex = 8;
            this.checkBox_Password.Text = "显示密码";
            this.checkBox_Password.UseVisualStyleBackColor = true;
            this.checkBox_Password.CheckedChanged += new System.EventHandler(this.checkBox_Password_CheckedChanged);
            // 
            // checkBox_RePassword
            // 
            this.checkBox_RePassword.AutoSize = true;
            this.checkBox_RePassword.Location = new System.Drawing.Point(259, 285);
            this.checkBox_RePassword.Name = "checkBox_RePassword";
            this.checkBox_RePassword.Size = new System.Drawing.Size(75, 21);
            this.checkBox_RePassword.TabIndex = 9;
            this.checkBox_RePassword.Text = "显示密码";
            this.checkBox_RePassword.UseVisualStyleBackColor = true;
            this.checkBox_RePassword.CheckedChanged += new System.EventHandler(this.checkBox_RePassword_CheckedChanged);
            // 
            // label_IDNULL
            // 
            this.label_IDNULL.AutoSize = true;
            this.label_IDNULL.Location = new System.Drawing.Point(210, 118);
            this.label_IDNULL.Name = "label_IDNULL";
            this.label_IDNULL.Size = new System.Drawing.Size(20, 17);
            this.label_IDNULL.TabIndex = 10;
            this.label_IDNULL.Text = "无";
            // 
            // label_PasswordNULL
            // 
            this.label_PasswordNULL.AutoSize = true;
            this.label_PasswordNULL.Location = new System.Drawing.Point(210, 212);
            this.label_PasswordNULL.Name = "label_PasswordNULL";
            this.label_PasswordNULL.Size = new System.Drawing.Size(20, 17);
            this.label_PasswordNULL.TabIndex = 11;
            this.label_PasswordNULL.Text = "无";
            // 
            // label_RePasswordNULL
            // 
            this.label_RePasswordNULL.AutoSize = true;
            this.label_RePasswordNULL.Location = new System.Drawing.Point(210, 309);
            this.label_RePasswordNULL.Name = "label_RePasswordNULL";
            this.label_RePasswordNULL.Size = new System.Drawing.Size(20, 17);
            this.label_RePasswordNULL.TabIndex = 12;
            this.label_RePasswordNULL.Text = "无";
            // 
            // Form_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 440);
            this.Controls.Add(this.label_RePasswordNULL);
            this.Controls.Add(this.label_PasswordNULL);
            this.Controls.Add(this.label_IDNULL);
            this.Controls.Add(this.checkBox_RePassword);
            this.Controls.Add(this.checkBox_Password);
            this.Controls.Add(this.label_showReslut);
            this.Controls.Add(this.button_Register);
            this.Controls.Add(this.textBox_RePassword);
            this.Controls.Add(this.label_RePassword);
            this.Controls.Add(this.textBox_PassWord);
            this.Controls.Add(this.label_PassWord);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label_ID);
            this.Name = "Form_Register";
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label_PassWord;
        private System.Windows.Forms.TextBox textBox_PassWord;
        private System.Windows.Forms.Label label_RePassword;
        private System.Windows.Forms.TextBox textBox_RePassword;
        private System.Windows.Forms.Button button_Register;
        private System.Windows.Forms.Label label_showReslut;
        private System.Windows.Forms.CheckBox checkBox_Password;
        private System.Windows.Forms.CheckBox checkBox_RePassword;
        private System.Windows.Forms.Label label_IDNULL;
        private System.Windows.Forms.Label label_PasswordNULL;
        private System.Windows.Forms.Label label_RePasswordNULL;
    }
}