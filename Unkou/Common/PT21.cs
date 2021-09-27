using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unkou.Common
{
	/// <summary>
	/// TODO：画面パターン21
	/// </summary>
	public partial class PT21 : FormBase
	{
		public PT21()
		{
			InitializeComponent();
		}

		#region 定数／変数宣言

		#region 変数
		public bool closeCheckFlg = false; //
		private bool _isRegistable = false; // 登録可否フラグ[登録機能の有効／無効を判定]
		private bool _isUpdatable = false; // 更新可否フラグ[更新機能の有効／無効を判定]
		private bool _isAutoSearch = false; // 自動検索可否フラグ[自動検索機能の有効／無効を判定]
		private bool _isTransitional; // 遷移可否フラグ[遷移機能の有効／無効を判定]
		private bool _isCancelable; // 取消可否フラグ[取消機能の有効／無効を判定]
		private OracleConnection _oracleConnection; // Oracle Connection
		#endregion

		#region 定数
		#endregion

		#endregion

		#region Enum
		protected enum DbShoriKbn : int
		{
			Insert = 1, //登録
			Update = 2 //更新
		}
		#endregion

		#region プロパティ

		#region パブリック プロパティ

		#region 登録可否[登録機能の有効／無効を判定]
		/// <summary>
		/// 登録可否[登録機能の有効／無効を判定]
		/// </summary>
		public bool IsRegistable
		{
			set
			{
				_isRegistable = value;
			}
		}
		#endregion

		#region 更新可否[更新機能の有効／無効を判定]
		/// <summary>
		/// 更新可否[更新機能の有効／無効を判定]
		/// </summary>
		public bool IsUpdatable
		{
			set
			{
				_isUpdatable = value;
			}
		}
		#endregion

		#region 自動検索可否[自動検索機能の有効／無効を判定]
		/// <summary>
		/// 自動検索可否[自動検索機能の有効／無効を判定]
		/// </summary>
		public bool IsAutoSearch
		{
			set
			{
				_isAutoSearch = value;
			}
		}
		#endregion

		#region 遷移可否[更新機能の有効／無効を判定]
		/// <summary>
		/// 遷移可否[更新機能の有効／無効を判定]
		/// </summary>
		public bool IsTransitional
		{
			set
			{
				_isTransitional = value;
			}
		}
		#endregion

		#region 取消可否[取消機能の有効／無効を判定]
		/// <summary>
		/// 取消可否[取消機能の有効／無効を判定]
		/// </summary>
		public bool IsCancelable
		{
			set
			{
				_isCancelable = value;
			}
		}
		#endregion

		#endregion

		#region プライベート プロパティ
		#endregion

		#endregion

		#region メソッド

		#region FormBaseから

		#region フォームイベント

		#region 画面起動時の独自処理
		/// <summary>
		/// 画面起動時の独自処理
		/// </summary>
		protected override void StartupOrgProc()
		{

			//画面パターン毎の固有初期処理
			initScreenPerttern();

		}
		#endregion

		#region 差分チェック処理(画面クローズ時)
		/// <summary>
		/// 差分チェック処理(画面クローズ時)
		/// </summary>
		/// <returns></returns>
		protected override bool closingScreen()
		{

			// 変数宣言
			bool retCode = true;

			return retCode;

		}
		#endregion

		#endregion

		#region コントロールイベント

		#region F2(戻る)ボタン押下時
		/// <summary>
		/// F2(戻る)ボタン押下時
		/// </summary>
		protected override void btnF2_ClickOrgProc()
		{
		}
		#endregion

		#region F8(検索)ボタン押下時
		/// <summary>
		/// F8(検索)ボタン押下時
		/// </summary>
		protected override void btnF8_ClickOrgProc()
		{
		}
		#endregion

		#region F10(登録／確定)ボタン押下時
		/// <summary>
		/// F10(登録／確定)ボタン押下時
		/// </summary>
		protected override void btnF10_ClickOrgProc()
		{
		}
		#endregion

		#region F11(更新)ボタン押下時
		/// <summary>
		/// F11(更新)ボタン押下時
		/// </summary>
		protected override void btnF11_ClickOrgProc()
		{
		}
		#endregion

		#endregion

		#endregion

		#region PT21独自

		#region 画面初期Load時のメソッド
		/// <summary>
		/// 画面初期Load時のメソッド
		/// </summary>
		protected virtual void initScreenPerttern()
		{

			// 検索条件部の項目初期化
			initSearchAreaItems();

			// 検索結果部の項目初期化
			initDetailAreaItems();

			// フッタボタンの制御(表示\[活性]／非表示[非活性])
			initFooterButtonControl();

			// エンティティ初期化
			initEntityData();

		}
		#endregion

		#region
		/// <summary>
		/// フッタボタンの制御(表示\[活性]／非表示[非活性])
		/// </summary>
		protected virtual void initFooterButtonControl()
		{

			// 不要ボタンを非表示、無効(非活性)且つにする
			btnF1.Visible = false; // F1:未使用
			btnF1.Enabled = false; //
			btnF2.Visible = true; // F2:戻る（常に使用可能）
			btnF2.Enabled = true;
			btnF3.Visible = false; // F3;未使用
			btnF3.Enabled = false; //
			btnF4.Visible = false; // F4;未使用
			btnF4.Enabled = false; //
			btnF5.Visible = false; // F5:未使用
			btnF5.Enabled = false; //
			btnF6.Visible = false; // F6:画面ごと
			btnF6.Enabled = false; //
			btnF7.Visible = false; // F7:未使用
			btnF7.Enabled = false; //
			btnF8.AllowAuthLevel = FixedCd.AuthLevel.read;
			if (_isAutoSearch) // 自動検索機能が有効である場合、「検索」ボタンは表示されない
			{
				btnF8.Visible = false; // F8:検索
				btnF8.Enabled = false; //
			}
			else
			{
				btnF8.Visible = true; // F8:検索ボタン（参照権限以上で活性）
				btnF8.Enabled = true;
			}
			btnF9.Visible = false; // F9:画面ごと
			btnF9.Enabled = false; //
			btnF10.AllowAuthLevel = FixedCd.AuthLevel.add;
			if (!_isRegistable) // 登録機能が無効である場合、「登録」ボタンは表示されない
			{
				btnF10.Visible = false; // F10:
				btnF10.Enabled = false; //
			}
			else
			{
				btnF10.Visible = true; // F10:登録ボタン（追加権限以上で活性）
				btnF10.Enabled = true;
			}
			btnF11.AllowAuthLevel = FixedCd.AuthLevel.update;
			if (!_isUpdatable) // 更新機能が無効である場合、「更新」ボタンは表示されない
			{
				btnF11.Enabled = false; // F11:更新
				btnF11.Enabled = false; //
			}
			else
			{
				btnF11.Visible = true; // F10:更新ボタン（更新権限以上で活性）
				btnF11.Enabled = true;
			}
			btnF12.Visible = false; // F12:画面ごと
			btnF12.Enabled = false; //

		}
		#endregion

		#endregion

		#region イベントリンクメソッド

		#region 「一覧に反映」ボタン押下時の処理
		/// <summary>
		/// 「一覧に反映」ボタン押下時の処理
		/// </summary>
		protected virtual void ReflectDetailOnList()
		{
		}
		#endregion

		#region 「取消」ボタン押下時の処理
		/// <summary>
		/// 「取消」ボタン押下時の処理
		/// </summary>
		protected virtual void ReflectCancel()
		{
		}
		#endregion

		#endregion

		#region 画面毎実装メソッド[具象メソッド(宣言)]

		#region 検索条件部の項目初期化
		/// <summary>
		/// 検索条件部の項目初期化
		/// </summary>
		protected virtual void initSearchAreaItems()
		{
		}
		#endregion

		#region 検索結果部の項目初期化
		/// <summary>
		/// 検索結果部の項目初期化
		/// </summary>
		protected virtual void initDetailAreaItems()
		{
		}
		#endregion

		#region 更新部の項目初期化
		/// <summary>
		/// 更新対象エリアの項目初期化
		/// </summary>
		protected virtual void initUpdateAreaItems()
		{
		}
		#endregion

		#region エンティティ初期化
		/// <summary>
		/// エンティティ初期化
		/// </summary>
		protected virtual void initEntityData()
		{
		}
		#endregion

		#region [選択行設定]Grid=>エンティティ(選択行のデータを取得)
		/// <summary>
		/// [選択行設定]Grid=>エンティティ(選択行のデータを取得)
		/// </summary>
		protected virtual void getSelectedRowData()
		{
		}
		#endregion

		#region Gridへの表示(グリッドデータの取得とグリッド表示)
		/// <summary>
		/// Gridへの表示(グリッドデータの取得とグリッド表示)
		/// </summary>
		protected virtual void reloadGrid()
		{
		}
		#endregion

		#region [検索処理](検索条件項目入力チェック)
		/// <summary>
		/// [検索処理](検索条件項目入力チェック)
		/// </summary>
		/// <returns></returns>
		protected virtual bool checkSearchItems()
		{
			return true;
		}
		#endregion

		// ＤＢ処理関連
		#region 検索対象データの取得
		/// <summary>
		/// 検索対象データの取得
		/// </summary>
		/// <returns></returns>
		protected virtual DataTable getTranData()
		{
			return null;
		}
		#endregion

		#endregion

		#endregion

	}
}
