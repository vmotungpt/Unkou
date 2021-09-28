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
    public partial class ComboBoxEx : GrapeCity.Win.Editors.GcComboBox, IUserControl
    {

        #region  変数／定数 
        private bool _notNull = false;
        private bool _existError = false;
        private string _GuideMessage = "";
        private List<string> _GuideMessageDetail = new List<string>();
        #endregion

        #region  メソッド 
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <remarks></remarks>
        public ComboBoxEx()
        {
            this.AutoSize = true;
            this.Font = new Font("ＭＳ ゴシック", (float)11.25d);
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            this.DropDown.AllowResize = false;
            this.ListHeaderPane.Visible = false;
            this.FlatStyle = GrapeCity.Win.Editors.FlatStyleEx.Popup;
            this.SideButtons.Clear();
        }
        /// <summary>
        /// 必須項目プロパティ
        /// </summary>
        /// <value>Ture:必須／False:任意</value>
        /// (プロパティ値を変更することにより、背景色が変更されます。)
        /// <returns></returns>
        /// <remarks></remarks>
        [Category("カスタム")]
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
        /// 固定コードに定義している情報を表示します。
        /// カラム(0:CODE_VALUE、1:CODE_NAME)
        /// SelectedValue=CODE_VALUEを取得します。
        /// </summary>
        /// <param name="systemTypeValue">固定コード定義</param>
        /// <param name="nullRecord">nullレコード有/無</param>
        /// <remarks></remarks>
        public void setData(Type systemTypeValue, bool nullRecord = false)
        {
            //this.DataSource = CommonLogic.getEnumOfDatatable(systemTypeValue, nullRecord);
        }

        /// <summary>
        /// 標準的なCODE/NAME形式を定義し、表示します。
        /// SelectedValue=CODE_VALUEを取得します。
        /// </summary>
        /// <param name="dataTable">CODE/NAME形式DataTable</param>
        /// <param name="codeVisible">CODEカラム表示/非表示</param>
        /// <param name="width">CODE表示時のWidth</param>
        /// <remarks></remarks>
        public void setData(DataTable dataTable, bool codeVisible = false, int width = 0)
        {

            // コンボボックスデータ設定
            this.DataSource = dataTable;
            this.ValueSubItemIndex = 0;
            if (codeVisible == false)
            {

                // CODEを非表示にし、NAMEのみ表示
                this.ListColumns[0].Visible = false;
                //this.TextSubItemIndex = 1;
                this.ListColumns[1].Width = this.Width;
            }
            else
            {
                // コンボボックスの内容は、NAMEのみ表示
                // 選択された値は、CODEで表示
                this.TextSubItemIndex = 0;
                this.ListColumns[0].Width = width;
                this.ListColumns[1].Width = this.DropDown.Size.Width - this.ListColumns[0].Width;
            }
        }

        #endregion

    }
}
