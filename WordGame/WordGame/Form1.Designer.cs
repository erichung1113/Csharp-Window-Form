namespace WordGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.Timelab = new System.Windows.Forms.Label();
            this.Falselab = new System.Windows.Forms.Label();
            this.Word = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("新細明體", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(318, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "猜英文單字\n6次猜錯機會";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(339, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "請輸入要猜的單字";
            // 
            // Input
            // 
            this.Input.BackColor = System.Drawing.SystemColors.Window;
            this.Input.Location = new System.Drawing.Point(363, 246);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(140, 22);
            this.Input.TabIndex = 2;
            this.Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Start.Location = new System.Drawing.Point(386, 314);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(100, 57);
            this.Start.TabIndex = 3;
            this.Start.Text = "START";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Timelab
            // 
            this.Timelab.AutoSize = true;
            this.Timelab.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Timelab.Location = new System.Drawing.Point(725, 83);
            this.Timelab.Name = "Timelab";
            this.Timelab.Size = new System.Drawing.Size(66, 16);
            this.Timelab.TabIndex = 7;
            this.Timelab.Text = "時間 : 0";
            this.Timelab.Visible = false;
            // 
            // Falselab
            // 
            this.Falselab.AutoSize = true;
            this.Falselab.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Falselab.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Falselab.Location = new System.Drawing.Point(725, 120);
            this.Falselab.Name = "Falselab";
            this.Falselab.Size = new System.Drawing.Size(112, 16);
            this.Falselab.TabIndex = 8;
            this.Falselab.Text = "猜錯次數: 0次";
            this.Falselab.Visible = false;
            // 
            // Word
            // 
            this.Word.Font = new System.Drawing.Font("新細明體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Word.Location = new System.Drawing.Point(189, 271);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(503, 141);
            this.Word.TabIndex = 9;
            this.Word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Word.Visible = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(879, 450);
            this.Controls.Add(this.Word);
            this.Controls.Add(this.Falselab);
            this.Controls.Add(this.Timelab);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label Timelab;
        private System.Windows.Forms.Label Falselab;
        private System.Windows.Forms.Label Word;
        private System.Windows.Forms.Timer timer;
    }
}

