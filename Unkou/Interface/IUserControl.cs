/// <summary>
/// コントロールインターフェース
/// </summary>
/// <remarks></remarks>
using System.Collections.Generic;

public partial interface IUserControl
{
    /// <summary>
    /// 必須項目
    /// (プロパティ値を変更することにより、背景色が変更されます。)
    /// </summary>
    /// <value>Ture:必須／False:任意</value>
    /// <returns></returns>
    /// <remarks></remarks>
    bool NotNull { get; set; }  // 必須項目
    /// <summary>
    /// エラー情報有無
    /// (プロパティ値を変更することにより、背景色が変更されます。)
    /// </summary>
    /// <value>Ture:エラー有／False:エラー無</value>
    /// <returns></returns>
    /// <remarks></remarks>
    bool ExistError { get; set; }  // エラー有無
    /// <summary>
    /// ガイドメッセージID
    /// (設定することにより、ガイドメッセージを出力します。)
    /// </summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    string GuideMessage { get; set; }  // ガイドメッセージID
    /// <summary>
    /// ガイドメッセージ内容
    /// （ガイドメッセージで、引数のあるメッセージの内容を設定します。)
    /// ※要素数3以内
    /// </summary>
    /// <value></value>
    /// <returns></returns>
    /// <remarks></remarks>
    List<string> GuideMessageDetail { get; set; }  // ガイドメッセージ内容
}