﻿namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.chatBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.remote = new System.Windows.Forms.TextBox();
            this.local = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(52, 433);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(583, 137);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // chatBox
            // 
            this.chatBox.Location = new System.Drawing.Point(52, 26);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(583, 369);
            this.chatBox.TabIndex = 1;
            this.chatBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(689, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 137);
            this.button1.TabIndex = 2;
            this.button1.Text = "send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(689, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 26);
            this.button2.TabIndex = 3;
            this.button2.Text = "Connect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // remote
            // 
            this.remote.Location = new System.Drawing.Point(689, 210);
            this.remote.Name = "remote";
            this.remote.Size = new System.Drawing.Size(246, 21);
            this.remote.TabIndex = 4;
            // 
            // local
            // 
            this.local.Location = new System.Drawing.Point(689, 36);
            this.local.Name = "local";
            this.local.Size = new System.Drawing.Size(246, 21);
            this.local.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(689, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(246, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Listen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(689, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(691, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 598);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.local);
            this.Controls.Add(this.remote);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox chatBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox remote;
        private System.Windows.Forms.TextBox local;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

