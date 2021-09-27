
using Unkou.Common;

namespace Unkou
{
	partial class S04_0104 : PT21
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
			GrapeCity.Win.Editors.Fields.DateHourDisplayField DateHourDisplayField2 = new GrapeCity.Win.Editors.Fields.DateHourDisplayField();
			GrapeCity.Win.Editors.Fields.DateLiteralDisplayField DateLiteralDisplayField4 = new GrapeCity.Win.Editors.Fields.DateLiteralDisplayField();
			GrapeCity.Win.Editors.Fields.DateMinuteDisplayField DateMinuteDisplayField2 = new GrapeCity.Win.Editors.Fields.DateMinuteDisplayField();
			GrapeCity.Win.Editors.Fields.DateHourField DateHourField2 = new GrapeCity.Win.Editors.Fields.DateHourField();
			GrapeCity.Win.Editors.Fields.DateLiteralField DateLiteralField4 = new GrapeCity.Win.Editors.Fields.DateLiteralField();
			GrapeCity.Win.Editors.Fields.DateMinuteField DateMinuteField2 = new GrapeCity.Win.Editors.Fields.DateMinuteField();
			GrapeCity.Win.Editors.Fields.DateYearDisplayField DateYearDisplayField2 = new GrapeCity.Win.Editors.Fields.DateYearDisplayField();
			GrapeCity.Win.Editors.Fields.DateLiteralDisplayField DateLiteralDisplayField5 = new GrapeCity.Win.Editors.Fields.DateLiteralDisplayField();
			GrapeCity.Win.Editors.Fields.DateMonthDisplayField DateMonthDisplayField2 = new GrapeCity.Win.Editors.Fields.DateMonthDisplayField();
			GrapeCity.Win.Editors.Fields.DateLiteralDisplayField DateLiteralDisplayField6 = new GrapeCity.Win.Editors.Fields.DateLiteralDisplayField();
			GrapeCity.Win.Editors.Fields.DateDayDisplayField DateDayDisplayField2 = new GrapeCity.Win.Editors.Fields.DateDayDisplayField();
			GrapeCity.Win.Editors.Fields.DateYearField DateYearField2 = new GrapeCity.Win.Editors.Fields.DateYearField();
			GrapeCity.Win.Editors.Fields.DateLiteralField DateLiteralField5 = new GrapeCity.Win.Editors.Fields.DateLiteralField();
			GrapeCity.Win.Editors.Fields.DateMonthField DateMonthField2 = new GrapeCity.Win.Editors.Fields.DateMonthField();
			GrapeCity.Win.Editors.Fields.DateLiteralField DateLiteralField6 = new GrapeCity.Win.Editors.Fields.DateLiteralField();
			GrapeCity.Win.Editors.Fields.DateDayField DateDayField2 = new GrapeCity.Win.Editors.Fields.DateDayField();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(S04_0104));
			this.gbxCondition = new Hatobus.ReservationManagementSystem.ClientCommon.GroupBoxEx();
			this.txtGousya = new Hatobus.ReservationManagementSystem.ClientCommon.TextBoxEx();
			this.lblGousya = new Hatobus.ReservationManagementSystem.ClientCommon.LabelEx();
			this.ucoCrsCd = new Hatobus.ReservationManagementSystem.Master.CodeControlEx();
			this.dtmSyuptTime = new Hatobus.ReservationManagementSystem.ClientCommon.TimeEx();
			this.lblCrsCd = new Hatobus.ReservationManagementSystem.ClientCommon.LabelEx();
			this.lblSyuptTime = new Hatobus.ReservationManagementSystem.ClientCommon.LabelEx();
			this.ucoNoribaCd = new Hatobus.ReservationManagementSystem.Master.CodeControlEx();
			this.lblNoriba = new Hatobus.ReservationManagementSystem.ClientCommon.LabelEx();
			this.lblSyuptDay = new Hatobus.ReservationManagementSystem.ClientCommon.LabelEx();
			this.dtmSyuptDay = new Hatobus.ReservationManagementSystem.ClientCommon.DateEx();
			this.DropDownButton1 = new GrapeCity.Win.Editors.DropDownButton();
			this.btnClear = new Hatobus.ReservationManagementSystem.ClientCommon.ButtonEx();
			this.btnSearch = new Hatobus.ReservationManagementSystem.ClientCommon.ButtonEx();
			this.btnVisiblerCondition = new Hatobus.ReservationManagementSystem.ClientCommon.ButtonEx();
			this.lblSearchKoumoku = new Hatobus.ReservationManagementSystem.ClientCommon.LabelEx();
			this.gbxArea1 = new Hatobus.ReservationManagementSystem.ClientCommon.GroupBoxEx();
			this.lblLengthGrd = new Hatobus.ReservationManagementSystem.ClientCommon.LabelEx();
			this.btnYoyakuInquiry = new Hatobus.ReservationManagementSystem.ClientCommon.ButtonEx();
			this.btnClear02 = new Hatobus.ReservationManagementSystem.ClientCommon.ButtonEx();
			this.btnAll = new Hatobus.ReservationManagementSystem.ClientCommon.ButtonEx();
			this.grdCrs = new Hatobus.ReservationManagementSystem.ClientCommon.FlexGridEx();
			this.gbxArea2 = new Hatobus.ReservationManagementSystem.ClientCommon.GroupBoxEx();
			this.txtNinzuTotal = new Hatobus.ReservationManagementSystem.ClientCommon.TextBoxEx();
			this.lblNinzuTotal = new Hatobus.ReservationManagementSystem.ClientCommon.LabelEx();
			this.grdYoyaku = new Hatobus.ReservationManagementSystem.ClientCommon.FlexGridEx();
			this.GcShortcut1 = new GrapeCity.Win.Editors.GcShortcut(this.components);
			this.pnlBaseFill.SuspendLayout();
			this.gbxCondition.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.txtGousya).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dtmSyuptTime).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dtmSyuptDay).BeginInit();
			this.gbxArea1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.grdCrs).BeginInit();
			this.gbxArea2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.txtNinzuTotal).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.grdYoyaku).BeginInit();
			this.SuspendLayout();
			//
			//pnlBaseFill
			//
			this.pnlBaseFill.Controls.Add(this.gbxArea2);
			this.pnlBaseFill.Controls.Add(this.lblSearchKoumoku);
			this.pnlBaseFill.Controls.Add(this.gbxArea1);
			this.pnlBaseFill.Controls.Add(this.btnVisiblerCondition);
			this.pnlBaseFill.Controls.Add(this.gbxCondition);
			this.pnlBaseFill.Size = new System.Drawing.Size(1264, 636);
			//
			//gbxCondition
			//
			this.gbxCondition.AutoSize = true;
			this.gbxCondition.Controls.Add(this.txtGousya);
			this.gbxCondition.Controls.Add(this.lblGousya);
			this.gbxCondition.Controls.Add(this.ucoCrsCd);
			this.gbxCondition.Controls.Add(this.dtmSyuptTime);
			this.gbxCondition.Controls.Add(this.lblCrsCd);
			this.gbxCondition.Controls.Add(this.lblSyuptTime);
			this.gbxCondition.Controls.Add(this.ucoNoribaCd);
			this.gbxCondition.Controls.Add(this.lblNoriba);
			this.gbxCondition.Controls.Add(this.lblSyuptDay);
			this.gbxCondition.Controls.Add(this.dtmSyuptDay);
			this.gbxCondition.Controls.Add(this.btnClear);
			this.gbxCondition.Controls.Add(this.btnSearch);
			this.gbxCondition.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.gbxCondition.Location = new System.Drawing.Point(8, 41);
			this.gbxCondition.Name = "gbxCondition";
			this.gbxCondition.Size = new System.Drawing.Size(1248, 122);
			this.gbxCondition.TabIndex = 1;
			this.gbxCondition.TabStop = false;
			//
			//txtGousya
			//
			this.txtGousya.AutoSize = true;
			this.txtGousya.CharLength = 4;
			this.txtGousya.ContentAlignment = System.Drawing.ContentAlignment.MiddleRight;
			this.txtGousya.ExistError = false;
			this.txtGousya.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.txtGousya.Format = "9";
			this.txtGousya.GuideMessage = "";
			this.txtGousya.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("txtGousya.GuideMessageDetail"));
			this.txtGousya.HighlightText = true;
			this.txtGousya.LineFeedProcessing = false;
			this.txtGousya.Location = new System.Drawing.Point(66, 66);
			this.txtGousya.MaxLength = 4;
			this.txtGousya.Name = "txtGousya";
			this.txtGousya.NotNull = false;
			this.txtGousya.Size = new System.Drawing.Size(39, 21);
			this.txtGousya.SJISOnly = false;
			this.txtGousya.TabIndex = 11;
			this.txtGousya.TextInputMode = Hatobus.ReservationManagementSystem.ClientCommon.TextBoxEx.InputMode.Half;
			//
			//lblGousya
			//
			this.lblGousya.AutoSize = true;
			this.lblGousya.ExistError = false;
			this.lblGousya.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.lblGousya.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblGousya.GuideMessage = "";
			this.lblGousya.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("lblGousya.GuideMessageDetail"));
			this.lblGousya.Location = new System.Drawing.Point(22, 69);
			this.lblGousya.Margin = new System.Windows.Forms.Padding(3);
			this.lblGousya.Name = "lblGousya";
			this.lblGousya.NotNull = false;
			this.lblGousya.Size = new System.Drawing.Size(39, 15);
			this.lblGousya.TabIndex = 10;
			this.lblGousya.Text = "号車";
			//
			//ucoCrsCd
			//
			this.ucoCrsCd.CharLength = 0;
			this.ucoCrsCd.CodeFormat = Hatobus.ReservationManagementSystem.Master.CodeControlEx.CodeFormatEnum.COURSE_CD;
			this.ucoCrsCd.CodeNotNull = false;
			this.ucoCrsCd.CodeText = "";
			this.ucoCrsCd.CodeType = Hatobus.ReservationManagementSystem.Master.CodeControlEx.CodeTypeEnum.COURSE_CD;
			this.ucoCrsCd.CompanyCodeText = "";
			this.ucoCrsCd.ExistError = false;
			this.ucoCrsCd.IsManualLenMode = false;
			this.ucoCrsCd.Location = new System.Drawing.Point(652, 35);
			this.ucoCrsCd.Margin = new System.Windows.Forms.Padding(2);
			this.ucoCrsCd.MasterTable = null;
			this.ucoCrsCd.Name = "ucoCrsCd";
			this.ucoCrsCd.Param1 = null;
			this.ucoCrsCd.Param2 = null;
			this.ucoCrsCd.Param3 = null;
			this.ucoCrsCd.Param4 = null;
			this.ucoCrsCd.Param5 = null;
			this.ucoCrsCd.Param6 = null;
			this.ucoCrsCd.Size = new System.Drawing.Size(447, 26);
			this.ucoCrsCd.TabIndex = 9;
			this.ucoCrsCd.ValueText = "";
			//
			//dtmSyuptTime
			//
			this.dtmSyuptTime.AutoSize = true;
			DateHourDisplayField2.ShowLeadingZero = true;
			DateLiteralDisplayField4.Text = ":";
			DateMinuteDisplayField2.ShowLeadingZero = true;
			this.dtmSyuptTime.DisplayFields.AddRange(new GrapeCity.Win.Editors.Fields.DateDisplayField[] { DateHourDisplayField2, DateLiteralDisplayField4, DateMinuteDisplayField2 });
			this.dtmSyuptTime.ExistError = false;
			DateLiteralField4.Text = ":";
			this.dtmSyuptTime.Fields.AddRange(new GrapeCity.Win.Editors.Fields.DateField[] { DateHourField2, DateLiteralField4, DateMinuteField2 });
			this.dtmSyuptTime.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.dtmSyuptTime.GuideMessage = "";
			this.dtmSyuptTime.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("dtmSyuptTime.GuideMessageDetail"));
			this.dtmSyuptTime.HighlightText = GrapeCity.Win.Editors.HighlightText.All;
			this.dtmSyuptTime.Location = new System.Drawing.Point(652, 9);
			this.dtmSyuptTime.Name = "dtmSyuptTime";
			this.dtmSyuptTime.NotNull = false;
			this.dtmSyuptTime.Size = new System.Drawing.Size(54, 21);
			this.dtmSyuptTime.TabIndex = 5;
			this.dtmSyuptTime.Value = null;
			//
			//lblCrsCd
			//
			this.lblCrsCd.AutoSize = true;
			this.lblCrsCd.ExistError = false;
			this.lblCrsCd.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.lblCrsCd.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCrsCd.GuideMessage = "";
			this.lblCrsCd.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("lblCrsCd.GuideMessageDetail"));
			this.lblCrsCd.Location = new System.Drawing.Point(543, 41);
			this.lblCrsCd.Margin = new System.Windows.Forms.Padding(18, 3, 3, 3);
			this.lblCrsCd.Name = "lblCrsCd";
			this.lblCrsCd.NotNull = false;
			this.lblCrsCd.Size = new System.Drawing.Size(103, 15);
			this.lblCrsCd.TabIndex = 8;
			this.lblCrsCd.Text = "コースコード";
			//
			//lblSyuptTime
			//
			this.lblSyuptTime.AutoSize = true;
			this.lblSyuptTime.ExistError = false;
			this.lblSyuptTime.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.lblSyuptTime.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblSyuptTime.GuideMessage = "";
			this.lblSyuptTime.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("lblSyuptTime.GuideMessageDetail"));
			this.lblSyuptTime.Location = new System.Drawing.Point(575, 12);
			this.lblSyuptTime.Margin = new System.Windows.Forms.Padding(18, 3, 3, 3);
			this.lblSyuptTime.Name = "lblSyuptTime";
			this.lblSyuptTime.NotNull = false;
			this.lblSyuptTime.Size = new System.Drawing.Size(71, 15);
			this.lblSyuptTime.TabIndex = 4;
			this.lblSyuptTime.Text = "出発時間";
			//
			//ucoNoribaCd
			//
			this.ucoNoribaCd.CharLength = 0;
			this.ucoNoribaCd.CodeFormat = Hatobus.ReservationManagementSystem.Master.CodeControlEx.CodeFormatEnum.COURSE_CD;
			this.ucoNoribaCd.CodeNotNull = true;
			this.ucoNoribaCd.CodeText = "";
			this.ucoNoribaCd.CodeType = Hatobus.ReservationManagementSystem.Master.CodeControlEx.CodeTypeEnum.PLACE_CD;
			this.ucoNoribaCd.CompanyCodeText = "";
			this.ucoNoribaCd.ExistError = false;
			this.ucoNoribaCd.IsManualLenMode = false;
			this.ucoNoribaCd.Location = new System.Drawing.Point(66, 35);
			this.ucoNoribaCd.Margin = new System.Windows.Forms.Padding(2);
			this.ucoNoribaCd.MasterTable = null;
			this.ucoNoribaCd.Name = "ucoNoribaCd";
			this.ucoNoribaCd.Param1 = null;
			this.ucoNoribaCd.Param2 = null;
			this.ucoNoribaCd.Param3 = null;
			this.ucoNoribaCd.Param4 = null;
			this.ucoNoribaCd.Param5 = null;
			this.ucoNoribaCd.Param6 = null;
			this.ucoNoribaCd.Size = new System.Drawing.Size(457, 26);
			this.ucoNoribaCd.TabIndex = 7;
			this.ucoNoribaCd.ValueText = "";
			//
			//lblNoriba
			//
			this.lblNoriba.AutoSize = true;
			this.lblNoriba.ExistError = false;
			this.lblNoriba.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.lblNoriba.ForeColor = System.Drawing.Color.Red;
			this.lblNoriba.GuideMessage = "";
			this.lblNoriba.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("lblNoriba.GuideMessageDetail"));
			this.lblNoriba.Location = new System.Drawing.Point(6, 41);
			this.lblNoriba.Margin = new System.Windows.Forms.Padding(3);
			this.lblNoriba.Name = "lblNoriba";
			this.lblNoriba.NotNull = true;
			this.lblNoriba.Size = new System.Drawing.Size(55, 15);
			this.lblNoriba.TabIndex = 6;
			this.lblNoriba.Text = "乗車地";
			//
			//lblSyuptDay
			//
			this.lblSyuptDay.AutoSize = true;
			this.lblSyuptDay.ExistError = false;
			this.lblSyuptDay.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.lblSyuptDay.ForeColor = System.Drawing.Color.Red;
			this.lblSyuptDay.GuideMessage = "";
			this.lblSyuptDay.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("lblSyuptDay.GuideMessageDetail"));
			this.lblSyuptDay.Location = new System.Drawing.Point(6, 12);
			this.lblSyuptDay.Margin = new System.Windows.Forms.Padding(3);
			this.lblSyuptDay.Name = "lblSyuptDay";
			this.lblSyuptDay.NotNull = true;
			this.lblSyuptDay.Size = new System.Drawing.Size(55, 15);
			this.lblSyuptDay.TabIndex = 2;
			this.lblSyuptDay.Text = "出発日";
			//
			//dtmSyuptDay
			//
			this.dtmSyuptDay.AutoSize = true;
			this.dtmSyuptDay.BackColor = System.Drawing.Color.LightBlue;
			DateYearDisplayField2.ShowLeadingZero = true;
			DateYearDisplayField2.YearDigit = GrapeCity.Win.Editors.YearDigitType.TwoDigitYear;
			DateLiteralDisplayField5.Text = "/";
			DateMonthDisplayField2.ShowLeadingZero = true;
			DateLiteralDisplayField6.Text = "/";
			DateDayDisplayField2.ShowLeadingZero = true;
			this.dtmSyuptDay.DisplayFields.AddRange(new GrapeCity.Win.Editors.Fields.DateDisplayField[] { DateYearDisplayField2, DateLiteralDisplayField5, DateMonthDisplayField2, DateLiteralDisplayField6, DateDayDisplayField2 });
			this.dtmSyuptDay.ExistError = false;
			DateYearField2.YearDigit = GrapeCity.Win.Editors.YearDigitType.TwoDigitYear;
			DateLiteralField5.Text = "/";
			DateLiteralField6.Text = "/";
			this.dtmSyuptDay.Fields.AddRange(new GrapeCity.Win.Editors.Fields.DateField[] { DateYearField2, DateLiteralField5, DateMonthField2, DateLiteralField6, DateDayField2 });
			this.dtmSyuptDay.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.dtmSyuptDay.GuideMessage = "";
			this.dtmSyuptDay.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("dtmSyuptDay.GuideMessageDetail"));
			this.dtmSyuptDay.HatoMode = false;
			this.dtmSyuptDay.HighlightText = GrapeCity.Win.Editors.HighlightText.All;
			this.dtmSyuptDay.Location = new System.Drawing.Point(67, 9);
			this.dtmSyuptDay.Name = "dtmSyuptDay";
			this.dtmSyuptDay.NotNull = true;
			this.dtmSyuptDay.SideButtons.AddRange(new GrapeCity.Win.Editors.SideButtonBase[] { this.DropDownButton1 });
			this.dtmSyuptDay.Size = new System.Drawing.Size(87, 21);
			this.dtmSyuptDay.TabIndex = 3;
			this.dtmSyuptDay.ValidatorMode = false;
			this.dtmSyuptDay.Value = null;
			//
			//DropDownButton1
			//
			this.DropDownButton1.Name = "DropDownButton1";
			//
			//btnClear
			//
			this.btnClear.AllowAuthLevel = Hatobus.ReservationManagementSystem.Common.FixedCd.AuthLevel.non;
			this.btnClear.AuthControl = false;
			this.btnClear.AutoSize = true;
			this.btnClear.BackColor = System.Drawing.Color.Transparent;
			this.btnClear.BtnEventId = Hatobus.ReservationManagementSystem.ClientCommon.ClientConstantCode.BtnKeyId.CLEAR;
			this.btnClear.ExistError = false;
			this.btnClear.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.btnClear.ForeColor = System.Drawing.Color.Black;
			this.btnClear.GuideMessage = "";
			this.btnClear.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("btnClear.GuideMessageDetail"));
			this.btnClear.Location = new System.Drawing.Point(1033, 66);
			this.btnClear.Name = "btnClear";
			this.btnClear.NotNull = false;
			this.btnClear.Size = new System.Drawing.Size(97, 30);
			this.btnClear.TabIndex = 12;
			this.btnClear.Text = "条件クリア";
			this.btnClear.UseVisualStyleBackColor = true;
			//
			//btnSearch
			//
			this.btnSearch.AllowAuthLevel = Hatobus.ReservationManagementSystem.Common.FixedCd.AuthLevel.non;
			this.btnSearch.AuthControl = false;
			this.btnSearch.AutoSize = true;
			this.btnSearch.BackColor = System.Drawing.Color.Transparent;
			this.btnSearch.BtnEventId = Hatobus.ReservationManagementSystem.ClientCommon.ClientConstantCode.BtnKeyId.F8;
			this.btnSearch.ExistError = false;
			this.btnSearch.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.btnSearch.ForeColor = System.Drawing.Color.Black;
			this.btnSearch.GuideMessage = "";
			this.btnSearch.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("btnSearch.GuideMessageDetail"));
			this.btnSearch.Location = new System.Drawing.Point(1136, 66);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.NotNull = false;
			this.btnSearch.Size = new System.Drawing.Size(97, 30);
			this.btnSearch.TabIndex = 13;
			this.btnSearch.Text = "F8:検索";
			this.btnSearch.UseVisualStyleBackColor = true;
			//
			//btnVisiblerCondition
			//
			this.btnVisiblerCondition.AllowAuthLevel = Hatobus.ReservationManagementSystem.Common.FixedCd.AuthLevel.non;
			this.btnVisiblerCondition.AuthControl = false;
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
			this.btnVisiblerCondition.TabIndex = 0;
			this.btnVisiblerCondition.Text = "非表示 <<";
			this.btnVisiblerCondition.UseVisualStyleBackColor = true;
			//
			//lblSearchKoumoku
			//
			this.lblSearchKoumoku.AutoSize = true;
			this.lblSearchKoumoku.ExistError = false;
			this.lblSearchKoumoku.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.lblSearchKoumoku.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblSearchKoumoku.GuideMessage = "";
			this.lblSearchKoumoku.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("lblSearchKoumoku.GuideMessageDetail"));
			this.lblSearchKoumoku.Location = new System.Drawing.Point(5, 11);
			this.lblSearchKoumoku.Margin = new System.Windows.Forms.Padding(3);
			this.lblSearchKoumoku.Name = "lblSearchKoumoku";
			this.lblSearchKoumoku.NotNull = false;
			this.lblSearchKoumoku.Size = new System.Drawing.Size(71, 15);
			this.lblSearchKoumoku.TabIndex = 0;
			this.lblSearchKoumoku.Text = "検索項目";
			//
			//gbxArea1
			//
			this.gbxArea1.AutoSize = true;
			this.gbxArea1.Controls.Add(this.lblLengthGrd);
			this.gbxArea1.Controls.Add(this.btnYoyakuInquiry);
			this.gbxArea1.Controls.Add(this.btnClear02);
			this.gbxArea1.Controls.Add(this.btnAll);
			this.gbxArea1.Controls.Add(this.grdCrs);
			this.gbxArea1.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.gbxArea1.Location = new System.Drawing.Point(8, 169);
			this.gbxArea1.Name = "gbxArea1";
			this.gbxArea1.Size = new System.Drawing.Size(1248, 209);
			this.gbxArea1.TabIndex = 2;
			this.gbxArea1.TabStop = false;
			this.gbxArea1.Text = "コース";
			//
			//lblLengthGrd
			//
			this.lblLengthGrd.AutoSize = true;
			this.lblLengthGrd.ExistError = false;
			this.lblLengthGrd.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.lblLengthGrd.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLengthGrd.GuideMessage = "";
			this.lblLengthGrd.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("lblLengthGrd.GuideMessageDetail"));
			this.lblLengthGrd.Location = new System.Drawing.Point(822, 31);
			this.lblLengthGrd.Margin = new System.Windows.Forms.Padding(3);
			this.lblLengthGrd.Name = "lblLengthGrd";
			this.lblLengthGrd.NotNull = false;
			this.lblLengthGrd.Size = new System.Drawing.Size(71, 15);
			this.lblLengthGrd.TabIndex = 1012;
			this.lblLengthGrd.Text = "      件";
			this.lblLengthGrd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//btnYoyakuInquiry
			//
			this.btnYoyakuInquiry.AllowAuthLevel = Hatobus.ReservationManagementSystem.Common.FixedCd.AuthLevel.non;
			this.btnYoyakuInquiry.AuthControl = false;
			this.btnYoyakuInquiry.AutoSize = true;
			this.btnYoyakuInquiry.BackColor = System.Drawing.Color.Transparent;
			this.btnYoyakuInquiry.BtnEventId = Hatobus.ReservationManagementSystem.ClientCommon.ClientConstantCode.BtnKeyId.F9;
			this.btnYoyakuInquiry.ExistError = false;
			this.btnYoyakuInquiry.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.btnYoyakuInquiry.ForeColor = System.Drawing.Color.Black;
			this.btnYoyakuInquiry.GuideMessage = "";
			this.btnYoyakuInquiry.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("btnYoyakuInquiry.GuideMessageDetail"));
			this.btnYoyakuInquiry.Location = new System.Drawing.Point(899, 155);
			this.btnYoyakuInquiry.Name = "btnYoyakuInquiry";
			this.btnYoyakuInquiry.NotNull = false;
			this.btnYoyakuInquiry.Size = new System.Drawing.Size(105, 25);
			this.btnYoyakuInquiry.TabIndex = 17;
			this.btnYoyakuInquiry.Text = "F9:予約照会";
			this.btnYoyakuInquiry.UseVisualStyleBackColor = true;
			//
			//btnClear02
			//
			this.btnClear02.AllowAuthLevel = Hatobus.ReservationManagementSystem.Common.FixedCd.AuthLevel.non;
			this.btnClear02.AuthControl = false;
			this.btnClear02.AutoSize = true;
			this.btnClear02.BackColor = System.Drawing.Color.Transparent;
			this.btnClear02.BtnEventId = Hatobus.ReservationManagementSystem.ClientCommon.ClientConstantCode.BtnKeyId.Null;
			this.btnClear02.ExistError = false;
			this.btnClear02.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.btnClear02.ForeColor = System.Drawing.Color.Black;
			this.btnClear02.GuideMessage = "";
			this.btnClear02.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("btnClear02.GuideMessageDetail"));
			this.btnClear02.Location = new System.Drawing.Point(102, 21);
			this.btnClear02.Name = "btnClear02";
			this.btnClear02.NotNull = false;
			this.btnClear02.Size = new System.Drawing.Size(89, 25);
			this.btnClear02.TabIndex = 15;
			this.btnClear02.Text = "全解除";
			this.btnClear02.UseVisualStyleBackColor = true;
			//
			//btnAll
			//
			this.btnAll.AllowAuthLevel = Hatobus.ReservationManagementSystem.Common.FixedCd.AuthLevel.non;
			this.btnAll.AuthControl = false;
			this.btnAll.AutoSize = true;
			this.btnAll.BackColor = System.Drawing.Color.Transparent;
			this.btnAll.BtnEventId = Hatobus.ReservationManagementSystem.ClientCommon.ClientConstantCode.BtnKeyId.Null;
			this.btnAll.ExistError = false;
			this.btnAll.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.btnAll.ForeColor = System.Drawing.Color.Black;
			this.btnAll.GuideMessage = "";
			this.btnAll.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("btnAll.GuideMessageDetail"));
			this.btnAll.Location = new System.Drawing.Point(7, 21);
			this.btnAll.Name = "btnAll";
			this.btnAll.NotNull = false;
			this.btnAll.Size = new System.Drawing.Size(89, 25);
			this.btnAll.TabIndex = 14;
			this.btnAll.Text = "全選択";
			this.btnAll.UseVisualStyleBackColor = true;
			//
			//grdCrs
			//
			this.grdCrs.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.grdCrs.AutoGenerateColumns = false;
			this.grdCrs.ColumnInfo = resources.GetString("grdCrs.ColumnInfo");
			this.grdCrs.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.grdCrs.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcrossOut;
			this.grdCrs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcrossOut;
			this.grdCrs.Location = new System.Drawing.Point(7, 52);
			this.grdCrs.Name = "grdCrs";
			this.grdCrs.Rows.DefaultSize = 21;
			this.grdCrs.Size = new System.Drawing.Size(886, 128);
			this.grdCrs.TabIndex = 16;
			this.grdCrs.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System;
			//
			//gbxArea2
			//
			this.gbxArea2.AutoSize = true;
			this.gbxArea2.Controls.Add(this.txtNinzuTotal);
			this.gbxArea2.Controls.Add(this.lblNinzuTotal);
			this.gbxArea2.Controls.Add(this.grdYoyaku);
			this.gbxArea2.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.gbxArea2.Location = new System.Drawing.Point(8, 384);
			this.gbxArea2.Name = "gbxArea2";
			this.gbxArea2.Size = new System.Drawing.Size(1248, 368);
			this.gbxArea2.TabIndex = 18;
			this.gbxArea2.TabStop = false;
			this.gbxArea2.Text = "予約";
			//
			//txtNinzuTotal
			//
			this.txtNinzuTotal.AutoSize = true;
			this.txtNinzuTotal.BackColor = System.Drawing.SystemColors.Control;
			this.txtNinzuTotal.CharLength = 5;
			this.txtNinzuTotal.ContentAlignment = System.Drawing.ContentAlignment.MiddleRight;
			this.txtNinzuTotal.DropDown.AllowDrop = false;
			this.txtNinzuTotal.ExistError = false;
			this.txtNinzuTotal.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.txtNinzuTotal.Format = "^Ｔ";
			this.txtNinzuTotal.GuideMessage = "";
			this.txtNinzuTotal.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("txtNinzuTotal.GuideMessageDetail"));
			this.txtNinzuTotal.HighlightText = true;
			this.txtNinzuTotal.LineFeedProcessing = false;
			this.txtNinzuTotal.Location = new System.Drawing.Point(83, 21);
			this.txtNinzuTotal.MaxLength = 5;
			this.txtNinzuTotal.Name = "txtNinzuTotal";
			this.txtNinzuTotal.NotNull = false;
			this.txtNinzuTotal.ReadOnly = true;
			this.txtNinzuTotal.Size = new System.Drawing.Size(47, 21);
			this.txtNinzuTotal.SJISOnly = false;
			this.txtNinzuTotal.TabIndex = 19;
			this.txtNinzuTotal.TabStop = false;
			this.txtNinzuTotal.TextInputMode = Hatobus.ReservationManagementSystem.ClientCommon.TextBoxEx.InputMode.Half;
			//
			//lblNinzuTotal
			//
			this.lblNinzuTotal.AutoSize = true;
			this.lblNinzuTotal.ExistError = false;
			this.lblNinzuTotal.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.lblNinzuTotal.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblNinzuTotal.GuideMessage = "";
			this.lblNinzuTotal.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("lblNinzuTotal.GuideMessageDetail"));
			this.lblNinzuTotal.Location = new System.Drawing.Point(6, 24);
			this.lblNinzuTotal.Margin = new System.Windows.Forms.Padding(3);
			this.lblNinzuTotal.Name = "lblNinzuTotal";
			this.lblNinzuTotal.NotNull = false;
			this.lblNinzuTotal.Size = new System.Drawing.Size(71, 15);
			this.lblNinzuTotal.TabIndex = 18;
			this.lblNinzuTotal.Text = "人数合計";
			//
			//grdYoyaku
			//
			this.grdYoyaku.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.grdYoyaku.AutoGenerateColumns = false;
			this.grdYoyaku.ColumnInfo = resources.GetString("grdYoyaku.ColumnInfo");
			this.grdYoyaku.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.grdYoyaku.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcrossOut;
			this.grdYoyaku.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcrossOut;
			this.grdYoyaku.Location = new System.Drawing.Point(7, 48);
			this.grdYoyaku.Name = "grdYoyaku";
			this.grdYoyaku.Rows.DefaultSize = 21;
			this.grdYoyaku.Size = new System.Drawing.Size(753, 289);
			this.grdYoyaku.TabIndex = 20;
			this.grdYoyaku.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System;
			//
			//S04_0104
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(8.0F, 15.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 742);
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
			this.Name = "S04_0104";
			this.setTitle = "";
			this.setTitleVisible = true;
			this.setWindowTitle = "PT01";
			this.Text = "PT01";
			this.pnlBaseFill.ResumeLayout(false);
			this.pnlBaseFill.PerformLayout();
			this.gbxCondition.ResumeLayout(false);
			this.gbxCondition.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.txtGousya).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dtmSyuptTime).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dtmSyuptDay).EndInit();
			this.gbxArea1.ResumeLayout(false);
			this.gbxArea1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.grdCrs).EndInit();
			this.gbxArea2.ResumeLayout(false);
			this.gbxArea2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.txtNinzuTotal).EndInit();
			((System.ComponentModel.ISupportInitialize)this.grdYoyaku).EndInit();
			this.ResumeLayout(false);

		}

		internal GroupBoxEx gbxCondition;
		internal LabelEx lblSearchKoumoku;
		internal ButtonEx btnVisiblerCondition;
		internal ButtonEx btnSearch;
		internal GroupBoxEx gbxArea2;
		internal GroupBoxEx gbxArea1;
		internal ButtonEx btnClear;
		internal GrapeCity.Win.Editors.GcShortcut GcShortcut1;
		internal LabelEx lblNoriba;
		internal LabelEx lblSyuptDay;
		internal DateEx dtmSyuptDay;
		internal GrapeCity.Win.Editors.DropDownButton DropDownButton1;
		internal Master.CodeControlEx ucoNoribaCd;
		internal LabelEx lblSyuptTime;
		internal TimeEx dtmSyuptTime;
		internal LabelEx lblCrsCd;
		internal Master.CodeControlEx ucoCrsCd;
		internal TextBoxEx txtGousya;
		internal LabelEx lblGousya;
		internal ButtonEx btnClear02;
		internal ButtonEx btnAll;
		internal FlexGridEx grdCrs;
		internal LabelEx lblLengthGrd;
		internal ButtonEx btnYoyakuInquiry;
		internal TextBoxEx txtNinzuTotal;
		internal LabelEx lblNinzuTotal;
		internal FlexGridEx grdYoyaku;
	}
}