using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using Microsoft.VisualBasic;

namespace Unkou.Entity
{
    /// <summary>
    /// ''' —\–ñî•ñiŠî–{jƒGƒ“ƒeƒBƒeƒB
    /// ''' </summary>
    /// ''' <remarks></remarks>
    [Serializable()]
    public class YoyakuInfoBasicEntity  // —\–ñî•ñiŠî–{jƒGƒ“ƒeƒBƒeƒB
    {
        //private EntityKoumoku_MojiType _yoyakuKbn = new EntityKoumoku_MojiType();    // —\–ñ‹æ•ª
        //private EntityKoumoku_NumberType _yoyakuNo = new EntityKoumoku_NumberType();   // —\–ñ‚m‚n
        //private EntityKoumoku_MojiType _address1 = new EntityKoumoku_MojiType(); // ZŠ‚P
        //private EntityKoumoku_MojiType _address2 = new EntityKoumoku_MojiType(); // ZŠ‚Q
        //private EntityKoumoku_MojiType _address3 = new EntityKoumoku_MojiType(); // ZŠ‚R
        //private EntityKoumoku_MojiType _moshikomiHotelFlg = new EntityKoumoku_MojiType();    // \žŽÒƒzƒeƒ‹ƒtƒ‰ƒO
        //private EntityKoumoku_NumberType _addChargeMaebaraiKei = new EntityKoumoku_NumberType();   // ’Ç‰Á—¿‹à‘O•¥Œv
        //private EntityKoumoku_NumberType _addChargeTojituPaymentKei = new EntityKoumoku_NumberType();  // ’Ç‰Á—¿‹à“–“ú•¥Œv
        //private EntityKoumoku_NumberType _afStayYoyakuSglNum = new EntityKoumoku_NumberType(); // Œã”‘—\–ñ‚r‚f‚k”
        //private EntityKoumoku_NumberType _afStayYoyakuTwnNum = new EntityKoumoku_NumberType(); // Œã”‘—\–ñ‚s‚v‚m”
        //private EntityKoumoku_MojiType _agentCd = new EntityKoumoku_MojiType();  // ‹ÆŽÒƒR[ƒh
        //private EntityKoumoku_MojiType _agentNameKana = new EntityKoumoku_MojiType();    // ‹ÆŽÒ–¼ƒJƒi
        //private EntityKoumoku_MojiType _agentNm = new EntityKoumoku_MojiType();  // ‹ÆŽÒ–¼Ì
        //private EntityKoumoku_MojiType _agentTantosya = new EntityKoumoku_MojiType();    // ‹ÆŽÒ’S“–ŽÒ
        //private EntityKoumoku_MojiType _agentTelNo = new EntityKoumoku_MojiType();   // ‹ÆŽÒ“d˜b”Ô†
        //private EntityKoumoku_MojiType _agentTelNo1 = new EntityKoumoku_MojiType();  // ‹ÆŽÒ“d˜b”Ô†‚P
        //private EntityKoumoku_MojiType _agentTelNo2 = new EntityKoumoku_MojiType();  // ‹ÆŽÒ“d˜b”Ô†‚Q
        //private EntityKoumoku_MojiType _agentTelNo3 = new EntityKoumoku_MojiType();  // ‹ÆŽÒ“d˜b”Ô†‚R
        //private EntityKoumoku_MojiType _agentYoyakuCd = new EntityKoumoku_MojiType();    // ‹ÆŽÒ—\–ñƒR[ƒh
        //private EntityKoumoku_MojiType _agentSeisanKbn = new EntityKoumoku_MojiType();   // ¸ŽZ‘ã—“X‹æ•ª
        //private EntityKoumoku_MojiType _aibeyaFlg = new EntityKoumoku_MojiType();    // ‘Š•”‰®ƒtƒ‰ƒO
        //private EntityKoumoku_NumberType _birthday = new EntityKoumoku_NumberType();   // ¶”NŒŽ“ú
        //private EntityKoumoku_MojiType _cancelFlg = new EntityKoumoku_MojiType();    // ƒLƒƒƒ“ƒZƒ‹ƒtƒ‰ƒO
        //private EntityKoumoku_MojiType _seatOnlyCancelFlg = new EntityKoumoku_MojiType();    // È‚Ì‚ÝƒLƒƒƒ“ƒZƒ‹ƒtƒ‰ƒO
        //private EntityKoumoku_NumberType _cancelRyouKei = new EntityKoumoku_NumberType();  // ƒLƒƒƒ“ƒZƒ‹—¿Œv
        //private EntityKoumoku_NumberType _changeHistoryLastDay = new EntityKoumoku_NumberType();   // •ÏX—š—ðÅI“ú
        //private EntityKoumoku_NumberType _changeHistoryLastSeq = new EntityKoumoku_NumberType();   // •ÏX—š—ðÅI‚r‚d‚p
        //private EntityKoumoku_MojiType _checkinFlg1 = new EntityKoumoku_MojiType();  // ƒ`ƒFƒbƒNƒCƒ“ƒtƒ‰ƒO‚P
        //private EntityKoumoku_MojiType _checkinFlg2 = new EntityKoumoku_MojiType();  // ƒ`ƒFƒbƒNƒCƒ“ƒtƒ‰ƒO‚Q
        //private EntityKoumoku_MojiType _checkinFlg3 = new EntityKoumoku_MojiType();  // ƒ`ƒFƒbƒNƒCƒ“ƒtƒ‰ƒO‚R
        //private EntityKoumoku_MojiType _checkinFlg4 = new EntityKoumoku_MojiType();  // ƒ`ƒFƒbƒNƒCƒ“ƒtƒ‰ƒO‚S
        //private EntityKoumoku_MojiType _checkinFlg5 = new EntityKoumoku_MojiType();  // ƒ`ƒFƒbƒNƒCƒ“ƒtƒ‰ƒO‚T
        //private EntityKoumoku_NumberType _checkinNinzu1 = new EntityKoumoku_NumberType();  // ƒ`ƒFƒbƒNƒCƒ“l”‚P
        //private EntityKoumoku_NumberType _checkinNinzu2 = new EntityKoumoku_NumberType();  // ƒ`ƒFƒbƒNƒCƒ“l”‚Q
        //private EntityKoumoku_NumberType _checkinNinzu3 = new EntityKoumoku_NumberType();  // ƒ`ƒFƒbƒNƒCƒ“l”‚R
        //private EntityKoumoku_NumberType _checkinNinzu4 = new EntityKoumoku_NumberType();  // ƒ`ƒFƒbƒNƒCƒ“l”‚S
        //private EntityKoumoku_NumberType _checkinNinzu5 = new EntityKoumoku_NumberType();  // ƒ`ƒFƒbƒNƒCƒ“l”‚T
        //private EntityKoumoku_NumberType _infantNinzu = new EntityKoumoku_NumberType();    // ƒCƒ“ƒtƒ@ƒ“ƒgl”
        //private EntityKoumoku_MojiType _crsCd = new EntityKoumoku_MojiType();    // ƒR[ƒXƒR[ƒh
        //private EntityKoumoku_MojiType _crsKbn1 = new EntityKoumoku_MojiType();  // ƒR[ƒX‹æ•ª‚P
        //private EntityKoumoku_MojiType _crsKbn2 = new EntityKoumoku_MojiType();  // ƒR[ƒX‹æ•ª‚Q
        //private EntityKoumoku_MojiType _crsKind = new EntityKoumoku_MojiType();  // ƒR[ƒXŽí•Ê
        //private EntityKoumoku_NumberType _deleteDay = new EntityKoumoku_NumberType();  // íœ“ú
        //private EntityKoumoku_NumberType _entryDay = new EntityKoumoku_NumberType();   // “o˜^“ú
        //private EntityKoumoku_MojiType _entryPersonCd = new EntityKoumoku_MojiType();    // “o˜^ŽÒƒR[ƒh
        //private EntityKoumoku_MojiType _entryPgmid = new EntityKoumoku_MojiType();   // “o˜^‚o‚f‚l‚h‚c
        //private EntityKoumoku_NumberType _entryTime = new EntityKoumoku_NumberType();  // “o˜^Žž
        //private EntityKoumoku_MojiType _fujyoProofIssueFlg = new EntityKoumoku_MojiType();   // •sæØ–¾”­sƒtƒ‰ƒO
        //private EntityKoumoku_MojiType _furikomiyoshiYohiFlg = new EntityKoumoku_MojiType(); // Už—pŽ†—v”Ûƒtƒ‰ƒO
        //private EntityKoumoku_NumberType _gousya = new EntityKoumoku_NumberType(); // †ŽÔ
        //private EntityKoumoku_NumberType _groupNo = new EntityKoumoku_NumberType();    // ƒOƒ‹[ƒv‚m‚n
        //private EntityKoumoku_NumberType _hakkenDay = new EntityKoumoku_NumberType();  // ”­Œ”“ú
        //private EntityKoumoku_MojiType _hakkenEigyosyoCd = new EntityKoumoku_MojiType(); // ”­Œ”‰c‹ÆŠƒR[ƒh
        //private EntityKoumoku_NumberType _hakkenKingaku = new EntityKoumoku_NumberType();  // ”­Œ”‹àŠz
        //private EntityKoumoku_MojiType _hakkenNaiyo = new EntityKoumoku_MojiType();  // ”­Œ”“à—e
        //private EntityKoumoku_MojiType _hakkenTantosyaCd = new EntityKoumoku_MojiType(); // ”­Œ”’S“–ŽÒƒR[ƒh
        //private EntityKoumoku_MojiType _itineraryTablePrintAlready = new EntityKoumoku_MojiType();   // s’ö•\ˆóüÏ
        //private EntityKoumoku_NumberType _itineraryTablePrintDay = new EntityKoumoku_NumberType(); // s’ö•\ˆóü“ú
        //private EntityKoumoku_MojiType _jyochachiCd1 = new EntityKoumoku_MojiType(); // æŽÔ’nƒR[ƒh‚P
        //private EntityKoumoku_MojiType _jyochachiCd2 = new EntityKoumoku_MojiType(); // æŽÔ’nƒR[ƒh‚Q
        //private EntityKoumoku_MojiType _jyochachiCd3 = new EntityKoumoku_MojiType(); // æŽÔ’nƒR[ƒh‚R
        //private EntityKoumoku_MojiType _jyochachiCd4 = new EntityKoumoku_MojiType(); // æŽÔ’nƒR[ƒh‚S
        //private EntityKoumoku_MojiType _jyochachiCd5 = new EntityKoumoku_MojiType(); // æŽÔ’nƒR[ƒh‚T
        //private EntityKoumoku_MojiType _jyoseiSenyo = new EntityKoumoku_MojiType();  // —ê
        //private EntityKoumoku_NumberType _jyosyaNinzu1 = new EntityKoumoku_NumberType();   // æŽÔl”‚P
        //private EntityKoumoku_NumberType _jyosyaNinzu2 = new EntityKoumoku_NumberType();   // æŽÔl”‚Q
        //private EntityKoumoku_NumberType _jyosyaNinzu3 = new EntityKoumoku_NumberType();   // æŽÔl”‚R
        //private EntityKoumoku_NumberType _jyosyaNinzu4 = new EntityKoumoku_NumberType();   // æŽÔl”‚S
        //private EntityKoumoku_NumberType _jyosyaNinzu5 = new EntityKoumoku_NumberType();   // æŽÔl”‚T
        //private EntityKoumoku_MojiType _kokuseki = new EntityKoumoku_MojiType(); // ‘Ð
        //private EntityKoumoku_NumberType _lastHenkinDay = new EntityKoumoku_NumberType();  // ÅI•Ô‹à“ú
        //private EntityKoumoku_NumberType _lastNyuukinDay = new EntityKoumoku_NumberType(); // ÅI“ü‹à“ú
        //private EntityKoumoku_MojiType _localTelNo = new EntityKoumoku_MojiType();   // Œ»’n“d˜b”Ô†
        //private EntityKoumoku_NumberType _lostDay = new EntityKoumoku_NumberType();    // •´Ž¸“ú
        //private EntityKoumoku_MojiType _lostFlg = new EntityKoumoku_MojiType();  // •´Ž¸ƒtƒ‰ƒO
        //private EntityKoumoku_MojiType _mailAddress = new EntityKoumoku_MojiType();  // ƒ[ƒ‹ƒAƒhƒŒƒX
        //private EntityKoumoku_MojiType _mailSendingKbn = new EntityKoumoku_MojiType();   // ƒ[ƒ‹‘—M‹æ•ª
        //private EntityKoumoku_MojiType _mediaCd = new EntityKoumoku_MojiType();  // ”}‘ÌƒR[ƒh
        //private EntityKoumoku_MojiType _mediaName = new EntityKoumoku_MojiType();    // ”}‘Ì–¼
        //private EntityKoumoku_NumberType _meiboSeq = new EntityKoumoku_NumberType();   // –¼•ë‚r‚d‚p
        //private EntityKoumoku_MojiType _messageCheckFlg1 = new EntityKoumoku_MojiType(); // ƒƒbƒZ[ƒWƒ`ƒFƒbƒNƒtƒ‰ƒO‚P
        //private EntityKoumoku_MojiType _messageCheckFlg2 = new EntityKoumoku_MojiType(); // ƒƒbƒZ[ƒWƒ`ƒFƒbƒNƒtƒ‰ƒO‚Q
        //private EntityKoumoku_MojiType _messageCheckFlg3 = new EntityKoumoku_MojiType(); // ƒƒbƒZ[ƒWƒ`ƒFƒbƒNƒtƒ‰ƒO‚R
        //private EntityKoumoku_MojiType _messageCheckFlg4 = new EntityKoumoku_MojiType(); // ƒƒbƒZ[ƒWƒ`ƒFƒbƒNƒtƒ‰ƒO‚S
        //private EntityKoumoku_MojiType _messageCheckFlg5 = new EntityKoumoku_MojiType(); // ƒƒbƒZ[ƒWƒ`ƒFƒbƒNƒtƒ‰ƒO‚T
        //private EntityKoumoku_MojiType _messageCheckFlg6 = new EntityKoumoku_MojiType(); // ƒƒbƒZ[ƒWƒ`ƒFƒbƒNƒtƒ‰ƒO‚U
        //private EntityKoumoku_MojiType _messageCheckFlg7 = new EntityKoumoku_MojiType(); // ƒƒbƒZ[ƒWƒ`ƒFƒbƒNƒtƒ‰ƒO‚V
        //private EntityKoumoku_MojiType _messageCheckFlg8 = new EntityKoumoku_MojiType(); // ƒƒbƒZ[ƒWƒ`ƒFƒbƒNƒtƒ‰ƒO‚W
        //private EntityKoumoku_MojiType _messageCheckFlg9 = new EntityKoumoku_MojiType(); // ƒƒbƒZ[ƒWƒ`ƒFƒbƒNƒtƒ‰ƒO‚X
        //private EntityKoumoku_MojiType _messageCheckFlg10 = new EntityKoumoku_MojiType();    // ƒƒbƒZ[ƒWƒ`ƒFƒbƒNƒtƒ‰ƒO‚P‚O
        //private EntityKoumoku_MojiType _surname = new EntityKoumoku_MojiType();  // ©
        //private EntityKoumoku_MojiType _name = new EntityKoumoku_MojiType(); // –¼
        //private EntityKoumoku_MojiType _surnameKj = new EntityKoumoku_MojiType();    // ©iŠ¿Žšj
        //private EntityKoumoku_MojiType _nameKj = new EntityKoumoku_MojiType();   // –¼iŠ¿Žšj
        //private EntityKoumoku_MojiType _noShowFlg = new EntityKoumoku_MojiType();    // ‚m‚n‚r‚g‚n‚vƒtƒ‰ƒO
        //private EntityKoumoku_NumberType _nyukingakuSokei = new EntityKoumoku_NumberType();    // “ü‹àŠz‘Œv
        //private EntityKoumoku_MojiType _nyuukinSituationKbn = new EntityKoumoku_MojiType();  // “ü‹àó‹µ‹æ•ª
        //private EntityKoumoku_NumberType _oldGousya = new EntityKoumoku_NumberType();  // ‹Œ†ŽÔ
        //private EntityKoumoku_MojiType _oldZaseki = new EntityKoumoku_MojiType();    // ‹ŒÀÈ
        //private EntityKoumoku_MojiType _receiptIssueFlg = new EntityKoumoku_MojiType();  // —ÌŽû‘”­sƒtƒ‰ƒO
        //private EntityKoumoku_MojiType _relationYoyakuKbn = new EntityKoumoku_MojiType();    // ŠÖ˜A—\–ñ‹æ•ª
        //private EntityKoumoku_NumberType _relationYoyakuNo = new EntityKoumoku_NumberType();   // ŠÖ˜A—\–ñ‚m‚n
        //private EntityKoumoku_NumberType _returnDay = new EntityKoumoku_NumberType();  // ‹A’…“ú
        //private EntityKoumoku_NumberType _roomingBetuNinzu1 = new EntityKoumoku_NumberType();  // ‚q‚n‚n‚l‚h‚m‚f•Êl”‚P
        //private EntityKoumoku_NumberType _roomingBetuNinzu2 = new EntityKoumoku_NumberType();  // ‚q‚n‚n‚l‚h‚m‚f•Êl”‚Q
        //private EntityKoumoku_NumberType _roomingBetuNinzu3 = new EntityKoumoku_NumberType();  // ‚q‚n‚n‚l‚h‚m‚f•Êl”‚R
        //private EntityKoumoku_NumberType _roomingBetuNinzu4 = new EntityKoumoku_NumberType();  // ‚q‚n‚n‚l‚h‚m‚f•Êl”‚S
        //private EntityKoumoku_NumberType _roomingBetuNinzu5 = new EntityKoumoku_NumberType();  // ‚q‚n‚n‚l‚h‚m‚f•Êl”‚T
        //private EntityKoumoku_NumberType _saikouKakuteiGuideOutDay = new EntityKoumoku_NumberType();   // ÃsŠm’èˆÄ“ào—Í“ú
        //private EntityKoumoku_NumberType _seikiChargeAllGaku = new EntityKoumoku_NumberType(); // ³‹K—¿‹à‘Šz
        //private EntityKoumoku_MojiType _seikyusyoYohiFlg = new EntityKoumoku_MojiType(); // ¿‹‘—v”Ûƒtƒ‰ƒO
        //private EntityKoumoku_MojiType _seisanHoho = new EntityKoumoku_MojiType();   // ¸ŽZ•û–@
        //private EntityKoumoku_MojiType _sexBetu = new EntityKoumoku_MojiType();  // «•Ê
        //private EntityKoumoku_MojiType _siharaiHoho = new EntityKoumoku_MojiType();  // Žx•¥•û–@
        //private EntityKoumoku_NumberType _sonotaNyuukinHenkin = new EntityKoumoku_NumberType();    // ‚»‚Ì‘¼“ü‹à•Ô‹à
        //private EntityKoumoku_MojiType _sponsorshipKeiyakuKbn = new EntityKoumoku_MojiType();    // ŽåÃŒ_–ñ‹æ•ª
        //private EntityKoumoku_MojiType _state = new EntityKoumoku_MojiType();    // ó‘Ô
        //private EntityKoumoku_NumberType _syugoTime1 = new EntityKoumoku_NumberType(); // W‡ŽžŠÔ‚P
        //private EntityKoumoku_NumberType _syugoTime2 = new EntityKoumoku_NumberType(); // W‡ŽžŠÔ‚Q
        //private EntityKoumoku_NumberType _syugoTime3 = new EntityKoumoku_NumberType(); // W‡ŽžŠÔ‚R
        //private EntityKoumoku_NumberType _syugoTime4 = new EntityKoumoku_NumberType(); // W‡ŽžŠÔ‚S
        //private EntityKoumoku_NumberType _syugoTime5 = new EntityKoumoku_NumberType(); // W‡ŽžŠÔ‚T
        //private EntityKoumoku_NumberType _syuptDay = new EntityKoumoku_NumberType();   // o”­“ú
        //private EntityKoumoku_NumberType _syuptTime1 = new EntityKoumoku_NumberType(); // o”­ŽžŠÔ‚P
        //private EntityKoumoku_NumberType _syuptTime2 = new EntityKoumoku_NumberType(); // o”­ŽžŠÔ‚Q
        //private EntityKoumoku_NumberType _syuptTime3 = new EntityKoumoku_NumberType(); // o”­ŽžŠÔ‚R
        //private EntityKoumoku_NumberType _syuptTime4 = new EntityKoumoku_NumberType(); // o”­ŽžŠÔ‚S
        //private EntityKoumoku_NumberType _syuptTime5 = new EntityKoumoku_NumberType(); // o”­ŽžŠÔ‚T
        //private EntityKoumoku_NumberType _tasyaKennoKingaku = new EntityKoumoku_NumberType();  // ‘¼ŽÐŒ””Ô‹àŠz
        //private EntityKoumoku_NumberType _tasyaYoyakuNo = new EntityKoumoku_NumberType();  // ‘¼ŽÐ—\–ñ‚m‚n
        //private EntityKoumoku_MojiType _teikiKeiyakuKbn = new EntityKoumoku_MojiType();  // ’èŠúŒ_–ñ‹æ•ª
        //private EntityKoumoku_MojiType _teikiKikakuKbn = new EntityKoumoku_MojiType();   // ’èŠúEŠé‰æ‹æ•ª
        //private EntityKoumoku_MojiType _telNo1 = new EntityKoumoku_MojiType();   // “d˜b”Ô†‚P
        //private EntityKoumoku_MojiType _telNo11 = new EntityKoumoku_MojiType();  // “d˜b”Ô†‚P|‚P
        //private EntityKoumoku_MojiType _telNo12 = new EntityKoumoku_MojiType();  // “d˜b”Ô†‚P|‚Q
        //private EntityKoumoku_MojiType _telNo13 = new EntityKoumoku_MojiType();  // “d˜b”Ô†‚P|‚R
        //private EntityKoumoku_MojiType _telNo2 = new EntityKoumoku_MojiType();   // “d˜b”Ô†‚Q
        //private EntityKoumoku_MojiType _telNo21 = new EntityKoumoku_MojiType();  // “d˜b”Ô†‚Q|‚P
        //private EntityKoumoku_MojiType _telNo22 = new EntityKoumoku_MojiType();  // “d˜b”Ô†‚Q|‚Q
        //private EntityKoumoku_MojiType _telNo23 = new EntityKoumoku_MojiType();  // “d˜b”Ô†‚Q|‚R
        //private EntityKoumoku_MojiType _tobiSeatFlg = new EntityKoumoku_MojiType();  // ‚Æ‚ÑÈƒtƒ‰ƒO
        //private EntityKoumoku_NumberType _tomonokaiNo = new EntityKoumoku_NumberType();    // —F‚Ì‰ï‚m‚n
        //private EntityKoumoku_NumberType _kaiinNo = new EntityKoumoku_NumberType();
        //private EntityKoumoku_NumberType _toriatukaiFeeCancel = new EntityKoumoku_NumberType();    // ŽæˆµŽè”—¿ƒLƒƒƒ“ƒZƒ‹
        //private EntityKoumoku_NumberType _toriatukaiFeeSagaku = new EntityKoumoku_NumberType();    // ŽæˆµŽè”—¿·Šz
        //private EntityKoumoku_NumberType _toriatukaiFeeUriage = new EntityKoumoku_NumberType();    // ŽæˆµŽè”—¿”„ã
        //private EntityKoumoku_MojiType _toursNo = new EntityKoumoku_MojiType();  // ƒcƒA[‚m‚nD
        //private EntityKoumoku_NumberType _unkyuContactDay = new EntityKoumoku_NumberType();    // ‰^‹x˜A—“ú
        //private EntityKoumoku_NumberType _updateDay = new EntityKoumoku_NumberType();  // XV“ú
        //private EntityKoumoku_MojiType _updatePersonCd = new EntityKoumoku_MojiType();   // XVŽÒƒR[ƒh
        //private EntityKoumoku_MojiType _updatePgmid = new EntityKoumoku_MojiType();  // XV‚o‚f‚l‚h‚c
        //private EntityKoumoku_NumberType _updateTime = new EntityKoumoku_NumberType(); // XVŽž
        //private EntityKoumoku_MojiType _usingFlg = new EntityKoumoku_MojiType(); // Žg—p’†ƒtƒ‰ƒO
        //private EntityKoumoku_NumberType _waribikiAllGaku = new EntityKoumoku_NumberType();    // Š„ˆø‘Šz
        //private EntityKoumoku_NumberType _year = new EntityKoumoku_NumberType();   // ”N
        //private EntityKoumoku_MojiType _yobi1 = new EntityKoumoku_MojiType();    // —\”õ‚P
        //private EntityKoumoku_MojiType _yobi2 = new EntityKoumoku_MojiType();    // —\”õ‚Q
        //private EntityKoumoku_MojiType _yobi3 = new EntityKoumoku_MojiType();    // —\”õ‚R
        //private EntityKoumoku_MojiType _yobi4 = new EntityKoumoku_MojiType();    // —\”õ‚S
        //private EntityKoumoku_MojiType _yobi5 = new EntityKoumoku_MojiType();    // —\”õ‚T
        //private EntityKoumoku_MojiType _yobi6 = new EntityKoumoku_MojiType();    // —\”õ‚U
        //private EntityKoumoku_NumberType _yobi7 = new EntityKoumoku_NumberType();  // —\”õ‚V
        //private EntityKoumoku_MojiType _yoyakuJiAgentCd = new EntityKoumoku_MojiType();  // —\–ñŽž‹ÆŽÒƒR[ƒh
        //private EntityKoumoku_MojiType _yoyakuJiAgentName = new EntityKoumoku_MojiType();    // —\–ñŽž‹ÆŽÒ–¼
        //private EntityKoumoku_NumberType _yoyakuKakuninDay = new EntityKoumoku_NumberType();   // —\–ñŠm”F“ú
        //private EntityKoumoku_MojiType _yoyakuUketukeKbn = new EntityKoumoku_MojiType(); // —\–ñŽó•t‹æ•ª
        //private EntityKoumoku_MojiType _yoyakuZasekiGetKbn = new EntityKoumoku_MojiType();   // —\–ñÀÈŽæ“¾‹æ•ª
        //private EntityKoumoku_MojiType _yoyakuZasekiKbn = new EntityKoumoku_MojiType();  // —\–ñÀÈ‹æ•ª
        //private EntityKoumoku_MojiType _yubinNo = new EntityKoumoku_MojiType();  // —X•Ö”Ô†
        //private EntityKoumoku_MojiType _yykmks = new EntityKoumoku_MojiType();   // \žŽÒ
        //private EntityKoumoku_MojiType _zaseki = new EntityKoumoku_MojiType();   // ÀÈ
        //private EntityKoumoku_MojiType _zasekiChangeUmu = new EntityKoumoku_MojiType();  // ÀÈ•ÏX—L–³
        //private EntityKoumoku_MojiType _zasekiReserveYoyakuFlg = new EntityKoumoku_MojiType();   // ÀÈŽw’è—\–ñƒtƒ‰ƒO
        //private EntityKoumoku_MojiType _subSeatWaitFlg = new EntityKoumoku_MojiType();   // •â•È‘Ò‚¿ƒtƒ‰ƒO
        //private EntityKoumoku_MojiType _motoYoyakuKbn = new EntityKoumoku_MojiType();   // Œ³—\–ñ‹æ•ª
        //private EntityKoumoku_NumberType _motoYoyakuNo = new EntityKoumoku_NumberType();   // Œ³—\–ñ”Ô†
        //private EntityKoumoku_MojiType _entrySectionCd = new EntityKoumoku_MojiType();   // “o˜^•”ƒR[ƒh
        //private EntityKoumoku_MojiType _systemEntryPgmid = new EntityKoumoku_MojiType(); // ƒVƒXƒeƒ€“o˜^‚o‚f‚l‚h‚c
        //private EntityKoumoku_MojiType _systemEntryPersonCd = new EntityKoumoku_MojiType();  // ƒVƒXƒeƒ€“o˜^ŽÒƒR[ƒh
        //private EntityKoumoku_YmdType _systemEntryDay = new EntityKoumoku_YmdType();    // ƒVƒXƒeƒ€“o˜^“ú
        //private EntityKoumoku_MojiType _systemUpdatePgmid = new EntityKoumoku_MojiType();    // ƒVƒXƒeƒ€XV‚o‚f‚l‚h‚c
        //private EntityKoumoku_MojiType _systemUpdatePersonCd = new EntityKoumoku_MojiType(); // ƒVƒXƒeƒ€XVŽÒƒR[ƒh
        //private EntityKoumoku_YmdType _systemUpdateDay = new EntityKoumoku_YmdType();   // ƒVƒXƒeƒ€XV“ú


        public YoyakuInfoBasicEntity()
        {
            _yoyakuKbn.PhysicsName = "YOYAKU_KBN";
            _yoyakuNo.PhysicsName = "YOYAKU_NO";
            _address1.PhysicsName = "ADDRESS_1";
            _address2.PhysicsName = "ADDRESS_2";
            _address3.PhysicsName = "ADDRESS_3";
            _moshikomiHotelFlg.PhysicsName = "MOSHIKOMI_HOTEL_FLG";
            _addChargeMaebaraiKei.PhysicsName = "ADD_CHARGE_MAEBARAI_KEI";
            _addChargeTojituPaymentKei.PhysicsName = "ADD_CHARGE_TOJITU_PAYMENT_KEI";
            _afStayYoyakuSglNum.PhysicsName = "AF_STAY_YOYAKU_SGL_NUM";
            _afStayYoyakuTwnNum.PhysicsName = "AF_STAY_YOYAKU_TWN_NUM";
            _agentCd.PhysicsName = "AGENT_CD";
            _agentNameKana.PhysicsName = "AGENT_NAME_KANA";
            _agentNm.PhysicsName = "AGENT_NM";
            _agentTantosya.PhysicsName = "AGENT_TANTOSYA";
            _agentTelNo.PhysicsName = "AGENT_TEL_NO";
            _agentTelNo1.PhysicsName = "AGENT_TEL_NO_1";
            _agentTelNo2.PhysicsName = "AGENT_TEL_NO_2";
            _agentTelNo3.PhysicsName = "AGENT_TEL_NO_3";
            _agentYoyakuCd.PhysicsName = "AGENT_YOYAKU_CD";
            _agentSeisanKbn.PhysicsName = "AGENT_SEISAN_KBN";
            _aibeyaFlg.PhysicsName = "AIBEYA_FLG";
            _birthday.PhysicsName = "BIRTHDAY";
            _cancelFlg.PhysicsName = "CANCEL_FLG";
            _seatOnlyCancelFlg.PhysicsName = "SEAT_ONLY_CANCEL_FLG";
            _cancelRyouKei.PhysicsName = "CANCEL_RYOU_KEI";
            _changeHistoryLastDay.PhysicsName = "CHANGE_HISTORY_LAST_DAY";
            _changeHistoryLastSeq.PhysicsName = "CHANGE_HISTORY_LAST_SEQ";
            _checkinFlg1.PhysicsName = "CHECKIN_FLG_1";
            _checkinFlg2.PhysicsName = "CHECKIN_FLG_2";
            _checkinFlg3.PhysicsName = "CHECKIN_FLG_3";
            _checkinFlg4.PhysicsName = "CHECKIN_FLG_4";
            _checkinFlg5.PhysicsName = "CHECKIN_FLG_5";
            _checkinNinzu1.PhysicsName = "CHECKIN_NINZU_1";
            _checkinNinzu2.PhysicsName = "CHECKIN_NINZU_2";
            _checkinNinzu3.PhysicsName = "CHECKIN_NINZU_3";
            _checkinNinzu4.PhysicsName = "CHECKIN_NINZU_4";
            _checkinNinzu5.PhysicsName = "CHECKIN_NINZU_5";
            _infantNinzu.PhysicsName = "INFANT_NINZU";
            _crsCd.PhysicsName = "CRS_CD";
            _crsKbn1.PhysicsName = "CRS_KBN_1";
            _crsKbn2.PhysicsName = "CRS_KBN_2";
            _crsKind.PhysicsName = "CRS_KIND";
            _deleteDay.PhysicsName = "DELETE_DAY";
            _entryDay.PhysicsName = "ENTRY_DAY";
            _entryPersonCd.PhysicsName = "ENTRY_PERSON_CD";
            _entryPgmid.PhysicsName = "ENTRY_PGMID";
            _entryTime.PhysicsName = "ENTRY_TIME";
            _fujyoProofIssueFlg.PhysicsName = "FUJYO_PROOF_ISSUE_FLG";
            _furikomiyoshiYohiFlg.PhysicsName = "FURIKOMIYOSHI_YOHI_FLG";
            _gousya.PhysicsName = "GOUSYA";
            _groupNo.PhysicsName = "GROUP_NO";
            _hakkenDay.PhysicsName = "HAKKEN_DAY";
            _hakkenEigyosyoCd.PhysicsName = "HAKKEN_EIGYOSYO_CD";
            _hakkenKingaku.PhysicsName = "HAKKEN_KINGAKU";
            _hakkenNaiyo.PhysicsName = "HAKKEN_NAIYO";
            _hakkenTantosyaCd.PhysicsName = "HAKKEN_TANTOSYA_CD";
            _itineraryTablePrintAlready.PhysicsName = "ITINERARY_TABLE_PRINT_ALREADY";
            _itineraryTablePrintDay.PhysicsName = "ITINERARY_TABLE_PRINT_DAY";
            _jyochachiCd1.PhysicsName = "JYOCHACHI_CD_1";
            _jyochachiCd2.PhysicsName = "JYOCHACHI_CD_2";
            _jyochachiCd3.PhysicsName = "JYOCHACHI_CD_3";
            _jyochachiCd4.PhysicsName = "JYOCHACHI_CD_4";
            _jyochachiCd5.PhysicsName = "JYOCHACHI_CD_5";
            _jyoseiSenyo.PhysicsName = "JYOSEI_SENYO";
            _jyosyaNinzu1.PhysicsName = "JYOSYA_NINZU_1";
            _jyosyaNinzu2.PhysicsName = "JYOSYA_NINZU_2";
            _jyosyaNinzu3.PhysicsName = "JYOSYA_NINZU_3";
            _jyosyaNinzu4.PhysicsName = "JYOSYA_NINZU_4";
            _jyosyaNinzu5.PhysicsName = "JYOSYA_NINZU_5";
            _kokuseki.PhysicsName = "KOKUSEKI";
            _lastHenkinDay.PhysicsName = "LAST_HENKIN_DAY";
            _lastNyuukinDay.PhysicsName = "LAST_NYUUKIN_DAY";
            _localTelNo.PhysicsName = "LOCAL_TEL_NO";
            _lostDay.PhysicsName = "LOST_DAY";
            _lostFlg.PhysicsName = "LOST_FLG";
            _mailAddress.PhysicsName = "MAIL_ADDRESS";
            _mailSendingKbn.PhysicsName = "MAIL_SENDING_KBN";
            _mediaCd.PhysicsName = "MEDIA_CD";
            _mediaName.PhysicsName = "MEDIA_NAME";
            _meiboSeq.PhysicsName = "MEIBO_SEQ";
            _messageCheckFlg1.PhysicsName = "MESSAGE_CHECK_FLG_1";
            _messageCheckFlg2.PhysicsName = "MESSAGE_CHECK_FLG_2";
            _messageCheckFlg3.PhysicsName = "MESSAGE_CHECK_FLG_3";
            _messageCheckFlg4.PhysicsName = "MESSAGE_CHECK_FLG_4";
            _messageCheckFlg5.PhysicsName = "MESSAGE_CHECK_FLG_5";
            _messageCheckFlg6.PhysicsName = "MESSAGE_CHECK_FLG_6";
            _messageCheckFlg7.PhysicsName = "MESSAGE_CHECK_FLG_7";
            _messageCheckFlg8.PhysicsName = "MESSAGE_CHECK_FLG_8";
            _messageCheckFlg9.PhysicsName = "MESSAGE_CHECK_FLG_9";
            _messageCheckFlg10.PhysicsName = "MESSAGE_CHECK_FLG_10";
            _surname.PhysicsName = "SURNAME";
            _name.PhysicsName = "NAME";
            _surnameKj.PhysicsName = "SURNAME_KJ";
            _nameKj.PhysicsName = "NAME_KJ";
            _noShowFlg.PhysicsName = "NO_SHOW_FLG";
            _nyukingakuSokei.PhysicsName = "NYUKINGAKU_SOKEI";
            _nyuukinSituationKbn.PhysicsName = "NYUUKIN_SITUATION_KBN";
            _oldGousya.PhysicsName = "OLD_GOUSYA";
            _oldZaseki.PhysicsName = "OLD_ZASEKI";
            _receiptIssueFlg.PhysicsName = "RECEIPT_ISSUE_FLG";
            _relationYoyakuKbn.PhysicsName = "RELATION_YOYAKU_KBN";
            _relationYoyakuNo.PhysicsName = "RELATION_YOYAKU_NO";
            _returnDay.PhysicsName = "RETURN_DAY";
            _roomingBetuNinzu1.PhysicsName = "ROOMING_BETU_NINZU_1";
            _roomingBetuNinzu2.PhysicsName = "ROOMING_BETU_NINZU_2";
            _roomingBetuNinzu3.PhysicsName = "ROOMING_BETU_NINZU_3";
            _roomingBetuNinzu4.PhysicsName = "ROOMING_BETU_NINZU_4";
            _roomingBetuNinzu5.PhysicsName = "ROOMING_BETU_NINZU_5";
            _saikouKakuteiGuideOutDay.PhysicsName = "SAIKOU_KAKUTEI_GUIDE_OUT_DAY";
            _seikiChargeAllGaku.PhysicsName = "SEIKI_CHARGE_ALL_GAKU";
            _seikyusyoYohiFlg.PhysicsName = "SEIKYUSYO_YOHI_FLG";
            _seisanHoho.PhysicsName = "SEISAN_HOHO";
            _sexBetu.PhysicsName = "SEX_BETU";
            _siharaiHoho.PhysicsName = "SIHARAI_HOHO";
            _sonotaNyuukinHenkin.PhysicsName = "SONOTA_NYUUKIN_HENKIN";
            _sponsorshipKeiyakuKbn.PhysicsName = "SPONSORSHIP_KEIYAKU_KBN";
            _state.PhysicsName = "STATE";
            _syugoTime1.PhysicsName = "SYUGO_TIME_1";
            _syugoTime2.PhysicsName = "SYUGO_TIME_2";
            _syugoTime3.PhysicsName = "SYUGO_TIME_3";
            _syugoTime4.PhysicsName = "SYUGO_TIME_4";
            _syugoTime5.PhysicsName = "SYUGO_TIME_5";
            _syuptDay.PhysicsName = "SYUPT_DAY";
            _syuptTime1.PhysicsName = "SYUPT_TIME_1";
            _syuptTime2.PhysicsName = "SYUPT_TIME_2";
            _syuptTime3.PhysicsName = "SYUPT_TIME_3";
            _syuptTime4.PhysicsName = "SYUPT_TIME_4";
            _syuptTime5.PhysicsName = "SYUPT_TIME_5";
            _tasyaKennoKingaku.PhysicsName = "TASYA_KENNO_KINGAKU";
            _tasyaYoyakuNo.PhysicsName = "TASYA_YOYAKU_NO";
            _teikiKeiyakuKbn.PhysicsName = "TEIKI_KEIYAKU_KBN";
            _teikiKikakuKbn.PhysicsName = "TEIKI_KIKAKU_KBN";
            _telNo1.PhysicsName = "TEL_NO_1";
            _telNo11.PhysicsName = "TEL_NO_1_1";
            _telNo12.PhysicsName = "TEL_NO_1_2";
            _telNo13.PhysicsName = "TEL_NO_1_3";
            _telNo2.PhysicsName = "TEL_NO_2";
            _telNo21.PhysicsName = "TEL_NO_2_1";
            _telNo22.PhysicsName = "TEL_NO_2_2";
            _telNo23.PhysicsName = "TEL_NO_2_3";
            _tobiSeatFlg.PhysicsName = "TOBI_SEAT_FLG";
            _tomonokaiNo.PhysicsName = "TOMONOKAI_NO";
            _kaiinNo.PhysicsName = "KAIIN_NO";
            _toriatukaiFeeCancel.PhysicsName = "TORIATUKAI_FEE_CANCEL";
            _toriatukaiFeeSagaku.PhysicsName = "TORIATUKAI_FEE_SAGAKU";
            _toriatukaiFeeUriage.PhysicsName = "TORIATUKAI_FEE_URIAGE";
            _toursNo.PhysicsName = "TOURS_NO";
            _unkyuContactDay.PhysicsName = "UNKYU_CONTACT_DAY";
            _updateDay.PhysicsName = "UPDATE_DAY";
            _updatePersonCd.PhysicsName = "UPDATE_PERSON_CD";
            _updatePgmid.PhysicsName = "UPDATE_PGMID";
            _updateTime.PhysicsName = "UPDATE_TIME";
            _usingFlg.PhysicsName = "USING_FLG";
            _waribikiAllGaku.PhysicsName = "WARIBIKI_ALL_GAKU";
            _year.PhysicsName = "YEAR";
            _yobi1.PhysicsName = "YOBI_1";
            _yobi2.PhysicsName = "YOBI_2";
            _yobi3.PhysicsName = "YOBI_3";
            _yobi4.PhysicsName = "YOBI_4";
            _yobi5.PhysicsName = "YOBI_5";
            _yobi6.PhysicsName = "YOBI_6";
            _yobi7.PhysicsName = "YOBI_7";
            _yoyakuJiAgentCd.PhysicsName = "YOYAKU_JI_AGENT_CD";
            _yoyakuJiAgentName.PhysicsName = "YOYAKU_JI_AGENT_NAME";
            _yoyakuKakuninDay.PhysicsName = "YOYAKU_KAKUNIN_DAY";
            _yoyakuUketukeKbn.PhysicsName = "YOYAKU_UKETUKE_KBN";
            _yoyakuZasekiGetKbn.PhysicsName = "YOYAKU_ZASEKI_GET_KBN";
            _yoyakuZasekiKbn.PhysicsName = "YOYAKU_ZASEKI_KBN";
            _yubinNo.PhysicsName = "YUBIN_NO";
            _yykmks.PhysicsName = "YYKMKS";
            _zaseki.PhysicsName = "ZASEKI";
            _zasekiChangeUmu.PhysicsName = "ZASEKI_CHANGE_UMU";
            _zasekiReserveYoyakuFlg.PhysicsName = "ZASEKI_RESERVE_YOYAKU_FLG";
            _subSeatWaitFlg.PhysicsName = "SUB_SEAT_WAIT_FLG";
            _motoYoyakuKbn.PhysicsName = "MOTO_YOYAKU_KBN";
            _motoYoyakuNo.PhysicsName = "MOTO_YOYAKU_NO";
            _entrySectionCd.PhysicsName = "ENTRY_SECTION_CD";
            _systemEntryPgmid.PhysicsName = "SYSTEM_ENTRY_PGMID";
            _systemEntryPersonCd.PhysicsName = "SYSTEM_ENTRY_PERSON_CD";
            _systemEntryDay.PhysicsName = "SYSTEM_ENTRY_DAY";
            _systemUpdatePgmid.PhysicsName = "SYSTEM_UPDATE_PGMID";
            _systemUpdatePersonCd.PhysicsName = "SYSTEM_UPDATE_PERSON_CD";
            _systemUpdateDay.PhysicsName = "SYSTEM_UPDATE_DAY";


            _yoyakuKbn.Required = false;
            _yoyakuNo.Required = false;
            _address1.Required = false;
            _address2.Required = false;
            _address3.Required = false;
            _moshikomiHotelFlg.Required = false;
            _addChargeMaebaraiKei.Required = false;
            _addChargeTojituPaymentKei.Required = false;
            _afStayYoyakuSglNum.Required = false;
            _afStayYoyakuTwnNum.Required = false;
            _agentCd.Required = false;
            _agentNameKana.Required = false;
            _agentNm.Required = false;
            _agentTantosya.Required = false;
            _agentTelNo.Required = false;
            _agentTelNo1.Required = false;
            _agentTelNo2.Required = false;
            _agentTelNo3.Required = false;
            _agentYoyakuCd.Required = false;
            _agentSeisanKbn.Required = false;
            _aibeyaFlg.Required = false;
            _birthday.Required = false;
            _cancelFlg.Required = false;
            _seatOnlyCancelFlg.Required = false;
            _cancelRyouKei.Required = false;
            _changeHistoryLastDay.Required = false;
            _changeHistoryLastSeq.Required = false;
            _checkinFlg1.Required = false;
            _checkinFlg2.Required = false;
            _checkinFlg3.Required = false;
            _checkinFlg4.Required = false;
            _checkinFlg5.Required = false;
            _checkinNinzu1.Required = false;
            _checkinNinzu2.Required = false;
            _checkinNinzu3.Required = false;
            _checkinNinzu4.Required = false;
            _checkinNinzu5.Required = false;
            _infantNinzu.Required = false;
            _crsCd.Required = false;
            _crsKbn1.Required = false;
            _crsKbn2.Required = false;
            _crsKind.Required = false;
            _deleteDay.Required = false;
            _entryDay.Required = false;
            _entryPersonCd.Required = false;
            _entryPgmid.Required = false;
            _entryTime.Required = false;
            _fujyoProofIssueFlg.Required = false;
            _furikomiyoshiYohiFlg.Required = false;
            _gousya.Required = false;
            _groupNo.Required = false;
            _hakkenDay.Required = false;
            _hakkenEigyosyoCd.Required = false;
            _hakkenKingaku.Required = false;
            _hakkenNaiyo.Required = false;
            _hakkenTantosyaCd.Required = false;
            _itineraryTablePrintAlready.Required = false;
            _itineraryTablePrintDay.Required = false;
            _jyochachiCd1.Required = false;
            _jyochachiCd2.Required = false;
            _jyochachiCd3.Required = false;
            _jyochachiCd4.Required = false;
            _jyochachiCd5.Required = false;
            _jyoseiSenyo.Required = false;
            _jyosyaNinzu1.Required = false;
            _jyosyaNinzu2.Required = false;
            _jyosyaNinzu3.Required = false;
            _jyosyaNinzu4.Required = false;
            _jyosyaNinzu5.Required = false;
            _kokuseki.Required = false;
            _lastHenkinDay.Required = false;
            _lastNyuukinDay.Required = false;
            _localTelNo.Required = false;
            _lostDay.Required = false;
            _lostFlg.Required = false;
            _mailAddress.Required = false;
            _mailSendingKbn.Required = false;
            _mediaCd.Required = false;
            _mediaName.Required = false;
            _meiboSeq.Required = false;
            _messageCheckFlg1.Required = false;
            _messageCheckFlg2.Required = false;
            _messageCheckFlg3.Required = false;
            _messageCheckFlg4.Required = false;
            _messageCheckFlg5.Required = false;
            _messageCheckFlg6.Required = false;
            _messageCheckFlg7.Required = false;
            _messageCheckFlg8.Required = false;
            _messageCheckFlg9.Required = false;
            _messageCheckFlg10.Required = false;
            _surname.Required = false;
            _name.Required = false;
            _surnameKj.Required = false;
            _nameKj.Required = false;
            _noShowFlg.Required = false;
            _nyukingakuSokei.Required = false;
            _nyuukinSituationKbn.Required = false;
            _oldGousya.Required = false;
            _oldZaseki.Required = false;
            _receiptIssueFlg.Required = false;
            _relationYoyakuKbn.Required = false;
            _relationYoyakuNo.Required = false;
            _returnDay.Required = false;
            _roomingBetuNinzu1.Required = false;
            _roomingBetuNinzu2.Required = false;
            _roomingBetuNinzu3.Required = false;
            _roomingBetuNinzu4.Required = false;
            _roomingBetuNinzu5.Required = false;
            _saikouKakuteiGuideOutDay.Required = false;
            _seikiChargeAllGaku.Required = false;
            _seikyusyoYohiFlg.Required = false;
            _seisanHoho.Required = false;
            _sexBetu.Required = false;
            _siharaiHoho.Required = false;
            _sonotaNyuukinHenkin.Required = false;
            _sponsorshipKeiyakuKbn.Required = false;
            _state.Required = false;
            _syugoTime1.Required = false;
            _syugoTime2.Required = false;
            _syugoTime3.Required = false;
            _syugoTime4.Required = false;
            _syugoTime5.Required = false;
            _syuptDay.Required = false;
            _syuptTime1.Required = false;
            _syuptTime2.Required = false;
            _syuptTime3.Required = false;
            _syuptTime4.Required = false;
            _syuptTime5.Required = false;
            _tasyaKennoKingaku.Required = false;
            _tasyaYoyakuNo.Required = false;
            _teikiKeiyakuKbn.Required = false;
            _teikiKikakuKbn.Required = false;
            _telNo1.Required = false;
            _telNo11.Required = false;
            _telNo12.Required = false;
            _telNo13.Required = false;
            _telNo2.Required = false;
            _telNo21.Required = false;
            _telNo22.Required = false;
            _telNo23.Required = false;
            _tobiSeatFlg.Required = false;
            _tomonokaiNo.Required = false;
            _kaiinNo.Required = false;
            _toriatukaiFeeCancel.Required = false;
            _toriatukaiFeeSagaku.Required = false;
            _toriatukaiFeeUriage.Required = false;
            _toursNo.Required = false;
            _unkyuContactDay.Required = false;
            _updateDay.Required = false;
            _updatePersonCd.Required = false;
            _updatePgmid.Required = false;
            _updateTime.Required = false;
            _usingFlg.Required = false;
            _waribikiAllGaku.Required = false;
            _year.Required = false;
            _yobi1.Required = false;
            _yobi2.Required = false;
            _yobi3.Required = false;
            _yobi4.Required = false;
            _yobi5.Required = false;
            _yobi6.Required = false;
            _yobi7.Required = false;
            _yoyakuJiAgentCd.Required = false;
            _yoyakuJiAgentName.Required = false;
            _yoyakuKakuninDay.Required = false;
            _yoyakuUketukeKbn.Required = false;
            _yoyakuZasekiGetKbn.Required = false;
            _yoyakuZasekiKbn.Required = false;
            _yubinNo.Required = false;
            _yykmks.Required = false;
            _zaseki.Required = false;
            _zasekiChangeUmu.Required = false;
            _zasekiReserveYoyakuFlg.Required = false;
            _subSeatWaitFlg.Required = false;
            _motoYoyakuKbn.Required = false;
            _motoYoyakuNo.Required = false;
            _entrySectionCd.Required = false;
            _systemEntryPgmid.Required = true;
            _systemEntryPersonCd.Required = true;
            _systemEntryDay.Required = true;
            _systemUpdatePgmid.Required = true;
            _systemUpdatePersonCd.Required = true;
            _systemUpdateDay.Required = true;


            _yoyakuKbn.DBType = OracleDbType.Char;
            _yoyakuNo.DBType = OracleDbType.Decimal;
            _address1.DBType = OracleDbType.Varchar2;
            _address2.DBType = OracleDbType.Varchar2;
            _address3.DBType = OracleDbType.Varchar2;
            _moshikomiHotelFlg.DBType = OracleDbType.Char;
            _addChargeMaebaraiKei.DBType = OracleDbType.Decimal;
            _addChargeTojituPaymentKei.DBType = OracleDbType.Decimal;
            _afStayYoyakuSglNum.DBType = OracleDbType.Decimal;
            _afStayYoyakuTwnNum.DBType = OracleDbType.Decimal;
            _agentCd.DBType = OracleDbType.Char;
            _agentNameKana.DBType = OracleDbType.Varchar2;
            _agentNm.DBType = OracleDbType.Varchar2;
            _agentTantosya.DBType = OracleDbType.Varchar2;
            _agentTelNo.DBType = OracleDbType.Varchar2;
            _agentTelNo1.DBType = OracleDbType.Varchar2;
            _agentTelNo2.DBType = OracleDbType.Varchar2;
            _agentTelNo3.DBType = OracleDbType.Varchar2;
            _agentYoyakuCd.DBType = OracleDbType.Char;
            _agentSeisanKbn.DBType = OracleDbType.Char;
            _aibeyaFlg.DBType = OracleDbType.Char;
            _birthday.DBType = OracleDbType.Decimal;
            _cancelFlg.DBType = OracleDbType.Char;
            _seatOnlyCancelFlg.DBType = OracleDbType.Char;
            _cancelRyouKei.DBType = OracleDbType.Decimal;
            _changeHistoryLastDay.DBType = OracleDbType.Decimal;
            _changeHistoryLastSeq.DBType = OracleDbType.Decimal;
            _checkinFlg1.DBType = OracleDbType.Char;
            _checkinFlg2.DBType = OracleDbType.Char;
            _checkinFlg3.DBType = OracleDbType.Char;
            _checkinFlg4.DBType = OracleDbType.Char;
            _checkinFlg5.DBType = OracleDbType.Char;
            _checkinNinzu1.DBType = OracleDbType.Decimal;
            _checkinNinzu2.DBType = OracleDbType.Decimal;
            _checkinNinzu3.DBType = OracleDbType.Decimal;
            _checkinNinzu4.DBType = OracleDbType.Decimal;
            _checkinNinzu5.DBType = OracleDbType.Decimal;
            _infantNinzu.DBType = OracleDbType.Decimal;
            _crsCd.DBType = OracleDbType.Char;
            _crsKbn1.DBType = OracleDbType.Char;
            _crsKbn2.DBType = OracleDbType.Char;
            _crsKind.DBType = OracleDbType.Char;
            _deleteDay.DBType = OracleDbType.Decimal;
            _entryDay.DBType = OracleDbType.Decimal;
            _entryPersonCd.DBType = OracleDbType.Varchar2;
            _entryPgmid.DBType = OracleDbType.Char;
            _entryTime.DBType = OracleDbType.Decimal;
            _fujyoProofIssueFlg.DBType = OracleDbType.Char;
            _furikomiyoshiYohiFlg.DBType = OracleDbType.Char;
            _gousya.DBType = OracleDbType.Decimal;
            _groupNo.DBType = OracleDbType.Decimal;
            _hakkenDay.DBType = OracleDbType.Decimal;
            _hakkenEigyosyoCd.DBType = OracleDbType.Char;
            _hakkenKingaku.DBType = OracleDbType.Decimal;
            _hakkenNaiyo.DBType = OracleDbType.Char;
            _hakkenTantosyaCd.DBType = OracleDbType.Varchar2;
            _itineraryTablePrintAlready.DBType = OracleDbType.Char;
            _itineraryTablePrintDay.DBType = OracleDbType.Decimal;
            _jyochachiCd1.DBType = OracleDbType.Char;
            _jyochachiCd2.DBType = OracleDbType.Char;
            _jyochachiCd3.DBType = OracleDbType.Char;
            _jyochachiCd4.DBType = OracleDbType.Char;
            _jyochachiCd5.DBType = OracleDbType.Char;
            _jyoseiSenyo.DBType = OracleDbType.Char;
            _jyosyaNinzu1.DBType = OracleDbType.Decimal;
            _jyosyaNinzu2.DBType = OracleDbType.Decimal;
            _jyosyaNinzu3.DBType = OracleDbType.Decimal;
            _jyosyaNinzu4.DBType = OracleDbType.Decimal;
            _jyosyaNinzu5.DBType = OracleDbType.Decimal;
            _kokuseki.DBType = OracleDbType.Varchar2;
            _lastHenkinDay.DBType = OracleDbType.Decimal;
            _lastNyuukinDay.DBType = OracleDbType.Decimal;
            _localTelNo.DBType = OracleDbType.Varchar2;
            _lostDay.DBType = OracleDbType.Decimal;
            _lostFlg.DBType = OracleDbType.Char;
            _mailAddress.DBType = OracleDbType.Char;
            _mailSendingKbn.DBType = OracleDbType.Char;
            _mediaCd.DBType = OracleDbType.Char;
            _mediaName.DBType = OracleDbType.Varchar2;
            _meiboSeq.DBType = OracleDbType.Decimal;
            _messageCheckFlg1.DBType = OracleDbType.Char;
            _messageCheckFlg2.DBType = OracleDbType.Char;
            _messageCheckFlg3.DBType = OracleDbType.Char;
            _messageCheckFlg4.DBType = OracleDbType.Char;
            _messageCheckFlg5.DBType = OracleDbType.Char;
            _messageCheckFlg6.DBType = OracleDbType.Char;
            _messageCheckFlg7.DBType = OracleDbType.Char;
            _messageCheckFlg8.DBType = OracleDbType.Char;
            _messageCheckFlg9.DBType = OracleDbType.Char;
            _messageCheckFlg10.DBType = OracleDbType.Char;
            _surname.DBType = OracleDbType.Varchar2;
            _name.DBType = OracleDbType.Varchar2;
            _surnameKj.DBType = OracleDbType.Varchar2;
            _nameKj.DBType = OracleDbType.Varchar2;
            _noShowFlg.DBType = OracleDbType.Char;
            _nyukingakuSokei.DBType = OracleDbType.Decimal;
            _nyuukinSituationKbn.DBType = OracleDbType.Char;
            _oldGousya.DBType = OracleDbType.Decimal;
            _oldZaseki.DBType = OracleDbType.Char;
            _receiptIssueFlg.DBType = OracleDbType.Char;
            _relationYoyakuKbn.DBType = OracleDbType.Char;
            _relationYoyakuNo.DBType = OracleDbType.Decimal;
            _returnDay.DBType = OracleDbType.Decimal;
            _roomingBetuNinzu1.DBType = OracleDbType.Decimal;
            _roomingBetuNinzu2.DBType = OracleDbType.Decimal;
            _roomingBetuNinzu3.DBType = OracleDbType.Decimal;
            _roomingBetuNinzu4.DBType = OracleDbType.Decimal;
            _roomingBetuNinzu5.DBType = OracleDbType.Decimal;
            _saikouKakuteiGuideOutDay.DBType = OracleDbType.Decimal;
            _seikiChargeAllGaku.DBType = OracleDbType.Decimal;
            _seikyusyoYohiFlg.DBType = OracleDbType.Char;
            _seisanHoho.DBType = OracleDbType.Char;
            _sexBetu.DBType = OracleDbType.Char;
            _siharaiHoho.DBType = OracleDbType.Char;
            _sonotaNyuukinHenkin.DBType = OracleDbType.Decimal;
            _sponsorshipKeiyakuKbn.DBType = OracleDbType.Char;
            _state.DBType = OracleDbType.Char;
            _syugoTime1.DBType = OracleDbType.Decimal;
            _syugoTime2.DBType = OracleDbType.Decimal;
            _syugoTime3.DBType = OracleDbType.Decimal;
            _syugoTime4.DBType = OracleDbType.Decimal;
            _syugoTime5.DBType = OracleDbType.Decimal;
            _syuptDay.DBType = OracleDbType.Decimal;
            _syuptTime1.DBType = OracleDbType.Decimal;
            _syuptTime2.DBType = OracleDbType.Decimal;
            _syuptTime3.DBType = OracleDbType.Decimal;
            _syuptTime4.DBType = OracleDbType.Decimal;
            _syuptTime5.DBType = OracleDbType.Decimal;
            _tasyaKennoKingaku.DBType = OracleDbType.Decimal;
            _tasyaYoyakuNo.DBType = OracleDbType.Decimal;
            _teikiKeiyakuKbn.DBType = OracleDbType.Char;
            _teikiKikakuKbn.DBType = OracleDbType.Char;
            _telNo1.DBType = OracleDbType.Varchar2;
            _telNo11.DBType = OracleDbType.Varchar2;
            _telNo12.DBType = OracleDbType.Varchar2;
            _telNo13.DBType = OracleDbType.Varchar2;
            _telNo2.DBType = OracleDbType.Varchar2;
            _telNo21.DBType = OracleDbType.Varchar2;
            _telNo22.DBType = OracleDbType.Varchar2;
            _telNo23.DBType = OracleDbType.Varchar2;
            _tobiSeatFlg.DBType = OracleDbType.Char;
            _tomonokaiNo.DBType = OracleDbType.Decimal;
            _kaiinNo.DBType = OracleDbType.Decimal;
            _toriatukaiFeeCancel.DBType = OracleDbType.Decimal;
            _toriatukaiFeeSagaku.DBType = OracleDbType.Decimal;
            _toriatukaiFeeUriage.DBType = OracleDbType.Decimal;
            _toursNo.DBType = OracleDbType.Char;
            _unkyuContactDay.DBType = OracleDbType.Decimal;
            _updateDay.DBType = OracleDbType.Decimal;
            _updatePersonCd.DBType = OracleDbType.Varchar2;
            _updatePgmid.DBType = OracleDbType.Char;
            _updateTime.DBType = OracleDbType.Decimal;
            _usingFlg.DBType = OracleDbType.Char;
            _waribikiAllGaku.DBType = OracleDbType.Decimal;
            _year.DBType = OracleDbType.Decimal;
            _yobi1.DBType = OracleDbType.Char;
            _yobi2.DBType = OracleDbType.Char;
            _yobi3.DBType = OracleDbType.Char;
            _yobi4.DBType = OracleDbType.Char;
            _yobi5.DBType = OracleDbType.Char;
            _yobi6.DBType = OracleDbType.Varchar2;
            _yobi7.DBType = OracleDbType.Decimal;
            _yoyakuJiAgentCd.DBType = OracleDbType.Char;
            _yoyakuJiAgentName.DBType = OracleDbType.Varchar2;
            _yoyakuKakuninDay.DBType = OracleDbType.Decimal;
            _yoyakuUketukeKbn.DBType = OracleDbType.Char;
            _yoyakuZasekiGetKbn.DBType = OracleDbType.Char;
            _yoyakuZasekiKbn.DBType = OracleDbType.Char;
            _yubinNo.DBType = OracleDbType.Char;
            _yykmks.DBType = OracleDbType.Varchar2;
            _zaseki.DBType = OracleDbType.Char;
            _zasekiChangeUmu.DBType = OracleDbType.Char;
            _zasekiReserveYoyakuFlg.DBType = OracleDbType.Char;
            _subSeatWaitFlg.DBType = OracleDbType.Char;
            _motoYoyakuKbn.DBType = OracleDbType.Char;
            _motoYoyakuNo.DBType = OracleDbType.Decimal;
            _entrySectionCd.DBType = OracleDbType.Varchar2;
            _systemEntryPgmid.DBType = OracleDbType.Char;
            _systemEntryPersonCd.DBType = OracleDbType.Varchar2;
            _systemEntryDay.DBType = OracleDbType.Date;
            _systemUpdatePgmid.DBType = OracleDbType.Char;
            _systemUpdatePersonCd.DBType = OracleDbType.Varchar2;
            _systemUpdateDay.DBType = OracleDbType.Date;


            _yoyakuKbn.IntegerBu = 1;
            _yoyakuNo.IntegerBu = 9;
            _address1.IntegerBu = 30;
            _address2.IntegerBu = 30;
            _address3.IntegerBu = 30;
            _moshikomiHotelFlg.IntegerBu = 1;
            _addChargeMaebaraiKei.IntegerBu = 7;
            _addChargeTojituPaymentKei.IntegerBu = 7;
            _afStayYoyakuSglNum.IntegerBu = 2;
            _afStayYoyakuTwnNum.IntegerBu = 2;
            _agentCd.IntegerBu = 8;
            _agentNameKana.IntegerBu = 20;
            _agentNm.IntegerBu = 42;
            _agentTantosya.IntegerBu = 20;
            _agentTelNo.IntegerBu = 13;
            _agentTelNo1.IntegerBu = 5;
            _agentTelNo2.IntegerBu = 4;
            _agentTelNo3.IntegerBu = 4;
            _agentYoyakuCd.IntegerBu = 12;
            _agentSeisanKbn.IntegerBu = 1;
            _aibeyaFlg.IntegerBu = 1;
            _birthday.IntegerBu = 8;
            _cancelFlg.IntegerBu = 1;
            _seatOnlyCancelFlg.IntegerBu = 1;
            _cancelRyouKei.IntegerBu = 7;
            _changeHistoryLastDay.IntegerBu = 8;
            _changeHistoryLastSeq.IntegerBu = 2;
            _checkinFlg1.IntegerBu = 1;
            _checkinFlg2.IntegerBu = 1;
            _checkinFlg3.IntegerBu = 1;
            _checkinFlg4.IntegerBu = 1;
            _checkinFlg5.IntegerBu = 1;
            _checkinNinzu1.IntegerBu = 3;
            _checkinNinzu2.IntegerBu = 3;
            _checkinNinzu3.IntegerBu = 3;
            _checkinNinzu4.IntegerBu = 3;
            _checkinNinzu5.IntegerBu = 3;
            _infantNinzu.IntegerBu = 2;
            _crsCd.IntegerBu = 6;
            _crsKbn1.IntegerBu = 1;
            _crsKbn2.IntegerBu = 1;
            _crsKind.IntegerBu = 1;
            _deleteDay.IntegerBu = 8;
            _entryDay.IntegerBu = 8;
            _entryPersonCd.IntegerBu = 20;
            _entryPgmid.IntegerBu = 8;
            _entryTime.IntegerBu = 6;
            _fujyoProofIssueFlg.IntegerBu = 1;
            _furikomiyoshiYohiFlg.IntegerBu = 1;
            _gousya.IntegerBu = 3;
            _groupNo.IntegerBu = 3;
            _hakkenDay.IntegerBu = 8;
            _hakkenEigyosyoCd.IntegerBu = 2;
            _hakkenKingaku.IntegerBu = 7;
            _hakkenNaiyo.IntegerBu = 1;
            _hakkenTantosyaCd.IntegerBu = 20;
            _itineraryTablePrintAlready.IntegerBu = 1;
            _itineraryTablePrintDay.IntegerBu = 8;
            _jyochachiCd1.IntegerBu = 3;
            _jyochachiCd2.IntegerBu = 3;
            _jyochachiCd3.IntegerBu = 3;
            _jyochachiCd4.IntegerBu = 3;
            _jyochachiCd5.IntegerBu = 3;
            _jyoseiSenyo.IntegerBu = 1;
            _jyosyaNinzu1.IntegerBu = 3;
            _jyosyaNinzu2.IntegerBu = 3;
            _jyosyaNinzu3.IntegerBu = 3;
            _jyosyaNinzu4.IntegerBu = 3;
            _jyosyaNinzu5.IntegerBu = 3;
            _kokuseki.IntegerBu = 80;
            _lastHenkinDay.IntegerBu = 8;
            _lastNyuukinDay.IntegerBu = 8;
            _localTelNo.IntegerBu = 50;
            _lostDay.IntegerBu = 8;
            _lostFlg.IntegerBu = 1;
            _mailAddress.IntegerBu = 65;
            _mailSendingKbn.IntegerBu = 1;
            _mediaCd.IntegerBu = 2;
            _mediaName.IntegerBu = 16;
            _meiboSeq.IntegerBu = 2;
            _messageCheckFlg1.IntegerBu = 1;
            _messageCheckFlg2.IntegerBu = 1;
            _messageCheckFlg3.IntegerBu = 1;
            _messageCheckFlg4.IntegerBu = 1;
            _messageCheckFlg5.IntegerBu = 1;
            _messageCheckFlg6.IntegerBu = 1;
            _messageCheckFlg7.IntegerBu = 1;
            _messageCheckFlg8.IntegerBu = 1;
            _messageCheckFlg9.IntegerBu = 1;
            _messageCheckFlg10.IntegerBu = 1;
            _surname.IntegerBu = 20;
            _name.IntegerBu = 20;
            _surnameKj.IntegerBu = 20;
            _nameKj.IntegerBu = 20;
            _noShowFlg.IntegerBu = 1;
            _nyukingakuSokei.IntegerBu = 7;
            _nyuukinSituationKbn.IntegerBu = 1;
            _oldGousya.IntegerBu = 3;
            _oldZaseki.IntegerBu = 24;
            _receiptIssueFlg.IntegerBu = 1;
            _relationYoyakuKbn.IntegerBu = 1;
            _relationYoyakuNo.IntegerBu = 9;
            _returnDay.IntegerBu = 8;
            _roomingBetuNinzu1.IntegerBu = 3;
            _roomingBetuNinzu2.IntegerBu = 3;
            _roomingBetuNinzu3.IntegerBu = 3;
            _roomingBetuNinzu4.IntegerBu = 3;
            _roomingBetuNinzu5.IntegerBu = 3;
            _saikouKakuteiGuideOutDay.IntegerBu = 8;
            _seikiChargeAllGaku.IntegerBu = 7;
            _seikyusyoYohiFlg.IntegerBu = 1;
            _seisanHoho.IntegerBu = 1;
            _sexBetu.IntegerBu = 1;
            _siharaiHoho.IntegerBu = 1;
            _sonotaNyuukinHenkin.IntegerBu = 7;
            _sponsorshipKeiyakuKbn.IntegerBu = 1;
            _state.IntegerBu = 1;
            _syugoTime1.IntegerBu = 4;
            _syugoTime2.IntegerBu = 4;
            _syugoTime3.IntegerBu = 4;
            _syugoTime4.IntegerBu = 4;
            _syugoTime5.IntegerBu = 4;
            _syuptDay.IntegerBu = 8;
            _syuptTime1.IntegerBu = 4;
            _syuptTime2.IntegerBu = 4;
            _syuptTime3.IntegerBu = 4;
            _syuptTime4.IntegerBu = 4;
            _syuptTime5.IntegerBu = 4;
            _tasyaKennoKingaku.IntegerBu = 9;
            _tasyaYoyakuNo.IntegerBu = 7;
            _teikiKeiyakuKbn.IntegerBu = 1;
            _teikiKikakuKbn.IntegerBu = 1;
            _telNo1.IntegerBu = 15;
            _telNo11.IntegerBu = 5;
            _telNo12.IntegerBu = 4;
            _telNo13.IntegerBu = 4;
            _telNo2.IntegerBu = 15;
            _telNo21.IntegerBu = 5;
            _telNo22.IntegerBu = 4;
            _telNo23.IntegerBu = 4;
            _tobiSeatFlg.IntegerBu = 1;
            _tomonokaiNo.IntegerBu = 6;
            _kaiinNo.IntegerBu = 9;
            _toriatukaiFeeCancel.IntegerBu = 7;
            _toriatukaiFeeSagaku.IntegerBu = 7;
            _toriatukaiFeeUriage.IntegerBu = 7;
            _toursNo.IntegerBu = 15;
            _unkyuContactDay.IntegerBu = 8;
            _updateDay.IntegerBu = 8;
            _updatePersonCd.IntegerBu = 20;
            _updatePgmid.IntegerBu = 8;
            _updateTime.IntegerBu = 6;
            _usingFlg.IntegerBu = 1;
            _waribikiAllGaku.IntegerBu = 7;
            _year.IntegerBu = 4;
            _yobi1.IntegerBu = 1;
            _yobi2.IntegerBu = 1;
            _yobi3.IntegerBu = 1;
            _yobi4.IntegerBu = 1;
            _yobi5.IntegerBu = 1;
            _yobi6.IntegerBu = 42;
            _yobi7.IntegerBu = 8;
            _yoyakuJiAgentCd.IntegerBu = 8;
            _yoyakuJiAgentName.IntegerBu = 42;
            _yoyakuKakuninDay.IntegerBu = 8;
            _yoyakuUketukeKbn.IntegerBu = 1;
            _yoyakuZasekiGetKbn.IntegerBu = 1;
            _yoyakuZasekiKbn.IntegerBu = 1;
            _yubinNo.IntegerBu = 7;
            _yykmks.IntegerBu = 20;
            _zaseki.IntegerBu = 90;
            _zasekiChangeUmu.IntegerBu = 1;
            _zasekiReserveYoyakuFlg.IntegerBu = 1;
            _subSeatWaitFlg.IntegerBu = 1;
            _motoYoyakuKbn.IntegerBu = 1;
            _motoYoyakuNo.IntegerBu = 9;
            _entrySectionCd.IntegerBu = 15;
            _systemEntryPgmid.IntegerBu = 8;
            _systemEntryPersonCd.IntegerBu = 20;
            _systemEntryDay.IntegerBu = 0;
            _systemUpdatePgmid.IntegerBu = 8;
            _systemUpdatePersonCd.IntegerBu = 20;
            _systemUpdateDay.IntegerBu = 0;


            _yoyakuKbn.DecimalBu = 0;
            _yoyakuNo.DecimalBu = 0;
            _address1.DecimalBu = 0;
            _address2.DecimalBu = 0;
            _address3.DecimalBu = 0;
            _moshikomiHotelFlg.DecimalBu = 0;
            _addChargeMaebaraiKei.DecimalBu = 0;
            _addChargeTojituPaymentKei.DecimalBu = 0;
            _afStayYoyakuSglNum.DecimalBu = 0;
            _afStayYoyakuTwnNum.DecimalBu = 0;
            _agentCd.DecimalBu = 0;
            _agentNameKana.DecimalBu = 0;
            _agentNm.DecimalBu = 0;
            _agentTantosya.DecimalBu = 0;
            _agentTelNo.DecimalBu = 0;
            _agentTelNo1.DecimalBu = 0;
            _agentTelNo2.DecimalBu = 0;
            _agentTelNo3.DecimalBu = 0;
            _agentYoyakuCd.DecimalBu = 0;
            _agentSeisanKbn.DecimalBu = 0;
            _aibeyaFlg.DecimalBu = 0;
            _birthday.DecimalBu = 0;
            _cancelFlg.DecimalBu = 0;
            _seatOnlyCancelFlg.DecimalBu = 0;
            _cancelRyouKei.DecimalBu = 0;
            _changeHistoryLastDay.DecimalBu = 0;
            _changeHistoryLastSeq.DecimalBu = 0;
            _checkinFlg1.DecimalBu = 0;
            _checkinFlg2.DecimalBu = 0;
            _checkinFlg3.DecimalBu = 0;
            _checkinFlg4.DecimalBu = 0;
            _checkinFlg5.DecimalBu = 0;
            _checkinNinzu1.DecimalBu = 0;
            _checkinNinzu2.DecimalBu = 0;
            _checkinNinzu3.DecimalBu = 0;
            _checkinNinzu4.DecimalBu = 0;
            _checkinNinzu5.DecimalBu = 0;
            _infantNinzu.DecimalBu = 0;
            _crsCd.DecimalBu = 0;
            _crsKbn1.DecimalBu = 0;
            _crsKbn2.DecimalBu = 0;
            _crsKind.DecimalBu = 0;
            _deleteDay.DecimalBu = 0;
            _entryDay.DecimalBu = 0;
            _entryPersonCd.DecimalBu = 0;
            _entryPgmid.DecimalBu = 0;
            _entryTime.DecimalBu = 0;
            _fujyoProofIssueFlg.DecimalBu = 0;
            _furikomiyoshiYohiFlg.DecimalBu = 0;
            _gousya.DecimalBu = 0;
            _groupNo.DecimalBu = 0;
            _hakkenDay.DecimalBu = 0;
            _hakkenEigyosyoCd.DecimalBu = 0;
            _hakkenKingaku.DecimalBu = 0;
            _hakkenNaiyo.DecimalBu = 0;
            _hakkenTantosyaCd.DecimalBu = 0;
            _itineraryTablePrintAlready.DecimalBu = 0;
            _itineraryTablePrintDay.DecimalBu = 0;
            _jyochachiCd1.DecimalBu = 0;
            _jyochachiCd2.DecimalBu = 0;
            _jyochachiCd3.DecimalBu = 0;
            _jyochachiCd4.DecimalBu = 0;
            _jyochachiCd5.DecimalBu = 0;
            _jyoseiSenyo.DecimalBu = 0;
            _jyosyaNinzu1.DecimalBu = 0;
            _jyosyaNinzu2.DecimalBu = 0;
            _jyosyaNinzu3.DecimalBu = 0;
            _jyosyaNinzu4.DecimalBu = 0;
            _jyosyaNinzu5.DecimalBu = 0;
            _kokuseki.DecimalBu = 0;
            _lastHenkinDay.DecimalBu = 0;
            _lastNyuukinDay.DecimalBu = 0;
            _localTelNo.DecimalBu = 0;
            _lostDay.DecimalBu = 0;
            _lostFlg.DecimalBu = 0;
            _mailAddress.DecimalBu = 0;
            _mailSendingKbn.DecimalBu = 0;
            _mediaCd.DecimalBu = 0;
            _mediaName.DecimalBu = 0;
            _meiboSeq.DecimalBu = 0;
            _messageCheckFlg1.DecimalBu = 0;
            _messageCheckFlg2.DecimalBu = 0;
            _messageCheckFlg3.DecimalBu = 0;
            _messageCheckFlg4.DecimalBu = 0;
            _messageCheckFlg5.DecimalBu = 0;
            _messageCheckFlg6.DecimalBu = 0;
            _messageCheckFlg7.DecimalBu = 0;
            _messageCheckFlg8.DecimalBu = 0;
            _messageCheckFlg9.DecimalBu = 0;
            _messageCheckFlg10.DecimalBu = 0;
            _surname.DecimalBu = 0;
            _name.DecimalBu = 0;
            _surnameKj.DecimalBu = 0;
            _nameKj.DecimalBu = 0;
            _noShowFlg.DecimalBu = 0;
            _nyukingakuSokei.DecimalBu = 0;
            _nyuukinSituationKbn.DecimalBu = 0;
            _oldGousya.DecimalBu = 0;
            _oldZaseki.DecimalBu = 0;
            _receiptIssueFlg.DecimalBu = 0;
            _relationYoyakuKbn.DecimalBu = 0;
            _relationYoyakuNo.DecimalBu = 0;
            _returnDay.DecimalBu = 0;
            _roomingBetuNinzu1.DecimalBu = 0;
            _roomingBetuNinzu2.DecimalBu = 0;
            _roomingBetuNinzu3.DecimalBu = 0;
            _roomingBetuNinzu4.DecimalBu = 0;
            _roomingBetuNinzu5.DecimalBu = 0;
            _saikouKakuteiGuideOutDay.DecimalBu = 0;
            _seikiChargeAllGaku.DecimalBu = 0;
            _seikyusyoYohiFlg.DecimalBu = 0;
            _seisanHoho.DecimalBu = 0;
            _sexBetu.DecimalBu = 0;
            _siharaiHoho.DecimalBu = 0;
            _sonotaNyuukinHenkin.DecimalBu = 0;
            _sponsorshipKeiyakuKbn.DecimalBu = 0;
            _state.DecimalBu = 0;
            _syugoTime1.DecimalBu = 0;
            _syugoTime2.DecimalBu = 0;
            _syugoTime3.DecimalBu = 0;
            _syugoTime4.DecimalBu = 0;
            _syugoTime5.DecimalBu = 0;
            _syuptDay.DecimalBu = 0;
            _syuptTime1.DecimalBu = 0;
            _syuptTime2.DecimalBu = 0;
            _syuptTime3.DecimalBu = 0;
            _syuptTime4.DecimalBu = 0;
            _syuptTime5.DecimalBu = 0;
            _tasyaKennoKingaku.DecimalBu = 0;
            _tasyaYoyakuNo.DecimalBu = 0;
            _teikiKeiyakuKbn.DecimalBu = 0;
            _teikiKikakuKbn.DecimalBu = 0;
            _telNo1.DecimalBu = 0;
            _telNo11.DecimalBu = 0;
            _telNo12.DecimalBu = 0;
            _telNo13.DecimalBu = 0;
            _telNo2.DecimalBu = 0;
            _telNo21.DecimalBu = 0;
            _telNo22.DecimalBu = 0;
            _telNo23.DecimalBu = 0;
            _tobiSeatFlg.DecimalBu = 0;
            _tomonokaiNo.DecimalBu = 0;
            _kaiinNo.DecimalBu = 0;
            _toriatukaiFeeCancel.DecimalBu = 0;
            _toriatukaiFeeSagaku.DecimalBu = 0;
            _toriatukaiFeeUriage.DecimalBu = 0;
            _toursNo.DecimalBu = 0;
            _unkyuContactDay.DecimalBu = 0;
            _updateDay.DecimalBu = 0;
            _updatePersonCd.DecimalBu = 0;
            _updatePgmid.DecimalBu = 0;
            _updateTime.DecimalBu = 0;
            _usingFlg.DecimalBu = 0;
            _waribikiAllGaku.DecimalBu = 0;
            _year.DecimalBu = 0;
            _yobi1.DecimalBu = 0;
            _yobi2.DecimalBu = 0;
            _yobi3.DecimalBu = 0;
            _yobi4.DecimalBu = 0;
            _yobi5.DecimalBu = 0;
            _yobi6.DecimalBu = 0;
            _yobi7.DecimalBu = 0;
            _yoyakuJiAgentCd.DecimalBu = 0;
            _yoyakuJiAgentName.DecimalBu = 0;
            _yoyakuKakuninDay.DecimalBu = 0;
            _yoyakuUketukeKbn.DecimalBu = 0;
            _yoyakuZasekiGetKbn.DecimalBu = 0;
            _yoyakuZasekiKbn.DecimalBu = 0;
            _yubinNo.DecimalBu = 0;
            _yykmks.DecimalBu = 0;
            _zaseki.DecimalBu = 0;
            _zasekiChangeUmu.DecimalBu = 0;
            _zasekiReserveYoyakuFlg.DecimalBu = 0;
            _subSeatWaitFlg.DecimalBu = 0;
            _motoYoyakuKbn.DecimalBu = 0;
            _motoYoyakuNo.DecimalBu = 0;
            _entrySectionCd.DecimalBu = 0;
            _systemEntryPgmid.DecimalBu = 0;
            _systemEntryPersonCd.DecimalBu = 0;
            _systemEntryDay.DecimalBu = 0;
            _systemUpdatePgmid.DecimalBu = 0;
            _systemUpdatePersonCd.DecimalBu = 0;
            _systemUpdateDay.DecimalBu = 0;
        }


        /// <summary>
        ///     ''' yoyakuKbn
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType yoyakuKbn
        {
            get
            {
                return _yoyakuKbn;
            }
            set
            {
                _yoyakuKbn = value;
            }
        }


        /// <summary>
        ///     ''' yoyakuNo
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType yoyakuNo
        {
            get
            {
                return _yoyakuNo;
            }
            set
            {
                _yoyakuNo = value;
            }
        }


        /// <summary>
        ///     ''' address1
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType address1
        {
            get
            {
                return _address1;
            }
            set
            {
                _address1 = value;
            }
        }


        /// <summary>
        ///     ''' address2
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType address2
        {
            get
            {
                return _address2;
            }
            set
            {
                _address2 = value;
            }
        }


        /// <summary>
        ///     ''' address3
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType address3
        {
            get
            {
                return _address3;
            }
            set
            {
                _address3 = value;
            }
        }


        /// <summary>
        ///     ''' moshikomiHotelFlg
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType moshikomiHotelFlg
        {
            get
            {
                return _moshikomiHotelFlg;
            }
            set
            {
                _moshikomiHotelFlg = value;
            }
        }


        /// <summary>
        ///     ''' addChargeMaebaraiKei
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType addChargeMaebaraiKei
        {
            get
            {
                return _addChargeMaebaraiKei;
            }
            set
            {
                _addChargeMaebaraiKei = value;
            }
        }


        /// <summary>
        ///     ''' addChargeTojituPaymentKei
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType addChargeTojituPaymentKei
        {
            get
            {
                return _addChargeTojituPaymentKei;
            }
            set
            {
                _addChargeTojituPaymentKei = value;
            }
        }


        /// <summary>
        ///     ''' afStayYoyakuSglNum
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType afStayYoyakuSglNum
        {
            get
            {
                return _afStayYoyakuSglNum;
            }
            set
            {
                _afStayYoyakuSglNum = value;
            }
        }


        /// <summary>
        ///     ''' afStayYoyakuTwnNum
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType afStayYoyakuTwnNum
        {
            get
            {
                return _afStayYoyakuTwnNum;
            }
            set
            {
                _afStayYoyakuTwnNum = value;
            }
        }


        /// <summary>
        ///     ''' agentCd
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType agentCd
        {
            get
            {
                return _agentCd;
            }
            set
            {
                _agentCd = value;
            }
        }


        /// <summary>
        ///     ''' agentNameKana
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType agentNameKana
        {
            get
            {
                return _agentNameKana;
            }
            set
            {
                _agentNameKana = value;
            }
        }


        /// <summary>
        ///     ''' agentNm
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType agentNm
        {
            get
            {
                return _agentNm;
            }
            set
            {
                _agentNm = value;
            }
        }


        /// <summary>
        ///     ''' agentTantosya
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType agentTantosya
        {
            get
            {
                return _agentTantosya;
            }
            set
            {
                _agentTantosya = value;
            }
        }


        /// <summary>
        ///     ''' agentTelNo
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType agentTelNo
        {
            get
            {
                return _agentTelNo;
            }
            set
            {
                _agentTelNo = value;
            }
        }


        /// <summary>
        ///     ''' agentTelNo1
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType agentTelNo1
        {
            get
            {
                return _agentTelNo1;
            }
            set
            {
                _agentTelNo1 = value;
            }
        }


        /// <summary>
        ///     ''' agentTelNo2
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType agentTelNo2
        {
            get
            {
                return _agentTelNo2;
            }
            set
            {
                _agentTelNo2 = value;
            }
        }


        /// <summary>
        ///     ''' agentTelNo3
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType agentTelNo3
        {
            get
            {
                return _agentTelNo3;
            }
            set
            {
                _agentTelNo3 = value;
            }
        }


        /// <summary>
        ///     ''' agentYoyakuCd
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType agentYoyakuCd
        {
            get
            {
                return _agentYoyakuCd;
            }
            set
            {
                _agentYoyakuCd = value;
            }
        }


        /// <summary>
        ///     ''' agentSeisanKbn
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType agentSeisanKbn
        {
            get
            {
                return _agentSeisanKbn;
            }
            set
            {
                _agentSeisanKbn = value;
            }
        }


        /// <summary>
        ///     ''' aibeyaFlg
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType aibeyaFlg
        {
            get
            {
                return _aibeyaFlg;
            }
            set
            {
                _aibeyaFlg = value;
            }
        }


        /// <summary>
        ///     ''' birthday
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType birthday
        {
            get
            {
                return _birthday;
            }
            set
            {
                _birthday = value;
            }
        }


        /// <summary>
        ///     ''' cancelFlg
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType cancelFlg
        {
            get
            {
                return _cancelFlg;
            }
            set
            {
                _cancelFlg = value;
            }
        }


        /// <summary>
        ///     ''' seatOnlyCancelFlg
        ///     ''' </summary>
        ///     ''' <returns></returns>
        public EntityKoumoku_MojiType seatOnlyCancelFlg
        {
            get
            {
                return _seatOnlyCancelFlg;
            }
            set
            {
                _seatOnlyCancelFlg = value;
            }
        }


        /// <summary>
        ///     ''' cancelRyouKei
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType cancelRyouKei
        {
            get
            {
                return _cancelRyouKei;
            }
            set
            {
                _cancelRyouKei = value;
            }
        }


        /// <summary>
        ///     ''' changeHistoryLastDay
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType changeHistoryLastDay
        {
            get
            {
                return _changeHistoryLastDay;
            }
            set
            {
                _changeHistoryLastDay = value;
            }
        }


        /// <summary>
        ///     ''' changeHistoryLastSeq
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType changeHistoryLastSeq
        {
            get
            {
                return _changeHistoryLastSeq;
            }
            set
            {
                _changeHistoryLastSeq = value;
            }
        }


        /// <summary>
        ///     ''' checkinFlg1
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType checkinFlg1
        {
            get
            {
                return _checkinFlg1;
            }
            set
            {
                _checkinFlg1 = value;
            }
        }


        /// <summary>
        ///     ''' checkinFlg2
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType checkinFlg2
        {
            get
            {
                return _checkinFlg2;
            }
            set
            {
                _checkinFlg2 = value;
            }
        }


        /// <summary>
        ///     ''' checkinFlg3
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType checkinFlg3
        {
            get
            {
                return _checkinFlg3;
            }
            set
            {
                _checkinFlg3 = value;
            }
        }


        /// <summary>
        ///     ''' checkinFlg4
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType checkinFlg4
        {
            get
            {
                return _checkinFlg4;
            }
            set
            {
                _checkinFlg4 = value;
            }
        }


        /// <summary>
        ///     ''' checkinFlg5
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType checkinFlg5
        {
            get
            {
                return _checkinFlg5;
            }
            set
            {
                _checkinFlg5 = value;
            }
        }


        /// <summary>
        ///     ''' checkinNinzu1
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType checkinNinzu1
        {
            get
            {
                return _checkinNinzu1;
            }
            set
            {
                _checkinNinzu1 = value;
            }
        }


        /// <summary>
        ///     ''' checkinNinzu2
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType checkinNinzu2
        {
            get
            {
                return _checkinNinzu2;
            }
            set
            {
                _checkinNinzu2 = value;
            }
        }


        /// <summary>
        ///     ''' checkinNinzu3
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType checkinNinzu3
        {
            get
            {
                return _checkinNinzu3;
            }
            set
            {
                _checkinNinzu3 = value;
            }
        }


        /// <summary>
        ///     ''' checkinNinzu4
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType checkinNinzu4
        {
            get
            {
                return _checkinNinzu4;
            }
            set
            {
                _checkinNinzu4 = value;
            }
        }


        /// <summary>
        ///     ''' checkinNinzu5
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType checkinNinzu5
        {
            get
            {
                return _checkinNinzu5;
            }
            set
            {
                _checkinNinzu5 = value;
            }
        }


        /// <summary>
        ///     ''' infantNinzu
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType infantNinzu
        {
            get
            {
                return _infantNinzu;
            }
            set
            {
                _infantNinzu = value;
            }
        }


        /// <summary>
        ///     ''' crsCd
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType crsCd
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
        ///     ''' crsKbn1
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType crsKbn1
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
        ///     ''' crsKbn2
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType crsKbn2
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
        ///     ''' crsKind
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType crsKind
        {
            get
            {
                return _crsKind;
            }
            set
            {
                _crsKind = value;
            }
        }


        /// <summary>
        ///     ''' deleteDay
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType deleteDay
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
        ///     ''' entryDay
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType entryDay
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
        ///     ''' entryPersonCd
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType entryPersonCd
        {
            get
            {
                return _entryPersonCd;
            }
            set
            {
                _entryPersonCd = value;
            }
        }


        /// <summary>
        ///     ''' entryPgmid
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType entryPgmid
        {
            get
            {
                return _entryPgmid;
            }
            set
            {
                _entryPgmid = value;
            }
        }


        /// <summary>
        ///     ''' entryTime
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType entryTime
        {
            get
            {
                return _entryTime;
            }
            set
            {
                _entryTime = value;
            }
        }


        /// <summary>
        ///     ''' fujyoProofIssueFlg
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType fujyoProofIssueFlg
        {
            get
            {
                return _fujyoProofIssueFlg;
            }
            set
            {
                _fujyoProofIssueFlg = value;
            }
        }


        /// <summary>
        ///     ''' furikomiyoshiYohiFlg
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType furikomiyoshiYohiFlg
        {
            get
            {
                return _furikomiyoshiYohiFlg;
            }
            set
            {
                _furikomiyoshiYohiFlg = value;
            }
        }


        /// <summary>
        ///     ''' gousya
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType gousya
        {
            get
            {
                return _gousya;
            }
            set
            {
                _gousya = value;
            }
        }


        /// <summary>
        ///     ''' groupNo
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType groupNo
        {
            get
            {
                return _groupNo;
            }
            set
            {
                _groupNo = value;
            }
        }


        /// <summary>
        ///     ''' hakkenDay
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType hakkenDay
        {
            get
            {
                return _hakkenDay;
            }
            set
            {
                _hakkenDay = value;
            }
        }


        /// <summary>
        ///     ''' hakkenEigyosyoCd
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType hakkenEigyosyoCd
        {
            get
            {
                return _hakkenEigyosyoCd;
            }
            set
            {
                _hakkenEigyosyoCd = value;
            }
        }


        /// <summary>
        ///     ''' hakkenKingaku
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType hakkenKingaku
        {
            get
            {
                return _hakkenKingaku;
            }
            set
            {
                _hakkenKingaku = value;
            }
        }


        /// <summary>
        ///     ''' hakkenNaiyo
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType hakkenNaiyo
        {
            get
            {
                return _hakkenNaiyo;
            }
            set
            {
                _hakkenNaiyo = value;
            }
        }


        /// <summary>
        ///     ''' hakkenTantosyaCd
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType hakkenTantosyaCd
        {
            get
            {
                return _hakkenTantosyaCd;
            }
            set
            {
                _hakkenTantosyaCd = value;
            }
        }


        /// <summary>
        ///     ''' itineraryTablePrintAlready
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType itineraryTablePrintAlready
        {
            get
            {
                return _itineraryTablePrintAlready;
            }
            set
            {
                _itineraryTablePrintAlready = value;
            }
        }


        /// <summary>
        ///     ''' itineraryTablePrintDay
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType itineraryTablePrintDay
        {
            get
            {
                return _itineraryTablePrintDay;
            }
            set
            {
                _itineraryTablePrintDay = value;
            }
        }


        /// <summary>
        ///     ''' jyochachiCd1
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType jyochachiCd1
        {
            get
            {
                return _jyochachiCd1;
            }
            set
            {
                _jyochachiCd1 = value;
            }
        }


        /// <summary>
        ///     ''' jyochachiCd2
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType jyochachiCd2
        {
            get
            {
                return _jyochachiCd2;
            }
            set
            {
                _jyochachiCd2 = value;
            }
        }


        /// <summary>
        ///     ''' jyochachiCd3
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType jyochachiCd3
        {
            get
            {
                return _jyochachiCd3;
            }
            set
            {
                _jyochachiCd3 = value;
            }
        }


        /// <summary>
        ///     ''' jyochachiCd4
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType jyochachiCd4
        {
            get
            {
                return _jyochachiCd4;
            }
            set
            {
                _jyochachiCd4 = value;
            }
        }


        /// <summary>
        ///     ''' jyochachiCd5
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType jyochachiCd5
        {
            get
            {
                return _jyochachiCd5;
            }
            set
            {
                _jyochachiCd5 = value;
            }
        }


        /// <summary>
        ///     ''' jyoseiSenyo
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType jyoseiSenyo
        {
            get
            {
                return _jyoseiSenyo;
            }
            set
            {
                _jyoseiSenyo = value;
            }
        }


        /// <summary>
        ///     ''' jyosyaNinzu1
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType jyosyaNinzu1
        {
            get
            {
                return _jyosyaNinzu1;
            }
            set
            {
                _jyosyaNinzu1 = value;
            }
        }


        /// <summary>
        ///     ''' jyosyaNinzu2
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType jyosyaNinzu2
        {
            get
            {
                return _jyosyaNinzu2;
            }
            set
            {
                _jyosyaNinzu2 = value;
            }
        }


        /// <summary>
        ///     ''' jyosyaNinzu3
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType jyosyaNinzu3
        {
            get
            {
                return _jyosyaNinzu3;
            }
            set
            {
                _jyosyaNinzu3 = value;
            }
        }


        /// <summary>
        ///     ''' jyosyaNinzu4
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType jyosyaNinzu4
        {
            get
            {
                return _jyosyaNinzu4;
            }
            set
            {
                _jyosyaNinzu4 = value;
            }
        }


        /// <summary>
        ///     ''' jyosyaNinzu5
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType jyosyaNinzu5
        {
            get
            {
                return _jyosyaNinzu5;
            }
            set
            {
                _jyosyaNinzu5 = value;
            }
        }


        /// <summary>
        ///     ''' kokuseki
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType kokuseki
        {
            get
            {
                return _kokuseki;
            }
            set
            {
                _kokuseki = value;
            }
        }


        /// <summary>
        ///     ''' lastHenkinDay
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType lastHenkinDay
        {
            get
            {
                return _lastHenkinDay;
            }
            set
            {
                _lastHenkinDay = value;
            }
        }


        /// <summary>
        ///     ''' lastNyuukinDay
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType lastNyuukinDay
        {
            get
            {
                return _lastNyuukinDay;
            }
            set
            {
                _lastNyuukinDay = value;
            }
        }


        /// <summary>
        ///     ''' localTelNo
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType localTelNo
        {
            get
            {
                return _localTelNo;
            }
            set
            {
                _localTelNo = value;
            }
        }


        /// <summary>
        ///     ''' lostDay
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType lostDay
        {
            get
            {
                return _lostDay;
            }
            set
            {
                _lostDay = value;
            }
        }


        /// <summary>
        ///     ''' lostFlg
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType lostFlg
        {
            get
            {
                return _lostFlg;
            }
            set
            {
                _lostFlg = value;
            }
        }


        /// <summary>
        ///     ''' mailAddress
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType mailAddress
        {
            get
            {
                return _mailAddress;
            }
            set
            {
                _mailAddress = value;
            }
        }


        /// <summary>
        ///     ''' mailSendingKbn
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType mailSendingKbn
        {
            get
            {
                return _mailSendingKbn;
            }
            set
            {
                _mailSendingKbn = value;
            }
        }


        /// <summary>
        ///     ''' mediaCd
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType mediaCd
        {
            get
            {
                return _mediaCd;
            }
            set
            {
                _mediaCd = value;
            }
        }


        /// <summary>
        ///     ''' mediaName
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType mediaName
        {
            get
            {
                return _mediaName;
            }
            set
            {
                _mediaName = value;
            }
        }


        /// <summary>
        ///     ''' meiboSeq
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType meiboSeq
        {
            get
            {
                return _meiboSeq;
            }
            set
            {
                _meiboSeq = value;
            }
        }


        /// <summary>
        ///     ''' messageCheckFlg1
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType messageCheckFlg1
        {
            get
            {
                return _messageCheckFlg1;
            }
            set
            {
                _messageCheckFlg1 = value;
            }
        }


        /// <summary>
        ///     ''' messageCheckFlg2
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType messageCheckFlg2
        {
            get
            {
                return _messageCheckFlg2;
            }
            set
            {
                _messageCheckFlg2 = value;
            }
        }


        /// <summary>
        ///     ''' messageCheckFlg3
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType messageCheckFlg3
        {
            get
            {
                return _messageCheckFlg3;
            }
            set
            {
                _messageCheckFlg3 = value;
            }
        }


        /// <summary>
        ///     ''' messageCheckFlg4
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType messageCheckFlg4
        {
            get
            {
                return _messageCheckFlg4;
            }
            set
            {
                _messageCheckFlg4 = value;
            }
        }


        /// <summary>
        ///     ''' messageCheckFlg5
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType messageCheckFlg5
        {
            get
            {
                return _messageCheckFlg5;
            }
            set
            {
                _messageCheckFlg5 = value;
            }
        }


        /// <summary>
        ///     ''' messageCheckFlg6
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType messageCheckFlg6
        {
            get
            {
                return _messageCheckFlg6;
            }
            set
            {
                _messageCheckFlg6 = value;
            }
        }


        /// <summary>
        ///     ''' messageCheckFlg7
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType messageCheckFlg7
        {
            get
            {
                return _messageCheckFlg7;
            }
            set
            {
                _messageCheckFlg7 = value;
            }
        }


        /// <summary>
        ///     ''' messageCheckFlg8
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType messageCheckFlg8
        {
            get
            {
                return _messageCheckFlg8;
            }
            set
            {
                _messageCheckFlg8 = value;
            }
        }


        /// <summary>
        ///     ''' messageCheckFlg9
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType messageCheckFlg9
        {
            get
            {
                return _messageCheckFlg9;
            }
            set
            {
                _messageCheckFlg9 = value;
            }
        }


        /// <summary>
        ///     ''' messageCheckFlg10
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType messageCheckFlg10
        {
            get
            {
                return _messageCheckFlg10;
            }
            set
            {
                _messageCheckFlg10 = value;
            }
        }


        /// <summary>
        ///     ''' surname
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }


        /// <summary>
        ///     ''' name
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }


        /// <summary>
        ///     ''' surnameKj
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType surnameKj
        {
            get
            {
                return _surnameKj;
            }
            set
            {
                _surnameKj = value;
            }
        }


        /// <summary>
        ///     ''' nameKj
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType nameKj
        {
            get
            {
                return _nameKj;
            }
            set
            {
                _nameKj = value;
            }
        }


        /// <summary>
        ///     ''' noShowFlg
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType noShowFlg
        {
            get
            {
                return _noShowFlg;
            }
            set
            {
                _noShowFlg = value;
            }
        }


        /// <summary>
        ///     ''' nyukingakuSokei
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType nyukingakuSokei
        {
            get
            {
                return _nyukingakuSokei;
            }
            set
            {
                _nyukingakuSokei = value;
            }
        }


        /// <summary>
        ///     ''' nyuukinSituationKbn
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType nyuukinSituationKbn
        {
            get
            {
                return _nyuukinSituationKbn;
            }
            set
            {
                _nyuukinSituationKbn = value;
            }
        }


        /// <summary>
        ///     ''' oldGousya
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType oldGousya
        {
            get
            {
                return _oldGousya;
            }
            set
            {
                _oldGousya = value;
            }
        }


        /// <summary>
        ///     ''' oldZaseki
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType oldZaseki
        {
            get
            {
                return _oldZaseki;
            }
            set
            {
                _oldZaseki = value;
            }
        }


        /// <summary>
        ///     ''' receiptIssueFlg
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType receiptIssueFlg
        {
            get
            {
                return _receiptIssueFlg;
            }
            set
            {
                _receiptIssueFlg = value;
            }
        }


        /// <summary>
        ///     ''' relationYoyakuKbn
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType relationYoyakuKbn
        {
            get
            {
                return _relationYoyakuKbn;
            }
            set
            {
                _relationYoyakuKbn = value;
            }
        }


        /// <summary>
        ///     ''' relationYoyakuNo
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType relationYoyakuNo
        {
            get
            {
                return _relationYoyakuNo;
            }
            set
            {
                _relationYoyakuNo = value;
            }
        }


        /// <summary>
        ///     ''' returnDay
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType returnDay
        {
            get
            {
                return _returnDay;
            }
            set
            {
                _returnDay = value;
            }
        }


        /// <summary>
        ///     ''' roomingBetuNinzu1
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType roomingBetuNinzu1
        {
            get
            {
                return _roomingBetuNinzu1;
            }
            set
            {
                _roomingBetuNinzu1 = value;
            }
        }


        /// <summary>
        ///     ''' roomingBetuNinzu2
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType roomingBetuNinzu2
        {
            get
            {
                return _roomingBetuNinzu2;
            }
            set
            {
                _roomingBetuNinzu2 = value;
            }
        }


        /// <summary>
        ///     ''' roomingBetuNinzu3
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType roomingBetuNinzu3
        {
            get
            {
                return _roomingBetuNinzu3;
            }
            set
            {
                _roomingBetuNinzu3 = value;
            }
        }


        /// <summary>
        ///     ''' roomingBetuNinzu4
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType roomingBetuNinzu4
        {
            get
            {
                return _roomingBetuNinzu4;
            }
            set
            {
                _roomingBetuNinzu4 = value;
            }
        }


        /// <summary>
        ///     ''' roomingBetuNinzu5
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType roomingBetuNinzu5
        {
            get
            {
                return _roomingBetuNinzu5;
            }
            set
            {
                _roomingBetuNinzu5 = value;
            }
        }


        /// <summary>
        ///     ''' saikouKakuteiGuideOutDay
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType saikouKakuteiGuideOutDay
        {
            get
            {
                return _saikouKakuteiGuideOutDay;
            }
            set
            {
                _saikouKakuteiGuideOutDay = value;
            }
        }


        /// <summary>
        ///     ''' seikiChargeAllGaku
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType seikiChargeAllGaku
        {
            get
            {
                return _seikiChargeAllGaku;
            }
            set
            {
                _seikiChargeAllGaku = value;
            }
        }


        /// <summary>
        ///     ''' seikyusyoYohiFlg
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType seikyusyoYohiFlg
        {
            get
            {
                return _seikyusyoYohiFlg;
            }
            set
            {
                _seikyusyoYohiFlg = value;
            }
        }


        /// <summary>
        ///     ''' seisanHoho
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType seisanHoho
        {
            get
            {
                return _seisanHoho;
            }
            set
            {
                _seisanHoho = value;
            }
        }


        /// <summary>
        ///     ''' sexBetu
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType sexBetu
        {
            get
            {
                return _sexBetu;
            }
            set
            {
                _sexBetu = value;
            }
        }


        /// <summary>
        ///     ''' siharaiHoho
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType siharaiHoho
        {
            get
            {
                return _siharaiHoho;
            }
            set
            {
                _siharaiHoho = value;
            }
        }


        /// <summary>
        ///     ''' sonotaNyuukinHenkin
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType sonotaNyuukinHenkin
        {
            get
            {
                return _sonotaNyuukinHenkin;
            }
            set
            {
                _sonotaNyuukinHenkin = value;
            }
        }


        /// <summary>
        ///     ''' sponsorshipKeiyakuKbn
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType sponsorshipKeiyakuKbn
        {
            get
            {
                return _sponsorshipKeiyakuKbn;
            }
            set
            {
                _sponsorshipKeiyakuKbn = value;
            }
        }


        /// <summary>
        ///     ''' state
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType state
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
            }
        }


        /// <summary>
        ///     ''' syugoTime1
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType syugoTime1
        {
            get
            {
                return _syugoTime1;
            }
            set
            {
                _syugoTime1 = value;
            }
        }


        /// <summary>
        ///     ''' syugoTime2
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType syugoTime2
        {
            get
            {
                return _syugoTime2;
            }
            set
            {
                _syugoTime2 = value;
            }
        }


        /// <summary>
        ///     ''' syugoTime3
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType syugoTime3
        {
            get
            {
                return _syugoTime3;
            }
            set
            {
                _syugoTime3 = value;
            }
        }


        /// <summary>
        ///     ''' syugoTime4
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType syugoTime4
        {
            get
            {
                return _syugoTime4;
            }
            set
            {
                _syugoTime4 = value;
            }
        }


        /// <summary>
        ///     ''' syugoTime5
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType syugoTime5
        {
            get
            {
                return _syugoTime5;
            }
            set
            {
                _syugoTime5 = value;
            }
        }


        /// <summary>
        ///     ''' syuptDay
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
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
        ///     ''' syuptTime1
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType syuptTime1
        {
            get
            {
                return _syuptTime1;
            }
            set
            {
                _syuptTime1 = value;
            }
        }


        /// <summary>
        ///     ''' syuptTime2
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType syuptTime2
        {
            get
            {
                return _syuptTime2;
            }
            set
            {
                _syuptTime2 = value;
            }
        }


        /// <summary>
        ///     ''' syuptTime3
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType syuptTime3
        {
            get
            {
                return _syuptTime3;
            }
            set
            {
                _syuptTime3 = value;
            }
        }


        /// <summary>
        ///     ''' syuptTime4
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType syuptTime4
        {
            get
            {
                return _syuptTime4;
            }
            set
            {
                _syuptTime4 = value;
            }
        }


        /// <summary>
        ///     ''' syuptTime5
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType syuptTime5
        {
            get
            {
                return _syuptTime5;
            }
            set
            {
                _syuptTime5 = value;
            }
        }


        /// <summary>
        ///     ''' tasyaKennoKingaku
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType tasyaKennoKingaku
        {
            get
            {
                return _tasyaKennoKingaku;
            }
            set
            {
                _tasyaKennoKingaku = value;
            }
        }


        /// <summary>
        ///     ''' tasyaYoyakuNo
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType tasyaYoyakuNo
        {
            get
            {
                return _tasyaYoyakuNo;
            }
            set
            {
                _tasyaYoyakuNo = value;
            }
        }


        /// <summary>
        ///     ''' teikiKeiyakuKbn
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType teikiKeiyakuKbn
        {
            get
            {
                return _teikiKeiyakuKbn;
            }
            set
            {
                _teikiKeiyakuKbn = value;
            }
        }


        /// <summary>
        ///     ''' teikiKikakuKbn
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType teikiKikakuKbn
        {
            get
            {
                return _teikiKikakuKbn;
            }
            set
            {
                _teikiKikakuKbn = value;
            }
        }


        /// <summary>
        ///     ''' telNo1
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType telNo1
        {
            get
            {
                return _telNo1;
            }
            set
            {
                _telNo1 = value;
            }
        }


        /// <summary>
        ///     ''' telNo11
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType telNo11
        {
            get
            {
                return _telNo11;
            }
            set
            {
                _telNo11 = value;
            }
        }


        /// <summary>
        ///     ''' telNo12
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType telNo12
        {
            get
            {
                return _telNo12;
            }
            set
            {
                _telNo12 = value;
            }
        }


        /// <summary>
        ///     ''' telNo13
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType telNo13
        {
            get
            {
                return _telNo13;
            }
            set
            {
                _telNo13 = value;
            }
        }


        /// <summary>
        ///     ''' telNo2
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType telNo2
        {
            get
            {
                return _telNo2;
            }
            set
            {
                _telNo2 = value;
            }
        }


        /// <summary>
        ///     ''' telNo21
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType telNo21
        {
            get
            {
                return _telNo21;
            }
            set
            {
                _telNo21 = value;
            }
        }


        /// <summary>
        ///     ''' telNo22
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType telNo22
        {
            get
            {
                return _telNo22;
            }
            set
            {
                _telNo22 = value;
            }
        }


        /// <summary>
        ///     ''' telNo23
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType telNo23
        {
            get
            {
                return _telNo23;
            }
            set
            {
                _telNo23 = value;
            }
        }


        /// <summary>
        ///     ''' tobiSeatFlg
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType tobiSeatFlg
        {
            get
            {
                return _tobiSeatFlg;
            }
            set
            {
                _tobiSeatFlg = value;
            }
        }


        /// <summary>
        ///     ''' tomonokaiNo
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType tomonokaiNo
        {
            get
            {
                return _tomonokaiNo;
            }
            set
            {
                _tomonokaiNo = value;
            }
        }

        /// <summary>
        ///     ''' kaiinNo
        ///     ''' </summary>
        ///     ''' <returns></returns>
        public EntityKoumoku_NumberType kaiinNo
        {
            get
            {
                return _kaiinNo;
            }
            set
            {
                _kaiinNo = value;
            }
        }

        /// <summary>
        ///     ''' toriatukaiFeeCancel
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType toriatukaiFeeCancel
        {
            get
            {
                return _toriatukaiFeeCancel;
            }
            set
            {
                _toriatukaiFeeCancel = value;
            }
        }


        /// <summary>
        ///     ''' toriatukaiFeeSagaku
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType toriatukaiFeeSagaku
        {
            get
            {
                return _toriatukaiFeeSagaku;
            }
            set
            {
                _toriatukaiFeeSagaku = value;
            }
        }


        /// <summary>
        ///     ''' toriatukaiFeeUriage
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType toriatukaiFeeUriage
        {
            get
            {
                return _toriatukaiFeeUriage;
            }
            set
            {
                _toriatukaiFeeUriage = value;
            }
        }


        /// <summary>
        ///     ''' toursNo
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType toursNo
        {
            get
            {
                return _toursNo;
            }
            set
            {
                _toursNo = value;
            }
        }


        /// <summary>
        ///     ''' unkyuContactDay
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType unkyuContactDay
        {
            get
            {
                return _unkyuContactDay;
            }
            set
            {
                _unkyuContactDay = value;
            }
        }


        /// <summary>
        ///     ''' updateDay
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType updateDay
        {
            get
            {
                return _updateDay;
            }
            set
            {
                _updateDay = value;
            }
        }


        /// <summary>
        ///     ''' updatePersonCd
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType updatePersonCd
        {
            get
            {
                return _updatePersonCd;
            }
            set
            {
                _updatePersonCd = value;
            }
        }


        /// <summary>
        ///     ''' updatePgmid
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType updatePgmid
        {
            get
            {
                return _updatePgmid;
            }
            set
            {
                _updatePgmid = value;
            }
        }


        /// <summary>
        ///     ''' updateTime
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType updateTime
        {
            get
            {
                return _updateTime;
            }
            set
            {
                _updateTime = value;
            }
        }


        /// <summary>
        ///     ''' usingFlg
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType usingFlg
        {
            get
            {
                return _usingFlg;
            }
            set
            {
                _usingFlg = value;
            }
        }


        /// <summary>
        ///     ''' waribikiAllGaku
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType waribikiAllGaku
        {
            get
            {
                return _waribikiAllGaku;
            }
            set
            {
                _waribikiAllGaku = value;
            }
        }


        /// <summary>
        ///     ''' year
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType year
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
        ///     ''' yobi1
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType yobi1
        {
            get
            {
                return _yobi1;
            }
            set
            {
                _yobi1 = value;
            }
        }


        /// <summary>
        ///     ''' yobi2
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType yobi2
        {
            get
            {
                return _yobi2;
            }
            set
            {
                _yobi2 = value;
            }
        }


        /// <summary>
        ///     ''' yobi3
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType yobi3
        {
            get
            {
                return _yobi3;
            }
            set
            {
                _yobi3 = value;
            }
        }


        /// <summary>
        ///     ''' yobi4
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType yobi4
        {
            get
            {
                return _yobi4;
            }
            set
            {
                _yobi4 = value;
            }
        }


        /// <summary>
        ///     ''' yobi5
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType yobi5
        {
            get
            {
                return _yobi5;
            }
            set
            {
                _yobi5 = value;
            }
        }


        /// <summary>
        ///     ''' yobi6
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType yobi6
        {
            get
            {
                return _yobi6;
            }
            set
            {
                _yobi6 = value;
            }
        }


        /// <summary>
        ///     ''' yobi7
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType yobi7
        {
            get
            {
                return _yobi7;
            }
            set
            {
                _yobi7 = value;
            }
        }


        /// <summary>
        ///     ''' yoyakuJiAgentCd
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType yoyakuJiAgentCd
        {
            get
            {
                return _yoyakuJiAgentCd;
            }
            set
            {
                _yoyakuJiAgentCd = value;
            }
        }


        /// <summary>
        ///     ''' yoyakuJiAgentName
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType yoyakuJiAgentName
        {
            get
            {
                return _yoyakuJiAgentName;
            }
            set
            {
                _yoyakuJiAgentName = value;
            }
        }


        /// <summary>
        ///     ''' yoyakuKakuninDay
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType yoyakuKakuninDay
        {
            get
            {
                return _yoyakuKakuninDay;
            }
            set
            {
                _yoyakuKakuninDay = value;
            }
        }


        /// <summary>
        ///     ''' yoyakuUketukeKbn
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType yoyakuUketukeKbn
        {
            get
            {
                return _yoyakuUketukeKbn;
            }
            set
            {
                _yoyakuUketukeKbn = value;
            }
        }


        /// <summary>
        ///     ''' yoyakuZasekiGetKbn
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType yoyakuZasekiGetKbn
        {
            get
            {
                return _yoyakuZasekiGetKbn;
            }
            set
            {
                _yoyakuZasekiGetKbn = value;
            }
        }


        /// <summary>
        ///     ''' yoyakuZasekiKbn
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType yoyakuZasekiKbn
        {
            get
            {
                return _yoyakuZasekiKbn;
            }
            set
            {
                _yoyakuZasekiKbn = value;
            }
        }


        /// <summary>
        ///     ''' yubinNo
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType yubinNo
        {
            get
            {
                return _yubinNo;
            }
            set
            {
                _yubinNo = value;
            }
        }


        /// <summary>
        ///     ''' yykmks
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType yykmks
        {
            get
            {
                return _yykmks;
            }
            set
            {
                _yykmks = value;
            }
        }


        /// <summary>
        ///     ''' zaseki
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType zaseki
        {
            get
            {
                return _zaseki;
            }
            set
            {
                _zaseki = value;
            }
        }


        /// <summary>
        ///     ''' zasekiChangeUmu
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType zasekiChangeUmu
        {
            get
            {
                return _zasekiChangeUmu;
            }
            set
            {
                _zasekiChangeUmu = value;
            }
        }


        /// <summary>
        ///     ''' zasekiReserveYoyakuFlg
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType zasekiReserveYoyakuFlg
        {
            get
            {
                return _zasekiReserveYoyakuFlg;
            }
            set
            {
                _zasekiReserveYoyakuFlg = value;
            }
        }

        /// <summary>
        ///     ''' subSeatWaitFlg
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType subSeatWaitFlg
        {
            get
            {
                return _subSeatWaitFlg;
            }
            set
            {
                _subSeatWaitFlg = value;
            }
        }


        /// <summary>
        ///     ''' motoYoyakuKbn
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType motoYoyakuKbn
        {
            get
            {
                return _motoYoyakuKbn;
            }
            set
            {
                _motoYoyakuKbn = value;
            }
        }


        /// <summary>
        ///     ''' motoYoyakuNo
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_NumberType motoYoyakuNo
        {
            get
            {
                return _motoYoyakuNo;
            }
            set
            {
                _motoYoyakuNo = value;
            }
        }


        /// <summary>
        ///     ''' entrySectionCd
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public EntityKoumoku_MojiType entrySectionCd
        {
            get
            {
                return _entrySectionCd;
            }
            set
            {
                _entrySectionCd = value;
            }
        }


        /// <summary>
        ///     ''' systemEntryPgmid
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
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
        ///     ''' systemEntryPersonCd
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
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
        ///     ''' systemEntryDay
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
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
        ///     ''' systemUpdatePgmid
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
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
        ///     ''' systemUpdatePersonCd
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
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
        ///     ''' systemUpdateDay
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
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

}
