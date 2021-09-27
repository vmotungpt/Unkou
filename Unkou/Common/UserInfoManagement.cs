using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unkou.Common
{
	public class UserInfoManagement
	{
		#region  変数／定数

		//------------------------------
		// ユーザ情報関連
		//------------------------------
		/// <summary>
		/// ユーザ名
		///   例）はと 太郎（M_USER)
		/// </summary>
		public static string userName = string.Empty;
		/// <summary>
		/// ユーザID
		///   例）123456890
		/// </summary>
		public static string userId = string.Empty;
		/// <summary>
		/// 所属部署名(所属階層2＋所属階層3)
		///   例）○○○部△△△課
		/// </summary>
		public static string sectionBusyoName = string.Empty;
		/// <summary>
		/// 所属部署コード
		///   例）1121000（総務課）、1222000（定期観光部）など
		/// </summary>
		public static string sectionBusyoCd = string.Empty;
		/// <summary>
		/// 会社コード（2桁）
		///   例）00
		/// </summary>
		/// <remarks>現行ASの2桁会社コードと同等</remarks>
		public static string companyCd = string.Empty;
		/// <summary>
		/// 営業所コード
		///   例）01（営業企画部）、31（新宿営業所）など
		/// </summary>
		/// <remarks>判定はDB側にて行い、セット</remarks>
		public static string eigyosyoCd = string.Empty;
		/// <summary>
		/// 営業所名
		///   例）営業企画部、新宿営業所 など
		/// </summary>
		public static string eigyosyoName = string.Empty;
		/// <summary>
		/// 営業所区分
		///   例）HE（営業企画部）、HJ（新宿営業所）など
		/// </summary>
		/// <remarks>判定はDB側にて行い、セット</remarks>
		public static string eigyosyoKbn = string.Empty;
		/// <summary>
		/// 営業所フラグ
		/// </summary>
		/// <remarks>営業所の場合true?</remarks>
		[Obsolete]
		public static bool eigyosyoFlg = false;
		/// <summary>
		/// 担当者ID
		///   例）HHXX
		/// </summary>
		/// <remarks>現行BOシステムのみ仕使用</remarks>
		[Obsolete]
		public static string tantosyaId = string.Empty;
		/// <summary>
		/// 助勤フラグ
		/// </summary>
		/// <remarks>助勤時True</remarks>
		public static bool assistanceFlg = false;
		/// <summary>
		/// 嘱託フラグ
		/// </summary>
		/// <remarks>嘱託時True</remarks>
		public static bool commissionFlg = false;
		/// <summary>
		/// 部署区分
		/// </summary>
		/// <remarks>現行造成、手配、BOで使用</remarks>
		[Obsolete]
		public static string busyoKbn = string.Empty;
		/// <summary>
		/// 日本語コース選択デフォルト
		/// </summary>
		/// <remarks>日本語（邦人）コースを初期値とする場合True</remarks>
		public static bool japaneseCrsSelectFlg = false;
		/// <summary>
		/// 外国語コース選択デフォルト
		/// </summary>
		/// <remarks>外国語（外客）コースを初期値とする場合True</remarks>
		public static bool gaikokugoCrsSelectFlg = true;
		/// <summary>
		/// サインオン（ログイン）時間
		/// </summary>
		public static DateTime signonDate;
		/// <summary>
		/// 取扱部署
		///   例）1（定期観光部）、2（企画旅行部）、3（国際事業部）、9（その他）
		/// </summary>
		public static string toriatukaiBusyo = string.Empty;

		//------------------------------
		// 権限関連
		//------------------------------
		//  不可 ＜ 参照 ＜ 更新 ＜ 追加 ＜ 承認
		//  ※特権＝システム管理
		/// <summary>
		/// 参照権限
		/// </summary>
		public static bool referenceFlg = false;
		/// <summary>
		/// 更新権限
		/// </summary>
		public static bool updateFlg = false;
		/// <summary>
		/// 追加権限
		/// </summary>
		public static bool addFlg = false;
		/// <summary>
		/// 承認権限
		/// </summary>
		public static bool syouninFlg = false;
		/// <summary>
		/// システム管理権限
		/// </summary>
		public static bool systemManagement = false;
		
		/// <summary>
		/// 権限データ
		/// </summary>
		/// <remarks>ログイン時取得した全メニュー分の権限情報</remarks>
		public static DataTable authData = null;


		//------------------------------
		// 端末関連
		//------------------------------
		/// <summary>
		/// クライアント名
		/// </summary>
		/// <remarks>実行端末クライアント名</remarks>
		public static string client = string.Empty;
		/// <summary>
		/// プロセスID
		/// </summary>
		/// <remarks>実行端末プロセスID</remarks>
		public static int processId = 0;

		/// <summary>
		/// 発行バージョン
		/// </summary>
		public static string isueVersion = string.Empty;
		/// <summary>
		/// システム名
		///   例）予約システム
		/// </summary>
		public static string SystemNm = string.Empty;

		// TODO:delete
		// ↓↓↓ H.Suna Add 2018.08.24 ↓↓↓
		//Public Shared passwordOracle As String                      'パスワード
		//Public Shared systemCode As String = String.Empty           'システムコード
		//Public Shared authorityLevel As Integer = 0                 '権限レベル
		//Public Shared sectionLevel As Integer = 0                   '取得所属階層レベル
		//Public Shared returnCode As Integer = 0                     'リターンコード
		//Public Shared sqlCode As String = String.Empty              'SQLCODE
		// ↑↑↑ H.Suna Add 2018.08.24 ↑↑↑


		#endregion

	}
}
