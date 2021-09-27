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
    public partial class PanelEx : Panel
    {

        #region  変数／定数 
        private Color _BorderColor = System.Drawing.SystemColors.ControlText;
        #endregion

        #region  メソッド 
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <remarks></remarks>
        public PanelEx()
        {
            this.AutoSize = true;
            this.Font = new Font("ＭＳ ゴシック", (float)11.25d);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
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
            Rectangle rect = this.ClientRectangle;
            var p = new Pen(_BorderColor);
            ControlPaint.DrawBorder(e.Graphics, rect, _BorderColor, ButtonBorderStyle.Solid);
        }
    }
}
