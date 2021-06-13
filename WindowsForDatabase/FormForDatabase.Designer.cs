
namespace WindowsForDatabase
{
    partial class FormForDatabase
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
            this.buttonOfJoinSystem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.label_introduce = new System.Windows.Forms.Label();
            this.label_name1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOfJoinSystem
            // 
            this.buttonOfJoinSystem.Location = new System.Drawing.Point(98, 224);
            this.buttonOfJoinSystem.Name = "buttonOfJoinSystem";
            this.buttonOfJoinSystem.Size = new System.Drawing.Size(100, 35);
            this.buttonOfJoinSystem.TabIndex = 0;
            this.buttonOfJoinSystem.Text = "进入此系统";
            this.buttonOfJoinSystem.UseVisualStyleBackColor = true;
            this.buttonOfJoinSystem.Click += new System.EventHandler(this.buttonOfJoinSystem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-131, -11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(80, 71);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(140, 17);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "欢迎来到数据库管理系统";
            // 
            // label_introduce
            // 
            this.label_introduce.AutoSize = true;
            this.label_introduce.Location = new System.Drawing.Point(80, 118);
            this.label_introduce.Name = "label_introduce";
            this.label_introduce.Size = new System.Drawing.Size(128, 17);
            this.label_introduce.TabIndex = 3;
            this.label_introduce.Text = "该程序由以下人员制作";
            // 
            // label_name1
            // 
            this.label_name1.AutoSize = true;
            this.label_name1.Location = new System.Drawing.Point(80, 156);
            this.label_name1.Name = "label_name1";
            this.label_name1.Size = new System.Drawing.Size(44, 17);
            this.label_name1.TabIndex = 4;
            this.label_name1.Text = "秦浩健";
            // 
            // FormForDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(311, 320);
            this.Controls.Add(this.label_name1);
            this.Controls.Add(this.label_introduce);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOfJoinSystem);
            this.Name = "FormForDatabase";
            this.Text = "数据库查询系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOfJoinSystem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_introduce;
        private System.Windows.Forms.Label label_name1;
    }
}

