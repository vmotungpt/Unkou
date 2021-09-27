using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrapeCity.Win.Editors;
using Microsoft.VisualBasic;
using GrapeCity.Win.Editors.Fields;

namespace Unkou.UserControl
{
    public partial class FromToMonthEx
    {
        public FromToMonthEx()
        {
            #region メソッド

            #region イベント

            /// <summary>
            /// FromTo月Exロードイベント
            /// </summary>
            /// <param name="sender">イベント送信元</param>
            /// <param name="e">イベントデータ</param>
        }

        #region Enum

        /// <summary>
        /// 日付種別
        /// </summary>
        public enum DateType
        {

            /// <summary> 年月(6桁) </summary>
            YYYYMM = 1,
            /// <summary> 年月(4桁) </summary>
            YYMM = 2
        }

        #endregion

        #region 変数

        /// <summary>
        /// 必須項目日付
        /// </summary>
        private bool _notNullForMonth = false;

        /// <summary>
        /// 必須項目From月
        /// </summary>
        private bool _notNullForFromMonth = false;

        /// <summary>
        /// 必須項目To月
        /// </summary>
        private bool _notNullForToMonth = false;

        /// <summary>
        /// 必須項目From月 or To月
        /// </summary>
        private bool _notNullForFromOrToMonth = false;


        /// <summary>
        /// エラー情報有無From月
        /// </summary>
        private bool _existErrorForFromMonth = false;

        /// <summary>
        /// エラー情報有無To月
        /// </summary>
        private bool _existErrorForToMonth = false;

        /// <summary>
        /// テキストタイプ
        /// </summary>
        private DateType _textType = DateType.YYYYMM;

        /// <summary>
        /// テキスト配置
        /// </summary>
        private ContentAlignment _textAlignment = ContentAlignment.TopLeft;

        /// <summary>
        /// 読み取り専用
        /// </summary>
        private bool _readOnlyNonTabStop = false;

        /// <summary>
        /// FromTo同値フラグ
        /// </summary>
        private bool _FromToSameFlg = true;

        #endregion

        #region プロパティ

        /// <summary>
        /// 必須項目From月プロパティ
        /// </summary>
        /// <value>Ture:必須／False:任意</value>
        /// (プロパティ値を変更することにより、背景色が変更されます。)
        /// <returns></returns>
        /// <remarks></remarks>
        [Category("カスタム")]
        [DisplayName(nameof(NotNullForFromMonth))]
        [Description("From月の必須項目を設定します。")]
        public bool NotNullForFromMonth
        {
            get
            {
                return _notNullForMonth;
            }

            set
            {
                setNotNullState(value);
            }
        }

        /// <summary>
        /// 必須項目To月プロパティ
        /// </summary>
        /// <value>Ture:必須／False:任意</value>
        /// (プロパティ値を変更することにより、背景色が変更されます。)
        /// <returns></returns>
        /// <remarks></remarks>
        [Category("カスタム")]
        [DisplayName(nameof(NotNullForToMonth))]
        [Description("To月の必須項目を設定します。")]
        public bool NotNullForToMonth
        {
            get
            {
                return _notNullForMonth;
            }

            set
            {
                setNotNullState(value);
            }
        }

        /// <summary>
        /// 必須項目From月 or To月プロパティ
        /// </summary>
        /// <value>Ture:必須／False:任意</value>
        /// (プロパティ値を変更することにより、背景色が変更されます。)
        /// <returns></returns>
        /// <remarks></remarks>
        [Category("カスタム")]
        [DisplayName(nameof(NotNullForFromOrToMonth))]
        [Description("From月 or To月の必須項目を設定します。")]
        public bool NotNullForFromOrToMonth
        {
            get
            {
                return _notNullForMonth;
            }

            set
            {
                setNotNullState(value);
            }
        }

        /// <summary>
        /// エラー有無From月プロパティ
        /// (プロパティ値を変更することにより、背景色が変更されます。)
        /// </summary>
        /// <value>Ture:エラー有／False:エラー無</value>
        /// <returns></returns>
        /// <remarks></remarks>
        [Browsable(false)]
        public bool ExistErrorForFromMonth
        {
            get
            {
                return _existErrorForFromMonth;
            }

            set
            {
                _existErrorForFromMonth = value;
                this.dtmFromMonth.ExistError = _existErrorForFromMonth;
            }
        }

        /// <summary>
        /// エラー有無To月プロパティ
        /// (プロパティ値を変更することにより、背景色が変更されます。)
        /// </summary>
        /// <value>Ture:エラー有／False:エラー無</value>
        /// <returns></returns>
        /// <remarks></remarks>
        [Browsable(false)]
        public bool ExistErrorForToMonth
        {
            get
            {
                return _existErrorForToMonth;
            }

            set
            {
                _existErrorForToMonth = value;
                this.dtmToMonth.ExistError = _existErrorForToMonth;
            }
        }

        /// <summary>
        /// テキストタイプ
        /// </summary>
        /// <returns></returns>
        [Category("カスタム")]
        [DisplayName(nameof(TextType))]
        [Description("入力、表示の日付フォーマットを設定します。")]
        public DateType TextType
        {
            get
            {
                return _textType;
            }

            set
            {
                _textType = value;
            }
        }

        /// <summary>
        /// テキスト配置
        /// </summary>
        /// <returns></returns>
        [Category("カスタム")]
        [DisplayName(nameof(ContentAlignment))]
        [Description("入力、表示の日付フォーマットを設定します。")]
        public ContentAlignment TextAlignment
        {
            get
            {
                return _textAlignment;
            }

            set
            {
                _textAlignment = value;
            }
        }

        /// <summary>
        /// From月プロパティ
        /// </summary>
        /// <returns></returns>
        [Category("カスタム")]
        [DisplayName(nameof(FromMonthText))]
        [Description("From月の値を取得します。")]
        public DateTime? FromMonthText
        {
            get
            {
                return this.dtmFromMonth.Value;
            }

            set
            {
                this.dtmFromMonth.Value = value;
            }
        }

        /// <summary>
        /// To月プロパティ
        /// </summary>
        /// <returns></returns>
        [Category("カスタム")]
        [DisplayName(nameof(ToMonthText))]
        [Description("To月の値を取得します。")]
        public DateTime? ToMonthText
        {
            get
            {
                return this.dtmToMonth.Value;
            }

            set
            {
                this.dtmToMonth.Value = value;
            }
        }

        /// <summary>
        /// 読み取り専用プロパティ
        /// </summary>
        /// <returns></returns>
        [Category("カスタム")]
        [DisplayName(nameof(ReadOnlyNonTabStop))]
        [Description("FromToの日付を読み取り専用にします。")]
        public bool ReadOnlyNonTabStop
        {
            get
            {
                return _readOnlyNonTabStop;
            }

            set
            {
                _readOnlyNonTabStop = value;
                this.dtmFromMonth.ReadOnly = value;
                this.dtmToMonth.ReadOnly = value;
                if (value)
                {
                    this.DropDownButton1.Visible = ButtonVisibility.NotShown;
                    this.DropDownButton2.Visible = ButtonVisibility.NotShown;
                }
                else
                {
                    this.DropDownButton1.Visible = ButtonVisibility.ShowAlways;
                    this.DropDownButton2.Visible = ButtonVisibility.ShowAlways;
                }
            }
        }

        /// <summary>
        /// From月プロパティ
        /// </summary>
        /// <returns></returns>
        [Category("カスタム")]
        [DisplayName(nameof(FromMonthValueInt))]
        [Description("From月の値を取得します。")]
        public int? FromMonthValueInt
        {
            get
            {
                try
                {
                    return int.Parse(this.dtmFromMonth.Text.ToString().Replace("/", ""));
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
                    this.dtmFromMonth.Value = DateTime.ParseExact(Convert.ToString(value), "yyyyMM", null);
                }
                catch (Exception ex)
                {
                    this.dtmFromMonth.Value = null;
                }
            }
        }

        /// <summary>
        /// To月プロパティ
        /// </summary>
        /// <returns></returns>
        [Category("カスタム")]
        [DisplayName(nameof(ToMonthValueInt))]
        [Description("To月の値を取得します。")]
        public int? ToMonthValueInt
        {
            get
            {
                try
                {
                    return int.Parse(this.dtmToMonth.Text.ToString().Replace("/", ""));
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
                    this.dtmToMonth.Value = DateTime.ParseExact(Convert.ToString(value), "yyyyMM", null);
                }
                catch (Exception ex)
                {
                    this.dtmToMonth.Value = null;
                }
            }
        }

        private void FromToMonthEx_Load(object sender, EventArgs e)
        {
            setTextAlignment(TextAlignment);
            setMonthInputFormat(TextType);
            setMonthDisplayFormat(TextType);
        }


        /// <summary>
        /// From値変更時イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtmFromMonth_TextChanged(object sender, EventArgs e)
        {
            // 変更前のFromTOが同値である場合、Fromの変更値にてTo値を上書き
            if (_FromToSameFlg == true)
            {
                dtmToMonth.Text = dtmFromMonth.Text;
            }

            // ブランクにした場合To値もブランク
            if (string.IsNullOrEmpty(Strings.Replace(Strings.Replace(dtmFromMonth.Text, "_", ""), "/", "")))
            {
                dtmToMonth.Text = dtmFromMonth.Text;
            }

            // From/To月矛盾の場合
            //if (dtmFromMonth.Text > dtmToMonth.Text)
            //{
            //    dtmToMonth.Text = dtmFromMonth.Text;
            //}

            setFromToSameFlg();
        }

        /// <summary>
        /// To値変更時イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtmToMonth_TextChanged(object sender, EventArgs e)
        {

            // To値がブランクの場合、From値もブランク
            if (string.IsNullOrEmpty(Strings.Replace(Strings.Replace(dtmToMonth.Text, "_", ""), "/", "")))
            {
                dtmFromMonth.Text = dtmToMonth.Text;
            }

            // From値がブランクの場合、To値にて上書き
            if (string.IsNullOrEmpty(Strings.Replace(Strings.Replace(dtmFromMonth.Text, "_", ""), "/", "")))
            {
                dtmFromMonth.Text = dtmToMonth.Text;
            }

            // From/To月矛盾の場合
            //if (dtmFromMonth.Text > dtmToMonth.Text)
            //{
            //    dtmFromMonth.Text = dtmToMonth.Text;
            //}

            setFromToSameFlg();
        }

        #endregion

        #region Private method

        /// <summary>
        /// テキスト配置
        /// </summary>
        /// <param name="textAlignment"></param>
        private void setTextAlignment(ContentAlignment textAlignment)
        {
            dtmFromMonth.ContentAlignment = textAlignment;
            dtmToMonth.ContentAlignment = textAlignment;
        }

        /// <summary>
        /// 入力フォーマット設定
        /// </summary>
        /// <param name="textType">日付種別</param>
        private void setMonthInputFormat(DateType textType)
        {
            this.dtmFromMonth.Fields.Clear();
            this.dtmToMonth.Fields.Clear();
            switch (textType)
            {
                case DateType.YYYYMM:
                    {
                        var fromYear = new DateYearField(YearDigitType.FourDigitYear);
                        var fromLiteral1 = new DateLiteralField("/");
                        var fromMonth = new DateMonthField(MonthPattern.Number);
                        var toYear = new DateYearField(YearDigitType.FourDigitYear);
                        var toLiteral1 = new DateLiteralField("/");
                        var toMonth = new DateMonthField(MonthPattern.Number);
                        this.dtmFromMonth.Fields.AddRange(new DateField[] { fromYear, fromLiteral1, fromMonth });
                        this.dtmToMonth.Fields.AddRange(new DateField[] { toYear, toLiteral1, toMonth });
                        break;
                    }

                case DateType.YYMM:
                    {
                        var fromYear = new DateYearField(YearDigitType.TwoDigitYear);
                        var fromLiteral1 = new DateLiteralField("/");
                        var fromMonth = new DateMonthField(MonthPattern.Number);
                        var toYear = new DateYearField(YearDigitType.TwoDigitYear);
                        var toLiteral1 = new DateLiteralField("/");
                        var toMonth = new DateMonthField(MonthPattern.Number);
                        this.dtmFromMonth.Fields.AddRange(new DateField[] { fromYear, fromLiteral1, fromMonth });
                        this.dtmToMonth.Fields.AddRange(new DateField[] { toYear, toLiteral1, toMonth });
                        break;
                    }

                default:
                    {
                        var fromYear = new DateYearField(YearDigitType.FourDigitYear);
                        var fromLiteral1 = new DateLiteralField("/");
                        var fromMonth = new DateMonthField(MonthPattern.Number);
                        var toYear = new DateYearField(YearDigitType.FourDigitYear);
                        var toLiteral1 = new DateLiteralField("/");
                        var toMonth = new DateMonthField(MonthPattern.Number);
                        this.dtmFromMonth.Fields.AddRange(new DateField[] { fromYear, fromLiteral1, fromMonth });
                        this.dtmToMonth.Fields.AddRange(new DateField[] { toYear, toLiteral1, toMonth });
                        break;
                    }
            }
        }

        /// <summary>
        /// 表示フォーマット設定
        /// </summary>
        /// <param name="textType">日付種別</param>
        private void setMonthDisplayFormat(DateType textType)
        {
            this.dtmFromMonth.DisplayFields.Clear();
            this.dtmToMonth.DisplayFields.Clear();
            switch (textType)
            {
                case DateType.YYYYMM:
                    {
                        var fromYear = new DateYearDisplayField(false, YearDigitType.FourDigitYear);
                        var fromLiteral1 = new DateLiteralDisplayField("/");
                        var fromMonth = new DateMonthDisplayField(true, MonthPattern.Number);
                        var toYear = new DateYearDisplayField(false, YearDigitType.FourDigitYear);
                        var toLiteral1 = new DateLiteralDisplayField("/");
                        var toMonth = new DateMonthDisplayField(true, MonthPattern.Number);
                        this.dtmFromMonth.DisplayFields.AddRange(new DateDisplayField[] { fromYear, fromLiteral1, fromMonth });
                        this.dtmToMonth.DisplayFields.AddRange(new DateDisplayField[] { toYear, toLiteral1, toMonth });
                        break;
                    }

                case DateType.YYMM:
                    {
                        var fromYear = new DateYearDisplayField(false, YearDigitType.TwoDigitYear);
                        var fromLiteral1 = new DateLiteralDisplayField("/");
                        var fromMonth = new DateMonthDisplayField(true, MonthPattern.Number);
                        var toYear = new DateYearDisplayField(false, YearDigitType.TwoDigitYear);
                        var toLiteral1 = new DateLiteralDisplayField("/");
                        var toMonth = new DateMonthDisplayField(true, MonthPattern.Number);
                        this.dtmFromMonth.DisplayFields.AddRange(new DateDisplayField[] { fromYear, fromLiteral1, fromMonth });
                        this.dtmToMonth.DisplayFields.AddRange(new DateDisplayField[] { toYear, toLiteral1, toMonth });
                        break;
                    }

                default:
                    {
                        var fromYear = new DateYearDisplayField(false, YearDigitType.FourDigitYear);
                        var fromLiteral1 = new DateLiteralDisplayField("/");
                        var fromMonth = new DateMonthDisplayField(true, MonthPattern.Number);
                        var toYear = new DateYearDisplayField(false, YearDigitType.FourDigitYear);
                        var toLiteral1 = new DateLiteralDisplayField("/");
                        var toMonth = new DateMonthDisplayField(true, MonthPattern.Number);
                        this.dtmFromMonth.DisplayFields.AddRange(new DateDisplayField[] { fromYear, fromLiteral1, fromMonth });
                        this.dtmToMonth.DisplayFields.AddRange(new DateDisplayField[] { toYear, toLiteral1, toMonth });
                        break;
                    }
            }
        }

        /// <summary>
        /// From月とTo月のNotNull制約を設定
        /// </summary>
        /// <param name="value"></param>
        private void setNotNullState(object value)
        {
            if (_notNullForMonth == false)
            {
                _notNullForMonth = Convert.ToBoolean(value);
            }

            this.dtmFromMonth.NotNull = _notNullForMonth;
            this.dtmToMonth.NotNull = _notNullForMonth;
        }

        /// <summary>
        /// From値とTo値が同値である場合_FromToSameFlgにTrueをセット、同値でない場合Falseをセット
        /// </summary>
        private void setFromToSameFlg()
        {
            if (dtmFromMonth.Text == dtmToMonth.Text)
            {
                _FromToSameFlg = true;
            }
            else
            {
                _FromToSameFlg = false;
            }
        }

        #endregion

        #region Public Method
        /// <summary>
        /// FromMonthへフォーカス
        /// </summary>
        public void FocusFromMonth()
        {
            this.dtmFromMonth.Focus();
        }

        /// <summary>
        /// ToMonthへフォーカス
        /// </summary>
        public void FocusToMonth()
        {
            this.dtmToMonth.Focus();
        }
        #endregion

        #endregion

    }
    #endregion
}
