using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unkou.Interface
{
    public partial interface ICodeControlEx
    {
        /// <summary>
        /// コード、名称の入力初期化
        /// </summary>
        void clear();
        /// <summary>
        /// エラーの背景色初期化
        /// </summary>
        void clearError();
        /// <summary>
        /// 必須入力チェック
        /// </summary>
        bool hissuError();
    }
}
