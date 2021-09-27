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
	/// 画面パターン11
	/// </summary>
	public partial class PT11 : FormBase
	{
		public PT11()
		{
			InitializeComponent();
		}
		#region  定数／変数宣言

		#region 変数
		protected DataTable SearchResultGridData = new DataTable(); // 検索結果グリッドデータ
		public bool closeCheckFlg = false;

		#endregion

		#region 定数
		#endregion
		// 最大取得件数
		private const int limitMaxData = 1000;
		#endregion

		#region Enum
		#endregion

		//業務画面より移動
		/// <summary>
		/// ＤＢ問合せ区分
		/// </summary>
		/// <remarks></remarks>
		protected enum DbTableKbn : int
		{
			@Select,
			Key
		}

		#region プロパティ
		public string UpdateMsgParam = "";
		public string InsertMsgParam = "";
#endregion

			#region FormBaseから

			#region  フォームイベント
			#region    Load時
			/// <summary>
			/// 画面起動時の独自処理
			/// </summary>
		protected override void StartupOrgProc()
		{

			//画面パターン毎の固有初期処理
			initScreenPerttern();

		}
		#endregion

		#region    Close時
		/// <summary>
		/// 画面クロージング時
		/// </summary>
		protected override bool closingScreen()
		{

			//差分チェック
			if (checkDifference() == true)
			{
				return false;
			}
			else
			{
				return true;
			}

		}
		#endregion

		#endregion

		#region  コントロールイベント
		#region F2(戻る)ボタン押下時
		/// <summary>
		/// F2(戻る)ボタン押下時
		/// </summary>
		protected override void btnF2_ClickOrgProc()
		{
			//戻る
			closeCheckFlg = true;
			base.closeFormFlg = true;
			this.Close();
		}
		#endregion

		#region F4(CSV出力)ボタン押下時
		/// <summary>
		/// F4(CSV出力)ボタン押下時
		/// </summary>
		protected override void btnF4_ClickOrgProc()
		{

		}
		#endregion

		#region F8(検索)ボタン押下時
		/// <summary>
		/// F8(検索)ボタン押下時
		/// </summary>
		protected override void btnF8_ClickOrgProc()
		{
			//チェックして検索
			if (checkSearchItems() == false)
			{
				return;
			}
			else
			{
				//データの取得
				SearchResultGridData = getMstData();

				if (SearchResultGridData.Rows.Count == 0)
				{
					//取得件数0件の場合、メッセージを表示
					CommonProcess.createFactoryMsg().messageDisp("E90_019");

					//登録/確定/更新ボタンを押下不可にする
					F10Key_Enabled = false;
					F11Key_Enabled = false;
				}
				else
				{
					//検索後のチェック（DB取得後にDBの値でチェックする必要がある場合はここで実装）
					if (checkAfterSearch() == false)
					{
						return;
					}

					//最大取得件数で絞込み
					SearchResultGridData = CommonDAUtil.checkLimitData(SearchResultGridData, limitMaxData);

					//登録/確定/更新ボタンを押下可にする
					F10Key_Enabled = true;
					F11Key_Enabled = true;
				}
				//検索後グリッド表示処理
				reloadGrid();
				if (SearchResultGridData.Rows.Count > 0)
				{
					//使用中フラグチェック
					checkUsingFlgAfterSearch();
				}
			}
		}
		#endregion

		#region F10(登録／確定)ボタン押下時
		/// <summary>
		/// F10(登録／確定)ボタン押下時
		/// </summary>
		protected override void btnF10_ClickOrgProc()
		{

			//登録／確定処理前チェック
			if (checkBeforeInsert() == true)
			{
				//登録／確定処理
				if (insertProc() == true)
				{
					CommonProcess.createFactoryMsg().messageDisp("I90_002", "登録");
					btnF8_ClickOrgProc();
				}
			}

		}
		#endregion

		#region F11(更新)ボタン押下時
		/// <summary>
		/// F11(更新)ボタン押下時
		/// </summary>
		protected override void btnF11_ClickOrgProc()
		{

			//更新処理前チェック
			if (checkBeforeUpdate() == true)
			{
				//更新処理
				if (updateProc() == true)
				{
					CommonProcess.createFactoryMsg().messageDisp("I90_002", "更新");
					btnF8_ClickOrgProc();
				}
			}

		}
		#endregion

		#region    条件クリア
		/// <summary>
		/// 条件クリアボタン押下時
		/// </summary>
		protected override void btnCLEAR_ClickOrgProc()
		{
			// 検索条件部の項目初期化
			initSearchAreaItems();
		}
		#endregion

		#endregion

		#endregion

		#region PT11独自

		#endregion

		#region メソッド

		#region イベントリンクメソッド
		/// <summary>
		/// 一覧グリッドイベント時
		/// </summary>
		protected virtual void clickedMainGrid()
		{
		}

		#endregion

		#region 画面毎実装メソッド[抽象メソッド(宣言)]
		//基本的な考え方は画面項目として必要なものだけを外だし
		//初期化用のメソッド
		//[検索エリア]
		protected virtual void initSearchAreaItems() // 検索条件部の項目初期化
		{
		}
		//[詳細エリア]
		protected virtual void initDetailAreaItems() // 検索結果部の項目初期化
		{
		}
		//[エンティティ]
		protected virtual void initEntityData() // エンティティ初期化
		{
		}

		//画面初期Load時のメソッド
		protected virtual void initScreenPerttern() // 画面パターン毎の固有初期処理
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

		// フッタボタンの制御(表示\[活性]／非表示[非活性])
		protected virtual void initFooterButtonControl()
		{

			// 不要ボタンを非表示、無効(非活性)且つにする
			btnF1.Visible = false; // F1:未使用
			btnF1.Enabled = false; //
			btnF2.Visible = true; // F2:戻る（常に使用可能）
			btnF2.Enabled = true; //
			btnF3.Visible = false; // F3:未使用
			btnF3.Enabled = false; //
			btnF4.Visible = true; // F4:CSV出力など（不可権限以外活性）
			btnF4.AllowAuthLevel = FixedCd.AuthLevel.read;
			btnF4.Enabled = true;
			btnF5.Visible = false; // F5:未使用
			btnF5.Enabled = false; //
			btnF6.Visible = false; // F6:画面ごと
			btnF6.Enabled = false; //
			btnF7.Visible = false; // F7:画面ごと
			btnF7.Enabled = false; //
			btnF8.Visible = false; // F8:未使用
			btnF8.Enabled = false; //
			btnF9.Visible = false; // F9:未使用
			btnF9.Enabled = false; //
			btnF10.Visible = true; // F10:登録ボタン（追加権限以上で活性）
			btnF10.AllowAuthLevel = FixedCd.AuthLevel.add;
			btnF10.Enabled = true;
			btnF11.Visible = true; // F11:更新ボタン（更新権限以上で活性）
			btnF11.AllowAuthLevel = FixedCd.AuthLevel.update;
			btnF11.Enabled = true;
			btnF12.Visible = false; // F12:画面ごと
			btnF12.Enabled = false; //

			this.F2Key_Text = "F2:戻る";
			this.F4Key_Text = "F4:CSV出力";
			this.F8Key_Text = "F8:検索";
			this.F10Key_Text = "F10:登録";
			this.F11Key_Text = "F11:更新";

		}

		//エンティティ系

		//[選択行設定]Grid=>エンティティ
		protected virtual void getSelectedRowData() // 選択行のデータを取得
		{
		}

		//Gridへの表示
		protected virtual void reloadGrid() // グリッドデータの取得とグリッド表示
		{
		}

		//チェック系
		//[検索前処理]
		protected virtual bool checkSearchItems() // 検索条件項目入力チェック（検索前）
		{
			return true;
		}

		//チェック系
		//[検索後処理]
		protected virtual bool checkAfterSearch() // 検索条件項目入力チェック（DB取得後のチェック）
		{
			return true;
		}

		//チェック系
		//[検索後処理]
		protected virtual void checkUsingFlgAfterSearch() // 検索処理後の使用中フラグチェック
		{
		}

		//チェック系
		//[登録前処理]
		protected virtual bool checkBeforeInsert() //登録処理前のチェック
		{
			return true;
		}

		//チェック系
		//[更新前処理]
		protected virtual bool checkBeforeUpdate() //更新処理前のチェック
		{
			return true;
		}

		//TODO:削除予定
		protected virtual void initUpdateEntity() // 更新エンティティ初期化
		{
		}


		//■ＤＢ処理関連■
		//Select
		protected virtual DataTable getMstData() // 対象マスタのデータ取得
		{
			return null;
		}

		protected virtual DataTable getMstDataByPrimaryKey() // キー値での問合せ
		{
			return null;
		}

		//Insert
		protected virtual bool insertProc() // 登録処理
		{
			return true;
		}

		//Update
		protected virtual bool updateProc() // 登録処理
		{
			return true;
		}
		#endregion

		#endregion

	}
}
