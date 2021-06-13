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
    public partial class Form_SystemIn : Form
    {
        public FormForDatabase FFD;
        public SqlCommand cmd;
        //public SqlDataReader reader;
        private string SelectAllSentence;
        private string DeleteAllSentence;
        private TextBox[] fuzzyOprationTB;//模糊查询的textbox
        private int MaxNumber_TB;//模糊查询的最大值
        private Dictionary<int, string> map_int2string;//这是一个数字对字符串的一种映射。
        private Dictionary<int, string> map_FuzzySentence;//模糊查询句子的哈希值。
        public Form_SystemIn()
        {
            InitializeComponent();
            FFD = new FormForDatabase();
            cmd = new SqlCommand();
            cmd.Connection = FFD.conn;
            SelectAllSentence = "select * from Table_TextDataChange";
            DeleteAllSentence = "delete from Table_TextDataChange";
            SelectAllData();//在一开始的时候就应该调用它
            MaxNumber_TB = 1;
            fuzzyOprationTB = new TextBox[MaxNumber_TB];//用以进行后续的模糊查询
            map_int2string = new Dictionary<int, string>();
            map_FuzzySentence = new Dictionary<int, string>();
            Start_FuzzySentence();
        }
        /// <summary>
        /// 初始化map_FuzzySentence;
        /// </summary>
        private void Start_FuzzySentence() {
            map_FuzzySentence[1] = "";//1表示查找状态
            map_FuzzySentence[2] = "";//2表示删除状态
        }
        private void button_AddData_Click(object sender, EventArgs e)
        {
            JumpForm_AddData_AndHideForm();
        }
        private void JumpForm_AddData_AndHideForm()
        {
            Form_AddData form_addData= new Form_AddData();//申请一个窗口类，生成添加数据的窗口。
            form_addData.ShowDialog();//显示添加数据的窗口
        }

        private void button_deleteAllData_Click(object sender, EventArgs e)
        {
            cmd.CommandText = DeleteAllSentence;
            cmd.ExecuteNonQuery();
        }
        /// <summary>
        /// 这是查找全部数据的方法
        /// </summary>
        private void SelectAllData()
        {
            listView_Show.Clear();//清空框架
            listView_Show.Columns.Add("第一数据");
            listView_Show.Columns.Add("第二数据");
            listView_Show.Columns.Add("第三数据");
            cmd.CommandText = SelectAllSentence;
            SqlDataReader DataReader = cmd.ExecuteReader();
            while (DataReader.Read())
            {
                string textData1 = DataReader[0].ToString();
                string textData2 = DataReader[1].ToString();
                string textData3 = DataReader[2].ToString();

                ListViewItem item = new ListViewItem(textData1);
                //先创造一个listviewitem类的item，初始化添加第一个数据的字符串
                item.SubItems.Add(textData2);
                //然后再添加一列的属性。
                item.SubItems.Add(textData3);

                listView_Show.Items.Add(item);
                //最后再将这些属性加入到原本的listview中
            }
            DataReader.Close();
        }

        /// <summary>
        /// 跳转到更新数据的页面上。
        /// </summary>
        private void JumpUpdateDatabaseForm(string firstData) {
            Form_UpdateDatabase form_UpdateDatabase = new Form_UpdateDatabase(firstData);
            form_UpdateDatabase.ShowDialog();
        }

        private void listView_Show_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Show.SelectedItems.Count == 1)
            {
                string firstData=listView_Show.SelectedItems[0].SubItems[0].Text;//这里的数据到时候会改
                JumpUpdateDatabaseForm(firstData);
            }
        }
        /// <summary>
        /// 刷新的函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Refresh_Click(object sender, EventArgs e)
        {
            SelectAllData();//估计要重做刷新函数
        }

        private void Form_SystemIn_Shown(object sender, EventArgs e)
        {
            SelectAllData();//在一开始的时候就应该调用它
        }

        private void button_FuzzySelect_Click(object sender, EventArgs e)
        {
            //此方法为模糊操作
            map_int2string.Clear();//清空字典内的值。更加灵活。
            string s_s = "select * from Table_TextDataChange";
            CombineSentence(s_s, 1);//查询是1状态。
            listView_Show.Clear();//清空框架
            listView_Show.Columns.Add("第一数据");
            listView_Show.Columns.Add("第二数据");
            listView_Show.Columns.Add("第三数据");
            //cmd.CommandText = FuzzySelectSentence;//模糊语句 可删除
            cmd.CommandText = map_FuzzySentence[1];//模糊语句 1为查询 2为删除.
            SqlDataReader DataReader = cmd.ExecuteReader();
            while (DataReader.Read())
            {
                string textData1 = DataReader[0].ToString();
                string textData2 = DataReader[1].ToString();
                string textData3 = DataReader[2].ToString();

                ListViewItem item = new ListViewItem(textData1);
                //先创造一个listviewitem类的item，初始化添加第一个数据的字符串
                item.SubItems.Add(textData2);
                //然后再添加一列的属性。
                item.SubItems.Add(textData3);

                listView_Show.Items.Add(item);
                //最后再将这些属性加入到原本的listview中
            }
            DataReader.Close();
            map_FuzzySentence[1] = "";//完成任务后 需初始化语句
        }
        /// <summary>
        /// 合并模糊操作的textbox
        /// </summary>
        private void CombineTextBox() {
            fuzzyOprationTB[0] = textBox_FuzzyOpreationData2;
        }
        /// <summary>
        /// 判空方法
        /// </summary>
        /// <param name="textboxs">要传递的参数</param>
        /// <returns>累加有多少不为空的</returns>
        private int FindEmpty(TextBox[] textboxs) {
            int result =0;
            for (int i = 0; i < MaxNumber_TB; i++) {
                if (textboxs[i].Text != "") {
                    result++;//累加有多少不为空的
                }
            }
            return result;
        }
        /// <summary>
        /// 用于添加映射的方法
        /// </summary>
        private void AddMapValue() {
            map_int2string.Add(0, "TextData1");
        }

        private void button_FuzzyDelete_Click(object sender, EventArgs e)
        {
            map_int2string.Clear();//清空字典内的值。更加灵活。
            string s_d = "delete from Table_TextDataChange";
            CombineSentence(s_d, 2);//删除是2状态。
            cmd.CommandText = map_FuzzySentence[2];
            cmd.ExecuteNonQuery();
            map_FuzzySentence[2] = "";//完成任务后需初始化数据。
        }
        private void CombineSentence(string s,int state) {
            CombineTextBox();
            // where 列名称=值
            map_FuzzySentence[state] += s;
            int count = FindEmpty(fuzzyOprationTB);
            if (count > 0)
            {
                AddMapValue();
                map_FuzzySentence[state] += " where ";
                for (int i = 0; i < MaxNumber_TB; i++)
                {
                    if (fuzzyOprationTB[i].Text != "")
                    {
                        map_FuzzySentence[state] += map_int2string[i] + " =" + fuzzyOprationTB[i].Text.ToString();
                        count--;
                    }
                    if (count > 0)
                    {
                        map_FuzzySentence[state] += " and ";
                    }
                }
            }
        }
    }
}
