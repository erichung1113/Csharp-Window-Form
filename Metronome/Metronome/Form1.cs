using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Metronome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SoundPlayer ding = new SoundPlayer();
        SoundPlayer dong = new SoundPlayer();
        SoundPlayer doo = new SoundPlayer();

        Button[] btns = new Button[8];
        int cur = 0, Bound=4;
        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 8; i++)
            {
                Button btn = new Button();
                btn.Enabled = false;
                btn.Location = new Point(153+i*70, 167);
                btn.Size = new Size(50,50);
                btns[i] = btn;
                Controls.Add(btns[i]);
            }
            one.Checked = true;
            comboBox1.Text = "4";
            
            ding.SoundLocation = "../../audio/ding.wav";
            ding.Load();
            
            dong.SoundLocation = "../../audio/dong.wav";
            dong.Load();
            
            doo.SoundLocation = "../../audio/doo.wav";
            doo.Load();

            timer1.Interval = 500;

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "4")
            {
                for (int i = 0; i < 8; i++)
                {
                    if (i < 4) btns[i].Location = new Point(153 + i * 165, 167);
                    else btns[i].Visible = false;
                }
                Bound = 4;
            }
            else if (comboBox1.Text == "8")
            {
                for (int i = 0; i < 8; i++)
                {
                    btns[i].Visible = true;
                    btns[i].Location = new Point(153 + i * 70, 167);
                }
                Bound = 8;
            }
            if (two.Checked) Bound *= 2;
            init();
        }

            private void trackBar1_Scroll(object sender, EventArgs e)
        {
            BPM.Text = trackBar1.Value.ToString()+"BPM";
            timer1.Interval = 60000 / trackBar1.Value;
            if (two.Checked) timer1.Interval /= 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Start"){
                button2.Text = "Stop";
                timer1.Start();
                init();
            }
            else
            {
                button2.Text = "Start";
                timer1.Stop();
                for (int i = 0; i < 8; i++) btns[i].BackColor = Color.White;
            }
        }
        void init()
        {
            ding.Play();
            for (int i = 0; i < 8; i++) btns[i].BackColor = Color.White;
            cur = 0;
            btns[0].BackColor = Color.LightGreen;
            
        }
        private void one_CheckedChanged(object sender, EventArgs e)
        {
            init();
            timer1.Interval = 60000 / trackBar1.Value;
            if(one.Checked) Bound /= 2;
        }

        private void two_CheckedChanged(object sender, EventArgs e)
        {
            init();
            timer1.Interval = 60000 / trackBar1.Value;
            timer1.Interval /= 2;
            if(two.Checked) Bound *= 2;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            cur = (cur + 1) % Bound;
            if (cur == 0) {
                if(two.Checked) btns[Bound/2 - 1].BackColor = Color.White;
                else btns[Bound-1].BackColor=Color.White;
                btns[cur].BackColor = Color.LightGreen;
                ding.Play();
                return;
            }
            if (two.Checked)
            {
                if (cur % 2 == 1) doo.Play();
                else
                {
                    btns[cur/2 - 1].BackColor = Color.White;
                    btns[cur/2].BackColor = Color.LightGreen;
                    dong.Play();
                }
            }
            else
            {
                btns[cur - 1].BackColor = Color.White;
                btns[cur].BackColor = Color.LightGreen;
                dong.Play();
            }
        }
    }
}
