using System.Windows.Forms;

namespace Unkou
{
	public partial class FormBase : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
			this.pnlTitle = new System.Windows.Forms.Panel();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.pnlBaseBottom = new System.Windows.Forms.Panel();
			this.pnlFormId = new System.Windows.Forms.Panel();
			this.lblFormId = new System.Windows.Forms.Label();
			this.StatusBar = new System.Windows.Forms.StatusStrip();
			this.pnlFunctionKeyPanel = new System.Windows.Forms.Panel();
			this.pnlBaseFill = new System.Windows.Forms.Panel();
			this.btnF12 = new Hatobus.ReservationManagementSystem.ClientCommon.ButtonEx();
			this.btnF11 = new Hatobus.ReservationManagementSystem.ClientCommon.ButtonEx();
			this.btnF10 = new Hatobus.ReservationManagementSystem.ClientCommon.ButtonEx();
			this.btnF9 = new Hatobus.ReservationManagementSystem.ClientCommon.ButtonEx();
			this.btnF8 = new Hatobus.ReservationManagementSystem.ClientCommon.ButtonEx();
			this.btnF7 = new Hatobus.ReservationManagementSystem.ClientCommon.ButtonEx();
			this.btnF6 = new Hatobus.ReservationManagementSystem.ClientCommon.ButtonEx();
			this.btnF5 = new Hatobus.ReservationManagementSystem.ClientCommon.ButtonEx();
			this.btnF4 = new Hatobus.ReservationManagementSystem.ClientCommon.ButtonEx();
			this.btnF3 = new Hatobus.ReservationManagementSystem.ClientCommon.ButtonEx();
			this.btnF2 = new Hatobus.ReservationManagementSystem.ClientCommon.ButtonEx();
			this.btnF1 = new Hatobus.ReservationManagementSystem.ClientCommon.ButtonEx();
			this.pnlTitle.SuspendLayout();
			this.pnlBaseBottom.SuspendLayout();
			this.pnlFormId.SuspendLayout();
			this.pnlFunctionKeyPanel.SuspendLayout();
			this.SuspendLayout();
			//
			//pnlTitle
			//
			this.pnlTitle.BackColor = System.Drawing.Color.Transparent;
			this.pnlTitle.BackgroundImage = (System.Drawing.Image)(resources.GetObject("pnlTitle.BackgroundImage"));
			this.pnlTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pnlTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlTitle.Controls.Add(this.Panel1);
			this.pnlTitle.Controls.Add(this.lblTitle);
			this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTitle.Location = new System.Drawing.Point(0, 0);
			this.pnlTitle.Name = "pnlTitle";
			this.pnlTitle.Size = new System.Drawing.Size(1264, 50);
			this.pnlTitle.TabIndex = 1;
			//
			//Panel1
			//
			this.Panel1.BackgroundImage = (System.Drawing.Image)(resources.GetObject("Panel1.BackgroundImage"));
			this.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.Panel1.Location = new System.Drawing.Point(31, 3);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(57, 37);
			this.Panel1.TabIndex = 0;
			//
			//lblTitle
			//
			this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom
				| System.Windows.Forms.AnchorStyles.Left;
			this.lblTitle.AutoSize = true;
			this.lblTitle.BackColor = System.Drawing.Color.Transparent;
			this.lblTitle.Font = new System.Drawing.Font("ＭＳ ゴシック", 18.0F, (System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
				| System.Drawing.FontStyle.Underline), System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(128));
			this.lblTitle.ForeColor = System.Drawing.Color.Black;
			this.lblTitle.Location = new System.Drawing.Point(90, 12);
			this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(75, 24);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Title";
			//
			//pnlBaseBottom
			//
			this.pnlBaseBottom.Controls.Add(this.pnlFormId);
			this.pnlBaseBottom.Controls.Add(this.StatusBar);
			this.pnlBaseBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlBaseBottom.Location = new System.Drawing.Point(0, 843);
			this.pnlBaseBottom.Name = "pnlBaseBottom";
			this.pnlBaseBottom.Size = new System.Drawing.Size(1264, 19);
			this.pnlBaseBottom.TabIndex = 1003;
			//
			//pnlFormId
			//
			this.pnlFormId.Controls.Add(this.lblFormId);
			this.pnlFormId.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlFormId.Location = new System.Drawing.Point(1193, 0);
			this.pnlFormId.Name = "pnlFormId";
			this.pnlFormId.Size = new System.Drawing.Size(71, 19);
			this.pnlFormId.TabIndex = 1000;
			//
			//lblFormId
			//
			this.lblFormId.AutoSize = true;
			this.lblFormId.Location = new System.Drawing.Point(4, 0);
			this.lblFormId.Name = "lblFormId";
			this.lblFormId.Size = new System.Drawing.Size(0, 15);
			this.lblFormId.TabIndex = 0;
			//
			//StatusBar
			//
			this.StatusBar.BackColor = System.Drawing.Color.Transparent;
			this.StatusBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StatusBar.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(128));
			this.StatusBar.Location = new System.Drawing.Point(0, 0);
			this.StatusBar.Name = "StatusBar";
			this.StatusBar.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
			this.StatusBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.StatusBar.Size = new System.Drawing.Size(1264, 19);
			this.StatusBar.SizingGrip = false;
			this.StatusBar.TabIndex = 999;
			this.StatusBar.Text = "StatusBar";
			//
			//pnlFunctionKeyPanel
			//
			this.pnlFunctionKeyPanel.BackColor = System.Drawing.Color.Transparent;
			this.pnlFunctionKeyPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlFunctionKeyPanel.Controls.Add(this.btnF12);
			this.pnlFunctionKeyPanel.Controls.Add(this.btnF11);
			this.pnlFunctionKeyPanel.Controls.Add(this.btnF10);
			this.pnlFunctionKeyPanel.Controls.Add(this.btnF9);
			this.pnlFunctionKeyPanel.Controls.Add(this.btnF8);
			this.pnlFunctionKeyPanel.Controls.Add(this.btnF7);
			this.pnlFunctionKeyPanel.Controls.Add(this.btnF6);
			this.pnlFunctionKeyPanel.Controls.Add(this.btnF5);
			this.pnlFunctionKeyPanel.Controls.Add(this.btnF4);
			this.pnlFunctionKeyPanel.Controls.Add(this.btnF3);
			this.pnlFunctionKeyPanel.Controls.Add(this.btnF2);
			this.pnlFunctionKeyPanel.Controls.Add(this.btnF1);
			this.pnlFunctionKeyPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlFunctionKeyPanel.Location = new System.Drawing.Point(0, 806);
			this.pnlFunctionKeyPanel.Name = "pnlFunctionKeyPanel";
			this.pnlFunctionKeyPanel.Size = new System.Drawing.Size(1264, 37);
			this.pnlFunctionKeyPanel.TabIndex = 1004;
			//
			//pnlBaseFill
			//
			this.pnlBaseFill.AutoScroll = true;
			this.pnlBaseFill.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlBaseFill.Location = new System.Drawing.Point(0, 50);
			this.pnlBaseFill.Name = "pnlBaseFill";
			this.pnlBaseFill.Padding = new System.Windows.Forms.Padding(5);
			this.pnlBaseFill.Size = new System.Drawing.Size(1264, 756);
			this.pnlBaseFill.TabIndex = 1005;
			//
			//btnF12
			//
			this.btnF12.AutoSize = true;
			this.btnF12.BackColor = System.Drawing.Color.Transparent;
			this.btnF12.BtnEventId = Hatobus.ReservationManagementSystem.ClientCommon.ClientConstantCode.BtnKeyId.F12;
			this.btnF12.ExistError = false;
			this.btnF12.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.btnF12.ForeColor = System.Drawing.Color.Black;
			this.btnF12.GuideMessage = "";
			this.btnF12.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("btnF12.GuideMessageDetail"));
			this.btnF12.Location = new System.Drawing.Point(1154, 2);
			this.btnF12.Name = "btnF12";
			this.btnF12.NotNull = false;
			this.btnF12.Size = new System.Drawing.Size(90, 30);
			this.btnF12.TabIndex = 11;
			this.btnF12.Text = "F12:";
			this.btnF12.UseVisualStyleBackColor = false;
			this.btnF12.Visible = false;
			//
			//btnF11
			//
			this.btnF11.AutoSize = true;
			this.btnF11.BackColor = System.Drawing.Color.Transparent;
			this.btnF11.BtnEventId = Hatobus.ReservationManagementSystem.ClientCommon.ClientConstantCode.BtnKeyId.F11;
			this.btnF11.ExistError = false;
			this.btnF11.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.btnF11.ForeColor = System.Drawing.Color.Black;
			this.btnF11.GuideMessage = "";
			this.btnF11.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("btnF11.GuideMessageDetail"));
			this.btnF11.Location = new System.Drawing.Point(1050, 2);
			this.btnF11.Name = "btnF11";
			this.btnF11.NotNull = false;
			this.btnF11.Size = new System.Drawing.Size(90, 30);
			this.btnF11.TabIndex = 10;
			this.btnF11.Text = "F11:更新";
			this.btnF11.UseVisualStyleBackColor = false;
			this.btnF11.Visible = false;
			//
			//btnF10
			//
			this.btnF10.AutoSize = true;
			this.btnF10.BackColor = System.Drawing.Color.Transparent;
			this.btnF10.BtnEventId = Hatobus.ReservationManagementSystem.ClientCommon.ClientConstantCode.BtnKeyId.F10;
			this.btnF10.ExistError = false;
			this.btnF10.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.btnF10.ForeColor = System.Drawing.Color.Black;
			this.btnF10.GuideMessage = "";
			this.btnF10.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("btnF10.GuideMessageDetail"));
			this.btnF10.Location = new System.Drawing.Point(946, 2);
			this.btnF10.Name = "btnF10";
			this.btnF10.NotNull = false;
			this.btnF10.Size = new System.Drawing.Size(90, 30);
			this.btnF10.TabIndex = 9;
			this.btnF10.Text = "F10:登録";
			this.btnF10.UseVisualStyleBackColor = false;
			this.btnF10.Visible = false;
			//
			//btnF9
			//
			this.btnF9.AutoSize = true;
			this.btnF9.BackColor = System.Drawing.Color.Transparent;
			this.btnF9.BtnEventId = Hatobus.ReservationManagementSystem.ClientCommon.ClientConstantCode.BtnKeyId.F9;
			this.btnF9.ExistError = false;
			this.btnF9.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.btnF9.ForeColor = System.Drawing.Color.Black;
			this.btnF9.GuideMessage = "";
			this.btnF9.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("btnF9.GuideMessageDetail"));
			this.btnF9.Location = new System.Drawing.Point(842, 2);
			this.btnF9.Name = "btnF9";
			this.btnF9.NotNull = false;
			this.btnF9.Size = new System.Drawing.Size(90, 30);
			this.btnF9.TabIndex = 8;
			this.btnF9.Text = "F9:";
			this.btnF9.UseVisualStyleBackColor = false;
			this.btnF9.Visible = false;
			//
			//btnF8
			//
			this.btnF8.AutoSize = true;
			this.btnF8.BackColor = System.Drawing.Color.Transparent;
			this.btnF8.BtnEventId = Hatobus.ReservationManagementSystem.ClientCommon.ClientConstantCode.BtnKeyId.F8;
			this.btnF8.ExistError = false;
			this.btnF8.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.btnF8.ForeColor = System.Drawing.Color.Black;
			this.btnF8.GuideMessage = "";
			this.btnF8.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("btnF8.GuideMessageDetail"));
			this.btnF8.Location = new System.Drawing.Point(738, 2);
			this.btnF8.Name = "btnF8";
			this.btnF8.NotNull = false;
			this.btnF8.Size = new System.Drawing.Size(90, 30);
			this.btnF8.TabIndex = 7;
			this.btnF8.Text = "F8:検索";
			this.btnF8.UseVisualStyleBackColor = false;
			this.btnF8.Visible = false;
			//
			//btnF7
			//
			this.btnF7.AutoSize = true;
			this.btnF7.BackColor = System.Drawing.Color.Transparent;
			this.btnF7.BtnEventId = Hatobus.ReservationManagementSystem.ClientCommon.ClientConstantCode.BtnKeyId.F7;
			this.btnF7.ExistError = false;
			this.btnF7.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.btnF7.ForeColor = System.Drawing.Color.Black;
			this.btnF7.GuideMessage = "";
			this.btnF7.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("btnF7.GuideMessageDetail"));
			this.btnF7.Location = new System.Drawing.Point(634, 2);
			this.btnF7.Name = "btnF7";
			this.btnF7.NotNull = false;
			this.btnF7.Size = new System.Drawing.Size(90, 30);
			this.btnF7.TabIndex = 6;
			this.btnF7.Text = "F7:印刷";
			this.btnF7.UseVisualStyleBackColor = false;
			this.btnF7.Visible = false;
			//
			//btnF6
			//
			this.btnF6.AutoSize = true;
			this.btnF6.BackColor = System.Drawing.Color.Transparent;
			this.btnF6.BtnEventId = Hatobus.ReservationManagementSystem.ClientCommon.ClientConstantCode.BtnKeyId.F6;
			this.btnF6.ExistError = false;
			this.btnF6.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.btnF6.ForeColor = System.Drawing.Color.Black;
			this.btnF6.GuideMessage = "";
			this.btnF6.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("btnF6.GuideMessageDetail"));
			this.btnF6.Location = new System.Drawing.Point(530, 2);
			this.btnF6.Name = "btnF6";
			this.btnF6.NotNull = false;
			this.btnF6.Size = new System.Drawing.Size(90, 30);
			this.btnF6.TabIndex = 5;
			this.btnF6.Text = "F6:";
			this.btnF6.UseVisualStyleBackColor = false;
			this.btnF6.Visible = false;
			//
			//btnF5
			//
			this.btnF5.AutoSize = true;
			this.btnF5.BackColor = System.Drawing.Color.Transparent;
			this.btnF5.BtnEventId = Hatobus.ReservationManagementSystem.ClientCommon.ClientConstantCode.BtnKeyId.F5;
			this.btnF5.ExistError = false;
			this.btnF5.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.btnF5.ForeColor = System.Drawing.Color.Black;
			this.btnF5.GuideMessage = "";
			this.btnF5.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("btnF5.GuideMessageDetail"));
			this.btnF5.Location = new System.Drawing.Point(426, 2);
			this.btnF5.Name = "btnF5";
			this.btnF5.NotNull = false;
			this.btnF5.Size = new System.Drawing.Size(90, 30);
			this.btnF5.TabIndex = 4;
			this.btnF5.Text = "F5:参照";
			this.btnF5.UseVisualStyleBackColor = false;
			this.btnF5.Visible = false;
			//
			//btnF4
			//
			this.btnF4.AutoSize = true;
			this.btnF4.BackColor = System.Drawing.Color.Transparent;
			this.btnF4.BtnEventId = Hatobus.ReservationManagementSystem.ClientCommon.ClientConstantCode.BtnKeyId.F4;
			this.btnF4.ExistError = false;
			this.btnF4.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.btnF4.ForeColor = System.Drawing.Color.Black;
			this.btnF4.GuideMessage = "";
			this.btnF4.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("btnF4.GuideMessageDetail"));
			this.btnF4.Location = new System.Drawing.Point(322, 2);
			this.btnF4.Name = "btnF4";
			this.btnF4.NotNull = false;
			this.btnF4.Size = new System.Drawing.Size(90, 30);
			this.btnF4.TabIndex = 3;
			this.btnF4.Text = "F4:削除";
			this.btnF4.UseVisualStyleBackColor = false;
			this.btnF4.Visible = false;
			//
			//btnF3
			//
			this.btnF3.AutoSize = true;
			this.btnF3.BackColor = System.Drawing.Color.Transparent;
			this.btnF3.BtnEventId = Hatobus.ReservationManagementSystem.ClientCommon.ClientConstantCode.BtnKeyId.F3;
			this.btnF3.ExistError = false;
			this.btnF3.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.btnF3.ForeColor = System.Drawing.Color.Black;
			this.btnF3.GuideMessage = "";
			this.btnF3.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("btnF3.GuideMessageDetail"));
			this.btnF3.Location = new System.Drawing.Point(218, 2);
			this.btnF3.Name = "btnF3";
			this.btnF3.NotNull = false;
			this.btnF3.Size = new System.Drawing.Size(90, 30);
			this.btnF3.TabIndex = 2;
			this.btnF3.Text = "F3:終了";
			this.btnF3.UseVisualStyleBackColor = false;
			this.btnF3.Visible = false;
			//
			//btnF2
			//
			this.btnF2.AutoSize = true;
			this.btnF2.BackColor = System.Drawing.Color.Transparent;
			this.btnF2.BtnEventId = Hatobus.ReservationManagementSystem.ClientCommon.ClientConstantCode.BtnKeyId.F2;
			this.btnF2.ExistError = false;
			this.btnF2.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.btnF2.ForeColor = System.Drawing.Color.Black;
			this.btnF2.GuideMessage = "";
			this.btnF2.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("btnF2.GuideMessageDetail"));
			this.btnF2.Location = new System.Drawing.Point(114, 2);
			this.btnF2.Name = "btnF2";
			this.btnF2.NotNull = false;
			this.btnF2.Size = new System.Drawing.Size(90, 30);
			this.btnF2.TabIndex = 1;
			this.btnF2.Text = "F2:戻る";
			this.btnF2.UseVisualStyleBackColor = false;
			this.btnF2.Visible = false;
			//
			//btnF1
			//
			this.btnF1.AutoSize = true;
			this.btnF1.BackColor = System.Drawing.Color.Transparent;
			this.btnF1.BtnEventId = Hatobus.ReservationManagementSystem.ClientCommon.ClientConstantCode.BtnKeyId.F1;
			this.btnF1.ExistError = false;
			this.btnF1.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F);
			this.btnF1.ForeColor = System.Drawing.Color.Black;
			this.btnF1.GuideMessage = "";
			this.btnF1.GuideMessageDetail = (System.Collections.Generic.List<string>)(resources.GetObject("btnF1.GuideMessageDetail"));
			this.btnF1.Location = new System.Drawing.Point(10, 2);
			this.btnF1.Name = "btnF1";
			this.btnF1.NotNull = false;
			this.btnF1.Size = new System.Drawing.Size(90, 30);
			this.btnF1.TabIndex = 0;
			this.btnF1.Text = "F1:";
			this.btnF1.UseVisualStyleBackColor = false;
			this.btnF1.Visible = false;
			//
			//FormBase
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(8.0F, 15.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(1264, 862);
			this.Controls.Add(this.pnlBaseFill);
			this.Controls.Add(this.pnlFunctionKeyPanel);
			this.Controls.Add(this.pnlBaseBottom);
			this.Controls.Add(this.pnlTitle);
			this.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(128));
			this.Icon = (System.Drawing.Icon)(resources.GetObject("$this.Icon"));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormBase";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.pnlTitle.ResumeLayout(false);
			this.pnlTitle.PerformLayout();
			this.pnlBaseBottom.ResumeLayout(false);
			this.pnlBaseBottom.PerformLayout();
			this.pnlFormId.ResumeLayout(false);
			this.pnlFormId.PerformLayout();
			this.pnlFunctionKeyPanel.ResumeLayout(false);
			this.pnlFunctionKeyPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		internal Panel pnlTitle;
		internal Panel Panel1;
		internal Label lblTitle;
		internal Panel pnlBaseBottom;
		internal Panel pnlFormId;
		internal Label lblFormId;
		internal StatusStrip StatusBar;
		internal Panel pnlFunctionKeyPanel;
		internal ButtonEx btnF1;
		public Panel pnlBaseFill;
		internal ButtonEx btnF6;
		internal ButtonEx btnF5;
		internal ButtonEx btnF4;
		internal ButtonEx btnF3;
		internal ButtonEx btnF2;
		internal ButtonEx btnF12;
		internal ButtonEx btnF11;
		internal ButtonEx btnF10;
		internal ButtonEx btnF9;
		internal ButtonEx btnF8;
		internal ButtonEx btnF7;
	}
}