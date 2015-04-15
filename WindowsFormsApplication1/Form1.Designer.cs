namespace WindowsFormsApplication1
{
    partial class ChatExample
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
            this.send_message = new System.Windows.Forms.Button();
            this.client_connect = new System.Windows.Forms.Button();
            this.remote = new System.Windows.Forms.TextBox();
            this.local = new System.Windows.Forms.TextBox();
            this.server_listen = new System.Windows.Forms.Button();
            this.server_status = new System.Windows.Forms.Label();
            this.client_status = new System.Windows.Forms.Label();
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
            // send_message
            // 
            this.send_message.Location = new System.Drawing.Point(689, 433);
            this.send_message.Name = "send_message";
            this.send_message.Size = new System.Drawing.Size(246, 137);
            this.send_message.TabIndex = 2;
            this.send_message.Text = "send";
            this.send_message.UseVisualStyleBackColor = true;
            this.send_message.Click += new System.EventHandler(this.send_message_Click);
            // 
            // client_connect
            // 
            this.client_connect.Location = new System.Drawing.Point(689, 255);
            this.client_connect.Name = "client_connect";
            this.client_connect.Size = new System.Drawing.Size(246, 26);
            this.client_connect.TabIndex = 3;
            this.client_connect.Text = "Connect";
            this.client_connect.UseVisualStyleBackColor = true;
            this.client_connect.Click += new System.EventHandler(this.client_connect_Click);
            // 
            // remote
            // 
            this.remote.Location = new System.Drawing.Point(689, 210);
            this.remote.Name = "remote";
            this.remote.Size = new System.Drawing.Size(246, 21);
            this.remote.TabIndex = 4;
            this.remote.Text = "127.0.0.1";
            // 
            // local
            // 
            this.local.Location = new System.Drawing.Point(689, 36);
            this.local.Name = "local";
            this.local.Size = new System.Drawing.Size(246, 21);
            this.local.TabIndex = 5;
            this.local.Text = "127.0.0.1";
            // 
            // server_listen
            // 
            this.server_listen.Location = new System.Drawing.Point(689, 75);
            this.server_listen.Name = "server_listen";
            this.server_listen.Size = new System.Drawing.Size(246, 23);
            this.server_listen.TabIndex = 6;
            this.server_listen.Text = "Listen";
            this.server_listen.UseVisualStyleBackColor = true;
            this.server_listen.Click += new System.EventHandler(this.server_listen_Click);
            // 
            // server_status
            // 
            this.server_status.AutoSize = true;
            this.server_status.Location = new System.Drawing.Point(689, 116);
            this.server_status.Name = "server_status";
            this.server_status.Size = new System.Drawing.Size(191, 12);
            this.server_status.TabIndex = 7;
            this.server_status.Text = "pass server ip and start listen";
            // 
            // client_status
            // 
            this.client_status.AutoSize = true;
            this.client_status.Location = new System.Drawing.Point(691, 303);
            this.client_status.Name = "client_status";
            this.client_status.Size = new System.Drawing.Size(167, 12);
            this.client_status.TabIndex = 8;
            this.client_status.Text = "pass a server ip to connect";
            // 
            // ChatExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 598);
            this.Controls.Add(this.client_status);
            this.Controls.Add(this.server_status);
            this.Controls.Add(this.server_listen);
            this.Controls.Add(this.local);
            this.Controls.Add(this.remote);
            this.Controls.Add(this.client_connect);
            this.Controls.Add(this.send_message);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.richTextBox1);
            this.Name = "ChatExample";
            this.Text = "Chat Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox chatBox;
        private System.Windows.Forms.Button send_message;
        private System.Windows.Forms.Button client_connect;
        private System.Windows.Forms.TextBox remote;
        private System.Windows.Forms.TextBox local;
        private System.Windows.Forms.Button server_listen;
        private System.Windows.Forms.Label server_status;
        private System.Windows.Forms.Label client_status;
    }
}

