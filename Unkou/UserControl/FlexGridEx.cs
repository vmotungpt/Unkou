using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Collections;
using static ClientConstantCode;
using Microsoft.VisualBasic;

namespace Unkou.UserControl
{
    public partial class FlexGridEx : C1FlexGrid
    {

        #region コンストラクタ

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <remarks></remarks>
        public FlexGridEx()
        {

            #endregion

            #region イベント

            /// <summary>
            /// グリッド再描画イベント
            /// </summary>
            /// <param name="sender">イベント送信元</param>
            /// <param name="e">イベントデータ</param>
            this.Paint += FlexGridEx_Paint;

            /// <summary>
            /// 編集モードに入る前
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            this.StartEdit += FlexGridV2Ex_StartEdit;
            this.AutoSize = true;
            this.Font = new Font("ＭＳ ゴシック", (float)11.25d);
            this.VisualStyle = VisualStyle.System;

            // マウスドラッグ不可 (初期値：True)
            this.AllowDragging = AllowDraggingEnum.None;

            // 自動列生成なし (初期値：True)
            this.AutoGenerateColumns = false;

            // エンターキーとタブキーを押下した場合、次のセルに移動する。
            this.KeyActionEnter = KeyActionEnum.MoveAcrossOut;
            this.KeyActionTab = KeyActionEnum.MoveAcrossOut;

            // 選択されたセルを強調表示するか
            this.HighLight = HighLightEnum.WithFocus;

            // セルにいつボタンを表示するか ※常に表示 (ex)ボタン (初期値：Inherit)
            this.ShowButtons = ShowButtonsEnum.Always;
        }

        #region 変数

        /// <summary>
        /// セルに埋め込むコントロール群
        /// </summary>
        public ArrayList HostedControlArr = new ArrayList();

        // 背景色：編集不可 (デフォルト：グレー)
        private Color _colorControlLight = SystemColors.ControlLight;

        #endregion

        #region 定数
        /// <summary>
        /// セルボタンタイプ
        /// </summary>
        public partial struct CellButtonType
        {
            // ボタンのみ
            public const string CellButton = "...";
            // 入力ボタン
            public const string InputButton = "|...";
        }

        #endregion

        #region 列挙
        /// <summary>
        /// 行移動方向
        /// </summary>
        public enum RowMoveType
        {
            up,
            down
        }
        #endregion

        #region プロパティ
        /// <summary>
        /// グリッド初期設定用プロパティ
        /// </summary>
        public partial class GridProperty
        {
            public string Caption { get; set; } = null;
            public string Name { get; set; } = null;
            public int? Width { get; set; } = default;
            public string ComboList { get; set; } = null;
            public IDictionary DataMap { get; set; } = null;
            public Control Editor { get; set; } = default;
            public Type DataType { get; set; } = null;
            public bool AllowEditing { get; set; } = false;
            public bool Visible { get; set; } = true;
        }

        /// <summary>
        /// 編集不可の背景色を設定するリスト
        /// </summary>
        public List<Color> NonEditColorList { get; set; } = new List<Color>();

        private void FlexGridEx_Paint(object sender, PaintEventArgs e)
        {
            foreach (HostedControl hosted in HostedControlArr)
                hosted.UpdatePosition();
        }

        private void FlexGridV2Ex_StartEdit(object sender, RowColEventArgs e)
        {

            // 編集不可リストに存在する場合、編集不可にする
            if (isCellNonEdit(e.Row, e.Col) == true)
            {
                e.Cancel = true;
            }

            // IMEMODE設定
            this.setImeMode(e.Row, e.Col);
        }

        #region マウスダウン (一旦、コメント)
        // ' マージセルのチェックボックスは値が変更できません。
        // ' 回避イベント
        // '  クリックされたセルを含むマージ範囲を取得し、マージ範囲全体の値を変更
        // Private Sub grdList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click

        // ' タイトルかどうかを判別
        // If ((Me.MouseRow < Me.Rows.Fixed) Or (Me.MouseCol < Me.Cols.Fixed)) Then
        // ' タイトルをクリックした場合
        // Exit Sub
        // End If

        // ' チェックボックスセルかどうかを判別
        // If Me.GetCellRange(Me.Row, Me.Col).Checkbox.Equals(CheckEnum.None) Then
        // ' チェックボックス以外をクリックした場合
        // Exit Sub
        // End If

        // ' マージ範囲を取得
        // Dim cr As CellRange
        // cr = Me.GetMergedRange(Me.Row, Me.Col, False)

        // ' マージセルかどうかを判別
        // If cr.IsSingleCell = True Then
        // ' マージセルでない場合
        // Exit Sub
        // End If

        // ' チェック状態を取得
        // Dim checkStatus As CheckEnum = Me.GetCellCheck(Me.Row, Me.Col)

        // ' マージ範囲全体の値を変更
        // If checkStatus.Equals(CheckEnum.Unchecked) Then
        // cr.Checkbox = CheckEnum.Checked
        // Else
        // cr.Checkbox = CheckEnum.Unchecked
        // End If

        // End Sub
        #endregion

        #endregion

        #region メソッド

        #region 初期設定
        /// <summary>
        /// 初期設定
        /// </summary>
        /// <param name="gridPropertyList"></param>
        public void Initialize(List<GridProperty> gridPropertyList)
        {
            for (int col = 0, loopTo = gridPropertyList.Count - 1; col <= loopTo; col++)
            {
                if (gridPropertyList[col] is null)
                {
                    continue;
                }

                {
                    var withBlock = this.Cols[col];
                    if (gridPropertyList[col].Caption is object)
                    {
                        withBlock.Caption = gridPropertyList[col].Caption;
                    }

                    if (gridPropertyList[col].Name is object)
                    {
                        withBlock.Name = gridPropertyList[col].Name;
                    }

                    if (gridPropertyList[col].Width is object)
                    {
                        withBlock.Width = (int)gridPropertyList[col].Width;
                    }

                    if (gridPropertyList[col].ComboList is object)
                    {
                        withBlock.ComboList = gridPropertyList[col].ComboList;
                    }

                    if (gridPropertyList[col].DataMap is object)
                    {
                        withBlock.DataMap = gridPropertyList[col].DataMap;
                    }

                    if (gridPropertyList[col].Editor is object)
                    {
                        withBlock.Editor = gridPropertyList[col].Editor;
                        withBlock.TextAlign = TextAlignEnum.LeftCenter;
                        if (gridPropertyList[col].Editor is NumberEx)
                        {
                            withBlock.TextAlign = TextAlignEnum.RightCenter;
                        }
                    }

                    if (gridPropertyList[col].DataType is object)
                    {
                        withBlock.DataType = gridPropertyList[col].DataType;
                    }

                    withBlock.AllowEditing = gridPropertyList[col].AllowEditing;
                    if (gridPropertyList[col].Visible == false)
                    {
                        withBlock.Visible = gridPropertyList[col].Visible;
                    }

                    // タイトル行 中央寄せ
                    withBlock.TextAlignFixed = TextAlignEnum.CenterCenter;
                }
            }
        }

        #endregion

        #region コントロール設定
        // カスタムエディタが既に設定されている場合、上書きされないため使用注意

        #region ボタン設定
        /// <summary>
        /// ボタン設定
        /// </summary>
        /// <param name="rg"></param>
        /// <param name="cellButtonType"></param>
        /// <param name="value"></param>
        public void setCellButton(CellRange rg, string cellButtonType, string value = "")
        {

            // スタイル生成(初期化)
            addInitStyle(rg);

            // 適用
            rg.Style.ComboList = cellButtonType;

            // 値設定
            this.SetData(rg, value);
        }

        public void setCellButton(int row, int col, string cellButtonType, string value = "")
        {

            // セル範囲のスタイル生成
            CellRange rg = this.GetCellRange(row, col);
            setCellButton(rg, cellButtonType, value);
        }

        public void setCellButton(int rowStr, int colStr, int rowEnd, int colEnd, string cellButtonType, string value = "")
        {

            // セル範囲のスタイル生成
            CellRange rg = this.GetCellRange(rowStr, colStr, rowEnd, colEnd);
            setCellButton(rg, cellButtonType, value);
        }

        public void setCellButton(int col, string cellButtonType, string value = "")
        {
            // ボタン設定 ※範囲
            this.setCellButton(this.Rows.Fixed, col, this.Rows.Count - 1, col, cellButtonType, value);
        }
        #endregion

        #region コンボボックス設定
        /// <summary>
        /// コンボボックス設定 ※セル
        /// </summary>
        /// <param name="rg"></param>
        /// <param name="data"></param>
        public void setComboBox(CellRange rg, IDictionary data)
        {

            // スタイル生成(初期化)
            addInitStyle(rg);

            // 適用
            rg.Style.DataMap = data;
        }

        public void setComboBox(int row, int col, IDictionary data)
        {

            // セル範囲のスタイル生成
            CellRange rg = this.GetCellRange(row, col);
            setComboBox(rg, data);
        }

        public void setComboBox(int rowStr, int colStr, int rowEnd, int colEnd, IDictionary data)
        {

            // セル範囲のスタイル生成
            CellRange rg = this.GetCellRange(rowStr, colStr, rowEnd, colEnd);
            setComboBox(rg, data);
        }

        public void setComboBox(int col, IDictionary data)
        {
            // コンボボックス設定 ※範囲
            this.setComboBox(this.Rows.Fixed, col, this.Rows.Count - 1, col, data);
        }
        #endregion

        #region チェックボックス設定
        /// <summary>
        /// チェックボックス設定
        /// </summary>
        /// <param name="rg"></param>
        /// <param name="check"></param>
        /// <param name="value"></param>
        public void setCheckBox(CellRange rg, CheckEnum check, string value = "")
        {

            // スタイル生成(初期化)
            addInitStyle(rg);

            // チェックボックス 初期値
            this.SetCellCheck(Row, Col, check);
            // ※DataType ( Boolean) で設定しない。(value が設定できないため) … SetCellCheck を使用

            // 値設定
            this.SetData(rg, value);

            // -----------------------------------
            // チェックボックスの位置を設定
            // -----------------------------------
            TextAlignEnum textAlignEnum = TextAlignEnum.CenterCenter;
            // セルテキストが指定されているか判定
            if (string.IsNullOrWhiteSpace(value) == false)
            {
                // 指定されている場合、□を左に配置
                textAlignEnum = TextAlignEnum.LeftCenter;
            }

            rg.Style.ImageAlign = (ImageAlignEnum)textAlignEnum;
        }

        public void setCheckBox(int row, int col, CheckEnum check, string value = "")
        {

            // セル範囲のスタイル生成
            CellRange rg = this.GetCellRange(row, col);
            setCheckBox(rg, check, value);
        }

        public void setCheckBox(int rowStr, int colStr, int rowEnd, int colEnd, CheckEnum check, string value = "")
        {

            // セル範囲のスタイル生成
            CellRange rg = this.GetCellRange(rowStr, colStr, rowEnd, colEnd);
            setCheckBox(rg, check, value);
        }

        public void setCheckBox(int col, CheckEnum check, string value = "")
        {
            // チェックボックス設定 ※範囲
            this.setCheckBox(this.Rows.Fixed, col, this.Rows.Count - 1, col, check, value);
        }
        #endregion

        #region カスタムエディタ型設定
        /// <summary>
        /// カスタムエディタ型設定
        /// </summary>
        /// <param name="rg"></param>
        /// <param name="editor"></param>
        public void setCustomEditor(CellRange rg, Control editor)
        {

            // スタイル生成(初期化)
            addInitStyle(rg);

            // 指定された範囲にコントロールに設定
            rg.Style.Editor = editor;
            TextAlignEnum textAlignEnum = TextAlignEnum.LeftCenter;
            if (editor is NumberEx)
            {
                // NumberEx の場合、右に配置
                textAlignEnum = TextAlignEnum.RightCenter;
            }

            rg.Style.TextAlign = textAlignEnum;
        }

        public void setCustomEditor(int row, int col, Control editor)
        {

            // セル範囲のスタイル生成
            CellRange rg = this.GetCellRange(row, col);
            setCustomEditor(rg, editor);
        }

        public void setCustomEditor(int rowStr, int colStr, int rowEnd, int colEnd, Control editor)
        {

            // セル範囲のスタイル生成
            CellRange rg = this.GetCellRange(rowStr, colStr, rowEnd, colEnd);
            setCustomEditor(rg, editor);
        }

        public void setCustomEditor(int col, Control editor)
        {
            // 範囲
            this.setCustomEditor(this.Rows.Fixed, col, this.Rows.Count - 1, col, editor);
        }
        #endregion

        #region スタイル生成(初期化)
        /// <summary>
        /// スタイル生成(初期化)
        /// </summary>
        /// <param name="rg"></param>
        private void addInitStyle(CellRange rg)
        {

            // スタイル生成
            rg.StyleNew.DataType = Type.GetType("System.Object");
            // スタイル要素を設定 (初期値)
            rg.Style.ComboList = null;
            rg.Style.DataMap = null;
            rg.Style.Editor = null;

            // 値クリア
            // Me.Clear(ClearFlags.Content, rg)
            // Me.Clear(ClearFlags.UserData, rg)
            // ↓　上記の場合、消えないので、下記にて回避する
            this.SetData(rg, string.Empty);
            for (int row = rg.r1, loopTo = rg.r2; row <= loopTo; row++)
            {
                for (int col = rg.c1, loopTo1 = rg.c2; col <= loopTo1; col++)
                {
                    this.SetUserData(row, col, default);
                    this.SetCellCheck(row, col, CheckEnum.None);
                }
            }
        }
        #endregion

        #endregion

        #region 色設定

        #region 色設定(必須)
        /// <summary>
        /// 色設定(必須)
        /// </summary>
        /// <param name="rowStr"></param>
        /// <param name="colStr"></param>
        public void setColorMust(int rowStr, int colStr)
        {
            // BackColor設定 (設定値を保存する)
            CellRange rg = this.GetCellRange(rowStr, colStr);
            this.setCellBackColor(rg, BackColorType.InputMust(), true);
        }

        public void setColorMust(int rowStr, int colStr, int rowEnd, int colEnd)
        {
            // 色設定 ※範囲 (設定値を保存する)
            CellRange rg = this.GetCellRange(rowStr, colStr, rowEnd, colEnd);
            this.setCellBackColor(rg, BackColorType.InputMust(), true);
        }

        public void setColorMust(int col)
        {
            // 色設定(必須) ※範囲
            this.setColorMust(this.Rows.Fixed, col, this.Rows.Count - 1, col);
        }
        #endregion

        #region 色設定(エラー)
        /// <summary>
        /// 色設定(エラー)
        /// </summary>
        /// <param name="rowStr"></param>
        /// <param name="colStr"></param>
        public void setColorError(int rowStr, int colStr)
        {
            // BackColor設定 (設定値を保存しない)
            CellRange rg = this.GetCellRange(rowStr, colStr);
            this.setCellBackColor(rg, BackColorType.InputError());
        }

        public void setColorError(int rowStr, int colStr, int rowEnd, int colEnd)
        {
            // 色設定 ※範囲 (設定値を保存しない)
            CellRange rg = this.GetCellRange(rowStr, colStr, rowEnd, colEnd);
            this.setCellBackColor(rg, BackColorType.InputError());
        }

        public void setColorError(int col)
        {
            // 色設定(エラー) ※範囲
            this.setColorError(this.Rows.Fixed, col, this.Rows.Count - 1, col);
        }
        #endregion

        #region 色設定(編集不可)
        /// <summary>
        /// 色設定(編集不可)
        /// </summary>
        /// <param name="rowStr"></param>
        /// <param name="colStr"></param>
        /// <param name="color"></param>
        public void setColorNonEdit(int rowStr, int colStr, Color color = default)
        {

            // 色指定がない場合、デフォルト色（グレー）  ※IsNothing(color) 判定は NG
            if (color == (default))
            {
                color = _colorControlLight;
            }

            // BackColor設定 (設定値を保存する)
            CellRange rg = this.GetCellRange(rowStr, colStr);
            setCellBackColor(rg, color, true);

            // 編集不可の背景色を編集不可リストに追加する
            addNonEditColor(color);
        }

        public void setColorNonEdit(int rowStr, int colStr, int rowEnd, int colEnd, Color color = default)
        {

            // 色指定がない場合、デフォルト色（グレー）  ※IsNothing(color) 判定は NG
            if (color == (default))
            {
                color = _colorControlLight;
            }

            // 色設定 ※範囲 (設定値を保存する)
            CellRange rg = this.GetCellRange(rowStr, colStr, rowEnd, colEnd);
            setCellBackColor(rg, color, true);

            // 編集不可の背景色を編集不可リストに追加する
            addNonEditColor(color);
        }

        public void setColorNonEdit(int col, Color color = default)
        {
            // 色設定(編集不可) ※範囲
            this.setColorNonEdit(this.Rows.Fixed, col, this.Rows.Count - 1, col, color);
        }
        #endregion

        #region 色設定(任意色)
        /// <summary>
        /// 色設定(編集不可)
        /// </summary>
        /// <param name="rowStr"></param>
        /// <param name="colStr"></param>
        /// <param name="color"></param>
        /// <param name="userDataSaveFlg">エラーセルクリア時、色を保持するか否かを設定(保持する場合、True。初期値はFalse (保持しない))</param>
        public void setSpecColor(int rowStr, int colStr, Color color, bool userDataSaveFlg = false)
        {
            // BackColor設定 (設定値を保存する)
            CellRange rg = this.GetCellRange(rowStr, colStr);
            setCellBackColor(rg, color, userDataSaveFlg);

            // 設定値を保存しない（True の場合、setCellBackColor にて設定済）
            if (userDataSaveFlg == false)
            {
                this.Clear(ClearFlags.UserData, rowStr, colStr);
            }
        }

        public void setSpecColor(int rowStr, int colStr, int rowEnd, int colEnd, Color color, bool userDataSaveFlg = false)
        {
            // 色設定 ※範囲 
            CellRange rg = this.GetCellRange(rowStr, colStr, rowEnd, colEnd);
            setCellBackColor(rg, color, userDataSaveFlg);

            // 設定値を保存しない（True の場合、setRangeBackColor にて設定済）
            if (userDataSaveFlg == false)
            {
                this.Clear(ClearFlags.UserData, rowStr, colStr, rowEnd, colEnd);
            }
        }

        public void setSpecColor(int col, Color color, bool userDataSaveFlg = false)
        {
            // 色設定(編集不可) ※範囲
            this.setSpecColor(this.Rows.Fixed, col, this.Rows.Count - 1, col, color, userDataSaveFlg);
        }
        #endregion

        #endregion

        #region 背景色クリア
        /// <summary>
        /// 背景色クリア ※セル
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        public void clearBackColor(int row, int col)
        {

            // Me.GetCellRange(row, col).Clear(StyleElementFlags.BackColor)
            // Me.GetCellRange(row, col).Clear(StyleElementFlags.UserData)

            CellRange rg = this.GetCellRange(row, col);
            this.setCellBackColor(rg, this.BackColor);

            // UserData クリア
            this.Clear(ClearFlags.UserData, row, col);
        }

        public void clearBackColor(int rowStr, int colStr, int rowEnd, int colEnd)
        {
            CellRange rg = this.GetCellRange(rowStr, colStr, rowEnd, colEnd);
            this.setCellBackColor(rg, this.BackColor);

            // UserData クリア
            for (int row = rg.r1, loopTo = rg.r2; row <= loopTo; row++)
            {
                for (int col = rg.c1, loopTo1 = rg.c2; col <= loopTo1; col++)
                    this.Clear(ClearFlags.UserData, row, col);
            }
        }

        public void clearBackColor(int col)
        {

            // 背景色クリア ※範囲
            this.clearBackColor(this.Rows.Fixed, col, this.Rows.Count - 1, col);
        }
        #endregion

        #region 必須入力チェック
        /// <summary>
        /// 必須入力チェック
        /// </summary>
        public bool checkInputMust()
        {
            bool ret = true;
            this.Redraw = false;

            // エラーセル背景色クリア
            clearErrorCell();

            // 背景色が "必須"(青色) の場合、未入力(未設定)項目の背景色を "エラー"(赤色) にする

            for (int row = this.Rows.Fixed, loopTo = this.Rows.Count - 1; row <= loopTo; row++)
            {
                for (int col = this.Cols.Fixed, loopTo1 = this.Cols.Count - 1; col <= loopTo1; col++)
                {

                    // 非表示列はスキップする
                    if (this.Cols[col].Visible == false)
                    {
                        continue;
                    }

                    // 背景色が "必須"(青色) 以外はスキップする
                    Color nowColor = this.GetCellRange(row, col).StyleDisplay.BackColor;
                    if (nowColor.Equals(BackColorType.InputMust()) == false)
                    {
                        continue;
                    }

                    // 未入力(未設定)の場合、項目の背景色を "エラー"(赤色) にする
                    if (isCellNullValue(row, col) == true)
                    {
                        CellRange rg = this.GetCellRange(row, col);
                        this.setCellBackColor(rg, BackColorType.InputError());
                        if (ret == true)
                        {
                            this.Select(row, col);
                        }

                        ret = false;
                    }
                }
            }

            this.Redraw = true;

            // 結果を返す (True:エラーなし / False:エラーあり)
            return ret;
        }
        #endregion

        #region エラーセル背景色クリア
        /// <summary>
        /// エラーセル背景色クリア
        /// </summary>
        public void clearErrorCell()
        {

            // 背景色を元に戻す

            for (int row = this.Rows.Fixed, loopTo = this.Rows.Count - 1; row <= loopTo; row++)
            {
                for (int col = this.Cols.Fixed, loopTo1 = this.Cols.Count - 1; col <= loopTo1; col++)
                {

                    // 背景色が "エラー"(赤色) 以外はスキップる
                    Color nowColor = this.GetCellRange(row, col).StyleDisplay.BackColor;
                    if (nowColor.Equals(BackColorType.InputError()) == false)
                    {
                        continue;
                    }

                    // 前回背景色を取得
                    Color bfrColor = (Color)this.GetUserData(row, col);
                    bool userDataSaveFlg = false;

                    // 前回背景色が取得できない場合（保持しない場合）、デフォルト値とする
                    if (bfrColor == (default))
                    {
                        bfrColor = this.BackColor;
                    }
                    else
                    {
                        userDataSaveFlg = true;
                    }

                    // 背景色を前回値に戻す
                    CellRange rg = this.GetCellRange(row, col);
                    setCellBackColor(rg, bfrColor, userDataSaveFlg);
                }
            }
        }
        #endregion

        #region データクリア (データのみ)
        /// <summary>
        /// データクリア (データのみ)
        /// </summary>
        public void clearDataOnly()
        {

            // Me.Clear(C1.Win.C1FlexGrid.ClearFlags.Content)
            // バインドされている場合、クリアされないため、セル毎にクリアする
            // ↓
            for (int row = this.Rows.Fixed, loopTo = this.Rows.Count - 1; row <= loopTo; row++)
            {
                for (int col = this.Cols.Fixed, loopTo1 = this.Cols.Count - 1; col <= loopTo1; col++)
                {
                    if (this.GetCellRange(row, col).Checkbox.Equals(CheckEnum.None))
                    {
                        // セルがチェックボックス 以外
                        this.SetData(row, col, default);
                    }
                    else
                    {
                        // セルがチェックボックス
                        this.SetCellCheck(row, col, CheckEnum.Unchecked);
                    }
                }
            }
        }
        #endregion

        #region データクリア (データ 及び 行)
        /// <summary>
        /// データクリア (データ 及び 行)
        /// </summary>
        public void clearDataAndRow()
        {

            // ---------------------------------------------
            // バインドされていない場合、行を削除する
            // ---------------------------------------------
            if (this.DataSource is null)
            {
                this.Rows.Count = this.Rows.Fixed;
                return;
            }
        }
        #endregion

        #region セルが空白か
        /// <summary>
        /// セルが空白か
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        public bool isCellNullValue(int row, int col)
        {
            string cellValue = string.Empty;
            if (isCellTypeDate(row, col) == true)
            {
                // 日付セル
                cellValue = getDateValueInt(row, col).ToString();
            }
            else if (isCellTypeTime(row, col) == true)
            {
                // 時間セル
                cellValue = getTimeValueInt(row, col).ToString();
            }
            else
            {
                // 上記以外のセル
                cellValue = this.GetData(row, col).ToString();
            }

            // 戻り値 (NULL の場合、True)
            return string.IsNullOrWhiteSpace(cellValue);
        }
        #endregion

        #region チェックボックス状態変更
        /// <summary>
        /// チェックボックス状態変更
        /// </summary>
        /// <param name="col"></param>
        /// <param name="checkEnum"></param>
        public void changeCheckBoxStatus(int col, CheckEnum checkEnum)
        {
            for (int row = this.Rows.Fixed, loopTo = this.Rows.Count - 1; row <= loopTo; row++)
            {

                // セルがチェックボックス 以外はスキップ
                if (this.GetCellRange(row, col).Checkbox.Equals(CheckEnum.None))
                {
                    continue;
                }

                this.SetCellCheck(row, col, checkEnum);
            }
        }
        #endregion

        #region 日付セルか (Editorに日付コントロールが設定されているセル)
        /// <summary>
        /// 日付セルか (Editorに日付コントロールが設定されているセル)
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        public bool isCellTypeDate(int row, int col)
        {
            return this.GetCellRange(row, col).StyleDisplay.Editor is DateEx;
        }
        #endregion

        #region 時刻セルか (Editorに時間コントロールが設定されているセル)
        /// <summary>
        /// 時刻セルか (Editorに時間コントロールが設定されているセル)
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        public bool isCellTypeTime(int row, int col)
        {
            return this.GetCellRange(row, col).StyleDisplay.Editor is Time24Ex;
        }
        #endregion

        #region チェックボックスセルか
        /// <summary>
        /// チェックボックスセルか
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        public bool isCellTypeCheckBox(int row, int col)
        {

            // Me.grd1.IsCellCheckBox(rowStr, colStr) 
            // 上記は正しく判定されない
            // ↓
            // None 以外は True。None は False
            return !this.GetCellCheck(row, col).Equals(CheckEnum.None);
        }

        #endregion

        #region 日付セル値(Integer)の取得
        /// <summary>
        /// 日付セル値(Integer)の取得
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        public int? getDateValueInt(int row, int col)
        {

            // ' Valueにセル値の値が正しく設定されていないため、直接参照はＮＧ (誤って使用しないようコメントを残す)
            // Dim dateValue As Date? = DirectCast(Me.GetCellRange(row, col).StyleDisplay.Editor, DateEx).Value
            // If dateValue Is Nothing Then
            // Return Nothing
            // Else
            // Return Integer.Parse(dateValue.Value.ToString("yyyyMMdd"))
            // End If
            // ↓
            // 以下で対応する
            string value = this.GetCellRange(row, col).Data.ToString();
            if (value is null || value.Length == 0)
            {
                return default;
            }

            if (Information.IsDate(value) == false)
            {
                return default;
            }

            return int.Parse(Convert.ToDateTime(value).ToString("yyyyMMdd"));  // Integer.Parse(value.Replace("/", ""))
        }
        #endregion

        #region 時刻セル値(Integer)の取得
        /// <summary>
        /// 時刻セル値(Integer)の取得
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        public int? getTimeValueInt(int row, int col)
        {

            // ' Valueにセル値の値が正しく設定されていないため、直接参照はＮＧ (誤って使用しないようコメントを残す)
            // Dim value As Integer? = DirectCast(Me.GetCellRange(row, col).StyleDisplay.Editor, Time24Ex).Value24Int
            // Return value
            // ↓
            // 以下で対応する
            string value = this.GetCellRange(row, col).Data.ToString();
            if (value is null || value.Length == 0)
            {
                return default;
                // 時間コントロールを使用し正しい値を取得する
            } ((Time24Ex)this.GetCellRange(row, col).StyleDisplay.Editor).Value24 = value;
            return ((Time24Ex)this.GetCellRange(row, col).StyleDisplay.Editor).Value24Int;
        }
        #endregion

        #region チェックボックスセル値(Boolean)の取得
        /// <summary>
        /// チェックボックスセル値(Boolean)の取得
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        public bool getCheckBoxValue(int row, int col)
        {
            // チェックON の場合 True。以外は False
            return this.GetCellCheck(row, col).Equals(CheckEnum.Checked);
        }
        #endregion

        #region 編集不可の背景色を編集不可リストに追加する
        /// <summary>
        /// 編集不可の背景色を編集不可リストに追加する
        /// </summary>
        /// <param name="color"></param>
        public void addNonEditColor(Color color)
        {

            // 存在する色がある場合、処理を抜ける
            if (NonEditColorList.Contains(color) == true)
            {
                return;
            }

            // 編集不可の背景色を追加
            NonEditColorList.Add(color);
        }
        #endregion

        #region 選択行を移動　(バインドしていない場合のみ使用可。※バインドしている場合、使用禁止)
        /// <summary>
        /// 選択行を移動
        /// </summary>
        /// <param name="nowRow">現在行</param>
        /// <param name="rowMove">up：上 down:下</param>
        public void moveRowData(int nowRow, RowMoveType rowMove)
        {

            // -------------------------------------------
            // バインドしている場合、使用禁止 (Grid仕様) ※別途、コード作成が必要
            // -------------------------------------------

            int fromRow = nowRow;
            int toRow;
            if (this.Row >= this.Rows.Fixed)
            {
                if (rowMove.Equals(RowMoveType.up))
                {
                    // 上に移動
                    toRow = fromRow - 1;
                    if (toRow < this.Rows.Fixed)
                    {
                        return;
                    }
                }
                else
                {
                    // 下に移動
                    toRow = fromRow + 1;
                    if (toRow >= this.Rows.Count)
                    {
                        return;
                    }
                }
                // 移動処理

                // バインドしている場合 NG (Grid仕様)
                // Me.Rows.Move(fromRow, toRow)
                // バインドしている場合 NG (Grid仕様)
                // Me.Rows.MoveRange(fromRow, 1, toRow)

            }
        }
        #endregion

        #region 内部メソッド

        #region 編集不可のセルか
        /// <summary>
        /// 編集不可のセルか (背景色：編集不可リストに存在する場合は編集不可)
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        private bool isCellNonEdit(int row, int col)
        {
            Color nowColor = this.GetCellRange(row, col).StyleDisplay.BackColor;

            // 存在する場合、True を返す
            return NonEditColorList.Contains(nowColor);
        }
        #endregion

        #region IMEMODE設定
        /// <summary>
        /// IMEMODE設定
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        private void setImeMode(int row, int col)
        {

            // IMEMODE設定
            if (this.GetCellRange(row, col).StyleDisplay.Editor is object)
            {
                this.ImeMode = this.GetCellRange(row, col).StyleDisplay.Editor.ImeMode;
            }
            else
            {
                this.ImeMode = ImeMode.Off;
            }
        }
        #endregion

        #region BackColor設定
        /// <summary>
        /// BackColor設定
        /// </summary>
        /// <param name="rg"></param>
        /// <param name="color"></param>
        /// <param name="userDataSaveFlg"></param>
        private void setCellBackColor(CellRange rg, Color color, bool userDataSaveFlg = false)
        {
            if (color == (default))
            {
                return;
            }

            // rg.StyleNew.BackColor = color
            // ↓ 範囲指定で設定すると 範囲が不正になる場合があるため個別に設定する
            // 背景色を設定
            for (int row = rg.r1, loopTo = rg.r2; row <= loopTo; row++)
            {
                for (int col = rg.c1, loopTo1 = rg.c2; col <= loopTo1; col++)
                {

                    // 非表示列はスキップする
                    if (this.Cols[col].Visible == false)
                    {
                        continue;
                    }

                    // 色設定
                    this.GetCellRange(row, col).StyleNew.BackColor = color;
                }
            }

            // UserData に背景色を対比
            if (userDataSaveFlg == true)
            {
                // 設定値を退避
                for (int row = rg.r1, loopTo2 = rg.r2; row <= loopTo2; row++)
                {
                    for (int col = rg.c1, loopTo3 = rg.c2; col <= loopTo3; col++)
                    {

                        // 非表示列はスキップする
                        if (this.Cols[col].Visible == false)
                        {
                            continue;
                        }

                        this.SetUserData(row, col, color);
                    }
                }
            }
            // False の場合、ここで、UserData をクリアしないこと (必須項目の保持もクリアされるため)

        }

        #endregion

        #endregion

        #endregion

    }

    #region グリッドのセルにコントロールを表示するクラス
    /// <summary>

    public partial class HostedControl
    {

        #region 変数

        /// <summary> 対象グリッド </summary>
        public C1.Win.C1FlexGrid.C1FlexGrid _flex;
        /// <summary> 対象コントロール </summary>
        public Control _ctl;
        /// <summary> 対象行 </summary>
        public C1.Win.C1FlexGrid.Row _row;
        /// <summary> 対象列 </summary>
        public C1.Win.C1FlexGrid.Column _col;

        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="flex">対象グリッド</param>
        /// <param name="control">コントロール</param>
        /// <param name="rowIndex">行番号</param>
        /// <param name="colIndex">列番号</param>
        public HostedControl(C1.Win.C1FlexGrid.C1FlexGrid flex, Control control, int rowIndex, int colIndex)
        {
            _flex = flex;
            _ctl = control;
            _row = flex.Rows[rowIndex];
            _col = flex.Cols[colIndex];
            _flex.Controls.Add(_ctl);
        }

        /// <summary>
        /// 対象コントロールを表示
        /// </summary>
        /// <returns></returns>
        public bool UpdatePosition()
        {
            int rowIndex = _row.Index;
            int colIndex = _col.Index;

            // TODO：今のところヘッダーにボタン配置することがないので、ヘッダーには配置しない形にする
            if (rowIndex < 0 || colIndex < 0)
            {
                return false;
            }

            // ヘッダ以外にデータがなければコントロールを表示しない
            if (_flex.Rows.Count <= 1)
            {
                _ctl.Visible = false;
                return true;
            }

            // セルの位置とサイズを取得
            Rectangle rectangle = _flex.GetCellRect(rowIndex, colIndex, false);
            // セルが表示されていない場合、表示するコントロールを非表示にする
            if (rectangle.Width <= 0 || rectangle.Height <= 0 || !rectangle.IntersectsWith(_flex.ClientRectangle))
            {
                _ctl.Visible = false;
                return true;
            }

            if (object.ReferenceEquals(_ctl.GetType(), typeof(RadioButtonEx)))
            {

                // セルの罫線位置までラジオボタンの配置するので、1ピクセルマイナスして罫線が表示されるようにする
                rectangle.Width = rectangle.Width - 1;
                rectangle.Height = rectangle.Height - 1;
            }

            _ctl.Bounds = rectangle;
            _ctl.Visible = true;
            return true;
        }
    }
    #endregion
    #endregion
}