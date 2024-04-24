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
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();
            this.textBox1.Focus();
        }

        private string PassWord = "bs2024";

        public string Modifyvalue { get; set; } = string.Empty;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != PassWord)
            {
                MessageBox.Show("密码错误");
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }

        }
    }
}
