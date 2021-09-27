using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unkou.Entity;

namespace Unkou.Common.Interface
{

	public interface iPT21
	{

		/// <summary>
		/// 初期処理(必須画面個別実装)
		/// </summary>
		void setSeFirsttDisplayData();

		/// <summary>
		/// 画面からエンティティに設定する処理(必須画面個別実装)
		/// </summary>
		/// <param name="ent"></param>
		void DisplayDataToEntity(ref iEntity ent);

		/// <summary>
		/// エンティティから画面に設定する処理(必須画面個別実装)
		/// </summary>
		/// <param name="ent"></param>
		void EntityDataToDisplay(ref iEntity ent);

		/// <summary>
		/// DataGridからエンティティ(前回値)に設定する処理(必須画面個別実装)
		/// ※DataGrid上の1レコードから関連するデータも取得する。Keyがない場合などは未対応
		/// </summary>
		/// <param name="pDataRow"></param>
		void OldDataToEntity(DataRow pDataRow);

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		bool CheckSearch();

		/// <summary>
		/// 登録処理前のチェック処理(必須画面個別実装)
		/// </summary>
		/// <returns></returns>
		bool CheckInsert();

		/// <summary>
		/// 更新処理前のチェック処理(必須画面個別実装)
		/// </summary>
		/// <returns></returns>
		bool CheckUpdate();

		/// <summary>
		/// 必須入力項目エラーチェック(登録時／更新時)
		/// </summary>
		/// <returns></returns>
		bool isExistHissuError();

	}
}
