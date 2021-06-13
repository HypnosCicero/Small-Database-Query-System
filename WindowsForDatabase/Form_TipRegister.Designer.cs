
namespace WindowsForDatabase
{
    partial class Form_TipRegister
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "系统尚未找到此账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "请检查你的账号是否有误，若你尚未注册请点击下面的按钮进行注册";
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(121, 184);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(181, 58);
            this.button_register.TabIndex = 2;
            this.button_register.Text = "注册新用户";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // Form_TipRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 279);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_TipRegister";
            this.Text = "提示";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_register;
    }
}