using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unkou.Common
{
	//2018/10/09 勝野 オプション追加

	/// <summary>
	/// 共通処理
	/// </summary>
	/// <remarks></remarks>
	public sealed class CommonDa //共通DA
	{

		#region  接続文字列
		public static string connectionString = string.Empty;
		public static string LogTable = string.Empty; //ログテーブル
		public static int usingFlgCheckCount = 0;
		public static int usingFlgCheckInterval = 0;
		#endregion

		#region 定数
		/// <summary>
		/// ログ種別タイプ
		/// </summary>
		/// <remarks></remarks>
		public enum LogKindType : int //ログ種別タイプ
		{
			debugLog = 1, //デバッグログ DEBUG
			operationLog = 2, //操作ログ INFO
			warningLog = 3, //ワーニングログ　WARNING
			errorLog = 4, //エラーログ ERROR
			fatalLog = 5 //フェイタルログ FATAL
		}

		/// <summary>
		/// ログ処理種別タイプ
		/// </summary>
		/// <remarks></remarks>
		public enum ProcessKindType : int //処理種別タイプ
		{
			login = 1, //ログイン
			search, //検索
			entry, //登録
			update, //更新
			delete, //削除
			syounin, //承認
			formOut, //帳票出力
			preview, //プレビューv
			infoRegist, //情報連携
			CSVTorikomi, //CSV取込
			CSVOut, //CSV出力
			FAX,
			DSCall, //DS呼出
			sonota = 99, //その他
						 //以下造成用追加
			copy, //コピー
			logicDelete, //論理削除
			physicsDelete, //物理削除
			createDocumentOut, //作成資料の出力
			ASRendo, //ＡＳ連動
			WEBRendo, //ＷＥＢ連動
			bulkOpen, //一括公開
			pamphIrai //パンフ依頼
		}

		#endregion

		//#region メソッド
		//public static CommonDaProcess createFactoryDA()
		//{
		//	return clsCommonDaProcess;
		//}

		//public static LogOut createFactoryLog()
		//{
		//	return clsLogOut;
		//}
		//#endregion

	}
}
