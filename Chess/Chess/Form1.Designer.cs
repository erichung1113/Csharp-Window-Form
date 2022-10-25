namespace Chess
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Start = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.RestTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.choose1 = new System.Windows.Forms.Label();
            this.choose2 = new System.Windows.Forms.Label();
            this.info1 = new System.Windows.Forms.Label();
            this.info2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(378, 235);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(120, 69);
            this.Start.TabIndex = 0;
            this.Start.Text = "開始遊戲";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("新細明體", 25F);
            this.Info.Location = new System.Drawing.Point(357, 21);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(151, 34);
            this.Info.TabIndex = 1;
            this.Info.Text = "準備階段";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 25F);
            this.label1.Location = new System.Drawing.Point(104, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "P1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 25F);
            this.label2.Location = new System.Drawing.Point(696, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "P2";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 15F);
            this.button1.Location = new System.Drawing.Point(80, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "戰士:1顆";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.choose_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 15F);
            this.button2.Location = new System.Drawing.Point(80, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "法師:1顆";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.choose_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("新細明體", 15F);
            this.button3.Location = new System.Drawing.Point(80, 260);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 44);
            this.button3.TabIndex = 6;
            this.button3.Text = "遊俠:1顆";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.choose_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("新細明體", 15F);
            this.button4.Location = new System.Drawing.Point(669, 260);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 44);
            this.button4.TabIndex = 9;
            this.button4.Text = "遊俠:1顆";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.choose_Click);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("新細明體", 15F);
            this.button5.Location = new System.Drawing.Point(669, 210);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 44);
            this.button5.TabIndex = 8;
            this.button5.Text = "法師:1顆";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.choose_Click);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Font = new System.Drawing.Font("新細明體", 15F);
            this.button6.Location = new System.Drawing.Point(669, 160);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 44);
            this.button6.TabIndex = 7;
            this.button6.Text = "戰士:1顆";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.choose_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("新細明體", 15F);
            this.button7.Location = new System.Drawing.Point(51, 320);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(81, 53);
            this.button7.TabIndex = 10;
            this.button7.Text = "攻擊";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("新細明體", 15F);
            this.button8.Location = new System.Drawing.Point(138, 320);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(81, 53);
            this.button8.TabIndex = 11;
            this.button8.Text = "移動";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("新細明體", 15F);
            this.button9.Location = new System.Drawing.Point(138, 379);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(81, 53);
            this.button9.TabIndex = 13;
            this.button9.Text = "待機";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Visible = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("新細明體", 15F);
            this.button10.Location = new System.Drawing.Point(51, 379);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(81, 53);
            this.button10.TabIndex = 12;
            this.button10.Text = "技能";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Visible = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("新細明體", 15F);
            this.button11.Location = new System.Drawing.Point(53, 449);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(166, 44);
            this.button11.TabIndex = 14;
            this.button11.Text = "結束";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Visible = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // RestTime
            // 
            this.RestTime.Font = new System.Drawing.Font("新細明體", 25F);
            this.RestTime.Location = new System.Drawing.Point(357, 73);
            this.RestTime.Name = "RestTime";
            this.RestTime.Size = new System.Drawing.Size(151, 34);
            this.RestTime.TabIndex = 20;
            this.RestTime.Text = "10";
            this.RestTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // button16
            // 
            this.button16.Enabled = false;
            this.button16.Font = new System.Drawing.Font("新細明體", 15F);
            this.button16.Location = new System.Drawing.Point(638, 320);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(81, 53);
            this.button16.TabIndex = 15;
            this.button16.Text = "攻擊";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.Enabled = false;
            this.button15.Font = new System.Drawing.Font("新細明體", 15F);
            this.button15.Location = new System.Drawing.Point(725, 320);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(81, 53);
            this.button15.TabIndex = 16;
            this.button15.Text = "移動";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.Enabled = false;
            this.button14.Font = new System.Drawing.Font("新細明體", 15F);
            this.button14.Location = new System.Drawing.Point(638, 379);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(81, 53);
            this.button14.TabIndex = 17;
            this.button14.Text = "技能";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.Enabled = false;
            this.button13.Font = new System.Drawing.Font("新細明體", 15F);
            this.button13.Location = new System.Drawing.Point(725, 379);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(81, 53);
            this.button13.TabIndex = 18;
            this.button13.Text = "待機";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Enabled = false;
            this.button12.Font = new System.Drawing.Font("新細明體", 15F);
            this.button12.Location = new System.Drawing.Point(640, 449);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(166, 44);
            this.button12.TabIndex = 19;
            this.button12.Text = "結束";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // choose1
            // 
            this.choose1.Font = new System.Drawing.Font("新細明體", 25F);
            this.choose1.Location = new System.Drawing.Point(84, 107);
            this.choose1.Name = "choose1";
            this.choose1.Size = new System.Drawing.Size(97, 39);
            this.choose1.TabIndex = 21;
            this.choose1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // choose2
            // 
            this.choose2.Font = new System.Drawing.Font("新細明體", 25F);
            this.choose2.Location = new System.Drawing.Point(663, 107);
            this.choose2.Name = "choose2";
            this.choose2.Size = new System.Drawing.Size(107, 50);
            this.choose2.TabIndex = 22;
            this.choose2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // info1
            // 
            this.info1.Font = new System.Drawing.Font("新細明體", 15F);
            this.info1.Location = new System.Drawing.Point(55, 156);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(164, 148);
            this.info1.TabIndex = 23;
            this.info1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // info2
            // 
            this.info2.Font = new System.Drawing.Font("新細明體", 15F);
            this.info2.Location = new System.Drawing.Point(642, 160);
            this.info2.Name = "info2";
            this.info2.Size = new System.Drawing.Size(164, 148);
            this.info2.TabIndex = 24;
            this.info2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 525);
            this.Controls.Add(this.choose2);
            this.Controls.Add(this.choose1);
            this.Controls.Add(this.RestTime);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.info1);
            this.Controls.Add(this.info2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label RestTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label choose1;
        private System.Windows.Forms.Label choose2;
        public System.Windows.Forms.Label info1;
        public System.Windows.Forms.Label info2;
    }
}

