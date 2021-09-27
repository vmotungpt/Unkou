/// <summary>
/// 固定コード
/// </summary>
/// <remarks></remarks>
public sealed class FixedCdUnkou
{

	/// <summary>
	/// 発券内容
	/// </summary>
	/// <remarks></remarks>
	public enum HakkenNaiyo : int
	{
		[Value("全金")]
		zenkin = 1, //全金
		[Value("内金")]
		uchikin = 2, //内金
		[Value("残金")]
		zankin = 3 //残金
	}

	/// <summary>
	/// キャンセル区分
	/// </summary>
	/// <remarks></remarks>
	public enum CanceKbn : int
	{
		[Value("済(1:発券前)")]
		HakkenMaeCancel = 1, //済(1:発券前)
		[Value("済(2:発券後)")]
		HakkenGoCancel = 2 //済(2:発券後)
	}

	/// <summary>
	/// 通知方法[仕入先]値の内容
	/// </summary>
	/// <remarks></remarks>
	public enum NotificationHohoKoshaRenraku : int
	{
		[Value("メール")]
		Mail = 1,
		[Value("FAX")]
		Fax = 2,
		[Value("TEL")]
		Tel = 3
	}

}