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
	/// TODO:画面パターン81
	/// </summary>
	public partial class PT81 : FormBase
	{

		#region  定数／変数宣言

		#region 変数
		protected DataTable searchResultCourseData = new DataTable(); // コース情報検索結果データ
		protected DataTable searchResultNinzuKbnData = new DataTable(); // 人数区分検索結果データ
		protected DataTable searchResultAddData = new DataTable(); // 追加情報検索結果データ
		protected DataTable searchResultMemoData = new DataTable(); // メモ情報検索結果データ

		protected string errorTableName = string.Empty; // 更新処理失敗時のテーブル名
		public bool closeCheckFlg = false;

		private OracleConnection _oracleConnection; // Oracle Connection

		#endregion

		#region 定数
		#endregion

		#region 列挙体
		/// <summary>
		/// 使用中フラグ更新ON/OFF区分
		/// </summary>
		/// <remarks></remarks>
		public enum UsingOnOffType : int
		{
			usingOn = 1,
			usingOff = 2
		}
		#endregion

		#endregion

		#region FormBaseから

		#region  フォームイベント

		#region 画面起動時の独自処理
		/// <summary>
		/// 画面起動時の独自処理
		/// </summary>
		protected override void StartupOrgProc()
		{

			//Visible
			//TODO:ボタンの表示/非表示を変更
			this.F2Key_Visible = true;
			this.F4Key_Visible = true;

			this.F1Key_Visible = false;
			this.F3Key_Visible = false;
			this.F5Key_Visible = false;
			this.F6Key_Visible = false;
			this.F7Key_Visible = false;
			this.F8Key_Visible = false;
			this.F9Key_Visible = false;
			this.F10Key_Visible = false;
			this.F11Key_Visible = false;
			this.F12Key_Visible = false;

			//Enabled
			// F2:戻る（常に使用可能）
			this.F2Key_Enabled = true;
			// F4:キャンセルなど（不可権限以外で活性）
			this.F4Key_AllowAuth = FixedCd.AuthLevel.read;
			this.F4Key_Enabled = true;

			//Text
			//TODO:ボタンのテキストを変更(必要に応じて)
			this.F2Key_Text = "F2:戻る";
			this.F4Key_Text = "F4:キャンセル";

			//画面パターン毎の固有初期処理
			initScreenPattern();

		}
		#endregion

		#region    Close時
		/// <summary>
		/// 画面クロージング時
		/// </summary>
		protected override bool closingScreen()
		{
			return true;
		}
		#endregion

		#endregion

		#region  コントロールイベント

		#region    F2
		/// <summary>
		/// F2()ボタン押下時の独自処理
		/// </summary>
		protected override void btnF2_ClickOrgProc()
		{
			// 戻る
			closeCheckFlg = true;
			base.closeFormFlg = true;

			this.Close();
		}
		#endregion

		#region    F4
		/// <summary>
		/// F4()ボタン押下時の独自処理
		/// </summary>
		protected override void btnF4_ClickOrgProc()
		{
			//チェック TungPT
			//if (checkUpdateItems() == true)
			//{

			//	//処理確認メッセージ表示
			//	if (CommonProcess.createFactoryMsg().messageDisp("Q90_001", "キャンセル") != DialogResult.Cancel)
			//	{
			//		//F4ボタン押下時処理

			//		//使用中フラグ更新
			//		if (updateUsingFlg((int)UsingOnOffType.usingOn) == true)
			//		{
			//			//キャンセルDB更新
			//			if (cancelDBUpdate() > 0)
			//			{
			//				//処理完了メッセージ表示
			//				CommonProcess.createFactoryMsg().messageDisp("I90_002", "キャンセル");

			//				//再描画
			//				screenRefresh();
			//			}
			//			else
			//			{
			//				//キャンセル処理失敗メッセージ表示
			//				CommonProcess.createFactoryMsg().messageDisp("E90_025", "キャンセル処理", errorTableName);

			//				//使用中フラグ更新
			//				if (updateUsingFlg((int)UsingOnOffType.usingOff) == false)
			//				{
			//					//使用中フラグ更新失敗メッセージ表示
			//					CommonProcess.createFactoryMsg().messageDisp("E90_025", "使用中フラグ更新", errorTableName);
			//				}
			//			}
			//		}
			//		else
			//		{
			//			//使用中フラグ更新失敗メッセージ表示
			//			CommonProcess.createFactoryMsg().messageDisp("E90_025", "使用中フラグ更新", errorTableName);
			//		}

			//		//キャンセルボタンを押下不可にする
			//		this.F4Key_Enabled = false;
			//	}
			//}

		}
		#endregion

		#endregion

		#endregion

		#region PT81独自

		#region メソッド

		#region 画面毎実装メソッド[抽象メソッド(宣言)]
		// 基本的な考え方は画面項目として必要なものだけを外だし
		// 初期化用のメソッド
		// [検索エリア]
		protected virtual void initSearchAreaItems() // 検索条件部の項目初期化
		{
		}
		// グリッド初期設定メソッド
		protected void initGrid() // グリッド初期設定
		{

			//If Not grd Is Nothing Then

			//    'ヘッダ行のみ表示
			//    grd.Rows.Count = 1
			//    '行ヘッダを非表示可
			//    grd.Cols(0).Visible = False
			//    '行選択モード
			//    grd.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
			//    '並び替え不可
			//    grd.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
			//    '編集不可
			//    grd.AllowEditing = False
			//    '自動列生成なし
			//    grd.AutoGenerateColumns = False
			//End If
		}

		// 画面初期Load時のメソッド
		protected virtual void initScreenPattern() // 画面パターン毎の固有初期処理
		{
		}

		// エンティティ系
		// [選択行設定]Grid=>エンティティ
		protected virtual void getSelectedRowData() // 選択行のデータを取得
		{
		}
		// Gridへの表示
		protected virtual void reloadGrid() // グリッドデータの取得とグリッド表示
		{
		}

		// チェック系
		// [更新処理]
		protected override bool checkUpdateItems()
		{
			//キャンセル前チェック
			return checkBeforeCancel();

		}
		protected virtual bool checkBeforeCancel()
		{
			return false;
		}

		//■ＤＢ処理関連■
		protected virtual DataTable getCourseInfoData() // コース情報のデータ取得
		{
			return null;
		}
		protected virtual DataTable getNinzuKbnData() // 人数区分のデータ取得
		{
			return null;
		}
		protected virtual DataTable getAddInfoData() // 追加情報のデータ取得
		{
			return null;
		}
		protected virtual DataTable getMemoInfoData() // メモ情報のデータ取得
		{
			return null;
		}

		// 使用中フラグ更新
		protected virtual bool updateUsingFlg(int usingFlgOnOff)
		{
			return false;
		}

		// キャンセルDB更新
		protected virtual int cancelDBUpdate()
		{
			return 0;
		}

		// 画面再描画処理
		protected virtual void screenRefresh()
		{
		}

		#endregion

		#endregion

		#endregion

	}
}
