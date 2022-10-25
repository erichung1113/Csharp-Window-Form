namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Continue = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.imgCats = new System.Windows.Forms.ImageList(this.components);
            this.TC = new System.Windows.Forms.TabControl();
            this.Page1 = new System.Windows.Forms.TabPage();
            this.Page2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.Score = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.History = new System.Windows.Forms.Label();
            this.Restart = new System.Windows.Forms.Button();
            this.TC.SuspendLayout();
            this.Page1.SuspendLayout();
            this.Page2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "翻牌小遊戲";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(481, 37);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(90, 37);
            this.Start.TabIndex = 1;
            this.Start.Text = "開始遊戲";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Continue
            // 
            this.Continue.Enabled = false;
            this.Continue.Location = new System.Drawing.Point(481, 112);
            this.Continue.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(90, 41);
            this.Continue.TabIndex = 2;
            this.Continue.Text = "繼續";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(481, 326);
            this.Exit.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(90, 39);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "離開遊戲";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // imgCats
            // 
            this.imgCats.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgCats.ImageStream")));
            this.imgCats.TransparentColor = System.Drawing.Color.Transparent;
            this.imgCats.Images.SetKeyName(0, "01.jpg");
            this.imgCats.Images.SetKeyName(1, "02.jpg");
            this.imgCats.Images.SetKeyName(2, "03.jpg");
            this.imgCats.Images.SetKeyName(3, "04.jpg");
            this.imgCats.Images.SetKeyName(4, "05.jpg");
            this.imgCats.Images.SetKeyName(5, "06.jpg");
            this.imgCats.Images.SetKeyName(6, "07.jpg");
            this.imgCats.Images.SetKeyName(7, "08.jpg");
            this.imgCats.Images.SetKeyName(8, "card.jpg");
            // 
            // TC
            // 
            this.TC.Controls.Add(this.Page1);
            this.TC.Controls.Add(this.Page2);
            this.TC.Location = new System.Drawing.Point(17, 40);
            this.TC.Name = "TC";
            this.TC.SelectedIndex = 0;
            this.TC.Size = new System.Drawing.Size(627, 447);
            this.TC.TabIndex = 4;
            // 
            // Page1
            // 
            this.Page1.Controls.Add(this.Restart);
            this.Page1.Controls.Add(this.UserName);
            this.Page1.Controls.Add(this.label2);
            this.Page1.Controls.Add(this.Score);
            this.Page1.Controls.Add(this.Start);
            this.Page1.Controls.Add(this.Continue);
            this.Page1.Controls.Add(this.Exit);
            this.Page1.Location = new System.Drawing.Point(4, 22);
            this.Page1.Name = "Page1";
            this.Page1.Padding = new System.Windows.Forms.Padding(3);
            this.Page1.Size = new System.Drawing.Size(619, 421);
            this.Page1.TabIndex = 0;
            this.Page1.Text = "遊玩區";
            this.Page1.UseVisualStyleBackColor = true;
            // 
            // Page2
            // 
            this.Page2.Controls.Add(this.History);
            this.Page2.Location = new System.Drawing.Point(4, 22);
            this.Page2.Name = "Page2";
            this.Page2.Padding = new System.Windows.Forms.Padding(3);
            this.Page2.Size = new System.Drawing.Size(619, 421);
            this.Page2.TabIndex = 1;
            this.Page2.Text = "歷史紀錄區";
            this.Page2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("新細明體", 15F);
            this.Score.Location = new System.Drawing.Point(20, 18);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(91, 20);
            this.Score.TabIndex = 4;
            this.Score.Text = "分數 : 100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15F);
            this.label2.Location = new System.Drawing.Point(136, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "名稱 : ";
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("新細明體", 12F);
            this.UserName.Location = new System.Drawing.Point(207, 18);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(100, 27);
            this.UserName.TabIndex = 6;
            // 
            // History
            // 
            this.History.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.History.Location = new System.Drawing.Point(21, 22);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(570, 378);
            this.History.TabIndex = 0;
            // 
            // Restart
            // 
            this.Restart.Location = new System.Drawing.Point(481, 190);
            this.Restart.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(90, 41);
            this.Restart.TabIndex = 7;
            this.Restart.Text = "重新開始";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(667, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TC);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TC.ResumeLayout(false);
            this.Page1.ResumeLayout(false);
            this.Page1.PerformLayout();
            this.Page2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1   ;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ImageList imgCats;
        private System.Windows.Forms.TabControl TC;
        private System.Windows.Forms.TabPage Page1;
        private System.Windows.Forms.TabPage Page2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label History;
        private System.Windows.Forms.Button Restart;
    }
}

