using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentVariable
{
    public class LEDxVariable
    {
        //public List<string> LED_Name { get; set; } = new List<string>(12) 
        //{
        //    "LED1",
        //    "LED2",
        //    "LED3",
        //    "LED4",
        //    "LED5",
        //    "LED6",
        //    "LED7",
        //    "LED8",
        //    "LED9",
        //    "LED10",
        //    "LED11",
        //    "LED12",
        //};
        ///// <summary>
        ///// LED_GetLEDV 读取电压     读两次数据太长 A高端的电压   K是底端电压 VF是LED的压差   VF=A-K DV是压差   初始化12个空值
        ///// </summary>
        //public List<string> VF { get; set; } = new List<string>(Enumerable.Repeat(string.Empty, 12)) ;
        ///// <summary>
        ///// LED_GetLEDI    读取电流   初始化12个空值
        ///// </summary>
        //public List<string> Ima { get; set; } = new List<string>(Enumerable.Repeat(string.Empty, 12)) { };

        public string LED_Name { get; set; }

        public string VF { get; set; }

        public string Ima { get; set; }

    }
}
