﻿namespace HslCommunicationDemo
{
    partial class FormOmronHostLinkCModeOverTcp
	{
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pipeSelectControl1 = new HslCommunicationDemo.DemoControl.PipeSelectControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userControlReadWriteDevice1 = new HslCommunicationDemo.DemoControl.UserControlReadWriteDevice();
            this.userControlHead1 = new HslCommunicationDemo.DemoControl.UserControlHead();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pipeSelectControl1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(3, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 65);
            this.panel1.TabIndex = 0;
            // 
            // pipeSelectControl1
            // 
            this.pipeSelectControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pipeSelectControl1.Location = new System.Drawing.Point(2, 3);
            this.pipeSelectControl1.Name = "pipeSelectControl1";
            this.pipeSelectControl1.SerialBaudRate = "9600";
            this.pipeSelectControl1.SerialDataBits = "8";
            this.pipeSelectControl1.SerialParity = System.IO.Ports.Parity.None;
            this.pipeSelectControl1.SerialStopBits = "1";
            this.pipeSelectControl1.SettingPipe = HslCommunicationDemo.DemoControl.SettingPipe.TcpPipe;
            this.pipeSelectControl1.Size = new System.Drawing.Size(790, 28);
            this.pipeSelectControl1.TabIndex = 41;
            this.pipeSelectControl1.TcpPortText = "2000";
            this.pipeSelectControl1.UdpPortText = "2000";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(31, 23);
            this.textBox1.TabIndex = 40;
            this.textBox1.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "站号：";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 25);
            this.comboBox1.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(898, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "关闭";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(801, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "连接";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.userControlReadWriteDevice1);
            this.panel2.Location = new System.Drawing.Point(3, 102);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(997, 540);
            this.panel2.TabIndex = 1;
            // 
            // userControlReadWriteDevice1
            // 
            this.userControlReadWriteDevice1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlReadWriteDevice1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userControlReadWriteDevice1.Location = new System.Drawing.Point(0, 0);
            this.userControlReadWriteDevice1.Name = "userControlReadWriteDevice1";
            this.userControlReadWriteDevice1.Size = new System.Drawing.Size(995, 538);
            this.userControlReadWriteDevice1.TabIndex = 0;
            // 
            // userControlHead1
            // 
            this.userControlHead1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userControlHead1.Dock = System.Windows.Forms.DockStyle.Top;
            this.userControlHead1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userControlHead1.HelpLink = "http://www.cnblogs.com/dathlin/p/7469679.html";
            this.userControlHead1.Location = new System.Drawing.Point(0, 0);
            this.userControlHead1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userControlHead1.MinimumSize = new System.Drawing.Size(800, 32);
            this.userControlHead1.Name = "userControlHead1";
            this.userControlHead1.ProtocolInfo = "Omron HostLink-CMode OverTcp";
            this.userControlHead1.Size = new System.Drawing.Size(1004, 32);
            this.userControlHead1.SupportListVisiable = true;
            this.userControlHead1.TabIndex = 2;
            this.userControlHead1.SaveConnectEvent += new System.EventHandler<System.EventArgs>(this.userControlHead1_SaveConnectEvent_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(234, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(571, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "当对地址D100.2 进行读写bool的时候，使用读字修改位、写字实现，实际使用可能存在风险，谨慎使用。";
            // 
            // FormOmronHostLinkCModeOverTcp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1004, 645);
            this.Controls.Add(this.userControlHead1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormOmronHostLinkCModeOverTcp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "欧姆龙PLC访问Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSiemens_FormClosing);
            this.Load += new System.EventHandler(this.FormSiemens_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private DemoControl.UserControlHead userControlHead1;
		private DemoControl.UserControlReadWriteDevice userControlReadWriteDevice1;
		private DemoControl.PipeSelectControl pipeSelectControl1;
        private System.Windows.Forms.Label label2;
    }
}