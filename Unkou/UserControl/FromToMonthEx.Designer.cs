using System;

namespace Unkou.UserControl
{
    partial class FromToMonthEx 
    {
        // UserControl はコンポーネント一覧をクリーンアップするために dispose をオーバーライドします。

       

        // Windows フォーム デザイナーで必要です。
        private System.ComponentModel.IContainer components;

        // メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
        // Windows フォーム デザイナーを使用して変更できます。  
        // コード エディターを使って変更しないでください。

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var DateYearField1 = new GrapeCity.Win.Editors.Fields.DateYearField();
            var DateLiteralField1 = new GrapeCity.Win.Editors.Fields.DateLiteralField();
            var DateMonthField1 = new GrapeCity.Win.Editors.Fields.DateMonthField();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FromToMonthEx));
            var DateYearField2 = new GrapeCity.Win.Editors.Fields.DateYearField();
            var DateLiteralField2 = new GrapeCity.Win.Editors.Fields.DateLiteralField();
            var DateMonthField2 = new GrapeCity.Win.Editors.Fields.DateMonthField();
            GcShortcut1 = new GrapeCity.Win.Editors.GcShortcut(components);
            DropDownButton2 = new GrapeCity.Win.Editors.DropDownButton();
            DropDownButton1 = new GrapeCity.Win.Editors.DropDownButton();
            ((System.ComponentModel.ISupportInitialize)dtmToMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtmFromMonth).BeginInit();
            
            // 
            // dtmToMonth
            // 
            dtmToMonth.AutoSize = true;
            dtmToMonth.DropDownCalendar.CalendarType = GrapeCity.Win.Editors.CalendarType.YearMonth;
            dtmToMonth.ExistError = false;
            DateLiteralField1.Text = "/";
            dtmToMonth.Fields.AddRange(new GrapeCity.Win.Editors.Fields.DateField[] { DateYearField1, DateLiteralField1, DateMonthField1 });
            dtmToMonth.Font = new System.Drawing.Font("MS Gothic", 11.25f);
            dtmToMonth.GuideMessage = "";
            dtmToMonth.HatoMode = false;
            dtmToMonth.HighlightText = GrapeCity.Win.Editors.HighlightText.All;
            dtmToMonth.Location = new System.Drawing.Point(141, 0);
            dtmToMonth.Name = "dtmToMonth";
            dtmToMonth.NotNull = false;
            dtmToMonth.SideButtons.AddRange(new GrapeCity.Win.Editors.SideButtonBase[] { DropDownButton2 });
            dtmToMonth.Size = new System.Drawing.Size(106, 21);
            dtmToMonth.TabIndex = 2;
            dtmToMonth.ValidatorMode = false;
            dtmToMonth.Value = new DateTime(2018, 7, 1, 0, 0, 0, 0);
            dtmToMonth.ValueInt = 201807;
            // 
            // DropDownButton2
            // 
            DropDownButton2.Name = "DropDownButton2";
            // 
            // dtmFromMonth
            // 
            dtmFromMonth.AutoSize = true;
            dtmFromMonth.DropDownCalendar.CalendarType = GrapeCity.Win.Editors.CalendarType.YearMonth;
            dtmFromMonth.ExistError = false;
            DateLiteralField2.Text = "/";
            dtmFromMonth.Fields.AddRange(new GrapeCity.Win.Editors.Fields.DateField[] { DateYearField2, DateLiteralField2, DateMonthField2 });
            dtmFromMonth.Font = new System.Drawing.Font("MS Gothic", 11.25f);
            dtmFromMonth.GuideMessage = "";
            dtmFromMonth.HatoMode = false;
            dtmFromMonth.HighlightText = GrapeCity.Win.Editors.HighlightText.All;
            dtmFromMonth.Location = new System.Drawing.Point(0, 0);
            dtmFromMonth.Name = "dtmFromMonth";
            dtmFromMonth.NotNull = false;
            dtmFromMonth.SideButtons.AddRange(new GrapeCity.Win.Editors.SideButtonBase[] { DropDownButton1 });
            dtmFromMonth.Size = new System.Drawing.Size(106, 21);
            dtmFromMonth.TabIndex = 0;
            dtmFromMonth.ValidatorMode = false;
            dtmFromMonth.Value = new DateTime(2018, 7, 1, 0, 0, 0, 0);
            dtmFromMonth.ValueInt = 201807;
            // 
            // DropDownButton1
            // 
            DropDownButton1.Name = "DropDownButton1";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.ExistError = false;
            lblTitle.Font = new System.Drawing.Font("MS Gothic", 11.25f);
            lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            lblTitle.GuideMessage = "";
            lblTitle.GuideMessageDetail = null;
            lblTitle.Location = new System.Drawing.Point(112, 3);
            lblTitle.Margin = new System.Windows.Forms.Padding(3);
            lblTitle.Name = "lblTitle";
            lblTitle.NotNull = false;
            lblTitle.Size = new System.Drawing.Size(23, 15);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "～";
         
        }

        internal DateEx dtmFromMonth;
        internal GrapeCity.Win.Editors.GcShortcut GcShortcut1;
        internal GrapeCity.Win.Editors.DropDownButton DropDownButton1;
        internal LabelEx lblTitle;
        internal DateEx dtmToMonth;
        internal GrapeCity.Win.Editors.DropDownButton DropDownButton2;
    }
}
