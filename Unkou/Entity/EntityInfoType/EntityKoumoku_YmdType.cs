using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unkou.Entity.EntityInfoType
{
    [Serializable()]
    public class EntityKoumoku_YmdType : IEntityKoumokuType
    {
        private bool _errorInfo = false;
        private bool _required = false;
        private Nullable<DateTime> _backupValue = default(DateTime?);
        private Nullable<DateTime> _zenkaiValue = default(DateTime?);
        private Nullable<DateTime> _value = default(DateTime?);
        private string _physicsName = string.Empty;
        private OracleDbType _DBType = OracleDbType.Varchar2;
        private int _integerBu = 0;
        private int _decimalBu = 0;

        /// <summary>
        ///     ''' エラー情報を取得＿設定します。
        ///     ''' </summary>
        ///     ''' <value>True:エラー有／False:エラー無</value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public bool ErrorInfo
        {
            get
            {
                return _errorInfo;
            }
            set
            {
                _errorInfo = value;
            }
        }
        /// <summary>
        ///     ''' 必須を取得＿設定します。
        ///     ''' </summary>
        ///     ''' <value>True:必須／False:任意</value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public bool Required
        {
            get
            {
                return _required;
            }
            set
            {
                _required = value;
            }
        }
        /// <summary>
        ///     ''' 値＿前回値のバックアップを取得＿設定します。
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public Nullable<DateTime> BackupValue
        {
            get
            {
                return _backupValue;
            }
            set
            {
                _backupValue = value;
            }
        }
        /// <summary>
        ///     ''' 前回値を取得＿設定します。
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public Nullable<DateTime> ZenkaiValue
        {
            get
            {
                return _zenkaiValue;
            }
            set
            {
                _zenkaiValue = value;
            }
        }
        /// <summary>
        ///     ''' 値を取得＿設定します。
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public Nullable<DateTime> Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
        /// <summary>
        ///     ''' 物理名を取得＿設定します。
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public string PhysicsName
        {
            get
            {
                return _physicsName;
            }
            set
            {
                _physicsName = value;
            }
        }
        /// <summary>
        ///     ''' 項目のOracleDb型を取得＿設定します。
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public OracleDbType DBType
        {
            get
            {
                return _DBType;
            }
            set
            {
                _DBType = value;
            }
        }
        /// <summary>
        ///     ''' 項目のDB桁数を取得＿設定します。
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public int IntegerBu
        {
            get
            {
                return _integerBu;
            }
            set
            {
                _integerBu = value;
            }
        }
        /// <summary>
        ///     ''' 項目のDB小数桁数を取得＿設定します。
        ///     ''' </summary>
        ///     ''' <value></value>
        ///     ''' <returns></returns>
        ///     ''' <remarks></remarks>
        public int DecimalBu
        {
            get
            {
                return _decimalBu;
            }
            set
            {
                _decimalBu = value;
            }
        }
    }

}
