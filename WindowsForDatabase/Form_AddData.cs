using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsForDatabase
{
    public partial class Form_AddData : Form
    {
        private int MaxIndex = 3;//这是最大的索引总和数，表示现在只有3个数据，拿到题目后可增加。
        private TextBox[] textBox;//这是将散的TextBox集合起来的容器
        private string Insert_Title;//这是SQL增加数据语句的句头
        private string Insert_Values;//这是SQL增加数据语句的值句
        private string Insert_Mid;//这是SQL增加数据语句的值中间的语句
        private string Insert_Tial; //这是SQL增加数据语句的尾句
        public FormForDatabase FFD;//这是之前类的连接对象
        public SqlCommand cmd;//这是用于执行数据库的对象。
        private string Insert_Overall;//将上面的所有语句加上数据总和起来的数据。
        public Form_AddData()
        {
            InitializeComponent();
            textBox = new TextBox[MaxIndex];
            Insert_Title = "insert into Table_TextDataChange";
            Insert_Values = " values('";
            Insert_Mid = "','";
            Insert_Tial = "')";
            FFD = new FormForDatabase();
            cmd = new SqlCommand();
            cmd.Connection = FFD.conn;//这里将操作以及之前打开的数据库联系起来。
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            SaveData();
            AddDataInDatabase();
        }
        /// <summary>
        /// 将数据存储到数据库函数中。
        /// </summary>
        private void AddDataInDatabase() {
            Statements_Consolidation();
            cmd.CommandText = Insert_Overall;
            cmd.ExecuteNonQuery();//执行插入函数。
            label_ShowResult.ForeColor = Color.Green;
            label_ShowResult.Text = "录入数据成功";
        }
        /// <summary>
        /// 这是将散的textBox进行存储到textBox数组中，从而便于操作。
        /// </summary>
        private void SaveData() {
            textBox[0] = textBox_Data1;
            textBox[1] = textBox_Data2;
            textBox[2] = textBox_text;//暂时性的
        }
        /// <summary>
        /// 此方法是用来合并语句的
        /// </summary>
        private void Statements_Consolidation() {
            Insert_Overall = Insert_Title + Insert_Values;
            for (int i = 0; i < MaxIndex; i++) {
                Insert_Overall = Insert_Overall + textBox[i].Text;
                if (i < MaxIndex-1) {
                    Insert_Overall = Insert_Overall + Insert_Mid;
                }
            }
            Insert_Overall += Insert_Tial;
        }
    }
}
