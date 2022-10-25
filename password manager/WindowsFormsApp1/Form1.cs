using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Result.Text = Accounts.FindSamePassword();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Accounts.Add("abc", "abc", "abc");
        }
        

        private void Result_Click(object sender, EventArgs e)
        {
            
        }

        private void Search_butten_Click(object sender, EventArgs e)
        {
            Result.Text = Accounts.Search(Input_bar.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool Change = label2.Visible;
            label2.Visible = !Change;
            label3.Visible = !Change;
            Search_butten.Enabled = !Change;
            Input_bar.Enabled = !Change;
            Risk_button.Enabled = !Change;
            Result.Visible = !Change;
            lblLink.Visible = Change;
            lblUser.Visible = Change;
            lblPassword.Visible = Change;
            Input_link.Visible = Change;
            Input_user.Visible = Change;
            Input_password.Visible = Change;
            Status_Column.Visible = Change;
            Insert.Visible = Change;
            Delete.Visible = Change;
            if (Change) ins_del_button.Text = "回主畫面";
            else ins_del_button.Text = "新增或刪除";
        }
        
        

        private void Insert_Click(object sender, EventArgs e)
        {
            string link = Input_link.Text;
            string user = Input_user.Text;
            string password = Input_password.Text;
            if (Accounts.Add(link, user, password))
            {
                Status_Column.Text = "新增完成";
                Input_link.Text = "";
                Input_user.Text = "";
                Input_password.Text = "";
            }
            else Status_Column.Text = "帳號已存在";

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string link = Input_link.Text;
            string user = Input_user.Text;
            string password = Input_password.Text;
            
            if (Accounts.Del(link, user, password))
            {
                Status_Column.Text = "刪除完成";
                Input_link.Text = "";
                Input_user.Text = "";
                Input_password.Text = "";

            }
            else Status_Column.Text = "帳號不存在或密碼錯誤";

        }
    }
}
