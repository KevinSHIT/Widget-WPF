using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widget_WPF
{
    public static class Data
    {
        public static string color = DEFAULT_BACK_COLOR;
        public static JObject jo = new JObject();
        public static string json = "{ \"backcolor\" : \"#99ff9fff\" }";

        public static string _tmpBackColor;
        public static string _tmpFontColor;

        public const string DEFAULT_BACK_COLOR = "#99669FFF";
        public const string DEFAULT_FONT_COLOR = "White";
    }
}
