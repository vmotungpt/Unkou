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
    public partial class FromToDateEx
    {
        public FromToDateEx()
        {
            #region メソッド

            #region イベント

            /// <summary>
            /// FromTo日付Exロードイベント
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

            /// <summary> 年月日(8桁) </summary>
            YYYYMMDD = 0,
            /// <summary> 年月日(6桁) </summary>
            YYMMDD = 1,
            /// <summary> 月日(4桁) </summary>
            MMDD = 2,
            /// <summary> 年月(6桁) </summary>
            YYYYMM = 3,
            /// <summary> 年月(4桁) </summary>
            YYMM = 4
        }

        #endregion

        #region 変数

        /// <summary>
        /// 必須項目日付
        /// </summary>
        private bool _notNullForDate = false;


        /// <summary>
        /// 必須項目From日付
        /// </summary>
        private bool _notNullForFromDate = false;

        /// <summary>
        /// 必須項目To日付
        /// </summary>
        private bool _notNullForToDate = false;

        /// <summary>
        /// 必須項目From日付 or To日付
        /// </summary>
        private bool _notNullForFromOrToDate = false;


        /// <summary>
        /// エラー情報有無From日付
        /// </summary>
        private bool _existErrorForFromDate = false;

        /// <summary>
        /// エラー情報有無To日付
        /// </summary>
        private bool _existErrorForToDate = false;

        /// <summary>
        /// テキストタイプ
        /// </summary>
        private DateType _textType = DateType.YYYYMMDD;

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
        /// 必須項目From日付プロパティ
        /// </summary>
        /// <value>Ture:必須／False:任意</value>
        /// (プロパティ値を変更することにより、背景色が変更されます。)
        /// <returns></returns>
        /// <remarks></remarks>
        [Category("カスタム")]
        [DisplayName(nameof(NotNullForFromDate))]
        [Description("From日付の必須項目を設定します。")]
        public bool NotNullForFromDate
        {
            get
            {
                return _notNullForDate;
            }

            set
            {
                setNotNullState(value);
            }
        }

        /// <summary>
        /// 必須項目To日付プロパティ
        /// </summary>
        /// <value>Ture:必須／False:任意</value>
        /// (プロパティ値を変更することにより、背景色が変更されます。)
        /// <returns></returns>
        /// <remarks></remarks>
        [Category("カスタム")]
        [DisplayName(nameof(NotNullForToDate))]
        [Description("To日付の必須項目を設定します。")]
        public bool NotNullForToDate
        {
            get
            {
                return _notNullForDate;
            }

            set
            {
                setNotNullState(value);
            }
        }

        /// <summary>
        /// 必須項目From日付 or To日付プロパティ
        /// </summary>
        /// <value>Ture:必須／False:任意</value>
        /// (プロパティ値を変更することにより、背景色が変更されます。)
        /// <returns></returns>
        /// <remarks></remarks>
        [Category("カスタム")]
        [DisplayName(nameof(NotNullForFromOrToDate))]
        [Description("From日付 or To日付の必須項目を設定します。")]
        public bool NotNullForFromOrToDate
        {
            get
            {
                return _notNullForDate;
            }

            set
            {
                setNotNullState(value);
            }
        }

        /// <summary>
        /// エラー有無From日付プロパティ
        /// (プロパティ値を変更することにより、背景色が変更されます。)
        /// </summary>
        /// <value>Ture:エラー有／False:エラー無</value>
        /// <returns></returns>
        /// <remarks></remarks>
        [Browsable(false)]
        public bool ExistErrorForFromDate
        {
            get
            {
                return _existErrorForFromDate;
            }

            set
            {
                _existErrorForFromDate = value;
                this.dtmFromDate.ExistError = _existErrorForFromDate;
            }
        }

        /// <summary>
        /// エラー有無To日付プロパティ
        /// (プロパティ値を変更することにより、背景色が変更されます。)
        /// </summary>
        /// <value>Ture:エラー有／False:エラー無</value>
        /// <returns></returns>
        /// <remarks></remarks>
        [Browsable(false)]
        public bool ExistErrorForToDate
        {
            get
            {
                return _existErrorForToDate;
            }

            set
            {
                _existErrorForToDate = value;
                this.dtmToDate.ExistError = _existErrorForToDate;
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
        /// From日付プロパティ
        /// </summary>
        /// <returns></returns>
        [Category("カスタム")]
        [DisplayName(nameof(FromDateText))]
        [Description("From日付の値を取得します。")]
        public DateTime? FromDateText
        {
            get
            {
                return this.dtmFromDate.Value;
            }

            set
            {
                this.dtmFromDate.Value = value;
            }
        }

        /// <summary>
        /// To日付プロパティ
        /// </summary>
        /// <returns></returns>
        [Category("カスタム")]
        [DisplayName(nameof(ToDateText))]
        [Description("To日付の値を取得します。")]
        public DateTime? ToDateText
        {
            get
            {
                return this.dtmToDate.Value;
            }

            set
            {
                this.dtmToDate.Value = value;
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
                this.dtmFromDate.ReadOnly = value;
                this.dtmToDate.ReadOnly = value;
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
        /// From日付プロパティ
        /// </summary>
        /// <returns></returns>
        [Category("カスタム")]
        [DisplayName(nameof(FromDateValueInt))]
        [Description("From日付の値を取得します。")]
        public int? FromDateValueInt
        {
            get
            {
                try
                {
                    return int.Parse(this.dtmFromDate.Text.ToString().Replace("/", ""));
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
                    this.dtmFromDate.Value = DateTime.ParseExact(Convert.ToString(value), "yyyyMMdd", null);
                }
                catch (Exception ex)
                {
                    this.dtmFromDate.Value = null;
                }
            }
        }

        /// <summary>
        /// To日付プロパティ
        /// </summary>
        /// <returns></returns>
        [Category("カスタム")]
        [DisplayName(nameof(ToDateValueInt))]
        [Description("To日付の値を取得します。")]
        public int? ToDateValueInt
        {
            get
            {
                try
                {
                    return int.Parse(this.dtmToDate.Text.ToString().Replace("/", ""));
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
                    this.dtmToDate.Value = DateTime.ParseExact(Convert.ToString(value), "yyyyMMdd", null);
                }
                catch (Exception ex)
                {
                    this.dtmToDate.Value = null;
                }
            }
        }

        private void FromToDateEx_Load(object sender, EventArgs e)
        {
            setTextAlignment(TextAlignment);
            setDateInputFormat(TextType);
            setDateDisplayFormat(TextType);
        }


        /// <summary>
        /// From値変更時イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtmFromDate_TextChanged(object sender, EventArgs e)
        {
            // 変更前のFromTOが同値である場合、Fromの変更値にてTo値を上書き
            if (_FromToSameFlg == true)
            {
                dtmToDate.Text = dtmFromDate.Text;
            }

            // ブランクにした場合To値もブランク
            if (string.IsNullOrEmpty(Strings.Replace(Strings.Replace(dtmFromDate.Text, "_", ""), "/", "")))
            {
                dtmToDate.Text = dtmFromDate.Text;
            }

            // From/To日付矛盾の場合
            //if (dtmFromDate.Text > dtmToDate.Text)
            //{
            //    dtmToDate.Text = dtmFromDate.Text;
            //}

            setFromToSameFlg();
        }

        /// <summary>
        /// To値変更時イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtmToDate_TextChanged(object sender, EventArgs e)
        {

            // To値がブランクの場合、From値もブランク
            if (string.IsNullOrEmpty(Strings.Replace(Strings.Replace(dtmToDate.Text, "_", ""), "/", "")))
            {
                dtmFromDate.Text = dtmToDate.Text;
            }

            // From値がブランクの場合、To値にて上書き
            if (string.IsNullOrEmpty(Strings.Replace(Strings.Replace(dtmFromDate.Text, "_", ""), "/", "")))
            {
                dtmFromDate.Text = dtmToDate.Text;
            }

            // From/To日付矛盾の場合
            //if (dtmFromDate.Text > dtmToDate.Text)
            //{
            //    dtmFromDate.Text = dtmToDate.Text;
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
            dtmFromDate.ContentAlignment = textAlignment;
            dtmToDate.ContentAlignment = textAlignment;
        }

        /// <summary>
        /// 入力フォーマット設定
        /// </summary>
        /// <param name="textType">日付種別</param>
        private void setDateInputFormat(DateType textType)
        {
            this.dtmFromDate.Fields.Clear();
            this.dtmToDate.Fields.Clear();
            switch (textType)
            {
                case DateType.YYYYMMDD:
                    {
                        var fromYear = new DateYearField(YearDigitType.FourDigitYear);
                        var fromLiteral1 = new DateLiteralField("/");
                        var fromMonth = new DateMonthField(MonthPattern.Number);
                        var fromLiteral2 = new DateLiteralField("/");
                        var fromDay = new DateDayField();
                        var toYear = new DateYearField(YearDigitType.FourDigitYear);
                        var toLiteral1 = new DateLiteralField("/");
                        var toMonth = new DateMonthField(MonthPattern.Number);
                        var toLiteral2 = new DateLiteralField("/");
                        var toDay = new DateDayField();
                        this.dtmFromDate.Fields.AddRange(new DateField[] { fromYear, fromLiteral1, fromMonth, fromLiteral2, fromDay });
                        this.dtmToDate.Fields.AddRange(new DateField[] { toYear, toLiteral1, toMonth, toLiteral2, toDay });
                        break;
                    }

                case DateType.YYMMDD:
                    {
                        var fromYear = new DateYearField(YearDigitType.TwoDigitYear);
                        var fromLiteral1 = new DateLiteralField("/");
                        var fromMonth = new DateMonthField(MonthPattern.Number);
                        var fromLiteral2 = new DateLiteralField("/");
                        var fromDay = new DateDayField();
                        var toYear = new DateYearField(YearDigitType.TwoDigitYear);
                        var toLiteral1 = new DateLiteralField("/");
                        var toMonth = new DateMonthField(MonthPattern.Number);
                        var toLiteral2 = new DateLiteralField("/");
                        var toDay = new DateDayField();
                        this.dtmFromDate.Fields.AddRange(new DateField[] { fromYear, fromLiteral1, fromMonth, fromLiteral2, fromDay });
                        this.dtmToDate.Fields.AddRange(new DateField[] { toYear, toLiteral1, toMonth, toLiteral2, toDay });
                        break;
                    }

                case DateType.MMDD:
                    {
                        var fromMonth = new DateMonthField(MonthPattern.Number);
                        var fromLiteral2 = new DateLiteralField("/");
                        var fromDay = new DateDayField();
                        var toMonth = new DateMonthField(MonthPattern.Number);
                        var toLiteral2 = new DateLiteralField("/");
                        var toDay = new DateDayField();
                        this.dtmFromDate.Fields.AddRange(new DateField[] { fromMonth, fromLiteral2, fromDay });
                        this.dtmToDate.Fields.AddRange(new DateField[] { toMonth, toLiteral2, toDay });
                        break;
                    }

                case DateType.YYYYMM:
                    {
                        var fromYear = new DateYearField(YearDigitType.FourDigitYear);
                        var fromLiteral1 = new DateLiteralField("/");
                        var fromMonth = new DateMonthField(MonthPattern.Number);
                        var toYear = new DateYearField(YearDigitType.FourDigitYear);
                        var toLiteral1 = new DateLiteralField("/");
                        var toMonth = new DateMonthField(MonthPattern.Number);
                        this.dtmFromDate.Fields.AddRange(new DateField[] { fromYear, fromLiteral1, fromMonth });
                        this.dtmToDate.Fields.AddRange(new DateField[] { toYear, toLiteral1, toMonth });
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
                        this.dtmFromDate.Fields.AddRange(new DateField[] { fromYear, fromLiteral1, fromMonth });
                        this.dtmToDate.Fields.AddRange(new DateField[] { toYear, toLiteral1, toMonth });
                        break;
                    }

                default:
                    {
                        var fromYear = new DateYearField(YearDigitType.FourDigitYear);
                        var fromLiteral1 = new DateLiteralField("/");
                        var fromMonth = new DateMonthField(MonthPattern.Number);
                        var fromLiteral2 = new DateLiteralField("/");
                        var fromDay = new DateDayField();
                        var toYear = new DateYearField(YearDigitType.FourDigitYear);
                        var toLiteral1 = new DateLiteralField("/");
                        var toMonth = new DateMonthField(MonthPattern.Number);
                        var toLiteral2 = new DateLiteralField("/");
                        var toDay = new DateDayField();
                        this.dtmFromDate.Fields.AddRange(new DateField[] { fromYear, fromLiteral1, fromMonth, fromLiteral2, fromDay });
                        this.dtmToDate.Fields.AddRange(new DateField[] { toYear, toLiteral1, toMonth, toLiteral2, toDay });
                        break;
                    }
            }
        }

        /// <summary>
        /// 表示フォーマット設定
        /// </summary>
        /// <param name="textType">日付種別</param>
        private void setDateDisplayFormat(DateType textType)
        {
            this.dtmFromDate.DisplayFields.Clear();
            this.dtmToDate.DisplayFields.Clear();
            switch (textType)
            {
                case DateType.YYYYMMDD:
                    {
                        var fromYear = new DateYearDisplayField(false, YearDigitType.FourDigitYear);
                        var fromLiteral1 = new DateLiteralDisplayField("/");
                        var fromMonth = new DateMonthDisplayField(true, MonthPattern.Number);
                        var fromLiteral2 = new DateLiteralDisplayField("/");
                        var fromDay = new DateDayDisplayField(true);
                        var toYear = new DateYearDisplayField(false, YearDigitType.FourDigitYear);
                        var toLiteral1 = new DateLiteralDisplayField("/");
                        var toMonth = new DateMonthDisplayField(true, MonthPattern.Number);
                        var toLiteral2 = new DateLiteralDisplayField("/");
                        var toDay = new DateDayDisplayField(true);
                        this.dtmFromDate.DisplayFields.AddRange(new DateDisplayField[] { fromYear, fromLiteral1, fromMonth, fromLiteral2, fromDay });
                        this.dtmToDate.DisplayFields.AddRange(new DateDisplayField[] { toYear, toLiteral1, toMonth, toLiteral2, toDay });
                        break;
                    }

                case DateType.YYMMDD:
                    {
                        var fromYear = new DateYearDisplayField(false, YearDigitType.TwoDigitYear);
                        var fromLiteral1 = new DateLiteralDisplayField("/");
                        var fromMonth = new DateMonthDisplayField(true, MonthPattern.Number);
                        var fromLiteral2 = new DateLiteralDisplayField("/");
                        var fromDay = new DateDayDisplayField(true);
                        var toYear = new DateYearDisplayField(false, YearDigitType.TwoDigitYear);
                        var toLiteral1 = new DateLiteralDisplayField("/");
                        var toMonth = new DateMonthDisplayField(true, MonthPattern.Number);
                        var toLiteral2 = new DateLiteralDisplayField("/");
                        var toDay = new DateDayDisplayField(true);
                        this.dtmFromDate.DisplayFields.AddRange(new DateDisplayField[] { fromYear, fromLiteral1, fromMonth, fromLiteral2, fromDay });
                        this.dtmToDate.DisplayFields.AddRange(new DateDisplayField[] { toYear, toLiteral1, toMonth, toLiteral2, toDay });
                        break;
                    }

                case DateType.MMDD:
                    {
                        var fromMonth = new DateMonthDisplayField(true, MonthPattern.Number);
                        var fromLiteral2 = new DateLiteralDisplayField("/");
                        var fromDay = new DateDayDisplayField(true);
                        var toMonth = new DateMonthDisplayField(true, MonthPattern.Number);
                        var toLiteral2 = new DateLiteralDisplayField("/");
                        var toDay = new DateDayDisplayField(true);
                        this.dtmFromDate.DisplayFields.AddRange(new DateDisplayField[] { fromMonth, fromLiteral2, fromDay });
                        this.dtmToDate.DisplayFields.AddRange(new DateDisplayField[] { toMonth, toLiteral2, toDay });
                        break;
                    }

                case DateType.YYYYMM:
                    {
                        var fromYear = new DateYearDisplayField(false, YearDigitType.FourDigitYear);
                        var fromLiteral1 = new DateLiteralDisplayField("/");
                        var fromMonth = new DateMonthDisplayField(true, MonthPattern.Number);
                        var toYear = new DateYearDisplayField(false, YearDigitType.FourDigitYear);
                        var toLiteral1 = new DateLiteralDisplayField("/");
                        var toMonth = new DateMonthDisplayField(true, MonthPattern.Number);
                        this.dtmFromDate.DisplayFields.AddRange(new DateDisplayField[] { fromYear, fromLiteral1, fromMonth });
                        this.dtmToDate.DisplayFields.AddRange(new DateDisplayField[] { toYear, toLiteral1, toMonth });
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
                        this.dtmFromDate.DisplayFields.AddRange(new DateDisplayField[] { fromYear, fromLiteral1, fromMonth });
                        this.dtmToDate.DisplayFields.AddRange(new DateDisplayField[] { toYear, toLiteral1, toMonth });
                        break;
                    }

                default:
                    {
                        var fromYear = new DateYearDisplayField(false, YearDigitType.FourDigitYear);
                        var fromLiteral1 = new DateLiteralDisplayField("/");
                        var fromMonth = new DateMonthDisplayField(true, MonthPattern.Number);
                        var fromLiteral2 = new DateLiteralDisplayField("/");
                        var fromDay = new DateDayDisplayField(true);
                        var toYear = new DateYearDisplayField(false, YearDigitType.FourDigitYear);
                        var toLiteral1 = new DateLiteralDisplayField("/");
                        var toMonth = new DateMonthDisplayField(true, MonthPattern.Number);
                        var toLiteral2 = new DateLiteralDisplayField("/");
                        var toDay = new DateDayDisplayField(true);
                        this.dtmFromDate.DisplayFields.AddRange(new DateDisplayField[] { fromYear, fromLiteral1, fromMonth, fromLiteral2, fromDay });
                        this.dtmToDate.DisplayFields.AddRange(new DateDisplayField[] { toYear, toLiteral1, toMonth, toLiteral2, toDay });
                        break;
                    }
            }
        }

        /// <summary>
        /// From日付とTo日付のNotNull制約を設定
        /// </summary>
        /// <param name="value"></param>
        private void setNotNullState(object value)
        {
            if (_notNullForDate == false)
            {
                _notNullForDate = Convert.ToBoolean(value);
            }

            this.dtmFromDate.NotNull = _notNullForDate;
            this.dtmToDate.NotNull = _notNullForDate;
        }

        /// <summary>
        /// From値とTo値が同値である場合_FromToSameFlgにTrueをセット、同値でない場合Falseをセット
        /// </summary>
        private void setFromToSameFlg()
        {
            if (dtmFromDate.Text == dtmToDate.Text)
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
        /// FromDateへフォーカス
        /// </summary>
        public void FocusFromDate()
        {
            this.dtmFromDate.Focus();
        }

        /// <summary>
        /// ToDateへフォーカス
        /// </summary>
        public void FocusToDate()
        {
            this.dtmToDate.Focus();
        }
        #endregion

        #endregion

    }
    #endregion
}
