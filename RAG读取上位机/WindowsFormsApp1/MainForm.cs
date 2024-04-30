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
using MiniExcelLibs;
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
            currentTimer = DateTime.Now.ToString("D").Replace("年", "-").Replace("月", "-").Replace("日", " ") + DateTime.Now.ToString("t");

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

        private string VariablePathFile = null;

        private string Log_Path = Application.StartupPath + "\\Log";

        public List<string> Current_Variable = new List<string>(8);

        private string VariablePath = Application.StartupPath + "\\Config\\DeviceConfig.xlsx";

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

        #region 查询路径里的xlsx文件转换为list<Variable>类型
        private void Initialize()
        {
            //    查询路径里的xlsx文件转换为list<Variable>类型
            try
            {
                CommandMethod.DeviceConfig = MiniExcel.Query<Variable>(VariablePath).ToList();
            }
            catch (Exception)
            {
                CommandMethod.DeviceConfig = new List<Variable>();
            }

            string[] PortName = SerialPort.GetPortNames();
            if (PortName.Length > 0)
            {
                this.cmb_port.Items.Clear();
                this.cmb_port.Items.AddRange(PortName);
                this.cmb_port.SelectedIndex = 0;
            }

            string[] deviceName = new string[CommandMethod.DeviceConfig.Count];
            for (int i = 0; i < CommandMethod.DeviceConfig.Count; i++)
            {
                deviceName[i] = (CommandMethod.DeviceConfig[i].DeviceName);
            }
            this.cmb_Device.Items.Clear();
            this.cmb_Device.Items.AddRange(deviceName);
        }
        #endregion

        #region 连接串口
        /// <summary>
        /// 连接串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            if (IsOpen)
            {
                MessageBox.Show("断开连接");
                this.button1.Text = "连接";
                helper.DisConncet();
                IsOpen = false;
                return;
            }

            IsOpen = helper.conncet(this.cmb_port.Text);
            if (IsOpen)
            {
                MessageBox.Show("连接成功");
                this.button1.Text = "连接中";
                return;
            }
        }
        #endregion

        #region 读取数据并显示
        private void button3_Click(object sender, EventArgs e)
        {
            if (!IsOpen)
            {
                MessageBox.Show("设备未连接，请检查");
                return;
            }
            if (this.textBox_SN.Text == "" || this.textBox_SN.Text == null)
            {
                MessageBox.Show("SN输入值为空，请检查");
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
                this.cmb_Device.Invoke(new Action(() =>
                {
                    DeviceFile(this.cmb_Device.Text, convetlData);
                }));
            }));

            this.textBox_SN.ForeColor = Color.Gray;

            //  显示1秒OK ng
            WindowsFormsApp1.Monitor Statu = new WindowsFormsApp1.Monitor(OKNG, 1000);
            Statu.ShowDialog();
            this.textBox_SN.Text = "";
        }
        #endregion

        #region 创建文件夹与CSV文件存储数据
        public void DeviceFile(string Name, int[] data)
        {

            string Path = Log_Path + $"\\{Name}";

            if (!File.Exists(Path))
            {
                // 设备日志文件夹不存在，创建

                DirectoryInfo Create = null;

                try
                {
                    Create = Directory.CreateDirectory(Path);
                }
                catch (Exception)
                {
                    this.Invoke(new Action(() =>
                    {
                        MessageBox.Show("设备日志日志文件夹创建失败，请检查");
                    }));
                    return;
                }
            }
            Write_LogCvs(Path, data);
        }
        /// <summary>
        /// 创建当月文件夹
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="data"></param>
        //private void Create_File(string Name, int[] data)
        //{

        //    //  检查文件夹是否存在

        //    VariablePathFile = Name + "\\" + DateTime.Now.ToString("yyyy:MM:d").Replace("年", "-").Replace("月", "-").Replace("日", " ");

        //    if (!File.Exists(VariablePathFile))
        //    {
        //        // 当月日志文件夹不存在，创建

        //        DirectoryInfo Create = null;

        //        try
        //        {
        //            Create = Directory.CreateDirectory(VariablePathFile);
        //        }
        //        catch (Exception)
        //        {
        //            this.Invoke(new Action(() =>
        //            {
        //                MessageBox.Show("当月日志文件夹创建失败，请检查");
        //            }));
        //            return;
        //        }
        //    }
        //    // 文件存在，读取或者写入日志内容，判断日志是否创建

        //    Task.Run(new Action(() =>
        //    {
        //        try
        //        {
        //            Write_LogCvs(data);
        //        }
        //        catch (Exception)
        //        {
        //            this.Invoke(new Action(() =>
        //            {
        //                MessageBox.Show("无法写入数据，请检查是否正在打开文件");

        //            }));
        //            return;
        //        }

        //    }));
        //}

        public void Write_LogCvs(string Name, int[] data)
        {
            VariableCsvFlie = Name + "//" + DateTime.Now.ToString("yyyy:MM:d").Replace("年", "-").Replace("月", "-").Replace("日", " ").Replace(":", "-") + ".csv";

            // 检查文件是否存在
            bool fileExists = File.Exists(VariableCsvFlie);

            Func<bool, string> getStatus = b => b ? "OK" : "NG";

            // 使用using语句自动关闭StreamWriter
            using (StreamWriter sw = new StreamWriter(VariableCsvFlie, append: true))
            {
                if (!fileExists)
                {
                    // 文件刚创建，写入标题行
                    sw.WriteLine("Device,Time:,SN:,R:,G:,B:,IR:,ID:,RES:");
                }

                // 使用Invoke确保线程安全地访问UI控件
                if (label1.InvokeRequired)
                {
                    label1.Invoke(new MethodInvoker(delegate
                    {
                        // 追加数据到文件

                        sw.WriteLine($"{this.cmb_Device.Text},{currentTimer},{"'" + textBox_SN.Text.Trim()}, {data[0]}, {data[1]}, {data[2]}, {data[03]}, {data[4]}, {getStatus(OKNG)}".Trim());
                    }));
                }
                else
                {
                    // 在UI线程中直接写入
                    sw.WriteLine($"{this.cmb_Device.Text},{currentTimer},{"'" + textBox_SN.Text.Trim()},{data[0]},{data[1]},{data[2]},{data[03]},{data[4]},{getStatus(OKNG)}".Trim());
                }
            }
        }
        #endregion

        #region 设置SN内容
        private void textBox_SN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3_Click(sender, e);
            }
        }

        private void textBox_SN_Click(object sender, EventArgs e)
        {
            this.textBox_SN.ForeColor = Color.Black;
            this.textBox_SN.Text = "";
        }
        #endregion

        #region 通用遍历查找窗体控件
        private void findTextLimit()
        {
            foreach (var item in this.Controls.OfType<TextBox>())
            {
                if (item.Tag != null)
                {
                    item.ReadOnly = false;
                }
            }
        }

        #endregion

        #region 编辑配置
        private void 编辑配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            if (modify.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("密码错误");
                return;
            }

            FrmVariableConfig frmVariableConfig = new FrmVariableConfig();
            frmVariableConfig.ShowDialog();
            try
            {
                Initialize();
            }
            catch (Exception)
            {
                MessageBox.Show("修改配置文件加载失败");
            }
        }
        #endregion


        private void 锁定ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.cmb_Device.Enabled = false;
            this.cmb_port.Enabled = false;
            this.button1.Enabled = false;
            this.button2.Enabled = false;
        }

        private void 解锁ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            if (modify.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("密码错误");
                return;
            }
            try
            {
                Initialize();
            }
            catch (Exception)
            {
                MessageBox.Show("修改配置文件加载失败");
                return;
            }
            this.cmb_Device.Enabled = true;
            this.cmb_port.Enabled = true;
            this.button1.Enabled = true;
            this.button2.Enabled = true;
        }
        /// <summary>
        /// 设备参数配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

            var CurrentDeviceConfig = CommandMethod.DeviceConfig.Find(c => c.DeviceName == this.cmb_Device.Text);
            if (CurrentDeviceConfig == null)
            {
                MessageBox.Show("没有该配置名称");
                return;
            }
            this.paramSet_RMIN.Text = CurrentDeviceConfig.RMIN;
            this.paramSet_RMAX.Text = CurrentDeviceConfig.RMAX;
            this.paramSet_GMIN.Text = CurrentDeviceConfig.GMIN;
            this.paramSet_GMAX.Text = CurrentDeviceConfig.GMAX;
            this.paramSet_BMIN.Text = CurrentDeviceConfig.BMIN;
            this.paramSet_BMAX.Text = CurrentDeviceConfig.BMAX;
            this.paramSet_IRMIN.Text = CurrentDeviceConfig.IRMIN;
            this.paramSet_IRMAX.Text = CurrentDeviceConfig.IRMAX;
        }
    }
}

