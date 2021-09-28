using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClientConstantCode;

namespace Unkou.UserControl
{
    public partial class LabelEx : Label, IUserControl
    {

        #region  変数／定数 
        private bool _notNull = false;
        private bool _existError = false;
        private string _GuideMessage = "";
        private List<string> _GuideMessageDetail = new List<string>();
        private bool _LineFeedProcessing = false;
        private bool _SJISOnly = false;
        #endregion

        #region  メソッド 
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <remarks></remarks>
        public LabelEx()
        {
            this.AutoSize = true;
            this.Font = new Font("ＭＳ ゴシック", (float)11.25d);
            this.Margin = new System.Windows.Forms.Padding(3);
            // TODO:コメント化
            // Me.TextDetached = True
            // Me.HighlightText = True
            // Me.SideButtons.Clear()
            // Me.DropDown.AllowDrop = False
        }
        /// <summary>
        /// 必須項目プロパティ
        /// (プロパティ値を変更することにより、背景色が変更されます。)
        /// </summary>
        /// <value>Ture:必須／False:任意</value>
        /// <returns></returns>
        /// <remarks></remarks>
        [Category("カスタム")]
        [Description("必須項目プロパティ")]
        public bool NotNull
        {
            get
            {
                return _notNull;
            }

            set
            {
                _notNull = value;
                switch (value)
                {
                    case true:
                        {
                            this.ForeColor = CharacterColorType.InputMust();
                            break;
                        }

                    default:
                        {
                            this.ForeColor = CharacterColorType.System();
                            break;
                        }
                }
            }
        }

        /// <summary>
        /// エラー有無プロパティ
        /// (プロパティ値を変更することにより、背景色が変更されます。)
        /// </summary>
        /// <value>Ture:エラー有／False:エラー無</value>
        /// <returns></returns>
        /// <remarks></remarks>
        [Browsable(false)]
        public bool ExistError
        {
            get
            {
                return _existError;
            }

            set
            {
                _existError = value;
                switch (NotNull)
                {
                    case true:
                        {
                            this.ForeColor = CharacterColorType.InputMust();
                            break;
                        }

                    default:
                        {
                            this.ForeColor = CharacterColorType.System();
                            break;
                        }
                }
            }
        }
        /// <summary>
        /// ガイドメッセージID
        /// (設定することにより、ガイドメッセージを出力します。)
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string GuideMessage
        {
            get
            {
                return _GuideMessage;
            }

            set
            {
                _GuideMessage = value;
            }
        }
        /// <summary>
        /// ガイドメッセージ内容
        /// （ガイドメッセージで、引数のあるメッセージの内容を設定します。)
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public List<string> GuideMessageDetail
        {
            get
            {
                return _GuideMessageDetail;
            }

            set
            {
                _GuideMessageDetail = value;
            }
        }

        #endregion

    }
}
