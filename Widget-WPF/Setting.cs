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
            Application.EnableVisualStyles();
            RefreshBar(htmlColorBox.Text);
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

                _main.RefreshBackColor(Data._tmpBackColor = htmlColorBox.Text);

            }
            catch (Exception ex)
            {
                Debug.Write(ex.ToString());
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            //Data.color
            _main.RefreshBackColor(Data.color = htmlColorBox.Text);
            this.Close();
        }

        private void Cancle_Click(object sender, EventArgs e)
        {
            try
            {
                _main.RefreshBackColor(Data.color);
            }
            catch
            { }
            this.Close();
        }


        private void colorBox_Paint(object sender, PaintEventArgs e)
        {
            var pp = new System.Drawing.Pen(System.Drawing.Color.Black, 3);
            e.Graphics.DrawRectangle(pp, e.ClipRectangle.X,
            e.ClipRectangle.Y,
            e.ClipRectangle.X + e.ClipRectangle.Width - 1,
            e.ClipRectangle.Y + e.ClipRectangle.Height - 1);
        }

        private string GenerateHtmlColorCode()
        {
            r = RedBar.Value;
            g = GreenBar.Value;
            b = BlueBar.Value;
            a = AlphaBar.Value;

            return "#" + Convert.ToString(a, 16).PadLeft(2, '0').ToUpper() + ColorTranslator.ToHtml(System.Drawing.Color.FromArgb(r, g, b)).Substring(1);
        }

        private void RefreshBar(string htmlColorCode)
        {
            _tmp = htmlColorCode.Substring(1);
            Debug.WriteLine(_tmp);
            var _tmpChar = _tmp.ToCharArray();
            if (_tmp.Length == 6)
            {
                RNumeric.Value = RedBar.Value = Convert.ToInt32(_tmpChar[0].ToString() + _tmpChar[1].ToString(), 16);
                GNumeric.Value = GreenBar.Value = Convert.ToInt32(_tmpChar[2].ToString() + _tmpChar[3].ToString(), 16);
                BNumeric.Value = BlueBar.Value = Convert.ToInt32(_tmpChar[4].ToString() + _tmpChar[5].ToString(), 16);
                ANumeric.Value = AlphaBar.Value = 255;
            }
            if (_tmp.Length == 8)
            {
                ANumeric.Value = AlphaBar.Value = Convert.ToInt32(_tmpChar[0].ToString() + _tmpChar[1].ToString(), 16);
                RNumeric.Value = RedBar.Value = Convert.ToInt32(_tmpChar[2].ToString() + _tmpChar[3].ToString(), 16);
                GNumeric.Value = GreenBar.Value = Convert.ToInt32(_tmpChar[4].ToString() + _tmpChar[5].ToString(), 16);
                BNumeric.Value = BlueBar.Value = Convert.ToInt32(_tmpChar[6].ToString() + _tmpChar[7].ToString(), 16);
            }
        }
        private static int r, g, b, a;

        #region 调整区域
        private void RNumeric_ValueChanged(object sender, EventArgs e)
        {
            RedBar.Value = (int)RNumeric.Value;

        }

        private void GNumeric_ValueChanged(object sender, EventArgs e)
        {
            GreenBar.Value = (int)GNumeric.Value;
        }

        private void BNumeric_ValueChanged(object sender, EventArgs e)
        {
            BlueBar.Value = (int)BNumeric.Value;
        }

        private void ANumeric_ValueChanged(object sender, EventArgs e)
        {
            AlphaBar.Value = (int)ANumeric.Value;
        }

        private void RedBar_ValueChanged(object sender, EventArgs e)
        {
            htmlColorBox.Text = GenerateHtmlColorCode();
            RNumeric.Value = RedBar.Value;
        }

        private void GreenBar_ValueChanged(object sender, EventArgs e)
        {
            htmlColorBox.Text = GenerateHtmlColorCode();
            GNumeric.Value = GreenBar.Value;
        }

        private void Setting_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void BlueBar_ValueChanged(object sender, EventArgs e)
        {
            htmlColorBox.Text = GenerateHtmlColorCode();
            BNumeric.Value = BlueBar.Value;
        }

        private void AlphaBar_ValueChanged(object sender, EventArgs e)
        {
            htmlColorBox.Text = GenerateHtmlColorCode();
            ANumeric.Value = AlphaBar.Value;
        }

        private static string _tmp;
        #endregion

    }
}
