using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Drawing;
using static ClientConstantCode;
/// <summary>
/// ボタンコントロールクラス
/// </summary>
/// <remarks></remarks>
public partial class ButtonEx : System.Windows.Forms.Button, IUserControl
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
    public ButtonEx()
    {
        this.AutoSize = true;
        this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
        this.Font = new Font("ＭＳ ゴシック", (float)11.25d);
        this.ForeColor = Color.Black;
        // デフォルト権限制御：なし
        AuthControl = false;
    }
    #endregion

    #region  プロパティ
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
                                    this.BackColor = BackColorType.Transparent();
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
                                    this.BackColor = BackColorType.Transparent();
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
    /// ボタンキー割当
    /// </summary>
    /// <value>割り当てキー</value>
    /// <returns></returns>
    /// <remarks></remarks>
    [Category("カスタム")]
    [Description("割り当てキー")]
    public BtnKeyId BtnEventId { get; set; }

    /// <summary>
    /// ボタン使用可能権限レベル
    /// </summary>
    /// <returns></returns>
    [Category("カスタム")]
    [Description("ボタン使用可能権限レベル")]

    public bool AuthControl { get; set; }

    /// <summary>
    /// 活性/非活性制御（権限付）
    /// </summary>
    /// <returns></returns>
    public bool Enabled
    {
        get
        {
            return base.Enabled;
        }

        set
        {
            switch (value)
            {
                case false:
                    {
                        // 非活性は常に設定する
                        base.Enabled = value;
                        break;
                    }

                case true:
                    {
                        if (AuthControl == false)
                        {
                            // 権限制御：なしの場合
                            // そのまま設定する
                            base.Enabled = value;
                        }
                        else
                        {
                            // 権限制御：ありの場合
                            // 許可レベル以上であれば活性に設定する
                            //base.Enabled = UserInfoManagement.authLevel >= AllowAuthLevel ? true : false;
                        }

                        break;
                    }
            }
        }
    }

    #endregion

}