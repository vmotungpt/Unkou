using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unkou.Common
{
    public class CommonDAUtil
    {
        /// <summary>
        /// 発券状態
        /// </summary>
        public enum _hakkenStateEnum
        {
            mihakken,
            zasekiSitei,
            hakkenzumi,
            jtbHakken,
            renrakuHakken,
            torikesi,
            sakujo,
            kntHakken
        }

        /// <summary>
        /// 引数で渡された内容により予約発券状態の文言を返却する。
        /// </summary>
        /// <param name="cancelFlg">キャンセルフラグ　String型</param>
        /// <param name="zasekiFlg">座席指定予約フラグ String</param>
        /// <param name="hakkenNaiyo">発券内容 String</param>
        /// <param name="jotai">状態 String</param>
        /// <returns>String型配列　要素数2　要素番号1：略称　要素番号2：正式名称</returns>
        public static string[] getYoyakuHakkenState(string cancelFlg, string zasekiFlg, string hakkenNaiyo, string jotai)
        {
            string[] mongon1array = new string[] { "　", "指", "券", "Ｊ", "連", "消", "削", "Ｋ", "　", "　" };
            string[] mongon2array = new string[] { "未発券　　　", "座席指定予約", "発券済　　　", "ＪＴＢ発券", "連絡発券　　", "取消　　　　", "削除　　　　", "ＫＮＴ発券　", "　　　　　　", "　　　　　　" };
            _hakkenStateEnum? yoyakuHakkenKbn = null;

            //キャンセルフラグによる区分
            if (string.IsNullOrEmpty(cancelFlg))
            {
                yoyakuHakkenKbn = edit(zasekiFlg, hakkenNaiyo, jotai);
            }
            else if (cancelFlg.Equals("1"))
            {
                yoyakuHakkenKbn = _hakkenStateEnum.torikesi;
            }
            else if (cancelFlg.Equals("2"))
            {
                yoyakuHakkenKbn = _hakkenStateEnum.sakujo;
            }

            //返却用変数
            string[] returnArray = new string[] { "", "" };
            //区分によるステータス変化
            if (yoyakuHakkenKbn != null)
            {
                returnArray[0] = mongon1array[System.Convert.ToInt32(yoyakuHakkenKbn)];
                returnArray[1] = mongon2array[System.Convert.ToInt32(yoyakuHakkenKbn)];
            }
            return returnArray;
        }

        /// <summary>
        /// getYoyakuHakkenStateで必要なNWW520Rからあるメソッド
        /// </summary>
        /// <param name="zasekiFlg"></param>
        /// <param name="hakkenNaiyo"></param>
        /// <param name="jotai"></param>
        /// <returns></returns>
        public static _hakkenStateEnum? edit(string zasekiFlg, string hakkenNaiyo, string jotai)
        {
            if (string.IsNullOrEmpty(hakkenNaiyo))
            {
                //未発券
                if (string.IsNullOrEmpty(zasekiFlg))
                {
                    return _hakkenStateEnum.mihakken;
                }
                else if (zasekiFlg.Equals("Y"))
                {
                    return _hakkenStateEnum.zasekiSitei;
                }

            }
            else
            {
                //発券済み
                if (string.IsNullOrEmpty(jotai))
                {
                    return _hakkenStateEnum.hakkenzumi;
                }
                else if (jotai.Equals("1"))
                {
                    return _hakkenStateEnum.jtbHakken;
                }
                else if (jotai.Equals("2"))
                {
                    return _hakkenStateEnum.renrakuHakken;
                }
                else if (jotai.Equals("3"))
                {
                    return _hakkenStateEnum.kntHakken;
                }
            }

            return null;
        }

        /// <summary>
        /// 最大取得件数で絞込み
        /// </summary>
        /// <param name="paramDt"></param>
        /// <param name="limitMaxData"></param>
        public static DataTable checkLimitData(DataTable paramDt, int limitMaxData)
        {
            // データの取得件数が最大取得件数より多い場合最大取得件数までデータを絞る
            if (paramDt.Rows.Count > limitMaxData)
            {
                // テーブル構造をコピー
                DataTable dt = paramDt.Clone();
                DataRow newDtRow = null;
                int rowCnt = 0;
                foreach (DataRow rowa in paramDt.Rows)
                {
                    int colCnt = 0;
                    if (rowCnt < limitMaxData)
                    {
                        newDtRow = dt.NewRow();
                        foreach (object elm in rowa.ItemArray)
                        {
                            newDtRow[colCnt] = elm;
                            colCnt++;
                        }
                        dt.Rows.Add(newDtRow);
                        rowCnt++;
                    }
                    else
                    {
                        //' TODO:最大取得件数指針決まり次第修正(仮対応)
                        CommonProcess.createFactoryMsg().messageDisp("9002", limitMaxData.ToString());
                        // 最大取得件数で絞ったデータを返す
                        return dt;
                    }
                }
                return dt;
            }
            else
            {
                // データの取得件数が最大取得件数以下の場合絞らずに返す
                return paramDt;
            }
        }

        /// <summary>
        /// EntityからSELECT文を作成する
        /// </summary>
        /// <typeparam name="T">エンティティ</typeparam>
        /// <returns></returns>
        //public static string makeSelectSql<T>(string tblId)
        //{
        //    EntityOperation<T> entity = new EntityOperation<T>;
        //    StringBuilder sqlString = new StringBuilder();
        //    string physicsName = "";

        //    sqlString.AppendLine(" SELECT");

        //    for (int idxItem = 0; idxItem <= entity.getPropertyDataLength - 1; idxItem++)
        //    {
        //        physicsName = System.Convert.ToString(((IEntityKoumokuType)(entity.getPtyValue(idxItem, entity.EntityData(0)))).PhysicsName);
        //        sqlString.AppendLine(System.Convert.ToString(System.Convert.ToString(idxItem > 0 ? "," : string.Empty) + physicsName));
        //    }
        //    sqlString.AppendLine(" FROM");
        //    sqlString.AppendLine("  {tblId}");

        //    return sqlString.ToString();

        //}
    }
}
