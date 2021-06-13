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
    public partial class Form_UpdateDatabase : Form
    {
        private string UpDateSelction_ALL;
        public FormForDatabase FFD;//这是之前类的连接对象
        public SqlCommand cmd;//这是用于执行数据库的对象。
        private string id;//用于存储转换过来的主键数据，
        private string SelectSelction;//用于查询数据的
        public Form_UpdateDatabase(string firstData)
        {
            InitializeComponent();
            FFD = new FormForDatabase();
            cmd = new SqlCommand();
            cmd.Connection = FFD.conn;
            id = firstData;//用于存储第一个数据也就是主键。
            UpDateSelction_ALL = "";//为空
            SelectSelction = "select TextData1,TextData2,TextData3 from Table_TextDataChange where TextData1=" + id;
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            //这里差一个合并语句。
            Statements_Consolidation();
            //这两句是用来执行的。
            cmd.CommandText = UpDateSelction_ALL;
            cmd.ExecuteNonQuery();
            label_ShowChange.ForeColor = Color.Green;
            label_ShowChange.Text = "已经更改数据";
        }
        /// <summary>
        /// 页面显示的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_UpdateDatabase_Shown(object sender, EventArgs e)
        {
            cmd.CommandText = SelectSelction; 
            SqlDataReader DataReader = cmd.ExecuteReader();
            while (DataReader.Read()) { 
                textBox_Data1.Text= DataReader[0].ToString();//这里通过更改相应的属性导致这里不能更改
                textBox_Data2.Text = DataReader[1].ToString();
                textBox_Data3.Text = DataReader[2].ToString();
            }
            DataReader.Close();
        }
        /// <summary>
        /// 用来合并更改语句。
        /// </summary>
        /// update 表名 set 第一个数据名 = '数据1', 第二个数据名 = 数据2 where 主键名 = 根据点进来的数据所填入
        private void Statements_Consolidation() {
            string ST = "update Table_TextDataChange set ";
            string S2 = "TextData2='" + textBox_Data2.Text.ToString()+"'";
            string S3 = "TextData3='" + textBox_Data3.Text.ToString()+"'";
            string STil = " where TextData1=" + id;
            UpDateSelction_ALL+= ST + S2 + "," + S3 + STil;//逗号作为每个数字之间的分隔后面会更改
        }
    }
}
