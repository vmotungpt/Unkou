using GrapeCity.Enterprise.Data.VisualBasicReplacement;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Unkou.Common
{
	public class CommonDateUtil
	{
		#region 変数/定数
		protected OracleParameter[] _setParameterList;
		//protected DataAccess _clsDataAccess;
		private const string LogGamenName = "Oracle";
		private OracleConnection _oracleConnection = null;
		private bool _logErr = false;
		//private DataAccess _dataAccess = new DataAccess();

		//日時フォーマット（日本版）
		public const string JPTime = "yyyy年MM月dd日"; //例　2018年09月11日
		public const string JPTime_Short = "yyyy年M月d日"; //例　2018年9月1日
		public const string NormalTime_JP = "yyyy/MM/dd"; //例　2018/09/11
		public const string NormalTime_JP_Short = "yyyy/M/d"; //例　2018/9/1
		public const string JPWareki = "gy年MM月dd日"; //例　平成30年09月11日
		public const string JPWareki_Short = "gy年M月d日"; //例　平成30年9月1日

		//日時フォーマット（アメリカ版）
		public const string NormalTime_US = "d"; //例　12/05/2000
		public const string NormalTime_US_plus = "D"; //例　Friday, May 12, 2000
		#endregion

		#region メソッド
		/// <summary>
		/// 引数で渡された日付From、日付Toの大小関係をチェックする
		/// </summary>
		/// <param name="_fromDate">日付 Date(yyyymmdd)</param>
		/// <param name="_toDate">日付To Date(yyyymmdd)</param>
		/// <returns>True：OK False:NG</returns>
		public static bool chkDayFromTo(DateTime _fromDate, DateTime _toDate)
		{
			//比較結果を保持する変数
			//0未満は_toDateが大きい　0は同じ日　1以上は_fromDateが大きい
			int check = DateTime.Compare(_fromDate, _toDate);
			if (check > 0)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		/// <summary>
		/// 日付評価
		/// 数値または文字列の「yyyymmdd」が日付として正しいか評価する
		/// </summary>
		/// <param name="_date">日数 String</param>
		/// <returns>True：OK　False：NG</returns>
		public static bool isDateYYYYMMDD(string _date)
		{
			//判定用変数
			DateTime dt;
			//Date型に変換できるか判断
			if (DateTime.TryParse(_date, out dt))
			{
				return true;
			}
			//文字の長さが8以外のものはFalseを返す
			if (_date.Length == 8)
			{
				//nop
			}
			else
			{
				return false;
			}
			//文字が数字以外だったらFalse
			if (Information.IsNumeric(_date))
			{
				//nop
			}
			else
			{
				return false;
			}
			//範囲チェック準備(年月日の切り出し)
			string year = _date.Substring(0, 4);
			int _year = int.Parse(year);
			string month = _date.Substring(4, 2);
			int _month = int.Parse(month);
			string day = _date.Substring(6, 2);
			int _day = int.Parse(day);
			//月範囲チェック（01 - 12）
			if (_month <= 12 & _month >= 1)
			{
				//nop
			}
			else
			{
				return false;
			}
			//日範囲チェック（01 - 31）
			if (_month == 2) //2月の場合
			{
				int leapYear = 28;
				//うるう年か判定 うるう年の場合は29日をleapYearに入れる
				if (_year % 4 == 0)
				{
					if (_year % 100 == 0)
					{
						if (_year % 400 == 0)
						{
							leapYear = 29;
						}
					}
					else
					{
						leapYear = 29;
					}
				}
				//日付がleapYear以内か
				if (_day <= leapYear)
				{
					//nop
				}
				else
				{
					return false;
				}
			}
			else if (_month == 4 || _month == 6 || _month == 9 || _month == 11) //4,6,9,11月の場合
		{
				if (_day <= 30 & _day >= 1)
				{
					//nop
				}
				else
				{
					return false;
				}
			}
		else //1,3,5,7,8,10,12月の場合
			{
				if (_day <= 31 & _day >= 1)
				{
					//nop
				}
				else
				{
					return false;
				}
			}
			//isDate関数を用いて正しいかチェック
			if (Information.IsDate(_year + "/" + System.Convert.ToString(_month) + "/" + System.Convert.ToString(_day)))
			{
				//nop
			}
			else
			{
				return false;
			}
			//最後まで通ったらTrueを返す
			return true;
		}

		/// <summary>
		/// 日付フォーマット変換
		/// 数値または文字列の「yyyymmdd」を「yyyy/mm/dd」や「yyyy年mm月dd日」に変換する
		/// </summary>
		/// <param name="_date">日付 String</param>
		/// <param name="_format">変換フォーマット指定（フォーマット形式はクラスのフィールドで保持）</param>
		/// <returns>変換文字列</returns>
		public static string convertDateFormat(string _date, string _format)
		{
			//引数1をDateに変換
			string year = _date.Substring(0, 4);
			int _year = int.Parse(year);
			string month = _date.Substring(4, 2);
			int _month = int.Parse(month);
			string day = _date.Substring(6, 2);
			int _day = int.Parse(day);
			DateTime time = new DateTime(_year, _month, _day, 0, 0, 0, 0);
			//カルチャ設定
			System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("ja-JP", false);
			//和暦対応
			if (_format.Contains("g"))
			{
				culture.DateTimeFormat.Calendar = new System.Globalization.JapaneseCalendar();
			}
			//リターン用変数
			string output = time.ToString(_format, culture);
			//リターン
			return output;
		}

		#region chkDayConversion
		/// <summary>
		/// 引数で渡された日付の変換を行う
		/// </summary>
		/// <param name="_date">日付　String</param>
		/// <param name="_processKbn">処理区分　String</param>
		/// <param name="_days">日数　String</param>
		/// <returns></returns>
		public static string chkDayConversion(string _date, string _processKbn, string _days)
		{
			if (_processKbn == "06") //処理区分が6だったら
			{
				//FromAnnualAccumulatedDay（積算日から戻す）
				return convertFromAnnualAccumulatedDay(_date);
			}
			else if (_processKbn == "04") //処理区分が4だったら
			{
				//DateChangeForNumberメソッドの実行　（数字変換） パス
				return convertDateForNumber(_date);
			}
			else //処理区分が6,4以外なら
			{
				//_dateを年月日に分解し数値に変換
				int days = 0;
				if (!(_days.Equals("") || ReferenceEquals(_days, null)))
				{
					//進める日にちを数値に変換
					days = int.Parse(_days);
				}
				string year = _date.Substring(0, 4);
				int _year = int.Parse(year);
				string month = _date.Substring(4, 2);
				int _month = int.Parse(month);
				string day = _date.Substring(6, 2);
				int _day = int.Parse(day);
				//Date型変数生成
				DateTime _ymd = new DateTime(_year, _month, _day);
				if (_processKbn == "03") //処理区分が3だったら
				{
					//DateChangeForEnglishメソッドの実行　（英語変換）
					return convertDateForEnglish(_ymd);
				}
				else if (_processKbn == "05") //処理区分が5だったら
				{
					//ToAnnualAccumulatedDayメソッドの実行　（積算日計算）
					return calculationToAnnualAccumulatedDay(_ymd);
				}
				else if (_processKbn == "11") //処理区分が11だったら
				{
					//第三引数の日付をDate型に変換
					string year2 = _days.Substring(0, 4);
					int _year2 = int.Parse(year2);
					string month2 = _days.Substring(4, 2);
					int _month2 = int.Parse(month2);
					string day2 = _days.Substring(6, 2);
					int _day2 = int.Parse(day2);
					DateTime _ymd2 = new DateTime(_year2, _month2, _day2);
					//HowManyDaysメソッドの実行　（日数計算）
					return acquisitionOfDays(_ymd, _ymd2);
				}
				else if (_processKbn == "12") //処理区分が12だったら
				{
					//DaysCalcメソッドの実行　（日数加算）
					return calculationAfterNDays(_ymd, days);
				}
				else if (_processKbn == "13") //処理区分が13だったら
				{
					//MonthCalcメソッドの実行　(月加算)
					return calculationAfterNMonths(_ymd, days);
				}
				else if (_processKbn == "14") //処理区分が14だったら
				{
					//LastDayメソッドの実行　(月末最終日を返す)
					return getEndOfTheMonth(_ymd);
				}
				else if (_processKbn == "15") //処理区分が15だったら
				{
					//DayOfTheWeekメソッドの実行(曜日を返す)
					return getDayOfTheWeek(_ymd);
				}
				else
				{
					//その他の初期区分のときは空文字を返す
					return "";
				}
			}
		}

		/// <summary>
		/// 渡されたDate型の数字日付を英語に変換する
		/// </summary>
		/// <param name="_date">日付　Date型</param>
		/// <returns>変換後の日付 String型</returns>
		public static string convertDateForEnglish(DateTime _date)
		{
			//英語表記の日時に変換
			System.Globalization.CultureInfo english = new System.Globalization.CultureInfo("en-US");
			//年月日のみを返却
			return _date.ToString("D", english);
		}

		/// <summary>
		/// 渡されたString型の英語日付を数字に変換する
		/// </summary>
		/// <param name="_date">日付　String型(曜日, 月 日付, 年 →例：Friday, May 12, 2002)</param>
		/// <returns>変換後の日付　String型(yyyymmdd)</returns>
		public static string convertDateForNumber(string _date)
		{
			//_dateをカンマで分割
			string[] _english = _date.Split(',');
			//月と日の部分を取得
			string _work = _english[1];
			//workを空白で分割
			string[] _english_sub = _work.Split(' ');
			//英語表記の月一覧
			string[] _monthList = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
			//カウンタ（月をあらわす)
			int counter = 0;
			//どの月か判定する
			foreach (string month in _monthList)
			{
				counter++;
				//_monthListと_english_sub(1)が一緒ならブレイクする
				if (month.Equals(_english_sub[1]))
				{
					break;
				}
			}
			//日付の取得
			int _work2 = int.Parse(System.Convert.ToString(_english_sub[2].Replace(" ", "")));
			//YYYYMMDDの形に成型してリターン
			return _english[2].Replace(" ", "") + counter.ToString("00") + _work2.ToString("00");
		}

		/// <summary>
		/// 日付から年間積算日を計算します
		/// </summary>
		/// <param name="_date">日付　Date型</param>
		/// <returns>通算積算日(YYYYDDD) String型</returns>
		public static string calculationToAnnualAccumulatedDay(DateTime _date)
		{
			//_dateから年を取得
			string year = _date.Year.ToString("0000");
			//_dateから日を取得
			string day = _date.DayOfYear.ToString("000");
			//YYYYDDDの形で返却
			return year + day;
		}

		/// <summary>
		/// 年間積算日から通常の日付形式(YYYYMMDD)に変換します
		/// </summary>
		/// <param name="_date"></param>
		/// <returns></returns>
		public static string convertFromAnnualAccumulatedDay(string _date)
		{
			//年の取得
			string year = _date.Substring(0, 4);
			int _year = int.Parse(year);
			//積算日の取得
			string day = _date.Substring(4, 3);
			int _day = int.Parse(day);
			//うるう年の考慮
			int _february = 0;
			if (_year % 4 == 0)
			{
				if (_year % 100 == 0)
				{
					if (_year % 400 == 0)
					{
						_february = 29;
					}
					else
					{
						_february = 28;
					}
				}
				else
				{
					_february = 29;
				}
			}
			else
			{
				_february = 28;
			}
			//一年の日数を保持する配列
			int[] _yearDays = new int[] { 31, _february, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
			//計算用変数
			int work = _day;
			//計算用　カウンタ 月を保持する
			int counterMonth = 0;
			//計算用　カウンタ 日を保持する
			int counterDay = 0;
			//計算部　workから順番に各月の日数を引いていき、月と日数を割り出す
			while (work > 0) //0より大きい間継続
			{
				//月を加算する
				counterMonth++;
				//workから日数を引く
				work = work - _yearDays[counterMonth - 1];
				//もしworkが0以下になったら
				if (work <= 0)
				{
					//counterDayにworkに引いた分を戻したものを代入する
					counterDay = work + _yearDays[counterMonth - 1];
				}
			}
			//年月日の形に整形しリターンする
			return year + counterMonth.ToString("00") + counterDay.ToString("00");
		}

		/// <summary>
		/// n日後の日付を返します
		/// 第二引数にマイナス値を入れることでn日前も計算できます。
		/// </summary>
		/// <param name="_date">基準日　Date型</param>
		/// <param name="_days">進める日にち　Integer型</param>
		/// <returns>基準日から進めた日付 YYYYMMDD</returns>
		public static string calculationAfterNDays(DateTime _date, int _days)
		{
			//日数加算結果保持用変数
			System.DateTime day = _date.AddDays(_days);
			//日数を加算し、YYYYMMDDの形式で保持する変数
			string output = day.Year.ToString("0000") + day.Month.ToString("00") + day.Day.ToString("00");
			//output返却
			return output;
		}

		/// <summary>
		/// n月後の日付を返します
		/// 第二引数にマイナス値を入れることでnヶ月前も計算できます。
		/// </summary>
		/// <param name="_date">基準日　Date型</param>
		/// <param name="_months">進める月数</param>
		/// <returns>日付　String型</returns>
		public static string calculationAfterNMonths(DateTime _date, int _months)
		{
			//月数を加算し、YYY/MM/DDの形式で保持する変数
			DateTime stock = System.Convert.ToDateTime(_date.AddMonths(_months).ToShortDateString());
			string output = stock.Year.ToString() + stock.Month.ToString("00") + stock.Day.ToString("00");
			//output返却
			return output;
		}

		/// <summary>
		/// 月末の日付を取得します
		/// </summary>
		/// <param name="_date">日付　Date型</param>
		/// <returns>月末の日付　String型</returns>
		public static string getEndOfTheMonth(DateTime _date)
		{
			//月を取得
			int _month = int.Parse(_date.Month.ToString());
			//年を取得
			int _year = int.Parse(_date.Year.ToString());
			//日数が31日の月か判定（1,3,5,7,8,10,12月)
			if (_month == 1 || _month == 3 || _month == 5 || _month == 7 || _month == 8 || _month == 10 || _month == 12)
			{
				return "31";
			}
			else if (_month == 2) //2月を考慮
			{
				//うるう年考慮
				if (_year % 4 == 0)
				{
					if (_year % 100 == 0)
					{
						if (_year % 400 == 0)
						{
							return "29";
						}
						else
						{
							return "28";
						}
					}
					else
					{
						return "29";
					}
				}
				else
				{
					return "28";
				}
			}
			else //日数が30日の月(4,6,9,11月）
			{
				return "30";
			}
		}

		/// <summary>
		/// 曜日を取得
		/// </summary>
		/// <param name="_date">日付　Date型</param>
		/// <returns>曜日　String型</returns>
		public static string getDayOfTheWeek(DateTime _date)
		{
			return _date.ToString("dddd");
		}

		/// <summary>
		/// 第一引数と第二引数の日数を返します
		/// </summary>
		/// <param name="_ymd">比較元の日付　Date型</param>
		/// <param name="_ymd2">比較先の日付　Date型</param>
		/// <returns>日数　String</returns>
		public static string acquisitionOfDays(DateTime _ymd, DateTime _ymd2)
		{
			//第一引数に比べて第二引数が前か後か判定します
			int result = _ymd.CompareTo(_ymd2);
			//リターン用変数
			string output = "";
			//時間削除用正規表現
			string regex = "[.].*";
			//正規表現を扱うためのインスタンスを生成
			Regex rgx = new Regex(regex);
			if (result == 0)
			{
				//_ymdと_ymd2が同じ場合
				return "0";
			}
			else if (result < 0)
			{
				//_ymd2が後の場合
				output = System.Convert.ToString(rgx.Replace(_ymd2.Subtract(_ymd).ToString(), ""));
			}
			else
			{
				//_ymdが後の場合
				output = System.Convert.ToString(rgx.Replace(_ymd.Subtract(_ymd2).ToString(), ""));
			}
			//outputを返却
			return output;
		}
		#endregion

		/// <summary>
		/// はと年度取得
		/// 渡された引数を基に、はと年度を計算する
		/// </summary>
		/// <param name="_standardDay">基準日　Date型</param>
		/// <returns>はと年度　Date型</returns>
		public static DateTime getHatoYear(DateTime _standardDay)
		{

			//年 (year) を取得する
			int year = _standardDay.Year;
			//月（month）を取得する
			int month = _standardDay.Month;

			if (month < 7)
			{
				//基準日の月が7月より前の月だったら年を-1した値を返す
				return _standardDay.AddYears(-1);
			}
			else
			{
				return _standardDay;
			}
		}

		/// <summary>
		/// 引数で渡された内容により年齢を返却する。
		/// </summary>
		/// <param name="birthDay">生年月日  Date（yyyyMMdd）</param>
		/// <param name="kijunDay">基準日  Date（yyyyMMdd）</param>
		/// <returns>年齢　String型</returns>
		public static string getAge(DateTime birthDay, DateTime kijunDay)
		{
			//年齢を計算する
			int age = kijunDay.Year - birthDay.Year;
			//誕生日がまだ来ていなければ、1年引く
			if (kijunDay.Month < birthDay.Month || (kijunDay.Month == birthDay.Month && kijunDay.Day < birthDay.Day))
			{
				age--;
			}
			//返却
			return age.ToString();
		}

		/// <summary>
		/// DBサーバの時間を取得します。
		/// </summary>
		/// <returns>日時　Date型</returns>
		public static DateTime getSystemTime()
		{
			//SQL実行
			CommonDaProcess getTable = new CommonDaProcess();
			DataTable table = null;
			table = getTable.getDbSysTime();
			//処理用変数
			DateTime ymd = System.Convert.ToDateTime(table.Rows[0].ItemArray.ToString().Replace("-", "/"));
			//リターン
			return ymd;
		}

		/// <summary>
		/// 月跨りチェック
		/// 入力した日付が月を跨った場合エラーとする
		/// </summary>
		/// <returns>True:エラー有 False:エラー無</returns>
		/// <remarks></remarks>
		public static bool isNotSameMonthDateFromTo(DateTime? FromDateText, DateTime? ToDateText)
		{
			bool returnValue = false;
			if (FromDateText != null && ToDateText != null
				&& ((System.Convert.ToDateTime(ToDateText).Year != System.Convert.ToDateTime(FromDateText).Year)
				|| (System.Convert.ToDateTime(ToDateText).Month != System.Convert.ToDateTime(FromDateText).Month)))
		{
				return true;
			}
			return returnValue;
		}

		/// <summary>
		/// 必須日
		/// </summary>
		/// <param name="DateText"></param>
		/// <returns>True:エラー有 False:エラー無</returns>
		public static bool IsEmptyDate(DateTime? DateText)
		{
			bool returnValue = false;
			if (ReferenceEquals(DateText, null))
			{
				return true;
			}
			return returnValue;
		}

		/// <summary>
		/// 明日以降の日付を入力した場合エラーとする
		/// </summary>
		/// <param name="DateText"></param>
		/// <returns>True:エラー有 False:エラー無</returns>
		public static bool IsFutureDate(DateTime? DateText)
		{
			bool returnValue = false;
			if (DateText != null && DateText > getSystemTime())
		{
				return true;
			}
			return returnValue;
		}

		/// <summary>
		/// 前月１日より前の日付を指定した場合エラーとする
		/// </summary>
		/// <param name="DateText"></param>
		/// <returns>True:エラー有 False:エラー無</returns>
		public static bool IsPastDate(DateTime? DateText)
		{
			bool returnValue = false;
			DateTime currentDate = getSystemTime();
			if (DateText != null && DateText < new DateTime(currentDate.AddMonths(-1).Year, currentDate.AddMonths(-1).Month, 1))
		{
				return true;
			}
			return returnValue;
		}
		#endregion

		#region ログ関連
		/// <summary>
		/// Oracleエラーのログ出力
		/// </summary>
		/// <param name="ex">エラー情報</param>
		/// <remarks></remarks>
		private void errLogOut(Exception ex, string sql)
		{
			string[] strErr;
			bool blnLogErr;

			if (ex is OracleException)
			{
				strErr = new string[] { ((OracleException)ex).Number.ToString(), ex.Message, ((OracleException)ex).Procedure, sql };
			}
			else
			{
				strErr = new string[] { ex.Message, ex.Source, ex.StackTrace };
			}

		}

		#endregion
	}
}
