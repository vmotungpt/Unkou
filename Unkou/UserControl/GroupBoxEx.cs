using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unkou.UserControl
{
    public partial class GroupBoxEx : GroupBox
    {

        #region  変数／定数 
        private Color _BorderColor = System.Drawing.SystemColors.ControlText;
        #endregion

        #region  メソッド 
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <remarks></remarks>
        public GroupBoxEx()
        {
            this.AutoSize = true;
            this.Font = new Font("ＭＳ ゴシック", (float)11.25d);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
        }
        /// <summary>
        /// 必須項目プロパティ
        /// (プロパティ値を変更することにより、背景色が変更されます。)
        /// </summary>
        /// <value>Ture:必須／False:任意</value>
        /// <returns></returns>
        /// <remarks></remarks>
        [DefaultValue(typeof(Color), "ControlText")]
        [Category("カスタム")]
        [Description("線の色")]
        public Color BorderColor
        {
            get
            {
                return _BorderColor;
            }

            set
            {
                _BorderColor = value;
                this.Invalidate();
            }
        }

        #endregion
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // 'Dim rect As Rectangle = Me.ClientRectangle
            // 'Dim p As New Pen(_BorderColor)
            // 'ControlPaint.DrawBorder(e.Graphics, rect, _BorderColor, ButtonBorderStyle.Solid)
            Brush textBrush = new SolidBrush(SystemColors.ControlText);
            Brush borderBrush = new SolidBrush(_BorderColor);
            var borderPen = new Pen(borderBrush);
            SizeF strSize = e.Graphics.MeasureString(this.Text, this.Font);
            var rect = new Rectangle(this.ClientRectangle.X, this.ClientRectangle.Y + Convert.ToInt32(strSize.Height / 2), this.ClientRectangle.Width - 1, this.ClientRectangle.Height - Convert.ToInt32(strSize.Height / 2 - 1));
            e.Graphics.Clear(this.BackColor);
            e.Graphics.DrawString(this.Text, this.Font, textBrush, this.Padding.Left, 0);
            e.Graphics.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
            e.Graphics.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
            e.Graphics.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height - 2), new Point(rect.X + rect.Width, rect.Y + rect.Height - 2));
            e.Graphics.DrawLine(borderPen, new Point(rect.X + this.Padding.Left + Convert.ToInt32(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
        }
    }
}
