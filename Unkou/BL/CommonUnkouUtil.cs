using System.Text;


/// <summary>
/// 共通処理
/// </summary>
/// <remarks></remarks>
public sealed class CommonProcessMst
{

	//#Region "変数"
	//    Private clsMessageOut As New MessageOut()
	//    Public XmlFilePath As String
	//    Public XmlFilePath_Guide As String
	//    Public DataStudioId As String = Nothing
	//    Public DataStudioPassword As String = Nothing
	//    Public ExclusionMojiCd As String = String.Empty      'AS用
	//#End Region

	//#Region "メッセージ関連"
	//    Public Function createFactoryMsg() As MessageOut
	//        If XmlFilePath = Nothing Then
	//            XmlFilePath = System.IO.Directory.GetCurrentDirectory
	//        End If
	//        If XmlFilePath_Guide = Nothing Then
	//            XmlFilePath_Guide = System.IO.Directory.GetCurrentDirectory
	//        End If
	//        clsMessageOut.XmlFilePath = XmlFilePath
	//        clsMessageOut.XmlFilePath_Guide = XmlFilePath_Guide
	//        Return clsMessageOut
	//    End Function
	//#End Region

	//#Region " テキストボックス関連 "

	//#Region " AS400_OpenFieldのための文字列チェック処理 "
	//    ''' <summary>
	//    ''' 'AS/400用の文字列のバイト数チェック
	//    ''' </summary>
	//    ''' <param name="pChkString"></param>
	//    ''' <returns></returns>
	//    ''' <remarks></remarks>
	//    Public Function chkByteForAS400(ByVal pChkString As String) As Integer

	//        Dim totalByte As Integer = 0     '引数である文字列のバイト数
	//        Dim beforeCharByte As Integer = 1       '1:半角/2:全角（バイト数）
	//        Dim strChar As String
	//        Dim charByte As Integer

	//        For i As Integer = 1 To pChkString.Length
	//            strChar = Mid(pChkString, i, 1)
	//            charByte = LenB(strChar)
	//            If charByte <> beforeCharByte Then
	//                totalByte = totalByte + 1
	//            End If

	//            totalByte = totalByte + charByte
	//            beforeCharByte = charByte
	//        Next

	//        If beforeCharByte = 2 Then
	//            totalByte = totalByte + 1
	//        End If

	//        Return totalByte

	//    End Function

	//    ''' <summary>バイト数を取得</summary>
	//    Public Function LenB(ByVal stTarget As String) As Integer
	//        Return System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(stTarget)
	//    End Function

	//    ''' <summary>Mid関数のバイト版。文字数と位置をバイト数で指定して文字列を切り抜く。</summary>
	//    ''' <param name="_str">対象の文字列</param>
	//    ''' <param name="_Start">切り抜き開始位置。全角文字を分割するよう位置が指定された場合、戻り値の文字列の先頭は意味不明の半角文字となる。</param>
	//    ''' <param name="_Length">切り抜く文字列のバイト数</param>
	//    ''' <returns>切り抜かれた文字列</returns>
	//    ''' <remarks>最後の１バイトが全角文字の半分になる場合、その１バイトは無視される。</remarks>
	//    Public Function midForAS400(ByVal _str As String, ByVal _Start As Integer, Optional ByVal _Length As Integer = 0) As String
	//        Dim _totalByte As Integer = 0               '引数である文字列のバイト数
	//        Dim _beforeCharByte As Integer = 1          '1:半角/2:全角（バイト数）
	//        Dim _strChar As String = String.Empty       '引数である文字列の1文字を格納
	//        Dim _charByte As Integer = 0                '_strCharのバイト数を格納
	//        Dim _ShiftCode As Integer = 1               'シフトコードバイト数を保持（固定）
	//        Dim _ShiftOutCode As Integer = 0            'シフトアウトコードを格納
	//        Dim _returnValue As String = String.Empty   '戻り値を格納

	//        If _str = "" Then
	//            Return ""
	//        End If

	//        For _charCnt As Integer = 1 To _str.Length
	//            _strChar = Mid(_str, _charCnt, 1)
	//            _charByte = LenB(_strChar)
	//            If _charByte <> _beforeCharByte Then
	//                '全角⇔半角切替時↓
	//                _totalByte = _totalByte + _ShiftCode + _charByte
	//            Else
	//                '全角または半角連続↓
	//                _totalByte = _totalByte + _charByte
	//            End If

	//            '前回バイト数保持↓
	//            _beforeCharByte = _charByte

	//            If _charByte = 2 Then
	//                '全角文字＝ShiftOutを加味↓
	//                _ShiftOutCode = 1
	//            Else
	//                _ShiftOutCode = 0
	//            End If

	//            If (_totalByte + _ShiftOutCode) <= _Length Then
	//                '指定バイト数以内↓
	//                _returnValue &= _strChar
	//            Else
	//                '指定バイト数以上↓
	//                Exit For
	//            End If
	//        Next

	//        Return _returnValue

	//    End Function
	//#End Region

	//#Region " JIS変換チェック処理"
	//    ''' <summary>JISへ変換可能かチェックする</summary>
	//    Public Function sjisCheck(ByVal checkString As String) As String
	//        Dim errString As String = String.Empty
	//        Dim chgbyte() As Byte
	//        Dim chgStatus As Boolean
	//        Dim enc As Encoding

	//        'SHIFT-JISへの変換
	//        '変換不可文字はExceptionを発生させる
	//        enc = Encoding.GetEncoding("shift_jis", New EncoderExceptionFallback, New DecoderExceptionFallback)

	//        For Each c As Char In checkString
	//            chgStatus = False
	//            Try
	//                chgbyte = enc.GetBytes(c)
	//                'VB.NETでのshift(-jisはMS932のため純粋なSHIFT-JISの対応外をチェックする)
	//                If chgbyte.Length = 1 Then
	//                    Select Case chgbyte(0)
	//                        Case Is <= &HDF
	//                            chgStatus = True
	//                    End Select
	//                Else
	//                    Dim num As Integer = chgbyte(0)
	//                    num = num << 8
	//                    num = num Or chgbyte(1)
	//                    Select Case num
	//                        Case &H8740 To &H879E   '13区
	//                            '一部IBM拡張文字は許可する(ASはSHIFT-JIS+IBM拡張
	//                            If (&H8754 <= num And num <= &H875D) _
	//                            OrElse num = &H8782 _
	//                            OrElse num = &H8784 _
	//                            OrElse num = &H878A Then
	//                                chgStatus = True
	//                            End If
	//                        Case &HED40 To &HED9E   '89区
	//                        Case &HED9F To &HEDFC   '90区
	//                        Case &HEE40 To &HEE9E   '91区
	//                        Case &HEE9F To &HEEFC   '92区
	//                            'Case &HFA40 To &HFA9E   '115区
	//                            'Case &HFA9F To &HFAFC   '116区
	//                            'Case &HFB40 To &HFB9E   '117区
	//                            'Case &HFB9F To &HFBFC   '118区
	//                            'Case &HFC40 To &HFC4B   '119区
	//                        Case &HFA40 To &HFC4B   '115区～119区
	//                            If (&HFA55 <> num) Then
	//                                chgStatus = True
	//                            End If
	//                        Case Else
	//                            chgStatus = True
	//                    End Select
	//                End If
	//                If chgStatus = False Then
	//                    errString += c
	//                Else
	//                    If ExclusionMojiCd.IndexOf(c) <> -1 Then
	//                        errString += c
	//                    End If
	//                End If
	//            Catch ex As Exception
	//                errString += c
	//            End Try
	//        Next

	//        Return errString

	//    End Function

	//    ''' <summary>unicode⇒shift-jisへ変換可能かチェックする</summary>
	//    Public Function unicodeCheck(ByVal checkString As String) As String
	//        Dim errString As String = String.Empty
	//        Dim chgbyte() As Byte
	//        Dim chgStatus As Boolean
	//        Dim enc As Encoding

	//        'SHIFT-JISへの変換
	//        '変換不可文字はExceptionを発生させる
	//        enc = Encoding.GetEncoding("shift_jis", New EncoderExceptionFallback, New DecoderExceptionFallback)

	//        For Each c As Char In checkString
	//            chgStatus = False
	//            Try
	//                chgbyte = enc.GetBytes(c)
	//            Catch ex As Exception
	//                errString += c
	//            End Try
	//        Next

	//        Return errString
	//    End Function

	//#End Region

	//#Region "NULL変換"
	//    ''' <summary>
	//    ''' DBNullかチェックし、DBNullだったらdefaultValueの値を返す
	//    ''' </summary>
	//    ''' <param name="pObj"></param>
	//    ''' <param name="defaultValue">pObjがDBNullだった場合に返す値</param>
	//    ''' <returns></returns>
	//    ''' <remarks></remarks>
	//    Public Function Nvl(ByVal pObj As Object, Optional ByVal defaultValue As Object = Nothing) As Object

	//        Dim returnValue As Object = defaultValue

	//        If Not IsDBNull(pObj) Then
	//            returnValue = pObj
	//        End If

	//        Return returnValue

	//    End Function

	//#End Region

	//#Region "Nothing変換"
	//    ''' <summary>
	//    ''' 値がNothingまたはString.Emptyの時、defaultValueの値を返す
	//    ''' </summary>
	//    ''' <param name="pString"></param>
	//    ''' <param name="defaultValue">値がNothingまたはString.Emptyの時に返す値</param>
	//    ''' <returns></returns>
	//    ''' <remarks></remarks>
	//    Public Function getEmptyValue(ByVal pString As String, Optional ByVal defaultValue As String = "") As String

	//        Dim returnValue As String = defaultValue

	//        If pString IsNot Nothing AndAlso
	//            pString <> String.Empty Then
	//            returnValue = pString
	//        End If

	//        Return returnValue

	//    End Function
	//#End Region

	//#End Region

	//#Region "数値ボックス関連"

	//#Region "Numbwe.Value変換（Nullable Decimal）"
	//    Public Function getValue(ByVal val As Decimal?) As Decimal
	//        If val.HasValue = False Then
	//            Return 0D
	//        Else
	//            Return CDec(val)
	//        End If
	//    End Function
	//#End Region

	//#End Region

	//#Region " チェックボックス関連 "

	//    ''' <summary>
	//    ''' Trueを1、Falseを0で返す
	//    ''' </summary>
	//    ''' <param name="pValue"></param>
	//    ''' <returns></returns>
	//    ''' <remarks></remarks>
	//    Public Function getCheckedValue(ByVal pValue As Boolean) As Integer

	//        Dim returnValue As Integer = 0

	//        If pValue Then
	//            returnValue = 1
	//        End If

	//        Return returnValue

	//    End Function

	//    ''' <summary>
	//    ''' 1をTrue、0をFalseで返す
	//    ''' </summary>
	//    ''' <param name="pValue"></param>
	//    ''' <returns></returns>
	//    ''' <remarks></remarks>
	//    Public Function getCheckBoxValue(ByVal pValue As Integer) As Boolean

	//        Dim returnValue As Boolean = True

	//        If pValue = 0 Then
	//            returnValue = False
	//        End If

	//        Return returnValue

	//    End Function

	//    ''' <summary>
	//    ''' 削除チェックボックス専用：String.EmptyならFalseを返す
	//    ''' </summary>
	//    ''' <param name="pValue"></param>
	//    ''' <returns></returns>
	//    ''' <remarks></remarks>
	//    Public Function getCheckBoxValueForDeleteDate(ByVal pValue As String) As Boolean

	//        Dim returnValue As Boolean = True

	//        If pValue = String.Empty Then
	//            returnValue = False
	//        End If

	//        Return returnValue

	//    End Function

	//    ''' <summary>
	//    ''' 削除フラグのセット値を取得する
	//    ''' </summary>
	//    ''' <param name="checkedValue"></param>
	//    ''' <param name="oldValue">前回値の値</param>
	//    ''' <returns>チェックされていたら前回値、前回値がなければ本日日付を返す</returns>
	//    ''' <remarks></remarks>
	//    Public Function getDeleteValue(ByVal checkedValue As Boolean, ByVal oldValue As String) As String

	//        Dim returnValue As String = String.Empty

	//        If checkedValue Then
	//            If oldValue <> String.Empty Then
	//                returnValue = oldValue
	//            Else
	//                returnValue = Today.Date.ToString("yyyyMMdd")
	//            End If
	//        End If

	//        Return returnValue

	//    End Function

	//#End Region

	//#Region " コンボボックス関連 "
	//    ''' <summary>
	//    ''' グリッドに設置したコンボボックスへデータを格納するSortedListを作成する
	//    ''' </summary>
	//    ''' <param name="dataTableValue"></param>
	//    ''' <returns></returns>
	//    ''' <remarks></remarks>
	//    Public Function getComboboxData(ByVal dataTableValue As DataTable, Optional ByVal nullRecord As Boolean = False) As SortedList(Of String, String)
	//        Dim returnValue As New SortedList(Of String, String)

	//        If nullRecord = True Then
	//            returnValue.Add("", "")
	//        End If

	//        For idxCountRow As Integer = 0 To dataTableValue.Rows.Count - 1

	//            returnValue.Add(dataTableValue.Rows(idxCountRow).Item(ComboBoxCdType.CODE_VALUE.ToString).ToString,
	//                            dataTableValue.Rows(idxCountRow).Item(ComboBoxCdType.CODE_NAME.ToString).ToString)

	//        Next

	//        Return returnValue

	//    End Function
	//    ''' <summary>
	//    ''' Enumからグリッドに設置したコンボボックスへデータを格納するSortedListを作成
	//    ''' </summary>
	//    ''' <param name="systemTypeValue"></param>
	//    ''' <returns></returns>
	//    ''' <remarks></remarks>
	//    Public Function getComboboxData(ByVal systemTypeValue As System.Type, Optional ByVal nullRecord As Boolean = False) As SortedList(Of String, String)
	//        Dim returnValue As New SortedList(Of String, String)

	//        If nullRecord = True Then
	//            returnValue.Add("", "")
	//        End If

	//        'For Each objectCount As Integer In System.Enum.GetValues(systemTypeValue)
	//        For Each objectCount As Object In System.Enum.GetValues(systemTypeValue)

	//            'returnValue.Add(objectCount.ToString, deleteUnderScore(System.Enum.GetName(systemTypeValue, objectCount)))
	//            returnValue.Add(CInt(objectCount), getEnumAttrValue(objectCount))

	//        Next

	//        Return returnValue

	//    End Function

	//    ''' <summary>
	//    ''' Enumからグリッドに設置したコンボボックスへデータを格納するSortedListを作成
	//    ''' </summary>
	//    ''' <param name="systemTypeValue"></param>
	//    ''' <returns></returns>
	//    ''' <remarks></remarks>
	//    Public Function getComboboxData_MojiColor_Kikaku(ByVal systemTypeValue As System.Type, Optional ByVal nullRecord As Boolean = False) As SortedList(Of String, String)
	//        Dim returnValue As New SortedList(Of String, String)

	//        If nullRecord = True Then
	//            returnValue.Add("", "")
	//        End If

	//        For Each objectCount As Integer In System.Enum.GetValues(systemTypeValue)

	//            returnValue.Add(objectCount.ToString, CommonType_MojiColValue.MojiColorTypeKikaku_Value(CType(objectCount, MojiColorType_Kikaku)))

	//        Next

	//        Return returnValue

	//    End Function

	//    ''' <summary>
	//    ''' Enumからグリッドに設置したコンボボックスへデータを格納するSortedListを作成
	//    ''' </summary>
	//    ''' <param name="systemTypeValue"></param>
	//    ''' <returns></returns>
	//    ''' <remarks></remarks>
	//    Public Function getComboboxData_MojiColor_Teiki(ByVal systemTypeValue As System.Type, Optional ByVal nullRecord As Boolean = False) As SortedList(Of String, String)
	//        Dim returnValue As New SortedList(Of String, String)

	//        If nullRecord = True Then
	//            returnValue.Add("", "")
	//        End If

	//        For Each objectCount As Integer In System.Enum.GetValues(systemTypeValue)

	//            returnValue.Add(objectCount.ToString, CommonType_MojiColValue.MojiColorType_Teiki_Value(CType(objectCount, MojiColorType_Teiki)))

	//        Next

	//        Return returnValue

	//    End Function

	/// <summary>
	/// Enumから、画面に設置したコンボボックスへデータを格納するDataTableを作成
	/// </summary>
	/// <param name="typ"></param>
	/// <param name="nullRecord"></param>
	/// <returns></returns>
	/// <remarks></remarks>
	public static DataTable getComboboxDataOfDatatable(System.Type typ, bool nullRecord)
	{
		DataTable returnValue = new DataTable();

		returnValue.Columns.Add("CODE_VALUE");
		returnValue.Columns.Add("CODE_NAME");

		if (nullRecord == true)
		{
			returnValue.Rows.Add(new object[] { "", "" });
		}

		foreach (object obj in System.Enum.GetValues(typ))
		{
			returnValue.Rows.Add(System.Convert.ToInt32(obj), getEnumAttrValue(obj));
		}

		return returnValue;
	}

	public static string getEnumAttrValue(object obj)
	{
		Type typ = obj.GetType();
		string name = System.Convert.ToString(System.Enum.GetName(typ, obj));
		Reflection.FieldInfo f = typ.GetField(obj.ToString());
		object[] attributes = f.GetCustomAttributes(typeof(ValueAttribute), false);
		if (attributes.Count() == 0)
		{
			return deleteUnderScore(name);
		}
		else
		{
			return deleteUnderScore(System.Convert.ToString(((ValueAttribute)(attributes[0])).Value));
		}
	}

	/// <summary>
	/// Enumから、画面に設置したコンボボックスへデータを格納するDataTableを作成
	/// </summary>
	/// <param name="systemTypeValue"></param>
	/// <param name="nullRecord"></param>
	/// <returns></returns>
	/// <remarks></remarks>
	public static DataTable getComboboxDataOfDatatable_old(System.Type systemTypeValue, bool nullRecord)
	{
		DataTable returnValue = new DataTable();

		returnValue.Columns.Add("CODE_VALUE");
		returnValue.Columns.Add("CODE_NAME");

		if (nullRecord == true)
		{
			returnValue.Rows.Add(new object[] { "", "" });
		}

		foreach (int objectCount in System.Enum.GetValues(systemTypeValue))
		{

			returnValue.Rows.Add(objectCount.ToString(), deleteUnderScore(System.Convert.ToString(System.Enum.GetName(systemTypeValue, objectCount))));

		}

		return returnValue;
	}

	//#End Region

	#region  列挙型関連
	/// <summary>
	/// 先頭の_(アンダースコア)を削除
	/// ※列挙型で使用を想定
	/// </summary>
	/// <param name="value"></param>
	/// <returns></returns>
	/// <remarks></remarks>
	public static string deleteUnderScore(string value)
	{
		if (value.Substring(0, 1) == "_")
		{
			return value.Substring(1, value.Count);
		}
		else
		{
			return value;
		}
	}
	#endregion

	//#Region " 日付＿時刻関連 "

	//    ''' <summary>
	//    ''' "HH:mm"形式の時刻に分指定での加減算を行い、"HH:mm"形式で返却する
	//    ''' </summary>
	//    ''' <param name="HHmm">"HH:mm"形式の時刻</param>
	//    ''' <param name="calclateMinutes">加減算値(マイナス値も可能)</param>
	//    ''' <param name="allowZerofill">True:ゼロフィル許可/false:ゼロフィル不許可</param>
	//    ''' <returns>計算後の時刻(24時間表記)</returns>
	//    ''' <remarks>+60以上/-60以下の数値には未対応</remarks>
	//    Public Function getCalclatedTimeAtHHmm(ByVal HHmm As String, ByVal calclateMinutes As Integer, Optional ByVal allowZerofill As Boolean = True) As String
	//        Dim returnValue As String = String.Empty
	//        Dim idx As Integer = 0
	//        Dim HH As Integer = 0
	//        Dim mm As Integer = 0

	//        Try
	//            idx = HHmm.IndexOf(":")
	//            HH = CType(HHmm.Substring(0, idx), Integer)
	//            mm = CType(HHmm.Substring(idx + 1, HHmm.Length - (idx + 1)), Integer)
	//            Select Case mm + calclateMinutes
	//                Case Is < 0
	//                    mm = mm + 60 + calclateMinutes
	//                    HH = HH - 1
	//                    If HH < 0 Then
	//                        HH = HH + 24
	//                    End If
	//                Case Is > 60
	//                    mm = mm - 60 + calclateMinutes
	//                    HH = HH + 1
	//                Case Else
	//                    mm = mm + calclateMinutes
	//                    HH = HH
	//            End Select

	//            Select Case allowZerofill
	//                Case True
	//                    returnValue = String.Format("{0:D2}:{1:D2}", HH, mm)
	//                Case False
	//                    returnValue = String.Format("{0}:{1:D2}", HH, mm)
	//            End Select

	//        Catch ex As Exception
	//            returnValue = HHmm
	//        End Try

	//        Return returnValue
	//    End Function

	//    ''' <summary>
	//    ''' "HH:mm"形式の時刻同士の差分計算を行い、"mm"形式で返却する
	//    ''' </summary>
	//    ''' <param name="HHmmBase">"HH:mm"形式の時刻(引かれる値)</param>
	//    ''' <param name="HHmmSubtract">"HH:mm"形式の時刻(引く値)</param>
	//    ''' <param name="allowNothing">True:両者引数が無効値の場合の返却値=String.Empty/false:両者引数が無効値の場合の返却値="0"</param>
	//    ''' <returns>計算後の差分(分)</returns>
	//    ''' <remarks></remarks>
	//    Public Function getCalclatedMinutesFromHHmm(ByVal HHmmBase As String, ByVal HHmmSubtract As String, Optional ByVal allowNothing As Boolean = False) As String
	//        Dim returnValue As String = String.Empty
	//        Dim idxBase As Integer = 0
	//        Dim idxSubstract As Integer = 0
	//        Dim HH As Integer = 0
	//        Dim mm As Integer = 0
	//        Dim mmBase As Integer = 0
	//        Dim mmSubtract As Integer = 0

	//        Try
	//            '引かれる値
	//            idxBase = HHmmBase.IndexOf(":")
	//            Select Case idxBase
	//                Case Is < 0
	//                    HH = 0
	//                    mm = 0
	//                Case Else
	//                    HH = CType(HHmmBase.Substring(0, idxBase), Integer)
	//                    mm = CType(HHmmBase.Substring(idxBase + 1, HHmmBase.Length - (idxBase + 1)), Integer)
	//            End Select
	//            mmBase = (HH * 60) + mm

	//            '引く値
	//            idxSubstract = HHmmSubtract.IndexOf(":")
	//            Select Case idxSubstract
	//                Case Is < 0
	//                    HH = 0
	//                    mm = 0
	//                Case Else
	//                    HH = CType(HHmmSubtract.Substring(0, idxSubstract), Integer)
	//                    mm = CType(HHmmSubtract.Substring(idxSubstract + 1, HHmmSubtract.Length - (idxSubstract + 1)), Integer)
	//            End Select
	//            mmSubtract = (HH * 60) + mm

	//            '返却値の算出
	//            Select Case allowNothing
	//                Case True
	//                    If idxBase < 0 OrElse idxSubstract < 0 Then
	//                        returnValue = String.Empty
	//                    Else
	//                        returnValue = (mmBase - mmSubtract).ToString()
	//                    End If
	//                Case False
	//                    returnValue = (mmBase - mmSubtract).ToString()
	//            End Select

	//        Catch ex As Exception
	//            '返却値の算出
	//            Select Case allowNothing
	//                Case True
	//                    returnValue = String.Empty
	//                Case False
	//                    returnValue = "0"
	//            End Select
	//        End Try

	//        Return returnValue
	//    End Function

	//#End Region

	//#Region " データ型変換 "

	//    ''' <summary>
	//    ''' どんなデータ型でもString型に変換して返却する
	//    ''' </summary>
	//    ''' <param name="targetValue">変換対象値</param>
	//    ''' <param name="defaultValue">基準値</param>
	//    ''' <param name="allowNothing">True:変換後の値がNothingの場合の返却値=Nothing/false：変換後の値がNothingの場合の返却値=defaultValue</param>
	//    ''' <returns>変換後の値</returns>
	//    ''' <remarks></remarks>
	//    Public Function convertObjectToString(ByVal targetValue As Object, Optional ByVal defaultValue As String = "", Optional ByVal allowNothing As Boolean = True) As String
	//        Dim returnValue As String = String.Empty

	//        Try
	//            returnValue = CType(targetValue, String)
	//        Catch ex As Exception
	//            returnValue = defaultValue
	//        End Try

	//        If returnValue Is Nothing = True Then
	//            If allowNothing = True Then
	//                returnValue = returnValue
	//            Else
	//                returnValue = defaultValue
	//            End If
	//        End If

	//        Return returnValue
	//    End Function

	//#End Region

	//#Region " 情報連携関連 "
	//    Public Function checkRenkeiRet(ByVal retStatus As FixedCd.InfoRegist_ReturnValue, ByRef msgID As String) As Boolean
	//        checkRenkeiRet = True
	//        Select Case retStatus
	//            Case FixedCd.InfoRegist_ReturnValue.normalEnd  '情報連携成功
	//                checkRenkeiRet = False
	//            Case FixedCd.InfoRegist_ReturnValue.warningEnd
	//                msgID = "8001"
	//            Case FixedCd.InfoRegist_ReturnValue.faultEnd
	//                msgID = "8002"
	//            Case FixedCd.InfoRegist_ReturnValue.timeout
	//                msgID = "8003"
	//            Case FixedCd.InfoRegist_ReturnValue.unexpectedError
	//                msgID = "8004"
	//            Case FixedCd.InfoRegist_ReturnValue.statusCreateError
	//                msgID = "8005"
	//            Case Else
	//                checkRenkeiRet = False
	//        End Select


	//    End Function
	//#End Region

	//#Region " 計算処理 "

	//    ''' <summary>
	//    ''' 除算の結果を返す。
	//    ''' 0除算の場合は0を返す。
	//    ''' </summary>
	//    ''' <param name="dividendNum">被除数</param>
	//    ''' <param name="divisorNum">除数</param>
	//    ''' <returns></returns>
	//    ''' <remarks></remarks>
	//    Public Function getDividedValue(ByVal dividendNum As Double, ByVal divisorNum As Double) As Double

	//        Try
	//            If divisorNum = 0.0 Then
	//                Return 0
	//            End If

	//            Return dividendNum / divisorNum

	//        Catch ex As DivideByZeroException
	//            Throw ex
	//        End Try

	//    End Function
	//#End Region

	//#Region "造成から移植"
	//    ''' <summary>
	//    ''' 共通の日付＆時分秒
	//    ''' ※サーバ日付に変更の可能性あり
	//    ''' </summary>
	//    ''' <returns></returns>
	//    ''' <remarks></remarks>
	//    Public Function getDateTime() As DateTime
	//        Return DateTime.Now
	//    End Function

	//    Public Function checkCharType(ByVal _value As String) As String
	//        Dim returnValue As String = String.Empty
	//        Dim _CharTypeList As String() = New String() {"\"}

	//        If _value = String.Empty Then
	//            Return returnValue
	//        End If

	//        For Len As Integer = 0 To _CharTypeList.Length - 1
	//            If _value.IndexOf(_CharTypeList(Len)) >= 0 Then
	//                returnValue += _CharTypeList(Len)
	//            End If
	//        Next

	//        Return returnValue
	//    End Function

	//    'ADD-20130418-ASサイズへPad↓
	//    ''' <summary>
	//    ''' 'AS/400用の文字列のバイト数挿入
	//    ''' </summary>
	//    ''' <param name="pChkString"></param>
	//    ''' <returns></returns>
	//    ''' <remarks></remarks>
	//    Public Function padRightForAS(ByVal pChkString As String, ByVal insChar As String, ByVal insMaxByte As Integer) As String

	//        Dim asByte As Integer = 0
	//        Dim beforeStr As String = String.Empty

	//        Do
	//            asByte = chkByteForAS400(pChkString)

	//            If asByte <= insMaxByte Then
	//                beforeStr = pChkString
	//                pChkString &= insChar
	//            Else
	//                pChkString = beforeStr
	//                Exit Do
	//            End If
	//        Loop

	//        Return pChkString

	//    End Function

	//    ''' <summary>
	//    ''' Enumから、画面に設置したコンボボックスへデータを格納するDataTableを作成
	//    ''' </summary>
	//    ''' <param name="systemTypeValue"></param>
	//    ''' <param name="nullRecord"></param>
	//    ''' <returns></returns>
	//    ''' <remarks></remarks>
	//    Public Function getComboData_HurikomiSeikyusyoKbn(ByVal systemTypeValue As System.Type, Optional ByVal nullRecord As Boolean = False) As DataTable
	//        Dim returnValue As New DataTable

	//        returnValue.Columns.Add("CODE_VALUE")
	//        returnValue.Columns.Add("CODE_NAME")

	//        If nullRecord = True Then
	//            returnValue.Rows.Add(New Object() {"", ""})
	//        End If

	//        For Each objectCount As Integer In System.Enum.GetValues(systemTypeValue)

	//            returnValue.Rows.Add(CommonType_MojiColValue.HurikomiSeikyusyoKbn_Value(CType(objectCount, HurikomiSeikyusyoKbnType)), deleteUnderScore(System.Enum.GetName(systemTypeValue, objectCount)))

	//        Next

	//        Return returnValue
	//    End Function

	//    ''' <summary>
	//    ''' Enumから、画面に設置したコンボボックスへデータを格納するDataTableを作成
	//    ''' </summary>
	//    ''' <param name="systemTypeValue"></param>
	//    ''' <param name="nullRecord"></param>
	//    ''' <returns></returns>
	//    ''' <remarks></remarks>
	//    Public Function getComboData_SokyakFee(ByVal systemTypeValue As System.Type, Optional ByVal nullRecord As Boolean = False) As DataTable
	//        Dim returnValue As New DataTable

	//        returnValue.Columns.Add("CODE_VALUE")
	//        returnValue.Columns.Add("CODE_NAME")

	//        If nullRecord = True Then
	//            returnValue.Rows.Add(New Object() {"", ""})
	//        End If

	//        For Each objectCount As Integer In System.Enum.GetValues(systemTypeValue)

	//            returnValue.Rows.Add(CommonType_MojiColValue.SokyakFeeType_Value(CType(objectCount, SokyakFeeType)), deleteUnderScore(System.Enum.GetName(systemTypeValue, objectCount)))

	//        Next

	//        Return returnValue
	//    End Function

	//    ''' <summary>
	//    ''' グリッドに設置したコンボボックスへデータを格納するDictionaryを作成する
	//    ''' </summary>
	//    ''' <returns></returns>
	//    ''' <remarks></remarks>
	//    Public Function getPcComboboxData() As Dictionary(Of String, String)
	//        Dim returnValue As New System.Collections.Generic.Dictionary(Of String, String)

	//        returnValue.Add("1", "浜朝1")
	//        returnValue.Add("6", "浜朝2")
	//        returnValue.Add("5", "新朝1")
	//        returnValue.Add("4", "浜昼1")
	//        returnValue.Add("3", "東昼1")
	//        returnValue.Add("7", "浜夜1")

	//        Return returnValue

	//    End Function

	//#End Region
}