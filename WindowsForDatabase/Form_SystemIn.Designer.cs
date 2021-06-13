
namespace WindowsForDatabase
{
    partial class Form_SystemIn
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
            this.groupBox_Controller = new System.Windows.Forms.GroupBox();
            this.button_FuzzyDelete = new System.Windows.Forms.Button();
            this.button_FuzzySelect = new System.Windows.Forms.Button();
            this.label_FuzzySelectData2 = new System.Windows.Forms.Label();
            this.textBox_FuzzyOpreationData2 = new System.Windows.Forms.TextBox();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_deleteAllData = new System.Windows.Forms.Button();
            this.button_AddData = new System.Windows.Forms.Button();
            this.listView_Show = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.groupBox_Select = new System.Windows.Forms.GroupBox();
            this.groupBox_Controller.SuspendLayout();
            this.groupBox_Select.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Controller
            // 
            this.groupBox_Controller.Controls.Add(this.button_FuzzyDelete);
            this.groupBox_Controller.Controls.Add(this.button_FuzzySelect);
            this.groupBox_Controller.Controls.Add(this.label_FuzzySelectData2);
            this.groupBox_Controller.Controls.Add(this.textBox_FuzzyOpreationData2);
            this.groupBox_Controller.Controls.Add(this.button_Refresh);
            this.groupBox_Controller.Controls.Add(this.button_deleteAllData);
            this.groupBox_Controller.Controls.Add(this.button_AddData);
            this.groupBox_Controller.Location = new System.Drawing.Point(1151, 7);
            this.groupBox_Controller.Name = "groupBox_Controller";
            this.groupBox_Controller.Size = new System.Drawing.Size(243, 617);
            this.groupBox_Controller.TabIndex = 0;
            this.groupBox_Controller.TabStop = false;
            this.groupBox_Controller.Text = "操作界面";
            // 
            // button_FuzzyDelete
            // 
            this.button_FuzzyDelete.Location = new System.Drawing.Point(56, 312);
            this.button_FuzzyDelete.Name = "button_FuzzyDelete";
            this.button_FuzzyDelete.Size = new System.Drawing.Size(161, 41);
            this.button_FuzzyDelete.TabIndex = 6;
            this.button_FuzzyDelete.Text = "删除";
            this.button_FuzzyDelete.UseVisualStyleBackColor = true;
            this.button_FuzzyDelete.Click += new System.EventHandler(this.button_FuzzyDelete_Click);
            // 
            // button_FuzzySelect
            // 
            this.button_FuzzySelect.Location = new System.Drawing.Point(54, 254);
            this.button_FuzzySelect.Name = "button_FuzzySelect";
            this.button_FuzzySelect.Size = new System.Drawing.Size(164, 38);
            this.button_FuzzySelect.TabIndex = 5;
            this.button_FuzzySelect.Text = "查询";
            this.button_FuzzySelect.UseVisualStyleBackColor = true;
            this.button_FuzzySelect.Click += new System.EventHandler(this.button_FuzzySelect_Click);
            // 
            // label_FuzzySelectData2
            // 
            this.label_FuzzySelectData2.AutoSize = true;
            this.label_FuzzySelectData2.Location = new System.Drawing.Point(52, 38);
            this.label_FuzzySelectData2.Name = "label_FuzzySelectData2";
            this.label_FuzzySelectData2.Size = new System.Drawing.Size(39, 17);
            this.label_FuzzySelectData2.TabIndex = 4;
            this.label_FuzzySelectData2.Text = "数据1";
            // 
            // textBox_FuzzyOpreationData2
            // 
            this.textBox_FuzzyOpreationData2.Location = new System.Drawing.Point(52, 58);
            this.textBox_FuzzyOpreationData2.Name = "textBox_FuzzyOpreationData2";
            this.textBox_FuzzyOpreationData2.Size = new System.Drawing.Size(166, 23);
            this.textBox_FuzzyOpreationData2.TabIndex = 3;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(52, 464);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(166, 38);
            this.button_Refresh.TabIndex = 2;
            this.button_Refresh.Text = "刷新查询界面";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // button_deleteAllData
            // 
            this.button_deleteAllData.Location = new System.Drawing.Point(52, 420);
            this.button_deleteAllData.Name = "button_deleteAllData";
            this.button_deleteAllData.Size = new System.Drawing.Size(166, 38);
            this.button_deleteAllData.TabIndex = 1;
            this.button_deleteAllData.Text = "删除所有数据";
            this.button_deleteAllData.UseVisualStyleBackColor = true;
            this.button_deleteAllData.Click += new System.EventHandler(this.button_deleteAllData_Click);
            // 
            // button_AddData
            // 
            this.button_AddData.Location = new System.Drawing.Point(52, 376);
            this.button_AddData.Name = "button_AddData";
            this.button_AddData.Size = new System.Drawing.Size(166, 38);
            this.button_AddData.TabIndex = 0;
            this.button_AddData.Text = "添加新数据";
            this.button_AddData.UseVisualStyleBackColor = true;
            this.button_AddData.Click += new System.EventHandler(this.button_AddData_Click);
            // 
            // listView_Show
            // 
            this.listView_Show.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView_Show.HideSelection = false;
            this.listView_Show.Location = new System.Drawing.Point(6, 16);
            this.listView_Show.Name = "listView_Show";
            this.listView_Show.Size = new System.Drawing.Size(1133, 576);
            this.listView_Show.TabIndex = 1;
            this.listView_Show.UseCompatibleStateImageBehavior = false;
            this.listView_Show.View = System.Windows.Forms.View.Details;
            this.listView_Show.SelectedIndexChanged += new System.EventHandler(this.listView_Show_SelectedIndexChanged);
            // 
            // groupBox_Select
            // 
            this.groupBox_Select.Controls.Add(this.listView_Show);
            this.groupBox_Select.Location = new System.Drawing.Point(12, 7);
            this.groupBox_Select.Name = "groupBox_Select";
            this.groupBox_Select.Size = new System.Drawing.Size(1133, 598);
            this.groupBox_Select.TabIndex = 2;
            this.groupBox_Select.TabStop = false;
            this.groupBox_Select.Text = "查询页面";
            // 
            // Form_SystemIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 624);
            this.Controls.Add(this.groupBox_Select);
            this.Controls.Add(this.groupBox_Controller);
            this.Name = "Form_SystemIn";
            this.Text = "数据库查询系统";
            this.Shown += new System.EventHandler(this.Form_SystemIn_Shown);
            this.groupBox_Controller.ResumeLayout(false);
            this.groupBox_Controller.PerformLayout();
            this.groupBox_Select.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Controller;
        private System.Windows.Forms.Button button_AddData;
        private System.Windows.Forms.ListView listView_Show;
        private System.Windows.Forms.Button button_deleteAllData;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.GroupBox groupBox_Select;
        private System.Windows.Forms.Button button_FuzzySelect;
        private System.Windows.Forms.Label label_FuzzySelectData2;
        private System.Windows.Forms.TextBox textBox_FuzzyOpreationData2;
        private System.Windows.Forms.Button button_FuzzyDelete;
    }
}