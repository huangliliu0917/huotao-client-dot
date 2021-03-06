﻿namespace HotTao.Controls
{
    partial class CustomSendControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileImage = new System.Windows.Forms.OpenFileDialog();
            this.openFileVideo = new System.Windows.Forms.OpenFileDialog();
            this.hotPanel1 = new HotTao.Controls.module.HotPanel(this.components);
            this.hotGroupBox1 = new HotTao.Controls.module.HotGroupBox(this.components);
            this.lbMsg = new System.Windows.Forms.Label();
            this.lkbAllSelected = new System.Windows.Forms.LinkLabel();
            this.lkbRefresh = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbWeChat = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartSend = new System.Windows.Forms.Button();
            this.hotGroupBox4 = new HotTao.Controls.module.HotGroupBox(this.components);
            this.txtVideoPath = new System.Windows.Forms.RichTextBox();
            this.hotGroupBox3 = new HotTao.Controls.module.HotGroupBox(this.components);
            this.txtPicPath = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStartTask = new System.Windows.Forms.Button();
            this.hotGroupBox2 = new HotTao.Controls.module.HotGroupBox(this.components);
            this.txtTempText = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.hotPanel1.SuspendLayout();
            this.hotGroupBox1.SuspendLayout();
            this.hotGroupBox4.SuspendLayout();
            this.hotGroupBox3.SuspendLayout();
            this.hotGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileImage
            // 
            this.openFileImage.Filter = "图像文件(*.jpg;*jpeg;*.png;*.bmp)|*.jpg;*jpeg;*.png;*.bmp";
            // 
            // openFileVideo
            // 
            this.openFileVideo.Filter = "MP4文件(*.mp4;*.gif)|*.mp4;*.gif";
            // 
            // hotPanel1
            // 
            this.hotPanel1.BackColor = System.Drawing.Color.White;
            this.hotPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.hotPanel1.Controls.Add(this.hotGroupBox1);
            this.hotPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hotPanel1.Location = new System.Drawing.Point(0, 0);
            this.hotPanel1.Name = "hotPanel1";
            this.hotPanel1.Size = new System.Drawing.Size(920, 606);
            this.hotPanel1.TabIndex = 0;
            // 
            // hotGroupBox1
            // 
            this.hotGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.hotGroupBox1.BorderTitleColor = System.Drawing.Color.Black;
            this.hotGroupBox1.Controls.Add(this.lbMsg);
            this.hotGroupBox1.Controls.Add(this.lkbAllSelected);
            this.hotGroupBox1.Controls.Add(this.lkbRefresh);
            this.hotGroupBox1.Controls.Add(this.label6);
            this.hotGroupBox1.Controls.Add(this.lbWeChat);
            this.hotGroupBox1.Controls.Add(this.label5);
            this.hotGroupBox1.Controls.Add(this.label4);
            this.hotGroupBox1.Controls.Add(this.label3);
            this.hotGroupBox1.Controls.Add(this.label2);
            this.hotGroupBox1.Controls.Add(this.label1);
            this.hotGroupBox1.Controls.Add(this.btnStartSend);
            this.hotGroupBox1.Controls.Add(this.hotGroupBox4);
            this.hotGroupBox1.Controls.Add(this.hotGroupBox3);
            this.hotGroupBox1.Controls.Add(this.button1);
            this.hotGroupBox1.Controls.Add(this.btnStartTask);
            this.hotGroupBox1.Controls.Add(this.hotGroupBox2);
            this.hotGroupBox1.Controls.Add(this.label9);
            this.hotGroupBox1.Controls.Add(this.label11);
            this.hotGroupBox1.Location = new System.Drawing.Point(6, 6);
            this.hotGroupBox1.Name = "hotGroupBox1";
            this.hotGroupBox1.Size = new System.Drawing.Size(907, 593);
            this.hotGroupBox1.TabIndex = 34;
            this.hotGroupBox1.TabStop = false;
            // 
            // lbMsg
            // 
            this.lbMsg.ForeColor = System.Drawing.Color.Red;
            this.lbMsg.Location = new System.Drawing.Point(714, 452);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(180, 23);
            this.lbMsg.TabIndex = 51;
            this.lbMsg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lkbAllSelected
            // 
            this.lkbAllSelected.AutoSize = true;
            this.lkbAllSelected.Location = new System.Drawing.Point(577, 401);
            this.lkbAllSelected.Name = "lkbAllSelected";
            this.lkbAllSelected.Size = new System.Drawing.Size(29, 12);
            this.lkbAllSelected.TabIndex = 50;
            this.lkbAllSelected.TabStop = true;
            this.lkbAllSelected.Text = "全选";
            this.lkbAllSelected.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbAllSelected_LinkClicked);
            // 
            // lkbRefresh
            // 
            this.lkbRefresh.AutoSize = true;
            this.lkbRefresh.Location = new System.Drawing.Point(613, 401);
            this.lkbRefresh.Name = "lkbRefresh";
            this.lkbRefresh.Size = new System.Drawing.Size(29, 12);
            this.lkbRefresh.TabIndex = 50;
            this.lkbRefresh.TabStop = true;
            this.lkbRefresh.Text = "刷新";
            this.lkbRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbRefresh_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(506, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 49;
            this.label6.Text = "群窗口列表";
            // 
            // lbWeChat
            // 
            this.lbWeChat.FormattingEnabled = true;
            this.lbWeChat.ItemHeight = 12;
            this.lbWeChat.Location = new System.Drawing.Point(507, 417);
            this.lbWeChat.Name = "lbWeChat";
            this.lbWeChat.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbWeChat.Size = new System.Drawing.Size(152, 172);
            this.lbWeChat.Sorted = true;
            this.lbWeChat.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 567);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 12);
            this.label5.TabIndex = 47;
            this.label5.Text = "发送顺序，文本内容》图片》视频";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 543);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 12);
            this.label4.TabIndex = 47;
            this.label4.Text = "发送目标当前拖出来的微信单独窗口";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 12);
            this.label3.TabIndex = 47;
            this.label3.Text = "自定义发送，如果为空，则不发。";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 46;
            this.label2.Text = "可选";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 46;
            this.label1.Text = "可选";
            // 
            // btnStartSend
            // 
            this.btnStartSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(158)))));
            this.btnStartSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartSend.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnStartSend.FlatAppearance.BorderSize = 0;
            this.btnStartSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartSend.ForeColor = System.Drawing.Color.White;
            this.btnStartSend.Location = new System.Drawing.Point(803, 404);
            this.btnStartSend.Name = "btnStartSend";
            this.btnStartSend.Size = new System.Drawing.Size(91, 34);
            this.btnStartSend.TabIndex = 45;
            this.btnStartSend.Text = "开始发送";
            this.btnStartSend.UseVisualStyleBackColor = false;
            this.btnStartSend.Click += new System.EventHandler(this.btnStartSend_Click);
            // 
            // hotGroupBox4
            // 
            this.hotGroupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.hotGroupBox4.BorderColor = System.Drawing.Color.Gainsboro;
            this.hotGroupBox4.BorderTitleColor = System.Drawing.Color.Black;
            this.hotGroupBox4.Controls.Add(this.txtVideoPath);
            this.hotGroupBox4.Location = new System.Drawing.Point(94, 462);
            this.hotGroupBox4.Name = "hotGroupBox4";
            this.hotGroupBox4.Size = new System.Drawing.Size(356, 40);
            this.hotGroupBox4.TabIndex = 44;
            this.hotGroupBox4.TabStop = false;
            // 
            // txtVideoPath
            // 
            this.txtVideoPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.txtVideoPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVideoPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVideoPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtVideoPath.Location = new System.Drawing.Point(3, 17);
            this.txtVideoPath.Multiline = false;
            this.txtVideoPath.Name = "txtVideoPath";
            this.txtVideoPath.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtVideoPath.Size = new System.Drawing.Size(350, 20);
            this.txtVideoPath.TabIndex = 26;
            this.txtVideoPath.Text = "";
            // 
            // hotGroupBox3
            // 
            this.hotGroupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.hotGroupBox3.BorderColor = System.Drawing.Color.Gainsboro;
            this.hotGroupBox3.BorderTitleColor = System.Drawing.Color.Black;
            this.hotGroupBox3.Controls.Add(this.txtPicPath);
            this.hotGroupBox3.Location = new System.Drawing.Point(95, 399);
            this.hotGroupBox3.Name = "hotGroupBox3";
            this.hotGroupBox3.Size = new System.Drawing.Size(355, 40);
            this.hotGroupBox3.TabIndex = 44;
            this.hotGroupBox3.TabStop = false;
            // 
            // txtPicPath
            // 
            this.txtPicPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.txtPicPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPicPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPicPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtPicPath.Location = new System.Drawing.Point(3, 17);
            this.txtPicPath.Multiline = false;
            this.txtPicPath.Name = "txtPicPath";
            this.txtPicPath.ReadOnly = true;
            this.txtPicPath.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtPicPath.Size = new System.Drawing.Size(349, 20);
            this.txtPicPath.TabIndex = 26;
            this.txtPicPath.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(216)))), ((int)(((byte)(106)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(216)))), ((int)(((byte)(106)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(216)))), ((int)(((byte)(106)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(183)))), ((int)(((byte)(89)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(9, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 29);
            this.button1.TabIndex = 43;
            this.button1.Tag = "video";
            this.button1.Text = "上传视频";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnStartTask
            // 
            this.btnStartTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(216)))), ((int)(((byte)(106)))));
            this.btnStartTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartTask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(216)))), ((int)(((byte)(106)))));
            this.btnStartTask.FlatAppearance.BorderSize = 0;
            this.btnStartTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(216)))), ((int)(((byte)(106)))));
            this.btnStartTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(183)))), ((int)(((byte)(89)))));
            this.btnStartTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartTask.ForeColor = System.Drawing.Color.White;
            this.btnStartTask.Location = new System.Drawing.Point(9, 409);
            this.btnStartTask.Name = "btnStartTask";
            this.btnStartTask.Size = new System.Drawing.Size(79, 29);
            this.btnStartTask.TabIndex = 43;
            this.btnStartTask.Tag = "pic";
            this.btnStartTask.Text = "上传图片";
            this.btnStartTask.UseVisualStyleBackColor = false;
            this.btnStartTask.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // hotGroupBox2
            // 
            this.hotGroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.hotGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.hotGroupBox2.BorderTitleColor = System.Drawing.Color.Black;
            this.hotGroupBox2.Controls.Add(this.txtTempText);
            this.hotGroupBox2.Location = new System.Drawing.Point(9, 39);
            this.hotGroupBox2.Name = "hotGroupBox2";
            this.hotGroupBox2.Size = new System.Drawing.Size(888, 355);
            this.hotGroupBox2.TabIndex = 34;
            this.hotGroupBox2.TabStop = false;
            // 
            // txtTempText
            // 
            this.txtTempText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.txtTempText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTempText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTempText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtTempText.Location = new System.Drawing.Point(3, 17);
            this.txtTempText.Name = "txtTempText";
            this.txtTempText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtTempText.Size = new System.Drawing.Size(882, 335);
            this.txtTempText.TabIndex = 26;
            this.txtTempText.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(158)))));
            this.label9.Location = new System.Drawing.Point(407, -1);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(5);
            this.label9.Size = new System.Drawing.Size(80, 22);
            this.label9.TabIndex = 33;
            this.label9.Text = "自定义发送";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(12, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 12);
            this.label11.TabIndex = 27;
            this.label11.Text = "自定义发送内容：";
            // 
            // CustomSendControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hotPanel1);
            this.Name = "CustomSendControl";
            this.Size = new System.Drawing.Size(920, 606);
            this.Load += new System.EventHandler(this.CustomSendControl_Load);
            this.hotPanel1.ResumeLayout(false);
            this.hotGroupBox1.ResumeLayout(false);
            this.hotGroupBox1.PerformLayout();
            this.hotGroupBox4.ResumeLayout(false);
            this.hotGroupBox3.ResumeLayout(false);
            this.hotGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private module.HotPanel hotPanel1;
        private module.HotGroupBox hotGroupBox1;
        private module.HotGroupBox hotGroupBox2;
        private System.Windows.Forms.RichTextBox txtTempText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnStartTask;
        private module.HotGroupBox hotGroupBox3;
        private System.Windows.Forms.RichTextBox txtPicPath;
        private System.Windows.Forms.OpenFileDialog openFileImage;
        private System.Windows.Forms.OpenFileDialog openFileVideo;
        private System.Windows.Forms.Button button1;
        private module.HotGroupBox hotGroupBox4;
        private System.Windows.Forms.RichTextBox txtVideoPath;
        private System.Windows.Forms.Button btnStartSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbWeChat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel lkbRefresh;
        private System.Windows.Forms.LinkLabel lkbAllSelected;
        private System.Windows.Forms.Label lbMsg;
    }
}
