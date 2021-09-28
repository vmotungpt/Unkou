using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Unkou.UserControl
{
    public partial class FromToTime24Ex
    {

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
        /// 時間種別プロパティ
        /// (プロパティ値を変更することにより、時間の範囲が変更されます。)
        /// </summary>
        /// <value>TimeKinds</value>
        /// <returns></returns>
        /// <remarks></remarks>
        [Category("カスタム")]
        [DisplayName(nameof(TimeKind))]
        [Description("時間種別を設定します")]
        public Time24Ex.TimeKinds TimeKind
        {
            get
            {
                // From, TO 共に同一値のため、どちらか一方の値を返す
                return this.txtFromTime.TimeKind;
            }

            set
            {

                // 時間種別 (初期値：その他(指定なし))
                Time24Ex.TimeKinds setValue = Time24Ex.TimeKinds.OTHER_TIME;
                if (Information.IsNothing(value) == false)
                {
                    // 時間種別 指定あり
                    setValue = value;
                }

                // From, To 共に同じ種別を設定する
                this.txtFromTime.TimeKind = setValue;
                this.txtToTime.TimeKind = setValue;
            }
        }

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
        [DisplayName(nameof(FromTimeValue24))]
        [Description("From時刻の値を取得します。")]
        public string FromTimeValue24
        {
            get
            {
                return this.txtFromTime.Value24;
            }

            set
            {
                this.txtFromTime.Value24 = value;
            }
        }

        /// <summary>
        /// To時刻プロパティ
        /// </summary>
        /// <returns></returns>
        [Category("カスタム")]
        [DisplayName(nameof(ToTimeValue24))]
        [Description("To時刻の値を取得します。")]
        public string ToTimeValue24
        {
            get
            {
                return this.txtToTime.Value24;
            }

            set
            {
                this.txtToTime.Value24 = value;
            }
        }

        /// <summary>
        /// From時刻プロパティ(Int)
        /// </summary>
        /// <returns></returns>
        [Category("カスタム")]
        [DisplayName(nameof(FromTimeValue24Int))]
        [Description("From時刻の値を取得します。")]
        public int? FromTimeValue24Int
        {
            get
            {
                return this.txtFromTime.Value24Int;
            }

            set
            {
                this.txtFromTime.Value24Int = value;
            }
        }

        /// <summary>
        /// To時刻プロパティ(Int)
        /// </summary>
        /// <returns></returns>
        [Category("カスタム")]
        [DisplayName(nameof(ToTimeValue24Int))]
        [Description("To時刻の値を取得します。")]
        public int? ToTimeValue24Int
        {
            get
            {
                return this.txtToTime.Value24Int;
            }

            set
            {
                this.txtToTime.Value24Int = value;
            }
        }

        /// <summary>
        /// From時刻プロパティ
        /// </summary>
        public Time24Ex FromTime24Ex
        {
            get
            {
                return this.txtFromTime;
            }
        }

        /// <summary>
        /// To時刻プロパティ
        /// </summary>
        public Time24Ex ToTime24Ex
        {
            get
            {
                return this.txtToTime;
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

        #endregion

    }
}
