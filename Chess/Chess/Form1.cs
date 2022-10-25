using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Button[] Btn = new Button[42];
        Button press;
        
        const int T = 10;
        int TimeCnt = T, status = 0, index = 0, P1rest = 3, P2rest = 3;
        bool[] P1alive = new bool[] { true, true, true };
        bool[] P2alive = new bool[] { true, true, true };

        bool done1 = false;

        private void Switch_Windows()
        {
            foreach(var i in Controls)
            {
                string T = i.GetType().ToString().Substring(21);
                if (T == "Button")
                {
                    Button Obj = (Button)i;


                    if (Obj.Name.ToString().Length < 6)
                    {
                        Obj.Visible = !Obj.Visible;
                    }
                    else
                    {
                        int idx = Convert.ToInt32(Obj.Name.ToString().Substring(6));
                        if (7 <= idx && idx <= 16) continue;
                        Obj.Visible = !Obj.Visible;
                    }
                }
                else if (T == "Label")
                {
                    Label Obj = (Label)i;
                    Obj.Visible = !Obj.Visible;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 42; i++)
            {
                Button btn = new Button();
                btn.SetBounds(250 + (i % 6) * 50, 150 + (i / 6) * 50, 50, 50);
                btn.Font = new System.Drawing.Font("新細明體", 8F, System.Drawing.FontStyle.Regular);
                btn.Click += btn_Click;
                btn.Name = i.ToString();
                Controls.Add(btn);
                Btn[i] = btn;
            }
            foreach (var i in Controls)
            {
                string T = i.GetType().ToString().Substring(21);
                if (T == "Button")
                {
                    Button Obj = (Button)i;
                    Obj.Visible = false;
                }
                else if (T == "Label")
                {
                    Label Obj = (Label)i;
                    Obj.Visible = false;
                }
            }
            Start.Visible = true;

            timer1.Interval = 1000; 
        }

        private void init()
        {
            Switch_Windows();
            timer1.Enabled = true;

            for (int i = 0; i < 7; i++)
            {
                for (int j = 3; j < 6; j++)
                {
                    Btn[i * 6 + j].Enabled = false;
                }
            }
            
        }
        private void Start_Click(object sender, EventArgs e)
        {
            init();
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
            if (TimeCnt == 0)
            {
                if (done1)
                {
                    if (button6.Enabled == true)
                    {
                        for (int i = 5; i < 42; i += 6)
                        {
                            if (Btn[i].Enabled == true)
                            {
                                Btn[i].BackColor = Color.LightPink;
                                Btn[i].Text = button1.Text.Substring(0, 2);
                                Btn[i].Enabled = false;
                                button6.Text = button6.Text.Substring(0, 2) + " : 0顆";
                                break;
                            }
                        }
                        button6.Enabled = false;
                    }
                    if (button5.Enabled == true)
                    {
                        for (int i = 5; i < 42; i += 6)
                        {
                            if (Btn[i].Enabled == true)
                            {
                                Btn[i].BackColor = Color.LightPink;
                                Btn[i].Text = button5.Text.Substring(0, 2);
                                Btn[i].Enabled = false;
                                button5.Text = button5.Text.Substring(0, 2) + " : 0顆";
                                break;
                            }
                        }
                        button5.Enabled = false;
                    }
                    if (button4.Enabled == true)
                    {
                        for (int i = 5; i < 42; i += 6)
                        {
                            if (Btn[i].Enabled == true)
                            {
                                Btn[i].BackColor = Color.LightPink;
                                Btn[i].Text = button3.Text.Substring(0, 2);
                                Btn[i].Enabled = false;
                                button4.Text = button4.Text.Substring(0, 2) + " : 0顆";
                                break;
                            }
                        }
                        button4.Enabled = false;
                    }

                    button1.Visible = false; button2.Visible = false; button3.Visible = false;
                    button4.Visible = false; button5.Visible = false; button6.Visible = false;

                    button7.Visible = true; button8.Visible = true; button9.Visible = true; button10.Visible = true; button11.Visible = true;
                    button12.Visible = true; button13.Visible = true; button14.Visible = true; button15.Visible = true; button16.Visible = true;
                    
                    for (int i = 0; i < 42; i++) Btn[i].Enabled = true;


                    Info.Text = "P1 Turn";
                    RestTime.Text = "";
                    button11.Enabled = false;
                    timer1.Enabled = false;

                    start_ATK();
                    
                }
                else
                {
                    TimeCnt = T;
                    button4.Enabled = true; button5.Enabled = true; button6.Enabled = true;
                    
                    if (button1.Enabled == true)
                    {
                        for (int i = 0; i < 42; i += 6){
                            if (Btn[i].Enabled == true)
                            {
                                Btn[i].BackColor = Color.LightBlue;
                                Btn[i].Text = button1.Text.Substring(0, 2);
                                Btn[i].Enabled = false;
                                button1.Text=button1.Text.Substring(0, 2) + " : 0顆";
                                break;
                            }
                        }
                        button1.Enabled = false;
                    }
                    if (button2.Enabled == true)
                    {
                        for (int i = 0; i < 42; i += 6)
                        {
                            if (Btn[i].Enabled == true)
                            {
                                Btn[i].BackColor = Color.LightBlue;
                                Btn[i].Text = button2.Text.Substring(0, 2);
                                Btn[i].Enabled = false;
                                button2.Text = button2.Text.Substring(0, 2) + " : 0顆";
                                break;
                            }
                        }
                        button2.Enabled = false;
                    }
                    if (button3.Enabled == true)
                    {
                        for (int i = 0; i < 42; i += 6)
                        {
                            if (Btn[i].Enabled == true)
                            {
                                Btn[i].BackColor = Color.LightBlue;
                                Btn[i].Text = button3.Text.Substring(0, 2);
                                Btn[i].Enabled = false;
                                button3.Text = button3.Text.Substring(0, 2) + " : 0顆";
                                break;
                            }
                        }
                        button3.Enabled = false;
                    }
                    for (int i = 0; i < 7; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            if (j < 3) Btn[i * 6 + j].Enabled = false;
                            else Btn[i * 6 + j].Enabled = true;
                        }
                    }
                    done1 = true;
                }

                press = null;

            }
            else
            {
                RestTime.Text = TimeCnt.ToString();
            }
            TimeCnt--;
            
        }

        private void choose_Click(object sender, EventArgs e){
            press = (Button)sender;
            if (Convert.ToInt32(press.Name[6]) <= '3')
            {   
                choose1.Text = press.Text.Substring(0,2);
            }
            else
            {
                choose2.Text = press.Text.Substring(0, 2);
            }
        }
        private bool check_win()
        {
            return false;
        }
        private void btn_Click(object sender, EventArgs e)
        {
            if (status != 0)
            {
                string target = "";
                if (Info.Text == "P1 Turn") target = choose1.Text;
                else target = choose2.Text;
                
                int pos = 0;
                for(int i = 0; i < 42; i++)
                {
                    if (Btn[i].Text == target)
                    {
                        if(Info.Text == "P1 Turn" && Btn[i].BackColor == Color.LightBlue)
                        {
                            pos = i;
                            break;
                        }
                        if (Info.Text == "P2 Turn" && Btn[i].BackColor == Color.LightPink)
                        {
                            pos = i;
                            break;
                        }
                    }
                }

                Button btn = (Button)sender;
                int now = Convert.ToInt32(btn.Name);
                double dis = Math.Sqrt((double)((now / 6 - pos / 6) * (now / 6 - pos / 6) + (now % 6 - pos % 6) * (now % 6 - pos % 6)));

                if (status == 2)
                {
                    int Max_Range = 0;
                    if (Info.Text == "P1 Turn") Max_Range=chaP1[index].MOVE_Range;
                    else Max_Range=chaP2[index].MOVE_Range;
                    
                    if (Math.Round(dis) == dis && dis <= Max_Range)
                    {
                        Btn[now].Text = target;
                        Btn[pos].Text = "";
                        if (Info.Text == "P1 Turn") Btn[now].BackColor = Color.LightBlue;
                        else Btn[now].BackColor = Color.LightPink;
                        Btn[pos].BackColor = Color.White;
                    }
                    else
                    {
                        return;
                    }
                }else if (status == 1)
                {
                    int Max_Range = 0;
                    if (Info.Text == "P1 Turn") Max_Range = chaP1[index].ATK_Range;
                    else Max_Range = chaP2[index].ATK_Range;

                    if (Math.Round(dis) == dis && dis <= Max_Range)
                    {
                        
                        if (btn.Text == "戰士")
                        {
                            if (Info.Text == "P1 Turn")
                            {
                                chaP2[0].HP -= chaP1[index].ATK;
                                info2.Text = "HP : " + chaP2[0].HP.ToString() + "\nMP : " + chaP2[0].MP.ToString() + "\nATK : " + chaP2[0].ATK.ToString() + "\nATK_Range : " + chaP2[0].ATK_Range.ToString() + "\nMove_Range : " + chaP2[0].MOVE_Range.ToString();
                                choose2.Text = "戰士";
                                if (chaP2[0].HP <= 0)
                                {
                                    P2rest--;
                                    btn.Text = "";
                                    btn.BackColor = Color.White;
                                    P2alive[0] = false;
                                }
                            }
                            else
                            {
                                chaP1[0].HP -= chaP2[index].ATK;
                                info1.Text = "HP : " + chaP1[0].HP.ToString() + "\nMP : " + chaP1[0].MP.ToString() + "\nATK : " + chaP1[0].ATK.ToString() + "\nATK_Range : " + chaP1[0].ATK_Range.ToString() + "\nMove_Range : " + chaP1[0].MOVE_Range.ToString();
                                choose1.Text = "戰士";
                                if (chaP1[0].HP <= 0)
                                {
                                    P1rest--;
                                    btn.Text = "";
                                    btn.BackColor = Color.White;
                                    P1alive[0] = false;
                                }
                            }
                        }
                        else if(btn.Text=="法師")
                        {
                            if (Info.Text == "P1 Turn")
                            {
                                chaP2[1].HP -= chaP1[index].ATK;
                                info2.Text = "HP : " + chaP2[1].HP.ToString() + "\nMP : " + chaP2[1].MP.ToString() + "\nATK : " + chaP2[1].ATK.ToString() + "\nATK_Range : " + chaP2[1].ATK_Range.ToString() + "\nMove_Range : " + chaP2[1].MOVE_Range.ToString();
                                choose2.Text = "法師";
                                if (chaP2[1].HP <= 0)
                                {
                                    P2rest--;
                                    btn.Text = "";
                                    btn.BackColor = Color.White;
                                    P2alive[1] = false;
                                }
                            }
                            else
                            {
                                chaP1[1].HP -= chaP2[index].ATK;
                                info1.Text = "HP : " + chaP1[1].HP.ToString() + "\nMP : " + chaP1[1].MP.ToString() + "\nATK : " + chaP1[1].ATK.ToString() + "\nATK_Range : " + chaP1[1].ATK_Range.ToString() + "\nMove_Range : " + chaP1[1].MOVE_Range.ToString();
                                choose1.Text = "法師";
                                if (chaP1[1].HP <= 0)
                                {
                                    P1rest--;
                                    btn.Text = "";
                                    btn.BackColor = Color.White;
                                    P1alive[1] = false;
                                }
                            }
                        }
                        else
                        {
                            if (Info.Text == "P1 Turn")
                            {
                                chaP2[2].HP -= chaP1[index].ATK;
                                info2.Text = "HP : " + chaP2[2].HP.ToString() + "\nMP : " + chaP2[2].MP.ToString() + "\nATK : " + chaP2[2].ATK.ToString() + "\nATK_Range : " + chaP2[2].ATK_Range.ToString() + "\nMove_Range : " + chaP2[2].MOVE_Range.ToString();
                                choose2.Text = "遊俠";
                                if (chaP2[2].HP <= 0)
                                {
                                    P2rest--;
                                    btn.Text = "";
                                    btn.BackColor = Color.White;
                                    P2alive[2] = false;
                                }
                            }
                            else
                            {
                                chaP1[2].HP -= chaP2[index].ATK;
                                info1.Text = "HP : " + chaP1[2].HP.ToString() + "\nMP : " + chaP1[2].MP.ToString() + "\nATK : " + chaP1[2].ATK.ToString() + "\nATK_Range : " + chaP1[2].ATK_Range.ToString() + "\nMove_Range : " + chaP1[2].MOVE_Range.ToString();
                                choose1.Text = "遊俠";
                                if (chaP1[2].HP <= 0)
                                {
                                    P1rest--;
                                    btn.Text = "";
                                    btn.BackColor = Color.White;
                                    P1alive[2] = false;
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("超出攻擊範圍");
                        return;
                    }
                }
                else
                {
                    if (Info.Text == "P1 Turn")
                    {
                        if (chaP1[index].MP-10 < 0) return;

                        Characteristic enemy = null;
                        int _index = 0;
                        if (btn.Text == "戰士") { enemy = chaP2[0]; _index = 0; }
                        else if (btn.Text == "法師") { enemy = chaP2[1]; _index = 1; }
                        else { enemy = chaP2[2]; _index = 2; }

                        if (chaP1[index].character == "戰士")
                        {
                            if(Math.Round(dis) == dis && dis <= chaP1[index].ATK_Range)
                            {
                                enemy.HP -= chaP1[index].ATK;
                                chaP1[index].HP += chaP1[index].ATK / 2;
                                
                                if (enemy.HP <= 0)
                                {
                                    P2rest--;
                                    btn.Text = "";
                                    btn.BackColor = Color.White;
                                    P2alive[_index] = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("超出攻擊範圍");
                                return;
                            }
                            
                        }
                        else if(chaP1[index].character == "法師")
                        {
                            if (Math.Round(dis) == dis && dis <= chaP1[index].ATK_Range)
                            {
                                
                                enemy.HP -= chaP1[index].ATK*2;

                                if (enemy.HP <= 0)
                                {
                                    P2rest--;
                                    btn.Text = "";
                                    btn.BackColor = Color.White;
                                    P2alive[_index] = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("超出攻擊範圍");
                                return;
                            }
                            
                        }
                        else{

                            if (Math.Round(dis) == dis && dis <= chaP1[index].ATK_Range+1)
                            {
                                enemy.HP -= chaP1[index].ATK;

                                if (enemy.HP <= 0)
                                {
                                    P2rest--;
                                    btn.Text = "";
                                    btn.BackColor = Color.White;
                                    P2alive[_index] = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("超出攻擊範圍");
                                return;
                            }
                        }
                        info2.Text = "HP : " + chaP2[_index].HP.ToString() + "\nMP : " + chaP1[_index].MP.ToString() + "\nATK : " + chaP1[_index].ATK.ToString() + "\nATK_Range : " + chaP1[_index].ATK_Range.ToString() + "\nMove_Range : " + chaP1[_index].MOVE_Range.ToString();
                        choose2.Text = enemy.character;
                        chaP1[index].MP -= 10;
                    }
                    else
                    {
                        if (chaP2[index].MP - 10 < 0) return;

                        Characteristic enemy = null;
                        int _index = 0;
                        if (btn.Text == "戰士") { enemy = chaP1[0]; _index = 0; }
                        else if (btn.Text == "法師") { enemy = chaP1[1]; _index = 1; }
                        else { enemy = chaP1[2]; _index = 2; }

                        if (chaP2[index].character == "戰士")
                        {
                            if (Math.Round(dis) == dis && dis <= chaP2[index].ATK_Range)
                            {
                                enemy.HP -= chaP2[index].ATK;
                                chaP2[index].HP += chaP2[index].ATK / 2;

                                if (enemy.HP <= 0)
                                {
                                    P1rest--;
                                    btn.Text = "";
                                    btn.BackColor = Color.White;
                                    P1alive[_index] = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("超出攻擊範圍");
                                return;
                            }

                        }
                        else if (chaP2[index].character == "法師")
                        {
                            if (Math.Round(dis) == dis && dis <= chaP2[index].ATK_Range)
                            {

                                enemy.HP -= chaP2[index].ATK * 2;

                                if (enemy.HP <= 0)
                                {
                                    P1rest--;
                                    btn.Text = "";
                                    btn.BackColor = Color.White;
                                    P1alive[_index] = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("超出攻擊範圍");
                                return;
                            }
                        }
                        else
                        {

                            if (Math.Round(dis) == dis && dis <= chaP2[index].ATK_Range + 1)
                            {
                                enemy.HP -= chaP2[index].ATK;

                                if (enemy.HP <= 0)
                                {
                                    P1rest--;
                                    btn.Text = "";
                                    btn.BackColor = Color.White;
                                    P1alive[_index] = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("超出攻擊範圍");
                                return;
                            }
                            
                        }
                        info1.Text = "HP : " + chaP1[_index].HP.ToString() + "\nMP : " + chaP1[_index].MP.ToString() + "\nATK : " + chaP1[_index].ATK.ToString() + "\nATK_Range : " + chaP1[_index].ATK_Range.ToString() + "\nMove_Range : " + chaP1[_index].MOVE_Range.ToString();
                        choose1.Text = enemy.character;
                        chaP2[index].MP -= 10;
                    }
                
                    
                }


                if(Info.Text=="P1 Turn") add1();
                else add2();
                status = 0;
                if (P1rest==0 || P2rest==0)
                {
                    End();
                }
                return;

            }
            if (press == null) return;

            Button cur = (Button)sender;
            if (Convert.ToInt32(cur.Name) % 6 < 3)
            {
                cur.BackColor = Color.LightBlue;
                cur.Text = choose1.Text;
            }
            else
            {
                cur.BackColor = Color.LightPink;    
                cur.Text = choose2.Text;
            }

            cur.Enabled = false;

            press.Text = press.Text.Substring(0, 2) + " : 0顆";
            press.Enabled = false;
            press = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            status = 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            status = 2;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            status = 3;
        }
        private void add1()
        {
            if (index == 3)
            {
                button7.Enabled = false; button8.Enabled = false;
                button9.Enabled = false; button10.Enabled = false;

                button11.Enabled = true;

            }
            else
            {
                index++;
                while (index < 3 && !P1alive[index]) index++;
                if (index == 3)
                {
                    button7.Enabled = false; button8.Enabled = false;
                    button9.Enabled = false; button10.Enabled = false;

                    button11.Enabled = true;
                    return;

                }

                string ans = "HP : " + chaP1[index].HP.ToString() + "\nMP : " + chaP1[index].MP.ToString() + "\nATK : " + chaP1[index].ATK.ToString() + "\nATK_Range : " + chaP1[index].ATK_Range.ToString() + "\nMove_Range : " + chaP1[index].MOVE_Range.ToString();
                info1.Text = ans;
                choose1.Text = chaP1[index].character;
            }
        }
        private void add2()
        {
            if (index == 3)
            {
                button13.Enabled = false; button14.Enabled = false;
                button15.Enabled = false; button16.Enabled = false;

                button12.Enabled = true;

            }
            else
            {
                index++;
                while (index < 3 && !P2alive[index]) index++;
                if (index == 3)
                {
                    button13.Enabled = false; button14.Enabled = false;
                    button15.Enabled = false; button16.Enabled = false;

                    button12.Enabled = true;
                    return;

                }
                string ans = "HP : " + chaP2[index].HP.ToString() + "\nMP : " + chaP2[index].MP.ToString() + "\nATK : " + chaP2[index].ATK.ToString() + "\nATK_Range : " + chaP2[index].ATK_Range.ToString() + "\nMove_Range : " + chaP2[index].MOVE_Range.ToString();
                info2.Text = ans;
                choose2.Text = chaP2[index].character;
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            add1();
        }
        

        Characteristic[] chaP1 = new Characteristic[3];
        int Rest1 = 3, Rest2 = 3;

        private void button11_Click(object sender, EventArgs e)
        {
            button13.Enabled = true;button14.Enabled = true;
            button15.Enabled = true;button16.Enabled = true;

            button11.Enabled = false;

            index = 0;
            while (!P2alive[index]) index++;

            string ans = "HP : " + chaP2[index].HP.ToString() + "\nMP : " + chaP2[index].MP.ToString() + "\nATK : " + chaP2[index].ATK.ToString() + "\nATK_Range : " + chaP2[index].ATK_Range.ToString() + "\nMove_Range : " + chaP2[index].MOVE_Range.ToString();
            info2.Text = ans;
            choose2.Text = chaP2[index].character;
            info1.Text = "";
            choose1.Text = "";
            Info.Text = "P2 Turn";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button7.Enabled = true; button8.Enabled = true;
            button9.Enabled = true; button10.Enabled = true;

            button12.Enabled = false;

            index = 0;
            while (!P1alive[index]) index++;

            string ans = "HP : " + chaP1[index].HP.ToString() + "\nMP : " + chaP1[index].MP.ToString() + "\nATK : " + chaP1[index].ATK.ToString() + "\nATK_Range : " + chaP1[index].ATK_Range.ToString() + "\nMove_Range : " + chaP1[index].MOVE_Range.ToString();

            info1.Text = ans; 
            choose1.Text = chaP1[index].character;
            info2.Text = "";
            Info.Text = "P1 Turn";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            status = 1;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            status = 2;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            status = 3;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            add2();
        }

        Characteristic[] chaP2 = new Characteristic[3];
        private void start_ATK()
        {
            chaP1[0] = new RoleA(0);
            chaP1[1] = new RoleB(0);
            chaP1[2] = new RoleC(0);
            chaP2[0] = new RoleA(1);
            chaP2[1] = new RoleB(1);
            chaP2[2] = new RoleC(1);

            string ans = "HP : " + chaP2[index].HP.ToString() + "\nMP : " + chaP2[index].MP.ToString() + "\nATK : " + chaP2[index].ATK.ToString() + "\nATK_Range : " + chaP2[index].ATK_Range.ToString() + "\nMove_Range : " + chaP2[index].MOVE_Range.ToString();
            info1.Text = ans;
            choose1.Text = "戰士";

        }
        private void End()
        {
            if (P1rest != 0) MessageBox.Show("P1贏了");
            else MessageBox.Show("P2贏了");
            Application.Exit();
        }
    }
}
