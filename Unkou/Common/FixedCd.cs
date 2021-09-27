using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unkou.Common
{
	/// <summary>
	/// 固定コード
	/// </summary>
	/// <remarks></remarks>
	public sealed class FixedCd //固定コード
	{

		#region  固定コード

		/// <summary>
		/// システム名
		/// </summary>
		public sealed class SystemName
		{
			[Value("システム名")]
			public const string systemname = "予約システム";
		}

		/// <summary>
		/// 取扱い部署
		///  ※その他：9の使用方法に注意
		/// </summary>
		/// <remarks></remarks>
		public enum ToriatsukaiBusyo : int
		{
			[Value("定期観光部")]
			teiki = 1,
			[Value("企画旅行部")]
			kikaku = 2,
			[Value("国際事業部")]
			world = 3,
			[Value("その他")]
			others = 9
		}

		/// <summary>
		/// 帳票処理タイプ（手仕舞い）
		/// </summary>
		/// <remarks>画面連携用</remarks>
		public enum TejimaiActionType : int
		{
			[Value("紙")]
			Kami,
			[Value("PDF_コース毎")]
			PDFKosuGoto,
			[Value("PDF_全コース")]
			PDFZenkosu,
			[Value("CSV_コース毎")]
			CSVKosuGoto,
			[Value("CSV_全コース")]
			CSVZenkosu,
			[Value("プレビュー")]
			Purebyu,
			[Value("PDF")]
			PDF,
			[Value("CSV")]
			CSV,
			[Value("CSV")]
			FAX
		}

		public enum TejimaiCallType : int
		{
			[Value("手仕舞い表")]
			TejimaiHyo
		}

		/// <summary>
		/// AGENT請求書
		/// </summary>
		/// <remarks></remarks>
		public enum AgentInvoice : int
		{
			[Value("AGENT請求書発行元郵便番号")]
			publisherPostCode = 102,
			[Value("AGENT請求書発行元住所")]
			publisherAddr = 103,
			[Value("AGENT請求書発行元部署")]
			publisherDept = 104,
			[Value("AGENT請求書発行元TEL")]
			publisherTel = 105,
			[Value("AGENT請求書発行元FAX")]
			publisherFax = 106
		}

		/// <summary>
		/// 定期＿企画区分
		/// </summary>
		/// <remarks></remarks>
		public enum Teiki_KikakuKbnType : int //定期＿企画区分タイプ
		{
			[Value("定期")]
			teikiKanko = 1, //定期観光
			[Value("企画")]
			kikakuTravel = 2 //企画旅行
		}
		/// <summary>
		/// コース分類
		/// </summary>
		/// <remarks></remarks>
		public enum CrsBunruiType : int //コース分類タイプ
		{
			shinki = 1, //新規
			continuation = 2, //継続
			kaitei = 3 //改定
		}
		/// <summary>
		/// コース種別
		/// </summary>
		/// <remarks></remarks>
		public enum CrsKindType : int //コース種別タイプ
		{
			[Value("定期")]
			hatoBusTeiki = 1, //はとバス定期
			[Value("キャピタル")]
			capital = 2, //キャピタル
						 // シーラインは次期では不要(Commonで使用されているためそのまま)
			shirain = 3, //シーライン
			[Value("企画（日帰り）")]
			higaeri = 4, //日帰り
			[Value("企画（宿泊）")]
			stay = 5, //宿泊
			[Value("企画（Rコース）")]
			rcourse = 6
			//gaikyaku = 8  '外客

		}
		/// <summary>
		/// メッセージ区分
		/// </summary>
		/// <remarks></remarks>
		public sealed class MessageKbnType //メッセージ区分タイプ
		{
			public const string DisplayOnly = "D"; //表示のみ
			public const string Display_Printing = "Y"; //表示＿印字
			public const string D = "表示のみ";
			public const string Y = "表示＆印字";
		}
		/// <summary>
		/// 方面コード_1桁目
		/// </summary>
		/// <remarks></remarks>
		public enum HomenCd_1DigitType : int
		{
			[Value("日帰り")]
			higaeri = 4,
			[Value("宿泊")]
			stay = 5
		}
		/// <summary>
		/// 座席指定区分
		/// </summary>
		/// <remarks></remarks>
		public enum ZasekiReserveKbnType : int //座席指定区分タイプ
		{
			[Value("縦")]
			tate = 1, //縦
			[Value("横")]
			yoko = 2 //横
		}

		/// <summary>
		/// 座席区分
		/// </summary>
		/// <remarks></remarks>
		public enum ZasekiKbnType : int //座席区分タイプ
		{
			[Value("座席")]
			zaseki = 0, //座席
			[Value("行")]
			row = 1, //行
			[Value("列")]
			col = 2 //列
		}

		/// <summary>
		/// 原価設定区分
		/// </summary>
		/// <remarks></remarks>
		public sealed class CostSetKbnType //原価設定区分タイプ
		{
			public const string PartMiSet = "P"; //一部未設定
			public const string SetAlready = "Y"; //設定済み
		}
		/// <summary>
		/// 専用コース区分
		/// </summary>
		/// <remarks></remarks>
		public enum SenyoCrsKbnType : int //専用コース区分タイプ
		{
			male = 1, //男性
			jyosei = 2, //女性
			junior = 3, //中人
			child = 4 //小人
		}
		/// <summary>
		/// WEB種別
		/// </summary>
		/// <remarks></remarks>
		public enum WebKindType : int //WEB種別タイプ
		{
			WEBHanbaiOk = 1, //WEB販売可
			WEBDisplayOnly = 2, //WEB表示のみ
			WEBNg = 3 //WEB不可
		}
		/// <summary>
		/// 出発時キャリア区分
		/// </summary>
		/// <remarks></remarks>
		public enum SyuptJiCarrierKbnType : int //出発時キャリア区分タイプ
		{
			bus = 1, //バス
			sonota = 2 //その他
		}
		/// <summary>
		/// キャンセル料区分
		/// </summary>
		/// <remarks></remarks>
		public enum CancelRyouKbnType : int //キャンセル料区分タイプ
		{
			[Value("日帰り")]
			higaeri = 4, //日帰り
			[Value("宿泊")]
			stay = 5 //宿泊
		}
		/// <summary>
		/// 乗車種別
		/// </summary>
		/// <remarks></remarks>
		public enum JyosyaKindType : int //乗車種別タイプ
		{
			jyo1 = 1, //乗１
			jyo2 = 2 //乗２
		}
		/// <summary>
		/// コース区分１
		/// </summary>
		/// <remarks></remarks>
		public enum CrsKbn1Type : int //コース区分１タイプ
		{
			noon = 1, //昼
			night = 2, //夜
			other = 9 //他
		}
		/// <summary>
		/// コース区分２
		/// </summary>
		/// <remarks></remarks>
		public enum crsKbn2Type : int //コース区分２タイプ
		{
			tonai = 1, //都内
			suburbs = 2, //郊外
			RCrs = 3, //Ｒコース
			other = 9 //他
		}
		/// <summary>
		/// コース区分３
		/// </summary>
		/// <remarks></remarks>
		public enum CrsKbn3Type : int //コース区分３タイプ
		{
			tunen = 0, //通年
			kisetu = 1, //季節
			___ = 2
		}
		/// <summary>
		/// 特定料金区分
		/// </summary>
		/// <remarks></remarks>
		public sealed class TokuteiChargeKbnType //特定料金区分タイプ
		{
			public const string SatDay = "A"; //土日
		}
		/// <summary>
		/// 日付種別
		/// </summary>
		/// <remarks></remarks>
		public enum YmdKindType : int //日付種別タイプ
		{
			@set = 0, //設定
			exclusion = 1 //除外
		}
		/// <summary>
		/// コースステータス
		/// </summary>
		/// <remarks></remarks>
		public enum CrsStatusType : int //コースステータスタイプ
		{
			zouseiChu = 0, //造成中
			zouseiReviewChu = 1, //造成レビュー中
			zouseiDone = 2, //造成完了
			pamphCreateDone = 3 //パンフ作成完了
		}
		/// <summary>
		/// 運休連絡先
		/// </summary>
		/// <remarks></remarks>
		public enum UnkyuContactSakiType : int //運休連絡先タイプ
		{
			local = 0, //現地
			toan = 1 //東案
		}
		/// <summary>
		/// 食事種別
		/// </summary>
		/// <remarks></remarks>
		public enum MealKindType : int //食事種別タイプ
		{
			breakfast = 1, //朝食
			lunch = 2, //昼食
			dinner = 3 //夕食
		}
		///' <summary>
		///' 運休区分
		///' </summary>
		///' <remarks></remarks>
		//Public NotInheritable Class 運休区分タイプ
		//    Public Const 廃止 As String = "X"
		//End Class
		/// <summary>
		/// 運休区分
		/// </summary>
		/// <remarks></remarks>
		public enum UnkyuKbnType
		{
			abolition = 0, //廃止
			unkyu //運休
		}
		/// <summary>
		/// 人数種別
		/// </summary>
		/// <remarks></remarks>
		public enum NinzuKindType : int //人数種別タイプ
		{
			/// <summary>１名１室</summary>
			_one1R = 1,
			/// <summary>２名１室</summary>
			_two1R = 2,
			/// <summary>３名１室</summary>
			_three1R = 3,
			/// <summary>４名１室</summary>
			_four1R = 4,
			/// <summary>５名以上１室</summary>
			_fiveIjyou1R = 5
		}
		/// <summary>
		/// ピックアップ区分
		/// </summary>
		/// <remarks></remarks>
		public enum PickupKbnType : int //ピックアップ区分タイプ
		{
			morning1 = 1, //朝１
			morning2 = 3, //朝２
			noon1 = 4, //昼１
			noon2 = 5, //昼２
			night1 = 7 //夜１
		}
		/// <summary>
		/// 食事付フラグ
		/// </summary>
		/// <remarks></remarks>
		public sealed class MealTukiFlgType
		{
			[Value("朝食付")]
			public const string BreakfastTuki = "1";
			[Value("２食付")]
			public const string NiSyokutuki = "2";
		}
		/// <summary>
		/// 税区分
		/// </summary>
		/// <remarks></remarks>
		public enum TaxKbnType : int //税区分タイプ
		{
			[Value("税込")]
			zeikomi = 1,
			[Value("税抜")]
			zeinuki = 2,
			[Value("非課税")]
			hikazei = 9
		}
		/// <summary>
		/// 税区分(帳票表示用)
		/// </summary>
		/// <remarks></remarks>
		public enum TaxKbn_FormForType : int //税区分_帳票用タイプ
		{
			inside = 1, //内
			outside = 2, //外
			non = 9 //非
		}
		/// <summary>
		/// 精算方法
		/// </summary>
		/// <remarks></remarks>
		public enum SeisanHohoType : int //精算方法タイプ
		{
			[Value("クーポン")]
			coupon = 1,
			[Value("青伝")]
			aoden = 2,
			[Value("請求書")]
			seikyusyo = 3,
			[Value("現金")]
			genkin = 4,
			[Value("赤伝")]
			akaden = 5
		}
		/// <summary>
		/// 特定料金設定
		/// </summary>
		/// <remarks></remarks>
		public enum TokuteiChargeSetType : int //特定料金設定タイプ
		{
			[Value("平日")]
			heijitu = 0,
			[Value("土日")]
			satDay = 1,
			[Value("土日祝")]
			satDaySYUKU = 2,
			[Value("金日")]
			friDay = 3,
			[Value("休前日")]
			kyuzenDay = 4
		}
		/// <summary>
		/// 預金種目
		/// </summary>
		/// <remarks></remarks>
		public enum YokinEventType : int //預金種目タイプ
		{
			[Value("普通")]
			usually = 1,
			[Value("当座")]
			touza = 2,
			[Value("他")]
			other = 9
		}
		/// <summary>
		/// ステータス条件
		/// </summary>
		/// <remarks></remarks>
		public enum StatusConditionsType : int //ステータス条件タイプ
		{
			mi = 1, //未
			already = 2 //済
		}
		///' <summary>
		///' 送客手数料
		///' </summary>
		///' <remarks></remarks>
		//Public NotInheritable Class 送客手数料タイプ
		//    Public Const 台数 As String = "A"
		//    Public Const 人数 As String = "B"
		//    Public Const 売上 As String = "C"
		//End Class
		/// <summary>
		/// 送客手数料
		/// </summary>
		/// <remarks></remarks>
		public enum SokyakFeeType : int //送客手数料タイプ
		{
			[Value("台数")]
			daisu, //台数
			[Value("人数")]
			ninzu, //人数
			[Value("売上")]
			uriage //売上
		}
		/// <summary>
		/// 平日／特定日区分
		/// </summary>
		/// <remarks></remarks>
		public enum Heijitu_TokuteiDayKbn : int //平日_特定日区分
		{
			heijitu = 0, //平日
			tokuteiDay1 = 1, //特定日１
			tokuteiDay2 = 2 //特定日２
		}
		/// <summary>
		/// 支払い方法
		/// </summary>
		/// <remarks></remarks>
		public enum PaymentHoho : int //支払い方法
		{
			hurikomi = 1, //振込
			genkin = 2, //現金
			other = 3 //他
		}
		/// <summary>
		/// 手続きタイプ
		/// </summary>
		/// <remarks></remarks>
		public enum TetudukiType : int //手続きタイプ
		{
			akaden = 1, //赤伝
			aoden = 2, //青伝
			genkin = 3, //現金
			seikyusyo = 4, //請求書
			hurikomi = 5, //振込
			ticket = 6, //チケット
			admissionRyou = 7, //入園料
			sonota = 8 //その他
		}
		/// <summary>
		/// 営業所マスタ
		/// 振込請求フラグタイプ
		/// </summary>
		/// <remarks></remarks>
		public enum HurikomiSeikyusyoKbnType : int //振込請求書区分タイプ
		{
			hurikomiSeikyusyo = 1, //振込請求書
			AGTSeikyusyo, //AGT請求書
			oredenSeikyusyo //オレ伝請求書
		}
		/// <summary>
		/// 精算目的：コードマスタ[コード分類:158]
		/// </summary>
		/// <remarks></remarks>
		public sealed class SeisanTgtCdType //精算目的タイプ
		{
			[Value("入搭乗")]
			public const string nyuTojo = "E";
		}

		/// <summary>
		/// テキスト付フォーマット区分
		/// </summary>
		/// <remarks></remarks>
		public enum String_FormatType : int
		{
			[Value("#,##0")]
			formatDecimal = 1
		}
		/// <summary>
		/// 集約料金区分
		/// </summary>
		/// <remarks></remarks>
		public enum ShuyakuRyokinKbnType : int
		{
			[Value("大人")]
			adult = 10,
			[Value("中人")]
			junior = 20,
			[Value("小人")]
			child = 30
		}
		/// <summary>
		/// 初期画面では営業所にS050503
		/// </summary>
		public const string INIT_CODE_S050503 = "90";
		/// <summary>
		/// 新宿営業所
		/// </summary>
		public enum ChildDepartment : int
		{
			//都庁
			[Value("0036")]
			TokyoMetropolitanGovernment = 1,
			//池袋
			[Value("0033")]
			Ikebukuro = 2,
			//浜松町ﾁｪｯｸｲﾝ
			[Value("0016")]
			HamamatsuchoCheckIn = 3,
			//新宿西口
			[Value("0034")]
			ShinjukuWestExit = 4,
			//池袋東口
			[Value("0039")]
			IkebukuroEastEntrance = 5,
			//企画旅行地元発
			[Value("0006")]
			PlanningTripFromLocal = 6,
			//横浜Ｙ－ＣＡＴ
			[Value("0041")]
			YokohamaYCat = 7,
			//横浜市営
			[Value("0043")]
			YokohamaMunicipalAdministration = 8,
			//浜松町
			[Value("0015")]
			Hamamatsucho = 9,
			//キャ企画
			[Value("0052")]
			CaPlanning = 10,
			//企画
			[Value("0008")]
			Planning = 11,
			//運輸
			[Value("0005")]
			Transport = 12,
			//キャピタルH
			[Value("0012")]
			CapitalH = 13
		}

		/// <summary>
		/// 船車券
		/// </summary>
		public enum ShipTicket : int
		{
			//船車券（定期）
			[Value("1")]
			SensyaKenTeiki = 1,
			//船車券(Rコース)
			[Value("2")]
			VesselTicket = 2,
			//B/C(定期)
			[Value("3")]
			BcRegular = 3,
			//B/C(Rコース)
			[Value("4")]
			BcRCourse = 4,
			//クレジット
			[Value("9")]
			Credit = 9
		}
		/// <summary>
		/// ラジオボタンステータス
		/// </summary>
		public enum RadioStatus : int
		{
			//ON
			[Value("1")]
			Check = 1,
			//OFF
			[Value("0")]
			UnCheck = 0
		}
		/// <summary>
		/// 割引コード
		/// </summary>
		public enum WaribikiCd : int
		{
			//招待優待のみ
			[Value("002")]
			ShotaiYutai = 1,
			//ファミリーチケットのみ
			[Value("004")]
			Famirichiketto = 2
		}
		/// <summary>
		/// 定期企画区分
		/// </summary>
		public enum TeikiKikaku : int
		{
			//定期
			[Value("1")]
			Teiki = 1,
			//企画
			[Value("2")]
			Kikaku = 2
		}
		/// <summary>
		/// クーポンフラグ
		/// </summary>
		public enum CouponFlg : int
		{
			//ON
			[Value("1")]
			FlgOn = 1,
			//OFF
			[Value("0")]
			FlgOff = 0
		}
		/// <summary>
		/// 営業所種別
		/// </summary>
		public enum EigyojoShubetsu : int
		{
			//定期
			[Value("1")]
			Teiki = 1,
			//企画
			[Value("2")]
			Kikaku = 2
		}
		public enum KekkaconditionSearch : int
		{
			//会社コード1
			[Value("companyCd1")]
			COMPANY_CD1 = 1,
			//会社コード2
			[Value("companyCd2")]
			COMPANY_CD2 = 2,
			//営業所
			[Value("eigyosyoCd")]
			EIGYOSYO_CD = 3,
			//定期企画区分
			[Value("teikiKikakuKbn")]
			TEIKI_KIKAKU_KBN = 4,
			//処理月
			[Value("createDay")]
			CREATE_DAY = 5,
			//出発月
			[Value("syuptDay")]
			SYUPT_DAY = 6,
			//処理月From
			[Value("createDayFrom")]
			CREATE_DAY_FROM = 7,
			//処理月To
			[Value("createDayTo")]
			CREATE_DAY_TO = 8,
			//出発月From
			[Value("syuptDayFrom")]
			SYUPT_DAY_FROM = 9,
			//出発月To
			[Value("syuptDayTo")]
			SYUPT_DAY_TO = 10,
			//日本語の場合1
			[Value("houjinGaikyakuKbn1")]
			HOUJIN_GAIKYAKU_KBN_1 = 11,
			//日本語の場合2
			[Value("houjinGaikyakuKbn2")]
			HOUJIN_GAIKYAKU_KBN_2 = 12,
			//クーポンフラグ
			[Value("couponFlg")]
			COUPON_FLG = 13,
			//割引コード1
			[Value("waribikiCd1")]
			WARIBIKI_CD_1 = 14,
			//割引コード2
			[Value("waribikiCd2")]
			WARIBIKI_CD_2 = 15,
			//代理店コード
			[Value("Dairiten")]
			DAIRITEN = 16,
			//コースコード
			[Value("Kosu")]
			KOSU = 17,
			//担当者コード
			[Value("TanToSha")]
			TANTOSHA = 18,
			//予約ＮＯ
			[Value("YoYaKuBango")]
			YOYAKUBANGO = 19
		}
		/// <summary>
		/// 検索メモ一覧表示状況
		/// </summary>
		public enum ConditionSearchMemoIchiranHyoji : int
		{
			//コースコード
			[Value("CRS_CD")]
			CRS_CD = 1,
			//出発日
			[Value("SYUPT_DAY")]
			SYUPT_DAY = 2,
			//号車
			[Value("GOUSYA")]
			GOUSYA = 3,
			//予約区分
			[Value("YOYAKU_KBN")]
			YOYAKU_KBN = 4,
			//予約ＮＯ
			[Value("YOYAKU_NO")]
			YOYAKU_NO = 5,
			//予約番号
			[Value("RESER_NM")]
			RESER_NM = 6,
			//共有事項
			[Value("SHARED_ITEMS")]
			SHARED_ITEMS = 7,
			//メモ
			[Value("MEMO")]
			MEMO = 8,
			//降車箇所連絡
			[Value("DISEMBARKATION_PLACE_REPORT")]
			DISEMBARKATION_PLACE_REPORT = 9,
			//スタッフ共有
			[Value("STAFF_SHARING")]
			STAFF_SHARING = 10,
			//業務履歴
			[Value("BUSINESS_HISTORY")]
			BUSINESS_HISTORY = 11,
			//入金連絡
			[Value("PAYMENT_CONTACT")]
			PAYMENT_CONTACT = 12,
			//予約確認
			[Value("BOOKING_CONFIRMATION")]
			BOOKING_CONFIRMATION = 13,
			//ＮＯＳＨＯＷ確認
			[Value("NOSHOW_CONFIRMATION")]
			NOSHOW_CONFIRMATION = 14,
			//催行中止連絡
			[Value("CANCELLATION_OF_LIAISON")]
			CANCELLATION_OF_LIAISON = 15,
			//ダブリチェック
			[Value("DUBRICITY_CHECK")]
			DUBRICITY_CHECK = 16,
			//ウェイト
			[Value("WEIGHT")]
			WEIGHT = 17,
			//リクエスト
			[Value("REQUEST")]
			REQUEST = 18,
			//枝番
			[Value("EDABAN")]
			EDABAN = 19
		}
		/// <summary>
		/// メモ一覧表示エイリアス
		/// </summary>
		public enum AliasMemoIchiranHyoji : int
		{
			[Value("COL_UPDATE")]
			COL_UPDATE = 1,
			[Value("RESER_NM")]
			RESER_NM = 2,
			[Value("NAME")]
			NAME = 3,
			[Value("CODE_NAME1")]
			CODE_NAME1 = 4,
			[Value("CODE_NAME2")]
			CODE_NAME2 = 5,
			[Value("NAIYO")]
			NAIYO = 6,
			[Value("SYSTEM_UPDATE_DAY")]
			SYSTEM_UPDATE_DAY = 7,
			[Value("SYSTEM_UPDATE_PERSON_CD")]
			SYSTEM_UPDATE_PERSON_CD = 8
		}
		/// <summary>
		/// 検索署名明細票状況
		/// </summary>
		public enum ConditionSearchFujoShomeiMeisai_Hyo : int
		{
			//営業所コード
			[Value("EIGYOSYO_CD")]
			EIGYOSYO_CD = 1,
			//システム登録日
			[Value("SYSTEM_ENTRY_DAY")]
			SYSTEM_ENTRY_DAY = 2,
			//ユーザID
			[Value("USER_ID")]
			USER_ID = 3,
			//コース種別
			[Value("HOUJIN_GAIKYAKU_KBN")]
			HOUJIN_GAIKYAKU_KBN = 4,
			//登録日
			[Value("ENTRY_DAY")]
			ENTRY_DAY = 5,
			//氏名
			[Value("USER_NAME")]
			USER_NAME = 6,
			//サインオン時刻
			[Value("SIGNON_TIME")]
			SIGNON_TIME = 7,
			//ユーザID
			[Value("ENTRY_PERSON_CD")]
			ENTRY_PERSON_CD = 8
		}
		/// <summary>
		/// 検索予約状況表状況
		/// </summary>
		public enum ConditionSearchYoyaku_Jokyo_Hyo : int
		{
			[Value("TAISYOU_CHECK")]
			TAISYOU_CHECK = 1,
			[Value("KAKO_TAISYOU_CHECK")]
			KAKO_TAISYOU_CHECK = 2,
			[Value("TAISYOU_DATE")]
			TAISYOU_DATE = 3,
			[Value("KAKO_TAISYOU_DATE")]
			KAKO_TAISYOU_DATE = 4,
			[Value("CRS_CD")]
			CRS_CD = 5,
			[Value("MARU_ZOU_MANAGEMENT_KBN")]
			MARU_ZOU_MANAGEMENT_KBN = 6,
			[Value("TEIKI_KIKAKU_KBN")]
			TEIKI_KIKAKU_KBN = 7,
			[Value("SAIKOU_TYUSHI")]
			SAIKOU_TYUSHI = 8,
			[Value("NIHONGO_CHECK")]
			NIHONGO_CHECK = 9,
			[Value("GAIKOKUGO_CHECK")]
			GAIKOKUGO_CHECK = 10,
			[Value("HOUJIN_KBN")]
			HOUJIN_KBN = 11,
			[Value("CRS_KBN_NOON_CHECK")]
			CRS_KBN_NOON_CHECK = 12,
			[Value("CRS_KBN_NIGHT_CHECK")]
			CRS_KBN_NIGHT_CHECK = 13,
			[Value("CRS_KBN")]
			CRS_KBN = 14,
			[Value("CRS_RCOURSE_CHECK")]
			CRS_RCOURSE_CHECK = 15,
			[Value("CRS_KIND_HIGAERI_CHECK")]
			CRS_KIND_HIGAERI_CHECK = 16,
			[Value("CRS_KIND_SYUKUHAKU_CHECK")]
			CRS_KIND_SYUKUHAKU_CHECK = 17,
			[Value("CRS_KIND")]
			CRS_KIND = 18,
			[Value("COURSE_TYPE")]
			COURSE_TYPE = 19,
			[Value("CRS_NAME")]
			CRS_NAME = 20,
			[Value("PLACE_NAME_1")]
			PLACE_NAME_1 = 21,
			[Value("SYUPT_TIME_1")]
			SYUPT_TIME_1 = 22,
			[Value("GOUSYA")]
			GOUSYA = 23,
			[Value("SYUPT_DAY")]
			SYUPT_DAY = 24,
			[Value("CANCEL_WAIT_NINZU")]
			CANCEL_WAIT_NINZU = 25,
			[Value("YOYAKU_NUM_TEISEKI")]
			YOYAKU_NUM_TEISEKI = 26,
			[Value("CRS_KIND_OR")]
			CRS_KIND_OR = 27,
			[Value("CODE_BUNRUI_KIND")]
			CODE_BUNRUI_KIND = 28,
			[Value("CODE_BUNRUI_KBN")]
			CODE_BUNRUI_KBN = 29,
			[Value("HOUJIN_GAIKYAKU_KBN")]
			HOUJIN_GAIKYAKU_KBN = 30,
			[Value("COURSE_CLASS")]
			COURSE_CLASS = 31,
			[Value("YOYAKU_NUM_SUB_SEAT")]
			YOYAKU_NUM_SUB_SEAT = 32
		}
		/// <summary>
		/// メモ区分
		/// </summary>
		/// <remarks></remarks>
		public sealed class NoteClassification
		{
			[Value("共有事項")]
			public const string Shared_Items = "01";
			[Value("廃止")]
			public const string Business_History = "02";
		}
		/// <summary>
		/// メモ分類
		/// </summary>
		/// <remarks></remarks>
		public sealed class MemoClassification
		{
			[Value("メモ")]
			public const string memo = "01";
			[Value("降車ヶ所連絡")]
			public const string disembarkation_Place_Report = "02";
			[Value("スタッフ共有")]
			public const string staff_Sharing = "03";
			[Value("入金連絡")]
			public const string payment_Contact = "04";
			[Value("予約確認")]
			public const string booking_Confirmation = "05";
			[Value("NOSHOW確認")]
			public const string NOSHOW_Confirmation = "06";
			[Value("催行中止連絡")]
			public const string cancellation_Of_Liaison = "07";
			[Value("ダブリチェック")]
			public const string dubricity_Check = "08";
			[Value("ウェイト")]
			public const string weight = "09";
			[Value("リクエスト")]
			public const string request = "10";
		}
		/// <summary>
		/// コース種別
		/// </summary>
		/// <remarks></remarks>
		public enum CrsKbnType : int
		{
			[Value("はとバス定期")]
			HatoBusTeiki = 1,
			[Value("キャピタル")]
			Capital = 2,
			[Value("企画日帰り")]
			Higaeri = 4,
			[Value("企画宿泊")]
			Stay = 5,
			[Value("企画都内Rコース")]
			Kikaku = 6
		}
		/// <summary>
		/// 割引種類
		/// </summary>
		/// <remarks></remarks>
		public enum WaribikiTypeKbn : int
		{
			[Value("一般割引")]
			GeneralDiscount = 1,
			[Value("招待優待")]
			InvitationBenifit = 2,
			[Value("身障者")]
			DisabledPerson = 3,
			[Value("家族慰安")]
			FamilyComfort = 4
		}
		/// <summary>
		/// 預金種目
		/// </summary>
		/// <remarks></remarks>
		public enum YokiniEvent : int
		{
			[Value("普通")]
			Usually = 1,
			[Value("当座")]
			Touza = 2,
			[Value("他")]
			Other = 3
		}
		/// <summary>
		/// 営業所マスタ
		/// 振込請求フラグタイプ
		/// </summary>
		/// <remarks></remarks>
		public sealed class HurikomiSeikyusyoType
		{
			[Value("振込請求書")]
			public const string HurikomiSeikyusyo = "Y";
			[Value("AGT請求書")]
			public const string AGTSeikyusyo = "S";
			[Value("オレ伝請求書")]
			public const string OredenSeikyusyo = "D";
		}
		/// <summary>
		/// 取引先区分
		/// </summary>
		/// <remarks></remarks>
		public enum SsTorihikiSakiKbn : int
		{
			[Value("なし")]
			Nashi = 0,
			[Value("得意先")]
			Customer = 1
		}
		/// <summary>
		/// 船車券
		/// </summary>
		/// <remarks></remarks>
		public enum SensyaKen : int
		{
			[Value("なし")]
			Nashi = 0,
			[Value("船車券")]
			SensyaKen = 1
		}
		/// <summary>
		/// クレジット
		/// </summary>
		public enum Credit : int
		{
			[Value("なし")]
			Nashi = 0,
			[Value("クレジット")]
			Credit = 1
		}
		/// <summary>
		/// 貸借区分
		/// </summary>
		public enum TaisyakuKbn : int
		{
			[Value("借方")]
			Karikata = 0,
			[Value("貸方")]
			Kasikata = 1
		}

		/// <summary>
		/// 通知方法[バス会社確定通知方法]値の内容
		/// </summary>
		/// <remarks></remarks>
		public enum NotificationHohoBusCompany : int
		{
			[Value("メール")]
			Mail = 1,
			[Value("FAX")]
			Fax = 2,
			[Value("郵送")]
			Yusou = 3
		}
		/// <summary>
		/// コース区分１
		/// </summary>
		public enum CrsKbn1 : int
		{
			[Value("昼")]
			day = 1,
			[Value("夜 ")]
			night = 2
		}
		/// <summary>
		/// コース区分２
		/// </summary>
		public enum CrsKbn2 : int
		{
			[Value("都内")]
			tonai = 1,
			[Value("郊外")]
			kogai = 2
		}
		/// <summary>
		/// 選択
		/// </summary>
		public enum Sentaku : int
		{
			//定期
			[Value("定期")]
			Regular = 1,
			//企画
			[Value("定期")]
			Planning = 2,
			//キャピタル
			[Value("キャピタル")]
			Capital = 3,
			//船車券
			[Value("船車券")]
			VesselTickets = 4,
			//宿泊
			[Value("宿泊")]
			Accommodation = 5,
			//観光券
			[Value("観光券")]
			TouristTicket = 6,
			//旅行参加券
			[Value("旅行参加券")]
			TravelParticipationTicket = 7,
			//その他商品
			[Value("その他商品")]
			OtherProducts = 8
		}
		/// <summary>
		/// 選択
		/// </summary>
		public enum UriageMeisaiHyoShutsuryokuSuru : int
		{
			//氏名
			[Value("USER_NAME")]
			USER_NAME = 1,
			//コース種別
			[Value("HOUJIN_GAIKYAKU_KBN")]
			HOUJIN_GAIKYAKU_KBN = 2,
			//ユーザID
			[Value("USER_ID")]
			USER_ID = 3,
			//営業所
			[Value("EIGYOSYO_CD")]
			EIGYOSYO_CD = 4,
			//登録日
			[Value("ENTRY_DAY")]
			ENTRY_DAY = 5,
			//サインオン時刻
			[Value("SIGNON_TIME")]
			SIGNON_TIME = 7
		}
		/// <summary>
		/// 買掛金明細表_区分１
		/// </summary>
		public enum KaikakeKinMeisaiHyo_Kbn1 : int
		{
			//昼
			[Value("DAY_TIME")]
			DAY_TIME = 1,
			//夜
			[Value("NIGHT")]
			NIGHT = 2,
			//日本語
			[Value("JAPANESE")]
			JAPANESE = 3,
			//外国語
			[Value("FOREIGN_LANGUAGE")]
			FOREIGN_LANGUAGE = 4,
			//企画
			[Value("KIKAKU")]
			KIKAKU = 5
		}
		/// <summary>
		/// 買掛金明細表_種別
		/// </summary>
		public enum KaikakeKinMeisaiHyo_Kind : int
		{
			//定期
			[Value("TEIKI")]
			TEIKI = 0,
			//R
			[Value("R")]
			R = 1,
			//企画
			[Value("KIKAKU")]
			KIKAKU = 2
		}
		/// <summary>
		/// 調整含む
		/// </summary>
		public enum Including_adjustment : int
		{
			//調整除く
			[Value("EXCLUDE_ADJUSTMENT")]
			EXCLUDE_ADJUSTMENT = 0
		}
		/// <summary>
		/// 買掛金明細表_企画
		/// </summary>
		public sealed class Referenc_date //TODO:不要では？　勝野
		{
			//返金日

			//<Value("返金日")>
			//Public Const Unkyu As String = "Y"
			//Public Const REFUND_DATE As DateTime = CommonDateUtil.getSystemTime().AddYears(-1)
			//チェック日
			//<Value("チェック日")>
			//CHECK_DATE = 1
			//'承認日
			//<Value("承認日")>
			//APPROVAL_DATE = 2
			//'出力日
			//<Value("出力日")>
			//OUTPUT_DATE = 3
		}
		/// <summary>
		/// 画面モード
		/// </summary>
		public enum Screen_Mode : int
		{

			//新規登録
			[Value("SIGN_UP")]
			SIGN_UP = 1,
			//更新
			[Value("UPDATE")]
			UPDATE = 2,
			//参照
			[Value("REFERENCE")]
			REFERENCE = 3
		}
		/// <summary>
		/// 割引区分
		/// </summary>
		public enum WaribikiKubun : int
		{
			//％ ： 割引率
			[Value("％：割引率")]
			WaribikiRitsu = 1,
			//￥ ： 割引額
			[Value("￥：割引額")]
			WaribikiGaku = 2
		}
		/// <summary>
		/// ピックアップ利用可能時間（到着時間前n分）
		/// </summary>
		public enum PickupCheckTime : int
		{
			BeforeDepartureTime = -5
		}
		#endregion

		#region  エンティティ関連
		/// <summary>
		/// エンティティ項目型タイプ
		/// </summary>
		/// <remarks></remarks>
		public enum deepCopyType : int
		{
			value, //値
			zenkaiValue, //前回値
			BackupValue
		}
		/// <summary>
		/// クリアタイプ
		/// </summary>
		/// <remarks></remarks>
		public enum clearType : int
		{
			value, //値
			zenkaiValue, //前回値
			errorInfo, //エラー情報
			required //必須
		}
		#endregion

		#region  コースマスタキー項目
		/// <summary>
		/// コースマスターキー項目型
		/// </summary>
		/// <remarks></remarks>
		public struct CrsMasterKeyKoumoku //コースマスタキー項目
		{
			private string _teiki_KikakuKbn; //_定期_企画区分
			private string _crsCd; //_コースコード
			private string _kaiteiDay; //_改定日
			private string _year; //_年
			private string _season; //_季
			private int _invalidFlg; //_無効フラグ
			private string _crsName; //_コース名
			private string _season_DisplayFor; //_季_表示用
			private string _pamphIraiDayDisplayFor; //_パンフ依頼日_表示用
			private string _crsStatus; //_コースステータス
			private string _entryDay; //_登録日
			private string _deleteDay; //_削除日
			private string _crsKind1; //_コース種別1
			private string _crsKind2; //_コース種別2
			private string _bulkOpenDay; //_一括公開日
			private string _yoyakuRendoDay; //_予約連動日
			private string _rendoMon; //_連動月
			private string _WEBRendoDay; //_WEB連動日
			private string _rosenzuFile; //_路線図ファイル名
			private string _applicationStartDay; //_適用開始日
												 //造成追加対応
			private string _crsKbn1; //_コース区分1
			private string _crsKbn2; //_コース区分2
			private string _crsKbn3; //_コース区分3

			/// <summary>
			/// 定期＿企画区分
			/// </summary>
			/// <value>1:定期／2:企画</value>
			/// <returns></returns>
			/// <remarks></remarks>
			public string Teiki_KikakuKbn //定期_企画区分
			{
				get
				{
					return _teiki_KikakuKbn;
				}
				set
				{
					_teiki_KikakuKbn = value;
				}
			}
			/// <summary>
			/// コースコード
			/// </summary>
			/// <value></value>
			/// <returns></returns>
			/// <remarks></remarks>
			public string CrsCd //コースコード
			{
				get
				{
					return _crsCd;
				}
				set
				{
					_crsCd = value;
				}
			}
			/// <summary>
			/// 改定日
			/// </summary>
			/// <value>yyyymmdd</value>
			/// <returns></returns>
			/// <remarks></remarks>
			public string KaiteiDay //改定日
			{
				get
				{
					return _kaiteiDay;
				}
				set
				{
					_kaiteiDay = value;
				}
			}
			/// <summary>
			/// 年
			/// </summary>
			/// <value>yyyy</value>
			/// <returns></returns>
			/// <remarks></remarks>
			public string Year //年
			{
				get
				{
					return _year;
				}
				set
				{
					_year = value;
				}
			}
			/// <summary>
			/// 季
			/// </summary>
			/// <value>コードマスタ（コード分類＝季）．コード値</value>
			/// <returns></returns>
			/// <remarks></remarks>
			public string Season //季
			{
				get
				{
					return _season;
				}
				set
				{
					_season = value;
				}
			}

			/// <summary>
			/// 無効フラグ
			/// </summary>
			/// <value></value>
			/// <returns></returns>
			/// <remarks></remarks>
			public int InvalidFlg //無効フラグ
			{
				get
				{
					return _invalidFlg;
				}
				set
				{
					_invalidFlg = value;
				}
			}
			/// <summary>
			/// コース名（Key項目ではないが、コースコピーで使用するため）
			/// </summary>
			/// <value></value>
			/// <returns></returns>
			/// <remarks></remarks>
			public string CrsName //コース名
			{
				get
				{
					return _crsName;
				}
				set
				{
					_crsName = value;
				}
			}
			/// <summary>
			/// 季_表示用（Key項目ではないが、コースコピーで使用するため）
			/// </summary>
			/// <value></value>
			/// <returns></returns>
			/// <remarks></remarks>
			public string Season_DisplayFor //季_表示用
			{
				get
				{
					return _season_DisplayFor;
				}
				set
				{
					_season_DisplayFor = value;
				}
			}
			/// <summary>
			/// パンフ依頼日_表示用（Key項目ではないが、パンフ依頼で使用するため）
			/// </summary>
			/// <value></value>
			/// <returns></returns>
			/// <remarks></remarks>
			public string PamphIraiDay_DisplayFor //パンフ依頼日_表示用
			{
				get
				{
					return _pamphIraiDayDisplayFor;
				}
				set
				{
					_pamphIraiDayDisplayFor = value;
				}
			}
			/// <summary>
			/// コースステータス
			/// </summary>
			/// <value></value>
			/// <returns></returns>
			/// <remarks></remarks>
			public string CrsStatus //コースステータス
			{
				get
				{
					return _crsStatus;
				}
				set
				{
					_crsStatus = value;
				}
			}
			/// <summary>
			/// 登録日
			/// </summary>
			/// <value></value>
			/// <returns></returns>
			/// <remarks></remarks>
			public string EntryDay //登録日
			{
				get
				{
					return _entryDay;
				}
				set
				{
					_entryDay = value;
				}
			}
			/// <summary>
			/// 削除日
			/// </summary>
			/// <value></value>
			/// <returns></returns>
			/// <remarks></remarks>
			public string DeleteDay //削除日
			{
				get
				{
					return _deleteDay;
				}
				set
				{
					_deleteDay = value;
				}
			}
			/// <summary>
			/// コース種別１
			/// </summary>
			/// <value></value>
			/// <returns></returns>
			/// <remarks></remarks>
			public string CrsKind1 //コース種別１
			{
				get
				{
					return _crsKind1;
				}
				set
				{
					_crsKind1 = value;
				}
			}
			/// <summary>
			/// コース種別２
			/// </summary>
			/// <value></value>
			/// <returns></returns>
			/// <remarks></remarks>
			public string CrsKind2 //コース種別２
			{
				get
				{
					return _crsKind2;
				}
				set
				{
					_crsKind2 = value;
				}
			}
			/// <summary>
			/// 一括公開日
			/// </summary>
			/// <value></value>
			/// <returns></returns>
			/// <remarks></remarks>
			public string YoyakuRendoDay //予約連動日
			{
				get
				{
					return _yoyakuRendoDay;
				}
				set
				{
					_yoyakuRendoDay = value;
				}
			}
			/// <summary>
			/// 連動月
			/// </summary>
			/// <value></value>
			/// <returns></returns>
			/// <remarks></remarks>
			public string RendoMon //連動月
			{
				get
				{
					return _rendoMon;
				}
				set
				{
					_rendoMon = value;
				}
			}
			/// <summary>
			/// 一括公開日
			/// </summary>
			/// <value></value>
			/// <returns></returns>
			/// <remarks></remarks>
			public string WebRendoDay //WEB連動日
			{
				get
				{
					return _WEBRendoDay;
				}
				set
				{
					_WEBRendoDay = value;
				}
			}
			/// <summary>
			/// 一括公開日
			/// </summary>
			/// <value></value>
			/// <returns></returns>
			/// <remarks></remarks>
			public string BulkOpenDay //一括公開日
			{
				get
				{
					return _bulkOpenDay;
				}
				set
				{
					_bulkOpenDay = value;
				}
			}

			/// <summary>
			/// 路線図ファイル名
			/// </summary>
			/// <value></value>
			/// <returns></returns>
			/// <remarks></remarks>
			public string RosenzuFile //路線図ファイル名
			{
				get
				{
					return _rosenzuFile;
				}
				set
				{
					_rosenzuFile = value;
				}
			}

			/// <summary>
			/// 適用開始日
			/// </summary>
			/// <value></value>
			/// <returns></returns>
			/// <remarks></remarks>
			public string ApplicationStartDay //適用開始日
			{
				get
				{
					return _applicationStartDay;
				}
				set
				{
					_applicationStartDay = value;
				}
			}

			//造成追加対応
			/// <summary>
			/// コース区分1
			/// </summary>
			/// <value></value>
			/// <returns></returns>
			/// <remarks></remarks>
			public string CrsKbn1 //コース区分1
			{
				get
				{
					return _crsKbn1;
				}
				set
				{
					_crsKbn1 = value;
				}
			}
			/// <summary>
			/// コース区分2
			/// </summary>
			/// <value></value>
			/// <returns></returns>
			/// <remarks></remarks>
			public string CrsKbn2 //コース区分2
			{
				get
				{
					return _crsKbn2;
				}
				set
				{
					_crsKbn2 = value;
				}
			}
			/// <summary>
			/// コース区分3
			/// </summary>
			/// <value></value>
			/// <returns></returns>
			/// <remarks></remarks>
			public string CrsKbn3 //コース区分3
			{
				get
				{
					return _crsKbn3;
				}
				set
				{
					_crsKbn3 = value;
				}
			}

		}

		/// <summary>
		/// 座席種別
		/// </summary>
		public sealed class ZasekiKind
		{
			[Value("通常席")]
			public const string normalSeat = "1";
			[Value("補助席")]
			public const string hojoSeat = "2";
			[Value("ダミー席")]
			public const string dummySeat = "3";
			[Value("使用不可")]
			public const string notUseSeat = "X";
		}
		#endregion

		#region  行程情報キー項目
		/// <summary>
		/// 行程情報キー項目
		/// </summary>
		/// <remarks></remarks>
		public struct ItineraryInfoKeyKoumoku //行程情報キー項目
		{
			private CrsMasterKeyKoumoku _crsMasterKeyKoumoku;
			private ItineraryKindType _itineraryKind;
			private int _lineNo;
			/// <summary>
			/// コースマスタキー項目
			/// </summary>
			/// <value></value>
			/// <returns></returns>
			/// <remarks></remarks>
			public CrsMasterKeyKoumoku CrsMasterKeyKoumoku //コースマスタキー項目
			{
				get
				{
					return _crsMasterKeyKoumoku;
				}
				set
				{
					_crsMasterKeyKoumoku = value;
				}
			}
			/// <summary>
			/// 行程種別
			/// </summary>
			/// <value></value>
			/// <returns></returns>
			/// <remarks></remarks>
			public ItineraryKindType ItineraryKind //行程種別
			{
				get
				{
					return _itineraryKind;
				}
				set
				{
					_itineraryKind = value;
				}
			}
			/// <summary>
			/// 行No
			/// </summary>
			/// <value></value>
			/// <returns></returns>
			/// <remarks></remarks>
			public int LineNo //行No
			{
				get
				{
					return _lineNo;
				}
				set
				{
					_lineNo = value;
				}
			}
		}
		#endregion

		#region  共通
		/// <summary>
		/// コース種別1値の内容
		/// </summary>
		/// <remarks></remarks>
		public enum CrsKind1Type : int
		{
			[Value("定期観光")]
			teikiKanko = 1,
			//DEL teikiRCrs = 2 '定期Ｒコース
			//DEL gaikyakuTeiki = 3  '外客定期
			//DEL gaikyakuRCrs = 4  '外客Ｒコース
			[Value("キャピタル")]
			capital = 5,
			//DEL shirain = 6  'シーライン
			[Value("企画旅行")]
			kikakuTravel = 7
		}
		/// <summary>
		/// コース種別2値の内容
		/// </summary>
		/// <remarks></remarks>
		public enum CrsKind2Type : int
		{
			[Value("日帰り")]
			higaeri = 1,
			[Value("宿泊")]
			stay,
			[Value("Ｒコース")]
			rCrs
		}

		/// <summary>
		/// 表示最大件数
		/// </summary>
		public const int MaxDispCount = 100;
		#endregion

		#region  降車ヶ所
		/// <summary>
		/// 行程種別タイプ
		/// </summary>
		/// <remarks></remarks>
		public enum ItineraryKindType : int //行程種別タイプ
		{
			@option = 0, //オプション
			itinerary = 1, //行程
			sonota = 2 //その他
		}
		/// <summary>
		/// 文字色タイプ(定期)
		/// </summary>
		/// <remarks></remarks>
		public enum MojiColorType_Teiki : int //文字色タイプ_定期
		{
			[Value("通常_黒")]
			normal_Black = 0, //通常_黒
			[Value("強調_赤")]
			emphasis_Red = 1, //強調_赤
			[Value("下線_赤強調")]
			_underline_RedEmphasis = 2 //下線_赤強調
		}
		/// <summary>
		/// 文字色タイプ(企画)
		/// </summary>
		/// <remarks></remarks>
		public enum MojiColorType_Kikaku : int //文字色タイプ_企画
		{
			[Value("黒")]
			black = 0, //黒
			[Value("赤")]
			red = 1, //赤
			[Value("青")]
			blue = 2, //青
			[Value("緑")]
			green = 3, //緑
			[Value("下線_赤強調")]
			underline_red = 4 //下線_赤強調
		}
		/// <summary>
		/// 回答結果値の内容
		/// </summary>
		/// <remarks></remarks>
		public enum KaitoResultType : int //回答結果タイプ
		{
			allOk = 0, //全て可
			partNg = 1, //一部不可
			ng = 2 //不可
		}
		#endregion

		#region  料金関連
		/// <summary>
		/// 単価区分値の内容
		/// </summary>
		/// <remarks></remarks>
		public enum TankaKbnType : int //単価区分タイプ
		{
			ninzuTanka = 1, //人数単価
			roomTanka = 2 //ルーム単価
		}
		/// <summary>
		/// 支払区分値の内容
		/// </summary>
		/// <remarks></remarks>
		public enum SiharaiKbnType : int //支払区分タイプ
		{
			maebarai = 1, //前払
			tojitubarai = 2, //当日払
			gentibarai = 3 //現地払
		}
		/// <summary>
		/// 料金区分値の内容
		/// </summary>
		/// <remarks></remarks>
		public enum ChargeKbnType : int //料金区分タイプ
		{
			adult, //大人
			junior, //中人
			child, //小人
			toddler //幼児
		}

		/// <summary>
		/// 集約料金区分
		/// </summary>
		/// <remarks></remarks>
		public sealed class ShuyakuChargeKbnType //集約料金区分タイプ
		{
			[Value("大人")]
			public const string adult = "10";
			[Value("中人")]
			public const string junior = "20";
			[Value("小人")]
			public const string child = "30";
		}

		/// <summary>
		/// 料金区分（人員）コード
		/// </summary>
		/// <remarks></remarks>
		public sealed class ChargeKbnJininCd //料金区分（人員）コード値
		{
			[Value("大人(男)")]
			public const string adultMan = "01";
			[Value("大人(女)")]
			public const string adultWoman = "02";
			[Value("中人(男)")]
			public const string juniorMan = "03";
			[Value("小人(男)")]
			public const string childMan = "04";
			[Value("幼児")]
			public const string toddler = "05";
			[Value("シルバー")]
			public const string elder = "06";
			[Value("中人(女)")]
			public const string juniorWoman = "07";
			[Value("小人(女)")]
			public const string childWoman = "08";
			[Value("大人")]
			public const string adult = "10";
			[Value("中人")]
			public const string junior = "20";
			[Value("小人")]
			public const string child = "30";
		}
		#endregion

		#region  背景色

		/// <summary>
		/// 背景色
		/// </summary>
		/// <remarks></remarks>
		public sealed class BackgroundColorType //背景色タイプ
		{
			public BackgroundColorType()
			{
				// VBConversions Note: Non-static class variable initialization is below.  Class variables cannot be initially assigned non-static values in C#.
				_backgroundColor_Normal = Color.Honeydew;
				_backgroundColor_Test = Color.Pink;

			}
			private static System.Drawing.Color _backgroundColor_Normal; // VBConversions Note: Initial value cannot be assigned here since it is non-static.  Assignment has been moved to the class constructors. //_背景色_通常
			private static System.Drawing.Color _backgroundColor_Test; // VBConversions Note: Initial value cannot be assigned here since it is non-static.  Assignment has been moved to the class constructors. //_背景色_テスト
			public static System.Drawing.Color Form //フォーム
			{
				get
				{
					return _backgroundColor_Normal;
				}
				set
				{
					_backgroundColor_Normal = value;
				}
			}
			public static System.Drawing.Color TestForm //テストフォーム
			{
				get
				{
					return _backgroundColor_Test;
				}
				set
				{
					_backgroundColor_Test = value;
				}
			}

			/// <summary>
			/// コントロール背景色[通常項目]
			/// </summary>
			/// <returns></returns>
			/// <remarks></remarks>
			public static System.Drawing.Color Standard() //通常
			{
				return SystemColors.Window;
			}

			/// <summary>
			/// コントロール背景色[入力必須項目]
			/// </summary>
			/// <returns></returns>
			/// <remarks></remarks>
			public static System.Drawing.Color InputMust() //入力必須
			{
				return Color.LightBlue;
			}

			/// <summary>
			/// コントロール背景色[エラー項目]
			/// </summary>
			/// <returns></returns>
			/// <remarks></remarks>
			public static System.Drawing.Color InputError() //エラー
			{
				return Color.Red;
			}

			/// <summary>
			/// コントロール背景色[3D項目]
			/// </summary>
			/// <returns></returns>
			/// <remarks></remarks>
			public static System.Drawing.Color Transparent() //透明
			{
				return Color.Transparent;
			}

			/// <summary>
			/// コントロール背景色[グリッド固定行選択時色]
			/// </summary>
			/// <returns></returns>
			/// <remarks></remarks>
			public static System.Drawing.Color SelectionJiFixedLine_BackgroundColor() //選択時固定行_背景色
			{
				return Color.FromArgb(Convert.ToInt32("ffffd033", 16));
			}

			/// <summary>
			/// コントロール背景色[グリッドRow選択時色](※仮)
			/// </summary>
			/// <returns></returns>
			/// <remarks></remarks>
			public static System.Drawing.Color SelectionLine_BackgroundColor() //選択行_背景色
			{
				return Color.FromArgb(Convert.ToInt32("ff8080ff", 16));
			}

			/// <summary>
			/// コントロール背景色[情報無_背景色]
			/// </summary>
			/// <returns></returns>
			/// <remarks></remarks>
			public static System.Drawing.Color InfoNasi_BackgroundColor() //情報無_背景色
			{
				return Color.Pink;
			}
		}


		#endregion

		#region  コード分類
		/// <summary>
		/// コード分類タイプ
		/// </summary>
		/// <remarks></remarks>
		public enum CdBunruiType : int //コード分類タイプ
		{
			managerSet, //管理者設定
			systemSet, //システム設定
			initialPlate, //初期プレート
			initialSuppliers_Shirain, //初期仕入先_シーライン
			initialSuppliers_TeikiKanko, //初期仕入先_定期観光
			initialSuppliers_TeikiR, //初期仕入先_定期R
			initialSuppliers_GaikyakuTeiki, //初期仕入先_外客定期
			initialSuppliers_GaikyakuR, //初期仕入先_外客R
			initialSuppliers_Kikaku, //初期仕入先_企画
			siireRelation_Teiki, //仕入関連_定期
			siireRelation_Kikaku_Higaeri, //仕入関連_企画_日帰り
			siireRelation_Gaikyaku, //仕入関連_外客
			siireRelation_Kikaku_Stay, //仕入関連_企画_宿泊
			chargeRank_Teiki_Higaeri, //料金ランク_定期_日帰り
			chargeRank_Kikaku_Higaeri, //料金ランク_企画_日帰り
			chargeRank_Teiki_Stay, //料金ランク_定期_宿泊
			chargeRank_Kikaku_Stay, //料金ランク_企画_宿泊
			chargeConstitutionTable, //料金構成表
			costTable_Higaeri, //原価表_日帰り
			costTable_Stay, //原価表_宿泊
			costTable_Higaeri_Kikaku, //原価表_日帰り_企画
			busyoMaster, //部署マスタ
			gengouMaster, //元号マスタ
			WEBMarkMaster, //WEB記号マスタ
			staySisetuSetubi, //宿泊施設設備
			seasonMaster_Kikaku, //季マスタ_企画
			seasonMaster_Teiki, //季マスタ_定期
			categoryMaster, //カテゴリマスタ
			homenMaster, //方面マスタ
			messageMaster, //メッセージマスタ
			crsInfoMaster, //コース情報マスタ
			accessCdMaster, //アクセスコードマスタ
			suppliersKindMaster, //仕入先種別マスタ
			seisanMokutekiMaster, //精算目的マスタ
			mediaMaster, //媒体マスタ
			WEB_KikakuAreaMaster, //WEB_企画エリアマスタ
			WEB_KikakuMokutekiMaster, //WEB_企画目的マスタ
			WEB_TeikiMokutekiMaster, //WEB_定期目的マスタ
			WEB_PlaceMaster, //WEB_場所マスタ
			syasoMaster, //車窓マスタ
			pamphFlg_Kikaku, //パンフフラグ_企画
			pamphFlg_Teiki, //パンフフラグ_定期
			saikouKakuteiKbn, //催行確定区分
			hissuKubun, //必須区分
			tankaKubun, //単価区分
			zeiKubun, //税区分
			seisanHoho, //精算方法
			siharaiHoho, //支払方法
			memokbn, //メモ区分
			memobunrui, //メモ分類
			cancelkbn, //キャンセル区分
			seisanhohojyosya, //精算方法（乗車）
			toriatsukai_busho, //取扱部署
			agentInvoice, //AGENT請求書
			unkyu, //運休区分
			yobi, //曜日コード
			crskbn1, //コース区分1
			crskbn2, //コース区分2
			discount_Type, //割引区分
			crskind, //コース種別
			language, //言語
			shareStaffItem, //スタッフ共有事項
			hojinGaikyakuKubun, //邦人／外客区分
			busType, //バスタイプ
			sexbetu, //性別
			sectionLv, //所属階層レベル
			autLvl, //権限レベル
			hanbaiKasho, //販売課所
			yoyakuBaitai, //予約媒体
			seisanKanren, //精算関連コード
			staffShareTaisyo, //スタッフ共有対象
			mokuteki, //目的（コード分類：213）
			packageCls, //団体種別 (コード分類=214)
			packageDiv, //団体区分 (コード分類=215)
			customerDiv, //顧客区分 (コード分類=216)
			kokuseki, //国籍
			tejimaiTable_Teiki_SofuMotoInfo, //手仕舞い表_定期_送付元情報(コード分類=250)
			tejimaiTable_KikakuHigaeri_SofuMotoInfo, //手仕舞い表_企画日帰り_送付元情報(コード分類=251)
			tejimaiTable_KikakuStay_SofuMotoInfo, //手仕舞い表_企画宿泊_送付元情報(コード分類=252)
			travelItineraryTable_SofuMotoInfo_Teiki, // [団体]御旅行行程表_送付元情報_定期(コード分類=221)
			travelItineraryTable_SofuMotoInfo_Kikaku, // [団体]御旅行行程表_送付元情報_企画(コード分類=222)
			travelItineraryTable_SofuMotoInfo_Dantai // [団体]御旅行行程表_送付元情報_団体(コード分類=223)
		}
		#endregion

		#region  管理者設定
		/// <summary>
		/// システム設定タイプ
		/// </summary>
		/// <remarks></remarks>
		public enum ManagerSetType : int //管理者設定タイプ
		{
			infoRegistExecUmu, //情報連携実行有無
			infoRegistResultDetectionInterval, //情報連携結果検出間隔
			infoRegistResultDetectionCount //情報連携結果検出回数
		}
		#endregion
		#region  その他
		/// <summary>
		/// 処理モード
		/// 基本情報画面の処理モードを列挙
		/// </summary>
		/// <remarks></remarks>
		public enum ProcessMode : int //処理モード
		{
			shinki, //新規
			update, //更新
			reference, //参照
			copy //コピー
		}
		#region (ph2) DEL
		///' <summary>
		///' 連動フラグタイプ
		///' </summary>
		///' <remarks></remarks>
		//Public Enum RendoFlgType As Integer  '連動フラグタイプ
		//    rendoKanou  '連動可能
		//    rendoChu  '連動中
		//End Enum
		#endregion
		/// <summary>
		/// コンボボックスデータ取得用タイプ
		/// </summary>
		/// <remarks></remarks>
		public enum ComboBoxCdType : int //コンボボックスコードタイプ
		{
			CODE_VALUE,
			CODE_NAME,
			NAIYO_1,
			NAIYO_2,
			NAIYO_3
		}

		/// <summary>
		/// 御旅行行程表形式タイプ
		/// </summary>
		/// <remarks></remarks>
		public enum OutputPrintProcessType : int //出力帳票処理タイプ
		{
			[Value("プレビュー")]
			Preview,
			[Value("印刷")]
			Report
		}

		/// <summary>
		/// 御旅行行程表形式タイプ
		/// </summary>
		/// <remarks></remarks>
		public enum ItineraryTableKeisikiType : int //行程表形式タイプ
		{
			[Value("日帰り")]
			higaeri,
			[Value("宿泊")]
			stay
		}

		/// <summary>
		/// 料金情報タイプ
		/// </summary>
		/// <remarks></remarks>
		public enum ChargeInfoType : int //料金情報タイプ
		{
			[Value("受付")]
			uketuke = 1,
			[Value("確定")]
			kakutei
		}
		#endregion

		#region  動作モード
		/// <summary>
		/// テストフラグタイプ
		/// </summary>
		/// <remarks></remarks>
		public enum TestFlgType : int //テストフラグタイプ
		{
			normalUser = 0, //通常ユーザー
			testUser = 1 //テストユーザー
		}
		#endregion

		#region  ロック関連

		#region  ENUM
		/// <summary>
		/// ロック状態
		/// </summary>
		/// <remarks></remarks>
		public enum LockState : int //ロック状態
		{
			lockSuccess, //ロック成功
			lockChu, //ロック中
			lockFailure //ロック失敗
		}
		#endregion

		#region  STRUCTURE
		/// <summary>
		/// ユーザー情報管理項目を明示的にしときます。
		/// </summary>
		/// <remarks></remarks>
		public struct UserInfoManagementKoumoku //ユーザー情報管理項目
		{
			private string _userId; //_ユーザーID
			private string _client; //_クライアント名
			private int _processId; //_プロセスID
			/// <summary>
			/// ユーザーID
			/// </summary>
			/// <value></value>
			/// <returns></returns>
			/// <remarks></remarks>
			public string UserId //ユーザーID
			{
				get
				{
					return _userId;
				}
				set
				{
					_userId = value;
				}
			}
			/// <summary>
			/// クライアント名
			/// </summary>
			/// <value></value>
			/// <returns></returns>
			/// <remarks></remarks>
			public string Client //クライアント名
			{
				get
				{
					return _client;
				}
				set
				{
					_client = value;
				}
			}
			/// <summary>
			/// プロセスID
			/// </summary>
			/// <value></value>
			/// <returns></returns>
			/// <remarks></remarks>
			public int ProcessId //プロセスID
			{
				get
				{
					return _processId;
				}
				set
				{
					_processId = value;
				}
			}
		}
		#endregion

		#endregion

		#region  情報連携関連

		#region  定数
		public const string TRG_NAME = "_TRG";
		public enum RendoType : int //連動タイプ
		{
			ASRendo = 0, //AS連動
			WEBRendo = 1 //WEB連動
		}
		#endregion

		#region  情報連携_結果
		public const string InfoRegist_Result_MiProcess = "00"; //情報連携_結果_未処理
		public const string InfoRegist_Result_NormalEnd = "01"; //情報連携_結果_正常終了
		public const string InfoRegist_Result_ProcessChu = "02"; //情報連携_結果_処理中
		public const string InfoRegist_Result_WarningEnd = "03"; //情報連携_結果_警告終了
		public const string InfoRegist_Result_FaultEnd = "11"; //情報連携_結果_異常終了
		#endregion

		#region  情報連携_戻り値
		public enum InfoRegist_ReturnValue : int //情報連携_戻り値
		{
			[Value("想定外エラー")]
			unexpectedError = -1,
			[Value("正常終了")]
			normalEnd = 1,
			[Value("ステータス作成エラー")]
			statusCreateError = 10,
			[Value("異常終了")]
			faultEnd = 11,
			[Value("警告終了")]
			warningEnd = 12,
			[Value("タイムアウト")]
			timeout = 13
		}
		#endregion

		#region  情報連携_初期値
		public bool infoRegistExecUmu = false; //情報連携実行有無
		public int infoRegistResultDetectionInterval = 100; //単位:msec  情報連携結果検出間隔
		public int infoRegistResultDetectionCount = 100; //情報連携結果検出回数
		#endregion

		#endregion

		#region  造成追加分
		/// <summary>
		/// システム設定タイプ
		/// </summary>
		/// <remarks></remarks>
		public enum SystemSetType : int //システム設定タイプ
		{
			AGCShareFolderName_Teiki, //AGC共有フォルダ名_定期
			AGCShareFolderName_KikaKu, //AGC共有フォルダ名_企画
			syohiTaxPer, //消費税率
			physicsDeleteKanouPassageYearNum, //物理削除可能経過年数
			crsTitleWebSize, //コースタイトルWEBサイズ
			syugoTime, //集合時間
			leastSaikouNinzu_Kikaku_TeikiGaikyakuRCrs, //最少催行人数_企画_定期外客Rコース
			leastSaikouNinzu_Teiki_Gaikyaku, //最少催行人数_定期_外客
			rosenzuImageFolderName, //路線図画像フォルダ名
			infoRegistFolderName, //情報連携フォルダ名
			PDFOutputFolderName, // PDF出力先フォルダ名 (コード=111)
			ExcelOutputFolderName, // Excel出力先フォルダ名 (コード=112)
			ExcelTemplateFolderName, // Excelテンプレートフォルダ名 (コード=113)
			syugoTime202 = 202, // 集合時間(企画旅行部,団体営業部)以外 (コード=202)
			syugoTime203 = 203, // 集合時間(企画旅行部)1223000 (コード=203)
			syugoTime204 = 204 // 集合時間(団体営業部)1225000 (コード=204)
		}

		/// <summary>
		/// 一時テーブル設定用
		/// </summary>
		/// <remarks></remarks>
		public sealed class ItiziTable //一時テーブル
		{
			public const string ItiziTableArticle = "TMP_"; //一時テーブル冠詞
		}

		/// <summary>
		/// コース状態
		/// </summary>
		/// <remarks></remarks>
		public enum CrsState : int //コース状態
		{
			lockSuccess, //ロック成功
			lockChu, //ロック中
			lockFailure //ロック失敗
		}

		#region  所属部署関連
		public const string SynthesisKikakuCyoseiBu = "01"; //総合企画調整部
		public const string TeikiKankoBu = "02"; //定期観光部
		public const string KikakuTravelBu = "03"; //企画旅行部


		public const string UketukeBusyoCd_TeikiKankoBu = "1222000"; //受付部署コード_定期観光部
		public const string UketukeBusyoCd_KikakuTravelBu = "1223000"; //受付部署コード_企画旅行部
		public const string UketukeBusyoCd_DantaiSalesBu = "1225000"; //受付部署コード_団体営業部

		#endregion

		#region  選択画面関連
		public const string SuppliersKind_Stay = "30"; //仕入先種別_宿泊
		public const string SuppliersKind_Hotel_Coupon = "35"; //仕入先種別_ホテル_クーポン
		public const string SuppliersKind_Koshakasho = "40"; //仕入先種別_降車ヶ所
		public const string SuppliersKind_StayPlan = "45"; //仕入先種別_宿泊プラン
		public const string SuppliersKind_Kosoku_TollRoad = "50"; //仕入先種別_高速_有料道路
		public const string SuppliersKind_Carrier = "80"; //仕入先種別_キャリア
		public const string SuppliersKind_SonotaExpense = "90"; //仕入先種別_その他経費
		public const string SuppliersKind_SonotaKakuteiExpense = "99"; //仕入先種別_その他確定経費
		#endregion

		/// <summary>
		/// ADD-20120821-練習環境時のフォームタイトル文字
		/// </summary>
		/// <remarks></remarks>
		public const string PracticeEnvironmentTitle = "【練習】"; //練習環境タイトル
		/// <summary>
		/// ADD-20120821-練習環境時のフォームタイトル文字
		/// </summary>
		/// <remarks></remarks>
		public const string FormTitle = "造成システム"; //フォームタイトル

		#region  原価表関連

		// 原価表（宿泊）
		public const string CdValue_CostTable_Stay_BusdaiCoefficient = "01"; //コード値_原価表_宿泊_バス代係数
		public const string CdValue_CostTable_Stay_SisanNinzu = "02"; //コード値_原価表_宿泊_試算人数
		public const string CdValue_CostTable_Stay_Badge = "03"; //コード値_原価表_宿泊_バッジ
		public const string CdValue_CostTable_Stay_CyozouSonota = "04"; //コード値_原価表_宿泊_貯蔵品その他
		public const string CdValue_CostTable_Stay_Insurance = "05"; //コード値_原価表_宿泊_保険
		public const string CdValue_CostTable_Stay_Tenjyoin = "06"; //コード値_原価表_宿泊_添乗員
		public const string CdValue_CostTable_Stay_Busdai = "07"; //コード値_原価表_宿泊_バス代
		public const string CdValue_CostTable_Stay_TollDorodai = "08"; //コード値_原価表_宿泊_有料道路代
		public const string CdValue_CostTable_Stay_JomuinShukuhakudai = "09"; //コード値_原価表_宿泊_乗務員宿泊代

		// 原価表（日帰り）共通
		public const string CostTable_Higaeri_BusdaiCoefficient = "01"; //原価表_日帰り_バス代係数
		public const string CostTable_Higaeri_SisanNinzu = "02"; //原価表_日帰り_試算人数
		public const string CostTable_Higaeri_AdultSubSeatWaribikiKingaku = "03"; //原価表_日帰り_大人補助席割引金額
		public const string CostTable_Higaeri_JuniorSubSeatWaribikiKingaku = "04"; //原価表_日帰り_中人補助席割引金額
		public const string CostTable_Higaeri_ChildSubSeatWaribikiKingaku = "05"; //原価表_日帰り_小人補助席割引金額
		public const string CostTable_Higaeri_ToddlerSubSeatWaribikiKingaku = "06"; //原価表_日帰り_幼児補助席割引金額
		public const string CostTable_Higaeri_Badge = "07"; //原価表_日帰り_バッジ
		public const string CostTable_Higaeri_CyozouSonota = "08"; //原価表_日帰り_貯蔵品その他
		public const string CostTable_Higaeri_Insurance = "09"; //原価表_日帰り_保険
		public const string CostTable_Higaeri_Tenjyoin = "10"; //原価表_日帰り_添乗員
		public const string CostTable_Higaeri_Busdai = "11"; //原価表_日帰り_バス代
		public const string CostTable_Higaeri_TollDourodai = "12"; //原価表_日帰り_有料道路代

		//料金構成表
		public const string ChargeConstitutionTable_TollRoad = "07"; //料金構成表_有料道路
		public const string ChargeConstitutionTable_JomuinMeal = "08"; //料金構成表_乗務員食事
		public const string ChargeConstitutionTable_Insurance = "09"; //料金構成表_保険

		/// <summary>
		/// コードマスタ　仕入先種別タイプ内容値
		/// </summary>
		/// <remarks></remarks>
		public enum CdMaster_SuppliersKindType : int //コードマスタ_仕入先種別タイプ
		{
			all = 0, //全て
			itinerary, //行程
			sonotaItinerary, //その他行程
			hihyoji //非表示
		}

		#endregion
		#endregion

		#region  チェックボックスON/OFF値
		/// <summary>
		/// チェックボックスON/OFF値
		/// </summary>
		/// <remarks></remarks>
		public enum CheckBoxValue : int //チェックボックス値
		{
			OffValue = 0, //OFF
			OnValue = 1 //ON
		}
		#endregion

		#region  代理店関連
		/// <summary>
		/// [本店]の支店コード固定値
		/// </summary>
		public const string HontenBranchCd = "0000";

		//全削除指定用レコード
		public const string DelRecord = "99999999";

		#endregion


		#region  手配追加分
		/// <summary>
		/// 曜日コード値
		/// </summary>
		/// <remarks></remarks>
		public enum YobiCd : int //曜日コード値
		{
			[Value("月")]
			Monday = 2, //月
			[Value("火")]
			Tuesday = 3, //火
			[Value("水")]
			Wednesday = 4, //水
			[Value("木")]
			Thursday = 5, //木
			[Value("金")]
			Friday = 6, //金
			[Value("土")]
			Saturday = 7, //土
			[Value("日")]
			Sunday = 1 //日
		}
		/// <summary>
		/// 定期企画区分
		/// </summary>
		/// <remarks></remarks>
		public enum TeikiKikakuKbn : int //定期企画区分
		{
			[Value("定期")]
			Teiki = 1, //定期
			[Value("企画")]
			Kikaku = 2 //企画
		}
		/// <summary>
		/// 表示区分
		/// </summary>
		/// <remarks></remarks>
		public enum HyojiKbn : int //表示区分
		{
			[Value("表示のみ")]
			Hyoji = 1, //表示のみ
			[Value("表示＆印刷")]
			HyoujiPrint = 2 //表示＆印刷
		}
		#endregion

		#region 精算
		/// <summary>
		/// 精算項目コード
		/// </summary>
		public enum SeisanItemCd : int
		{
			/// <summary>
			///キャンセル料
			/// </summary>
			cancel_ryo = 811,
			/// <summary>
			///払戻手数料
			/// </summary>
			haraimodosi_tesuryo = 821,
			/// <summary>
			///現金
			/// </summary>
			genkin = 110,
			/// <summary>
			///現金戻
			/// </summary>
			genkin_modosi = 111,
			/// <summary>
			///振込等営業所
			/// </summary>
			hurikomi_eigyosyo = 120,
			/// <summary>
			///振込等営業所戻
			/// </summary>
			hurikomi_eigyosyo_modosi = 121,
			/// <summary>
			///振込等予約センター
			/// </summary>
			hurikomi_yoyaku_center = 130,
			/// <summary>
			///振込等予約センター戻
			/// </summary>
			hurikomi_yoyaku_center_modosi = 131,
			/// <summary>
			///船車券
			/// </summary>
			sensya_ken = 140,
			/// <summary>
			///船車券戻
			/// </summary>
			sensya_ken_modosi = 141,
			/// <summary>
			///ＢＣ
			/// </summary>
			bc = 150,
			/// <summary>
			///ＢＣ戻
			/// </summary>
			bc_modosi = 151,
			/// <summary>
			///クレジットカード
			/// </summary>
			credit_card = 160,
			/// <summary>
			///クレジットカード払戻
			/// </summary>
			credit_card_modosi = 161,
			/// <summary>
			///オンラインクレジット
			/// </summary>
			online_credit = 170,
			/// <summary>
			///オンラインクレジット戻
			/// </summary>
			online_credit_modosi = 171,
			/// <summary>
			///割引金額
			/// </summary>
			waribiki_kingaku = 830,
			/// <summary>
			///割引金額戻
			/// </summary>
			waribiki_kingaku_modosi = 831,
			/// <summary>
			///その他
			/// </summary>
			sonota = 180,
			/// <summary>
			///その他戻
			/// </summary>
			sonota_modosi = 181,
			/// <summary>
			///オープン券
			/// </summary>
			open_ken = 190,
			/// <summary>
			///取扱手数料
			/// </summary>
			toriatukai_tesuryo = 840,
			/// <summary>
			///取扱手数料戻
			/// </summary>
			toriatukai_tesuryo_modosi = 841,
			/// <summary>
			///仮受金
			/// </summary>
			kariukekin = 201,
			/// <summary>
			///仮受金精算
			/// </summary>
			kariukekin_seisan = 200,
			/// <summary>
			///前受金
			/// </summary>
			maeukekin = 211,
			/// <summary>
			///前受金精算
			/// </summary>
			maeukekin_seisan = 210,
			/// <summary>
			///未収
			/// </summary>
			misyu = 220,
			/// <summary>
			///未収回収
			/// </summary>
			misyu_kaisyu = 221,
			/// <summary>
			///仮払金
			/// </summary>
			karibaraikin = 230,
			/// <summary>
			///仮払金精算
			/// </summary>
			karibaraikin_seisan = 231,
			/// <summary>
			///未収補助券
			/// </summary>
			misyu_hojyo_ken = 240,
			/// <summary>
			///未収（補助券）回収（東京）
			/// </summary>
			misyu_hojyo_ken_kaisyu_ht = 241,
			/// <summary>
			///未収（補助券）回収（ホテル）
			/// </summary>
			misyu_hojyo_ken_kaisyu_hc = 242,
			/// <summary>
			///未収（補助券）回収（浜松町）
			/// </summary>
			misyu_hojyo_ken_kaisyu_hf = 243,
			/// <summary>
			///未収（補助券）回収（新宿）
			/// </summary>
			misyu_hojyo_ken_kaisyu_hj = 244,
			/// <summary>
			///未収（補助券）回収（池袋）
			/// </summary>
			misyu_hojyo_ken_kaisyu_hb = 245,
			/// <summary>
			///未収（補助券）回収（都庁）
			/// </summary>
			misyu_hojyo_ken_kaisyu_ha = 246,
			/// <summary>
			///未収（補助券）回収（営業企）
			/// </summary>
			misyu_hojyo_ken_kaisyu_he = 247,
			/// <summary>
			///未収（補助券）回収（予約Ｃ）
			/// </summary>
			misyu_hojyo_ken_kaisyu_hd = 248
		}

		/// <summary>
		/// 精算項目コード★★削除予定（使用禁止）★★
		/// </summary>
		public enum CreditPayOffKomokuCd : int
		{
			/// <summary>
			/// クーポン払戻し
			/// </summary>
			CouponRefund = 101,
			/// <summary>
			///クーポン売上
			/// </summary>
			CouponSales = 102,
			/// <summary>
			///キャンセル料
			/// </summary>
			CancellationCharge = 103,
			/// <summary>
			///払戻手数料
			/// </summary>
			RefundCharge = 104,
			/// <summary>
			///他売上商品払戻
			/// </summary>
			OtherSalesCommodityWithdrawal = 105,
			/// <summary>
			///他売上商品売上
			/// </summary>
			SalesOfOtherSalesProducts = 106,
			/// <summary>
			///現金
			/// </summary>
			Cash = 107,
			/// <summary>
			///現金払戻
			/// </summary>
			CashWithdrawal = 108,
			/// <summary>
			///振込等営業所
			/// </summary>
			TransferEtcSalesOffice = 109,
			/// <summary>
			///振込等営業所戻
			/// </summary>
			TransferEtcBusinessOfficeReturn = 110,
			/// <summary>
			///振込等予約センター
			/// </summary>
			ReservationReservationCenter = 111,
			/// <summary>
			///振込等予約センター戻
			/// </summary>
			TransferEtcReservationCenterReversion = 112,
			/// <summary>
			///船車券
			/// </summary>
			ShipTicket = 113,
			/// <summary>
			///船車券戻し
			/// </summary>
			VesselTicketReturn = 114,
			/// <summary>
			///ＢＣ
			/// </summary>
			Bc = 115,
			/// <summary>
			///ＢＣ戻し
			/// </summary>
			ReturnBc = 116,
			/// <summary>
			///クレジットカード
			/// </summary>
			CreditCard = 117,
			/// <summary>
			///クレジットカード払戻
			/// </summary>
			CreditCardWithdrawal = 118,
			/// <summary>
			///オンラインクレジット
			/// </summary>
			OnlineCredit = 119,
			/// <summary>
			///オンラインクレジット戻
			/// </summary>
			OnlineCreditReturn = 120,
			/// <summary>
			///割引金額
			/// </summary>
			DiscountAmount = 121,
			/// <summary>
			///割引金額戻
			/// </summary>
			DiscountAmountReturn = 122,
			/// <summary>
			///その他入金返金
			/// </summary>
			OtherDepositRefunds = 123,
			/// <summary>
			///その他戻
			/// </summary>
			OtherReturn = 124,
			/// <summary>
			///オープン券
			/// </summary>
			OpenTicket = 125,
			/// <summary>
			///取扱手数料
			/// </summary>
			HandlingFee = 126,
			/// <summary>
			///取扱手数料戻
			/// </summary>
			HandlingCommissionReversion = 127,
			/// <summary>
			///仮受金
			/// </summary>
			ProvisionalReceipt = 128,
			/// <summary>
			///仮受金精算
			/// </summary>
			PreliminaryPaymentSettlement = 129,
			/// <summary>
			///前受金
			/// </summary>
			AdvancePayment = 130,
			/// <summary>
			///前受金精算
			/// </summary>
			AdvancePaymentAdjustment = 131,
			/// <summary>
			///__前受金精算（東京）
			/// </summary>
			AdvancePaymentSettlementTokyo = 132,
			/// <summary>
			///__前受金精算（新宿）
			/// </summary>
			AdvancePaymentSettlementShinjuku = 133,
			/// <summary>
			///__前受金精算（池袋）
			/// </summary>
			AdvancePaymentSettlementIkebukuro = 134,
			/// <summary>
			///__前受金精算（浜松町）
			/// </summary>
			AdvancePaymentSettlementHamamatsucho = 135,
			/// <summary>
			///__前受金精算（都庁）
			/// </summary>
			AdvancePaymentAdjustmentTocho = 136,
			/// <summary>
			///__前受金精算（キャピタル）
			/// </summary>
			AdvancePaymentAdjustmentCapital = 137,
			/// <summary>
			///未収
			/// </summary>
			Accrued = 138,
			/// <summary>
			///未収回収
			/// </summary>
			AccruedCollection = 139,
			/// <summary>
			///仮払金
			/// </summary>
			TemporaryPayment = 140,
			/// <summary>
			///仮払金精算
			/// </summary>
			PrepaidPaymentSettlement = 141,
			/// <summary>
			///未収補助券
			/// </summary>
			AccruedVoucher = 142,
			/// <summary>
			///未収補助券回収
			/// </summary>
			RecoveryOfAccruedAuxiliaryTickets = 143,
			/// <summary>
			///__未収（補助券）回収（東京）
			/// </summary>
			ReceivedAuxiliaryVoucherCollectionTokyo = 144,
			/// <summary>
			///__未収（補助券）回収（新宿）
			/// </summary>
			AccrualSubsidizedTicketsCollectionShinjuku = 145,
			/// <summary>
			///__未収（補助券）回収（池袋）
			/// </summary>
			RecoveryOfUnpaidSupplementaryTicketsIkebukuro = 146,
			/// <summary>
			///__未収（補助券）回収（浜松町）
			/// </summary>
			AccrualSubsidiaryTicketCollectionHamamatsucho = 147,
			/// <summary>
			///__未収（補助券）回収（都庁）
			/// </summary>
			ReceivedAuxiliaryVoucherCollectionTocho = 148,
			/// <summary>
			///__未収（補助券）回収（キャピタル
			/// </summary>
			ReceivedAuxiliaryTicketCollectionCapital = 149
		}

		/// <summary>
		/// 精算区分
		/// </summary>
		public enum SeisanKbn : int
		{
			/// <summary>
			/// はとバス定期
			/// </summary>
			HatoBusTeiki = 11,
			/// <summary>
			/// Ｒｺｰｽ
			/// </summary>
			RCrs = 12,
			/// <summary>
			/// ｷｬﾋﾟﾀﾙ
			/// </summary>
			Capital = 13,
			/// <summary>
			/// ｼｰﾗｲﾝ
			/// </summary>
			SeaLine = 14,
			/// <summary>
			/// 企画旅行
			/// </summary>
			KikakuTravel = 20,
			/// <summary>
			/// ｸｰﾎﾟﾝ(旅行参加券
			/// </summary>
			CouponTravelSankaKen = 31,
			/// <summary>
			/// ｸｰﾎﾟﾝ(宿泊券
			/// </summary>
			CouponStayKen = 32,
			/// <summary>
			/// ｸｰﾎﾟﾝ(船車券
			/// </summary>
			CouponSensyaKen = 33,
			/// <summary>
			/// ｸｰﾎﾟﾝ(観光券
			/// </summary>
			CouponKankoKen = 34,
			/// <summary>
			/// その他商品売上
			/// </summary>
			SonotaSyohinUriage = 40
		}
		/// <summary>
		/// コース種別３
		/// </summary>
		/// <remarks></remarks>
		public enum CrsKind3Type : int
		{
			[Value("日本語")]
			Japanese = 1,
			[Value("外国語")]
			English = 2
		}
		/// <summary>
		/// 売上区分
		/// </summary>
		/// <remarks></remarks>
		public sealed class UriageKbnType
		{
			[Value("払戻")]
			public const string HaraiModoshi = "H";
			[Value("VOID")]
			public const string Void = "V";
		}
		/// <summary>
		/// 席のみキャンセルフラグ
		/// </summary>
		public sealed class SeatOnlyCancelFlg
		{
			[Value("席のみキャンセル")]
			public const string cancel = "Y";
			public const string notCancel = "";
		}

		/// <summary>
		/// 発行元分類
		/// </summary>
		public sealed class IssueInfoBunrui
		{

			/// <summary>
			/// 発行元郵便番号
			/// </summary>
			public const string IssueYubinNo = "102";
			/// <summary>
			/// 発行元住所
			/// </summary>
			public const string IssueAddress = "103";
			/// <summary>
			/// 発行元部署
			/// </summary>
			public const string IssueSection = "104";
			/// <summary>
			/// 発行元TEL
			/// </summary>
			public const string IssueTel = "105";
			/// <summary>
			/// 発行元FAX
			/// </summary>
			public const string IssueFax = "106";
		}
		#endregion

		#region  コントロール書式
		/// <summary>
		/// コントロール書式
		/// </summary>
		/// <remarks></remarks>
		public const string ControlFormatNotSurrogate = "^Ｔ"; //サロゲートペア文字禁止

		/// <summary>
		/// コントロール書式
		/// </summary>
		/// <remarks></remarks>
		public enum ControlFormat : int
		{
			[Value("None")]
			None = 0, //全角半角混在（初期IMEモード=Hiragana)
			[Value("Aa9")]
			HankakuEiSuji = 1, //半角英数字
			[Value("Aa9@")]
			HankakuEiSujiKigou = 2, //半角英数字記号
			[Value("A9")]
			HankakuEiSujiOnlyUpper = 3, //半角英数字（大文字のみ）
			[Value("A9@")]
			HankakuEiSujiKigouOnlyUpper = 4, //半角英数字記号（大文字のみ）
			[Value("9")]
			HankakuSuji = 5, //半角数字
			[Value("9@")]
			HankakuSujiKigou = 6, //半角数字記号
			[Value("K")]
			HankakuKatakana = 7, //半角ｶﾅ
			[Value("Ｚ")]
			Zenkaku = 8, //全角のみ（半角不可）※全角半角混在は none を使用
			[Value("^ＺＴ")]
			NotZenkaku = 9, //全角以外[サロゲートも除く【補足】「HogeHoge以外」の場合は、サロゲートも除くをデフォルトで含めて下さい]
			[Value("A9@K")]
			NotZenkakuOnlyUpper = 10, //全角以外（大文字のみ）[半角英字(大文字のみ) + 数字 + 記号 + 半角ｶﾅ]
			[Value("A")]
			HankakuEiOnlyUpper = 11 //半角英字（大文字のみ）
		}

		#endregion

		#region  各業務からの移植

		/// <summary>
		/// コード分類管理関連フラグ
		/// 追加・更新・削除フラグの定義値
		/// ※コード分類管理テーブル専用の定義値
		/// </summary>
		/// <remarks></remarks>
		public enum codeBunruiCtlAddUpdDelFlgType : int
		{
			[Value("不可")]
			fuka = 0,
			[Value("有効（一般）")]
			yukoIppan = 1,
			[Value("有効（システム）")]
			yukoSystem = 2
		}

		/// <summary>
		/// システム共通記号定義
		/// </summary>
		/// <remarks></remarks>
		public sealed class CommonKigouType
		{
			public const string maruMark = "○";
			public const string percentMark = "％";
			public const string enMark = "円";
		}

		/// <summary>
		/// 会社コード定義
		/// </summary>
		/// <remarks></remarks>
		public sealed class CompanyCdType
		{
			[Value("はとバス")]
			public const string hatoBus = "00";
			//【メモ】「00」以外にも「01」,「02」,「03」,「04」,「09」,「11」,「31」
			//があるようだが、仕様が明確でないためはとバスのみを定義する。
			//会社コードの定義が必要になったらこの定義体へ追加すること
		}

		/// <summary>
		/// Fill用文字の定義定義
		/// </summary>
		/// <remarks></remarks>
		public sealed class FillCharType
		{
			public const string fillZero = "0"; //「0」埋め用文字
			public const string fillZenSpace = "　"; //全角スペース埋め用文字
			public const string fillSpace = " "; //半角スペース埋め用文字
		}

		/// <summary>
		/// システム共通汎用文字定義
		/// </summary>
		/// <remarks></remarks>
		public sealed class CommonCharType
		{
			public const string slash = "/"; //スラッシュ
			public const string hyphen = "-"; //ハイフン
			public const string comma = ","; //カンマ
		}

		/// <summary>
		/// システム共通汎用フォーマット定義
		/// </summary>
		/// <remarks></remarks>
		public sealed class CommonFormatType
		{
			public const string dateFormatyyyyMMdd = "yyyyMMdd";
			public const string dateFormatyyyyMM = "yyyyMM";
			public const string dateFormatYYYYMMDDbySlash = "YYYY/MM/DD";
			public const string numberFormatComma = "999G999G999";
			public const string numberFormatCommaLargeDigit = "999G999G999G999";
		}

		/// <summary>
		/// システム共通ボタンテキスト定義
		/// </summary>
		/// <remarks></remarks>
		public sealed class CommonButtonTextType
		{
			public const string hyoji = "表示 >>";
			public const string hiHyoji = "非表示 <<";
		}

		/// <summary>
		/// 利用者情報(M_USER)の会社情報内容
		/// </summary>
		/// <remarks></remarks>
		public sealed class MuserCompanyCdType
		{
			[Value("はとバス")]
			public const string hatoBus = "0001";
		}

		/// <summary>
		/// システム設定マスタ(M_SETTING)の分類ID内容
		/// </summary>
		/// <remarks></remarks>
		public enum MsettingClassificationIdType : int
		{
			[Value("利用者の権限種類")]
			UserAutKind = 50
		}

		/// <summary>
		/// 場所マスタWeb予約コンボ上限、下限値定義の内容 ※未使用 2019/05/15
		/// </summary>
		/// <remarks></remarks>
		public sealed class PlaceMstWebComboBoxFromToType
		{
			[Value("定期・From値")]
			public const string teikiFromCodeValue = "31";
			[Value("定期・To値")]
			public const string teikiToCodeValue = "50";
			[Value("企画・From値")]
			public const string kikakuFromCodeValue = "01";
			[Value("企画・To値")]
			public const string kikakuToCodeValue = "30";
		}
		/// <summary>
		/// 消費税区分
		/// </summary>
		/// <remarks></remarks>
		public sealed class ShohiTaxKbnType //消費税区分タイプ
		{
			[Value("なし")]
			public const string nashi = "0";
			[Value("税込")]
			public const string zeikomi = "1";
			[Value("税抜")]
			public const string zeinuki = "2";
		}

		/// <summary>
		/// 使用区分の内容
		/// </summary>
		/// <remarks></remarks>
		public sealed class UseKbnType
		{
			[Value("選択可能")]
			public const string chooseable = "1";
			[Value("固定表示")]
			public const string fixedDisplay = "2";
		}

		/// <summary>
		/// 場所コード(予約値)の内容
		/// </summary>
		/// <remarks></remarks>
		public sealed class PlaceCdFixedType
		{
			[Value("着後解散")]
			public const string chakugoKaisan = "98";
			[Value("入場解散")]
			public const string nyujoKaisan = "99";
		}

		/// <summary>
		/// キャリア区分
		/// </summary>
		/// <remarks></remarks>
		public sealed class CarrierKbnType
		{
			[Value("バス")]
			public const string bus = "B";
			[Value("AIR")]
			public const string air = "A";
			[Value("列車")]
			public const string train = "T";
			[Value("船舶")]
			public const string ship = "S";
		}

		/// <summary>
		/// 通知方法[仕入先]値の内容
		/// </summary>
		/// <remarks></remarks>
		public enum NotificationHohoSiireSakiType : int
		{
			[Value("メール")]
			Mail = 1,
			[Value("FAX")]
			Fax = 2
		}

		/// <summary>
		/// 通知方法[代理店]値の内容
		/// </summary>
		/// <remarks></remarks>
		public enum NotificationHohoAgentType : int
		{
			[Value("メール")]
			Mail = 1,
			[Value("FAX")]
			Fax = 2,
			[Value("メール(お客様宛)")]
			MailForCustomers = 3,
			[Value("郵送(お客様宛)")]
			YusouForCustomers = 4
		}

		/// <summary>
		/// 請求書送付値の内容
		/// </summary>
		/// <remarks></remarks>
		public enum SeikyuSofuType : int
		{
			[Value("しない")]
			Shinai = 0,
			[Value("する")]
			Suru = 1
		}

		/// <summary>
		/// 本券送付値の内容
		/// </summary>
		/// <remarks></remarks>
		public enum HonkenSofuType : int
		{
			[Value("しない")]
			Shinai = 0,
			[Value("する")]
			Suru = 1
		}

		/// <summary>
		/// 契約区分値の内容
		/// (定期/企画・R/貸切)
		/// </summary>
		/// <remarks></remarks>
		public enum DairitenKeiyakuKbnType : int
		{
			[Value("契約")]
			Kekyaku = 0,
			[Value("未契約")]
			MiKekyaku = 1
		}

		/// <summary>
		/// 企画未契約対象フラグ値の内容
		/// </summary>
		/// <remarks></remarks>
		public enum KikakuMiFlgType : int
		{
			[Value("非対象")]
			NotTaisho = 0,
			[Value("対象")]
			Taisho = 1
		}

		/// <summary>
		/// 支払区分値の内容[代理店]
		/// (定期/企画・R/貸切)
		/// </summary>
		/// <remarks></remarks>
		public enum DairitenSiharaiKbnType : int
		{
			[Value("前払い")]
			Maebarai = 0,
			[Value("後払い")]
			Atobarai = 1
		}

		/// <summary>
		/// 後払時精算区分値の内容[代理店]
		/// (定期/企画・R/貸切)
		/// </summary>
		/// <remarks></remarks>
		public enum AtoSeisanKbnType : int
		{
			[Value("発券精算")]
			HakkenSeisan = 0,
			[Value("着券精算")]
			ChakukenSeisan = 1
		}

		/// <summary>
		/// 後払時クーポン区分値の内容[代理店]
		/// (定期/企画・R/貸切)
		/// </summary>
		/// <remarks></remarks>
		public enum AtoCouponKbnType : int
		{
			[Value("AGTクーポン(自社)")]
			AGTCoupon = 0,
			[Value("はと手書きクーポン(乗車証)")]
			HatoCouponJoshaSho = 1,
			[Value("はと手書きクーポン(会員券)")]
			HatoCouponKaiinKen = 2
		}

		/// <summary>
		/// 送客手数料_計算方法区分(仕入マスタ)
		/// </summary>
		/// <remarks></remarks>
		public sealed class SokyakFeeSiireType
		{
			[Value("台数")]
			public const string daisu = "A";
			[Value("人数")]
			public const string ninzu = "B";
			[Value("売上")]
			public const string uriage = "C";
		}

		/// <summary>
		/// 支払い方法(仕入マスタ)
		/// </summary>
		/// <remarks></remarks>
		public enum PaymentHohoSiire : int
		{
			[Value("振込（請求書）")]
			hurikomiSeikyusho = 1,
			[Value("現金")]
			genkin = 2,
			[Value("他")]
			other = 3,
			[Value("振込（支払通知）")]
			hurikomiSiharaiTuti = 4
		}

		/// <summary>
		/// 精算方法（乗車）
		/// </summary>
		/// <remarks></remarks>
		public enum SeisanHohoJyosya : int
		{
			[Value("振込")]
			furikomi = 1, //振込
			[Value("窓口（前払現金）")]
			maebaraiGenkin = 2, //窓口（前払現金）
			[Value("窓口（当日現金）")]
			toujitsuGenkin = 3, //窓口（当日現金）
			[Value("他社券")]
			tasyaken = 4, //他社券
			[Value("カード（ｵﾝﾗｲﾝ決済）")]
			card = 5, //カード（ｵﾝﾗｲﾝ決済）
			[Value("その他")]
			sonota = 6 //その他
		}

		//ラジオボタン未選択値
		public const int NotSelectedRadioValue = -1;

		/// <summary>
		/// 使用中フラグ
		/// </summary>
		/// <remarks></remarks>
		public sealed class UsingFlg
		{
			[Value("使用中")]
			public const string Use = "Y";
			[Value("未使用")]
			public const string Unused = null;
		}

		/// <summary>
		/// 手仕舞区分
		/// </summary>
		/// <remarks></remarks>
		public enum TejimaiKbn : int //手仕舞区分値
		{
			[Value("済")]
			Zumi = 1,
			[Value("未")]
			Mi = 2
		}

		/// <summary>
		/// 邦人＿外客区分
		/// </summary>
		public sealed class HoujinGaikyakuKbnType //邦人_外客区分タイプ
		{
			public const string Houjin = "H"; //邦人
			public const string Gaikyaku = "G"; //外客
		}
		/// <summary>
		/// 催行可否
		/// </summary>
		/// <remarks></remarks>
		public enum Saikoukahi : int //催行可否値
		{
			[Value("未設定")]
			Miseetei = 1,
			[Value("催行")]
			Saikou = 2,
			[Value("中止")]
			Tyushi = 3
		}

		/// <summary>
		/// 催行確定区分
		/// </summary>
		/// <remarks></remarks>
		public sealed class SaikouKakuteiKbn
		{
			[Value("催行")]
			public const string Saikou = "Y";
			[Value("中止")]
			public const string Tyushi = "N";
			[Value("廃止")]
			public const string Haishi = "X";
		}

		/// <summary>
		/// コード分類コード
		/// </summary>
		public sealed class CodeBunrui
		{
			public const string unkyu = "009"; // 運休区分
			public const string saikou = "008"; // 催行確定区分
			public const string yobi = "015"; // 曜日コード
			public const string crskbn1 = "018"; // コース区分1
			public const string crskbn2 = "019"; // コース区分2
			public const string crskind = "020"; // コース種別
			public const string seasonKikaku = "150"; //季マスタ（企画）
			public const string seasonTeiki = "151"; //季マスタ（定期）
			public const string category = "152"; // カテゴリー
			public const string crsmessage = "154"; // メッセージ
			public const string crsinfo = "155"; // コース情報
			public const string siireKind = "157"; // 仕入先種別
			public const string seisanMokuteki = "158"; // 精算目的
			public const string seisanKanren = "400"; // 精算関連項目
		}

		/// <summary>
		/// 運休区分
		/// </summary>
		/// <remarks></remarks>
		public sealed class UnkyuKbn
		{
			[Value("運休")]
			public const string Unkyu = "Y";
			[Value("廃止")]
			public const string Haishi = "X";
		}

		/// <summary>
		/// 営業所ブロック区分
		/// </summary>
		public sealed class EigyosyoBlockKbn
		{
			[Value("ブロックなし")]
			public const string blockNo = "0";
			[Value("ブロックあり")]
			public const string blockYes = "1";
		}

		/// <summary>
		/// 台数カウント
		/// </summary>
		/// <remarks></remarks>
		public sealed class BusCountFlg
		{
			[Value("カウントする")]
			public const string Count = "0";
			[Value("カウントしない")]
			public const string NoCount = "1";
		}

		/// <summary>
		/// 発券内容
		/// </summary>
		/// <remarks></remarks>
		public enum HakkenNaiyo : int
		{
			[Value("全金")]
			Zenkin = 1,
			[Value("内金")]
			Uchikin = 2,
			[Value("残金")]
			Zankin = 3
		}

		/// <summary>
		/// ○増管理区分
		/// </summary>
		/// <remarks></remarks>
		public sealed class MaruzouKanriKbn
		{
			[Value("○増")]
			public const string Maruzou = "M";
		}

		/// <summary>
		/// 車種コード（架空車種）
		/// </summary>
		/// <remarks></remarks>
		public const string CarTypeCdKakuu = "XX";

		/// <summary>
		/// 精算方法
		/// </summary>
		/// <remarks></remarks>
		public sealed class SeisanHouhou
		{
			[Value("振込")]
			public const string furikomi = "1";
			[Value("営業所")]
			public const string eigyousyo = "2";
			[Value("当日払い")]
			public const string toujitsubarai = "3";
			[Value("ＡＧＴ")]
			public const string agt = "4";
			[Value("カード")]
			public const string card = "5";
		}

		/// <summary>
		/// 性別
		/// </summary>
		public enum SexBetu : int
		{
			[Value("男性")]
			Man = 1,
			[Value("女性")]
			Woman = 2
		}

		/// <summary>
		/// 必須区分
		/// </summary>
		/// <remarks></remarks>
		public enum HissuKbn : int
		{
			[Value("任意")]
			any = 1,
			[Value("必須（人毎）")]
			hitogoto = 3,
			[Value("必須（予約毎）")]
			yoyakugoto = 2
		}

		/// <summary>
		/// 単価区分
		/// </summary>
		/// <remarks></remarks>
		public enum TankaKbn : int
		{
			[Value("人数単価")]
			ninzuu = 1,
			[Value("ルーム単価")]
			room = 2,
			[Value("数量単価")]
			suuryo = 3
		}

		/// <summary>
		/// 予約停止フラグ
		/// </summary>
		/// <remarks></remarks>
		public sealed class YoyakuStopFlg
		{
			[Value("停止")]
			public const string Teishi = "Y";
		}

		/// <summary>
		/// ノーサイン区分
		/// </summary>
		/// <remarks></remarks>
		public sealed class NosignKbn
		{
			[Value("ノーサイン")]
			public const string N = "N";
		}

		/// <summary>
		/// 受付開始ヶ月前値
		/// </summary>
		/// <remarks></remarks>
		public enum UketukeStartKagetumae : int //受付開始ヶ月前値
		{
			[Value("1")]
			One = 1,
			[Value("2")]
			Two = 2,
			[Value("3")]
			Three = 3
		}

		/// <summary>
		/// 受付開始日値
		/// </summary>
		/// <remarks></remarks>
		public enum UketukeStartBi : int //受付開始日値
		{
			[Value("1")]
			ONE = 1,
			[Value("2")]
			Two = 2
		}

		/// <summary>
		/// キャンセルフラグ
		/// </summary>
		/// <remarks></remarks>
		public enum CancelFlg : int //キャンセルフラグ
		{
			[Value("発券前")]
			Hakkenmae = 1,
			[Value("発券後")]
			Hakkengo = 2
		}

		/// <summary>
		/// 空席数補助席
		/// </summary>
		/// <remarks></remarks>
		public sealed class SubSeatOkKbn
		{
			[Value("発売")]
			public const string Ka = "Y";
			[Value("")]
			public const string Hi = "N";
		}

		/// <summary>
		/// 予約状態
		/// </summary>
		/// <remarks></remarks>
		public enum YoyakuStatus : int
		{
			[Value("仮配置")]
			Karihaichi = 0,
			[Value("発券済")]
			hakkenzumi = 1,
			[Value("座席指定")]
			Zasekishitei = 2,
			[Value("仮再配置")]
			Karisaihaichi = 3
		}

		/// <summary>
		/// 予約不可フラグ
		/// </summary>
		/// <remarks></remarks>
		public sealed class YoyakuNgFlg
		{
			[Value("不可")]
			public const string Huka = "Y";
		}

		/// <summary>
		/// 振込区分
		/// </summary>
		/// <remarks></remarks>
		public sealed class HurikomiKbn
		{
			[Value("銀行")]
			public const string ginko = "G";
			[Value("郵便局")]
			public const string yubinkyoku = "Y";
			[Value("コンビニ")]
			public const string konbini = "K";
		}
		#endregion

		#region 営業所区分
		/// <summary>
		/// 営業所区分
		///  （ログイン時に設定される区分値）
		/// </summary>
		public sealed class EigyosyoKbn
		{
			[Value("東京営業所")]
			public const string TokyoSalesOffice = "HT";
			[Value("新宿営業所")]
			public const string ShinjukuSalesOffice = "HJ";
			[Value("池袋営業所")]
			public const string IkebukuroSalesOffice = "HB";
			[Value("都庁内案内所")]
			public const string TotyouAnnaijyo = "HA";
			[Value("横浜駅東口・市営バス")]
			public const string YokohamaHigasiSieiBus = "HI";
			[Value("予約センター")]
			public const string ReserveCenter = "HD";
			[Value("業務システム推進部")]
			public const string SystemPromote = "HH";
			[Value("営業企画部")]
			public const string SalesPlanning = "HE";
			[Value("定期観光部")]
			public const string TeikiKanko = "HK";
			[Value("企画旅行部")]
			public const string KikakuTravel = "HR";
			[Value("浜松町総合センター")]
			public const string Hamamatsutyo = "HF";
			[Value("運輸部")]
			public const string Transport = "HU";
			[Value("キャピタルホテル")]
			public const string Capital = "HC";
			[Value("研修室")]
			public const string Kensyusitsu = "HX";
			[Value("企画旅行地元発")]
			public const string PlanningLocalDepartment = "HP";
			[Value("浜松町企画カウンター")]
			public const string HamamatsuchoCheckIn = "HG";
			[Value("新宿駅西口")]
			public const string ShinjukuNishiguchi = "HO";
			[Value("池袋東口")]
			public const string IkebukuroHigashiguchi = "HM";
			[Value("キャピタル企画")]
			public const string CapitalPlanning = "H1";
			[Value("路線バス事業部")]
			public const string RosenBus = "HZ";
			[Value("本社")]
			public const string Honsya = "HQ";

		}
		#endregion

		// 廃止2019/02/21
		//#Region " 部署区分[BO]（暫定仮値）"
		//    Public NotInheritable Class busyoKbnBO
		//        <Value("業務管理課")>
		//        Public Const GyomuKanri As String = "1"
		//        <Value("予約センター")>
		//        Public Const ReserveCenter As String = "2"
		//        <Value("東京営業所")>
		//        Public Const TokyoEigyosho As String = "3"
		//        <Value("新宿営業所")>
		//        Public Const SinjukuEigyosho As String = "4"
		//        <Value("池袋営業所")>
		//        Public Const IkebukuroEigyosho As String = "5"
		//        <Value("浜松町営業所")>
		//        Public Const HamamatsutyoEigyosho As String = "6"
		//        <Value("都庁営業所")>
		//        Public Const TochoEigyosho As String = "7"
		//        <Value("営業所企画課")>
		//        Public Const EigyoKikakuka As String = "8"
		//        <Value("企画旅行部")>
		//        Public Const KikakuRyokobu As String = "9"
		//        <Value("ホテル")>
		//        Public Const Hotel As String = "10"
		//        <Value("その他")>
		//        Public Const Sonota As String = "11"
		//    End Class
		//#End Region

		#region  所属部署コード
		public sealed class SectionBusyoCd
		{
			[Value("営業企画部 営業企画課")]
			public const string EigyoKikakuka = "12211";
			[Value("営業企画部 業務管理課")]
			public const string GyomuKanrika = "12214";
			[Value("国際事業部企画課")]
			public const string InternationalPlanninng = "1226100";
			[Value("国際事業部販売促進課")]
			public const string SalesPromote = "1226300";
		}
		#endregion

		#region 権限関連

		/// <summary>
		/// 権限種類
		/// </summary>
		/// <remarks></remarks>
		public enum AutKd : int
		{
			[Value("所属")]
			syozoku = 1,
			[Value("個人")]
			kojin = 2,
			[Value("役職")]
			yakusyoku = 3
		}

		/// <summary>
		/// 権限レベル
		/// </summary>
		/// <remarks></remarks>
		public enum AuthLevel : int
		{
			[Value("不可")]
			non = 0,
			[Value("参照")]
			read = 1,
			[Value("更新")]
			update = 2,
			[Value("追加")]
			add = 3,
			[Value("承認")]
			syounin = 4,
			[Value("特権")]
			super = 9
		}


		/// <summary>
		/// システムコード
		/// </summary>
		public sealed class SystemCode
		{
			// 造成 --------------------
			[Value("造成メニュー")]
			public const string M01 = "M01";
			// 造成（各メニューのボタン） --------------------
			[Value("造成_コース検索")]
			public const string M0101 = "M0101";
			[Value("造成_使用済コース番号照会")]
			public const string M0102 = "M0102";
			[Value("造成_ピックアップホテルマスタ")]
			public const string M0103 = "M0103";
			[Value("造成_ピックアップマスタ")]
			public const string M0104 = "M0104";

			// 予約 --------------------
			[Value("予約メニュー")]
			public const string M02 = "M02";
			// 予約（各メニューのボタン） --------------------
			[Value("予約_予約登録")]
			public const string M0201 = "M0201";
			[Value("予約_当日予約")]
			public const string M0202 = "M0202";
			[Value("予約_予約照会・変更")]
			public const string M0203 = "M0203";
			[Value("予約_予約照会（バス単位）")]
			public const string M0204 = "M0204";
			[Value("予約_予約メモ照会")]
			public const string M0205 = "M0205";
			[Value("予約_発券")]
			public const string M0206 = "M0206";
			[Value("予約_払戻")]
			public const string M0207 = "M0207";
			[Value("予約_座席照会・変更")]
			public const string M0208 = "M0208";
			[Value("予約_予約取込")]
			public const string M0209 = "M0209";
			[Value("予約_キャンセル発生コース照会")]
			public const string M0210 = "M0210";
			[Value("予約_予約キャンセル料金修正")]
			public const string M0211 = "M0211";
			[Value("予約_送付物")]
			public const string M0212 = "M0212";
			[Value("予約_入金確認")]
			public const string M0213 = "M0213";
			[Value("予約_請求書")]
			public const string M0214 = "M0214";
			[Value("予約_事後予約登録")]
			public const string M0215 = "M0215";
			[Value("予約_予約連絡リスト")]
			public const string M0216 = "M0216";
			[Value("予約_ダブリチェックリスト")]
			public const string M0217 = "M0217";
			[Value("予約_予約ログ照会")]
			public const string M0218 = "M0218";
			[Value("予約_ホリデーチケット設定")]
			public const string M0219 = "M0219";
			[Value("予約_郵便番号検索")]
			public const string M0220 = "M0220";
			[Value("予約_代理店（業者）検索")]
			public const string M0221 = "M0221";
			[Value("予約_使用中解除")]
			public const string M0222 = "M0222";
			[Value("予約_帳票（予約）")]
			public const string M0223 = "M0223";

			// 手配 --------------------
			[Value("手配メニュー")]
			public const string M03 = "M03";
			// 手配（各メニューのボタン） --------------------
			[Value("手配_予約状況表")]
			public const string M0301 = "M0301";
			[Value("手配_コース台帳")]
			public const string M0302 = "M0302";
			[Value("手配_増発")]
			public const string M0303 = "M0303";
			[Value("手配_催行可否・手仕舞い")]
			public const string M0304 = "M0304";
			[Value("手配_バス会社決定")]
			public const string M0305 = "M0305";
			[Value("手配_車番登録")]
			public const string M0306 = "M0306";
			[Value("手配_帳票（手配）")]
			public const string M0307 = "M0307";
			[Value("手配_リクエスト")]
			public const string M0308 = "M0308";

			// 運行 --------------------
			[Value("運行メニュー")]
			public const string M04 = "M04";
			// 運行（各メニューのボタン） --------------------
			[Value("運行_利用人員確定")]
			public const string M0401 = "M0401";
			[Value("運行_チェックイン")]
			public const string M0402 = "M0402";
			[Value("運行_受付状況確認")]
			public const string M0403 = "M0403";
			[Value("運行_降車ヶ所人員連絡")]
			public const string M0404 = "M0404";
			[Value("運行_準備金管理")]
			public const string M0405 = "M0405";
			[Value("運行_ピックアップ管理")]
			public const string M0406 = "M0406";
			[Value("運行_添乗員一括入力")]
			public const string M0407 = "M0407";
			[Value("運行_経由便経由地調整")]
			public const string M0408 = "M0408";
			[Value("運行_乗り場設定")]
			public const string M0409 = "M0409";
			[Value("運行_帳票（運行）")]
			public const string M0410 = "M0410";

			// 精算 --------------------
			[Value("精算メニュー")]
			public const string M05 = "M05";
			// 精算（各メニューのボタン） --------------------
			[Value("精算_入金管理")]
			public const string M0501 = "M0501";
			[Value("精算_返金管理")]
			public const string M0502 = "M0502";
			[Value("精算_現払処理")]
			public const string M0503 = "M0503";
			[Value("精算_その他商品・その他精算")]
			public const string M0504 = "M0504";
			[Value("精算_窓口会計処理")]
			public const string M0505 = "M0505";
			[Value("精算_月次請求")]
			public const string M0506 = "M0506";
			[Value("精算_買掛金管理")]
			public const string M0507 = "M0507";
			[Value("精算_会計連携")]
			public const string M0508 = "M0508";

			// 顧客 --------------------
			[Value("顧客メニュー")]
			public const string M06 = "M06";
			// 顧客（各メニューのボタン） --------------------
			[Value("顧客_WEB会員管理")]
			public const string M0601 = "M0601";
			[Value("顧客_UG管理")]
			public const string M0602 = "M0602";
			[Value("顧客_割引クーポン管理")]
			public const string M0603 = "M0603";

			// 統計 --------------------
			[Value("統計メニュー")]
			public const string M07 = "M07";
			// 統計（各メニューのボタン） --------------------
			[Value("統計_予約・売上集計分析")]
			public const string M0701 = "M0701";
			[Value("統計_利用人員表")]
			public const string M0702 = "M0702";
			[Value("統計_帳票（統計）")]
			public const string M0703 = "M0703";
			[Value("統計_自由分析")]
			public const string M0704 = "M0704";
			[Value("統計_顧客関連情報分析")]
			public const string M0705 = "M0705";

			// 団体受付 --------------------
			[Value("団体受付メニュー")]
			public const string M08 = "M08";
			// 団体受付（各メニューのボタン） --------------------
			[Value("団体受付_団体受付")]
			public const string M0801 = "M0801";
			[Value("団体受付_ツアー別売上収支一覧表")]
			public const string M0802 = "M0802";

			// マスタ管理 --------------------
			[Value("マスタ管理メニュー")]
			public const string M70 = "M70";
			// マスタ管理（各メニューのボタン） --------------------
			[Value("マスタ管理_車種マスタ照会・更新")]
			public const string M7001 = "M7001";
			[Value("マスタ管理_料金区分マスタ照会・更新")]
			public const string M7002 = "M7002";
			[Value("マスタ管理_バス会社通知方法照会・更新")]
			public const string M7003 = "M7003";
			[Value("マスタ管理_接続会社マスタ照会・更新")]
			public const string M7004 = "M7004";
			[Value("マスタ管理_代理店マスタ照会・更新")]
			public const string M7005 = "M7005";
			[Value("マスタ管理_郵便番号マスタ照会・更新")]
			public const string M7006 = "M7006";
			[Value("マスタ管理_料金区分（人員）マスタ照会・更新")]
			public const string M7007 = "M7007";
			[Value("マスタ管理_補助券発行会社登録")]
			public const string M7008 = "M7008";
			[Value("マスタ管理_オプション登録")]
			public const string M7009 = "M7009";
			[Value("マスタ管理_団体情報マスタ照会・更新")]
			public const string M7010 = "M7010";
			[Value("マスタ管理_コードマスタ照会・更新")]
			public const string M7011 = "M7011";
			[Value("マスタ管理_種別マスタ照会・更新")]
			public const string M7012 = "M7012";
			[Value("マスタ管理_割引クーポンマスタ照会・更新")]
			public const string M7013 = "M7013";
			[Value("マスタ管理_他社マスタ照会・更新")]
			public const string M7014 = "M7014";
			[Value("マスタ管理_営業所マスタ照会・更新")]
			public const string M7015 = "M7015";
			[Value("マスタ管理_場所マスタ照会・更新")]
			public const string M7016 = "M7016";
			[Value("マスタ管理_他社主催商品マスタ照会・更新")]
			public const string M7017 = "M7017";
			[Value("マスタ管理_路線マスタ照会・更新")]
			public const string M7018 = "M7018";
			[Value("マスタ管理_SS部門マスタ照会・更新")]
			public const string M7019 = "M7019";
			[Value("マスタ管理_SS科目・補助マスタ照会・更新")]
			public const string M7020 = "M7020";
			[Value("マスタ管理_科目：船車券対応照会・更新")]
			public const string M7021 = "M7021";
			[Value("マスタ管理_科目：クレジット対応照会・更新")]
			public const string M7022 = "M7022";
			[Value("マスタ管理_仕入先マスタ照会・更新")]
			public const string M7023 = "M7023";
			[Value("マスタ管理_カレンダーマスタ照会・更新")]
			public const string M7024 = "M7024";
			[Value("マスタ管理_連結記号マスタ照会・更新")]
			public const string M7025 = "M7025";
			[Value("マスタ管理_割引コードマスタ照会・更新")]
			public const string M7026 = "M7026";
			[Value("マスタ管理_添乗員マスタ照会・更新")]
			public const string M7027 = "M7027";
			[Value("マスタ管理_車番マスタ照会・更新")]
			public const string M7028 = "M7028";
			[Value("マスタ管理_宿泊施設素材マスタ照会・更新")]
			public const string M7029 = "M7029";
			[Value("マスタ管理_工程素材マスタ照会・更新")]
			public const string M7030 = "M7030";
			[Value("マスタ管理_その他素材マスタ照会・更新")]
			public const string M7031 = "M7031";
			[Value("マスタ管理_会員管理マスタ照会・更新")]
			public const string M7032 = "M7032";
			[Value("マスタ管理_クーポン管理マスタ照会・更新")]
			public const string M7033 = "M7033";

			// 管理機能 --------------------
			[Value("管理機能メニュー")]
			public const string M80 = "M80";
			// 管理機能（各メニューのボタン） --------------------
			[Value("管理機能_利用者情報照会・更新")]
			public const string M8001 = "M8001";
			[Value("管理機能_所属情報照会・更新")]
			public const string M8002 = "M8002";
			[Value("管理機能_権限情報照会・更新")]
			public const string M8003 = "M8003";
			[Value("管理機能_システム管理情報照会・更新")]
			public const string M8004 = "M8004";
			[Value("管理機能_利用者情報取込")]
			public const string M8005 = "M8005";
			[Value("管理機能_所属情報取込")]
			public const string M8006 = "M8006";
			[Value("管理機能_権限情報取込")]
			public const string M8007 = "M8007";

			// 共通機能 --------------------
			[Value("各種メニュー")]
			public const string M00 = "M00";
			[Value("各種メニュー")]
			public const string M00XX = "M00XX";

			[Value("各種子画面")]
			public const string M90 = "M90";
			[Value("各種子画面")]
			public const string M90XX = "M90XX";

		}

		#endregion

		#region 会員関連

		/// <summary>
		/// 会員職業区分
		/// </summary>
		/// <remarks></remarks>
		public enum KaiinShokuGyouKbn : int
		{
			[Value("会社員")]
			K,
			[Value("公務員")]
			C,
			[Value("自営業")]
			J,
			[Value("主婦")]
			F,
			[Value("学生")]
			S,
			[Value("その他")]
			E
		}

		/// <summary>
		/// 要否
		/// </summary>
		/// <remarks></remarks>
		public enum HiYou : int
		{
			[Value("必要")]
			Y,
			[Value("不要")]
			N
		}

		/// <summary>
		/// 電話区分
		/// </summary>
		/// <remarks></remarks>
		public enum TelKbn : int
		{
			[Value("自宅")]
			jitaku = 1,
			[Value("勤務先")]
			kinmusaki = 2,
			[Value("その他")]
			sonota = 9
		}


		/// <summary>
		///   承認_選択
		/// </summary>
		/// <remarks></remarks>
		public enum Approve_Status : int
		{
			[Value(" ")]
			NO_STATUS = 0,
			[Value("未承認")]
			NOT_YET = 1,
			[Value("チェック済")]
			CHECKED = 2,
			[Value("承認済")]
			APPROVED = 3
		}

		/// <summary>
		///    条件日
		/// </summary>
		/// <remarks></remarks>
		public enum References_date : int
		{
			[Value("返金日")]
			REFUND_DATE = 0,

			[Value("チェック日")]
			CHECK_DATE = 1,

			[Value("承認日")]
			APPROVAL_DATE = 2,

			[Value("出力日")]
			OUTPUT_DATE = 3

		}

		#endregion



	}
}
