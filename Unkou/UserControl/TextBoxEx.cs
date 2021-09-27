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
    public partial class TextBoxEx : GrapeCity.Win.Editors.GcTextBox, IUserControl
    {
        #region  コンストラクタ 

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <remarks></remarks>
        public TextBoxEx()
        {

            #endregion

            #region  イベント 
            /// <summary>
            /// 改行対応
            /// （マルチライン時の改行のキャンセル処理をします。)
            /// </summary>
            /// <remarks></remarks>
            this.AutoSize = true;
            this.Font = new Font("ＭＳ ゴシック", (float)11.25d);
            this.HighlightText = true;
            this.SideButtons.Clear();
            this.DropDown.AllowDrop = false;
        }



        /// <summary>
        /// 入力モード
        /// </summary>
        public enum InputMode
        {
            /// <summary> 全角 </summary>
            Full,
            /// <summary> 半角 </summary>
            Half,
            /// <summary> なし </summary>
            None
        }



        /// <summary>
        /// 半角規定桁数
        /// </summary>
        private int DefaultHalfWidth = 15;

        /// <summary>
        /// 全角規定桁数
        /// </summary>
        private int DefaultFullWidth = 23;

        /// <summary>
        /// 半角差分サイズ
        /// </summary>
        private int DefHalfSize = 8;

        /// <summary>
        /// 全角差分サイズ
        /// </summary>
        private int DefFullSize = 16;



        private bool _notNull = false;
        private bool _existError = false;
        private string _GuideMessage = "";
        private List<string> _GuideMessageDetail = new List<string>();
        private bool _LineFeedProcessing = false;
        private bool _SJISOnly = false;
        private InputMode _TextInputMode = InputMode.Half;
        private int _CharLength = 4;
        private bool _ReadOnlyTabStop = false;
        // private ControlFormat? _FormatType;



        /// <summary>
        /// 必須項目プロパティ
        /// (プロパティ値を変更することにより、背景色が変更されます。)
        /// </summary>
        /// <value>Ture:必須／False:任意</value>
        /// <returns></returns>
        /// <remarks></remarks>
        [Category("カスタム")]
        [DisplayName(nameof(NotNull))]
        [Description("テキストボックスの必須項目を設定します。")]
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
        /// 改行処理
        /// （マルチライン時の改行の処理を設定します。True:改行許可 False:改行不可)
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool LineFeedProcessing
        {
            get
            {
                return _LineFeedProcessing;
            }

            set
            {
                _LineFeedProcessing = value;
            }
        }

        /// <summary>
        /// SJISのみ
        /// （入力文字列がSJISのみか設定をします。)
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool SJISOnly
        {
            get
            {
                return _SJISOnly;
            }

            set
            {
                _SJISOnly = value;
            }
        }

        /// <summary>
        /// テキストボックスの幅設定
        /// </summary>
        /// <returns></returns>
        [Category("カスタム")]
        [DisplayName(nameof(TextInputMode))]
        [Description("半角/全角項目の幅設定をします。")]
        public InputMode TextInputMode
        {
            get
            {
                return _TextInputMode;
            }

            set
            {
                _TextInputMode = value;
            }
        }

        /// <summary>
        /// テキストボックスの幅設定プロパティ
        /// </summary>
        /// <returns></returns>
        [Category("カスタム")]
        [DisplayName(nameof(CharLength))]
        [Description("テキストボックスに入力できる最大文字数を取得または設定します。" + "また、テキストボックスの横幅を設定します。")]
        public int CharLength
        {
            get
            {
                setTextBoxWidth(_CharLength);
                return _CharLength;
            }

            set
            {
                _CharLength = value;
                setTextBoxWidth(_CharLength);
            }
        }

        /// <summary>
        /// 読み込み専用プロパティ
        /// </summary>
        /// <returns></returns>
        /// <remarks>読み込み専用にした場合、同時にTabStopがかかるようになる。</remarks>
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
                    if (ExistError)
                    {
                        this.BackColor = BackColorType.InputError();
                    }
                    else if (NotNull)
                    {
                        this.BackColor = BackColorType.InputMust();
                    }
                    else
                    {
                        this.BackColor = BackColorType.Standard();
                    }
                }
            }
        }


        /// <summary>
        /// 書式種別プロパティ
        /// </summary>
        /// <returns></returns>
        //[Category("カスタム")]
        //[DisplayName(nameof(FormatType))]
        //[Description("書式種別を設定します。")]
        //public ControlFormat? FormatType
        //{
        //    get
        //    {
        //        return _FormatType;
        //    }

        //    set
        //    {
        //        _FormatType = value;
        //        if (value is object)
        //        {
        //            this.Format = setControlFormat(value);
        //            this.ImeMode = getImeMode(value);
        //        }
        //    }
        //}

        //private void TextBoxEx_KeyDown(object sender, Global.System.Windows.Forms.KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        if (Multiline)
        //        {
        //            if (!_LineFeedProcessing)
        //            {
        //                e.Handled = true;
        //                e.SuppressKeyPress = true;
        //            }
        //        }
        //    }
        //}

        // ''' <summary>
        // ''' 改行対応（ペースト時）
        // ''' （改行コードを削除します。)
        // ''' </summary>
        // ''' <remarks></remarks>
        // ''' TODO:コメント化
        // '''Private Sub TextBoxEx_TextChanging(ByVal sender As Object, ByVal e As GrapeCity.Win.Editors.TextChangingEventArgs) Handles Me.TextChanging
        // '''    If Not _LineFeedProcessing Then
        // '''        Dim posi As Integer = e.Result.IndexOf(vbCrLf)
        // '''        If posi >= 0 Then
        // '''            e.Cancel = True
        // '''            Text = e.Result.Replace(vbCrLf, "")
        // '''            SelectionStart = Text.Length
        // '''        End If
        // '''    End If
        // '''End Sub

        /// <summary>
        /// テキストボックスの桁数を設定
        /// </summary>
        /// <param name="length">最大桁数</param>
        private void setTextBoxWidth(int length)
        {

            // 最大桁数設定
            this.MaxLength = length;
            int deffSize = 0;
            switch (TextInputMode)
            {
                case InputMode.Full:
                    {
                        if (length > 1)
                        {
                            deffSize = DefFullSize * (length - 1);
                        }

                        this.Width = DefaultFullWidth + deffSize;
                        break;
                    }

                case InputMode.Half:
                    {
                        if (length > 1)
                        {
                            deffSize = DefHalfSize * (length - 1);
                        }

                        this.Width = DefaultHalfWidth + deffSize;
                        break;
                    }
            }
        }

        //private ImeMode getImeMode(ControlFormat value)
        //{
        //    switch (value)
        //    {
        //        case var @case when @case == ControlFormat.None:
        //            {
        //                // 全角半角混在（IME初期=Hiragana)
        //                return ImeMode.Hiragana;
        //            }

        //        case var case1 when case1 == ControlFormat.Zenkaku:
        //            {
        //                // 全角の場合
        //                return ImeMode.Hiragana;
        //            }

        //        case var case2 when case2 == ControlFormat.HankakuKatakana:
        //            {
        //                // 半角ｶﾅの場合
        //                return ImeMode.KatakanaHalf;
        //            }
        //    }

        //    // 上記以外の場合 (IME使用不可)
        //    return ImeMode.Disable;
        //}        
    }
    #endregion
}