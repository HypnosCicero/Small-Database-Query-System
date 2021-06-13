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
    public partial class Form_Register : Form
    {
        public FormForDatabase FFD;
        private string Insert_Title;//这是SQL增加数据语句的句头
        private string Insert_Values;//这是SQL增加数据语句的值句
        private string Insert_Mid;//这是SQL增加数据语句的值中间的语句
        private string Insert_Tial; //这是SQL增加数据语句的尾句
        private string Insert_Overall;//将上面的所有语句加上数据总和起来的数据。
        public SqlCommand cmd;//这是用于执行数据库的对象。
        public Form_Register()
        {
            InitializeComponent();
            Insert_Title = "insert into Table_User";//这里将会重写表名。
            Insert_Values = " values('";
            Insert_Mid = "','";
            Insert_Tial = "')";
            cmd = new SqlCommand();
            FFD = new FormForDatabase();
            cmd.Connection = FFD.conn;
            textBox_PassWord.PasswordChar = '*';//先将其设为*
            textBox_RePassword.PasswordChar = '*';//同上
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            Jugement();
        }

        private void checkBox_Password_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Password.Checked)
            {
                textBox_PassWord.PasswordChar = '\0';//显示输入
            }
            else {
                textBox_PassWord.PasswordChar = '*';//显示*
            }
        }

        private void checkBox_RePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_RePassword.Checked)
            {
                textBox_RePassword.PasswordChar = '\0';//显示输入
            }
            else
            {
                textBox_RePassword.PasswordChar = '*';//显示*
            }
        }
        /// <summary>
        /// 注册方法
        /// </summary>
        private void Register() {
            if (string.Compare(textBox_PassWord.ToString(), textBox_RePassword.ToString()) != 0)
            {
                //返回的是两个密码不同。
                MessageBox.Show("您输入的两个密码不相同", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Insert_Overall = Insert_Title + Insert_Values + textBox_ID.Text.ToString() + Insert_Mid + textBox_RePassword.Text.ToString() + Insert_Tial;
                cmd.CommandText = Insert_Overall;
                cmd.ExecuteNonQuery();//这是执行的方法。
                                      //这里出问题了。
                label_showReslut.ForeColor = Color.Green;//表示颜色变为绿色
                label_showReslut.Text = "已注册成功！";

            }
        }
        /// <summary>
        /// 判空
        /// </summary>
        private void Jugement() {

            if (textBox_ID.Text == "" && textBox_PassWord.Text == "" && textBox_RePassword.Text == "")
            {
                label_IDNULL.ForeColor = Color.Red;
                label_PasswordNULL.ForeColor = Color.Red;
                label_RePasswordNULL.ForeColor = Color.Red;
                label_IDNULL.Text = "账号不能为空";
                label_PasswordNULL.Text = "密码不能为空";
                label_RePasswordNULL.Text = "重输密码不能为空";
            }
            else if (textBox_ID.Text == "" && textBox_PassWord.Text == "")
            {
                label_IDNULL.ForeColor = Color.Red;
                label_PasswordNULL.ForeColor = Color.Red;
                label_IDNULL.Text = "账号不能为空";
                label_PasswordNULL.Text = "密码不能为空";
                label_RePasswordNULL.Text = "";
            }
            else if (textBox_PassWord.Text == "" && textBox_RePassword.Text == "")
            {
                label_PasswordNULL.ForeColor = Color.Red;
                label_RePasswordNULL.ForeColor = Color.Red;
                label_IDNULL.Text = "";
                label_PasswordNULL.Text = "密码不能为空";
                label_RePasswordNULL.Text = "重输密码不能为空";
            }
            else if (textBox_ID.Text == "" && textBox_RePassword.Text == "")
            {
                label_IDNULL.ForeColor = Color.Red;
                label_RePasswordNULL.ForeColor = Color.Red;
                label_IDNULL.Text = "账号不能为空";
                label_PasswordNULL.Text = "";
                label_RePasswordNULL.Text = "重输密码不能为空";
            }
            else if (textBox_ID.Text == "")
            {
                label_IDNULL.ForeColor = Color.Red;
                label_IDNULL.Text = "账号不能为空";
                label_PasswordNULL.Text = "";
                label_RePasswordNULL.Text = "";
            }
            else if (textBox_PassWord.Text == "")
            {
                label_PasswordNULL.ForeColor = Color.Red;
                label_IDNULL.Text = "";
                label_PasswordNULL.Text = "密码不能为空";
                label_RePasswordNULL.Text = "";
            }
            else if (textBox_RePassword.Text == "")
            {
                label_RePasswordNULL.ForeColor = Color.Red;
                label_IDNULL.Text = "";
                label_PasswordNULL.Text = "";
                label_RePasswordNULL.Text = "重输密码不能为空";
            }
            else
            {
                label_IDNULL.Text = "";
                label_PasswordNULL.Text = "";
                label_RePasswordNULL.Text = "";
                Register();
            }
        }
    }
}
