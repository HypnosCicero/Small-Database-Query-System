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
    public partial class Form_Login : Form
    {
        public string ID;//这是在数据库查找的ID字符串
        public string PassWord;//这是在数据库中查找的密码字符串
        private string SelectSecn;//查询语句的总语句。
        public FormForDatabase FFD;//引用之前的ffd作为变量。
        public SqlCommand cmd;//执行sql的类
        public SqlDataReader reader;
        public Form_Login()
        {
            InitializeComponent();
            FFD = new FormForDatabase();//用于使用前面的连接操作。
            cmd = new SqlCommand();
            cmd.Connection = FFD.conn;//将前面的连接操作的。
            textBox_PassWord.PasswordChar = '*';//显示*
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            //直接调用判断函数，从而往下进行调用。
            if (textBox_ID.Text == "" && textBox_PassWord.Text == "") {
                label_IDNULL.ForeColor = Color.Red;
                label_PasswordNULL.ForeColor = Color.Red;
                label_IDNULL.Text = "账号不能为空";
                label_PasswordNULL.Text = "密码不能为空";
            }
            else if (textBox_ID.Text == ""){
                label_IDNULL.ForeColor = Color.Red;
                label_IDNULL.Text = "账号不能为空";
                label_PasswordNULL.Text = "";
            }else if (textBox_PassWord.Text == "")
            {
                label_PasswordNULL.ForeColor = Color.Red;
                label_PasswordNULL.Text = "密码不能为空";
                label_IDNULL.Text = "";
            }else{
                label_IDNULL.Text = "";
                label_PasswordNULL.Text = "";
                Compairing();
            }
        }
        
        /// <summary>
        /// 对比函数
        /// </summary>
        private void Compairing() {
            ID = textBox_ID.Text;
            PassWord = textBox_PassWord.Text;
            SelectSecn = "select * from Table_User where ID=" + ID;
            cmd.CommandText = SelectSecn;//用之前存储的查询语句放在这个属性里面。

            SqlDataReader dataReader =cmd.ExecuteReader();//未初始化连接属性
            if (!dataReader.Read())
            {
                ShowTipRegister();//调用注册提前的窗口。
            }
            else {
                if (string.Compare(dataReader.GetString(1).Trim(' '), PassWord.ToString()) == 0)//这里需要Trim方法进行空格控制。
                {
                    InTheSystem();//密码正确并进入系统。
                }
                else {
                    //弹出警告窗口，但是里面的代码不对。
                    MessageBox.Show("您输入的密码有误", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            dataReader.Close();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            //新建立一个窗口进行数据的输入以及输出
            InRegister();
        }
        /// <summary>
        /// 用来显示注册提示窗口
        /// </summary>
        private void ShowTipRegister()
        {
            Form_TipRegister form_tipRegister = new Form_TipRegister();
            this.Hide();
            form_tipRegister.ShowDialog();
            //这两句的意思是将关闭页面你输入的账号和密码将不再显示再textbox上面。
            textBox_ID.Text = "";
            textBox_PassWord.Text = "";
            //再进行显示
            this.Show();
        }
        /// <summary>
        /// 进入总系统的方法
        /// </summary>
        private void InTheSystem()
        {
            Form_SystemIn form_SystemIn = new Form_SystemIn();
            this.Hide();
            form_SystemIn.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// 进入注册页面的方法
        /// </summary>
        private void InRegister() {
            Form_Register form_Register = new Form_Register();
            this.Hide();
            form_Register.ShowDialog();
            //这两句的意思是将关闭页面你输入的账号和密码将不再显示再textbox上面。
            textBox_ID.Text = "";
            textBox_PassWord.Text = "";
            label_IDNULL.Text = "";
            label_PasswordNULL.Text = "";
            //在进行显示
            this.Show();
        }

        private void checkBox_PassWord_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_PassWord.Checked)
            {
                textBox_PassWord.PasswordChar = '\0';//显示输入
            }
            else {
                textBox_PassWord.PasswordChar = '*';//显示*
            }
        }

    }
}
