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

        
        public void init1()
        {
            ShowUpdate();
            console.Text = "...";
            stk1btn.Text = "選取";
            stk2btn.Text = "選取";
            stk3btn.Text = "選取";
            stk4btn.Text = "選取";
            if (game.cantake(0)) stk1btn.Enabled = true;
            else stk1btn.Enabled = false;
            if (game.cantake(1)) stk2btn.Enabled = true;
            else stk2btn.Enabled = false;
            if (game.cantake(2)) stk3btn.Enabled = true;
            else stk3btn.Enabled = false;
            if (game.cantake(3)) stk4btn.Enabled = true;
            else stk4btn.Enabled = false;

            if (game.win())
            {
                stk1btn.Enabled = false;
                stk2btn.Enabled = false;
                stk3btn.Enabled = false;
                stk4btn.Enabled = false;
                console.Text = "你贏了";
            }
        }
        public void init2()
        {
            stk1btn.Text = "放置";
            stk2btn.Text = "放置";
            stk3btn.Text = "放置";
            stk4btn.Text = "放置";
            if (game.canplace(0)) stk1btn.Enabled = true;
            else stk1btn.Enabled = false;
            if (game.canplace(1)) stk2btn.Enabled = true;
            else stk2btn.Enabled = false;
            if (game.canplace(2)) stk3btn.Enabled = true;
            else stk3btn.Enabled = false;
            if (game.canplace(3)) stk4btn.Enabled = true;
            else stk4btn.Enabled = false;
        }
        public void ShowUpdate()
        {
            stk1.Text = game.output(0);
            stk2.Text = game.output(1);
            stk3.Text = game.output(2);
            stk4.Text = game.output(3);
        }
        private bool ok(string[] input)
        {
            int[] cnt = new int[10];
            for(int i = 0; i < 4; i++)
            {
                if (input[i].Count() > 8) return false;
                for(int j=0;j<input[i].Count(); j += 2)
                {
                    if (!Char.IsDigit(input[i][j])) return false;
                    cnt[input[i][j] - '0']++;
                }
            }
            int cnt3 = 0;
            for(int i = 0; i < 4; i++)
            {
                if (cnt[i] == 3) cnt3++;
            }
            return cnt3 == 3;
        }
        private void Start_Click(object sender, EventArgs e)
        {
            string[] input = new string[]{ stk1_Input.Text, stk2_Input.Text, stk3_Input.Text, stk4_Input.Text };
            if (ok(input))
            {
                game = new Game(input);
                Switch_Windows();
                Size = new Size(300, 400);
                init1();
            }
            else
            {
                Info.Text = "測資錯誤";
            }
        }
        
        private void home_Click(object sender, EventArgs e)
        {
            Switch_Windows();
            Size = new Size(300, 330);
            stk1_Input.Text = "1 1 2";
            stk2_Input.Text = "2 2";
            stk3_Input.Text = "";
            stk4_Input.Text = "3 3 3 1";
            Info.Text = "請輸入測資";
        }
        private void Switch_Windows()
        {
            bool Change = !Info.Visible;
            Info.Visible = Change;
            label6.Visible = Change;
            label7.Visible = Change;
            label8.Visible = Change;
            label9.Visible = Change;
            stk1_Input.Visible = Change;
            stk2_Input.Visible = Change;
            stk3_Input.Visible = Change;
            stk4_Input.Visible = Change;
            Start.Visible = Change;
            label1.Visible = !Change;
            label2.Visible = !Change;
            label3.Visible = !Change;
            label4.Visible = !Change;
            stk1.Visible = !Change;
            stk2.Visible = !Change;
            stk3.Visible = !Change;
            stk4.Visible = !Change;
            stk1btn.Visible = !Change;
            stk2btn.Visible = !Change;
            stk3btn.Visible = !Change;
            stk4btn.Visible = !Change;
            console.Visible = !Change;
            home.Visible = !Change;
        }

        private void stk1btn_Click(object sender, EventArgs e)
        {
            if (stk1btn.Text == "選取")
            {
                console.Text = "你選了堆疊1";
                game.MarkTake(0);
                init2();
            }
            else
            {
                game.MarkPlace(0);
                game.move();
                init1();
            }
        }

        private void stk2btn_Click(object sender, EventArgs e)
        {
            if (stk2btn.Text == "選取")
            {
                console.Text = "你選了堆疊2";
                game.MarkTake(1);
                init2();
            }
            else
            {
                game.MarkPlace(1);
                game.move();
                init1();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (stk3btn.Text == "選取")
            {
                console.Text = "你選了堆疊3";
                game.MarkTake(2);
                init2();
            }
            else
            {
                game.MarkPlace(2);
                game.move();
                init1();
            }
        }
        private void stk4btn_Click(object sender, EventArgs e)
        {
            if (stk4btn.Text == "選取")
            {
                console.Text = "你選了堆疊4";
                game.MarkTake(3);
                init2();
            }
            else
            {
                game.MarkPlace(3);
                game.move();
                init1();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
