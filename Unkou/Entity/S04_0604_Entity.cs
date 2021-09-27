using Oracle.ManagedDataAccess.Client;



/// <summary>
/// ピックアップルート台帳 （ホテル）
/// </summary>
/// <remarks></remarks>
[Serializable()]
public class S04_0604_Entity // ピックアップルート台帳 （ホテル）エンティティ
{


	private EntityKoumoku_NumberType _syuptDay = new EntityKoumoku_NumberType(); // 出発日
	private EntityKoumoku_MojiType _pickupRouteCd = new EntityKoumoku_MojiType(); // ピックアップルートコード
	private EntityKoumoku_YmdType _startDay = new EntityKoumoku_YmdType(); // 開始日
	private EntityKoumoku_MojiType _pickupHotelCd = new EntityKoumoku_MojiType(); // ピックアップホテルコード
	private EntityKoumoku_NumberType _syuptTime = new EntityKoumoku_NumberType(); // 出発時間
	private EntityKoumoku_NumberType _ninzu = new EntityKoumoku_NumberType(); // 乗車人数
	private EntityKoumoku_MojiType _systemEntryPgmid = new EntityKoumoku_MojiType(); // システム登録ＰＧＭＩＤ
	private EntityKoumoku_MojiType _systemEntryPersonCd = new EntityKoumoku_MojiType(); // システム登録者コード
	private EntityKoumoku_YmdType _systemEntryDay = new EntityKoumoku_YmdType(); // システム登録日
	private EntityKoumoku_MojiType _systemUpdatePgmid = new EntityKoumoku_MojiType(); // システム更新ＰＧＭＩＤ
	private EntityKoumoku_MojiType _systemUpdatePersonCd = new EntityKoumoku_MojiType(); // システム更新者コード
	private EntityKoumoku_YmdType _systemUpdateDay = new EntityKoumoku_YmdType(); // システム更新日


	public S04_0604_Entity()
	{
		_syuptDay.PhysicsName = "SYUPT_DAY";
		_pickupRouteCd.PhysicsName = "PICKUP_ROUTE_CD";
		_startDay.PhysicsName = "START_DAY";
		_pickupHotelCd.PhysicsName = "PICKUP_HOTEL_CD";
		_syuptTime.PhysicsName = "SYUPT_TIME";
		_ninzu.PhysicsName = "NINZU";
		_systemEntryPgmid.PhysicsName = "SYSTEM_ENTRY_PGMID";
		_systemEntryPersonCd.PhysicsName = "SYSTEM_ENTRY_PERSON_CD";
		_systemEntryDay.PhysicsName = "SYSTEM_ENTRY_DAY";
		_systemUpdatePgmid.PhysicsName = "SYSTEM_UPDATE_PGMID";
		_systemUpdatePersonCd.PhysicsName = "SYSTEM_UPDATE_PERSON_CD";
		_systemUpdateDay.PhysicsName = "SYSTEM_UPDATE_DAY";


		_syuptDay.Required = false;
		_pickupRouteCd.Required = false;
		_startDay.Required = false;
		_pickupHotelCd.Required = false;
		_syuptTime.Required = false;
		_ninzu.Required = false;
		_systemEntryPgmid.Required = true;
		_systemEntryPersonCd.Required = true;
		_systemEntryDay.Required = true;
		_systemUpdatePgmid.Required = true;
		_systemUpdatePersonCd.Required = true;
		_systemUpdateDay.Required = true;


		_syuptDay.DBType = OracleDbType.Decimal;
		_pickupRouteCd.DBType = OracleDbType.Char;
		_startDay.DBType = OracleDbType.Date;
		_pickupHotelCd.DBType = OracleDbType.Char;
		_syuptTime.DBType = OracleDbType.Decimal;
		_ninzu.DBType = OracleDbType.Decimal;
		_systemEntryPgmid.DBType = OracleDbType.Char;
		_systemEntryPersonCd.DBType = OracleDbType.Varchar2;
		_systemEntryDay.DBType = OracleDbType.Date;
		_systemUpdatePgmid.DBType = OracleDbType.Char;
		_systemUpdatePersonCd.DBType = OracleDbType.Varchar2;
		_systemUpdateDay.DBType = OracleDbType.Date;


		_syuptDay.IntegerBu = 8;
		_pickupRouteCd.IntegerBu = 6;
		_startDay.IntegerBu = 0;
		_pickupHotelCd.IntegerBu = 6;
		_syuptTime.IntegerBu = 4;
		_ninzu.IntegerBu = 3;
		_systemEntryPgmid.IntegerBu = 8;
		_systemEntryPersonCd.IntegerBu = 20;
		_systemEntryDay.IntegerBu = 0;
		_systemUpdatePgmid.IntegerBu = 8;
		_systemUpdatePersonCd.IntegerBu = 20;
		_systemUpdateDay.IntegerBu = 0;


		_syuptDay.DecimalBu = 0;
		_pickupRouteCd.DecimalBu = 0;
		_startDay.DecimalBu = 0;
		_pickupHotelCd.DecimalBu = 0;
		_syuptTime.DecimalBu = 0;
		_ninzu.DecimalBu = 0;
		_systemEntryPgmid.DecimalBu = 0;
		_systemEntryPersonCd.DecimalBu = 0;
		_systemEntryDay.DecimalBu = 0;
		_systemUpdatePgmid.DecimalBu = 0;
		_systemUpdatePersonCd.DecimalBu = 0;
		_systemUpdateDay.DecimalBu = 0;
	}


	/// <summary>
	/// syuptDay
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_NumberType syuptDay
	{
		get
		{
			return _syuptDay;
		}
		set
		{
			_syuptDay = value;
		}
	}


	/// <summary>
	/// pickupRouteCd
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_MojiType pickupRouteCd
	{
		get
		{
			return _pickupRouteCd;
		}
		set
		{
			_pickupRouteCd = value;
		}
	}


	/// <summary>
	/// startDay
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_YmdType startDay
	{
		get
		{
			return _startDay;
		}
		set
		{
			_startDay = value;
		}
	}


	/// <summary>
	/// pickupHotelCd
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_MojiType pickupHotelCd
	{
		get
		{
			return _pickupHotelCd;
		}
		set
		{
			_pickupHotelCd = value;
		}
	}


	/// <summary>
	/// syuptTime
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_NumberType syuptTime
	{
		get
		{
			return _syuptTime;
		}
		set
		{
			_syuptTime = value;
		}
	}


	/// <summary>
	/// ninzu
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_NumberType ninzu
	{
		get
		{
			return _ninzu;
		}
		set
		{
			_ninzu = value;
		}
	}


	/// <summary>
	/// systemEntryPgmid
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_MojiType systemEntryPgmid
	{
		get
		{
			return _systemEntryPgmid;
		}
		set
		{
			_systemEntryPgmid = value;
		}
	}


	/// <summary>
	/// systemEntryPersonCd
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_MojiType systemEntryPersonCd
	{
		get
		{
			return _systemEntryPersonCd;
		}
		set
		{
			_systemEntryPersonCd = value;
		}
	}


	/// <summary>
	/// systemEntryDay
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_YmdType systemEntryDay
	{
		get
		{
			return _systemEntryDay;
		}
		set
		{
			_systemEntryDay = value;
		}
	}


	/// <summary>
	/// systemUpdatePgmid
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_MojiType systemUpdatePgmid
	{
		get
		{
			return _systemUpdatePgmid;
		}
		set
		{
			_systemUpdatePgmid = value;
		}
	}


	/// <summary>
	/// systemUpdatePersonCd
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_MojiType systemUpdatePersonCd
	{
		get
		{
			return _systemUpdatePersonCd;
		}
		set
		{
			_systemUpdatePersonCd = value;
		}
	}


	/// <summary>
	/// systemUpdateDay
	/// </summary>
	/// <value></value>
	/// <returns></returns>
	/// <remarks></remarks>
	public EntityKoumoku_YmdType systemUpdateDay
	{
		get
		{
			return _systemUpdateDay;
		}
		set
		{
			_systemUpdateDay = value;
		}
	}


}