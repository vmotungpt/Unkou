
using Unkou.Common;
using System.Windows.Forms;

namespace Unkou
{
	partial class S04_0101 : PT11
	{

		//フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		//Windows フォーム デザイナーで必要です。
		private System.ComponentModel.Container components = null;

		//メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
		//Windows フォーム デザイナーを使用して変更できます。
		//コード エディターを使って変更しないでください。
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			GrapeCity.Win.Editors.Fields.DateHourDisplayField DateHourDisplayField1 = new GrapeCity.Win.Editors.Fields.DateHourDisplayField();
			GrapeCity.Win.Editors.Fields.DateLiteralDisplayField DateLiteralDisplayField1 = new GrapeCity.Win.Editors.Fields.DateLiteralDisplayField();
			GrapeCity.Win.Editors.Fields.DateMinuteDisplayField DateMinuteDisplayField1 = new GrapeCity.Win.Editors.Fields.DateMinuteDisplayField();
			GrapeCity.Win.Editors.Fields.DateHourField DateHourField1 = new GrapeCity.Win.Editors.Fields.DateHourField();
			GrapeCity.Win.Editors.Fields.DateLiteralField DateLiteralField1 = new GrapeCity.Win.Editors.Fields.DateLiteralField();
			GrapeCity.Win.Editors.Fields.DateMinuteField DateMinuteField1 = new GrapeCity.Win.Editors.Fields.DateMinuteField();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(S04_0101));
			this.gbxCondition = new Hatobus.ReservationManagementSystem.ClientCommon.GroupBoxEx();
			this.chkNightLine = new Hatobus.ReservationManagementSystem.ClientCommon.CheckBoxEx();
			this.btnClear = new Hatobus.ReservationManagementSystem.ClientCommon.ButtonEx();
			this.chk2StayMore = new Hatobus.ReservationManagementSystem.ClientCommon.CheckBoxEx();
			this.chkBoat = new Hatobus.ReservationManagementSystem.ClientCommon.CheckBoxEx();
			this.lblCrsCd2 = new Hatobus.ReservationManagementSystem.ClientCommon.LabelEx();
			this.ucoCrsCd = new Hatobus.ReservationManagementSystem.Master.CodeControlEx();
			this.lblSyuptTime = new Hatobus.ReservationManagementSystem.ClientCommon.LabelEx();
			this.dtmSyuptTime = new Hatobus.ReservationManagementSystem.ClientCommon.TimeEx();
			this.chkJapanese = new Hatobus.ReservationManagementSystem.ClientCommon.CheckBoxEx();
			this.chkGaikokugo = new Hatobus.ReservationManagementSystem.ClientCommon.CheckBoxEx();
			this.lblCrsKind = new Hatobus.ReservationManagementSystem.ClientCommon.LabelEx();
			this.lblJyosyaTi = new Hatobus.ReservationManagementSystem.ClientCommon.LabelEx();
			this.ucoJyosyaTiCd = new Hatobus.ReservationManagementSystem.Master.CodeControlEx();
			this.txtGousya = new Hatobus.ReservationManagementSystem.ClientCommon.TextBoxEx();
			this.LabelEx2 = new Hatobus.ReservationManagementSystem.ClientCommon.LabelEx();
			this.chkKikakuStay = new Hatobus.ReservationManagementSystem.ClientCommon.CheckBoxEx();
			this.chkKikakuDayTrip = new Hatobus.ReservationManagementSystem.ClientCommon.CheckBoxEx();
			this.chkRCrs = new Hatobus.ReservationManagementSystem.ClientCommon.CheckBoxEx();
			this.chkTeikiNight = new Hatobus.ReservationManagementSystem.ClientCommon.CheckBoxEx();
			this.chkTeikiNoon = new Hatobus.ReservationManagementSystem.ClientCommon.CheckBoxEx();
			this.lblCrsKbn = new Hatobus.ReservationManagementSystem.ClientCommon.LabelEx();
			this.lblSyuptDay = new Hatobus.ReservationManagementSystem.ClientCommon.LabelEx();
			this.dtmSyuptDayFromTo = new Hatobus.ReservationManagementSystem.ClientCommon.FromToDateEx();
			this.btnSearch = new Hatobus.ReservationManagementSystem.ClientCommon.ButtonEx();
			this.btnVisiblerCondition = new Hatobus.ReservationManagementSystem.ClientCommon.ButtonEx();
			this.LabelEx1 = new Hatobus.ReservationManagementSystem.ClientCommon.LabelEx();
			this.PanelEx1 = new Hatobus.ReservationManagementSystem.ClientCommon.PanelEx();
			this.grdRiyouJininKakuteiRev = new Hatobus.ReservationManagementSystem.ClientCommon.FlexGridEx();
			this.lblLengthGrd = new Hatobus.ReservationManagementSystem.ClientCommon.LabelEx();
			this.GcShortcut1 = new GrapeCity.Win.Editors.GcShortcut(this.components);
			((System.ComponentModel.ISupportInitialize)this.SearchResultGridData).BeginInit();
			this.pnlBaseFill.SuspendLayout();
			this.gbxCondition.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dtmSyuptTime).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.txtGousya).BeginInit();
			this.PanelEx1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.grdRiyouJininKakuteiRev).BeginInit();
			this.SuspendLayout();
			//
			//pnlBaseFill
			//
			this.pnlBaseFill.Controls.Add(this.PanelEx1);
			this.pnlBaseFill.Controls.Add(this.LabelEx1);
			this.pnlBaseFill.Controls.Add(this.btnVisiblerCondition);
			this.pnlBaseFill.Controls.Add(this.gbxCondition);
			this.pnlBaseFill.Size = new System.Drawing.Size(1264, 756);
			//
			//gbxCondition
			//
			this.gbxCondition.AutoSize = true;
			this.gbxCondition.Controls.Add(this.chkNightLine);
			this.gbxCondition.Controls.Add(this.btnClear);
			this.gbxCondition.Controls.Add(this.chk2StayMore);
			this.gbxCondition.Controls.Add(this.chkBoat);
			this.gbxCondition.Controls.Add(this.lblCrsCd2);
			this.gbxCondition.Controls.Add(this.ucoCrsCd);
			this.gbxCondition.Controls.Add(this.lblSyuptTime);
			this.gbxCondition.Controls.Add(this.dtmSyuptTime);
			this.gbxCondition.Controls.Add(this.chkJapanese);
			this.gbxCondition.Controls.Add(this.chkGaikokugo);
			this.gbxCondition.Controls.Add(this.lblCrsKind);
			this.gbxCondition.Controls.Add(this.lblJyosyaTi);
			this.gbxCondition.Controls.Add(this.ucoJyosyaTiCd);
			this.gbxCondition.Controls.Add(this.txtGousya);
			this.gbxCondition.Controls.Add(this.LabelEx2);
			this.gbxCondition.Controls.Add(this.chkKikakuStay);
			this.gbxCondition.Controls.Add(this.chkKikakuDayTrip);
			this.gbxCondition.Controls.Add(this.chkRCrs);
			this.gbxCondition.Controls.Add(this.chkTeikiNight);
			this.gbxCondition.Controls.Add(this.chkTeikiNoon);
			this.gbxCondition.Controls.Add(this.lblCrsKbn);
			this.gbxCondition.Controls.Add(this.lblSyuptDay);
			this.gbxCondition.Controls.Add(this.dtmSyuptDayFromTo);
			this.gbxCondition.Controls.Add(this.btnSearch);
			this.gbxCondition.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.gbxCondition.Location = new System.Drawing.Point(8, 41);
			this.gbxCondition.Name = "gbxCondition";
			this.gbxCondition.Size = new System.Drawing.Size(1248, 150);
			this.gbxCondition.TabIndex = 2;
			this.gbxCondition.TabStop = false;
			//
			//chkNightLine
			//
			this.chkNightLine.AutoSize = true;
			this.chkNightLine.BackColor = System.Drawing.Color.Transparent;
			this.chkNightLine.ExistError = false;
			this.chkNightLine.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.chkNightLine.ForeColor = System.Drawing.Color.Black;
			this.chkNightLine.GuideMessage = "";
			this.chkNightLine.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("chkNightLine.GuideMessageDetail"));
			this.chkNightLine.Location = new System.Drawing.Point(752, 74);
			this.chkNightLine.Name = "chkNightLine";
			this.chkNightLine.NotNull = false;
			this.chkNightLine.Size = new System.Drawing.Size(58, 19);
			this.chkNightLine.TabIndex = 21;
			this.chkNightLine.Text = "夜行";
			this.chkNightLine.UseVisualStyleBackColor = true;
			//
			//btnClear
			//
			this.btnClear.AutoSize = true;
			this.btnClear.BackColor = System.Drawing.Color.Transparent;
			this.btnClear.BtnEventId = Hatobus.ReservationManagementSystem.ClientCommon.ClientConstantCode.BtnKeyId.CLEAR;
			this.btnClear.ExistError = false;
			this.btnClear.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.btnClear.ForeColor = System.Drawing.Color.Black;
			this.btnClear.GuideMessage = "";
			this.btnClear.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("btnClear.GuideMessageDetail"));
			this.btnClear.Location = new System.Drawing.Point(1031, 99);
			this.btnClear.Name = "btnClear";
			this.btnClear.NotNull = false;
			this.btnClear.Size = new System.Drawing.Size(97, 30);
			this.btnClear.TabIndex = 25;
			this.btnClear.Text = "条件クリア";
			this.btnClear.UseVisualStyleBackColor = true;
			//
			//chk2StayMore
			//
			this.chk2StayMore.AutoSize = true;
			this.chk2StayMore.BackColor = System.Drawing.Color.Transparent;
			this.chk2StayMore.ExistError = false;
			this.chk2StayMore.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.chk2StayMore.ForeColor = System.Drawing.Color.Black;
			this.chk2StayMore.GuideMessage = "";
			this.chk2StayMore.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("chk2StayMore.GuideMessageDetail"));
			this.chk2StayMore.Location = new System.Drawing.Point(880, 74);
			this.chk2StayMore.Name = "chk2StayMore";
			this.chk2StayMore.NotNull = false;
			this.chk2StayMore.Size = new System.Drawing.Size(90, 19);
			this.chk2StayMore.TabIndex = 23;
			this.chk2StayMore.Text = "２泊以上";
			this.chk2StayMore.UseVisualStyleBackColor = true;
			//
			//chkBoat
			//
			this.chkBoat.AutoSize = true;
			this.chkBoat.BackColor = System.Drawing.Color.Transparent;
			this.chkBoat.ExistError = false;
			this.chkBoat.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.chkBoat.ForeColor = System.Drawing.Color.Black;
			this.chkBoat.GuideMessage = "";
			this.chkBoat.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("chkBoat.GuideMessageDetail"));
			this.chkBoat.Location = new System.Drawing.Point(816, 74);
			this.chkBoat.Name = "chkBoat";
			this.chkBoat.NotNull = false;
			this.chkBoat.Size = new System.Drawing.Size(58, 19);
			this.chkBoat.TabIndex = 22;
			this.chkBoat.Text = "船舶";
			this.chkBoat.UseVisualStyleBackColor = true;
			//
			//lblCrsCd2
			//
			this.lblCrsCd2.AutoSize = true;
			this.lblCrsCd2.ExistError = false;
			this.lblCrsCd2.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.lblCrsCd2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCrsCd2.GuideMessage = "";
			this.lblCrsCd2.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("lblCrsCd2.GuideMessageDetail"));
			this.lblCrsCd2.Location = new System.Drawing.Point(361, 43);
			this.lblCrsCd2.Margin = new System.Windows.Forms.Padding(18, 3, 3, 3);
			this.lblCrsCd2.Name = "lblCrsCd2";
			this.lblCrsCd2.NotNull = false;
			this.lblCrsCd2.Size = new System.Drawing.Size(103, 15);
			this.lblCrsCd2.TabIndex = 10;
			this.lblCrsCd2.Text = "コースコード";
			//
			//ucoCrsCd
			//
			this.ucoCrsCd.CharLength = 20;
			this.ucoCrsCd.CodeFormat = Hatobus.ReservationManagementSystem.Master.CodeControlEx.CodeFormatEnum.COURSE_CD;
			this.ucoCrsCd.CodeNotNull = false;
			this.ucoCrsCd.CodeText = "";
			this.ucoCrsCd.CodeType = Hatobus.ReservationManagementSystem.Master.CodeControlEx.CodeTypeEnum.COURSE_CD;
			this.ucoCrsCd.CompanyCodeText = "";
			this.ucoCrsCd.ExistError = false;
			this.ucoCrsCd.IsManualLenMode = true;
			this.ucoCrsCd.Location = new System.Drawing.Point(469, 40);
			this.ucoCrsCd.Margin = new System.Windows.Forms.Padding(2);
			this.ucoCrsCd.MasterTable = null;
			this.ucoCrsCd.Name = "ucoCrsCd";
			this.ucoCrsCd.Param1 = null;
			this.ucoCrsCd.Param2 = null;
			this.ucoCrsCd.Param3 = null;
			this.ucoCrsCd.Param4 = null;
			this.ucoCrsCd.Param5 = null;
			this.ucoCrsCd.Param6 = null;
			this.ucoCrsCd.Size = new System.Drawing.Size(472, 26);
			this.ucoCrsCd.TabIndex = 11;
			this.ucoCrsCd.ValueText = "";
			//
			//lblSyuptTime
			//
			this.lblSyuptTime.AutoSize = true;
			this.lblSyuptTime.ExistError = false;
			this.lblSyuptTime.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.lblSyuptTime.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblSyuptTime.GuideMessage = "";
			this.lblSyuptTime.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("lblSyuptTime.GuideMessageDetail"));
			this.lblSyuptTime.Location = new System.Drawing.Point(11, 75);
			this.lblSyuptTime.Margin = new System.Windows.Forms.Padding(3);
			this.lblSyuptTime.Name = "lblSyuptTime";
			this.lblSyuptTime.NotNull = false;
			this.lblSyuptTime.Size = new System.Drawing.Size(71, 15);
			this.lblSyuptTime.TabIndex = 14;
			this.lblSyuptTime.Text = "出発時間";
			//
			//dtmSyuptTime
			//
			this.dtmSyuptTime.AutoSize = true;
			DateHourDisplayField1.ShowLeadingZero = true;
			DateLiteralDisplayField1.Text = ":";
			DateMinuteDisplayField1.ShowLeadingZero = true;
			this.dtmSyuptTime.DisplayFields.AddRange(new GrapeCity.Win.Editors.Fields.DateDisplayField[] { DateHourDisplayField1, DateLiteralDisplayField1, DateMinuteDisplayField1 });
			this.dtmSyuptTime.ExistError = false;
			DateLiteralField1.Text = ":";
			this.dtmSyuptTime.Fields.AddRange(new GrapeCity.Win.Editors.Fields.DateField[] { DateHourField1, DateLiteralField1, DateMinuteField1 });
			this.dtmSyuptTime.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.dtmSyuptTime.GuideMessage = "";
			this.dtmSyuptTime.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("dtmSyuptTime.GuideMessageDetail"));
			this.dtmSyuptTime.HighlightText = GrapeCity.Win.Editors.HighlightText.All;
			this.dtmSyuptTime.Location = new System.Drawing.Point(88, 72);
			this.dtmSyuptTime.Name = "dtmSyuptTime";
			this.dtmSyuptTime.NotNull = false;
			this.dtmSyuptTime.Size = new System.Drawing.Size(54, 21);
			this.dtmSyuptTime.TabIndex = 15;
			this.dtmSyuptTime.Value = null;
			//
			//chkJapanese
			//
			this.chkJapanese.AutoSize = true;
			this.chkJapanese.BackColor = System.Drawing.Color.Transparent;
			this.chkJapanese.ExistError = false;
			this.chkJapanese.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.chkJapanese.ForeColor = System.Drawing.Color.Black;
			this.chkJapanese.GuideMessage = "";
			this.chkJapanese.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("chkJapanese.GuideMessageDetail"));
			this.chkJapanese.Location = new System.Drawing.Point(672, 12);
			this.chkJapanese.Name = "chkJapanese";
			this.chkJapanese.NotNull = false;
			this.chkJapanese.Size = new System.Drawing.Size(74, 19);
			this.chkJapanese.TabIndex = 6;
			this.chkJapanese.Text = "日本語";
			this.chkJapanese.UseVisualStyleBackColor = true;
			//
			//chkGaikokugo
			//
			this.chkGaikokugo.AutoSize = true;
			this.chkGaikokugo.BackColor = System.Drawing.Color.Transparent;
			this.chkGaikokugo.ExistError = false;
			this.chkGaikokugo.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.chkGaikokugo.ForeColor = System.Drawing.Color.Black;
			this.chkGaikokugo.GuideMessage = "";
			this.chkGaikokugo.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("chkGaikokugo.GuideMessageDetail"));
			this.chkGaikokugo.Location = new System.Drawing.Point(752, 13);
			this.chkGaikokugo.Name = "chkGaikokugo";
			this.chkGaikokugo.NotNull = false;
			this.chkGaikokugo.Size = new System.Drawing.Size(74, 19);
			this.chkGaikokugo.TabIndex = 7;
			this.chkGaikokugo.Text = "外国語";
			this.chkGaikokugo.UseVisualStyleBackColor = true;
			//
			//lblCrsKind
			//
			this.lblCrsKind.AutoSize = true;
			this.lblCrsKind.ExistError = false;
			this.lblCrsKind.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.lblCrsKind.ForeColor = System.Drawing.Color.Red;
			this.lblCrsKind.GuideMessage = "";
			this.lblCrsKind.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("lblCrsKind.GuideMessageDetail"));
			this.lblCrsKind.Location = new System.Drawing.Point(579, 14);
			this.lblCrsKind.Margin = new System.Windows.Forms.Padding(18, 3, 3, 3);
			this.lblCrsKind.Name = "lblCrsKind";
			this.lblCrsKind.NotNull = true;
			this.lblCrsKind.Size = new System.Drawing.Size(87, 15);
			this.lblCrsKind.TabIndex = 5;
			this.lblCrsKind.Text = "コース種別";
			this.lblCrsKind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//lblJyosyaTi
			//
			this.lblJyosyaTi.AutoSize = true;
			this.lblJyosyaTi.ExistError = false;
			this.lblJyosyaTi.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.lblJyosyaTi.ForeColor = System.Drawing.Color.Red;
			this.lblJyosyaTi.GuideMessage = "";
			this.lblJyosyaTi.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("lblJyosyaTi.GuideMessageDetail"));
			this.lblJyosyaTi.Location = new System.Drawing.Point(27, 14);
			this.lblJyosyaTi.Margin = new System.Windows.Forms.Padding(3);
			this.lblJyosyaTi.Name = "lblJyosyaTi";
			this.lblJyosyaTi.NotNull = true;
			this.lblJyosyaTi.Size = new System.Drawing.Size(55, 15);
			this.lblJyosyaTi.TabIndex = 3;
			this.lblJyosyaTi.Text = "乗車地";
			//
			//ucoJyosyaTiCd
			//
			this.ucoJyosyaTiCd.CharLength = 22;
			this.ucoJyosyaTiCd.CodeFormat = Hatobus.ReservationManagementSystem.Master.CodeControlEx.CodeFormatEnum.COURSE_CD;
			this.ucoJyosyaTiCd.CodeNotNull = true;
			this.ucoJyosyaTiCd.CodeText = "";
			this.ucoJyosyaTiCd.CodeType = Hatobus.ReservationManagementSystem.Master.CodeControlEx.CodeTypeEnum.PLACE_CD;
			this.ucoJyosyaTiCd.CompanyCodeText = "";
			this.ucoJyosyaTiCd.ExistError = false;
			this.ucoJyosyaTiCd.IsManualLenMode = true;
			this.ucoJyosyaTiCd.Location = new System.Drawing.Point(87, 10);
			this.ucoJyosyaTiCd.Margin = new System.Windows.Forms.Padding(2);
			this.ucoJyosyaTiCd.MasterTable = null;
			this.ucoJyosyaTiCd.Name = "ucoJyosyaTiCd";
			this.ucoJyosyaTiCd.Param1 = null;
			this.ucoJyosyaTiCd.Param2 = null;
			this.ucoJyosyaTiCd.Param3 = null;
			this.ucoJyosyaTiCd.Param4 = null;
			this.ucoJyosyaTiCd.Param5 = null;
			this.ucoJyosyaTiCd.Param6 = null;
			this.ucoJyosyaTiCd.Size = new System.Drawing.Size(472, 26);
			this.ucoJyosyaTiCd.TabIndex = 4;
			this.ucoJyosyaTiCd.ValueText = "";
			//
			//txtGousya
			//
			this.txtGousya.AutoSize = true;
			this.txtGousya.CharLength = 4;
			this.txtGousya.ContentAlignment = System.Drawing.ContentAlignment.MiddleRight;
			this.txtGousya.DropDown.AllowDrop = false;
			this.txtGousya.ExistError = false;
			this.txtGousya.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.txtGousya.Format = "9";
			this.txtGousya.GuideMessage = "";
			this.txtGousya.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("txtGousya.GuideMessageDetail"));
			this.txtGousya.HighlightText = true;
			this.txtGousya.LineFeedProcessing = false;
			this.txtGousya.Location = new System.Drawing.Point(1006, 41);
			this.txtGousya.MaxLength = 4;
			this.txtGousya.Name = "txtGousya";
			this.txtGousya.NotNull = false;
			this.txtGousya.Size = new System.Drawing.Size(39, 21);
			this.txtGousya.SJISOnly = false;
			this.txtGousya.TabIndex = 13;
			this.txtGousya.TextInputMode = Hatobus.ReservationManagementSystem.ClientCommon.TextBoxEx.InputMode.Half;
			//
			//LabelEx2
			//
			this.LabelEx2.AutoSize = true;
			this.LabelEx2.ExistError = false;
			this.LabelEx2.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.LabelEx2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.LabelEx2.GuideMessage = "";
			this.LabelEx2.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("LabelEx2.GuideMessageDetail"));
			this.LabelEx2.Location = new System.Drawing.Point(961, 43);
			this.LabelEx2.Margin = new System.Windows.Forms.Padding(18, 3, 3, 3);
			this.LabelEx2.Name = "LabelEx2";
			this.LabelEx2.NotNull = false;
			this.LabelEx2.Size = new System.Drawing.Size(39, 15);
			this.LabelEx2.TabIndex = 12;
			this.LabelEx2.Text = "号車";
			//
			//chkKikakuStay
			//
			this.chkKikakuStay.AutoSize = true;
			this.chkKikakuStay.BackColor = System.Drawing.Color.Transparent;
			this.chkKikakuStay.ExistError = false;
			this.chkKikakuStay.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.chkKikakuStay.ForeColor = System.Drawing.Color.Black;
			this.chkKikakuStay.GuideMessage = "";
			this.chkKikakuStay.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("chkKikakuStay.GuideMessageDetail"));
			this.chkKikakuStay.Location = new System.Drawing.Point(624, 74);
			this.chkKikakuStay.Name = "chkKikakuStay";
			this.chkKikakuStay.NotNull = false;
			this.chkKikakuStay.Size = new System.Drawing.Size(122, 19);
			this.chkKikakuStay.TabIndex = 20;
			this.chkKikakuStay.Text = "企画（宿泊）";
			this.chkKikakuStay.UseVisualStyleBackColor = true;
			//
			//chkKikakuDayTrip
			//
			this.chkKikakuDayTrip.AutoSize = true;
			this.chkKikakuDayTrip.BackColor = System.Drawing.Color.Transparent;
			this.chkKikakuDayTrip.ExistError = false;
			this.chkKikakuDayTrip.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.chkKikakuDayTrip.ForeColor = System.Drawing.Color.Black;
			this.chkKikakuDayTrip.GuideMessage = "";
			this.chkKikakuDayTrip.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("chkKikakuDayTrip.GuideMessageDetail"));
			this.chkKikakuDayTrip.Location = new System.Drawing.Point(480, 74);
			this.chkKikakuDayTrip.Name = "chkKikakuDayTrip";
			this.chkKikakuDayTrip.NotNull = false;
			this.chkKikakuDayTrip.Size = new System.Drawing.Size(138, 19);
			this.chkKikakuDayTrip.TabIndex = 19;
			this.chkKikakuDayTrip.Text = "企画（日帰り）";
			this.chkKikakuDayTrip.UseVisualStyleBackColor = true;
			//
			//chkRCrs
			//
			this.chkRCrs.AutoSize = true;
			this.chkRCrs.BackColor = System.Drawing.Color.Transparent;
			this.chkRCrs.ExistError = false;
			this.chkRCrs.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.chkRCrs.ForeColor = System.Drawing.Color.Black;
			this.chkRCrs.GuideMessage = "";
			this.chkRCrs.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("chkRCrs.GuideMessageDetail"));
			this.chkRCrs.Location = new System.Drawing.Point(976, 74);
			this.chkRCrs.Name = "chkRCrs";
			this.chkRCrs.NotNull = false;
			this.chkRCrs.Size = new System.Drawing.Size(90, 19);
			this.chkRCrs.TabIndex = 24;
			this.chkRCrs.Text = "Ｒコース";
			this.chkRCrs.UseVisualStyleBackColor = true;
			//
			//chkTeikiNight
			//
			this.chkTeikiNight.AutoSize = true;
			this.chkTeikiNight.BackColor = System.Drawing.Color.Transparent;
			this.chkTeikiNight.ExistError = false;
			this.chkTeikiNight.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.chkTeikiNight.ForeColor = System.Drawing.Color.Black;
			this.chkTeikiNight.GuideMessage = "";
			this.chkTeikiNight.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("chkTeikiNight.GuideMessageDetail"));
			this.chkTeikiNight.Location = new System.Drawing.Point(368, 74);
			this.chkTeikiNight.Name = "chkTeikiNight";
			this.chkTeikiNight.NotNull = false;
			this.chkTeikiNight.Size = new System.Drawing.Size(106, 19);
			this.chkTeikiNight.TabIndex = 18;
			this.chkTeikiNight.Text = "定期（夜）";
			this.chkTeikiNight.UseVisualStyleBackColor = true;
			//
			//chkTeikiNoon
			//
			this.chkTeikiNoon.AutoSize = true;
			this.chkTeikiNoon.BackColor = System.Drawing.Color.Transparent;
			this.chkTeikiNoon.ExistError = false;
			this.chkTeikiNoon.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.chkTeikiNoon.ForeColor = System.Drawing.Color.Black;
			this.chkTeikiNoon.GuideMessage = "";
			this.chkTeikiNoon.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("chkTeikiNoon.GuideMessageDetail"));
			this.chkTeikiNoon.Location = new System.Drawing.Point(256, 74);
			this.chkTeikiNoon.Name = "chkTeikiNoon";
			this.chkTeikiNoon.NotNull = false;
			this.chkTeikiNoon.Size = new System.Drawing.Size(106, 19);
			this.chkTeikiNoon.TabIndex = 17;
			this.chkTeikiNoon.Text = "定期（昼）";
			this.chkTeikiNoon.UseVisualStyleBackColor = true;
			//
			//lblCrsKbn
			//
			this.lblCrsKbn.AutoSize = true;
			this.lblCrsKbn.ExistError = false;
			this.lblCrsKbn.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.lblCrsKbn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCrsKbn.GuideMessage = "";
			this.lblCrsKbn.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("lblCrsKbn.GuideMessageDetail"));
			this.lblCrsKbn.Location = new System.Drawing.Point(163, 75);
			this.lblCrsKbn.Margin = new System.Windows.Forms.Padding(18, 3, 3, 3);
			this.lblCrsKbn.Name = "lblCrsKbn";
			this.lblCrsKbn.NotNull = false;
			this.lblCrsKbn.Size = new System.Drawing.Size(87, 15);
			this.lblCrsKbn.TabIndex = 16;
			this.lblCrsKbn.Text = "コース区分";
			//
			//lblSyuptDay
			//
			this.lblSyuptDay.AutoSize = true;
			this.lblSyuptDay.ExistError = false;
			this.lblSyuptDay.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.lblSyuptDay.ForeColor = System.Drawing.Color.Red;
			this.lblSyuptDay.GuideMessage = "";
			this.lblSyuptDay.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("lblSyuptDay.GuideMessageDetail"));
			this.lblSyuptDay.Location = new System.Drawing.Point(27, 43);
			this.lblSyuptDay.Margin = new System.Windows.Forms.Padding(3);
			this.lblSyuptDay.Name = "lblSyuptDay";
			this.lblSyuptDay.NotNull = true;
			this.lblSyuptDay.Size = new System.Drawing.Size(55, 15);
			this.lblSyuptDay.TabIndex = 8;
			this.lblSyuptDay.Text = "出発日";
			//
			//dtmSyuptDayFromTo
			//
			this.dtmSyuptDayFromTo.ExistErrorForFromDate = false;
			this.dtmSyuptDayFromTo.ExistErrorForToDate = false;
			this.dtmSyuptDayFromTo.FromDateText = null;
			this.dtmSyuptDayFromTo.Location = new System.Drawing.Point(87, 41);
			this.dtmSyuptDayFromTo.Name = "dtmSyuptDayFromTo";
			this.dtmSyuptDayFromTo.NotNullForFromDate = true;
			this.dtmSyuptDayFromTo.NotNullForFromOrToDate = false;
			this.dtmSyuptDayFromTo.NotNullForToDate = true;
			this.dtmSyuptDayFromTo.ReadOnlyNonTabStop = false;
			this.dtmSyuptDayFromTo.Size = new System.Drawing.Size(253, 27);
			this.dtmSyuptDayFromTo.TabIndex = 9;
			this.dtmSyuptDayFromTo.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.dtmSyuptDayFromTo.TextType = Hatobus.ReservationManagementSystem.ClientCommon.FromToDateEx.DateType.YYMMDD;
			this.dtmSyuptDayFromTo.ToDateText = null;
			//
			//btnSearch
			//
			this.btnSearch.AutoSize = true;
			this.btnSearch.BackColor = System.Drawing.Color.Transparent;
			this.btnSearch.BtnEventId = Hatobus.ReservationManagementSystem.ClientCommon.ClientConstantCode.BtnKeyId.F8;
			this.btnSearch.ExistError = false;
			this.btnSearch.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.btnSearch.ForeColor = System.Drawing.Color.Black;
			this.btnSearch.GuideMessage = "";
			this.btnSearch.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("btnSearch.GuideMessageDetail"));
			this.btnSearch.Location = new System.Drawing.Point(1134, 99);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.NotNull = false;
			this.btnSearch.Size = new System.Drawing.Size(97, 30);
			this.btnSearch.TabIndex = 26;
			this.btnSearch.Text = "F8:検索";
			this.btnSearch.UseVisualStyleBackColor = true;
			//
			//btnVisiblerCondition
			//
			this.btnVisiblerCondition.AutoSize = true;
			this.btnVisiblerCondition.BackColor = System.Drawing.Color.Transparent;
			this.btnVisiblerCondition.BtnEventId = Hatobus.ReservationManagementSystem.ClientCommon.ClientConstantCode.BtnKeyId.Null;
			this.btnVisiblerCondition.ExistError = false;
			this.btnVisiblerCondition.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.btnVisiblerCondition.ForeColor = System.Drawing.Color.Black;
			this.btnVisiblerCondition.GuideMessage = "";
			this.btnVisiblerCondition.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("btnVisiblerCondition.GuideMessageDetail"));
			this.btnVisiblerCondition.Location = new System.Drawing.Point(82, 6);
			this.btnVisiblerCondition.Name = "btnVisiblerCondition";
			this.btnVisiblerCondition.NotNull = false;
			this.btnVisiblerCondition.Size = new System.Drawing.Size(89, 25);
			this.btnVisiblerCondition.TabIndex = 1;
			this.btnVisiblerCondition.Text = "非表示 <<";
			this.btnVisiblerCondition.UseVisualStyleBackColor = true;
			//
			//LabelEx1
			//
			this.LabelEx1.AutoSize = true;
			this.LabelEx1.ExistError = false;
			this.LabelEx1.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.LabelEx1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.LabelEx1.GuideMessage = "";
			this.LabelEx1.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("LabelEx1.GuideMessageDetail"));
			this.LabelEx1.Location = new System.Drawing.Point(5, 11);
			this.LabelEx1.Margin = new System.Windows.Forms.Padding(3);
			this.LabelEx1.Name = "LabelEx1";
			this.LabelEx1.NotNull = false;
			this.LabelEx1.Size = new System.Drawing.Size(71, 15);
			this.LabelEx1.TabIndex = 0;
			this.LabelEx1.Text = "検索項目";
			//
			//PanelEx1
			//
			this.PanelEx1.AutoSize = true;
			this.PanelEx1.Controls.Add(this.grdRiyouJininKakuteiRev);
			this.PanelEx1.Controls.Add(this.lblLengthGrd);
			this.PanelEx1.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.PanelEx1.Location = new System.Drawing.Point(8, 197);
			this.PanelEx1.Name = "PanelEx1";
			this.PanelEx1.Size = new System.Drawing.Size(1251, 556);
			this.PanelEx1.TabIndex = 27;
			//
			//grdRiyouJininKakuteiRev
			//
			this.grdRiyouJininKakuteiRev.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.grdRiyouJininKakuteiRev.AutoGenerateColumns = false;
			this.grdRiyouJininKakuteiRev.ColumnInfo = resources.GetString("grdRiyouJininKakuteiRev.ColumnInfo");
			this.grdRiyouJininKakuteiRev.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.grdRiyouJininKakuteiRev.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcrossOut;
			this.grdRiyouJininKakuteiRev.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcrossOut;
			this.grdRiyouJininKakuteiRev.Location = new System.Drawing.Point(14, 34);
			this.grdRiyouJininKakuteiRev.Name = "grdRiyouJininKakuteiRev";
			this.grdRiyouJininKakuteiRev.Rows.DefaultSize = 21;
			this.grdRiyouJininKakuteiRev.Size = new System.Drawing.Size(1224, 517);
			this.grdRiyouJininKakuteiRev.TabIndex = 29;
			this.grdRiyouJininKakuteiRev.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System;
			//
			//lblLengthGrd
			//
			this.lblLengthGrd.AutoSize = true;
			this.lblLengthGrd.ExistError = false;
			this.lblLengthGrd.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.lblLengthGrd.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLengthGrd.GuideMessage = "";
			this.lblLengthGrd.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("lblLengthGrd.GuideMessageDetail"));
			this.lblLengthGrd.Location = new System.Drawing.Point(1167, 13);
			this.lblLengthGrd.Margin = new System.Windows.Forms.Padding(3);
			this.lblLengthGrd.Name = "lblLengthGrd";
			this.lblLengthGrd.NotNull = false;
			this.lblLengthGrd.Size = new System.Drawing.Size(71, 15);
			this.lblLengthGrd.TabIndex = 28;
			this.lblLengthGrd.Text = "      件";
			this.lblLengthGrd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//S04_0101
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(8.0F, 15.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 862);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.F10Key_Visible = true;
			this.F11Key_Visible = true;
			this.F12Key_Visible = true;
			this.F1Key_Visible = true;
			this.F2Key_Visible = true;
			this.F3Key_Visible = true;
			this.F4Key_Visible = true;
			this.F5Key_Visible = true;
			this.F6Key_Visible = true;
			this.F7Key_Visible = true;
			this.F8Key_Visible = true;
			this.F9Key_Visible = true;
			this.Name = "S04_0101";
			this.setTitle = "";
			this.setTitleVisible = true;
			this.setWindowTitle = "PT01";
			this.Text = "PT01";
			((System.ComponentModel.ISupportInitialize)this.SearchResultGridData).EndInit();
			this.pnlBaseFill.ResumeLayout(false);
			this.pnlBaseFill.PerformLayout();
			this.gbxCondition.ResumeLayout(false);
			this.gbxCondition.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dtmSyuptTime).EndInit();
			((System.ComponentModel.ISupportInitialize)this.txtGousya).EndInit();
			this.PanelEx1.ResumeLayout(false);
			this.PanelEx1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.grdRiyouJininKakuteiRev).EndInit();
			this.ResumeLayout(false);

		}

		internal GroupBoxEx gbxCondition;
		internal LabelEx LabelEx1;
		internal ButtonEx btnVisiblerCondition;
		internal PanelEx PanelEx1;
		internal ButtonEx btnSearch;
		internal LabelEx lblLengthGrd;
		internal FlexGridEx grdRiyouJininKakuteiRev;
		internal LabelEx lblSyuptDay;
		internal FromToDateEx dtmSyuptDayFromTo;
		internal CheckBoxEx chkKikakuStay;
		internal CheckBoxEx chkKikakuDayTrip;
		internal CheckBoxEx chkRCrs;
		internal CheckBoxEx chkTeikiNight;
		internal CheckBoxEx chkTeikiNoon;
		internal LabelEx lblCrsKbn;
		internal TextBoxEx txtGousya;
		internal GrapeCity.Win.Editors.GcShortcut GcShortcut1;
		internal LabelEx LabelEx2;
		internal LabelEx lblJyosyaTi;
		internal Master.CodeControlEx ucoJyosyaTiCd;
		internal CheckBoxEx chkJapanese;
		internal CheckBoxEx chkGaikokugo;
		internal LabelEx lblCrsKind;
		internal LabelEx lblSyuptTime;
		internal TimeEx dtmSyuptTime;
		internal LabelEx lblCrsCd2;
		internal Master.CodeControlEx ucoCrsCd;
		internal CheckBoxEx chk2StayMore;
		internal CheckBoxEx chkBoat;
		internal ButtonEx btnClear;
		internal CheckBoxEx chkNightLine;
	}
}