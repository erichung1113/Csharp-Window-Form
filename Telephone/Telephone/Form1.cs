using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Telephone
{
    public partial class Form1 : Form
    {


        FileInfo[] Sound1 = new FileInfo[4];
        FileInfo[] Sound2 = new FileInfo[3];

        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (number.Text == "Telephone") return;
            number.Text = number.Text.Substring(0, Math.Max(0,number.Text.Length - 1));
        }
        
        private void button15_Click(object sender, EventArgs e)
        {
            number.Text ="";
        }
        private void reverse_other_button()
        {
            button0.Enabled = !button0.Enabled;
            button1.Enabled = !button1.Enabled;
            button2.Enabled = !button2.Enabled;
            button3.Enabled = !button3.Enabled;
            button4.Enabled = !button4.Enabled;
            button5.Enabled = !button5.Enabled;
            button6.Enabled = !button6.Enabled;
            button7.Enabled = !button7.Enabled;
            button8.Enabled = !button8.Enabled;
            button9.Enabled = !button9.Enabled;
            button10.Enabled = !button10.Enabled;
            button12.Enabled = !button12.Enabled;
            delete.Enabled = !delete.Enabled;
            back.Enabled = !back.Enabled;
        }
        private void call_Click(object sender, EventArgs e)
        {
            if (call.ImageIndex == 2)
            {
                call.ImageIndex = 3;
                reverse_other_button();
                log.Text += number.Text + '\n';
            }
            else
            {
                call.ImageIndex = 2;
                reverse_other_button();
                number.Text = "Telephone";
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (path.Text == "")
            {

                MessageBox.Show("Empty String");
                return;
            }else if (!File.Exists(path.Text)) { 
                MessageBox.Show("Directory Not Found");
                return;
            }
            

            StreamWriter sw = new StreamWriter(path.Text);
            sw.Write(log.Text);
            sw.Close();
            FileInfo fi = new FileInfo(path.Text);
            MessageBox.Show("Done\n"+fi.FullName);
        }
        

        char cur = '.';
        private void tabControl1_KeyUp(object sender, KeyEventArgs e)
        {
            cur = '.';
            wp1.Ctlcontrols.stop();
            wp2.Ctlcontrols.stop();
        }

        

        private void PlaySound(char Key,int index)
        {
            wp1.URL = Sound1[index/3].FullName;
            wp2.URL = Sound2[index%3].FullName;

            wp1.Ctlcontrols.play();
            wp2.Ctlcontrols.play();
        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (tabControl1.SelectedIndex == 1) return;

            
            char Key = e.KeyCode.ToString().Length == 2 ? e.KeyCode.ToString()[1]:e.KeyCode.ToString()[0];

            int index = Key-'1';
            if (Key == '0') index = 10;

            if (e.Shift)
            {
                if (e.KeyCode == Keys.D3) { Key = '#'; index = 11; }
                else if (e.KeyCode == Keys.D8) { Key = '*'; index = 9; }
                else return;
            }
            
            if(('0'<=Key && Key<='9') || Key=='*' || Key == '#')
            {
                if (cur == '.')
                {
                    if (number.Text == "Telephone") number.Text = "";
                    number.Text += Key;
                    cur = Key;

                    PlaySound(Key, index);
                }
            }
        }


        private void MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            PlaySound(Convert.ToChar(btn.Text),btn.TabIndex-1);

            if (number.Text == "Telephone") number.Text = "";
            number.Text += btn.Text;
        }

        private void MouseUp(object sender, MouseEventArgs e)
        {
            wp1.Ctlcontrols.stop();
            wp2.Ctlcontrols.stop();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            Sound1[0] = new FileInfo("../../audio/697.wav");
            Sound1[1] = new FileInfo("../../audio/770.wav");
            Sound1[2] = new FileInfo("../../audio/852.wav");
            Sound1[3] = new FileInfo("../../audio/941.wav");

            Sound2[0] = new FileInfo("../../audio/1209.wav");
            Sound2[1] = new FileInfo("../../audio/1336.wav");
            Sound2[2] = new FileInfo("../../audio/1477.wav");


            wp1.settings.setMode("loop", true);
            wp2.settings.setMode("loop", true);
        }
    }
}
