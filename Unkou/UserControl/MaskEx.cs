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
    public partial class MaskEx : GrapeCity.Win.Editors.GcMask, IUserControl
    {

        #region  変数／定数 
        private bool _notNull = false;
        private bool _ExistError = false;
        private string _GuideMessage = "";
        private List<string> _GuideMessageDetail = new List<string>();
        #endregion

        #region  メソッド 
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <remarks></remarks>
        public MaskEx()
        {
            this.AutoSize = true;
            this.Font = new Font("ＭＳ ゴシック", (float)11.25d);
            this.HighlightText = GrapeCity.Win.Editors.HighlightText.All;
            this.SideButtons.Clear();
            this.Fields.Clear();
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
                return _ExistError;
            }

            set
            {
                _ExistError = value;
                switch (value)
                {
                    case true:
                        {
                            this.BackColor = BackColorType.InputError();
                            break;
                        }

                    default:
                        {
                            switch (NotNull)
                            {
                                case true:
                                    {
                                        this.BackColor = BackColorType.InputMust();
                                        break;
                                    }

                                default:
                                    {
                                        // TODO：現行の背景色(GrapecityはTransparentをサポートしていないため)
                                        // Me.BackColor = BackColorType.Transparent
                                        this.BackColor = SystemColors.Window;
                                        break;
                                    }
                            }

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

        /// <summary>
        /// 必須項目プロパティ
        /// (プロパティ値を変更することにより、背景色が変更されます。)
        /// </summary>
        /// <value>Ture:必須／False:任意</value>
        /// <returns></returns>
        /// <remarks></remarks>
        [Category("必須項目")]
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
                            switch (ExistError)
                            {
                                case true:
                                    {
                                        this.BackColor = BackColorType.InputError();
                                        break;
                                    }

                                default:
                                    {
                                        this.BackColor = BackColorType.InputMust();
                                        break;
                                    }
                            }

                            break;
                        }

                    default:
                        {
                            switch (ExistError)
                            {
                                case true:
                                    {
                                        this.BackColor = BackColorType.InputError();
                                        break;
                                    }

                                default:
                                    {
                                        // TODO：現行の背景色(GrapecityはTransparentをサポートしていないため)
                                        // Me.BackColor = BackColorType.Transparent
                                        this.BackColor = SystemColors.Window;
                                        break;
                                    }
                            }

                            break;
                        }
                }
            }
        }

        #endregion

    }
}
