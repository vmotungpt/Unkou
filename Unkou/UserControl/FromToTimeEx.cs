using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrapeCity.Win.Editors.Fields;

namespace Unkou.UserControl
{
    public partial class FromToTimeEx
    {
        public FromToTimeEx()
        {
            #region イベント

            /// <summary>
            /// FromTo時刻Exロードイベント
            /// </summary>
            /// <param name="sender">イベント送信元</param>
            /// <param name="e">イベントデータ</param>x
        }

        #region 変数

        /// <summary>
        /// 必須項目From時刻
        /// </summary>
        private bool _notNullForFromTime = false;

        /// <summary>
        /// 必須項目To時刻
        /// </summary>
        private bool _notNullForToTime = false;

        /// <summary>
        /// 必須項目From時刻 or To時刻
        /// </summary>
        private bool _notNullForFromOrToTime = false;

        /// <summary>
        /// エラー情報有無From時刻
        /// </summary>
        private bool _existErrorForFromTime = false;

        /// <summary>
        /// エラー情報有無To時刻
        /// </summary>
        private bool _existErrorForToTime = false;

        /// <summary>
        /// 読み取り専用
        /// </summary>
        private bool _readOnlyNonTabStop = false;

        #endregion

        #region プロパティ

        /// <summary>
        /// 必須項目From時刻プロパティ
        /// </summary>
        /// <value>Ture:必須／False:任意</value>
        /// (プロパティ値を変更することにより、背景色が変更されます。)
        /// <returns></returns>
        /// <remarks></remarks>
        [Category("カスタム")]
        [DisplayName(nameof(NotNullForFromTime))]
        [Description("From時刻の必須項目を設定します。")]
        public bool NotNullForFromTime
        {
            get
            {
                return _notNullForFromTime;
            }

            set
            {
                _notNullForFromTime = value;
                this.txtFromTime.NotNull = _notNullForFromTime;
            }
        }

        /// <summary>
        /// 必須項目To時刻プロパティ
        /// </summary>
        /// <value>Ture:必須／False:任意</value>
        /// (プロパティ値を変更することにより、背景色が変更されます。)
        /// <returns></returns>
        /// <remarks></remarks>
        [Category("カスタム")]
        [DisplayName(nameof(NotNullForToTime))]
        [Description("To時刻の必須項目を設定します。")]
        public bool NotNullForToTime
        {
            get
            {
                return _notNullForToTime;
            }

            set
            {
                _notNullForToTime = value;
                this.txtToTime.NotNull = _notNullForToTime;
            }
        }

        /// <summary>
        /// 必須項目From時刻 or To時刻プロパティ
        /// </summary>
        /// <value>Ture:必須／False:任意</value>
        /// (プロパティ値を変更することにより、背景色が変更されます。)
        /// <returns></returns>
        /// <remarks></remarks>
        [Category("カスタム")]
        [DisplayName(nameof(NotNullForFromOrToTime))]
        [Description("From時刻 or To時刻の必須項目を設定します。")]
        public bool NotNullForFromOrToTime
        {
            get
            {
                return _notNullForFromOrToTime;
            }

            set
            {
                _notNullForFromOrToTime = value;
                // Me.txtToTime.NotNull = _notNullForFromOrToTime
            }
        }
        /// <summary>
        /// エラー有無From時刻プロパティ
        /// (プロパティ値を変更することにより、背景色が変更されます。)
        /// </summary>
        /// <value>Ture:エラー有／False:エラー無</value>
        /// <returns></returns>
        /// <remarks></remarks>
        [Browsable(false)]
        public bool ExistErrorForFromTime
        {
            get
            {
                return _existErrorForFromTime;
            }

            set
            {
                _existErrorForFromTime = value;
                this.txtFromTime.ExistError = _existErrorForFromTime;
            }
        }

        /// <summary>
        /// エラー有無To時刻プロパティ
        /// (プロパティ値を変更することにより、背景色が変更されます。)
        /// </summary>
        /// <value>Ture:エラー有／False:エラー無</value>
        /// <returns></returns>
        /// <remarks></remarks>
        [Browsable(false)]
        public bool ExistErrorForToTime
        {
            get
            {
                return _existErrorForToTime;
            }

            set
            {
                _existErrorForToTime = value;
                this.txtToTime.ExistError = _existErrorForToTime;
            }
        }

        /// <summary>
        /// From時刻プロパティ
        /// </summary>
        /// <returns></returns>
        [Category("カスタム")]
        [DisplayName(nameof(FromTimeText))]
        [Description("From時刻の値を取得します。")]
        public TimeSpan? FromTimeText
        {
            get
            {
                return this.txtFromTime.Value;
            }

            set
            {
                this.txtFromTime.Value = value;
            }
        }

        /// <summary>
        /// To時刻プロパティ
        /// </summary>
        /// <returns></returns>
        [Category("カスタム")]
        [DisplayName(nameof(ToTimeText))]
        [Description("To時刻の値を取得します。")]
        public TimeSpan? ToTimeText
        {
            get
            {
                return this.txtToTime.Value;
            }

            set
            {
                this.txtToTime.Value = value;
            }
        }

        /// <summary>
        /// 読み取り専用プロパティ
        /// </summary>
        /// <returns></returns>
        [Category("カスタム")]
        [DisplayName(nameof(ReadOnlyNonTabStop))]
        [Description("FromToの時刻を読み取り専用にします。")]
        public bool ReadOnlyNonTabStop
        {
            get
            {
                return _readOnlyNonTabStop;
            }

            set
            {
                _readOnlyNonTabStop = value;
                this.txtFromTime.ReadOnly = value;
                this.txtToTime.ReadOnly = value;
            }
        }

        private void FromToTimeEx_Load(object sender, EventArgs e)
        {
            setTimeInputFormat();
            setTimeDisplayFormat();
        }

        #region Private method

        /// <summary>
        /// 入力フォーマット設定
        /// </summary>
        private void setTimeInputFormat()
        {
            this.txtFromTime.Fields.Clear();
            this.txtToTime.Fields.Clear();

            // 入力フィールドのオブジェクトを作成します。
            var fromHour = new DateHourField();
            fromHour.MidnightAs24 = true;
            var fromLiteral = new DateLiteralField(":");
            var fromMinute = new DateMinuteField();
            var toHour = new DateHourField();
            var toLiteral = new DateLiteralField(":");
            var toMinute = new DateMinuteField();

            // フィールドをコレクションに追加してコントロールに入力書式を設定します。
            this.txtFromTime.Fields.AddRange(new DateField[] { fromHour, fromLiteral, fromMinute });
            this.txtToTime.Fields.AddRange(new DateField[] { toHour, toLiteral, toMinute });
        }

        /// <summary>
        /// 表示フォーマット設定
        /// </summary>
        private void setTimeDisplayFormat()
        {
            this.txtFromTime.DisplayFields.Clear();
            this.txtToTime.DisplayFields.Clear();

            // 表示フィールドのオブジェクトを作成します。
            var fromHour = new DateHourDisplayField(true, true);
            var fromLiteral = new DateLiteralDisplayField(":");
            var fromMinute = new DateMinuteDisplayField(true);
            var toHour = new DateHourDisplayField(true, true);
            var toLiteral = new DateLiteralDisplayField(":");
            var toMinute = new DateMinuteDisplayField(true);

            // フィールドをコレクションに追加してコントロールに表示書式を設定します。
            this.txtFromTime.DisplayFields.AddRange(new DateDisplayField[] { fromHour, fromLiteral, fromMinute });
            this.txtToTime.DisplayFields.AddRange(new DateDisplayField[] { toHour, toLiteral, toMinute });
        }

        #endregion

        #endregion

    }
    #endregion
}
