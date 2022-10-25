namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        Game game;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stk1 = new System.Windows.Forms.Label();
            this.stk2 = new System.Windows.Forms.Label();
            this.stk4 = new System.Windows.Forms.Label();
            this.stk3 = new System.Windows.Forms.Label();
            this.stk1btn = new System.Windows.Forms.Button();
            this.stk2btn = new System.Windows.Forms.Button();
            this.stk3btn = new System.Windows.Forms.Button();
            this.stk4btn = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.console = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.stk1_Input = new System.Windows.Forms.TextBox();
            this.stk4_Input = new System.Windows.Forms.TextBox();
            this.stk3_Input = new System.Windows.Forms.TextBox();
            this.stk2_Input = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "堆疊1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "堆疊4";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "堆疊3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "堆疊2";
            this.label4.Visible = false;
            // 
            // stk1
            // 
            this.stk1.BackColor = System.Drawing.Color.White;
            this.stk1.Location = new System.Drawing.Point(57, 75);
            this.stk1.Name = "stk1";
            this.stk1.Size = new System.Drawing.Size(93, 459);
            this.stk1.TabIndex = 4;
            this.stk1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.stk1.Visible = false;
            // 
            // stk2
            // 
            this.stk2.BackColor = System.Drawing.Color.White;
            this.stk2.Location = new System.Drawing.Point(182, 75);
            this.stk2.Name = "stk2";
            this.stk2.Size = new System.Drawing.Size(93, 459);
            this.stk2.TabIndex = 5;
            this.stk2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.stk2.Visible = false;
            // 
            // stk4
            // 
            this.stk4.BackColor = System.Drawing.Color.White;
            this.stk4.Location = new System.Drawing.Point(444, 75);
            this.stk4.Name = "stk4";
            this.stk4.Size = new System.Drawing.Size(93, 459);
            this.stk4.TabIndex = 6;
            this.stk4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.stk4.Visible = false;
            // 
            // stk3
            // 
            this.stk3.BackColor = System.Drawing.Color.White;
            this.stk3.Location = new System.Drawing.Point(308, 75);
            this.stk3.Name = "stk3";
            this.stk3.Size = new System.Drawing.Size(93, 459);
            this.stk3.TabIndex = 7;
            this.stk3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.stk3.Visible = false;
            // 
            // stk1btn
            // 
            this.stk1btn.Location = new System.Drawing.Point(61, 561);
            this.stk1btn.Name = "stk1btn";
            this.stk1btn.Size = new System.Drawing.Size(89, 48);
            this.stk1btn.TabIndex = 8;
            this.stk1btn.Text = "選取";
            this.stk1btn.UseVisualStyleBackColor = true;
            this.stk1btn.Visible = false;
            this.stk1btn.Click += new System.EventHandler(this.stk1btn_Click);
            // 
            // stk2btn
            // 
            this.stk2btn.Location = new System.Drawing.Point(177, 561);
            this.stk2btn.Name = "stk2btn";
            this.stk2btn.Size = new System.Drawing.Size(89, 48);
            this.stk2btn.TabIndex = 9;
            this.stk2btn.Text = "選取";
            this.stk2btn.UseVisualStyleBackColor = true;
            this.stk2btn.Visible = false;
            this.stk2btn.Click += new System.EventHandler(this.stk2btn_Click);
            // 
            // stk3btn
            // 
            this.stk3btn.Location = new System.Drawing.Point(312, 561);
            this.stk3btn.Name = "stk3btn";
            this.stk3btn.Size = new System.Drawing.Size(89, 48);
            this.stk3btn.TabIndex = 10;
            this.stk3btn.Text = "選取";
            this.stk3btn.UseVisualStyleBackColor = true;
            this.stk3btn.Visible = false;
            this.stk3btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // stk4btn
            // 
            this.stk4btn.Location = new System.Drawing.Point(448, 561);
            this.stk4btn.Name = "stk4btn";
            this.stk4btn.Size = new System.Drawing.Size(89, 48);
            this.stk4btn.TabIndex = 11;
            this.stk4btn.Text = "選取";
            this.stk4btn.UseVisualStyleBackColor = true;
            this.stk4btn.Visible = false;
            this.stk4btn.Click += new System.EventHandler(this.stk4btn_Click);
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(312, 646);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(225, 44);
            this.home.TabIndex = 12;
            this.home.Text = "回主畫面";
            this.home.UseVisualStyleBackColor = true;
            this.home.Visible = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // console
            // 
            this.console.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.console.Location = new System.Drawing.Point(61, 646);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(214, 43);
            this.console.TabIndex = 13;
            this.console.Text = "...";
            this.console.Visible = false;
            // 
            // Info
            // 
            this.Info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Info.Location = new System.Drawing.Point(50, 53);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(507, 67);
            this.Info.TabIndex = 14;
            this.Info.Text = "請輸入測資";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "堆疊1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "堆疊2";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "堆疊3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 427);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "堆疊4";
            // 
            // stk1_Input
            // 
            this.stk1_Input.Location = new System.Drawing.Point(108, 171);
            this.stk1_Input.Name = "stk1_Input";
            this.stk1_Input.Size = new System.Drawing.Size(449, 36);
            this.stk1_Input.TabIndex = 19;
            this.stk1_Input.Text = "1 1 2";
            // 
            // stk4_Input
            // 
            this.stk4_Input.Location = new System.Drawing.Point(108, 424);
            this.stk4_Input.Name = "stk4_Input";
            this.stk4_Input.Size = new System.Drawing.Size(449, 36);
            this.stk4_Input.TabIndex = 20;
            this.stk4_Input.Text = "3 3 3 1";
            // 
            // stk3_Input
            // 
            this.stk3_Input.Location = new System.Drawing.Point(108, 341);
            this.stk3_Input.Name = "stk3_Input";
            this.stk3_Input.Size = new System.Drawing.Size(449, 36);
            this.stk3_Input.TabIndex = 21;
            // 
            // stk2_Input
            // 
            this.stk2_Input.Location = new System.Drawing.Point(108, 257);
            this.stk2_Input.Name = "stk2_Input";
            this.stk2_Input.Size = new System.Drawing.Size(449, 36);
            this.stk2_Input.TabIndex = 22;
            this.stk2_Input.Text = "2 2";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(177, 490);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(240, 44);
            this.Start.TabIndex = 23;
            this.Start.Text = "開始遊戲";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 776);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.stk2_Input);
            this.Controls.Add(this.stk3_Input);
            this.Controls.Add(this.stk4_Input);
            this.Controls.Add(this.stk1_Input);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.console);
            this.Controls.Add(this.home);
            this.Controls.Add(this.stk4btn);
            this.Controls.Add(this.stk3btn);
            this.Controls.Add(this.stk2btn);
            this.Controls.Add(this.stk1btn);
            this.Controls.Add(this.stk3);
            this.Controls.Add(this.stk4);
            this.Controls.Add(this.stk2);
            this.Controls.Add(this.stk1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label stk1;
        private System.Windows.Forms.Label stk2;
        private System.Windows.Forms.Label stk4;
        private System.Windows.Forms.Label stk3;
        private System.Windows.Forms.Button stk1btn;
        private System.Windows.Forms.Button stk2btn;
        private System.Windows.Forms.Button stk3btn;
        private System.Windows.Forms.Button stk4btn;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Label console;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox stk1_Input;
        private System.Windows.Forms.TextBox stk4_Input;
        private System.Windows.Forms.TextBox stk3_Input;
        private System.Windows.Forms.TextBox stk2_Input;
        private System.Windows.Forms.Button Start;
    }
}

