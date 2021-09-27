/// <summary>
/// NO SHOW 一覧エンティティ
/// </summary>
[Serializable()]
public class S04_0303_Entity
{

	#region  変数／定数

	//(検索項目)出発日
	private EntityKoumoku_NumberType _SyuptDay = new EntityKoumoku_NumberType();
	//(検索項目)乗車地コード
	private EntityKoumoku_MojiType _JyosyachiCd = new EntityKoumoku_MojiType();
	//コースコード
	private EntityKoumoku_MojiType _CrsCd = new EntityKoumoku_MojiType();
	//コース名
	private EntityKoumoku_MojiType _CrsName = new EntityKoumoku_MojiType();
	//乗車地１
	private EntityKoumoku_MojiType _JyosyachiNm1 = new EntityKoumoku_MojiType();
	//出発時間１
	private EntityKoumoku_NumberType _SyuptTime1 = new EntityKoumoku_NumberType();
	//乗車地２
	private EntityKoumoku_MojiType _JyosyachiNm2 = new EntityKoumoku_MojiType();
	//出発時間２
	private EntityKoumoku_NumberType _SyuptTime2 = new EntityKoumoku_NumberType();
	//乗車地３
	private EntityKoumoku_MojiType _JyosyachiNm3 = new EntityKoumoku_MojiType();
	//出発時間３
	private EntityKoumoku_NumberType _SyuptTime3 = new EntityKoumoku_NumberType();
	//乗車地４
	private EntityKoumoku_MojiType _JyosyachiNm4 = new EntityKoumoku_MojiType();
	//出発時間４
	private EntityKoumoku_NumberType _SyuptTime4 = new EntityKoumoku_NumberType();
	//乗車地５
	private EntityKoumoku_MojiType _JyosyachiNm5 = new EntityKoumoku_MojiType();
	//出発時間５
	private EntityKoumoku_NumberType _SyuptTime5 = new EntityKoumoku_NumberType();
	//号車
	private EntityKoumoku_NumberType _Gousya = new EntityKoumoku_NumberType();
	//ＮＯＳＨＯＷフラグ
	private EntityKoumoku_MojiType _NoShowFlg = new EntityKoumoku_MojiType();
	//ＮＯＳＨＯＷ
	private EntityKoumoku_MojiType _NoShow = new EntityKoumoku_MojiType();
	//予約区分
	private EntityKoumoku_MojiType _YoyakuKbn = new EntityKoumoku_MojiType();
	//予約NO
	private EntityKoumoku_NumberType _YoyakuNo = new EntityKoumoku_NumberType();
	//予約NOビュー
	private EntityKoumoku_NumberType _YoyakuNoView = new EntityKoumoku_NumberType();
	//名前
	private EntityKoumoku_MojiType _YoyakuNm = new EntityKoumoku_MojiType();
	//乗車人数（大人）
	private EntityKoumoku_NumberType _JyosyaNinzu1 = new EntityKoumoku_NumberType();
	//乗車人数（中人）
	private EntityKoumoku_NumberType _JyosyaNinzu2 = new EntityKoumoku_NumberType();
	//乗車人数（小人）
	private EntityKoumoku_NumberType _JyosyaNinzu3 = new EntityKoumoku_NumberType();
	//電話番号
	private EntityKoumoku_MojiType _TelNo1 = new EntityKoumoku_MojiType();
	//業者名
	private EntityKoumoku_MojiType _AgentNm = new EntityKoumoku_MojiType();
	//申込者
	private EntityKoumoku_MojiType _Yykmks = new EntityKoumoku_MojiType();
	//キャンセルフラグ
	private EntityKoumoku_MojiType _CancelFlg = new EntityKoumoku_MojiType();
	//座席指定予約フラグ
	private EntityKoumoku_MojiType _ZasekiReserveYoyakuFlg = new EntityKoumoku_MojiType();
	//発券内容
	private EntityKoumoku_MojiType _HakkenNaiyo = new EntityKoumoku_MojiType();
	//状態
	private EntityKoumoku_MojiType _State = new EntityKoumoku_MojiType();
	//状態ビュー
	private EntityKoumoku_MojiType _StateView = new EntityKoumoku_MojiType();
	//座席
	private EntityKoumoku_MojiType _Zaseki = new EntityKoumoku_MojiType();
	///************** 以下は固定項目 ***************/
	//登録ＰＧＭＩＤ
	private EntityKoumoku_MojiType _EntryPgmid = new EntityKoumoku_MojiType();
	//登録者コード
	private EntityKoumoku_MojiType _EntryPersonCd = new EntityKoumoku_MojiType();
	//登録日
	private EntityKoumoku_YmdType _EntryDate = new EntityKoumoku_YmdType();
	//更新ＰＧＭＩＤ
	private EntityKoumoku_MojiType _UpdatePgmid = new EntityKoumoku_MojiType();
	//更新者コード
	private EntityKoumoku_MojiType _UpdatePersonCd = new EntityKoumoku_MojiType();
	//更新日
	private EntityKoumoku_YmdType _UpdateDate = new EntityKoumoku_YmdType();
	//削除日(TODO 型が共通と異なる)
	//Private _DeleteDate As New EntityKoumoku_MojiType
	private EntityKoumoku_NumberType _DeleteDate = new EntityKoumoku_NumberType();
	#endregion

	#region  メソッド
	/// <summary>
	/// コンストラクタ
	/// </summary>
	/// <remarks></remarks>
	public S04_0303_Entity()
	{
		//・物理名
		//(検索項目)出発日
		_SyuptDay.PhysicsName = "SYUPT_DAY";
		//(検索項目)乗車地コード
		_JyosyachiCd.PhysicsName = "HAISYA_KEIYU_CD_1";
		//コースコード
		_CrsCd.PhysicsName = "CRS_CD";
		//コース名
		_CrsName.PhysicsName = "CRS_NAME";
		//乗車地１
		_JyosyachiNm1.PhysicsName = "PLACE_NAME_1";
		//出発時間１
		_SyuptTime1.PhysicsName = "SYUPT_TIME_1";
		//乗車地２
		_JyosyachiNm2.PhysicsName = "PLACE_NAME_2";
		//出発時間２
		_SyuptTime2.PhysicsName = "SYUPT_TIME_2";
		//乗車地３
		_JyosyachiNm3.PhysicsName = "PLACE_NAME_3";
		//出発時間３
		_SyuptTime3.PhysicsName = "SYUPT_TIME_3";
		//乗車地４
		_JyosyachiNm4.PhysicsName = "PLACE_NAME_4";
		//出発時間４
		_SyuptTime4.PhysicsName = "SYUPT_TIME_4";
		//乗車地５
		_JyosyachiNm5.PhysicsName = "PLACE_NAME_5";
		//出発時間５
		_SyuptTime5.PhysicsName = "SYUPT_TIME_5";
		//号車
		_Gousya.PhysicsName = "GOUSYA";
		//ＮＯＳＨＯＷフラグ
		_NoShowFlg.PhysicsName = "NO_SHOW_FLG";
		//ＮＯＳＨＯＷ
		_NoShow.PhysicsName = "NO_SHOW";
		//予約区分
		_YoyakuKbn.PhysicsName = "YOYAKU_KBN";
		//予約NO
		_YoyakuNo.PhysicsName = "YOYAKU_NO";
		//予約NOビュー
		_YoyakuNoView.PhysicsName = "YOYAKU_NO_VIEW";
		//名前
		_YoyakuNm.PhysicsName = "YOYAKU_NM";
		//乗車人数（大人）
		_JyosyaNinzu1.PhysicsName = "JYOSYA_NINZU_1";
		//乗車人数（中人）
		_JyosyaNinzu2.PhysicsName = "JYOSYA_NINZU_2";
		//乗車人数（小人）
		_JyosyaNinzu3.PhysicsName = "JYOSYA_NINZU_3";
		//電話番号
		_TelNo1.PhysicsName = "TEL_NO_1";
		//業者名
		_AgentNm.PhysicsName = "AGENT_NM";
		//申込者
		_Yykmks.PhysicsName = "YYKMKS";
		//キャンセルフラグ
		_CancelFlg.PhysicsName = "CANCEL_FLG";
		//座席指定予約フラグ
		_ZasekiReserveYoyakuFlg.PhysicsName = "ZASEKI_RESERVE_YOYAKU_FLG";
		//発券内容
		_HakkenNaiyo.PhysicsName = "HAKKEN_NAIYO";
		//状態
		_State.PhysicsName = "STATE";
		//状態ビュー
		_StateView.PhysicsName = "STATE_VIEW";
		//座席
		_Zaseki.PhysicsName = "ZASEKI";
		///************** 以下は固定項目 ***************/
		//'登録ＰＧＭＩＤ(TODO 物理名が共通と異なる)
		//_EntryPgmid.PhysicsName = "ENTRY_PGMID"
		_EntryPgmid.PhysicsName = "SYSTEM_ENTRY_PGMID";
		//'登録者コード(TODO 物理名が共通と異なる)
		//_EntryPersonCd.PhysicsName = "ENTRY_PERSON_CD"
		_EntryPersonCd.PhysicsName = "SYSTEM_ENTRY_PERSON_CD";
		//'登録日(TODO 物理名が共通と異なる)
		//_EntryDate.PhysicsName = "ENTRY_DATE"
		_EntryDate.PhysicsName = "SYSTEM_ENTRY_DAY";
		//'更新ＰＧＭＩＤ(TODO 物理名が共通と異なる)
		//_UpdatePgmid.PhysicsName = "UPDATE_PGMID"
		_UpdatePgmid.PhysicsName = "SYSTEM_UPDATE_PGMID";
		//'更新者コード(TODO 物理名が共通と異なる)
		//_UpdatePersonCd.PhysicsName = "UPDATE_PERSON_CD"
		_UpdatePersonCd.PhysicsName = "SYSTEM_UPDATE_PERSON_CD";
		//'更新日(TODO 物理名が共通と異なる)
		//_UpdateDate.PhysicsName = "UPDATE_DATE"
		_UpdateDate.PhysicsName = "SYSTEM_UPDATE_DAY";
		//'削除日(TODO 物理名が共通と異なる)
		//_DeleteDate.PhysicsName = "DELETE_DATE"
		_DeleteDate.PhysicsName = "DELETE_DAY";

		//・必須
		//(検索項目)出発日
		_SyuptDay.Required = true;
		//(検索項目)乗車地コード
		_JyosyachiCd.Required = false;
		//コースコード
		_CrsCd.Required = true;
		//コース名
		_CrsName.Required = false;
		//乗車地１
		_JyosyachiNm1.Required = false;
		//出発時間１
		_SyuptTime1.Required = false;
		//乗車地２
		_JyosyachiNm2.Required = false;
		//出発時間２
		_SyuptTime2.Required = false;
		//乗車地３
		_JyosyachiNm3.Required = false;
		//出発時間３
		_SyuptTime3.Required = false;
		//乗車地４
		_JyosyachiNm4.Required = false;
		//出発時間４
		_SyuptTime4.Required = false;
		//乗車地５
		_JyosyachiNm5.Required = false;
		//出発時間５
		_SyuptTime5.Required = false;
		//号車
		_Gousya.Required = true;
		//ＮＯＳＨＯＷフラグ
		_NoShowFlg.Required = false;
		//ＮＯＳＨＯＷ
		_NoShow.Required = false;
		//予約区分
		_YoyakuKbn.Required = true;
		//予約NO
		_YoyakuNo.Required = true;
		//予約NOビュー
		_YoyakuNoView.Required = false;
		//名前
		_YoyakuNm.Required = false;
		//乗車人数（大人）
		_JyosyaNinzu1.Required = false;
		//乗車人数（中人）
		_JyosyaNinzu2.Required = false;
		//乗車人数（小人）
		_JyosyaNinzu3.Required = false;
		//電話番号
		_TelNo1.Required = false;
		//業者名
		_AgentNm.Required = false;
		//申込者
		_Yykmks.Required = false;
		//キャンセルフラグ
		_CancelFlg.Required = false;
		//座席指定予約フラグ
		_ZasekiReserveYoyakuFlg.Required = false;
		//発券内容
		_HakkenNaiyo.Required = false;
		//状態
		_State.Required = false;
		//状態ビュー
		_StateView.Required = false;
		//座席
		_Zaseki.Required = false;
		///************** 以下は固定項目 ***************/
		//登録ＰＧＭＩＤ
		_EntryPgmid.Required = false;
		//登録者コード
		_EntryPersonCd.Required = false;
		//登録日
		_EntryDate.Required = false;
		//更新ＰＧＭＩＤ
		_UpdatePgmid.Required = false;
		//更新者コード
		_UpdatePersonCd.Required = false;
		//更新日
		_UpdateDate.Required = false;
		//削除日
		_DeleteDate.Required = false;

		//・DB型 [Oracleクライアント未参照なのでコメントアウト]
		//(検索項目)出発日
		_SyuptDay.DBType = OracleDbType.Decimal;
		//(検索項目)乗車地コード
		_JyosyachiCd.DBType = OracleDbType.Char;
		//コースコード
		_CrsCd.DBType = OracleDbType.Char;
		//コース名
		_CrsName.DBType = OracleDbType.Varchar2;
		//乗車地１
		_JyosyachiNm1.DBType = OracleDbType.Varchar2;
		//出発時間１
		_SyuptTime1.DBType = OracleDbType.Decimal;
		//乗車地２
		_JyosyachiNm2.DBType = OracleDbType.Varchar2;
		//出発時間２
		_SyuptTime2.DBType = OracleDbType.Decimal;
		//乗車地３
		_JyosyachiNm3.DBType = OracleDbType.Varchar2;
		//出発時間３
		_SyuptTime3.DBType = OracleDbType.Decimal;
		//乗車地４
		_JyosyachiNm4.DBType = OracleDbType.Varchar2;
		//出発時間４
		_SyuptTime4.DBType = OracleDbType.Decimal;
		//乗車地５
		_JyosyachiNm5.DBType = OracleDbType.Varchar2;
		//出発時間５
		_SyuptTime5.DBType = OracleDbType.Decimal;
		//号車
		_Gousya.DBType = OracleDbType.Decimal;
		//ＮＯＳＨＯＷフラグ
		_NoShowFlg.DBType = OracleDbType.Char;
		//ＮＯＳＨＯＷ
		_NoShow.DBType = OracleDbType.Varchar2;
		//予約区分
		_YoyakuKbn.DBType = OracleDbType.Char;
		//予約NO
		_YoyakuNo.DBType = OracleDbType.Decimal;
		//予約NOビュー
		_YoyakuNoView.DBType = OracleDbType.Decimal;
		//名前
		_YoyakuNm.DBType = OracleDbType.Varchar2;
		//乗車人数（大人）
		_JyosyaNinzu1.DBType = OracleDbType.Decimal;
		//乗車人数（中人）
		_JyosyaNinzu2.DBType = OracleDbType.Decimal;
		//乗車人数（小人）
		_JyosyaNinzu3.DBType = OracleDbType.Decimal;
		//電話番号
		_TelNo1.DBType = OracleDbType.Varchar2;
		//業者名
		_AgentNm.DBType = OracleDbType.Varchar2;
		//申込者
		_Yykmks.DBType = OracleDbType.Varchar2;
		//キャンセルフラグ
		_CancelFlg.DBType = OracleDbType.Char;
		//座席指定予約フラグ
		_ZasekiReserveYoyakuFlg.DBType = OracleDbType.Char;
		//発券内容
		_HakkenNaiyo.DBType = OracleDbType.Char;
		//状態
		_State.DBType = OracleDbType.Char;
		//状態ビュー
		_StateView.DBType = OracleDbType.Varchar2;
		//座席
		_Zaseki.DBType = OracleDbType.Char;
		///************** 以下は固定項目 ***************/
		//登録ＰＧＭＩＤ
		_EntryPgmid.DBType = OracleDbType.Char;
		//登録者コード
		_EntryPersonCd.DBType = OracleDbType.Char;
		//登録日
		_EntryDate.DBType = OracleDbType.Date;
		//更新ＰＧＭＩＤ
		_UpdatePgmid.DBType = OracleDbType.Char;
		//更新者コード
		_UpdatePersonCd.DBType = OracleDbType.Char;
		//更新日
		_UpdateDate.DBType = OracleDbType.Date;
		//削除日(TODO 型が共通と異なる)
		//_DeleteDate.DBType = OracleDbType.Char
		_DeleteDate.DBType = OracleDbType.Decimal;

		//・桁数[整数部]
		//(検索項目)出発日
		_SyuptDay.IntegerBu = 8;
		//(検索項目)乗車地コード
		_JyosyachiCd.IntegerBu = 3;
		//コースコード
		_CrsCd.IntegerBu = 6;
		//コース名
		_CrsName.IntegerBu = 256;
		//乗車地１
		_JyosyachiNm1.IntegerBu = 22;
		//出発時間１
		_SyuptTime1.IntegerBu = 4;
		//乗車地２
		_JyosyachiNm2.IntegerBu = 22;
		//出発時間２
		_SyuptTime2.IntegerBu = 4;
		//乗車地３
		_JyosyachiNm3.IntegerBu = 22;
		//出発時間３
		_SyuptTime3.IntegerBu = 4;
		//乗車地４
		_JyosyachiNm4.IntegerBu = 22;
		//出発時間４
		_SyuptTime4.IntegerBu = 4;
		//乗車地５
		_JyosyachiNm5.IntegerBu = 22;
		//出発時間５
		_SyuptTime5.IntegerBu = 4;
		//号車
		_Gousya.IntegerBu = 3;
		//ＮＯＳＨＯＷフラグ
		_NoShowFlg.IntegerBu = 1;
		//ＮＯＳＨＯＷ
		_NoShow.IntegerBu = 7;
		//予約区分
		_YoyakuKbn.IntegerBu = 1;
		//予約NO
		_YoyakuNo.IntegerBu = 9;
		//予約NOビュー
		_YoyakuNoView.IntegerBu = 10;
		//名前
		_YoyakuNm.IntegerBu = 40;
		//乗車人数（大人）
		_JyosyaNinzu1.IntegerBu = 3;
		//乗車人数（中人）
		_JyosyaNinzu2.IntegerBu = 3;
		//乗車人数（小人）
		_JyosyaNinzu3.IntegerBu = 3;
		//電話番号
		_TelNo1.IntegerBu = 15;
		//業者名
		_AgentNm.IntegerBu = 42;
		//申込者
		_Yykmks.IntegerBu = 20;
		//キャンセルフラグ
		_CancelFlg.IntegerBu = 1;
		//座席指定予約フラグ
		_ZasekiReserveYoyakuFlg.IntegerBu = 1;
		//発券内容
		_HakkenNaiyo.IntegerBu = 1;
		//状態
		_State.IntegerBu = 1;
		//状態ビュー
		_StateView.IntegerBu = 1;
		//座席
		_Zaseki.IntegerBu = 90;
		///************** 以下は固定項目 ***************/
		//登録ＰＧＭＩＤ
		_EntryPgmid.IntegerBu = 8;
		//登録者コード
		_EntryPersonCd.IntegerBu = 20;
		//登録日
		_EntryDate.IntegerBu = 0;
		//更新ＰＧＭＩＤ
		_UpdatePgmid.IntegerBu = 8;
		//更新者コード
		_UpdatePersonCd.IntegerBu = 20;
		//更新日
		_UpdateDate.IntegerBu = 0;
		//削除日
		_DeleteDate.IntegerBu = 8;

		//・桁数[小数部]
		//(検索項目)出発日
		_SyuptDay.DecimalBu = 0;
		//(検索項目)乗車地コード
		_JyosyachiCd.DecimalBu = 0;
		//コースコード
		_CrsCd.DecimalBu = 0;
		//コース名
		_CrsName.DecimalBu = 0;
		//乗車地１
		_JyosyachiNm1.DecimalBu = 0;
		//出発時間１
		_SyuptTime1.DecimalBu = 0;
		//乗車地２
		_JyosyachiNm2.DecimalBu = 0;
		//出発時間２
		_SyuptTime2.DecimalBu = 0;
		//乗車地３
		_JyosyachiNm3.DecimalBu = 0;
		//出発時間３
		_SyuptTime3.DecimalBu = 0;
		//乗車地４
		_JyosyachiNm4.DecimalBu = 0;
		//出発時間４
		_SyuptTime4.DecimalBu = 0;
		//乗車地５
		_JyosyachiNm5.DecimalBu = 0;
		//出発時間５
		_SyuptTime5.DecimalBu = 0;
		//号車
		_Gousya.DecimalBu = 0;
		//ＮＯＳＨＯＷフラグ
		_NoShowFlg.DecimalBu = 0;
		//ＮＯＳＨＯＷ
		_NoShow.DecimalBu = 0;
		//予約区分
		_YoyakuKbn.DecimalBu = 0;
		//予約NO
		_YoyakuNo.DecimalBu = 0;
		//予約NOビュー
		_YoyakuNoView.DecimalBu = 0;
		//名前
		_YoyakuNm.DecimalBu = 0;
		//乗車人数（大人）
		_JyosyaNinzu1.DecimalBu = 0;
		//乗車人数（中人）
		_JyosyaNinzu2.DecimalBu = 0;
		//乗車人数（小人）
		_JyosyaNinzu3.DecimalBu = 0;
		//電話番号
		_TelNo1.DecimalBu = 0;
		//業者名
		_AgentNm.DecimalBu = 0;
		//申込者
		_Yykmks.DecimalBu = 0;
		//キャンセルフラグ
		_CancelFlg.DecimalBu = 0;
		//座席指定予約フラグ
		_ZasekiReserveYoyakuFlg.DecimalBu = 0;
		//発券内容
		_HakkenNaiyo.DecimalBu = 0;
		//状態
		_State.DecimalBu = 0;
		//状態ビュー
		_StateView.DecimalBu = 0;
		//座席
		_Zaseki.DecimalBu = 0;
		///************** 以下は固定項目 ***************/
		//登録ＰＧＭＩＤ
		_EntryPgmid.DecimalBu = 0;
		//登録者コード
		_EntryPersonCd.DecimalBu = 0;
		//登録日
		_EntryDate.DecimalBu = 0;
		//更新ＰＧＭＩＤ
		_UpdatePgmid.DecimalBu = 0;
		//更新者コード
		_UpdatePersonCd.DecimalBu = 0;
		//更新日
		_UpdateDate.DecimalBu = 0;
		//削除日
		_DeleteDate.DecimalBu = 0;

	}

	/// <summary>
	///	(検索項目)出発日
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_NumberType SyuptDay
	{
		get
		{
			return _SyuptDay;
		}
		set
		{
			_SyuptDay = value;
		}
	}

	/// <summary>
	///	(検索項目)乗車地コード
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_MojiType JyosyachiCd
	{
		get
		{
			return _JyosyachiCd;
		}
		set
		{
			_JyosyachiCd = value;
		}
	}

	/// <summary>
	///	コースコード
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_MojiType CrsCd
	{
		get
		{
			return _CrsCd;
		}
		set
		{
			_CrsCd = value;
		}
	}

	/// <summary>
	///	コース名
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_MojiType CrsName
	{
		get
		{
			return _CrsName;
		}
		set
		{
			_CrsName = value;
		}
	}

	/// <summary>
	///	乗車地１
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_MojiType JyosyachiNm1
	{
		get
		{
			return _JyosyachiNm1;
		}
		set
		{
			_JyosyachiNm1 = value;
		}
	}

	/// <summary>
	///	出発時間１
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_NumberType SyuptTime1
	{
		get
		{
			return _SyuptTime1;
		}
		set
		{
			_SyuptTime1 = value;
		}
	}

	/// <summary>
	///	乗車地２
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_MojiType JyosyachiNm2
	{
		get
		{
			return _JyosyachiNm2;
		}
		set
		{
			_JyosyachiNm2 = value;
		}
	}

	/// <summary>
	///	出発時間２
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_NumberType SyuptTime2
	{
		get
		{
			return _SyuptTime2;
		}
		set
		{
			_SyuptTime2 = value;
		}
	}

	/// <summary>
	///	乗車地３
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_MojiType JyosyachiNm3
	{
		get
		{
			return _JyosyachiNm3;
		}
		set
		{
			_JyosyachiNm3 = value;
		}
	}

	/// <summary>
	///	出発時間３
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_NumberType SyuptTime3
	{
		get
		{
			return _SyuptTime3;
		}
		set
		{
			_SyuptTime3 = value;
		}
	}







	/// <summary>
	///	乗車地４
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_MojiType JyosyachiNm4
	{
		get
		{
			return _JyosyachiNm4;
		}
		set
		{
			_JyosyachiNm4 = value;
		}
	}

	/// <summary>
	///	出発時間４
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_NumberType SyuptTime4
	{
		get
		{
			return _SyuptTime4;
		}
		set
		{
			_SyuptTime4 = value;
		}
	}


	/// <summary>
	///	乗車地５
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_MojiType JyosyachiNm5
	{
		get
		{
			return _JyosyachiNm5;
		}
		set
		{
			_JyosyachiNm5 = value;
		}
	}

	/// <summary>
	///	出発時間５
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_NumberType SyuptTime5
	{
		get
		{
			return _SyuptTime5;
		}
		set
		{
			_SyuptTime5 = value;
		}
	}



































	/// <summary>
	///	号車
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_NumberType Gousya
	{
		get
		{
			return _Gousya;
		}
		set
		{
			_Gousya = value;
		}
	}

	/// <summary>
	///	ＮＯＳＨＯＷフラグ
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_MojiType NoShowFlg
	{
		get
		{
			return _NoShowFlg;
		}
		set
		{
			_NoShowFlg = value;
		}
	}

	/// <summary>
	///	ＮＯＳＨＯＷ
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_MojiType NoShow
	{
		get
		{
			return _NoShow;
		}
		set
		{
			_NoShow = value;
		}
	}

	/// <summary>
	///	予約区分
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_MojiType YoyakuKbn
	{
		get
		{
			return _YoyakuKbn;
		}
		set
		{
			_YoyakuKbn = value;
		}
	}

	/// <summary>
	///	予約NO
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_NumberType YoyakuNo
	{
		get
		{
			return _YoyakuNo;
		}
		set
		{
			_YoyakuNo = value;
		}
	}

	/// <summary>
	///	予約NOビュー
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_NumberType YoyakuNoView
	{
		get
		{
			return _YoyakuNoView;
		}
		set
		{
			_YoyakuNoView = value;
		}
	}

	/// <summary>
	///	名前
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_MojiType YoyakuNm
	{
		get
		{
			return _YoyakuNm;
		}
		set
		{
			_YoyakuNm = value;
		}
	}

	/// <summary>
	///	乗車人数（大人）
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_NumberType JyosyaNinzu1
	{
		get
		{
			return _JyosyaNinzu1;
		}
		set
		{
			_JyosyaNinzu1 = value;
		}
	}

	/// <summary>
	///	乗車人数（中人）
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_NumberType JyosyaNinzu2
	{
		get
		{
			return _JyosyaNinzu2;
		}
		set
		{
			_JyosyaNinzu2 = value;
		}
	}

	/// <summary>
	///	乗車人数（小人）
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_NumberType JyosyaNinzu3
	{
		get
		{
			return _JyosyaNinzu3;
		}
		set
		{
			_JyosyaNinzu3 = value;
		}
	}

	/// <summary>
	///	電話番号
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_MojiType TelNo1
	{
		get
		{
			return _TelNo1;
		}
		set
		{
			_TelNo1 = value;
		}
	}

	/// <summary>
	///	業者名
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_MojiType AgentNm
	{
		get
		{
			return _AgentNm;
		}
		set
		{
			_AgentNm = value;
		}
	}

	/// <summary>
	///	申込者
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_MojiType Yykmks
	{
		get
		{
			return _Yykmks;
		}
		set
		{
			_Yykmks = value;
		}
	}

	/// <summary>
	///	キャンセルフラグ
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_MojiType CancelFlg
	{
		get
		{
			return _CancelFlg;
		}
		set
		{
			_CancelFlg = value;
		}
	}

	/// <summary>
	///	座席指定予約フラグ
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_MojiType ZasekiReserveYoyakuFlg
	{
		get
		{
			return _ZasekiReserveYoyakuFlg;
		}
		set
		{
			_ZasekiReserveYoyakuFlg = value;
		}
	}

	/// <summary>
	///	発券内容
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_MojiType HakkenNaiyo
	{
		get
		{
			return _HakkenNaiyo;
		}
		set
		{
			_HakkenNaiyo = value;
		}
	}

	/// <summary>
	///	状態
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_MojiType State
	{
		get
		{
			return _State;
		}
		set
		{
			_State = value;
		}
	}

	/// <summary>
	///	状態ビュー
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_MojiType StateView
	{
		get
		{
			return _StateView;
		}
		set
		{
			_StateView = value;
		}
	}

	/// <summary>
	///	座席
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_MojiType Zaseki
	{
		get
		{
			return _Zaseki;
		}
		set
		{
			_Zaseki = value;
		}
	}

	/// <summary>
	///	登録ＰＧＭＩＤ
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_MojiType EntryPgmid
	{
		get
		{
			return _EntryPgmid;
		}
		set
		{
			_EntryPgmid = value;
		}
	}

	/// <summary>
	///	登録者コード
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_MojiType EntryPersonCd
	{
		get
		{
			return _EntryPersonCd;
		}
		set
		{
			_EntryPersonCd = value;
		}
	}

	/// <summary>
	///	登録日
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_YmdType EntryDate
	{
		get
		{
			return _EntryDate;
		}
		set
		{
			_EntryDate = value;
		}
	}

	/// <summary>
	///	更新ＰＧＭＩＤ
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_MojiType UpdatePgmid
	{
		get
		{
			return _UpdatePgmid;
		}
		set
		{
			_UpdatePgmid = value;
		}
	}

	/// <summary>
	///	更新者コード
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_MojiType UpdatePersonCd
	{
		get
		{
			return _UpdatePersonCd;
		}
		set
		{
			_UpdatePersonCd = value;
		}
	}

	/// <summary>
	///	更新日
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_YmdType UpdateDate
	{
		get
		{
			return _UpdateDate;
		}
		set
		{
			_UpdateDate = value;
		}
	}

	//(TODO 型が共通と異なる)
	///' <summary>
	///'	削除日
	///' </summary>
	///' <value></value>
	///' <returns></returns>
	///' <remarks></remarks>
	//Public Property DeleteDate() As EntityKoumoku_MojiType
	//    Get
	//        Return _DeleteDate
	//    End Get
	//    Set(ByVal value As EntityKoumoku_MojiType)
	//        _DeleteDate = value
	//    End Set
	//End Property

	/// <summary>
	///	削除日
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_NumberType DeleteDate
	{
		get
		{
			return _DeleteDate;
		}
		set
		{
			_DeleteDate = value;
		}
	}

	#endregion

}