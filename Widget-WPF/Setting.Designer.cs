namespace Widget_WPF
{
    partial class Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OK = new System.Windows.Forms.Button();
            this.Cancle = new System.Windows.Forms.Button();
            this.RedBar = new System.Windows.Forms.TrackBar();
            this.AlphaBar = new System.Windows.Forms.TrackBar();
            this.colorBox = new System.Windows.Forms.PictureBox();
            this.htmlColorBox = new System.Windows.Forms.TextBox();
            this.BlueBar = new System.Windows.Forms.TrackBar();
            this.GreenBar = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ANumeric = new System.Windows.Forms.NumericUpDown();
            this.BNumeric = new System.Windows.Forms.NumericUpDown();
            this.GNumeric = new System.Windows.Forms.NumericUpDown();
            this.RNumeric = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.RedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlphaBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ANumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RNumeric)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(146, 394);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 0;
            this.OK.Text = "确定";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancle
            // 
            this.Cancle.Location = new System.Drawing.Point(227, 394);
            this.Cancle.Name = "Cancle";
            this.Cancle.Size = new System.Drawing.Size(75, 23);
            this.Cancle.TabIndex = 1;
            this.Cancle.Text = "取消";
            this.Cancle.UseVisualStyleBackColor = true;
            this.Cancle.Click += new System.EventHandler(this.Cancle_Click);
            // 
            // RedBar
            // 
            this.RedBar.Location = new System.Drawing.Point(3, 3);
            this.RedBar.Maximum = 255;
            this.RedBar.Name = "RedBar";
            this.RedBar.Size = new System.Drawing.Size(100, 30);
            this.RedBar.TabIndex = 2;
            this.RedBar.ValueChanged += new System.EventHandler(this.RedBar_ValueChanged);
            // 
            // AlphaBar
            // 
            this.AlphaBar.Location = new System.Drawing.Point(3, 111);
            this.AlphaBar.Maximum = 255;
            this.AlphaBar.Name = "AlphaBar";
            this.AlphaBar.Size = new System.Drawing.Size(100, 33);
            this.AlphaBar.TabIndex = 4;
            this.AlphaBar.ValueChanged += new System.EventHandler(this.AlphaBar_ValueChanged);
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(180, 21);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(156, 147);
            this.colorBox.TabIndex = 5;
            this.colorBox.TabStop = false;
            this.colorBox.Paint += new System.Windows.Forms.PaintEventHandler(this.colorBox_Paint);
            // 
            // htmlColorBox
            // 
            this.htmlColorBox.Location = new System.Drawing.Point(16, 227);
            this.htmlColorBox.Name = "htmlColorBox";
            this.htmlColorBox.Size = new System.Drawing.Size(100, 21);
            this.htmlColorBox.TabIndex = 6;
            this.htmlColorBox.TextChanged += new System.EventHandler(this.HtmlColorBox_TextChanged);
            // 
            // BlueBar
            // 
            this.BlueBar.Location = new System.Drawing.Point(3, 75);
            this.BlueBar.Maximum = 255;
            this.BlueBar.Name = "BlueBar";
            this.BlueBar.Size = new System.Drawing.Size(100, 30);
            this.BlueBar.TabIndex = 10;
            this.BlueBar.ValueChanged += new System.EventHandler(this.BlueBar_ValueChanged);
            // 
            // GreenBar
            // 
            this.GreenBar.Location = new System.Drawing.Point(3, 39);
            this.GreenBar.Maximum = 255;
            this.GreenBar.Name = "GreenBar";
            this.GreenBar.Size = new System.Drawing.Size(100, 30);
            this.GreenBar.TabIndex = 11;
            this.GreenBar.ValueChanged += new System.EventHandler(this.GreenBar_ValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.BlueBar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.GreenBar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.RedBar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AlphaBar, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(106, 147);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // ANumeric
            // 
            this.ANumeric.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ANumeric.Location = new System.Drawing.Point(3, 117);
            this.ANumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ANumeric.Name = "ANumeric";
            this.ANumeric.Size = new System.Drawing.Size(45, 21);
            this.ANumeric.TabIndex = 13;
            this.ANumeric.ValueChanged += new System.EventHandler(this.ANumeric_ValueChanged);
            // 
            // BNumeric
            // 
            this.BNumeric.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BNumeric.Location = new System.Drawing.Point(3, 79);
            this.BNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BNumeric.Name = "BNumeric";
            this.BNumeric.Size = new System.Drawing.Size(45, 21);
            this.BNumeric.TabIndex = 14;
            this.BNumeric.ValueChanged += new System.EventHandler(this.BNumeric_ValueChanged);
            // 
            // GNumeric
            // 
            this.GNumeric.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GNumeric.Location = new System.Drawing.Point(3, 43);
            this.GNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.GNumeric.Name = "GNumeric";
            this.GNumeric.Size = new System.Drawing.Size(45, 21);
            this.GNumeric.TabIndex = 15;
            this.GNumeric.ValueChanged += new System.EventHandler(this.GNumeric_ValueChanged);
            // 
            // RNumeric
            // 
            this.RNumeric.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RNumeric.Location = new System.Drawing.Point(3, 7);
            this.RNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RNumeric.Name = "RNumeric";
            this.RNumeric.Size = new System.Drawing.Size(45, 21);
            this.RNumeric.TabIndex = 16;
            this.RNumeric.ValueChanged += new System.EventHandler(this.RNumeric_ValueChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.RNumeric, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ANumeric, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.BNumeric, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.GNumeric, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(123, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(51, 147);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(380, 429);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.htmlColorBox);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.Cancle);
            this.Controls.Add(this.OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Setting";
            this.Text = "Setting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Setting_FormClosing);
            this.Load += new System.EventHandler(this.Setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlphaBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBar)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ANumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RNumeric)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancle;
        private System.Windows.Forms.TrackBar RedBar;
        private System.Windows.Forms.TrackBar AlphaBar;
        private System.Windows.Forms.PictureBox colorBox;
        private System.Windows.Forms.TextBox htmlColorBox;
        private System.Windows.Forms.TrackBar BlueBar;
        private System.Windows.Forms.TrackBar GreenBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown ANumeric;
        private System.Windows.Forms.NumericUpDown BNumeric;
        private System.Windows.Forms.NumericUpDown GNumeric;
        private System.Windows.Forms.NumericUpDown RNumeric;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}