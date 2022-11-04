namespace ToDoList
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
            if (disposing && (components != null)) {
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
            this.List = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ji3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.儲存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存新黨ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.關閉ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.檢視ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字型大小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.顯示完成事項ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隱藏完成事項ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編輯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.尋找ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增事項ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.完成事項ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刪除事項ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // List
            // 
            this.List.Location = new System.Drawing.Point(12, 42);
            this.List.Multiline = true;
            this.List.Name = "List";
            this.List.ReadOnly = true;
            this.List.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.List.Size = new System.Drawing.Size(717, 368);
            this.List.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ji3ToolStripMenuItem,
            this.檢視ToolStripMenuItem,
            this.編輯ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(741, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ji3ToolStripMenuItem
            // 
            this.ji3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem,
            this.開啟ToolStripMenuItem,
            this.儲存ToolStripMenuItem,
            this.另存新黨ToolStripMenuItem,
            this.關閉ToolStripMenuItem});
            this.ji3ToolStripMenuItem.Name = "ji3ToolStripMenuItem";
            this.ji3ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.ji3ToolStripMenuItem.Text = "檔案";
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.新增ToolStripMenuItem.Text = "新增";
            this.新增ToolStripMenuItem.Click += new System.EventHandler(this.新增ToolStripMenuItem_Click);
            // 
            // 開啟ToolStripMenuItem
            // 
            this.開啟ToolStripMenuItem.Name = "開啟ToolStripMenuItem";
            this.開啟ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.開啟ToolStripMenuItem.Text = "開啟";
            this.開啟ToolStripMenuItem.Click += new System.EventHandler(this.開啟ToolStripMenuItem_Click);
            // 
            // 儲存ToolStripMenuItem
            // 
            this.儲存ToolStripMenuItem.Name = "儲存ToolStripMenuItem";
            this.儲存ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.儲存ToolStripMenuItem.Text = "儲存";
            this.儲存ToolStripMenuItem.Click += new System.EventHandler(this.儲存ToolStripMenuItem_Click);
            // 
            // 另存新黨ToolStripMenuItem
            // 
            this.另存新黨ToolStripMenuItem.Name = "另存新黨ToolStripMenuItem";
            this.另存新黨ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.另存新黨ToolStripMenuItem.Text = "另存新檔";
            this.另存新黨ToolStripMenuItem.Click += new System.EventHandler(this.另存新黨ToolStripMenuItem_Click);
            // 
            // 關閉ToolStripMenuItem
            // 
            this.關閉ToolStripMenuItem.Name = "關閉ToolStripMenuItem";
            this.關閉ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.關閉ToolStripMenuItem.Text = "關閉";
            this.關閉ToolStripMenuItem.Click += new System.EventHandler(this.關閉ToolStripMenuItem_Click);
            // 
            // 檢視ToolStripMenuItem
            // 
            this.檢視ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.字型大小ToolStripMenuItem,
            this.顯示完成事項ToolStripMenuItem,
            this.隱藏完成事項ToolStripMenuItem});
            this.檢視ToolStripMenuItem.Name = "檢視ToolStripMenuItem";
            this.檢視ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.檢視ToolStripMenuItem.Text = "檢視";
            // 
            // 字型大小ToolStripMenuItem
            // 
            this.字型大小ToolStripMenuItem.Name = "字型大小ToolStripMenuItem";
            this.字型大小ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.字型大小ToolStripMenuItem.Text = "字型大小";
            this.字型大小ToolStripMenuItem.Click += new System.EventHandler(this.字型大小ToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(654, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "新增事項";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(563, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "完成事項";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // 顯示完成事項ToolStripMenuItem
            // 
            this.顯示完成事項ToolStripMenuItem.Name = "顯示完成事項ToolStripMenuItem";
            this.顯示完成事項ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.顯示完成事項ToolStripMenuItem.Text = "顯示完成事項";
            this.顯示完成事項ToolStripMenuItem.Click += new System.EventHandler(this.顯示完成事項ToolStripMenuItem_Click);
            // 
            // 隱藏完成事項ToolStripMenuItem
            // 
            this.隱藏完成事項ToolStripMenuItem.Name = "隱藏完成事項ToolStripMenuItem";
            this.隱藏完成事項ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.隱藏完成事項ToolStripMenuItem.Text = "隱藏完成事項";
            this.隱藏完成事項ToolStripMenuItem.Click += new System.EventHandler(this.隱藏完成事項ToolStripMenuItem_Click);
            // 
            // 編輯ToolStripMenuItem
            // 
            this.編輯ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.尋找ToolStripMenuItem,
            this.新增事項ToolStripMenuItem,
            this.完成事項ToolStripMenuItem,
            this.刪除事項ToolStripMenuItem});
            this.編輯ToolStripMenuItem.Name = "編輯ToolStripMenuItem";
            this.編輯ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.編輯ToolStripMenuItem.Text = "編輯";
            // 
            // 尋找ToolStripMenuItem
            // 
            this.尋找ToolStripMenuItem.Name = "尋找ToolStripMenuItem";
            this.尋找ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.尋找ToolStripMenuItem.Text = "尋找";
            this.尋找ToolStripMenuItem.Click += new System.EventHandler(this.尋找ToolStripMenuItem_Click);
            // 
            // 新增事項ToolStripMenuItem
            // 
            this.新增事項ToolStripMenuItem.Name = "新增事項ToolStripMenuItem";
            this.新增事項ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.新增事項ToolStripMenuItem.Text = "新增事項";
            this.新增事項ToolStripMenuItem.Click += new System.EventHandler(this.新增事項ToolStripMenuItem_Click);
            // 
            // 完成事項ToolStripMenuItem
            // 
            this.完成事項ToolStripMenuItem.Name = "完成事項ToolStripMenuItem";
            this.完成事項ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.完成事項ToolStripMenuItem.Text = "完成事項";
            this.完成事項ToolStripMenuItem.Click += new System.EventHandler(this.完成事項ToolStripMenuItem_Click);
            // 
            // 刪除事項ToolStripMenuItem
            // 
            this.刪除事項ToolStripMenuItem.Name = "刪除事項ToolStripMenuItem";
            this.刪除事項ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.刪除事項ToolStripMenuItem.Text = "刪除事項";
            this.刪除事項ToolStripMenuItem.Click += new System.EventHandler(this.刪除事項ToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(654, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "關閉搜尋";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.List);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox List;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ji3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開啟ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 儲存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存新黨ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 檢視ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 關閉ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字型大小ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem 顯示完成事項ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 隱藏完成事項ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編輯ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 尋找ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增事項ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 完成事項ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刪除事項ToolStripMenuItem;
        private System.Windows.Forms.Button button3;
    }
}

