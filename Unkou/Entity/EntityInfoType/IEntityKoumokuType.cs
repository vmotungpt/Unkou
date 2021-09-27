using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unkou.Entity.EntityInfoType
{
	/// <summary>
	/// エンティティ項目_型
	/// インターフェース
	/// </summary>
	/// <remarks></remarks>
	public interface IEntityKoumokuType
	{
		/// <summary>
		/// エラー情報を取得＿設定します。
		/// </summary>
		/// <value>True:エラー有／False:エラー無</value>
		/// <returns></returns>
		/// <remarks></remarks>
		bool ErrorInfo { get; set; }

		/// <summary>
		/// 必須を取得＿設定します。
		/// </summary>
		/// <value>True:必須／False:任意</value>
		/// <returns></returns>
		/// <remarks></remarks>
		bool Required { get; set; }

		/// <summary>
		/// 物理名を取得＿設定します。
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		/// <remarks></remarks>
		string PhysicsName { get; set; }

		/// <summary>
		/// 項目のOracleDb型を取得＿設定します。
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		/// <remarks></remarks>
		OracleDbType DBType { get; set; }

		/// <summary>
		/// 項目のDB桁数を取得＿設定します。
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		/// <remarks></remarks>
		int IntegerBu { get; set; }

		/// <summary>
		/// 項目のDB小数桁数を取得＿設定します。
		/// </summary>
		/// <value></value>
		/// <returns></returns>
		/// <remarks></remarks>
		int DecimalBu { get; set; }

	}
}
