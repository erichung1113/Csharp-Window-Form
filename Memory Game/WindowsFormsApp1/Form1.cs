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


        Random rand = new Random();

        int[] ans = new int[16];
        int[] cnt = new int[8];
        int mark1 = -1, mark2 = -1, rest = 16, score = 100;

        Button[] b = new Button[16];

        private int getNum()
        {
            int ans = rand.Next()%8;
            while (cnt[ans] == 0) ans = (ans + 1) % 8;
            cnt[ans]--;
            return ans;
        }

        private void UpdateScore(int Update)
        {
            score += Update;
            Score.Text = "分數 : " + score.ToString();
        }
        private void Restart_Click(object sender, EventArgs e)
        {
            score = 100;
            UpdateScore(0);
            UserName.Text = "";
            Start.Enabled = true;
            for (int i = 0; i < 16; i++)
            {
                Controls.Remove(b[i]);
                Page1.Controls.Remove(b[i]);
                b[i] = null;
            }
        }

        private void Operation()
        {
            if (mark2 == -1) return;
            b[mark1].ImageIndex = ans[mark1];
            b[mark2].ImageIndex = ans[mark2];

            if (ans[mark1] == ans[mark2])
            {
                rest -= 2;
                b[mark1].Enabled = false;
                b[mark2].Enabled = false;
                mark1 = mark2 = -1;
                UpdateScore(10);
                if (rest == 0)
                {
                    History.Text += UserName.Text + " 得分為 : " + score.ToString() + "\n\n";
                    DialogResult Result = MessageBox.Show("分數: " + score.ToString(),"遊戲結束", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    if (Result == DialogResult.Retry) Restart_Click(null,null);
                }
            }
            else
            {
                UpdateScore(-5);
                Continue.Enabled = true;
            }
            
        }
       

        private void Continue_Click(object sender, EventArgs e)
        {
            b[mark1].ImageIndex = 8;
            b[mark2].ImageIndex = 8;
            mark1 = mark2 = -1;
            Continue.Enabled = false;
        }

        private void init()
        {
            rest = 16;
            score = 100;
            for (int i = 0; i < 8; i++) cnt[i] = 2;

            for (int i = 0; i < 16; i++)
            {
                b[i] = new Button();

                b[i].SetBounds(30 + (i / 4) * 90, 60 + (i % 4) * 90, 80, 80);
                b[i].ImageList = imgCats;
                b[i].ImageIndex = 8;
                b[i].Name = i.ToString();
                b[i].Click += new EventHandler(Btn_Click);
                Controls.Add(b[i]);
                Page1.Controls.Add(b[i]);

                ans[i] = getNum();
            }
            
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (UserName.Text == "")
            {
                MessageBox.Show("名稱不能為空白", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (UserName.Text.Length < 3 || UserName.Text.Length > 10)
            {
                MessageBox.Show("名稱不合格式 ( >= 3 && <= 10)", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Start.Enabled = false;
                init();
            }
        }

        

        private void Exit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("確定要離開遊戲嗎?","離開遊戲",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
        

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int Index = Int32.Parse(btn.Name);
            if (mark1 == -1) mark1 = Index;
            else mark2 = Index;
            Operation();
        }
    }
}
