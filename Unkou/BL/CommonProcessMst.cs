using System.Text;
using Hatobus.ReservationManagementSystem.Master;


/// <summary>
/// マスタメンテナンス共通処理クラス
/// </summary>
public class CommonUnkouUtil
{

	/// <summary>
	/// WHERE文字列作成
	/// </summary>
	/// <param name="grd">対象Grid</param>
	/// <param name="keys">Key配列</param>
	public static string MakeWhere(FlexGridEx grd, string[] keys)
	{
		string whereString = "";
		FlexGridEx with_1 = grd;
		if (with_1.Row >= 0 && with_1.Rows.Count > 1)
		{
			foreach (string s in keys)
			{
				if (with_1.Item(with_1.Row, s).ToString() != string.Empty)
				{
					if (whereString != string.Empty)
					{
						whereString += " AND ";
					}
					whereString += s + " = '" + with_1.Item(with_1.Row, s).ToString() + "'";
				}
			}
		}

		return whereString;
	}

	/// <summary>
	/// コンボの共通的なプロパティ設定
	/// </summary>
	/// <param name="cmbParam"></param>
	/// <param name="dataSourceParram"></param>
	public static void setComboCommonProperty(ComboBoxEx cmbParam, DataTable dataSourceParram)
	{
		ComboBoxEx with_1 = cmbParam;
		with_1.DataSource = dataSourceParram;
		with_1.DropDown.AllowResize = false;
		with_1.ListHeaderPane.Visible = false;
		with_1.ListColumns(ComboBoxCdType.CODE_VALUE).Visible = false;
		with_1.ListColumns(ComboBoxCdType.CODE_NAME).Width = with_1.Width;
		with_1.TextSubItemIndex = ComboBoxCdType.CODE_NAME;

	}

	#region コンボボックス操作

	/// <summary>
	/// コンボボックスのデータ設定
	/// </summary>
	/// <param name="CdBunrui"></param>
	/// <param name="ComboName"></param>
	/// <param name="NullRecord"></param>
	/// <param name="arraySiireSakiShubetsu"></param>
	public static void setComboBox(CdBunruiType CdBunrui, ComboBoxEx ComboName, bool NullRecord, string[] arraySiireSakiShubetsu)
	{

		//パラメータ
		Hashtable paramInfoList = new Hashtable();

		//DataAccessクラス生成
		Code_DA dataAccess = new Code_DA();

		//戻り値
		DataTable returnValue = null;

		returnValue = dataAccess.GetCodeMasterData(System.Convert.ToString(CdBunrui), arraySiireSakiShubetsu, NullRecord);
		ComboName.DataSource = returnValue;
		ComboBoxEx with_1 = ComboName;
		with_1.ListColumns(ComboBoxCdType.CODE_NAME).Visible = true;
		with_1.ListColumns(ComboBoxCdType.CODE_NAME).Width = with_1.Width;
		with_1.ListColumns(ComboBoxCdType.CODE_VALUE).Visible = false;
		with_1.TextSubItemIndex = ComboBoxCdType.CODE_NAME;
		with_1.ValueSubItemIndex = ComboBoxCdType.CODE_VALUE;

	}
	#endregion


}