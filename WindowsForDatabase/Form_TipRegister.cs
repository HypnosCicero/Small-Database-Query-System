using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForDatabase
{
    public partial class Form_TipRegister : Form
    {
        public Form_TipRegister()
        {
            InitializeComponent();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            InRegister();//进入注册页面。
        }
        /// <summary>
        /// 进入住粗页面的方法
        /// </summary>
        private void InRegister() {
            Form_Register form_register = new Form_Register();
            this.Hide();
            form_register.ShowDialog();
            this.Close();
        }
    }
}
