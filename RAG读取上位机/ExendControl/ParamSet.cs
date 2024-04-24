using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExendControl
{
    public partial class ParamSet : UserControl
    {
        public ParamSet()
        {
            InitializeComponent();
        }

        private string Limiti = "0";
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置高限低限")]
        public string limiti
        {
            get { return Limiti; }
            set
            {
                if (Power)
                {
                    Limiti = value;
                    this.lab_Param.Text = value;
                }
            }
        }
        private bool Power = false;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置修改权限")]
        public bool power
        {
            get { return Power; }
            set { Power = value; }
        }
    }
}
