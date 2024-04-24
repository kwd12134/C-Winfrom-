using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;
using WindowsFormsApp1;
using thinger.DataConvertLib;
using System.Timers;
using ExendControl;

namespace SerialPortExample
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
            Initialize();
            storeTimer.Interval = 900;
            storeTimer.AutoReset = true;
            storeTimer.Elapsed += StoreTimer_Elapsed;
            storeTimer.Start();
            this.textBox_SN.TextChanged += TextBox_SN_TextChanged;
        }

        private void TextBox_SN_TextChanged(object sender, EventArgs e)
        {
            this.textBox_SN.ForeColor = Color.Black;
        }


        private void StoreTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            currentTimer = DateTime.Now.ToString("g").Replace("年", "-").Replace("月", "-").Replace("日", " ");

            Current_Variable = new List<string>(8) { currentTimer, this.textBox_SN.Text, this.text_Read_R.Text, this.text_Read_G.Text, this.text_Read_B.Text, this.text_Read_IR.Text, this.Text, this.lab_OKNG.Text };
        }

        public string currentTimer { get; set; }

        public bool IsOpen = false;

        private Helper helper = new Helper();


        private System.Timers.Timer storeTimer = new System.Timers.Timer();

        public string SN { get; set; }

        /// <summary>
        /// 日志
        /// </summary>
        private string VariableCsvFlie = Application.StartupPath + "\\Log\\" + DateTime.Now.ToString("yyyy-MM").Replace("年", "-").Replace("月", "-").Replace("日", " ") + "//" + DateTime.Now.ToString("m").Replace("年", "-").Replace("月", "-").Replace("日", " ") + ".csv";

        private string VariablePathFile = Application.StartupPath + "\\Log\\" + DateTime.Now.ToString("yyyy-MM").Replace("年", "-").Replace("月", "-").Replace("日", " ");

        private string Log_Path = Application.StartupPath + "Log";

        public List<string> Current_Variable = new List<string>(8);


        private bool OKNG;
        public bool OK_NG
        {
            get { return OKNG; }
            set
            {
                OKNG = value;
                if (!OKNG)
                {
                    this.lab_OKNG.ForeColor = Color.Red;
                    this.lab_OKNG.Text = "NG";
                }
                else
                {
                    this.lab_OKNG.ForeColor = Color.Green;
                    this.lab_OKNG.Text = "OK";
                }
            }
        }


        private void Initialize()
        {
            string[] PortName = SerialPort.GetPortNames();
            if (PortName.Length > 0)
            {
                this.cmb_port.Items.AddRange(PortName);
                this.cmb_port.SelectedIndex = 0;
                cmb_port.SelectedIndex = 1;
            }

        }
        /// <summary>
        /// 连接串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            IsOpen = helper.conncet(this.cmb_port.Text);
            if (IsOpen)
            {
                MessageBox.Show("连接成功");
                return;
            }
            else
            {
                MessageBox.Show("连接失败");
                return;
            }
        }
        /// <summary>
        /// 断开串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (IsOpen)
            {
                helper._SerialPort.Close();
                MessageBox.Show("成功断开");
                IsOpen = false;
                return;
            }
            else
            {
                MessageBox.Show("未连接");
                return;
            }
        }
        /// <summary>
        /// 读取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {

            if (this.textBox_SN.Text == "" && this.textBox_SN.Text == null)
            {
                MessageBox.Show("输入值为null，请检查");
                return;
            }

                string data = null;
            bool IsWrite = helper.WriteRuqire();
            int[] convetlData = null;
            if (IsWrite == false)
            {
                MessageBox.Show("请求失败");
                return;
            }

            else
            {
                data = helper.Result_Data();
                if (data == null)
                {
                    MessageBox.Show("返回值为null");
                    return;
                }
                this.lab_readData.Text = data;
            }

            convetlData = helper.ConvertHexStringToByteArray(data);
            if (convetlData.Length != 5)
            {
                MessageBox.Show("返回值为超出");
                return;
            }
            try
            {
                this.text_Read_R.Text = convetlData[0].ToString();
                this.text_Read_G.Text = convetlData[1].ToString();
                this.text_Read_B.Text = convetlData[2].ToString();
                this.text_Read_IR.Text = convetlData[3].ToString();
                this.text_IP.Text = convetlData[4].ToString();

                OK_NG = helper.Judge_OKorNG(Convert.ToInt32(this.paramSet_RMIN.Text), Convert.ToInt32(this.paramSet_RMAX.Text),
                    Convert.ToInt32(this.paramSet_GMIN.Text), Convert.ToInt32(this.paramSet_GMAX.Text),
                    Convert.ToInt32(this.paramSet_BMIN.Text), Convert.ToInt32(this.paramSet_BMAX.Text),
                    Convert.ToInt32(this.paramSet_IRMIN.Text), Convert.ToInt32(this.paramSet_IRMAX.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("输入值有误，请检查");
                return;
            }
            Task.Run(new Action(() =>
            {
                Create_File(convetlData);
            }));

            this.textBox_SN.ForeColor = Color.Gray;

            //  显示1.5秒OK ng
            WindowsFormsApp1.Monitor Statu = new WindowsFormsApp1.Monitor(OKNG,1000);
            Statu.ShowDialog();
        }

        private void Create_File(int[] data)
        {

            //  写入日志

            if (File.Exists(Log_Path))
            {
                MessageBox.Show("日志文件存放路径不存在，请检查");
                return;
            }

            //  检查文件夹是否存在

            if (!File.Exists(VariablePathFile))
            {
                // 当月日志文件夹不存在，创建

                DirectoryInfo Create = null;

                try
                {
                    Create = Directory.CreateDirectory(VariablePathFile);
                }
                catch (Exception)
                {
                    MessageBox.Show("当月日志文件夹创建失败，请检查");
                    return;
                }
            }
            // 文件存在，读取或者写入日志内容，判断日志是否创建

            Task.Run(new Action(() =>
            {
                try
                {
                    Write_LogCvs(data);
                }
                catch (Exception)
                {
                    MessageBox.Show("无法写入数据，请检查是否正在打开文件");
                    return;
                }

            }));
        }

        public void Write_LogCvs(int[] data)
        {
            // 检查文件是否存在
            bool fileExists = File.Exists(VariableCsvFlie);

            Func<bool, string> getStatus = b => b ? "OK" : "NG";

            // 使用using语句自动关闭StreamWriter
            using (StreamWriter sw = new StreamWriter(VariableCsvFlie, append: true))
            {
                if (!fileExists)
                {
                    // 文件刚创建，写入标题行
                    sw.WriteLine("Time:,SN:,R:,G:,B:,IR:,ID:,RES:");
                }

                // 使用Invoke确保线程安全地访问UI控件
                if (label1.InvokeRequired)
                {
                    label1.Invoke(new MethodInvoker(delegate
                    {
                        // 追加数据到文件

                        sw.WriteLine($"{currentTimer}, {textBox_SN.Text}, {data[0]}, {data[1]}, {data[2]}, {data[03]}, {data[4]}, {getStatus(OKNG)}");
                    }));
                }
                else
                {
                    // 在UI线程中直接写入
                    sw.WriteLine($"{currentTimer}, {textBox_SN.Text}, {data[0]}, {data[1]}, {data[2]}, {data[03]}, {data[4]}, {getStatus(OKNG)}");
                }
            }
        }


        private void but_Default_Click(object sender, EventArgs e)
        {
            this.text_CONF1.Text = "0x30";
            this.text_CONF2.Text = "0x09";
        }

        private void textBox_SN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.textBox_SN.Text == "" && this.textBox_SN.Text == null)
                {
                    MessageBox.Show("输入值为null，请检查");
                    return;
                }
                button3_Click(sender, e);
            }

        }

        private void textBox_SN_Click(object sender, EventArgs e)
        {
            this.textBox_SN.ForeColor = Color.Black;
            this.textBox_SN.Text = "";
        }

        //public string ModifyValue { get; set; }
        /// <summary>
        /// 双击修改变量
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="value"></param>
        //private void paramSet_RMIN_DoubleClick(object sender, EventArgs e)
        //{
        //    if (sender is ParamSet param)
        //    {
        //        if (param.limiti != null)
        //        {
        //            Modify modify = new Modify(param.limiti);

        //            modify.ShowDialog();

        //            if (modify.DialogResult == DialogResult.OK)
        //            {
        //                param.limiti = modify.Modifyvalue;
        //                findParamSet(param.Tag.ToString(), modify.Modifyvalue);
        //                //findParamSet1(param.Tag.ToString(), modify.Modifyvalue);
        //                return;
        //            }
        //            MessageBox.Show("密码错误修改失败");
        //        }
        //    }
        //}
        private void findTextLimit()
        {
            foreach (var item in this.Controls.OfType<TextBox>())
            {
                if (item.Tag!=null)
                {
                    item.ReadOnly = false;
                }
            }
        }
        private void but_EditLimit_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            modify.ShowDialog();
            if (modify.DialogResult == DialogResult.OK)
            {
                findTextLimit();
            }
        }

        private void but_Lock_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls.OfType<TextBox>())
            {
                if (item.Tag != null)
                {
                    item.ReadOnly = true;
                }
            }
        }
    }
}

