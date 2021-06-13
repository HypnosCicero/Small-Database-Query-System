
namespace WindowsForDatabase
{
    partial class Form_UpdateDatabase
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
            this.label_TextData1 = new System.Windows.Forms.Label();
            this.textBox_Data1 = new System.Windows.Forms.TextBox();
            this.label_TextData2 = new System.Windows.Forms.Label();
            this.textBox_Data2 = new System.Windows.Forms.TextBox();
            this.label_TextData3 = new System.Windows.Forms.Label();
            this.textBox_Data3 = new System.Windows.Forms.TextBox();
            this.button_Update = new System.Windows.Forms.Button();
            this.label_ShowChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_TextData1
            // 
            this.label_TextData1.AutoSize = true;
            this.label_TextData1.Location = new System.Drawing.Point(24, 34);
            this.label_TextData1.Name = "label_TextData1";
            this.label_TextData1.Size = new System.Drawing.Size(63, 17);
            this.label_TextData1.TabIndex = 0;
            this.label_TextData1.Text = "测试数据1";
            // 
            // textBox_Data1
            // 
            this.textBox_Data1.Enabled = false;
            this.textBox_Data1.Location = new System.Drawing.Point(24, 54);
            this.textBox_Data1.Name = "textBox_Data1";
            this.textBox_Data1.Size = new System.Drawing.Size(237, 23);
            this.textBox_Data1.TabIndex = 1;
            // 
            // label_TextData2
            // 
            this.label_TextData2.AutoSize = true;
            this.label_TextData2.Location = new System.Drawing.Point(24, 124);
            this.label_TextData2.Name = "label_TextData2";
            this.label_TextData2.Size = new System.Drawing.Size(63, 17);
            this.label_TextData2.TabIndex = 2;
            this.label_TextData2.Text = "测试数据2";
            // 
            // textBox_Data2
            // 
            this.textBox_Data2.Location = new System.Drawing.Point(24, 144);
            this.textBox_Data2.Name = "textBox_Data2";
            this.textBox_Data2.Size = new System.Drawing.Size(236, 23);
            this.textBox_Data2.TabIndex = 3;
            // 
            // label_TextData3
            // 
            this.label_TextData3.AutoSize = true;
            this.label_TextData3.Location = new System.Drawing.Point(24, 214);
            this.label_TextData3.Name = "label_TextData3";
            this.label_TextData3.Size = new System.Drawing.Size(63, 17);
            this.label_TextData3.TabIndex = 4;
            this.label_TextData3.Text = "测试数据3";
            // 
            // textBox_Data3
            // 
            this.textBox_Data3.Location = new System.Drawing.Point(24, 234);
            this.textBox_Data3.Name = "textBox_Data3";
            this.textBox_Data3.Size = new System.Drawing.Size(236, 23);
            this.textBox_Data3.TabIndex = 5;
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(210, 429);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(98, 27);
            this.button_Update.TabIndex = 6;
            this.button_Update.Text = "更改";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // label_ShowChange
            // 
            this.label_ShowChange.AutoSize = true;
            this.label_ShowChange.Location = new System.Drawing.Point(167, 402);
            this.label_ShowChange.Name = "label_ShowChange";
            this.label_ShowChange.Size = new System.Drawing.Size(20, 17);
            this.label_ShowChange.TabIndex = 7;
            this.label_ShowChange.Text = "无";
            // 
            // Form_UpdateDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 468);
            this.Controls.Add(this.label_ShowChange);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.textBox_Data3);
            this.Controls.Add(this.label_TextData3);
            this.Controls.Add(this.textBox_Data2);
            this.Controls.Add(this.label_TextData2);
            this.Controls.Add(this.textBox_Data1);
            this.Controls.Add(this.label_TextData1);
            this.Name = "Form_UpdateDatabase";
            this.Text = "更新数据";
            this.Shown += new System.EventHandler(this.Form_UpdateDatabase_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_TextData1;
        private System.Windows.Forms.TextBox textBox_Data1;
        private System.Windows.Forms.Label label_TextData2;
        private System.Windows.Forms.TextBox textBox_Data2;
        private System.Windows.Forms.Label label_TextData3;
        private System.Windows.Forms.TextBox textBox_Data3;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Label label_ShowChange;
    }
}