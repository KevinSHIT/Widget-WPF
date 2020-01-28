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
            InitialSetting();
            this.IsBack.Checked = true;
            Application.EnableVisualStyles();
            //Data.jo = JObject.Parse(Data.json);
        }

        private void Setting_Shown(object sender, EventArgs e)
        {
            this.IsBack.Checked = true;
            InitialSetting();
        }

        private void InitialSetting()
        {
            this.colorBox.BackColor = ColorTranslator.FromHtml(_main.Background.ToString());
            this.backHtmlColorBox.Text = _main.Background.ToString();
            this.fontHtmlColorBox.Text = _main.Hour.Foreground.ToString();
            RefreshBar(backHtmlColorBox.Text);
        }

        private void IsBack_CheckedChanged(object sender, EventArgs e)
        {
            if (IsBack.Checked)
                RefreshBar(this.backHtmlColorBox.Text);
        }

        private void FreshChecked()
        {
            if (IsBack.Checked)
                backHtmlColorBox.Text = GenerateHtmlColorCode();
            else
                fontHtmlColorBox.Text = GenerateHtmlColorCode();
        }

        private void IsFont_CheckedChanged(object sender, EventArgs e)
        {
            if (!IsBack.Checked)
                RefreshBar(this.fontHtmlColorBox.Text);
        }
        private void Setting_Load(object sender, EventArgs e)
        {

        }

        private void HtmlColorBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var bc = new BrushConverter();

                if (IsBack.Checked)
                {
                    this.colorBox.BackColor = ColorTranslator.FromHtml(backHtmlColorBox.Text);
                    _main.RefreshBackColor(Data._tmpBackColor = backHtmlColorBox.Text);
                }
                else
                {
                    this.colorBox.BackColor = ColorTranslator.FromHtml(fontHtmlColorBox.Text);
                    _main.RefreshFontColor(Data._tmpFontColor = fontHtmlColorBox.Text);
                }

            }
            catch (Exception ex)
            {
                Debug.Write(ex.ToString());
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            //Data.backColor
            _main.RefreshBackColor(Data.backColor = backHtmlColorBox.Text);
            _main.RefreshFontColor(Data.fontColor = fontHtmlColorBox.Text);
            this.Close();
        }



        private void Cancle_Click(object sender, EventArgs e)
        {
            try
            {
                _main.RefreshBackColor(Data.backColor);
                _main.RefreshFontColor(Data.fontColor);
            }
            catch
            { }
            this.Close();
        }

        private void Setting_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Data.backColor = Data._tmpBackColor;
            _main.RefreshBackColor(Data.backColor);
            _main.RefreshFontColor(Data.fontColor);
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

        private void backHtmlColorBox_Enter(object sender, EventArgs e)
        {
            IsBack.Checked = true;
        }
        private void fontHtmlColorBox_Enter(object sender, EventArgs e)
        {
            IsFont.Checked = true;
        }

        private void RefreshBar(string htmlColorCode)
        {
            try
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
            catch (Exception ex)
            {
                Debug.WriteLine("RefreshBar -> Error");
                Debug.WriteLine(ex.ToString());
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
            FreshChecked();
            RNumeric.Value = RedBar.Value;
        }

        private void GreenBar_ValueChanged(object sender, EventArgs e)
        {
            FreshChecked();
            GNumeric.Value = GreenBar.Value;
        }

        private void BlueBar_ValueChanged(object sender, EventArgs e)
        {
            FreshChecked();
            BNumeric.Value = BlueBar.Value;
        }

        private void AlphaBar_ValueChanged(object sender, EventArgs e)
        {
            FreshChecked();
            ANumeric.Value = AlphaBar.Value;
        }

        private static string _tmp;
        #endregion

    }
}
