﻿namespace HslCommunicationDemo
{
    partial class FormModbusAscii
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
            this.checkBox_station_check = new System.Windows.Forms.CheckBox();
            this.pipeSelectControl1 = new HslCommunicationDemo.DemoControl.PipeSelectControl();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userControlReadWriteDevice1 = new HslCommunicationDemo.DemoControl.UserControlReadWriteDevice();
            this.userControlHead1 = new HslCommunicationDemo.DemoControl.UserControlHead();
            this.textBox_BroadcastStation = new System.Windows.Forms.TextBox();
            this.label_BroadcastStation = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox_BroadcastStation);
            this.panel1.Controls.Add(this.label_BroadcastStation);
            this.panel1.Controls.Add(this.checkBox_station_check);
            this.panel1.Controls.Add(this.pipeSelectControl1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.textBox15);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Location = new System.Drawing.Point(3, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 65);
            this.panel1.TabIndex = 0;
            // 
            // checkBox_station_check
            // 
            this.checkBox_station_check.AutoSize = true;
            this.checkBox_station_check.Checked = true;
            this.checkBox_station_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_station_check.Location = new System.Drawing.Point(569, 37);
            this.checkBox_station_check.Name = "checkBox_station_check";
            this.checkBox_station_check.Size = new System.Drawing.Size(106, 21);
            this.checkBox_station_check.TabIndex = 36;
            this.checkBox_station_check.Text = "Station Check";
            this.checkBox_station_check.UseVisualStyleBackColor = true;
            // 
            // pipeSelectControl1
            // 
            this.pipeSelectControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pipeSelectControl1.Location = new System.Drawing.Point(2, 4);
            this.pipeSelectControl1.Name = "pipeSelectControl1";
            this.pipeSelectControl1.SerialBaudRate = "9600";
            this.pipeSelectControl1.SerialDataBits = "8";
            this.pipeSelectControl1.SerialParity = System.IO.Ports.Parity.None;
            this.pipeSelectControl1.SerialStopBits = "1";
            this.pipeSelectControl1.SettingPipe = HslCommunicationDemo.DemoControl.SettingPipe.SerialPipe;
            this.pipeSelectControl1.Size = new System.Drawing.Size(793, 28);
            this.pipeSelectControl1.TabIndex = 28;
            this.pipeSelectControl1.TcpPortText = "502";
            this.pipeSelectControl1.UdpPortText = "502";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ABCD",
            "BADC",
            "CDAB",
            "DCBA"});
            this.comboBox2.Location = new System.Drawing.Point(119, 34);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(111, 25);
            this.comboBox2.TabIndex = 27;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(55, 35);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(37, 23);
            this.textBox15.TabIndex = 7;
            this.textBox15.Text = "1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(8, 38);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 17);
            this.label21.TabIndex = 6;
            this.label21.Text = "站号：";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(897, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "关闭串口";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(799, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "打开串口";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(270, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 21);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "首地址从0开始";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(432, 37);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(87, 21);
            this.checkBox3.TabIndex = 26;
            this.checkBox3.Text = "字符串颠倒";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.userControlReadWriteDevice1);
            this.panel2.Location = new System.Drawing.Point(3, 105);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(997, 537);
            this.panel2.TabIndex = 1;
            // 
            // userControlReadWriteDevice1
            // 
            this.userControlReadWriteDevice1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlReadWriteDevice1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userControlReadWriteDevice1.Location = new System.Drawing.Point(0, 0);
            this.userControlReadWriteDevice1.Name = "userControlReadWriteDevice1";
            this.userControlReadWriteDevice1.Size = new System.Drawing.Size(995, 535);
            this.userControlReadWriteDevice1.TabIndex = 0;
            // 
            // userControlHead1
            // 
            this.userControlHead1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userControlHead1.Dock = System.Windows.Forms.DockStyle.Top;
            this.userControlHead1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userControlHead1.HelpLink = "http://www.cnblogs.com/dathlin/p/8974215.html";
            this.userControlHead1.Location = new System.Drawing.Point(0, 0);
            this.userControlHead1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userControlHead1.MinimumSize = new System.Drawing.Size(800, 32);
            this.userControlHead1.Name = "userControlHead1";
            this.userControlHead1.ProtocolInfo = "Modbus Ascii";
            this.userControlHead1.Size = new System.Drawing.Size(1004, 32);
            this.userControlHead1.TabIndex = 2;
            this.userControlHead1.SaveConnectEvent += new System.EventHandler<System.EventArgs>(this.userControlHead1_SaveConnectEvent_1);
            // 
            // textBox_BroadcastStation
            // 
            this.textBox_BroadcastStation.Location = new System.Drawing.Point(782, 36);
            this.textBox_BroadcastStation.Name = "textBox_BroadcastStation";
            this.textBox_BroadcastStation.Size = new System.Drawing.Size(39, 23);
            this.textBox_BroadcastStation.TabIndex = 38;
            // 
            // label_BroadcastStation
            // 
            this.label_BroadcastStation.AutoSize = true;
            this.label_BroadcastStation.Location = new System.Drawing.Point(703, 39);
            this.label_BroadcastStation.Name = "label_BroadcastStation";
            this.label_BroadcastStation.Size = new System.Drawing.Size(59, 17);
            this.label_BroadcastStation.TabIndex = 37;
            this.label_BroadcastStation.Text = "广播站号:";
            // 
            // FormModbusAscii
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
            this.Name = "FormModbusAscii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modbus Ascii访问Demo";
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
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private DemoControl.UserControlHead userControlHead1;
		private DemoControl.UserControlReadWriteDevice userControlReadWriteDevice1;
		private DemoControl.PipeSelectControl pipeSelectControl1;
        private System.Windows.Forms.CheckBox checkBox_station_check;
        private System.Windows.Forms.TextBox textBox_BroadcastStation;
        private System.Windows.Forms.Label label_BroadcastStation;
    }
}