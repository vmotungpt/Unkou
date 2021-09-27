using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unkou.Interface;
using static ClientConstantCode;
using Unkou.Common;

namespace Unkou.UserControl
{
    public partial class LanguageCheckBoxEx : System.Windows.Forms.Control, ICodeControlEx
    {
        public LanguageCheckBoxEx()
        {            

            #region イベント
            /// <summary>
            /// コードコントロール表示イベント
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
        }

        #region 変数

        /// <summary>
        /// 必須 (全てのチェックボックスに適用)
        /// </summary>
        private bool _notNull = false;

        /// <summary>
        /// エラー有無 (全てのチェックボックスに適用)
        /// </summary>
        private bool _existError = false;

        /// <summary>
        /// 状態初期設定 (Trueの場合 [Load時,Clear時] 部署を判定しチェックON/OFF)
        /// </summary>
        private bool _initState = false;

        #endregion

        #region プロパティ

        #region 共通
        /// <summary>
        /// 必須項目プロパティ
        /// </summary>
        /// <value>Ture:必須／False:任意</value>
        /// (プロパティ値を変更することにより、全てチェックボックスの背景色が変更されます。)
        /// <returns></returns>
        /// <remarks></remarks>
        [Category("カスタム")]
        [DisplayName(nameof(NotNull))]
        [Description("全てのチェックボックスに必須項目を設定します。")]
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
                                        this.BackColor = BackColorType.Transparent();
                                        break;
                                    }
                            }

                            break;
                        }
                }
                // 以下はチェックボックス毎に行う場合（本プロパティはユーザーコントールに対して行うためコメント）
                // ' 全てのチェックボックスに適用
                // For Each winControl As Control In Me.Controls
                // If TypeOf winControl Is CheckBoxEx Then
                // CType(winControl, CheckBoxEx).NotNull = _notNull
                // End If
                // Next
            }
        }

        /// <summary>
        /// エラー有無プロパティ
        /// </summary>
        /// <value>Ture:必須／False:任意</value>
        /// (プロパティ値を変更することにより、全てチェックボックスの背景色が変更されます。)
        /// <returns></returns>
        /// <remarks></remarks>
        [Category("カスタム")]
        [DisplayName(nameof(ExistError))]
        [Description("全てのチェックボックスにエラー有無を設定します。")]
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
                                        this.BackColor = BackColorType.Transparent();
                                        break;
                                    }
                            }

                            break;
                        }
                }
                // 以下はチェックボックス毎に行う場合（本プロパティはユーザーコントールに対して行うためコメント）
                // ' 全てのチェックボックスに適用
                // For Each winControl As Control In Me.Controls
                // If TypeOf winControl Is CheckBoxEx Then
                // CType(winControl, CheckBoxEx).ExistError = _existError
                // End If
                // Next
            }
        }

        #endregion

        #region 固有
        /// <summary>
        /// 状態初期設定プロパティ
        /// (プロパティ値を変更することにより、Trueの場合 [Load時,Clear時] 部署を判定しチェックON/OFFします)
        /// </summary>
        /// <value>TimeKinds</value>
        /// <returns></returns>
        /// <remarks></remarks>
        [Category("カスタム")]
        [DisplayName(nameof(InitState))]
        [Description("Trueの場合 [Load時,Clear時] 部署を判定しチェックON/OFFします")]
        public bool InitState
        {
            get
            {
                return _initState;
            }

            set
            {
                _initState = value;
            }
        }

        /// <summary>
        /// 日本語チェックボックス使用可否プロパティ
        /// </summary>
        /// <value>Ture:必須／False:任意</value>
        /// (プロパティ値を変更することにより、日本語チェックボックスの使用可否が変更されます。)
        /// <returns></returns>
        /// <remarks></remarks>
        [Category("カスタム")]
        [DisplayName(nameof(JapaneseEnable))]
        [Description("日本語チェックボックスの使用可否を設定します。")]
        public bool JapaneseEnable
        {
            get
            {
                return this.chkJapanese.Enabled;
            }

            set
            {
                this.chkJapanese.Enabled = value;
            }
        }

        /// <summary>
        /// 外国語チェックボックス使用可否プロパティ
        /// </summary>
        /// <value>Ture:必須／False:任意</value>
        /// (プロパティ値を変更することにより、外国語チェックボックスの使用可否が変更されます。)
        /// <returns></returns>
        /// <remarks></remarks>
        [Category("カスタム")]
        [DisplayName(nameof(ForeignEnable))]
        [Description("外国語チェックボックスの使用可否を設定します。")]
        public bool ForeignEnable
        {
            get
            {
                return this.chkForeign.Enabled;
            }

            set
            {
                this.chkForeign.Enabled = value;
            }
        }

        /// <summary>
        /// 日本語チェックボックス状態プロパティ
        /// </summary>
        /// <value>Ture:必須／False:任意</value>
        /// (プロパティ値を変更することにより、日本語チェックボックスの状態が変更されます。)
        /// <returns></returns>
        /// <remarks></remarks>
        [Category("カスタム")]
        [DisplayName(nameof(JapaneseState))]
        [Description("日本語チェックボックスの状態を設定します。")]
        public bool JapaneseState
        {
            get
            {
                return this.chkJapanese.Checked;
            }

            set
            {
                this.chkJapanese.Checked = value;
            }
        }

        /// <summary>
        /// 外語語チェックボックス状態プロパティ
        /// </summary>
        /// <value>Ture:必須／False:任意</value>
        /// (プロパティ値を変更することにより、外語語チェックボックスの状態が変更されます。)
        /// <returns></returns>
        /// <remarks></remarks>
        [Category("カスタム")]
        [DisplayName(nameof(ForeignState))]
        [Description("外語語チェックボックスの状態を設定します。")]
        public bool ForeignState
        {
            get
            {
                return this.chkForeign.Checked;
            }

            set
            {
                this.chkForeign.Checked = value;
            }
        }

        private void LanguageCheckBoxEx_Load(object sender, EventArgs e)
        {

            // -----------------------------------------------------------
            // 初期状態設定
            // -----------------------------------------------------------
            if (_initState == true)
            {
                // 部署を判定しチェックON/OFF
                SetInitState();
            }
        }
        #endregion

        #region メソッド

        #region 共通
        /// <summary>
        /// 初期化
        /// </summary>
        public void clear()
        {
            if (_initState == true)
            {
                // 状態初期設定 が True の場合 部署を判定しチェックON/OFFする
                SetInitState();
            }
            else
            {
                this.chkJapanese.Checked = false;
                this.chkForeign.Checked = false;
            }
        }

        /// <summary>
        /// エラーの背景色初期化
        /// </summary>
        public void clearError()
        {
            ExistError = false;
        }

        /// <summary>
        /// 必須入力チェック
        /// </summary>
        public bool hissuError()
        {
            if (_notNull == false)
            {
                return false;
            }

            var chkList = new List<bool>();

            // 全てのチェックボックスをチェックする
            foreach (Control winControl in this.Controls)
            {

                // チェックボックス コントール 以外はスキップ (チェックボックス コントール以外はあり得ないが実装)
                if (winControl is CheckBoxEx == false)
                {
                    continue;
                }

                // １件でもチェックON があれば OK とするため 一旦 リストに退避。後続処理で判定する
                CheckBoxEx ctrl = (CheckBoxEx)winControl;
                chkList.Add(ctrl.Checked);
            }

            // チェックボックス コントール なし
            if (chkList.Count == 0)
            {
                return false;
            }

            // １件でもチェックON があれば OK とする
            if (chkList.Contains(true) == true)
            {
                return false;
            }

            ExistError = true;
            return true;
        }

        /// <summary>
        /// フォーカス
        /// </summary>
        public void SetFocus()
        {
            if (this.chkForeign.Enabled == true)
            {
                this.chkForeign.Select();
            }
            else
            {
                this.chkJapanese.Select();
            }
        }
        #endregion

        #region 固有
        /// <summary>
        /// 部署を判定しチェックON/OFFする
        /// </summary>
        public void SetInitState()
        {
            this.chkForeign.Checked = UserInfoManagement.gaikokugoCrsSelectFlg;
            this.chkJapanese.Checked = !UserInfoManagement.gaikokugoCrsSelectFlg;
        }
        #endregion

        #endregion

    }
    #endregion
}
