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

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filename="";
        List<string> all_thing = new List<string>();
        Form2 form2 = new Form2();
        bool show_complete = true;

        bool getThing()
        {
            Enabled = false;
            form2.ShowDialog();
            Enabled = true;
            if (form2.thing == "") return false;
            return true;
        }

        void UpdateList()
        {
            List<string> ShowList = new List<string>();
            foreach(var thing in all_thing) { 
                if (show_complete || thing[2] != '√') {
                    ShowList.Add(thing);
                }
            }

            List.Lines = ShowList.ToArray();
        }

        private void 另存新黨ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Todo Files(*.todo)|*.todo|Text Files(*.txt)|*.txt|All Files(*.*)|*.*";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Title = "另存新檔";
            saveFileDialog1.ShowDialog();
            filename = saveFileDialog1.FileName;
            write_file();
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List.Text = "";
            filename = "";
            all_thing.Clear();
        }

        private void 開啟ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Todo Files(*.todo)|*.todo|Text Files(*.txt)|*.txt|All Files(*.*)|*.*";
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "開啟";
            openFileDialog1.ShowDialog();
            filename = openFileDialog1.FileName;

            List.Text="";
            all_thing.Clear();

            using (StreamReader sr = new StreamReader(filename)) {
                string line;
                while ((line = sr.ReadLine()) != null) {
                    if (line[0] == '-') {
                        line = " [ ] " + line;
                    } else {
                        line = " [√] " + line;
                    }
                    all_thing.Add(line);
                }
            }
            UpdateList();
        }
        
        void write_file()
        {
            using(StreamWriter sw=new StreamWriter(filename)) {
                foreach(var item in all_thing) {
                    string thing = item;
                    if (item[2] == '√') thing = '+' + thing.Substring(5);
                    else thing = '-' + thing.Substring(5);
                    sw.WriteLine(thing);
                }
            }

        }
        private void 儲存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filename == "") 另存新黨ToolStripMenuItem_Click(sender, e);
            else write_file();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            新增事項ToolStripMenuItem_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            完成事項ToolStripMenuItem_Click(sender, e);
        }

        private void 關閉ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 字型大小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            List.Font = fontDialog1.Font;
        }

        private void 新增事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (getThing()) {
                string target = " [ ] " + form2.thing;
                all_thing.Add(target);
                UpdateList();
            }
        }

        private void 完成事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (getThing()) {
                string target = " [ ] " + form2.thing;
                for (int i = 0; i < all_thing.Count(); i++) {
                    if (all_thing[i] == target) {
                        all_thing[i] = " [√] " + form2.thing;
                        UpdateList();
                        return;
                    }
                }
            }
        }

        private void 刪除事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (getThing()) {
                string target1 = " [ ] " + form2.thing;
                string target2 = " [√] " + form2.thing;

                for (int i = 0; i < all_thing.Count(); i++) {
                    if (all_thing[i] == target1 || all_thing[i] == target2) {
                        all_thing.RemoveAt(i);
                        List.Lines = all_thing.ToArray();
                        return;
                    }
                }
            }
        }

        private void 顯示完成事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            show_complete = true;
            UpdateList();
        }

        private void 隱藏完成事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            show_complete = false;
            UpdateList();
        }

        private void 尋找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (getThing()) {
                string thing = form2.thing;

                List<string> ShowList = new List<string>();
                
                foreach(var item in all_thing) {
                    if (item.IndexOf(thing) != -1) ShowList.Add(item);
                }
                List.Lines = ShowList.ToArray();
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = true;
                menuStrip1.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            menuStrip1.Enabled = true;
            UpdateList();
        }
    }
}
