using System;
using System.Drawing;

/// <summary>
/// 固定コード
/// </summary>
/// <remarks></remarks>
public static partial class ClientConstantCode
{

    #region  メソッド 

    #region  固定コード 
    #region  ボタン固定コード 
    /// <summary>
    /// ボタン
    /// </summary>
    /// <remarks></remarks>
    public enum BtnKeyId : int
    {
        Null,
        F1,
        F2,
        F3,
        F4,
        F5,
        F6,
        F7,
        F8,
        F9,
        F10,
        F11,
        F12,
        CLEAR
    }
    #endregion
    #region  背景色 

    /// <summary>
    /// 背景色
    /// </summary>
    /// <remarks></remarks>
    public sealed partial class BackColorType
    {
        /// <summary>
        /// フォーム背景色
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public static System.Drawing.Color Form()
        {
            return Color.Honeydew;
        }

        /// <summary>
        /// フォーム背景色
        /// UPD-20120201-LightYellow→Pinkに変更
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public static System.Drawing.Color TestForm()
        {
            return Color.FromArgb(Convert.ToInt32("ffffddff", 16));
        }

        /// <summary>
        /// コントロール背景色[通常項目]
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public static System.Drawing.Color Standard()
        {
            return SystemColors.Window;
        }

        /// <summary>
        /// コントロール背景色[入力必須項目]
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public static System.Drawing.Color InputMust()
        {
            return Color.LightBlue;
        }

        /// <summary>
        /// コントロール背景色[エラー項目]
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public static System.Drawing.Color InputError()
        {
            return Color.Red;
        }

        /// <summary>
        /// コントロール背景色[3D項目]
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public static System.Drawing.Color Transparent()
        {
            return Color.Transparent;
        }
    }


    #endregion

    #region  文字色 
    /// <summary>
    /// 背景色
    /// </summary>
    /// <remarks></remarks>
    public sealed partial class CharacterColorType
    {
        /// <summary>
        /// 文字色
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public static System.Drawing.Color InputMust()
        {
            return Color.Red;
        }

        /// <summary>
        /// 文字色
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public static System.Drawing.Color System()
        {
            return SystemColors.ControlText;
        }
    }
    #endregion

    #endregion

    #endregion

}