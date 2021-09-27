using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unkou.Common;
using static Unkou.Common.ClientConstantCode;
using static Unkou.Common.ConstantCode;

namespace Unkou
{
    public partial class FormBase : Form
    {
        #region  定数／変数
        private string _shozokuName = "";
        private string _shozokuCode = "";
        private string _userName = "";
        private ArrayList formControls = new ArrayList();
        private bool _ItemChangeCheckResult;
        private bool _F1Key_Visible;
        private bool _F2Key_Visible;
        private bool _F3Key_Visible;
        private bool _F4Key_Visible;
        private bool _F5Key_Visible;
        private bool _F6Key_Visible;
        private bool _F7Key_Visible;
        private bool _F8Key_Visible;
        private bool _F9Key_Visible;
        private bool _F10Key_Visible;
        private bool _F11Key_Visible;
        private bool _F12Key_Visible;

        private ButtonEx _pbtnF1;
        private ButtonEx _pbtnF2;
        private ButtonEx _pbtnF3;
        private ButtonEx _pbtnF4;
        private ButtonEx _pbtnF5;
        private ButtonEx _pbtnF6;
        private ButtonEx _pbtnF7;
        /// <summary>
        /// 画面上のF7ボタンを指定します。
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public ButtonEx baseBtnF7
        {
            get
            {
                return _pbtnF7;
            }
            set
            {
                _pbtnF7 = value;
            }
        }

        private ButtonEx _pbtnF8;
        /// <summary>
        /// 画面上のF8ボタンを指定します。
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public ButtonEx baseBtnF8
        {
            get
            {
                return _pbtnF8;
            }
            set
            {
                _pbtnF8 = value;
            }
        }

        private ButtonEx _pbtnF9;
        private ButtonEx _pbtnF10;
        private ButtonEx _pbtnF11;
        private ButtonEx _pbtnF12;



        private bool _errorFlag = false; // True : エラー有、False : エラー無
        private Exception _exception; // Exception
        private bool _functionExec; // True : 実行中、False : 待機中

        private const int _btnLocationY = 2;


        public bool closeFormFlg = true; //クローズ確認フラグ

        protected const string windowTitleString = "{0}　　【{1}】{2}"; // Windowタイトルの表示定義

        protected const int RET_CANCEL = 0;
        protected const int RET_NONEXEC = -2;
        protected const int RET_NONDATAUPDATED = -9;

        public bool closeReturnFlg = true; //データ戻し確認フラグ

        #endregion

        #region  コントロールプロパティ設定
        private System.Windows.Forms.ToolStripStatusLabel strStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        /// <summary>
        /// ステータスバーのガイドメッセージを挿入します。
        /// </summary>
        /// <value></value>
        /// <remarks></remarks>
        private string setStatus
        {
            set
            {
                strStatusLabel.Text = value;
                this.StatusBar.Items.Add(strStatusLabel);
            }
        }

        /// <summary>
        /// タイトルを挿入します。
        /// </summary>
        /// <value></value>
        /// <remarks></remarks>
        public string setTitle
        {
            get
            {
                return this.lblTitle.Text;
            }
            set
            {
                this.lblTitle.Text = value;
            }
        }

        /// <summary>
        /// ウインドウタイトルを挿入します。
        /// </summary>
        /// <value></value>
        /// <remarks></remarks>
        public string setWindowTitle
        {
            get
            {
                return this.Text;
            }
            set
            {
                this.Text = value;
            }
        }

        /// <summary>
        /// 画面IDを挿入します。
        /// </summary>
        /// <value></value>
        /// <remarks></remarks>
        public string setFormId
        {
            get
            {
                return this.lblFormId.Text;
            }
            set
            {
                this.lblFormId.Text = value;
            }
        }

        /// <summary>
        /// メニューID
        /// </summary>
        /// <returns></returns>
        /// <remarks>自画面の呼出元メニューID</remarks>
        public string menuId;

        /// <summary>
        /// システムコード
        /// </summary>
        /// <returns></returns>
        /// <remarks>自画面の呼出元システムコード</remarks>
        public string systemCd;

        /// <summary>
        /// システムコード（呼出元指定用）
        /// </summary>
        /// <returns></returns>
        /// <remarks>異なるシステムコード（＝メニューボタン）から1つの画面を表示する際に指定。
        /// 　　　　　　（ボタンで権限が変わるときにこの指定が無いと判定できない）
        /// </remarks>
        public string fromSystemCd;


        /// <summary>
        /// 所属を挿入します。
        /// </summary>
        /// <value></value>
        /// <remarks></remarks>
        public string setShozoku
        {
            set
            {
                //'If value = "" Then
                //'    Me.pnlShozoku.Visible = False
                //'    Me.lblShozoku.Visible = False
                //'    Me.lblShozokuTitle.Visible = False
                //'Else
                //'    Me.pnlShozoku.Visible = True
                //'    Me.lblShozoku.Visible = True
                //'    Me.lblShozokuTitle.Visible = True
                //'    Me.lblShozokuTitle.Text = "所属:"
                //'    Me.lblShozoku.Text = value
                //'End If
            }
        }

        /// <summary>
        /// ユーザーIDを挿入します。
        /// </summary>
        /// <value></value>
        /// <remarks></remarks>
        public string setUserName
        {
            set
            {
                //'If value = "" Then
                //'    Me.pnlUser.Visible = False
                //'    Me.lblUserNameTitle.Visible = False
                //'    Me.lblUserName.Visible = False
                //'Else
                //'    Me.pnlUser.Visible = True
                //'    Me.lblUserNameTitle.Visible = True
                //'    Me.lblUserName.Visible = True
                //'    Me.lblUserNameTitle.Text = "ユーザー名:"
                //'    Me.lblUserName.Text = value
                //'End If
            }
        }

        /// <summary>
        /// タイトルパネルの表示/非表示を選択します。
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        [Category("SetTitleVisible"), Description("タイトルパネルの表示/非表示を設定")]
        public bool setTitleVisible
        {
            get
            {
                return this.pnlTitle.Visible;
            }
            set
            {
                this.pnlTitle.Visible = value;
            }
        }

        private System.Drawing.Color _bc2 = Color.White;
        /// <summary>
        /// グラフィックスの第２色目を指定します。
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public System.Drawing.Color BackColor2
        {
            get
            {
                return _bc2;
            }
            set
            {
                _bc2 = value;
            }
        }

        private System.Drawing.Drawing2D.LinearGradientMode _mode = LinearGradientMode.Vertical;
        /// <summary>
        /// グラフィックス描画モードを指定します。
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public System.Drawing.Drawing2D.LinearGradientMode Mode
        {
            get
            {
                return _mode;
            }
            set
            {
                _mode = value;
            }
        }
        #endregion

        #region その他のプロパティ

        /// <summary>
        /// 実行中フラグ
        /// </summary>
        /// <returns></returns>
        public bool FunctionExec
        {
            get
            {
                return _functionExec;
            }
            set
            {
                _functionExec = value;
            }
        }

        /// <summary>
        /// エラーフラグ
        /// </summary>
        /// <returns></returns>
        public bool ErrorFlg
        {
            get
            {
                return _errorFlag;
            }
            set
            {
                _errorFlag = value;
            }
        }

        /// <summary>
        /// Exception
        /// </summary>
        /// <returns></returns>
        public Exception Exception
        {
            get
            {
                return _exception;
            }
            set
            {
                _exception = value;
            }
        }

        #endregion

        ///' <summary>
        ///' ペイントイベント
        ///' </summary>
        ///' <param name="sender"></param>
        ///' <param name="e"></param>
        ///' <remarks>32ビット環境にて不具合発生(2/22)</remarks>
        //Private Sub FormBase_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        //    Dim myLGBrush As System.Drawing.Drawing2D.LinearGradientBrush = _
        //                 New System.Drawing.Drawing2D.LinearGradientBrush(Me.ClientRectangle, Me.BackColor, Me._bc2, Me._mode)
        //    e.Graphics.FillRectangle(myLGBrush, Me.ClientRectangle)

        //    myLGBrush.Dispose()
        //    e.Dispose()
        //End Sub

        #region  イベント

        /// <summary>
        /// フォームロードイベント
        /// </summary>
        /// <param name="sender">イベント送信元</param>
        /// <param name="e">イベントデータ</param>
        protected void FormBase_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormBase_Shown(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void FormBase_Actived(object sender, EventArgs e)
        {
            // 権限セット（画面切替時用）
            
        }

        /// <summary>
        /// イベント時の前処理
        /// </summary>
        protected void comPreEvent()
        {
            // マウスカーソルを砂時計にする
            this.Cursor = Cursors.WaitCursor;

            // エラー有無のクリア
            ErrorFlg = false;

            // オブジェクトの初期化
        }

        /// <summary>
        /// イベント時の後処理
        /// </summary>
        protected void comPostEvent()
        {
            // マウスカーソルを元に戻す
            this.Cursor = Cursors.Default;
        }

        /// <summary>
        /// フォームキーダウンイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        protected void FormBase_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                ButtonEx btn = null;

                if (e.KeyData == Keys.F1)
                {
                    btn = this._pbtnF1;
                }
                else if (e.KeyData == Keys.F2)
                {
                    btn = this._pbtnF2;
                }
                else if (e.KeyData == Keys.F3)
                {
                    btn = this._pbtnF3;
                }
                else if (e.KeyData == Keys.F4)
                {
                    btn = this._pbtnF4;
                }
                else if (e.KeyData == Keys.F5)
                {
                    btn = this._pbtnF5;
                }
                else if (e.KeyData == Keys.F6)
                {
                    btn = this._pbtnF6;
                }
                else if (e.KeyData == Keys.F7)
                {
                    btn = this._pbtnF7;
                }
                else if (e.KeyData == Keys.F8)
                {
                    btn = this._pbtnF8;
                }
                else if (e.KeyData == Keys.F9)
                {
                    btn = this._pbtnF9;
                }
                else if (e.KeyData == Keys.F10)
                {
                    btn = this._pbtnF10;
                }
                else if (e.KeyData == Keys.F11)
                {
                    btn = this._pbtnF11;
                }
                else if (e.KeyData == Keys.F12)
                {
                    btn = this._pbtnF12;
                }
                else if (e.KeyData == Keys.Pause)
                {
                    //メッセージ出力.messageDisp("9999", ユーザー情報管理.発行バージョン)
                    MessageBox.Show("9999");
                }
                else
                {
                    //その他キー
                }
                if (ReferenceEquals(btn, null) == false)
                {
                    if (btn.Visible == true && btn.Enabled == true)
                    {
                        e.Handled = true;
                        btn.Focus();
                        btnCom_Click(btn, e);
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("E90_018");
                string[] strErr;
                strErr = new string[] { ex.Message, ex.Source, ex.StackTrace };
                this.Close();
            }
            catch (Exception ex)
            {
                //例外処理も共通化
                MessageBox.Show("E90_046");
                string[] strErr;
                strErr = new string[] { ex.Message, ex.Source, ex.StackTrace };
                this.Close();
            }
        }

        #region フッタ

        /// <summary>
        /// ファンクションキー１イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        protected virtual void btnCom_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                //前処理
                comPreEvent();

                // 実処理
                if (BtnKeyId.F1.Equals(((ButtonEx)sender).BtnEventId))
                {
                    MessageBox.Show("Lỗi");
                    btnF1_ClickOrgProc();
                }
                else if (BtnKeyId.F2.Equals(((ButtonEx)sender).BtnEventId))
                {
                    MessageBox.Show("Lỗi");
                    btnF2_ClickOrgProc();
                }
                else if (BtnKeyId.F3.Equals(((ButtonEx)sender).BtnEventId))
                {
                    MessageBox.Show("Lỗi");
                    btnF3_ClickOrgProc();
                }
                else if (BtnKeyId.F4.Equals(((ButtonEx)sender).BtnEventId))
                {
                    MessageBox.Show("Lỗi");
                    btnF4_ClickOrgProc();
                }
                else if (BtnKeyId.F5.Equals(((ButtonEx)sender).BtnEventId))
                {
                    MessageBox.Show("Lỗi");
                    btnF5_ClickOrgProc();
                }
                else if (BtnKeyId.F6.Equals(((ButtonEx)sender).BtnEventId))
                {
                    MessageBox.Show("Lỗi");
                    btnF6_ClickOrgProc();
                }
                else if (BtnKeyId.F7.Equals(((ButtonEx)sender).BtnEventId))
                {
                    MessageBox.Show("Lỗi");
                    btnF7_ClickOrgProc();
                }
                else if (BtnKeyId.F8.Equals(((ButtonEx)sender).BtnEventId))
                {
                    MessageBox.Show("Lỗi");
                    btnF8_ClickOrgProc();
                }
                else if (BtnKeyId.F9.Equals(((ButtonEx)sender).BtnEventId))
                {
                    MessageBox.Show("Lỗi");
                    btnF9_ClickOrgProc();
                }
                else if (BtnKeyId.F10.Equals(((ButtonEx)sender).BtnEventId))
                {
                    MessageBox.Show("Lỗi");
                    btnF10_ClickOrgProc();
                }
                else if (BtnKeyId.F11.Equals(((ButtonEx)sender).BtnEventId))
                {
                    MessageBox.Show("Lỗi");
                    btnF11_ClickOrgProc();
                }
                else if (BtnKeyId.F12.Equals(((ButtonEx)sender).BtnEventId))
                {
                    MessageBox.Show("Lỗi");
                    btnF12_ClickOrgProc();
                }
                else if (BtnKeyId.CLEAR.Equals(((ButtonEx)sender).BtnEventId))
                {
                    MessageBox.Show("Lỗi");

                    btnCLEAR_ClickOrgProc();
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("E90_018");
                string[] strErr;
                strErr = new string[] { ex.Message, ex.Source, ex.StackTrace };
                this.Close();
            }
            catch (Exception ex)
            {
                //例外処理も共通化
                MessageBox.Show("E90_046");
                string[] strErr;
                strErr = new string[] { ex.Message, ex.Source, ex.StackTrace };
                this.Close();
            }
            finally
            {
                // 後処理
                comPostEvent();
            }

        }
        #endregion

        #endregion

        #region  ファンクションボタンコントロール操作

        #region  Width
        /// <summary>
        /// F1Key_Width
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public int F1Key_Width
        {
            get
            {
                return this.btnF1.Width;
            }
            set
            {
                this.btnF1.Width = value;
            }
        }
        /// <summary>
        /// F2Key_Width
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public int F2Key_Width
        {
            get
            {
                return this.btnF2.Width;
            }
            set
            {
                this.btnF2.Width = value;
            }
        }
        /// <summary>
        /// F3Key_Width
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public int F3Key_Width
        {
            get
            {
                return this.btnF3.Width;
            }
            set
            {
                this.btnF3.Width = value;
            }
        }
        /// <summary>
        /// F4Key_Width
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public int F4Key_Width
        {
            get
            {
                return this.btnF4.Width;
            }
            set
            {
                this.btnF4.Width = value;
            }
        }
        /// <summary>
        /// F5Key_Width
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public int F5Key_Width
        {
            get
            {
                return this.btnF5.Width;
            }
            set
            {
                this.btnF5.Width = value;
            }
        }
        /// <summary>
        /// F6Key_Width
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public int F6Key_Width
        {
            get
            {
                return this.btnF6.Width;
            }
            set
            {
                this.btnF6.Width = value;
            }
        }
        /// <summary>
        /// F7Key_Width
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public int F7Key_Width
        {
            get
            {
                return this.btnF7.Width;
            }
            set
            {
                this.btnF7.Width = value;
            }
        }
        /// <summary>
        /// F8Key_Width
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public int F8Key_Width
        {
            get
            {
                return this.btnF8.Width;
            }
            set
            {
                this.btnF8.Width = value;
            }
        }
        /// <summary>
        /// F9Key_Width
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public int F9Key_Width
        {
            get
            {
                return this.btnF9.Width;
            }
            set
            {
                this.btnF9.Width = value;
            }
        }
        /// <summary>
        /// F10Key_Width
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public int F10Key_Width
        {
            get
            {
                return this.btnF10.Width;
            }
            set
            {
                this.btnF10.Width = value;
            }
        }
        /// <summary>
        /// F11Key_Width
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public int F11Key_Width
        {
            get
            {
                return this.btnF11.Width;
            }
            set
            {
                this.btnF11.Width = value;
            }
        }
        /// <summary>
        /// F12Key_Width
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public int F12Key_Width
        {
            get
            {
                return this.btnF12.Width;
            }
            set
            {
                this.btnF12.Width = value;
            }
        }
        #endregion

        #region  Location X
        /// <summary>
        /// F1Key_Location_X
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public int F1Key_Location_X
        {
            get
            {
                return this.btnF1.Location.X;
            }
            set
            {
                this.btnF1.Location = new Point(value, _btnLocationY);
            }
        }
        /// <summary>
        /// F2Key_Location_X
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public int F2Key_Location_X
        {
            get
            {
                return this.btnF2.Location.X;
            }
            set
            {
                this.btnF2.Location = new Point(value, _btnLocationY);
            }
        }
        /// <summary>
        /// F3Key_Location_X
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public int F3Key_Location_X
        {
            get
            {
                return this.btnF3.Location.X;
            }
            set
            {
                this.btnF3.Location = new Point(value, _btnLocationY);
            }
        }
        /// <summary>
        /// F4Key_Location_X
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public int F4Key_Location_X
        {
            get
            {
                return this.btnF4.Location.X;
            }
            set
            {
                this.btnF4.Location = new Point(value, _btnLocationY);
            }
        }
        /// <summary>
        /// F5Key_Location_X
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public int F5Key_Location_X
        {
            get
            {
                return this.btnF5.Location.X;
            }
            set
            {
                this.btnF5.Location = new Point(value, _btnLocationY);
            }
        }
        /// <summary>
        /// F6Key_Location_X
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public int F6Key_Location_X
        {
            get
            {
                return this.btnF6.Location.X;
            }
            set
            {
                this.btnF6.Location = new Point(value, _btnLocationY);
            }
        }
        /// <summary>
        /// F7Key_Location_X
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public int F7Key_Location_X
        {
            get
            {
                return this.btnF7.Location.X;
            }
            set
            {
                this.btnF7.Location = new Point(value, _btnLocationY);
            }
        }
        /// <summary>
        /// F8Key_Location_X
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public int F8Key_Location_X
        {
            get
            {
                return this.btnF8.Location.X;
            }
            set
            {
                this.btnF8.Location = new Point(value, _btnLocationY);
            }
        }
        /// <summary>
        /// F9Key_Location_X
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public int F9Key_Location_X
        {
            get
            {
                return this.btnF9.Location.X;
            }
            set
            {
                this.btnF9.Location = new Point(value, _btnLocationY);
            }
        }
        /// <summary>
        /// F10Key_Location_X
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public int F10Key_Location_X
        {
            get
            {
                return this.btnF10.Location.X;
            }
            set
            {
                this.btnF10.Location = new Point(value, _btnLocationY);
            }
        }
        /// <summary>
        /// F11Key_Location_X
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public int F11Key_Location_X
        {
            get
            {
                return this.btnF11.Location.X;
            }
            set
            {
                this.btnF11.Location = new Point(value, _btnLocationY);
            }
        }
        /// <summary>
        /// F12Key_Location_X
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public int F12Key_Location_X
        {
            get
            {
                return this.btnF12.Location.X;
            }
            set
            {
                this.btnF12.Location = new Point(value, _btnLocationY);
            }
        }
        #endregion

        #region  Visible
        /// <summary>
        /// F1Key_Visible
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F1Key_Visible
        {
            get
            {
                return this.btnF1.Visible;
            }
            set
            {
                this.btnF1.Visible = value;
                _F1Key_Visible = value;
            }
        }
        /// <summary>
        /// F2Key_Visible
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F2Key_Visible
        {
            get
            {
                return this.btnF2.Visible;
            }
            set
            {
                this.btnF2.Visible = value;
                _F2Key_Visible = value;
            }
        }
        /// <summary>
        /// F3Key_Visible
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F3Key_Visible
        {
            get
            {
                return this.btnF3.Visible;
            }
            set
            {
                this.btnF3.Visible = value;
                _F3Key_Visible = value;
            }
        }
        /// <summary>
        /// F4Key_Visible
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F4Key_Visible
        {
            get
            {
                return this.btnF4.Visible;
            }
            set
            {
                this.btnF4.Visible = value;
                _F4Key_Visible = value;
            }
        }
        /// <summary>
        /// F5Key_Visible
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F5Key_Visible
        {
            get
            {
                return this.btnF5.Visible;
            }
            set
            {
                this.btnF5.Visible = value;
                _F5Key_Visible = value;
            }
        }
        /// <summary>
        /// F6Key_Visible
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F6Key_Visible
        {
            get
            {
                return this.btnF6.Visible;
            }
            set
            {
                this.btnF6.Visible = value;
                _F6Key_Visible = value;
            }
        }
        /// <summary>
        /// F7Key_Visible
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F7Key_Visible
        {
            get
            {
                return this.btnF7.Visible;
            }
            set
            {
                this.btnF7.Visible = value;
                _F7Key_Visible = value;
            }
        }
        /// <summary>
        /// F8Key_Visible
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F8Key_Visible
        {
            get
            {
                return this.btnF8.Visible;
            }
            set
            {
                this.btnF8.Visible = value;
                _F8Key_Visible = value;
            }
        }
        /// <summary>
        /// F9Key_Visible
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F9Key_Visible
        {
            get
            {
                return this.btnF9.Visible;
            }
            set
            {
                this.btnF9.Visible = value;
                _F9Key_Visible = value;
            }
        }
        /// <summary>
        /// F10Key_Visible
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F10Key_Visible
        {
            get
            {
                return this.btnF10.Visible;
            }
            set
            {
                this.btnF10.Visible = value;
                _F10Key_Visible = value;
            }
        }
        /// <summary>
        /// F11Key_Visible
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F11Key_Visible
        {
            get
            {
                return this.btnF11.Visible;
            }
            set
            {
                this.btnF11.Visible = value;
                _F11Key_Visible = value;
            }
        }
        /// <summary>
        /// F12Key_Visible
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F12Key_Visible
        {
            get
            {
                return this.btnF12.Visible;
            }
            set
            {
                this.btnF12.Visible = value;
                _F12Key_Visible = value;
            }
        }
        #endregion

        #region  Text
        /// <summary>
        /// F1Key_Text
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string F1Key_Text
        {
            get
            {
                return this.btnF1.Text;
            }
            set
            {
                this.btnF1.Text = value;
            }
        }
        /// <summary>
        /// F2Key_Text
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string F2Key_Text
        {
            get
            {
                return this.btnF2.Text;
            }
            set
            {
                this.btnF2.Text = value;
            }
        }
        /// <summary>
        /// F3Key_Text
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string F3Key_Text
        {
            get
            {
                return this.btnF3.Text;
            }
            set
            {
                this.btnF3.Text = value;
            }
        }
        /// <summary>
        /// F4Key_Text
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string F4Key_Text
        {
            get
            {
                return this.btnF4.Text;
            }
            set
            {
                this.btnF4.Text = value;
            }
        }
        /// <summary>
        /// F5Key_Text
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string F5Key_Text
        {
            get
            {
                return this.btnF5.Text;
            }
            set
            {
                this.btnF5.Text = value;
            }
        }
        /// <summary>
        /// F6Key_Text
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string F6Key_Text
        {
            get
            {
                return this.btnF6.Text;
            }
            set
            {
                this.btnF6.Text = value;
            }
        }
        /// <summary>
        /// F7Key_Text
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string F7Key_Text
        {
            get
            {
                return this.btnF7.Text;
            }
            set
            {
                this.btnF7.Text = value;
            }
        }
        /// <summary>
        /// F8Key_Text
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string F8Key_Text
        {
            get
            {
                return this.btnF8.Text;
            }
            set
            {
                this.btnF8.Text = value;
            }
        }
        /// <summary>
        /// F9Key_Text
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string F9Key_Text
        {
            get
            {
                return this.btnF9.Text;
            }
            set
            {
                this.btnF9.Text = value;
            }
        }
        /// <summary>
        /// F10Key_Text
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string F10Key_Text
        {
            get
            {
                return this.btnF10.Text;
            }
            set
            {
                this.btnF10.Text = value;
            }
        }
        /// <summary>
        /// F11Key_Text
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string F11Key_Text
        {
            get
            {
                return this.btnF11.Text;
            }
            set
            {
                this.btnF11.Text = value;
            }
        }
        /// <summary>
        /// F12Key_Text
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string F12Key_Text
        {
            get
            {
                return this.btnF12.Text;
            }
            set
            {
                this.btnF12.Text = value;
            }
        }
        #endregion

        #region  Enabled
        /// <summary>
        /// F1Key_Enabled
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F1Key_Enabled
        {
            get
            {
                return this.btnF1.Enabled;
            }
            set
            {
                this.btnF1.Enabled = value;
            }
        }
        /// <summary>
        /// F2Key_Enabled
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F2Key_Enabled
        {
            get
            {
                return this.btnF2.Enabled;
            }
            set
            {
                this.btnF2.Enabled = value;
            }
        }
        /// <summary>
        /// F3Key_Enabled
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F3Key_Enabled
        {
            get
            {
                return this.btnF3.Enabled;
            }
            set
            {
                this.btnF3.Enabled = value;
            }
        }
        /// <summary>
        /// F4Key_Enabled
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F4Key_Enabled
        {
            get
            {
                return this.btnF4.Enabled;
            }
            set
            {
                this.btnF4.Enabled = value;
            }
        }
        /// <summary>
        /// F5Key_Enabled
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F5Key_Enabled
        {
            get
            {
                return this.btnF5.Enabled;
            }
            set
            {
                this.btnF5.Enabled = value;
            }
        }
        /// <summary>
        /// F6Key_Enabled
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F6Key_Enabled
        {
            get
            {
                return this.btnF6.Enabled;
            }
            set
            {
                this.btnF6.Enabled = value;
            }
        }
        /// <summary>
        /// F7Key_Enabled
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F7Key_Enabled
        {
            get
            {
                return this.btnF7.Enabled;
            }
            set
            {
                this.btnF7.Enabled = value;
            }
        }
        /// <summary>
        /// F8Key_Enabled
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F8Key_Enabled
        {
            get
            {
                return this.btnF8.Enabled;
            }
            set
            {
                this.btnF8.Enabled = value;
            }
        }
        /// <summary>
        /// F9Key_Enabled
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F9Key_Enabled
        {
            get
            {
                return this.btnF9.Enabled;
            }
            set
            {
                this.btnF9.Enabled = value;
            }
        }
        /// <summary>
        /// F10Key_Enabled
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F10Key_Enabled
        {
            get
            {
                return this.btnF10.Enabled;
            }
            set
            {
                this.btnF10.Enabled = value;
            }
        }
        /// <summary>
        /// F11Key_Enabled
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F11Key_Enabled
        {
            get
            {
                return this.btnF11.Enabled;
            }
            set
            {
                this.btnF11.Enabled = value;
            }
        }
        /// <summary>
        /// F12Key_Enabled
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F12Key_Enabled
        {
            get
            {
                return this.btnF12.Enabled;
            }
            set
            {
                this.btnF12.Enabled = value;
            }
        }
        #endregion

        #region  AllowAuth
        /// <summary>
        /// F1Key_AllowAuth（F1キーの使用を許可する権限レベル（設定値以上が使用可能））
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public FixedCd.AuthLevel F1Key_AllowAuth
        {
            get
            {
                return this.btnF1.AllowAuthLevel;
            }
            set
            {
                this.btnF1.AllowAuthLevel = value;
            }
        }
        /// <summary>
        /// F2Key_AllowAuth（F2キーの使用を許可する権限レベル（設定値以上が使用可能））
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public FixedCd.AuthLevel F2Key_AllowAuth
        {
            get
            {
                return this.btnF2.AllowAuthLevel;
            }
            set
            {
                this.btnF2.AllowAuthLevel = value;
            }
        }
        /// <summary>
        /// F3Key_AllowAuth（F3キーの使用を許可する権限レベル（設定値以上が使用可能））
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public FixedCd.AuthLevel F3Key_AllowAuth
        {
            get
            {
                return this.btnF3.AllowAuthLevel;
            }
            set
            {
                this.btnF3.AllowAuthLevel = value;
            }
        }
        /// <summary>
        /// F4Key_AllowAuth（F4キーの使用を許可する権限レベル（設定値以上が使用可能））
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public FixedCd.AuthLevel F4Key_AllowAuth
        {
            get
            {
                return this.btnF4.AllowAuthLevel;
            }
            set
            {
                this.btnF4.AllowAuthLevel = value;
            }
        }
        /// <summary>
        /// F5Key_AllowAuth（F5キーの使用を許可する権限レベル（設定値以上が使用可能））
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public FixedCd.AuthLevel F5Key_AllowAuth
        {
            get
            {
                return this.btnF5.AllowAuthLevel;
            }
            set
            {
                this.btnF5.AllowAuthLevel = value;
            }
        }
        /// <summary>
        /// F6Key_AllowAuth（F6キーの使用を許可する権限レベル（設定値以上が使用可能））
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public FixedCd.AuthLevel F6Key_AllowAuth
        {
            get
            {
                return this.btnF6.AllowAuthLevel;
            }
            set
            {
                this.btnF6.AllowAuthLevel = value;
            }
        }
        /// <summary>
        /// F7Key_AllowAuth（F7キーの使用を許可する権限レベル（設定値以上が使用可能））
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public FixedCd.AuthLevel F7Key_AllowAuth
        {
            get
            {
                return this.btnF7.AllowAuthLevel;
            }
            set
            {
                this.btnF7.AllowAuthLevel = value;
            }
        }
        /// <summary>
        /// F8Key_AllowAuth（F8キーの使用を許可する権限レベル（設定値以上が使用可能））
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public FixedCd.AuthLevel F8Key_AllowAuth
        {
            get
            {
                return this.btnF8.AllowAuthLevel;
            }
            set
            {
                this.btnF8.AllowAuthLevel = value;
            }
        }
        /// <summary>
        /// F9Key_AllowAuth（F9キーの使用を許可する権限レベル（設定値以上が使用可能））
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public FixedCd.AuthLevel F9Key_AllowAuth
        {
            get
            {
                return this.btnF9.AllowAuthLevel;
            }
            set
            {
                this.btnF9.AllowAuthLevel = value;
            }
        }
        /// <summary>
        /// F10Key_AllowAuth（F10キーの使用を許可する権限レベル（設定値以上が使用可能））
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public FixedCd.AuthLevel F10Key_AllowAuth
        {
            get
            {
                return this.btnF10.AllowAuthLevel;
            }
            set
            {
                this.btnF10.AllowAuthLevel = value;
            }
        }
        /// <summary>
        /// F11Key_AllowAuth（F11キーの使用を許可する権限レベル（設定値以上が使用可能））
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public FixedCd.AuthLevel F11Key_AllowAuth
        {
            get
            {
                return this.btnF11.AllowAuthLevel;
            }
            set
            {
                this.btnF11.AllowAuthLevel = value;
            }
        }
        /// <summary>
        /// F12Key_AllowAuth（F12キーの使用を許可する権限レベル（設定値以上が使用可能））
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public FixedCd.AuthLevel F12Key_AllowAuth
        {
            get
            {
                return this.btnF12.AllowAuthLevel;
            }
            set
            {
                this.btnF12.AllowAuthLevel = value;
            }
        }
        #endregion

        #region  AuthControl
        /// <summary>
        /// F1Key_AuthControl
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F1Key_AuthControl
        {
            get
            {
                return this.btnF1.AuthControl;
            }
            set
            {
                this.btnF1.AuthControl = value;
            }
        }
        /// <summary>
        /// F2Key_AuthControl
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F2Key_AuthControl
        {
            get
            {
                return this.btnF2.AuthControl;
            }
            set
            {
                this.btnF2.AuthControl = value;
            }
        }
        /// <summary>
        /// F3Key_AuthControl
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F3Key_AuthControl
        {
            get
            {
                return this.btnF3.AuthControl;
            }
            set
            {
                this.btnF3.AuthControl = value;
            }
        }
        /// <summary>
        /// F4Key_AuthControl
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F4Key_AuthControl
        {
            get
            {
                return this.btnF4.AuthControl;
            }
            set
            {
                this.btnF4.AuthControl = value;
            }
        }
        /// <summary>
        /// F5Key_AuthControl
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F5Key_AuthControl
        {
            get
            {
                return this.btnF5.AuthControl;
            }
            set
            {
                this.btnF5.AuthControl = value;
            }
        }
        /// <summary>
        /// F6Key_AuthControl
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F6Key_AuthControl
        {
            get
            {
                return this.btnF6.AuthControl;
            }
            set
            {
                this.btnF6.AuthControl = value;
            }
        }
        /// <summary>
        /// F7Key_AuthControl
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F7Key_AuthControl
        {
            get
            {
                return this.btnF7.AuthControl;
            }
            set
            {
                this.btnF7.AuthControl = value;
            }
        }
        /// <summary>
        /// F8Key_AuthControl
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F8Key_AuthControl
        {
            get
            {
                return this.btnF8.AuthControl;
            }
            set
            {
                this.btnF8.AuthControl = value;
            }
        }
        /// <summary>
        /// F9Key_AuthControl
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F9Key_AuthControl
        {
            get
            {
                return this.btnF9.AuthControl;
            }
            set
            {
                this.btnF9.AuthControl = value;
            }
        }
        /// <summary>
        /// F10Key_AuthControl
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F10Key_AuthControl
        {
            get
            {
                return this.btnF10.AuthControl;
            }
            set
            {
                this.btnF10.AuthControl = value;
            }
        }
        /// <summary>
        /// F11Key_AuthControl
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F11Key_AuthControl
        {
            get
            {
                return this.btnF11.AuthControl;
            }
            set
            {
                this.btnF11.AuthControl = value;
            }
        }
        /// <summary>
        /// F12Key_AuthControl
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool F12Key_AuthControl
        {
            get
            {
                return this.btnF12.AuthControl;
            }
            set
            {
                this.btnF12.AuthControl = value;
            }
        }
        #endregion

        #region  メソッド

        #region 公開メソッド
        /// <summary>
        /// ファンクションのコントロールを取得する
        /// </summary>
        /// <param name="FuncNo"></param>
        /// <remarks></remarks>
        public ButtonEx getFunctionCtl(int FuncNo)
        {
            ButtonEx ctl = null;
            switch (FuncNo)
            {
                case 1:
                    ctl = this._pbtnF1;
                    break;
                case 2:
                    ctl = this._pbtnF2;
                    break;
                case 3:
                    ctl = this._pbtnF3;
                    break;
                case 4:
                    ctl = this._pbtnF4;
                    break;
                case 5:
                    ctl = this._pbtnF5;
                    break;
                case 6:
                    ctl = this._pbtnF6;
                    break;
                case 7:
                    ctl = this._pbtnF7;
                    break;
                case 8:
                    ctl = this._pbtnF8;
                    break;
                case 9:
                    ctl = this._pbtnF9;
                    break;
                case 10:
                    ctl = this._pbtnF10;
                    break;
                case 11:
                    ctl = this._pbtnF11;
                    break;
                case 12:
                    ctl = this._pbtnF12;
                    break;
            }
            return ctl;
        }


        /// <summary>
        /// ExistErrorのクリア
        /// </summary>
        protected void clearExistError()
        {

            // UserControlのExistErrorプロパティのクリア
            clearExistErrorProperty(this.Controls);

            // Exceptionのクリア
            this.Exception = null;

            // エラーフラグの初期化
            this.ErrorFlg = false;

        }
        /// <summary>
        /// エラー有無プロパティのクリア
        /// </summary>
        /// <param name="winControls"></param>
        protected void clearExistErrorProperty(Control.ControlCollection winControls)
        {

            //
            foreach (Control winControl in winControls)
            {

                // エラー有無プロパティのクリア
                if (winControl is ButtonEx)
                {
                    // 「ButtonEx」の場合は何もしない
                    continue;
                }
                else if (winControl is LabelEx)
                {
                    // 「LabelEx」の場合は何もしない
                    continue;
                }
                else if (winControl is TextBoxEx)
                {
                    // 取り出したControlを「TextBoxEx」にCastする
                    TextBoxEx textBoxExWk = (TextBoxEx)winControl;

                    // 「TextBoxEx」のエラー有無プロパティをクリア
                    textBoxExWk.ExistError = false;

                    // 変数のクリア(参照先のControlは「Dispose」しないこと)
                    textBoxExWk = null;
                }
                else if (winControl is NumberEx)
                {
                    // 取り出したControlを「NumberEx」にCastする
                    object numberExWk = (NumberEx)winControl;

                    // 「NumberEx」のエラー有無プロパティをクリア
                    numberExWk.ExistError = false;

                    // 変数のクリア(参照先のControlは「Dispose」しないこと)
                    numberExWk = null;
                }
                else if (winControl is DateEx)
                {
                    // 取り出したControlを「DateEx」にCastする
                    DateEx dateExWk = (DateEx)winControl;

                    // 「DateEx」のエラー有無プロパティをクリア
                    dateExWk.ExistError = false;

                    // 変数のクリア(参照先のControlは「Dispose」しないこと)
                    dateExWk = null;
                }
                else if (winControl is TimeEx)
                {
                    // 取り出したControlを「TimeEx」にCastする
                    TimeEx timeExWk = (TimeEx)winControl;

                    // 「TimeEx」のエラー有無プロパティをクリア
                    timeExWk.ExistError = false;

                    // 変数のクリア(参照先のControlは「Dispose」しないこと)
                    timeExWk = null;
                }
                else if (winControl is Time24Ex)
                {
                    // 取り出したControlを「TimeEx」にCastする
                    Time24Ex timeExWk = (Time24Ex)winControl;

                    // 「TimeEx」のエラー有無プロパティをクリア
                    timeExWk.ExistError = false;

                    // 変数のクリア(参照先のControlは「Dispose」しないこと)
                    timeExWk = null;
                }
                else if (winControl is MaskEx)
                {
                    // 取り出したControlを「MaskEx」にCastする
                    MaskEx maskExWk = (MaskEx)winControl;

                    // 「MaskEx」のエラー有無プロパティをクリア
                    maskExWk.ExistError = false;

                    // 変数のクリア(参照先のControlは「Dispose」しないこと)
                    maskExWk = null;
                }
                else if (winControl is YoyakuNoEx)
                {
                    // 取り出したControlを「YoyakuNoEx」にCastする
                    YoyakuNoEx yoyakuNoExWk = (YoyakuNoEx)winControl;

                    // 「YoyakuNoEx」のエラー有無プロパティをクリア
                    yoyakuNoExWk.ExistError = false;

                    // 変数のクリア(参照先のControlは「Dispose」しないこと)
                    yoyakuNoExWk = null;
                    //Case TypeOf winControl Is CodeControlEx
                    //    ' 取り出したControlを「CodeControlEx」にCastする
                    //    Dim codeControlExWk As CodeControlEx = CType(winControl, CodeControlEx)

                    //    ' 「CodeControlEx」のエラー有無プロパティをクリア
                    //    codeControlExWk.txtCode.ExistError = False
                    //    codeControlExWk.txtValue.ExistError = False

                    //    ' 変数のクリア(参照先のControlは「Dispose」しないこと)
                    //    codeControlExWk = Nothing
                }
                else if ("CodeControlEx".Equals(winControl.GetType().Name))
                {
                    ((ICodeControlEx)winControl).clearError();
                }
                else if ("AddressEx".Equals(winControl.GetType().Name))
                {
                    // 「AddressEx」配下に配置されている各Controlのエラー有無プロパティをクリア
                    clearExistErrorProperty(winControl.Controls);
                }
                else if (winControl is FromToDateEx)
                {
                    // 取り出したControlを「FromToDateEx」にCastする
                    FromToDateEx fromToDateExWk = (FromToDateEx)winControl;

                    // 「FromToDateEx」のエラー有無プロパティをクリア
                    fromToDateExWk.ExistErrorForFromDate = false;
                    fromToDateExWk.ExistErrorForToDate = false;

                    // 変数のクリア(参照先のControlは「Dispose」しないこと)
                    fromToDateExWk = null;
                }
                else if (winControl is FromToTimeEx)
                {
                    // 取り出したControlを「FromToTimeEx」にCastする
                    FromToTimeEx fromToTimeExWk = (FromToTimeEx)winControl;

                    // 「FromToTimeEx」のエラー有無プロパティをクリア
                    fromToTimeExWk.ExistErrorForFromTime = false;
                    fromToTimeExWk.ExistErrorForToTime = false;

                    // 変数のクリア(参照先のControlは「Dispose」しないこと)
                    fromToTimeExWk = null;
                }
                else if (winControl is FromToTime24Ex)
                {
                    // 取り出したControlを「FromToTimeEx」にCastする
                    FromToTime24Ex fromToTimeExWk = (FromToTime24Ex)winControl;

                    // 「FromToTimeEx」のエラー有無プロパティをクリア
                    fromToTimeExWk.ExistErrorForFromTime = false;
                    fromToTimeExWk.ExistErrorForToTime = false;

                    // 変数のクリア(参照先のControlは「Dispose」しないこと)
                    fromToTimeExWk = null;
                }
                else if (winControl is CheckBoxEx)
                {
                    // 取り出したControlを「CheckBoxEx」にCastする
                    CheckBoxEx checkBoxExWk = (CheckBoxEx)winControl;

                    // 「CheckBoxEx」のエラー有無プロパティをクリア
                    checkBoxExWk.ExistError = false;

                    // 変数のクリア(参照先のControlは「Dispose」しないこと)
                    checkBoxExWk = null;
                }
                else if (winControl is RadioButtonEx)
                {
                    // 取り出したControlを「RadioButtonEx」にCastする
                    RadioButtonEx radioButtonExWk = (RadioButtonEx)winControl;

                    // 「RadioButtonEx」のエラー有無プロパティをクリア
                    radioButtonExWk.ExistError = false;

                    // 変数のクリア(参照先のControlは「Dispose」しないこと)
                    radioButtonExWk = null;
                }
                else if (winControl is ComboBoxEx)
                {
                    // 取り出したControlを「ComboBox」にCastする
                    ComboBoxEx combBoxExWk = (ComboBoxEx)winControl;

                    // 「ComboBox」のエラー有無プロパティをクリア
                    combBoxExWk.ExistError = false;

                    // 変数のクリア(参照先のControlは「Dispose」しないこと)
                    combBoxExWk = null;
                }
                else if (winControl is FlexGridEx)
                {
                    // 「FlexGridEx」の場合は何もしない
                    continue;
                }
                else if (winControl is GroupBoxEx)
                {
                    // 取り出したControlを「GroupBoxEx」にCastする
                    GroupBoxEx groupBoxExWk = (GroupBoxEx)winControl;

                    // 「GroupBoxEx」配下に配置されている各Controlのエラー有無プロパティをクリア
                    clearExistErrorProperty(groupBoxExWk.Controls);

                    // 変数のクリア(参照先のControlは「Dispose」しないこと)
                    groupBoxExWk = null;
                }
                else if (winControl is PanelEx)
                {
                    // 取り出したControlを「PanelEx」にCastする
                    PanelEx panelExWk = (PanelEx)winControl;

                    // 「PanelEx」」配下に配置されている各Controlのエラー有無プロパティをクリア
                    clearExistErrorProperty(panelExWk.Controls);

                    // 変数のクリア(参照先のControlは「Dispose」しないこと)
                    panelExWk = null;
                }
                else
                {
                    // 上記以外の場合は何もしない
                    continue;
                }

            }

        }

        /// <summary>
        /// 次画面へ遷移
        /// </summary>
        /// <param name="frm">表示フォーム</param>
        /// <param name="parentDispFlg">呼出元画面表示フラグ（親画面を表示したままにしたい場合はTrueを設定）</param>
        protected void openWindow(Form frm, bool parentDispFlg)
        {
            try
            {
                if (parentDispFlg == false)
                {
                    this.Visible = false;
                }
                if (frm is iPT99)
                {
                    ((iPT99)frm).iPt99StartSetting();
                }

                frm.ShowDialog(this);
                this.Refresh();
                if (parentDispFlg == false)
                {
                    this.Visible = true;
                }
            }
            catch (Exception ex)
            {
                // 非表示状態でExceptionがthrowされると、visible=falseのままとなる為、再表示
                this.Visible = true;
                string[] strErrNaiyo;
                strErrNaiyo = new[] { "ex.Message;" + ex.Message, "ex.Source;" + ex.Source, "ex.StackTrace;" + ex.StackTrace };

                MessageBox.Show("E90_046");
                frm.Close();
            }
            finally
            {
                frm.Dispose();
            }
        }
        #endregion

        #region 固有メソッド
        /// <summary>
        ///
        /// </summary>
        private void setControlInitiarize()
        {

            //Visible
            this.F1Key_Visible = true;
            this.F2Key_Visible = true;
            this.F3Key_Visible = true;
            this.F4Key_Visible = true;
            this.F5Key_Visible = true;
            this.F6Key_Visible = true;
            this.F7Key_Visible = true;
            this.F8Key_Visible = true;
            this.F9Key_Visible = true;
            this.F10Key_Visible = true;
            this.F11Key_Visible = true;
            this.F12Key_Visible = true;

            // 権限制御有無
            this.F1Key_AuthControl = false;
            this.F2Key_AuthControl = false;
            this.F3Key_AuthControl = true;
            this.F4Key_AuthControl = true;
            this.F5Key_AuthControl = true;
            this.F6Key_AuthControl = true;
            this.F7Key_AuthControl = true;
            this.F8Key_AuthControl = true;
            this.F9Key_AuthControl = true;
            this.F10Key_AuthControl = true;
            this.F11Key_AuthControl = true;
            this.F12Key_AuthControl = true;

            // Fキー使用可能権限を設定（F1、F2キー以外は不可権限は使用不可とする）
            this.F1Key_AllowAuth = FixedCd.AuthLevel.non; // 設定するが未使用
            this.F2Key_AllowAuth = FixedCd.AuthLevel.non; // 設定するが未使用
            this.F3Key_AllowAuth = FixedCd.AuthLevel.read;
            this.F4Key_AllowAuth = FixedCd.AuthLevel.read;
            this.F5Key_AllowAuth = FixedCd.AuthLevel.read;
            this.F6Key_AllowAuth = FixedCd.AuthLevel.read;
            this.F7Key_AllowAuth = FixedCd.AuthLevel.read;
            this.F8Key_AllowAuth = FixedCd.AuthLevel.read;
            this.F9Key_AllowAuth = FixedCd.AuthLevel.read;
            this.F10Key_AllowAuth = FixedCd.AuthLevel.read;
            this.F11Key_AllowAuth = FixedCd.AuthLevel.read;
            this.F12Key_AllowAuth = FixedCd.AuthLevel.read;

            //Enabled（ボタン側で権限に従い最終的に活性になるか制御）
            this.F1Key_Enabled = true;
            this.F2Key_Enabled = true;
            this.F3Key_Enabled = true;
            this.F4Key_Enabled = true;
            this.F5Key_Enabled = true;
            this.F6Key_Enabled = true;
            this.F7Key_Enabled = true;
            this.F8Key_Enabled = true;
            this.F9Key_Enabled = true;
            this.F10Key_Enabled = true;
            this.F11Key_Enabled = true;
            this.F12Key_Enabled = true;

            this._pbtnF1 = this.btnF1;
            this._pbtnF2 = this.btnF2;
            this._pbtnF3 = this.btnF3;
            this._pbtnF4 = this.btnF4;
            this._pbtnF5 = this.btnF5;
            this._pbtnF6 = this.btnF6;
            this._pbtnF7 = this.btnF7;
            this._pbtnF8 = this.btnF8;
            this._pbtnF9 = this.btnF9;
            this._pbtnF10 = this.btnF10;
            this._pbtnF11 = this.btnF11;
            this._pbtnF12 = this.btnF12;

        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (closeFormFlg == false)
                {
                    e.Cancel = false;
                }
                else
                {
                    if (closingScreen() == false)
                    {

                        if (CommonProcess.createFactoryMsg().messageDisp("W90_003", "変更") == DialogResult.Cancel)
                        {
                            e.Cancel = true;
                            closeReturnFlg = false;
                        }
                    }
                }
                closeFormFlg = true;

            }
            catch (OracleException ex)
            {
                MessageBox.Show("E90_018");
                string[] strErr;
                strErr = new string[] { ex.Message, ex.Source, ex.StackTrace };
                this.Close();
            }
            catch (Exception ex)
            {
                //例外処理も共通化
                MessageBox.Show("E90E90_046_018");
                string[] strErr;
                strErr = new string[] { ex.Message, ex.Source, ex.StackTrace };
                this.Close();
            }
        }
        #endregion

        #region 具象メソッド(宣言)
        /// <summary>
        /// フォーム起動時の独自処理
        /// </summary>
        protected virtual void StartupOrgProc()
        {
        }

        /// <summary>
        /// フォーム終了時の独自処理
        /// </summary>
        protected virtual void FormClosingOrgProc()
        {
        }

        /// <summary>
        /// F1ボタン押下時の独自処理
        /// </summary>
        protected virtual void btnF1_ClickOrgProc()
        {
        }

        /// <summary>
        /// F2ボタン押下時の独自処理
        /// </summary>
        protected virtual void btnF2_ClickOrgProc()
        {
        }

        /// <summary>
        /// F3ボタン押下時の独自処理
        /// </summary>
        protected virtual void btnF3_ClickOrgProc()
        {
        }

        /// <summary>
        /// F4ボタン押下時の独自処理
        /// </summary>
        protected virtual void btnF4_ClickOrgProc()
        {
        }

        /// <summary>
        /// F5ボタン押下時の独自処理
        /// </summary>
        protected virtual void btnF5_ClickOrgProc()
        {
        }

        /// <summary>
        /// F6ボタン押下時の独自処理
        /// </summary>
        protected virtual void btnF6_ClickOrgProc()
        {
        }

        /// <summary>
        /// F7ボタン押下時の独自処理
        /// </summary>
        protected virtual void btnF7_ClickOrgProc()
        {
        }

        /// <summary>
        /// F8ボタン押下時の独自処理
        /// </summary>
        protected virtual void btnF8_ClickOrgProc()
        {
        }

        /// <summary>
        /// F9ボタン押下時の独自処理
        /// </summary>
        protected virtual void btnF9_ClickOrgProc()
        {
        }

        /// <summary>
        /// F10ボタン押下時の独自処理
        /// </summary>
        protected virtual void btnF10_ClickOrgProc()
        {
        }

        /// <summary>
        /// F11ボタン押下時の独自処理
        /// </summary>
        protected virtual void btnF11_ClickOrgProc()
        {
        }

        /// <summary>
        /// F12ボタン押下時の独自処理
        /// </summary>
        protected virtual void btnF12_ClickOrgProc()
        {
        }

        /// <summary>
        /// CLEARボタン押下時の独自処理
        /// </summary>
        protected virtual void btnCLEAR_ClickOrgProc()
        {
        }

        /// <summary>
        /// 画面Close時の独自処理(判定付き)
        /// </summary>
        /// <returns></returns>
        protected virtual bool closingScreen()
        {
            return true;
        }

        // ↓↓↓ 処理共通化のため移動(各中間クラス⇒FormBase) ↓↓↓
        #region [登録処理](登録処理入力チェック)
        /// <summary>
        /// [登録処理](登録処理入力チェック)
        /// </summary>
        /// <returns></returns>
        protected virtual bool checkInsertItems()
        {
            return true;
        }
        #endregion

        #region [更新処理](更新処理入力チェック)
        /// <summary>
        /// [更新処理](更新処理入力チェック)
        /// </summary>
        /// <returns></returns>
        protected virtual bool checkUpdateItems()
        {
            return true;
        }
        #endregion

        #region [変更チェック](差分チェック)
        /// <summary>
        /// [変更チェック](差分チェック)
        /// </summary>
        /// <returns></returns>
        protected virtual bool checkDifference()
        {
            return true;
        }
        #endregion

        #region [Dataセット]画面=>エンティティ(更新対象項目をエンティティにセット)
        /// <summary>
        /// [Dataセット]画面=>エンティティ(更新対象項目をエンティティにセット)
        /// </summary>
        protected virtual void setEntityDataValue()
        {
        }
        #endregion

        #region 登録対象データの登録[マスタ系]
        /// <summary>
        /// 登録対象データの登録[マスタ系]
        /// </summary>
        /// <returns></returns>
        protected virtual int insertMstData()
        {

            // 変数宣言
            int rowCount = 0;

            try
            {
                // TODO:ここに挿入処理を記述する(以下は実装例)
                rowCount = ExecuteInsertMaster();

            }
            catch (Exception)
            {
                throw;
                rowCount = -2;
            }
            finally
            {

            }

            // 呼び出し元に影響を受けたデータの件数を返す
            return rowCount;

        }
        #endregion

        #region 更新対象データの更新[マスタ系]
        /// <summary>
        /// 更新対象データの更新[マスタ系]
        /// </summary>
        /// <returns></returns>
        protected virtual int updateMstData()
        {

            // 変数宣言
            int rowCount = 0;

            try
            {
                // TODO:ここに挿入処理を記述する(以下は実装例)
                rowCount = ExecuteUpdateMaster();

            }
            catch (Exception)
            {
                throw;
                rowCount = -2;
            }
            finally
            {

            }

            // 呼び出し元に影響を受けたデータの件数を返す
            return rowCount;

        }
        #endregion

        #region 登録対象データ登録用SQLの実行[マスタ系]
        /// <summary>
        /// 登録対象データ登録用SQLの実行[マスタ系]
        /// </summary>
        /// <returns></returns>
        protected virtual int ExecuteInsertMaster()
        {
            return 0;
        }
        #endregion

        #region 更新対象データ更新用SQLの実行[マスタ系]
        /// <summary>
        /// 更新対象データ更新用SQLの実行[マスタ系]
        /// </summary>
        /// <returns></returns>
        protected virtual int ExecuteUpdateMaster()
        {
            return 0;
        }
        #endregion

        #region 登録対象データの登録[トランザクション系]
        /// <summary>
        /// 登録対象データの登録[トランザクション系]
        /// </summary>
        /// <returns></returns>
        protected virtual int insertTranData()
        {

            // 変数宣言
            int rowCount = 0;

            try
            {

                // TODO:ここに挿入処理を記述する(以下は実装例)
                rowCount = ExecuteInsertTran();


            }
            catch (Exception)
            {
                throw;
                rowCount = -2;
            }
            finally
            {

            }

            // 呼び出し元に影響を受けたデータの件数を返す
            return rowCount;

        }
        #endregion

        #region 更新対象データの更新[トランザクション系]
        /// <summary>
        /// 更新対象データの更新
        /// </summary>
        /// <returns></returns>
        protected virtual int updateTranData()
        {

            // 変数宣言
            int rowCount = 0;

            try
            {
                // TODO:ここに挿入処理を記述する(以下は実装例)
                rowCount = ExecuteUpdateTran();

            }
            catch (Exception)
            {
                throw;
                rowCount = -2;
            }
            finally
            {

            }

            // 呼び出し元に影響を受けたデータの件数を返す
            return rowCount;

        }
        #endregion

        #region 登録対象データ登録用SQLの実行[マスタ系] //新川では[トランザクション系]となっている
        /// <summary>
        /// 登録対象データ登録用SQLの実行
        /// </summary>
        /// <returns></returns>
        protected virtual int ExecuteInsertTran()
        {
            return 0;
        }
        #endregion

        #region 更新対象データ更新用SQLの実行[マスタ系] //新川では[トランザクション系]となっている
        /// <summary>
        /// 更新対象データ更新用SQLの実行
        /// </summary>
        /// <returns></returns>
        protected virtual int ExecuteUpdateTran()
        {
            return 0;
        }
        #endregion

        #region
        /// <summary>
        ///
        /// </summary>
        /// <param name="updateFlg"></param>
        /// <returns>
        ///      1以上:正常終了
        ///      0    :正常終了(キャンセル/未実行[差異無しのため])
        ///     -1    :異常終了
        ///     -2    :処理中断
        /// </returns>
        protected virtual int DbOperator(DbShoriKbn updateFlg)
        {
            string msgid = "";
            string msgParam = "";

            //Entityに値をセット
            setEntityDataValue();


            msgid = "Q90_001";

            if (DbShoriKbn.Insert.Equals(updateFlg))
            {
                //登録時のチェック(既存データとの重複チェック)
                if (checkInsertItems() == false)
                {
                    return RET_NONEXEC;
                }

                msgParam = "登録";
            }
            else
            {
                //変更確認追加
                if (checkDifference() == true)
                {
                    CommonProcess.createFactoryMsg().messageDisp("E90_068");
                    return RET_NONEXEC;
                }

                //更新時のチェック(プライマリーキー項目の変更確認)
                if (checkUpdateItems() == false)
                {
                    return RET_NONEXEC;
                }

                msgParam = "更新";
            }

            //メッセージ出力(登録します。よろしいですか？／更新します。よろしいですか？)
            //***[メッセージ処理が提供されるまでコメントアウト]*********************
            if (CommonProcess.createFactoryMsg().messageDisp(msgid, msgParam) == DialogResult.Cancel)
            {
                //キャンセル
                return RET_CANCEL;
            }
            else
            {
                if (DbShoriKbn.Insert.Equals(updateFlg))
                {
                    //登録処理実行
                    if (this.GetType().BaseType.Name == "PT71")
                    {
                        return insertMstData();
                    }
                    else
                    {
                        return insertTranData();
                    }
                }
                else
                {
                    //更新処理実行
                    int updResult = 0;
                    if (this.GetType().BaseType.Name == "PT71")
                    {
                        updResult = updateMstData();
                    }
                    else
                    {
                        updResult = updateTranData();
                    }
                    //結果判定
                    if (updResult == 0)
                    {
                        //更新結果件数が0件の場合
                        return RET_NONDATAUPDATED;
                    }
                    else
                    {
                        //更新されたデータがある場合、その件数を返す
                        return updResult;
                    }
                }
            }

        }


        #endregion
        #endregion

        #endregion

        #endregion
    }
}
