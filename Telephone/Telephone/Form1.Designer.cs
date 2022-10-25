namespace Telephone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.wp1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.back = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.call = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.log = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wp2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wp1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wp2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(772, 546);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
            this.tabControl1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyUp);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.wp2);
            this.tabPage1.Controls.Add(this.wp1);
            this.tabPage1.Controls.Add(this.back);
            this.tabPage1.Controls.Add(this.call);
            this.tabPage1.Controls.Add(this.delete);
            this.tabPage1.Controls.Add(this.button10);
            this.tabPage1.Controls.Add(this.button0);
            this.tabPage1.Controls.Add(this.button12);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.number);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(764, 520);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Telephone";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // wp1
            // 
            this.wp1.Enabled = true;
            this.wp1.Location = new System.Drawing.Point(559, 95);
            this.wp1.Name = "wp1";
            this.wp1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wp1.OcxState")));
            this.wp1.Size = new System.Drawing.Size(151, 153);
            this.wp1.TabIndex = 16;
            this.wp1.Visible = false;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Gainsboro;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("新細明體", 35F);
            this.back.ForeColor = System.Drawing.Color.Black;
            this.back.ImageIndex = 1;
            this.back.ImageList = this.imageList1;
            this.back.Location = new System.Drawing.Point(433, 438);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(65, 65);
            this.back.TabIndex = 15;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.button13_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "iShot_2022-10-23_14.37.41.png");
            this.imageList1.Images.SetKeyName(1, "2.png");
            this.imageList1.Images.SetKeyName(2, "—Pngtree—call icon_4419870.png");
            this.imageList1.Images.SetKeyName(3, "截圖 2022-10-23 下午3.09.35.png");
            // 
            // call
            // 
            this.call.BackColor = System.Drawing.Color.Gainsboro;
            this.call.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.call.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.call.FlatAppearance.BorderSize = 0;
            this.call.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.call.Font = new System.Drawing.Font("新細明體", 35F);
            this.call.ForeColor = System.Drawing.Color.Black;
            this.call.ImageIndex = 2;
            this.call.ImageList = this.imageList1;
            this.call.Location = new System.Drawing.Point(340, 438);
            this.call.Name = "call";
            this.call.Size = new System.Drawing.Size(65, 65);
            this.call.TabIndex = 14;
            this.call.UseVisualStyleBackColor = false;
            this.call.Click += new System.EventHandler(this.call_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Gainsboro;
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("新細明體", 35F);
            this.delete.ForeColor = System.Drawing.Color.Black;
            this.delete.ImageIndex = 0;
            this.delete.ImageList = this.imageList1;
            this.delete.Location = new System.Drawing.Point(245, 438);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(65, 65);
            this.delete.TabIndex = 13;
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.button15_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Gainsboro;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("新細明體", 35F);
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(433, 351);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(65, 65);
            this.button10.TabIndex = 12;
            this.button10.Text = "#";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.Gainsboro;
            this.button0.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button0.FlatAppearance.BorderSize = 0;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Font = new System.Drawing.Font("新細明體", 35F);
            this.button0.ForeColor = System.Drawing.Color.Black;
            this.button0.Location = new System.Drawing.Point(340, 351);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(65, 65);
            this.button0.TabIndex = 11;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Gainsboro;
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("新細明體", 35F);
            this.button12.ForeColor = System.Drawing.Color.Black;
            this.button12.Location = new System.Drawing.Point(245, 351);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(65, 65);
            this.button12.TabIndex = 10;
            this.button12.Text = "*";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gainsboro;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("新細明體", 35F);
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(433, 262);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(65, 65);
            this.button7.TabIndex = 9;
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Gainsboro;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("新細明體", 35F);
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(340, 262);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(65, 65);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Gainsboro;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("新細明體", 35F);
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(245, 262);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(65, 65);
            this.button9.TabIndex = 7;
            this.button9.Text = "7";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gainsboro;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("新細明體", 35F);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(433, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 65);
            this.button4.TabIndex = 6;
            this.button4.Text = "6";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gainsboro;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("新細明體", 35F);
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(340, 172);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 65);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gainsboro;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("新細明體", 35F);
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(245, 172);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(65, 65);
            this.button6.TabIndex = 4;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("新細明體", 35F);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(433, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 65);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("新細明體", 35F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(340, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 65);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("新細明體", 35F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(245, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Font = new System.Drawing.Font("新細明體", 30F);
            this.number.Location = new System.Drawing.Point(14, 13);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(177, 40);
            this.number.TabIndex = 0;
            this.number.Text = "Telephone";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.log);
            this.tabPage2.Controls.Add(this.save);
            this.tabPage2.Controls.Add(this.path);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(764, 520);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.Gainsboro;
            this.log.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.log.Location = new System.Drawing.Point(16, 100);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(731, 404);
            this.log.TabIndex = 4;
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.save.Location = new System.Drawing.Point(681, 56);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(66, 22);
            this.save.TabIndex = 3;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(57, 54);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(609, 22);
            this.path.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Save";
            // 
            // wp2
            // 
            this.wp2.Enabled = true;
            this.wp2.Location = new System.Drawing.Point(559, 302);
            this.wp2.Name = "wp2";
            this.wp2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wp2.OcxState")));
            this.wp2.Size = new System.Drawing.Size(151, 153);
            this.wp2.TabIndex = 17;
            this.wp2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 556);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wp1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wp2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button call;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
        private AxWMPLib.AxWindowsMediaPlayer wp1;
        private AxWMPLib.AxWindowsMediaPlayer wp2;
    }
}

