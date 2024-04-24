namespace SerialPortExample
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_port = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.but_ReadData = new System.Windows.Forms.Button();
            this.lab_readData = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_SN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_CONF2 = new System.Windows.Forms.TextBox();
            this.but_Default = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.text_CONF1 = new System.Windows.Forms.TextBox();
            this.but_EditLimit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.text_Read_G = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.text_IP = new System.Windows.Forms.TextBox();
            this.text_Read_B = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.text_Read_IR = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.text_Read_R = new System.Windows.Forms.TextBox();
            this.lab_OKNG = new System.Windows.Forms.Label();
            this.paramSet_RMIN = new System.Windows.Forms.TextBox();
            this.paramSet_GMIN = new System.Windows.Forms.TextBox();
            this.paramSet_BMIN = new System.Windows.Forms.TextBox();
            this.paramSet_IRMIN = new System.Windows.Forms.TextBox();
            this.paramSet_RMAX = new System.Windows.Forms.TextBox();
            this.paramSet_GMAX = new System.Windows.Forms.TextBox();
            this.paramSet_BMAX = new System.Windows.Forms.TextBox();
            this.paramSet_IRMAX = new System.Windows.Forms.TextBox();
            this.but_Lock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 355);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "连接";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_port
            // 
            this.cmb_port.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_port.FormattingEnabled = true;
            this.cmb_port.Location = new System.Drawing.Point(433, 369);
            this.cmb_port.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_port.Name = "cmb_port";
            this.cmb_port.Size = new System.Drawing.Size(158, 28);
            this.cmb_port.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(322, 374);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "端口号:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(942, 353);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 59);
            this.button2.TabIndex = 0;
            this.button2.Text = "断开";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // but_ReadData
            // 
            this.but_ReadData.Location = new System.Drawing.Point(1228, 353);
            this.but_ReadData.Margin = new System.Windows.Forms.Padding(4);
            this.but_ReadData.Name = "but_ReadData";
            this.but_ReadData.Size = new System.Drawing.Size(138, 59);
            this.but_ReadData.TabIndex = 0;
            this.but_ReadData.Text = "读取数据";
            this.but_ReadData.UseVisualStyleBackColor = true;
            this.but_ReadData.Click += new System.EventHandler(this.button3_Click);
            // 
            // lab_readData
            // 
            this.lab_readData.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_readData.Location = new System.Drawing.Point(27, 22);
            this.lab_readData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_readData.Name = "lab_readData";
            this.lab_readData.Size = new System.Drawing.Size(277, 47);
            this.lab_readData.TabIndex = 3;
            this.lab_readData.Text = "null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(267, 300);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "SN:";
            // 
            // textBox_SN
            // 
            this.textBox_SN.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_SN.Location = new System.Drawing.Point(331, 291);
            this.textBox_SN.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_SN.Name = "textBox_SN";
            this.textBox_SN.Size = new System.Drawing.Size(1206, 42);
            this.textBox_SN.TabIndex = 4;
            this.textBox_SN.Text = "111";
            this.textBox_SN.Click += new System.EventHandler(this.textBox_SN_Click);
            this.textBox_SN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_SN_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(494, 445);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "RGB_CONFO(HEX)";
            // 
            // text_CONF2
            // 
            this.text_CONF2.Location = new System.Drawing.Point(1090, 442);
            this.text_CONF2.Name = "text_CONF2";
            this.text_CONF2.Size = new System.Drawing.Size(196, 30);
            this.text_CONF2.TabIndex = 5;
            this.text_CONF2.Text = "0x09";
            // 
            // but_Default
            // 
            this.but_Default.Location = new System.Drawing.Point(307, 436);
            this.but_Default.Margin = new System.Windows.Forms.Padding(4);
            this.but_Default.Name = "but_Default";
            this.but_Default.Size = new System.Drawing.Size(138, 39);
            this.but_Default.TabIndex = 0;
            this.but_Default.Text = "默认RGB CONF";
            this.but_Default.UseVisualStyleBackColor = true;
            this.but_Default.Click += new System.EventHandler(this.but_Default_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(921, 447);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "RGB_CONFO1(HEX)";
            // 
            // text_CONF1
            // 
            this.text_CONF1.Location = new System.Drawing.Point(663, 440);
            this.text_CONF1.Name = "text_CONF1";
            this.text_CONF1.Size = new System.Drawing.Size(196, 30);
            this.text_CONF1.TabIndex = 5;
            this.text_CONF1.Text = "0x30";
            // 
            // but_EditLimit
            // 
            this.but_EditLimit.Location = new System.Drawing.Point(251, 545);
            this.but_EditLimit.Margin = new System.Windows.Forms.Padding(4);
            this.but_EditLimit.Name = "but_EditLimit";
            this.but_EditLimit.Size = new System.Drawing.Size(144, 47);
            this.but_EditLimit.TabIndex = 0;
            this.but_EditLimit.Text = "编辑上下限";
            this.but_EditLimit.UseVisualStyleBackColor = true;
            this.but_EditLimit.Click += new System.EventHandler(this.but_EditLimit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(611, 507);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "G";
            // 
            // text_Read_G
            // 
            this.text_Read_G.Location = new System.Drawing.Point(661, 502);
            this.text_Read_G.Name = "text_Read_G";
            this.text_Read_G.ReadOnly = true;
            this.text_Read_G.Size = new System.Drawing.Size(150, 30);
            this.text_Read_G.TabIndex = 5;
            this.text_Read_G.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(410, 507);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "R";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(1224, 507);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "IP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(812, 507);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "B";
            // 
            // text_IP
            // 
            this.text_IP.Location = new System.Drawing.Point(1284, 502);
            this.text_IP.Name = "text_IP";
            this.text_IP.ReadOnly = true;
            this.text_IP.Size = new System.Drawing.Size(150, 30);
            this.text_IP.TabIndex = 5;
            this.text_IP.Text = "0";
            // 
            // text_Read_B
            // 
            this.text_Read_B.Location = new System.Drawing.Point(862, 504);
            this.text_Read_B.Name = "text_Read_B";
            this.text_Read_B.ReadOnly = true;
            this.text_Read_B.Size = new System.Drawing.Size(150, 30);
            this.text_Read_B.TabIndex = 5;
            this.text_Read_B.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(1013, 507);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "IR";
            // 
            // text_Read_IR
            // 
            this.text_Read_IR.Location = new System.Drawing.Point(1073, 504);
            this.text_Read_IR.Name = "text_Read_IR";
            this.text_Read_IR.ReadOnly = true;
            this.text_Read_IR.Size = new System.Drawing.Size(150, 30);
            this.text_Read_IR.TabIndex = 5;
            this.text_Read_IR.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(255, 621);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "R-MIN:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(255, 726);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "B-MIN:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(255, 674);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "G-MIN:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(245, 785);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "IR-MIN:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(906, 616);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "R-MAX:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(906, 729);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "B-MAX:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(906, 667);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 20);
            this.label16.TabIndex = 2;
            this.label16.Text = "G-MAX:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(896, 785);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 20);
            this.label17.TabIndex = 2;
            this.label17.Text = "IR-MAX:";
            // 
            // text_Read_R
            // 
            this.text_Read_R.Location = new System.Drawing.Point(460, 502);
            this.text_Read_R.Name = "text_Read_R";
            this.text_Read_R.ReadOnly = true;
            this.text_Read_R.Size = new System.Drawing.Size(150, 30);
            this.text_Read_R.TabIndex = 5;
            this.text_Read_R.Text = "0";
            this.text_Read_R.WordWrap = false;
            // 
            // lab_OKNG
            // 
            this.lab_OKNG.AutoSize = true;
            this.lab_OKNG.Font = new System.Drawing.Font("宋体", 79.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_OKNG.ForeColor = System.Drawing.Color.Lime;
            this.lab_OKNG.Location = new System.Drawing.Point(793, 34);
            this.lab_OKNG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_OKNG.Name = "lab_OKNG";
            this.lab_OKNG.Size = new System.Drawing.Size(193, 133);
            this.lab_OKNG.TabIndex = 2;
            this.lab_OKNG.Text = "OK";
            // 
            // paramSet_RMIN
            // 
            this.paramSet_RMIN.Font = new System.Drawing.Font("宋体", 14F);
            this.paramSet_RMIN.Location = new System.Drawing.Point(331, 613);
            this.paramSet_RMIN.Name = "paramSet_RMIN";
            this.paramSet_RMIN.ReadOnly = true;
            this.paramSet_RMIN.Size = new System.Drawing.Size(551, 34);
            this.paramSet_RMIN.TabIndex = 5;
            this.paramSet_RMIN.Tag = "1";
            this.paramSet_RMIN.Text = "0";
            this.paramSet_RMIN.WordWrap = false;
            // 
            // paramSet_GMIN
            // 
            this.paramSet_GMIN.Font = new System.Drawing.Font("宋体", 14F);
            this.paramSet_GMIN.Location = new System.Drawing.Point(331, 668);
            this.paramSet_GMIN.Name = "paramSet_GMIN";
            this.paramSet_GMIN.ReadOnly = true;
            this.paramSet_GMIN.Size = new System.Drawing.Size(551, 34);
            this.paramSet_GMIN.TabIndex = 5;
            this.paramSet_GMIN.Tag = "1";
            this.paramSet_GMIN.Text = "0";
            this.paramSet_GMIN.WordWrap = false;
            // 
            // paramSet_BMIN
            // 
            this.paramSet_BMIN.Font = new System.Drawing.Font("宋体", 14F);
            this.paramSet_BMIN.Location = new System.Drawing.Point(331, 720);
            this.paramSet_BMIN.Name = "paramSet_BMIN";
            this.paramSet_BMIN.ReadOnly = true;
            this.paramSet_BMIN.Size = new System.Drawing.Size(551, 34);
            this.paramSet_BMIN.TabIndex = 5;
            this.paramSet_BMIN.Tag = "1";
            this.paramSet_BMIN.Text = "0";
            this.paramSet_BMIN.WordWrap = false;
            // 
            // paramSet_IRMIN
            // 
            this.paramSet_IRMIN.Font = new System.Drawing.Font("宋体", 14F);
            this.paramSet_IRMIN.Location = new System.Drawing.Point(331, 779);
            this.paramSet_IRMIN.Name = "paramSet_IRMIN";
            this.paramSet_IRMIN.ReadOnly = true;
            this.paramSet_IRMIN.Size = new System.Drawing.Size(551, 34);
            this.paramSet_IRMIN.TabIndex = 5;
            this.paramSet_IRMIN.Tag = "1";
            this.paramSet_IRMIN.Text = "0";
            this.paramSet_IRMIN.WordWrap = false;
            // 
            // paramSet_RMAX
            // 
            this.paramSet_RMAX.Font = new System.Drawing.Font("宋体", 14F);
            this.paramSet_RMAX.Location = new System.Drawing.Point(985, 610);
            this.paramSet_RMAX.Name = "paramSet_RMAX";
            this.paramSet_RMAX.ReadOnly = true;
            this.paramSet_RMAX.Size = new System.Drawing.Size(545, 34);
            this.paramSet_RMAX.TabIndex = 5;
            this.paramSet_RMAX.Tag = "1";
            this.paramSet_RMAX.Text = "1000";
            this.paramSet_RMAX.WordWrap = false;
            // 
            // paramSet_GMAX
            // 
            this.paramSet_GMAX.Font = new System.Drawing.Font("宋体", 14F);
            this.paramSet_GMAX.Location = new System.Drawing.Point(985, 667);
            this.paramSet_GMAX.Name = "paramSet_GMAX";
            this.paramSet_GMAX.ReadOnly = true;
            this.paramSet_GMAX.Size = new System.Drawing.Size(545, 34);
            this.paramSet_GMAX.TabIndex = 5;
            this.paramSet_GMAX.Tag = "1";
            this.paramSet_GMAX.Text = "1000";
            this.paramSet_GMAX.WordWrap = false;
            // 
            // paramSet_BMAX
            // 
            this.paramSet_BMAX.Font = new System.Drawing.Font("宋体", 14F);
            this.paramSet_BMAX.Location = new System.Drawing.Point(985, 720);
            this.paramSet_BMAX.Name = "paramSet_BMAX";
            this.paramSet_BMAX.ReadOnly = true;
            this.paramSet_BMAX.Size = new System.Drawing.Size(545, 34);
            this.paramSet_BMAX.TabIndex = 5;
            this.paramSet_BMAX.Tag = "1";
            this.paramSet_BMAX.Text = "1000";
            this.paramSet_BMAX.WordWrap = false;
            // 
            // paramSet_IRMAX
            // 
            this.paramSet_IRMAX.Font = new System.Drawing.Font("宋体", 14F);
            this.paramSet_IRMAX.Location = new System.Drawing.Point(985, 779);
            this.paramSet_IRMAX.Name = "paramSet_IRMAX";
            this.paramSet_IRMAX.ReadOnly = true;
            this.paramSet_IRMAX.Size = new System.Drawing.Size(545, 34);
            this.paramSet_IRMAX.TabIndex = 5;
            this.paramSet_IRMAX.Tag = "1";
            this.paramSet_IRMAX.Text = "1000";
            this.paramSet_IRMAX.WordWrap = false;
            // 
            // but_Lock
            // 
            this.but_Lock.Location = new System.Drawing.Point(419, 545);
            this.but_Lock.Margin = new System.Windows.Forms.Padding(4);
            this.but_Lock.Name = "but_Lock";
            this.but_Lock.Size = new System.Drawing.Size(144, 47);
            this.but_Lock.TabIndex = 0;
            this.but_Lock.Text = "锁定";
            this.but_Lock.UseVisualStyleBackColor = true;
            this.but_Lock.Click += new System.EventHandler(this.but_Lock_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1842, 966);
            this.Controls.Add(this.text_Read_B);
            this.Controls.Add(this.text_Read_IR);
            this.Controls.Add(this.text_IP);
            this.Controls.Add(this.paramSet_IRMAX);
            this.Controls.Add(this.paramSet_IRMIN);
            this.Controls.Add(this.paramSet_BMAX);
            this.Controls.Add(this.paramSet_BMIN);
            this.Controls.Add(this.paramSet_GMAX);
            this.Controls.Add(this.paramSet_RMAX);
            this.Controls.Add(this.paramSet_GMIN);
            this.Controls.Add(this.paramSet_RMIN);
            this.Controls.Add(this.text_Read_R);
            this.Controls.Add(this.text_Read_G);
            this.Controls.Add(this.text_CONF1);
            this.Controls.Add(this.text_CONF2);
            this.Controls.Add(this.textBox_SN);
            this.Controls.Add(this.lab_readData);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lab_OKNG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_port);
            this.Controls.Add(this.but_Lock);
            this.Controls.Add(this.but_EditLimit);
            this.Controls.Add(this.but_Default);
            this.Controls.Add(this.but_ReadData);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Winform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button but_ReadData;
        private System.Windows.Forms.Label lab_readData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_SN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_CONF2;
        private System.Windows.Forms.Button but_Default;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_CONF1;
        private System.Windows.Forms.Button but_EditLimit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_Read_G;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_IP;
        private System.Windows.Forms.TextBox text_Read_B;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox text_Read_IR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox text_Read_R;
        private System.Windows.Forms.Label lab_OKNG;
        private System.Windows.Forms.TextBox paramSet_RMIN;
        private System.Windows.Forms.TextBox paramSet_GMIN;
        private System.Windows.Forms.TextBox paramSet_BMIN;
        private System.Windows.Forms.TextBox paramSet_IRMIN;
        private System.Windows.Forms.TextBox paramSet_RMAX;
        private System.Windows.Forms.TextBox paramSet_GMAX;
        private System.Windows.Forms.TextBox paramSet_BMAX;
        private System.Windows.Forms.TextBox paramSet_IRMAX;
        private System.Windows.Forms.Button but_Lock;
    }
}

