using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button[] Btn = new Button[26];
        String ans = "";
        int TimeCnt = 0, comp = 0, FalseCnt = 0;

        private void Win()
        {
            timer.Enabled = false;
            MessageBox.Show("花費時間 : " + TimeCnt.ToString() + "\n猜錯 " + FalseCnt.ToString() + " 次", "You Win!");
            Switch_Windows();
        }
        private void Lose()
        {
            timer.Enabled = false;
            Word.Text = ans;
            MessageBox.Show("You Lose!");
            Switch_Windows();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            for (int i = 0; i < 26; i++)
            {
                Button btn = new Button();
                if (i <= 19) btn.SetBounds(150 + (i % 10) * 56, 60 + (i / 10) * 56, 55, 55);
                else btn.SetBounds(150 + (i % 10 + 2) * 56, 60 + (i / 10) * 56, 55, 55);
                btn.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Bold);
                btn.Text = (Convert.ToChar(65 + i)).ToString();
                btn.Visible = false;
                Controls.Add(btn);
                Btn[i] = btn;
            }
        }


        private void Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.ToUpper(e.KeyChar) < 'A' || 'Z' < Char.ToUpper(e.KeyChar))
            {
                if (e.KeyChar == (Char)Keys.Back) return;
                e.Handled = true;
            }
        }

        private void Switch_Windows()
        {

            foreach (var i in Controls)
            {
                string T = i.GetType().ToString().Substring(21);
                if (T == "Button")
                {
                    Button Obj = (Button)i;
                    if (TimeCnt != 0 && Obj.Name != "Start") Obj.Visible = false;
                    else Obj.Visible = !Obj.Visible;
                    Obj.BackColor = Color.White;
                }
                else if (T == "Label")
                {
                    Label Obj = (Label)i;
                    Obj.Visible = !Obj.Visible;
                }
                else
                {
                    TextBox Obj = (TextBox)i;
                    Obj.Visible = !Obj.Visible;
                }
            }
        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = Char.ToUpper(Convert.ToChar(e.KeyChar));
            bool Find = false;

            StringBuilder update = new StringBuilder(Word.Text);
            for (int i = 0; i < ans.Length; i++)
            {
                if (ans[i] == key)
                {
                    if (update[i * 2] != '_') return;
                    Find = true;
                    update[i * 2] = e.KeyChar;
                    comp++;
                }
            }

            if (Find)
            {
                Word.Text = update.ToString();
                Btn[key - 'A'].BackColor = Color.LightGreen;
            }
            else
            {
                Btn[key - 'A'].Visible = false;
                FalseCnt++;
                Falselab.Text = "猜錯次數 : " + FalseCnt.ToString() + "次";
            }

            if (comp == ans.Length)
            {
                Win();
            }
            else if (FalseCnt >= 6)
            {
                Lose();
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {

            TimeCnt = 0; comp = 0; FalseCnt = 0;

            Timelab.Text = "時間 : 0";
            Falselab.Text = "猜錯次數 : 0";

            Switch_Windows();

            string UpperCase_Input = "";
            for (int i = 0; i < Input.Text.Length; i++)
            {
                UpperCase_Input += Char.ToUpper(Input.Text[i]).ToString();
            }
            ans = UpperCase_Input;

            Word.Text = "";
            for (int i = 0; i < Input.Text.Length * 2; i++)
            {
                if (i % 2 == 0)
                {
                    Word.Text += '_';
                }
                else
                {
                    Word.Text += ' ';
                }
            }
            timer.Enabled = true;
            Focus();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeCnt++;
            Timelab.Text = "時間 : " + TimeCnt.ToString();
        }
    }
}
