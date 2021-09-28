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
    public partial class YoyakuNoEx : IUserControl
    {

        #region 変数
        /// <summary>
        /// 許可する文字
        /// </summary>
        /// <remarks>
        /// バックスペース、スラッシュ、"W"、"R"、コントロールキー + "V" 、コントロールキー + "C" 
        /// </remarks>
        private char[] _validChars = new char[] { ControlChars.Back, 'w', 'W', 'r', 'R', '\u0016', '\u0003' };

        /// <summary>
        /// 必須項目
        /// </summary>
        private bool _notNull = false;

        /// <summary>
        /// エラー有無
        /// </summary>
        private bool _existError = false;

        /// <summary>
        /// ガイドメッセージID
        /// </summary>
        private string _GuideMessage = "";

        /// <summary>
        /// ガイドメッセージ内容
        /// </summary>
        private List<string> _GuideMessageDetail = new List<string>();

        /// <summary>
        /// 読み取り専用
        /// </summary>
        private bool _ReadOnlyTabStop = false;

        #endregion

        #region プロパティ

        /// <summary>
        /// 必須項目プロパティ
        /// (プロパティ値を変更することにより、背景色が変更されます。)
        /// </summary>
        /// <value>Ture:必須／False:任意</value>
        /// <returns></returns>
        /// <remarks></remarks>
        [Category("カスタム")]
        [DisplayName(nameof(NotNull))]
        [Description("予約番号の必須項目を設定します。")]
        public bool NotNull
        {
            get
            {
                return _notNull;
            }

            set
            {
                _notNull = value;
                this.lblYoyakuNo.NotNull = _notNull;
                this.txtYoyakuNo.NotNull = _notNull;
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
                this.lblYoyakuNo.ExistError = _existError;
                this.txtYoyakuNo.ExistError = _existError;
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
        /// 予約番号プロパティ
        /// </summary>
        /// <returns></returns>
        [Category("カスタム")]
        [DisplayName(nameof(YoyakuText))]
        [Description("予約番号の値を取得または設定をします。")]
        public string YoyakuText
        {
            get
            {
                return this.txtYoyakuNo.Text.Replace(",", "");
            }

            set
            {
                this.txtYoyakuNo.Text = separeteByComma(value);
            }
        }

        /// <summary>
        /// 読み取り専用プロパティ
        /// </summary>
        /// <returns></returns>
        [Category("カスタム")]
        [DisplayName(nameof(ReadOnlyNonTabStop))]
        [Description("予約番号テキストボックスの読み取り専用を設定します。")]
        public bool ReadOnlyNonTabStop
        {
            get
            {
                return _ReadOnlyTabStop;
            }

            set
            {
                _ReadOnlyTabStop = value;
                this.txtYoyakuNo.ReadOnly = value;
            }
        }

        #endregion

        #region Event

        /// <summary>
        /// 予約番号テキストボックスフォーカスインイベント
        /// (マウスでクリック時も含む)
        /// </summary>
        /// <param name="sender">イベント送信元</param>
        /// <param name="e">イベントデータ</param>
        private void txtYoyakuNo_Enter(object sender, EventArgs e)
        {

            // カンマを除去
            this.txtYoyakuNo.Text = this.txtYoyakuNo.Text.Replace(",", "");
            // 全選択
            this.txtYoyakuNo.SelectAll();
        }

        /// <summary>
        /// 予約番号テキストボックスフォーカスアウトイベント
        /// </summary>
        /// <param name="sender">イベント送信元</param>
        /// <param name="e">イベントデータ</param>
        private void txtYoyakuNo_Leave(object sender, EventArgs e)
        {
            // 不正文字時を除去
            foreach (char chr in txtYoyakuNo.Text)
            {
                bool isValidChar = _validChars.Any(c => c == chr);
                if ((chr < '0' || '9' < chr) && !isValidChar)
                {
                    this.txtYoyakuNo.Text = this.txtYoyakuNo.Text.Replace(chr, ' ');
                }
            }
            // カンマ付与
            this.txtYoyakuNo.Text = this.separeteByComma(this.txtYoyakuNo.Text);
        }

        /// <summary>
        /// 予約番号テキストボックスキープレスイベント
        /// </summary>
        /// <param name="sender">イベント送信元</param>
        /// <param name="e">イベントデータ</param>
        private void txtYoyakuNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 許可されているかチェック
            bool isValidChar = _validChars.Any(c => c == e.KeyChar);

            // 0～9、許可された文字以外は、イベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && !isValidChar)
            {
                e.Handled = true;
            }
        }
        #endregion

        #region メソッド
        /// <summary>
        /// カンマ区切り
        /// </summary>
        private string separeteByComma(string tmpval)
        {
            string rtnVal = "";

            // 大文字化
            tmpval = tmpval.ToUpper();

            // カンマ付与
            while (tmpval.Length > 3)
            {
                rtnVal = "," + tmpval.Substring(tmpval.Length - 3, 3) + rtnVal;
                tmpval = tmpval.Substring(0, tmpval.Length - 3);
            }

            rtnVal = tmpval + rtnVal;
            return rtnVal;
        }
        #endregion

    }
}
