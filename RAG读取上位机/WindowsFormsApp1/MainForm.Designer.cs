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
            this.but_ReadData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_SN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_CONF2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_CONF1 = new System.Windows.Forms.TextBox();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.编辑配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.锁定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.锁定ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_Device = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(399, 251);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "连接";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_port
            // 
            this.cmb_port.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmb_port.Enabled = false;
            this.cmb_port.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_port.FormattingEnabled = true;
            this.cmb_port.Location = new System.Drawing.Point(200, 256);
            this.cmb_port.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_port.Name = "cmb_port";
            this.cmb_port.Size = new System.Drawing.Size(158, 24);
            this.cmb_port.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(89, 261);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "端口号:";
            // 
            // but_ReadData
            // 
            this.but_ReadData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.but_ReadData.Location = new System.Drawing.Point(705, 238);
            this.but_ReadData.Margin = new System.Windows.Forms.Padding(4);
            this.but_ReadData.Name = "but_ReadData";
            this.but_ReadData.Size = new System.Drawing.Size(628, 59);
            this.but_ReadData.TabIndex = 0;
            this.but_ReadData.Text = "读取数据";
            this.but_ReadData.UseVisualStyleBackColor = true;
            this.but_ReadData.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(63, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "SN:";
            // 
            // textBox_SN
            // 
            this.textBox_SN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox_SN.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_SN.Location = new System.Drawing.Point(127, 174);
            this.textBox_SN.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_SN.Name = "textBox_SN";
            this.textBox_SN.Size = new System.Drawing.Size(1206, 35);
            this.textBox_SN.TabIndex = 4;
            this.textBox_SN.Click += new System.EventHandler(this.textBox_SN_Click);
            this.textBox_SN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_SN_KeyDown);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(542, 334);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "RGB_CONFO(HEX)";
            // 
            // text_CONF2
            // 
            this.text_CONF2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.text_CONF2.Location = new System.Drawing.Point(1133, 331);
            this.text_CONF2.Name = "text_CONF2";
            this.text_CONF2.ReadOnly = true;
            this.text_CONF2.Size = new System.Drawing.Size(196, 26);
            this.text_CONF2.TabIndex = 5;
            this.text_CONF2.Text = "0x09";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(969, 336);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "RGB_CONFO1(HEX)";
            // 
            // text_CONF1
            // 
            this.text_CONF1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.text_CONF1.Location = new System.Drawing.Point(706, 329);
            this.text_CONF1.Name = "text_CONF1";
            this.text_CONF1.ReadOnly = true;
            this.text_CONF1.Size = new System.Drawing.Size(196, 26);
            this.text_CONF1.TabIndex = 5;
            this.text_CONF1.Text = "0x30";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(314, 409);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "G";
            // 
            // text_Read_G
            // 
            this.text_Read_G.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.text_Read_G.Location = new System.Drawing.Point(376, 404);
            this.text_Read_G.Name = "text_Read_G";
            this.text_Read_G.ReadOnly = true;
            this.text_Read_G.Size = new System.Drawing.Size(150, 26);
            this.text_Read_G.TabIndex = 5;
            this.text_Read_G.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(55, 411);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "R";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(1099, 411);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "ID";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(573, 409);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "B";
            // 
            // text_IP
            // 
            this.text_IP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.text_IP.Location = new System.Drawing.Point(1169, 406);
            this.text_IP.Name = "text_IP";
            this.text_IP.ReadOnly = true;
            this.text_IP.Size = new System.Drawing.Size(150, 26);
            this.text_IP.TabIndex = 5;
            this.text_IP.Text = "0";
            // 
            // text_Read_B
            // 
            this.text_Read_B.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.text_Read_B.Location = new System.Drawing.Point(635, 406);
            this.text_Read_B.Name = "text_Read_B";
            this.text_Read_B.ReadOnly = true;
            this.text_Read_B.Size = new System.Drawing.Size(150, 26);
            this.text_Read_B.TabIndex = 5;
            this.text_Read_B.Text = "0";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(832, 409);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "IR";
            // 
            // text_Read_IR
            // 
            this.text_Read_IR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.text_Read_IR.Location = new System.Drawing.Point(902, 406);
            this.text_Read_IR.Name = "text_Read_IR";
            this.text_Read_IR.ReadOnly = true;
            this.text_Read_IR.Size = new System.Drawing.Size(150, 26);
            this.text_Read_IR.TabIndex = 5;
            this.text_Read_IR.Text = "0";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(51, 504);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "R-MIN:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(51, 609);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "B-MIN:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(51, 557);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "G-MIN:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(41, 668);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "IR-MIN:";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(702, 499);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 16);
            this.label14.TabIndex = 2;
            this.label14.Text = "R-MAX:";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(702, 612);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 16);
            this.label15.TabIndex = 2;
            this.label15.Text = "B-MAX:";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(702, 550);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 16);
            this.label16.TabIndex = 2;
            this.label16.Text = "G-MAX:";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(692, 668);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 16);
            this.label17.TabIndex = 2;
            this.label17.Text = "IR-MAX:";
            // 
            // text_Read_R
            // 
            this.text_Read_R.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.text_Read_R.Location = new System.Drawing.Point(117, 406);
            this.text_Read_R.Name = "text_Read_R";
            this.text_Read_R.ReadOnly = true;
            this.text_Read_R.Size = new System.Drawing.Size(150, 26);
            this.text_Read_R.TabIndex = 5;
            this.text_Read_R.Text = "0";
            this.text_Read_R.WordWrap = false;
            // 
            // lab_OKNG
            // 
            this.lab_OKNG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lab_OKNG.AutoSize = true;
            this.lab_OKNG.Font = new System.Drawing.Font("宋体", 79.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_OKNG.ForeColor = System.Drawing.Color.Lime;
            this.lab_OKNG.Location = new System.Drawing.Point(593, 32);
            this.lab_OKNG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_OKNG.Name = "lab_OKNG";
            this.lab_OKNG.Size = new System.Drawing.Size(155, 107);
            this.lab_OKNG.TabIndex = 2;
            this.lab_OKNG.Text = "OK";
            // 
            // paramSet_RMIN
            // 
            this.paramSet_RMIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.paramSet_RMIN.Font = new System.Drawing.Font("宋体", 14F);
            this.paramSet_RMIN.Location = new System.Drawing.Point(127, 496);
            this.paramSet_RMIN.Name = "paramSet_RMIN";
            this.paramSet_RMIN.ReadOnly = true;
            this.paramSet_RMIN.Size = new System.Drawing.Size(551, 29);
            this.paramSet_RMIN.TabIndex = 5;
            this.paramSet_RMIN.Tag = "1";
            this.paramSet_RMIN.Text = "0";
            this.paramSet_RMIN.WordWrap = false;
            // 
            // paramSet_GMIN
            // 
            this.paramSet_GMIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.paramSet_GMIN.Font = new System.Drawing.Font("宋体", 14F);
            this.paramSet_GMIN.Location = new System.Drawing.Point(127, 551);
            this.paramSet_GMIN.Name = "paramSet_GMIN";
            this.paramSet_GMIN.ReadOnly = true;
            this.paramSet_GMIN.Size = new System.Drawing.Size(551, 29);
            this.paramSet_GMIN.TabIndex = 5;
            this.paramSet_GMIN.Tag = "1";
            this.paramSet_GMIN.Text = "0";
            this.paramSet_GMIN.WordWrap = false;
            // 
            // paramSet_BMIN
            // 
            this.paramSet_BMIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.paramSet_BMIN.Font = new System.Drawing.Font("宋体", 14F);
            this.paramSet_BMIN.Location = new System.Drawing.Point(127, 603);
            this.paramSet_BMIN.Name = "paramSet_BMIN";
            this.paramSet_BMIN.ReadOnly = true;
            this.paramSet_BMIN.Size = new System.Drawing.Size(551, 29);
            this.paramSet_BMIN.TabIndex = 5;
            this.paramSet_BMIN.Tag = "1";
            this.paramSet_BMIN.Text = "0";
            this.paramSet_BMIN.WordWrap = false;
            // 
            // paramSet_IRMIN
            // 
            this.paramSet_IRMIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.paramSet_IRMIN.Font = new System.Drawing.Font("宋体", 14F);
            this.paramSet_IRMIN.Location = new System.Drawing.Point(127, 662);
            this.paramSet_IRMIN.Name = "paramSet_IRMIN";
            this.paramSet_IRMIN.ReadOnly = true;
            this.paramSet_IRMIN.Size = new System.Drawing.Size(551, 29);
            this.paramSet_IRMIN.TabIndex = 5;
            this.paramSet_IRMIN.Tag = "1";
            this.paramSet_IRMIN.Text = "0";
            this.paramSet_IRMIN.WordWrap = false;
            // 
            // paramSet_RMAX
            // 
            this.paramSet_RMAX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.paramSet_RMAX.Font = new System.Drawing.Font("宋体", 14F);
            this.paramSet_RMAX.Location = new System.Drawing.Point(781, 493);
            this.paramSet_RMAX.Name = "paramSet_RMAX";
            this.paramSet_RMAX.ReadOnly = true;
            this.paramSet_RMAX.Size = new System.Drawing.Size(545, 29);
            this.paramSet_RMAX.TabIndex = 5;
            this.paramSet_RMAX.Tag = "1";
            this.paramSet_RMAX.Text = "1000";
            this.paramSet_RMAX.WordWrap = false;
            // 
            // paramSet_GMAX
            // 
            this.paramSet_GMAX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.paramSet_GMAX.Font = new System.Drawing.Font("宋体", 14F);
            this.paramSet_GMAX.Location = new System.Drawing.Point(781, 550);
            this.paramSet_GMAX.Name = "paramSet_GMAX";
            this.paramSet_GMAX.ReadOnly = true;
            this.paramSet_GMAX.Size = new System.Drawing.Size(545, 29);
            this.paramSet_GMAX.TabIndex = 5;
            this.paramSet_GMAX.Tag = "1";
            this.paramSet_GMAX.Text = "1000";
            this.paramSet_GMAX.WordWrap = false;
            // 
            // paramSet_BMAX
            // 
            this.paramSet_BMAX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.paramSet_BMAX.Font = new System.Drawing.Font("宋体", 14F);
            this.paramSet_BMAX.Location = new System.Drawing.Point(781, 603);
            this.paramSet_BMAX.Name = "paramSet_BMAX";
            this.paramSet_BMAX.ReadOnly = true;
            this.paramSet_BMAX.Size = new System.Drawing.Size(545, 29);
            this.paramSet_BMAX.TabIndex = 5;
            this.paramSet_BMAX.Tag = "1";
            this.paramSet_BMAX.Text = "1000";
            this.paramSet_BMAX.WordWrap = false;
            // 
            // paramSet_IRMAX
            // 
            this.paramSet_IRMAX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.paramSet_IRMAX.Font = new System.Drawing.Font("宋体", 14F);
            this.paramSet_IRMAX.Location = new System.Drawing.Point(781, 662);
            this.paramSet_IRMAX.Name = "paramSet_IRMAX";
            this.paramSet_IRMAX.ReadOnly = true;
            this.paramSet_IRMAX.Size = new System.Drawing.Size(545, 29);
            this.paramSet_IRMAX.TabIndex = 5;
            this.paramSet_IRMAX.Tag = "1";
            this.paramSet_IRMAX.Text = "1000";
            this.paramSet_IRMAX.WordWrap = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑配置ToolStripMenuItem,
            this.锁定ToolStripMenuItem,
            this.锁定ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1377, 29);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 编辑配置ToolStripMenuItem
            // 
            this.编辑配置ToolStripMenuItem.Name = "编辑配置ToolStripMenuItem";
            this.编辑配置ToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.编辑配置ToolStripMenuItem.Text = "编辑配置";
            this.编辑配置ToolStripMenuItem.Click += new System.EventHandler(this.编辑配置ToolStripMenuItem_Click);
            // 
            // 锁定ToolStripMenuItem
            // 
            this.锁定ToolStripMenuItem.Name = "锁定ToolStripMenuItem";
            this.锁定ToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.锁定ToolStripMenuItem.Text = "解锁";
            this.锁定ToolStripMenuItem.Click += new System.EventHandler(this.解锁ToolStripMenuItem_Click);
            // 
            // 锁定ToolStripMenuItem1
            // 
            this.锁定ToolStripMenuItem1.Name = "锁定ToolStripMenuItem1";
            this.锁定ToolStripMenuItem1.Size = new System.Drawing.Size(54, 25);
            this.锁定ToolStripMenuItem1.Text = "锁定";
            this.锁定ToolStripMenuItem1.Click += new System.EventHandler(this.锁定ToolStripMenuItem1_Click);
            // 
            // cmb_Device
            // 
            this.cmb_Device.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmb_Device.Enabled = false;
            this.cmb_Device.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_Device.FormattingEnabled = true;
            this.cmb_Device.Location = new System.Drawing.Point(200, 332);
            this.cmb_Device.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Device.Name = "cmb_Device";
            this.cmb_Device.Size = new System.Drawing.Size(158, 24);
            this.cmb_Device.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(41, 335);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 16);
            this.label18.TabIndex = 2;
            this.label18.Text = "设备配置参数:";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(399, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "配置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1377, 726);
            this.Controls.Add(this.button2);
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
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Device);
            this.Controls.Add(this.cmb_port);
            this.Controls.Add(this.but_ReadData);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Winform";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_ReadData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_SN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_CONF2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_CONF1;
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 编辑配置ToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmb_Device;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ToolStripMenuItem 锁定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 锁定ToolStripMenuItem1;
        private System.Windows.Forms.Button button2;
    }
}

