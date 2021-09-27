using System;
using System.ComponentModel;
using System.Windows.Forms;
using GrapeCity.Win.Editors.Fields;
using Microsoft.VisualBasic; // Install-Package Microsoft.VisualBasic
using Microsoft.VisualBasic.CompilerServices; // Install-Package Microsoft.VisualBasic
using Unkou.Common;

namespace Unkou.UserControl
{
    public partial class Time24Ex : TimeEx
    {

        #region  変数／定数 
        // 時間種別
        private TimeKinds _timeKind;

        // 時間書式
        private const string TimeDefaultString = "0";
        // 時間表示区切り文字
        private const string TimeLiteralChar = ":";
        // 時間に何も入力されていないとき表示するプロンプト文字
        private const string TimePromptChar = "_";
        // 時間に何も入力されていないとき表示する文字列 (__:__)
        private string _displayNullChar = string.Concat(Strings.StrDup(2, TimePromptChar), TimeLiteralChar, Strings.StrDup(2, TimePromptChar));

        /// <summary>
        /// 時間種別
        /// </summary>
        /// <remarks></remarks>
        public enum TimeKinds : int
        {
            [Value("その他 (指定なし)")]
            OTHER_TIME,
            [Value("集合時間")]
            SYUGO_TIME,
            [Value("出発時間")]
            SYUPT_TIME,
            [Value("終了時間")]
            END_TIME,
            [Value("到着時間")]
            TTYAK_TIME
        }

        #region 各種時間設定値
        /// <summary>
        /// その他 (指定なし) ※00:00 ～ 23:59
        /// </summary>
        /// <remarks></remarks>
        public sealed partial class OtherTImeInfo
        {
            [Value("最小時間")]
            public const string MinTime = "00:00";
            [Value("最大時間")]
            public const string MaxTime = "23:59";
        }

        /// <summary>
        /// 集合時間
        /// </summary>
        /// <remarks></remarks>
        public sealed partial class SyugoTImeInfo
        {
            [Value("最小時間")]
            public const string MinTime = "00:01";
            [Value("最大時間")]
            public const string MaxTime = "27:59";
        }

        /// <summary>
        /// 出発時間
        /// </summary>
        /// <remarks></remarks>
        public sealed partial class SyuptTImeInfo
        {
            [Value("最小時間")]
            public const string MinTime = "00:01";
            [Value("最大時間")]
            public const string MaxTime = "27:59";
        }

        /// <summary>
        /// 終了時間
        /// </summary>
        /// <remarks></remarks>
        public sealed partial class EndTImeInfo
        {
            [Value("最小時間")]
            public const string MinTime = "00:01";
            [Value("最大時間")]
            public const string MaxTime = "27:59";
        }

        /// <summary>
        /// 到着時間
        /// </summary>
        /// <remarks></remarks>
        public sealed partial class TtyakTImeInfo
        {
            [Value("最小時間")]
            public const string MinTime = "00:01";
            [Value("最大時間")]
            public const string MaxTime = "27:59";
        }
        #endregion

        #endregion

        #region  コンストラクタ

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <remarks></remarks>
        public Time24Ex() : base()
        {
            var dateMinuteField = new DateMinuteField();
            var dateSecondField = new DateSecondField();
            var dateLiteralField = new DateLiteralField(TimeLiteralChar);
            Fields.AddRange(new DateField[] { dateMinuteField, dateLiteralField, dateSecondField });
            DisplayFields.Clear();
            var dateMinuteDisplayField = new DateMinuteDisplayField();
            var dateSecondDisplayField = new DateSecondDisplayField();
            var dateLiteralDisplayField = new DateLiteralDisplayField(TimeLiteralChar);
            dateMinuteDisplayField.ShowLeadingZero = true;
            dateSecondDisplayField.ShowLeadingZero = true;
            DisplayFields.AddRange(new DateDisplayField[] { dateMinuteDisplayField, dateLiteralDisplayField, dateSecondDisplayField });
            this.AlternateText.DisplayNull.Text = _displayNullChar;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;

            // 時間種別 (初期値)
            TimeKind = TimeKinds.OTHER_TIME;
        }

        #endregion

        #region 継承コントロールをフォームにドロップした時の制御
        // 継承コントロールをフォームにドロップした時にコントロールに
        // 入力フィールドが追加される動作を無効にします。
        public TimeFieldCollection Fields
        {
            get
            {
                return (TimeFieldCollection)base.Fields;
            }
        }

        private bool ShouldSerializeFields()
        {
            return false;
        }

        // 継承コントロールをフォームにドロップした時にコントロールに
        // 表示フィールドが追加される動作を無効にします。
        public TimeDisplayFieldCollection DisplayFields
        {
            get
            {
                return (TimeDisplayFieldCollection)base.DisplayFields;
            }
        }

        private bool ShouldSerializeDisplayFields()
        {
            return false;
        }

        #endregion

        #region プロパティ

        #region 時間種別プロパティ
        /// <summary>
        /// 時間種別プロパティ
        /// (プロパティ値を変更することにより、時間の範囲が変更されます。)
        /// </summary>
        /// <value>TimeKinds</value>
        /// <returns></returns>
        /// <remarks></remarks>
        [Category("カスタム")]
        [DisplayName(nameof(TimeKind))]
        [Description("時間種別を設定します")]
        public TimeKinds TimeKind
        {
            get
            {
                return _timeKind;
            }

            set
            {

                // 時間種別
                if (Information.IsNothing(value))
                {
                    // Nothing の場合、その他 (指定なし)を設定
                    _timeKind = TimeKinds.OTHER_TIME;
                }
                else
                {
                    // Nothing 以外の場合、指定値を設定
                    _timeKind = value;
                }

                // 時間種別に応じて時間の設定を行なう
                setInitTime(_timeKind);
            }
        }
        #endregion

        #region 時間最小値プロパティ
        /// <summary>
        /// 時間最小値プロパティ
        /// (プロパティ値を変更することにより、時間最小値が変更されます。)
        /// </summary>
        /// <value>時分[HH:MM]</value>
        /// <returns></returns>
        /// <remarks></remarks>
        [Category("カスタム")]
        [DisplayName(nameof(MinValue24))]
        [Description("時間最小値プロパティの値を取得または設定します")]
        public string MinValue24
        {
            get
            {
                // 時間最小値を取得 (親コントロールから取得) (00:12:34)→(12:34)
                return getMyBaseMinValue();
            }

            set
            {
                // 時間最小値を設定 (親コントロールに反映) (12:34)→(00:12:34)
                setMyBaseMinValue(value);
            }
        }
        #endregion

        #region 時間最大値プロパティ
        /// <summary>
        /// 時間最大値プロパティ
        /// (プロパティ値を変更することにより、時間最大値が変更されます。)
        /// </summary>
        /// <value>時分[HH:MM]</value>
        /// <returns></returns>
        /// <remarks></remarks>
        [Category("カスタム")]
        [DisplayName(nameof(MaxValue24))]
        [Description("時間最大値プロパティの値を取得または設定します")]
        public string MaxValue24
        {
            get
            {
                // 時間最最大値を取得 (親コントロールから取得) (00:12:34)→(12:34)
                return getMyBaseMaxValue();
            }

            set
            {
                // 時間最大値を設定 (親コントロールに反映) (12:34)→(00:12:34)
                setMyBaseMaxValue(value);
            }
        }
        #endregion

        #region 時間プロパティ
        /// <summary>
        /// 時間プロパティ (String型) ※ ex) 1:00 → 01:00
        /// (プロパティ値を変更することにより、時間が変更されます。)
        /// </summary>
        /// <value>時分[HH:MM]</value>
        /// <returns></returns>
        /// <remarks></remarks>
        [Category("カスタム")]
        [DisplayName(nameof(Value24))]
        [Description("時間プロパティの値を取得または設定します")]
        public string Value24
        {
            get
            {
                // 時間値を取得 (親コントロールから取得) (00:12:34)→(12:34)
                return getMyBaseValue();
            }

            set
            {
                // 時間値を設定 (親コントロールに反映) (12:34)→(00:12:34)
                setMyBaseValue(value);
            }
        }
        #endregion

        #region 時間プロパティ
        /// <summary>
        /// 時間プロパティ (Interger型) ※ ex) 01:00 → 100
        /// (プロパティ値を変更することにより、時間が変更されます。)
        /// </summary>
        /// <value>時分[HH:MM]</value>
        /// <returns></returns>
        /// <remarks></remarks>
        [Category("カスタム")]
        [DisplayName(nameof(Value24Int))]
        [Description("時間プロパティの値を取得または設定します")]
        public int? Value24Int
        {
            get
            {
                // 時間値を取得 (親コントロールから取得) (00:12:34)→(12:34)
                return cnvTimeStringToInteger(getMyBaseValue());
            }

            set
            {
                // Integer値を[時:分]書式に変換する (1234)→(12:34)
                string timeValue = cnvIntValueToDispValue(value);
                // 時間値を設定 (親コントロールに反映) (12:34)→(00:12:34)
                setMyBaseValue(timeValue);
            }
        }
        #endregion

        #endregion

        #region  メソッド 

        #region 時間種別に応じて時間の設定を行なう
        /// <summary>
        /// 時間種別に応じて時間の設定を行なう
        /// </summary>
        /// <param name="timeKind"></param>
        private void setInitTime(TimeKinds timeKind)
        {
            object timeInfo = null;
            switch (timeKind)
            {
                case TimeKinds.SYUGO_TIME:
                    {
                        // 集合時間
                        timeInfo = new SyugoTImeInfo();
                        break;
                    }

                case TimeKinds.SYUPT_TIME:
                    {
                        // 出発時間
                        timeInfo = new SyuptTImeInfo();
                        break;
                    }

                case TimeKinds.END_TIME:
                    {
                        // 終了時間
                        timeInfo = new EndTImeInfo();
                        break;
                    }

                case TimeKinds.TTYAK_TIME:
                    {
                        // 到着時間
                        timeInfo = new TtyakTImeInfo();
                        break;
                    }

                default:
                    {
                        // その他 (指定なし)
                        timeInfo = new OtherTImeInfo();
                        break;
                    }
            }

            string minTime = Conversions.ToString("00:01");
            string maxTime = Conversions.ToString("27:59");


            // 時間最小値を設定 (親コントロールに反映)
            setMyBaseMinValue(minTime);

            // 時間最大値を設定 (親コントロールに反映)
            setMyBaseMaxValue(maxTime);
        }
        #endregion

        #region 時間最小値を取得 (親コントロールから取得) (00:12:34)→(12:34)
        /// <summary>
        /// 時間最小値を取得 (親コントロールから取得) (00:12:34)→(12:34)
        /// </summary>
        /// <returns></returns>
        private string getMyBaseMinValue()
        {
            return cutHourTime(base.MinValue);
        }
        #endregion

        #region 時間最大値を取得 (親コントロールから取得) (00:12:34)→(12:34)
        /// <summary>
        /// 時間最大値を取得 (親コントロールから取得) (00:12:34)→(12:34)
        /// </summary>
        /// <returns></returns>
        private string getMyBaseMaxValue()
        {
            return cutHourTime(base.MaxValue);
        }
        #endregion

        #region 時間を取得 (親コントロールから取得) (00:12:34)→(12:34)
        /// <summary>
        /// 時間を取得 (親コントロールから取得) (00:12:34)→(12:34)
        /// </summary>
        /// <returns></returns>
        private string getMyBaseValue()
        {
            return cutHourTime(base.Value);
        }
        #endregion

        #region 時間最小値を設定 (親コントロールに反映) (12:34)→(00:12:34)
        /// <summary>
        /// 時間最小値を設定 (親コントロールに反映) (12:34)→(00:12:34)
        /// </summary>
        /// <param name="minTime24">HH:MM</param>
        private void setMyBaseMinValue(string minTime24)
        {

            // (12:34)→(00:12:34)
            string minTime = addHourTime(minTime24);

            // 親コントロールへ反映
            base.MinValue = TimeSpan.Parse(minTime);
        }
        #endregion

        #region 時間最大値を設定 (親コントロールに反映) (12:34)→(00:12:34)
        /// <summary>
        /// 時間最大値を設定 (親コントロールに反映) (12:34)→(00:12:34)
        /// </summary>
        /// <param name="maxTime24">HH:MM</param>
        private void setMyBaseMaxValue(string maxTime24)
        {

            // (12:34)→(00:12:34)
            string maxTime = addHourTime(maxTime24);

            // 親コントロールへ反映
            base.MaxValue = TimeSpan.Parse(maxTime);
        }
        #endregion

        #region 時間を設定 (親コントロールに反映) (12:34)→(00:12:34)
        /// <summary>
        /// 時間を設定 (親コントロールに反映) (12:34)→(00:12:34)
        /// </summary>
        /// <param name="value24"></param>
        private void setMyBaseValue(string value24)
        {

            // (12:34)→(00:12:34)
            string tgtTime = addHourTime(value24);

            // 時間最小値より小さい場合は Nothing にする
            tgtTime = checkValueForMinTime(tgtTime);

            // 時間最大値より大きい場合は、時間最大値 にする
            tgtTime = checkValueForMaxTime(tgtTime);

            // 親コントロールへ反映
            if (tgtTime is null)
            {
                base.Value = null;
            }
            else
            {
                base.Value = TimeSpan.Parse(tgtTime);
            }
        }
        #endregion

        #region 時間[mm:ss]に [時]を追加する (12:34)→(00:12:34)
        /// <summary>
        /// 時間[mm:ss]に [時]を追加する (12:34)→(00:12:34)
        /// </summary>
        /// <param name="value"></param>
        private string addHourTime(string value)
        {
            var arrTimes = Strings.Split(value, TimeLiteralChar);
            if (arrTimes.Length < 2)
            {
                return null;
            }

            // 配列の添え字
            int idxHour = 0;
            int idxMinute = 1;
            string wkTimes = string.Empty;
            // 時
            wkTimes += Strings.StrDup(2, TimeDefaultString);
            // 分
            wkTimes += TimeLiteralChar;
            wkTimes += arrTimes[idxHour].PadLeft(2, char.Parse(TimeDefaultString));
            // 秒
            wkTimes += TimeLiteralChar;
            wkTimes += arrTimes[idxMinute].PadLeft(2, char.Parse(TimeDefaultString));
            return wkTimes;
        }
        #endregion

        #region 時間[hh:mm:ss]から [時]を消去する (00:12:34)→(12:34)
        /// <summary>
        /// 時間[hh:mm:ss]から [時]を消去する (00:12:34)→(12:34)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private string cutHourTime(TimeSpan? value)
        {
            if (Information.IsNothing(value))
            {
                return null;
            }

            var arrTimes = Strings.Split(value.ToString(), TimeLiteralChar);
            if (arrTimes.Length < 3)
            {
                return null;
            }

            // 配列の添え字
            int idxMinute = 1;
            int idxSecond = 2;
            string wkTimes = string.Empty;
            // 分　→ [時]
            wkTimes += arrTimes[idxMinute].PadLeft(2, char.Parse(TimeDefaultString));
            // 秒　→ [分]
            wkTimes += TimeLiteralChar;
            wkTimes += arrTimes[idxSecond].PadLeft(2, char.Parse(TimeDefaultString));
            return wkTimes;
        }
        #endregion

        #region Integer値を[時:分]書式に変換する
        /// <summary>
        /// Integer値を[時:分]書式に変換する (ex)100→ 01:00
        /// </summary>
        /// <param name="timeValue"></param>
        /// <returns></returns>
        private string cnvIntValueToDispValue(int? timeValue)
        {
            string returnValue = null;
            if (timeValue is null)
            {
                return returnValue;
            }

            if (string.IsNullOrWhiteSpace(timeValue.ToString()))
            {
                return returnValue;
            }

            string dispTimeFormat = _displayNullChar.Replace(TimePromptChar, TimeDefaultString);
            string orgTime = Conversions.ToInteger(timeValue).ToString(dispTimeFormat);
            returnValue = orgTime;
            return returnValue;
        }
        #endregion

        #region [時:分]をInteger書式に変換する
        /// <summary>
        /// [時:分]をInteger型に変換する (ex) 01:00 → 100
        /// </summary>
        /// <param name="timeValue"></param>
        /// <returns></returns>
        private int? cnvTimeStringToInteger(string timeValue)
        {
            int? returnValue = default;
            if (timeValue is null)
            {
                return returnValue;
            }

            // プロンプト文字が存在する場合は Nothing を返す (TimeEx.Value同等) ※timeValue は nothing となっているが念のため
            if (0 <= timeValue.IndexOf(TimePromptChar))
            {
                return returnValue;
            }

            // 文字列を ":" で 区切る
            var ayyTimeValue = Strings.Split(timeValue, TimeLiteralChar);
            if (ayyTimeValue.Length < 2)
            {
                return returnValue;
            }

            // 時・分 のどちらか一方が空白の場合は  Nothing を返す (TimeEx.Value同等) ※timeValue は nothing となっているが念のため
            for (int row = 0, loopTo = ayyTimeValue.Length - 1; row <= loopTo; row++)
            {
                if (string.IsNullOrWhiteSpace(ayyTimeValue[row]))
                {
                    return returnValue;
                }
            }

            // xx:xx → xxxx にして 数値変換する
            returnValue = Conversions.ToInteger(timeValue.Replace(TimeLiteralChar, string.Empty));
            return returnValue;
        }
        #endregion

        #region 引数の時間をチェックし、時間最小値より小さい場合は Nothing を返す
        /// <summary>
        /// 引数の時間をチェックし、時間最小値より小さい場合は Nothing を返す
        /// </summary>
        /// <param name="timeValue">HH:MM:ss</param>
        /// <returns></returns>
        private string checkValueForMinTime(string timeValue)
        {
            string returnValue = timeValue;

            // 時間に変換できない場合は Nothing を返す
            if (Information.IsDate(timeValue) == false)
            {
                return null;
            }

            // 時間最小値より小さい場合は Nothing を返す
            if (TimeSpan.Parse(timeValue) < base.MinValue)
            {
                return null;
            }

            return returnValue;
        }
        #endregion

        #region 引数の時間をチェックし、時間最大値を超えている場合は 時間最大値を返す
        /// <summary>
        /// 引数の時間をチェックし、時間最大値を超えている場合は 時間最大値を返す
        /// </summary>
        /// <param name="timeValue">HH:MM:ss</param>
        /// <returns></returns>
        private string checkValueForMaxTime(string timeValue)
        {
            string returnValue = timeValue;

            // 時間に変換できない場合は Nothing を返す
            if (Information.IsDate(timeValue) == false)
            {
                return null;
            }

            // 時間最大値を超えている場合は 時間最大値 を返す
            if (base.MaxValue < TimeSpan.Parse(timeValue))
            {
                return base.MaxValue.ToString();
            }

            return returnValue;
        }
        #endregion

        #endregion

    }
}
