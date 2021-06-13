
namespace WindowsForDatabase
{
    partial class Form_AddData
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
            this.label_AddData1 = new System.Windows.Forms.Label();
            this.textBox_Data1 = new System.Windows.Forms.TextBox();
            this.label_AddData2 = new System.Windows.Forms.Label();
            this.textBox_Data2 = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.textBox_text = new System.Windows.Forms.TextBox();
            this.label_ShowResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_AddData1
            // 
            this.label_AddData1.AutoSize = true;
            this.label_AddData1.Location = new System.Drawing.Point(40, 13);
            this.label_AddData1.Name = "label_AddData1";
            this.label_AddData1.Size = new System.Drawing.Size(75, 17);
            this.label_AddData1.TabIndex = 0;
            this.label_AddData1.Text = "请添加数据1";
            // 
            // textBox_Data1
            // 
            this.textBox_Data1.Location = new System.Drawing.Point(40, 33);
            this.textBox_Data1.Name = "textBox_Data1";
            this.textBox_Data1.Size = new System.Drawing.Size(163, 23);
            this.textBox_Data1.TabIndex = 1;
            // 
            // label_AddData2
            // 
            this.label_AddData2.AutoSize = true;
            this.label_AddData2.Location = new System.Drawing.Point(40, 79);
            this.label_AddData2.Name = "label_AddData2";
            this.label_AddData2.Size = new System.Drawing.Size(75, 17);
            this.label_AddData2.TabIndex = 2;
            this.label_AddData2.Text = "请添加数据2";
            // 
            // textBox_Data2
            // 
            this.textBox_Data2.Location = new System.Drawing.Point(40, 99);
            this.textBox_Data2.Name = "textBox_Data2";
            this.textBox_Data2.Size = new System.Drawing.Size(163, 23);
            this.textBox_Data2.TabIndex = 3;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(229, 391);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(125, 47);
            this.button_Add.TabIndex = 4;
            this.button_Add.Text = "录入系统";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // textBox_text
            // 
            this.textBox_text.Location = new System.Drawing.Point(40, 156);
            this.textBox_text.Name = "textBox_text";
            this.textBox_text.Size = new System.Drawing.Size(189, 23);
            this.textBox_text.TabIndex = 5;
            // 
            // label_ShowResult
            // 
            this.label_ShowResult.AutoSize = true;
            this.label_ShowResult.Location = new System.Drawing.Point(41, 319);
            this.label_ShowResult.Name = "label_ShowResult";
            this.label_ShowResult.Size = new System.Drawing.Size(20, 17);
            this.label_ShowResult.TabIndex = 6;
            this.label_ShowResult.Text = "无";
            // 
            // Form_AddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 450);
            this.Controls.Add(this.label_ShowResult);
            this.Controls.Add(this.textBox_text);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textBox_Data2);
            this.Controls.Add(this.label_AddData2);
            this.Controls.Add(this.textBox_Data1);
            this.Controls.Add(this.label_AddData1);
            this.Name = "Form_AddData";
            this.Text = "添加数据";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_AddData1;
        private System.Windows.Forms.TextBox textBox_Data1;
        private System.Windows.Forms.Label label_AddData2;
        private System.Windows.Forms.TextBox textBox_Data2;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textBox_text;
        private System.Windows.Forms.Label label_ShowResult;
    }
}