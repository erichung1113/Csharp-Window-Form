using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    partial class Form1
    {
        

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        //--------------------------------------------------------

        Account Accounts = new Account();

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Search_butten = new System.Windows.Forms.Button();
            this.Input_bar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Risk_button = new System.Windows.Forms.Button();
            this.ins_del_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.Status_Column = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.Input_link = new System.Windows.Forms.TextBox();
            this.Input_user = new System.Windows.Forms.TextBox();
            this.Input_password = new System.Windows.Forms.TextBox();
            this.Insert = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(44, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "密碼管理員";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Search_butten
            // 
            this.Search_butten.Location = new System.Drawing.Point(1019, 138);
            this.Search_butten.Name = "Search_butten";
            this.Search_butten.Size = new System.Drawing.Size(114, 52);
            this.Search_butten.TabIndex = 2;
            this.Search_butten.Text = "搜尋";
            this.Search_butten.UseVisualStyleBackColor = true;
            this.Search_butten.Click += new System.EventHandler(this.Search_butten_Click);
            // 
            // Input_bar
            // 
            this.Input_bar.Location = new System.Drawing.Point(198, 147);
            this.Input_bar.Name = "Input_bar";
            this.Input_bar.Size = new System.Drawing.Size(798, 36);
            this.Input_bar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "搜尋列";
            // 
            // Risk_button
            // 
            this.Risk_button.Location = new System.Drawing.Point(100, 228);
            this.Risk_button.Name = "Risk_button";
            this.Risk_button.Size = new System.Drawing.Size(1033, 48);
            this.Risk_button.TabIndex = 5;
            this.Risk_button.Text = "風險帳號";
            this.Risk_button.UseVisualStyleBackColor = true;
            this.Risk_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // ins_del_button
            // 
            this.ins_del_button.Location = new System.Drawing.Point(847, 315);
            this.ins_del_button.Name = "ins_del_button";
            this.ins_del_button.Size = new System.Drawing.Size(286, 48);
            this.ins_del_button.TabIndex = 6;
            this.ins_del_button.Text = "新增或刪除";
            this.ins_del_button.UseVisualStyleBackColor = true;
            this.ins_del_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "搜尋結果";
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.Color.White;
            this.Result.Location = new System.Drawing.Point(100, 400);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(1033, 380);
            this.Result.TabIndex = 8;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // Status_Column
            // 
            this.Status_Column.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Status_Column.Location = new System.Drawing.Point(294, 485);
            this.Status_Column.Name = "Status_Column";
            this.Status_Column.Size = new System.Drawing.Size(604, 41);
            this.Status_Column.TabIndex = 10;
            this.Status_Column.Text = "我是狀態列";
            this.Status_Column.Visible = false;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(290, 561);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(58, 24);
            this.lblLink.TabIndex = 11;
            this.lblLink.Text = "連結";
            this.lblLink.Visible = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(290, 634);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(82, 24);
            this.lblUser.TabIndex = 12;
            this.lblUser.Text = "使用者";
            this.lblUser.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(290, 710);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(58, 24);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "密碼";
            this.lblPassword.Visible = false;
            // 
            // Input_link
            // 
            this.Input_link.Location = new System.Drawing.Point(398, 558);
            this.Input_link.Name = "Input_link";
            this.Input_link.Size = new System.Drawing.Size(500, 36);
            this.Input_link.TabIndex = 14;
            this.Input_link.Visible = false;
            // 
            // Input_user
            // 
            this.Input_user.Location = new System.Drawing.Point(398, 621);
            this.Input_user.Name = "Input_user";
            this.Input_user.Size = new System.Drawing.Size(500, 36);
            this.Input_user.TabIndex = 15;
            this.Input_user.Visible = false;
            // 
            // Input_password
            // 
            this.Input_password.Location = new System.Drawing.Point(398, 697);
            this.Input_password.Name = "Input_password";
            this.Input_password.Size = new System.Drawing.Size(500, 36);
            this.Input_password.TabIndex = 16;
            this.Input_password.Visible = false;
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(652, 774);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(103, 45);
            this.Insert.TabIndex = 17;
            this.Insert.Text = "新增";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Visible = false;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(785, 774);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(101, 45);
            this.Delete.TabIndex = 18;
            this.Delete.Text = "刪除";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Visible = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 831);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.Input_password);
            this.Controls.Add(this.Input_user);
            this.Controls.Add(this.Input_link);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.Status_Column);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ins_del_button);
            this.Controls.Add(this.Risk_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Input_bar);
            this.Controls.Add(this.Search_butten);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        private Label label1;
        private Button Search_butten;
        private TextBox Input_bar;
        private Label label2;
        private Button Risk_button;
        private Button ins_del_button;
        private Label label3;
        private Label Result;
        private Label Status_Column;
        private Label lblLink;
        private Label lblUser;
        private Label lblPassword;
        private TextBox Input_link;
        private TextBox Input_user;
        private TextBox Input_password;
        private Button Insert;
        private Button Delete;
    }
}

