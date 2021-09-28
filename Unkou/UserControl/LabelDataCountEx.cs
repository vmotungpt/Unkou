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
    public partial class LabelDataCountEx : LabelEx
    {

        #region  変数／定数 

        // 件数
        private int _Count = 0;

        #endregion

        #region コンストラクタ
        public LabelDataCountEx() : base()
        {

            // 右寄せ
            this.TextAlign = ContentAlignment.MiddleRight;
            // 幅
            this.Width = 103;
            // 高さ
            this.Height = 15;
        }
        #endregion

        #region プロパティ
        /// <summary>
        /// 件数プロパティ
        /// </summary>
        /// <returns></returns>
        [Category("カスタム")]
        [DisplayName(nameof(Count))]
        [Description("件数プロパティの値を取得または設定します")]
        public int Count
        {
            get
            {
                return _Count;
            }

            set
            {
                _Count = value;
                // ダミー
                Text = string.Empty;
            }
        }

        /// <summary>
        /// テキスト プロパティ (非表示)
        /// </summary>
        /// <returns></returns>
        [Browsable(false)]
        public override string Text
        {
            get
            {
                return base.Text;
            }

            set
            {
                base.Text = string.Format("{0:#,0}件", _Count);
                return;
            }
        }

        /// <summary>
        /// AutoSizeプロパティ (強制的に False にする)
        /// </summary>
        /// <returns></returns>
        public override bool AutoSize
        {
            get
            {
                return false;
            }

            set
            {
                base.AutoSize = false;
            }
        }

        #endregion

        #region  メソッド 

        #endregion

    }
}
