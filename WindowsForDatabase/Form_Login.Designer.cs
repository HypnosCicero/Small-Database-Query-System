
namespace WindowsForDatabase
{
    partial class Form_Login
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
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_PassWord = new System.Windows.Forms.TextBox();
            this.button_register = new System.Windows.Forms.Button();
            this.button_Login = new System.Windows.Forms.Button();
            this.checkBox_PassWord = new System.Windows.Forms.CheckBox();
            this.label_IDNULL = new System.Windows.Forms.Label();
            this.label_PasswordNULL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(12, 97);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(32, 17);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "账号";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(60, 93);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(210, 23);
            this.textBox_ID.TabIndex = 1;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(12, 177);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(32, 17);
            this.label_Password.TabIndex = 2;
            this.label_Password.Text = "密码";
            // 
            // textBox_PassWord
            // 
            this.textBox_PassWord.Location = new System.Drawing.Point(60, 171);
            this.textBox_PassWord.Name = "textBox_PassWord";
            this.textBox_PassWord.Size = new System.Drawing.Size(210, 23);
            this.textBox_PassWord.TabIndex = 3;
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(12, 269);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(128, 31);
            this.button_register.TabIndex = 4;
            this.button_register.Text = "新用户注册";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(224, 270);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(134, 30);
            this.button_Login.TabIndex = 5;
            this.button_Login.Text = "登录";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // checkBox_PassWord
            // 
            this.checkBox_PassWord.AutoSize = true;
            this.checkBox_PassWord.Location = new System.Drawing.Point(282, 177);
            this.checkBox_PassWord.Name = "checkBox_PassWord";
            this.checkBox_PassWord.Size = new System.Drawing.Size(75, 21);
            this.checkBox_PassWord.TabIndex = 6;
            this.checkBox_PassWord.Text = "显示密码";
            this.checkBox_PassWord.UseVisualStyleBackColor = true;
            this.checkBox_PassWord.CheckedChanged += new System.EventHandler(this.checkBox_PassWord_CheckedChanged);
            // 
            // label_IDNULL
            // 
            this.label_IDNULL.AutoSize = true;
            this.label_IDNULL.Location = new System.Drawing.Point(227, 119);
            this.label_IDNULL.Name = "label_IDNULL";
            this.label_IDNULL.Size = new System.Drawing.Size(20, 17);
            this.label_IDNULL.TabIndex = 7;
            this.label_IDNULL.Text = "无";
            // 
            // label_PasswordNULL
            // 
            this.label_PasswordNULL.AutoSize = true;
            this.label_PasswordNULL.Location = new System.Drawing.Point(227, 197);
            this.label_PasswordNULL.Name = "label_PasswordNULL";
            this.label_PasswordNULL.Size = new System.Drawing.Size(20, 17);
            this.label_PasswordNULL.TabIndex = 8;
            this.label_PasswordNULL.Text = "无";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 355);
            this.Controls.Add(this.label_PasswordNULL);
            this.Controls.Add(this.label_IDNULL);
            this.Controls.Add(this.checkBox_PassWord);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.textBox_PassWord);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label_ID);
            this.Name = "Form_Login";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_PassWord;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.CheckBox checkBox_PassWord;
        private System.Windows.Forms.Label label_IDNULL;
        private System.Windows.Forms.Label label_PasswordNULL;
    }
}