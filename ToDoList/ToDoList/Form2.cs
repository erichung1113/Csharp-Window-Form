﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string thing = "";
            
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thing = textBox1.Text;
            if(thing!="") Close();
            else {
                MessageBox.Show("請輸入事項");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            thing = "";
            textBox1.Text = thing;
        }
    }
}
