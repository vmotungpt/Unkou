using Oracle.ManagedDataAccess.Client;
using System;

namespace Unkou.Entity.EntityInfoType
{
    /// <summary>
    /// エンティティ項目_数値_小数型
    /// </summary>
    /// <remarks></remarks>
    /// <summary>
    /// ''' エンティティ項目_数値_小数型
    /// ''' </summary>
    /// ''' <remarks></remarks>

    [Serializable()]
    public class EntityKoumoku_MojiType : IEntityKoumokuType
    {
        private bool _errorInfo = false;
        private bool _required = false;
        private Nullable<decimal> _backupValue = default(Decimal?);
        private Nullable<decimal> _zenkaiValue = default(Decimal?);
        private Nullable<decimal> _value = default(Decimal?);
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
        public new Nullable<decimal> BackupValue
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
        public Nullable<decimal> ZenkaiValue
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
        public Nullable<decimal> Value
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

        OracleDbType IEntityKoumokuType.DBType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

}
