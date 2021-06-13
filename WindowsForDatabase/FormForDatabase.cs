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
    public partial class FormForDatabase : Form
    {
        public string connStr;
        public SqlConnection conn;
        public SqlCommand commd;
        public FormForDatabase()
        {
            InitializeComponent();
            connStr = "SERVER=DESKTOP-A9QRII5\\SQLEXPRESS;DATABASE=Text_CsFormForDatabase;Integrated Security=SSPI";
            //Windows用户登录。
            BindDatabase();
            ConnectionDatabase();
        }

        private void buttonOfJoinSystem_Click(object sender, EventArgs e)
        {
            JumpAndCloseForm();
        }
        public void BindDatabase() {
            conn = new SqlConnection(connStr);//绑定相应的数据库
        }
        private void JumpAndCloseForm()
        {
            Form_Login form_Login = new Form_Login();//申请一个窗口类，生成相应的窗口。
            this.Hide();//只能隐藏当前窗口
            form_Login.ShowDialog();//显示相应窗口

            //一下语句在连接数据库时解锁。
            CloseDatabase();//这里时关闭数据库连接
            this.Close();//指关闭前面的窗口则不在显示这个窗口而是全部关闭
        }
        private void ConnectionDatabase() {
            conn.Open();//真正的与数据库连接
        }
        private void CloseDatabase() {
            conn.Close();//关闭数据库的连接
        }
    }
}
