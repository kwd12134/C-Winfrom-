using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentVariable
{
    public class Common_Read
    {
        public static string LED_GetNTC_R { get; set; } = "LED_GetNTC_R\r\n";

        public static string LED_GetLEDV { get; set; } = "LED_GetLEDV\r\n";

        public static string LED_GetLEDI { get; set; } = "LED_GetLEDI\r\n";

        public static string LED_GetDVal { get; set; } = "LED_GetDVal\r\n";

        public static string LED_Get_ChNum { get; set; } = "LED_Get_ChNum\r\n";

        public static string LED_clear_maxmin { get; set; } = "LED_clear_maxmin\r\n";

        public static string LED_ON { get; set; } = "LED_ON\r\n";

        public static string LED_OFF { get; set; } = "LED_OFF\r\n";

        public static string LED_GetAlarmState { get; set; } = "LED_GetAlarmState\r\n";

        public static List<string> common_Read_collection { get; set; } = new List<string>()
        {
            "LED_GetNTC_R\r\n",
            "LED_GetLEDV\r\n",
            "LED_GetLEDI\r\n",
            "LED_GetDVal\r\n",
            "LED_Get_ChNum\r\n",
            "LED_clear_maxmin\r\n",
            "LED_GetAlarmState\r\n"
        };

        /////////////////////////////////////////////////////////////////////////////

        public static string LED_Set_PrjNames { get; set; } = "LED_Set_PrjNames$\r\n";

        public static string LED_SHorL { get; set; } = "LED_SHorL$\r\n";

        public static string LED_Set_ChNum { get; set; } = "LED_Set_ChNum$\r\n";

        public static string LED_Set_I { get; set; } = "LED_Set_I$\r\n";

        public static string LED_Set_Imaxmin { get; set; } = "LED_Set_Imaxmin$\r\n";

        public static string LED_Set_Vmaxmin { get; set; } = "LED_Set_Vmaxmin$\r\n";

        public static string LED_DVal_maxmin { get; set; } = "LED_DVal_maxmin$\r\n";

        public static string LED_Set_NTC_Ch { get; set; } = "LED_Set_NTC_Ch$\r\n";

        public static string LED_SNTC_maxmin { get; set; } = "LED_SNTC_maxmin$\r\n";

        public static string NTC_MODEL { get; set; } = "NTC_MODEL$\r\n";
        /// <summary>
        /// 当前功率
        /// </summary>
        public static string Set_Current_Gain { get; set; } = "Set_Current_Gain$\r\n";

        public static List<string> common_Write_collection { get; set; } = new List<string>()
        {
            "LED_clear_maxmin\r\n",       //每次写入之前先清除之前的配置信息
            "LED_Set_PrjNames$",
            "LED_Set_ChNum$",
            "LED_Set_I$",
            "LED_Set_Imaxmin$",
            "LED_Set_Vmaxmin$",
            "LED_SHorL$",
            "LED_DVal_maxmin$",
            "LED_Set_NTC_Ch$",
            "NTC_MODEL$",
            "LED_SNTC_maxmin$"

        };
    }
}
