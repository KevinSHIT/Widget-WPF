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
        public static string backColor = DEFAULT_BACK_COLOR;
        public static string fontColor = DEFAULT_FONT_COLOR;

        public static JObject jo = new JObject();
        public static string json;

        public static string _tmpBackColor;
        public static string _tmpFontColor;

        public const string DEFAULT_BACK_COLOR = "#45FFFFFF";
        public const string DEFAULT_FONT_COLOR = "#EEFFFFFF";
        public const string DEFAULT_CONFIG_PATH = "config.json";

        public const string DEFAULT_CONFIG_JSON =
            "{\r\n" +
            "    \"backcolor\": \"#45FFFFFF\",\r\n" +
            "    \"fontcolor\": \"#EEFFFFFF\"\r\n" +
            "}";
    }
}
