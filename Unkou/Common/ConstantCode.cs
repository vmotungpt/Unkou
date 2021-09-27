using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unkou.Common
{
	/// <summary>
	/// 固定コード
	/// </summary>
	/// <remarks></remarks>
	public sealed class ConstantCode
	{

		/// <summary>
		/// ＤＢ処理区分
		/// (T.Sugino Add 2018.08.31 追加)
		/// </summary>
		/// <remarks></remarks>
		public enum DbShoriKbn : int
		{
			Insert = 1, //登録
			Update = 2 //更新
		}

	}
}
