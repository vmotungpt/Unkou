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
    public partial class DateEx : GrapeCity.Win.Editors.GcDate, IUserControl
    {
        #region  メソッド 
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <remarks></remarks>
        public DateEx()
        {
            #endregion

            #region  イベント 
            /// <summary>
            /// キーダウンイベント
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            /// <remarks></remarks>
            base.KeyDown += DateEx_KeyDown;

            /// <summary>
            /// Validateイベント
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            /// <remarks></remarks>
            this.Validated += DateEx_Validated;
            this.AutoSize = true;
            this.Font = new Font("ＭＳ ゴシック", (float)11.25d);
            this.HighlightText = GrapeCity.Win.Editors.HighlightText.All;
            this.Fields.Clear();
            this.SideButtons.Clear();
        }

        #region  変数／定数 
        private bool _notNull = false;
        private bool _existError = false;
        private string _GuideMessage = "";
        private List<string> _GuideMessageDetail = new List<string>();
        private bool _DepartureTime = false;
        private bool _ValidatorMode = false;
        #endregion

        public void DateEx_KeyDown(object sender, KeyEventArgs e)
        {
            if (_DepartureTime)
            {
                if (this.SelectionStart == 0)
                {
                    if (e.KeyCode >= Keys.D3 && e.KeyCode <= Keys.D9 || e.KeyCode >= Keys.NumPad3 && e.KeyCode <= Keys.NumPad9)
                    {
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                    }
                }
                else if (this.SelectionStart == 1 & base.Text.Substring(0, 1).Equals("2"))
                {
                    if (e.KeyCode >= Keys.D8 && e.KeyCode <= Keys.D9 || e.KeyCode >= Keys.NumPad8 && e.KeyCode <= Keys.D9)
                    {
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                    }
                }
                else if (this.SelectionStart == 4 && this.Text.Substring(0, 4).Equals("00:0") && (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0))
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void DateEx_Validated(object sender, EventArgs e)
        {
            if (_ValidatorMode == true)
            {

                // TODO
                // 'If Me.Value Is Nothing Then
                // '    Me.Value = Nothing
                // 'End If
            }
        }
        /// <summary>
        /// 必須項目プロパティ
        /// </summary>
        /// <value>Ture:必須／False:任意</value>
        /// (プロパティ値を変更することにより、背景色が変更されます。)
        /// <returns></returns>
        /// <remarks></remarks>
        [Category("カスタム")]
        [DisplayName(nameof(NotNull))]
        [Description("日付コントロールの必須項目を設定します。")]
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
                                        this.BackColor = BackColorType.Standard();
                                        break;
                                    }
                            }

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
                                        this.BackColor = BackColorType.Standard();
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
        /// キーダウンイベントで使用
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool HatoMode
        {
            get
            {
                return _DepartureTime;
            }

            set
            {
                _DepartureTime = value;
                // TODO
                // If value Then
                // Spin.AllowSpin = False
                // End If
            }
        }
        /// <summary>
        /// Validate検証モード（ValidateEvent時にNothingを挿入）を設定します。
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        [Category("ValidatorMode")]
        [Description("Validate検証モード（ValidateEvent時にNothingを挿入）を設定します。")]
        public bool ValidatorMode
        {
            get
            {
                return _ValidatorMode;
            }

            set
            {
                _ValidatorMode = value;
            }
        }

        /// <summary>
        /// 読み取り専用プロパティ
        /// </summary>
        /// <returns></returns>
        /// <remarks>読み取り専用時、同時に、TabStopを設定する</remarks>
        public bool ReadOnly
        {
            get
            {
                return base.ReadOnly;
            }

            set
            {
                base.ReadOnly = value;
                if (value)
                {
                    this.TabStop = !value;
                    this.BackColor = SystemColors.Control;
                }
                else
                {
                    this.TabStop = !value;
                }
            }
        }

        /// <summary>
        /// 日付プロパティ
        /// </summary>
        /// <returns></returns>
        [Category("カスタム")]
        [DisplayName(nameof(ValueInt))]
        [Description("日付の値を取得します。")]
        public int? ValueInt
        {
            get
            {
                try
                {
                    return int.Parse(this.Text.ToString().Replace("/", ""));
                }
                catch (Exception ex)
                {
                    return default;
                }
            }

            set
            {
                try
                {
                    this.Value = DateTime.ParseExact(Convert.ToString(value), "yyyyMMdd", null);
                }
                catch (Exception ex)
                {
                    this.Value = null;
                }
            }
        }

        #endregion

    }
}
