using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Media;

namespace Widget_WPF
{
    public partial class Setting : Form
    {
        readonly MainWindow _main;
        public Setting(MainWindow tmp)
        {
            InitializeComponent();
            _main = tmp;
            this.colorBox.BackColor = ColorTranslator.FromHtml(_main.Background.ToString());
            this.htmlColorBox.Text = _main.Background.ToString();
            //Data.jo = JObject.Parse(Data.json);
        }

        private void Setting_Load(object sender, EventArgs e)
        {

        }

        private void HtmlColorBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var bc = new BrushConverter();
                this.colorBox.BackColor = ColorTranslator.FromHtml(htmlColorBox.Text);
                Data.color = htmlColorBox.Text;
                _main.FreshBackColor();
            }
            catch(Exception ex)
            {
                Debug.Write(ex.ToString());
            }
        }
    }
}
