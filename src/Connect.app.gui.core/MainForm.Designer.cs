﻿
namespace core.audiamus.connect.app.gui {
  partial class MainForm {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose (bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose ();
      }
      base.Dispose (disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent () {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.ckBoxAdult = new System.Windows.Forms.CheckBox();
      this.ckBoxMultiPart = new System.Windows.Forms.CheckBox();
      this.convertdgvControl1 = new core.audiamus.connect.ui.ConvertDGVControl();
      this.panelTop = new System.Windows.Forms.Panel();
      this.grpBoxDownload = new System.Windows.Forms.GroupBox();
      this.comBoxDnldQual = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.ckBoxRefresh = new System.Windows.Forms.CheckBox();
      this.ckBoxUpdLib = new System.Windows.Forms.CheckBox();
      this.btnDnldDir = new System.Windows.Forms.Button();
      this.comBoxSort = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.ckBoxKeepEncrypted = new System.Windows.Forms.CheckBox();
      this.ckBoxOpenDlg = new System.Windows.Forms.CheckBox();
      this.grpBoxExport = new System.Windows.Forms.GroupBox();
      this.btnExprtDir = new System.Windows.Forms.Button();
      this.ckBoxExport = new System.Windows.Forms.CheckBox();
      this.grpBoxProfiles = new System.Windows.Forms.GroupBox();
      this.btnProfiles = new System.Windows.Forms.Button();
      this.panelBottom = new System.Windows.Forms.Panel();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.progressBarItems = new System.Windows.Forms.ProgressBar();
      this.progressBarConvert = new System.Windows.Forms.ProgressBar();
      this.progressBarDnld = new System.Windows.Forms.ProgressBar();
      this.btnAbort = new System.Windows.Forms.Button();
      this.btnConvert = new System.Windows.Forms.Button();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.panelTop.SuspendLayout();
      this.grpBoxDownload.SuspendLayout();
      this.grpBoxExport.SuspendLayout();
      this.grpBoxProfiles.SuspendLayout();
      this.panelBottom.SuspendLayout();
      this.SuspendLayout();
      // 
      // ckBoxAdult
      // 
      this.ckBoxAdult.AutoSize = true;
      this.ckBoxAdult.Location = new System.Drawing.Point(147, 78);
      this.ckBoxAdult.Name = "ckBoxAdult";
      this.ckBoxAdult.Size = new System.Drawing.Size(96, 17);
      this.ckBoxAdult.TabIndex = 7;
      this.ckBoxAdult.Text = "Adult products";
      this.ckBoxAdult.UseVisualStyleBackColor = true;
      this.ckBoxAdult.UseWaitCursor = true;
      this.ckBoxAdult.CheckedChanged += new System.EventHandler(this.ckBoxAdult_CheckedChanged);
      // 
      // ckBoxMultiPart
      // 
      this.ckBoxMultiPart.AutoSize = true;
      this.ckBoxMultiPart.Location = new System.Drawing.Point(147, 58);
      this.ckBoxMultiPart.Name = "ckBoxMultiPart";
      this.ckBoxMultiPart.Size = new System.Drawing.Size(121, 17);
      this.ckBoxMultiPart.TabIndex = 6;
      this.ckBoxMultiPart.Text = "Multi-part download";
      this.ckBoxMultiPart.UseVisualStyleBackColor = true;
      this.ckBoxMultiPart.UseWaitCursor = true;
      this.ckBoxMultiPart.CheckedChanged += new System.EventHandler(this.ckBoxMultiPart_CheckedChanged);
      // 
      // convertdgvControl1
      // 
      this.convertdgvControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.convertdgvControl1.DownloadOnlyMode = false;
      this.convertdgvControl1.Location = new System.Drawing.Point(0, 107);
      this.convertdgvControl1.Name = "convertdgvControl1";
      this.convertdgvControl1.PartiallyDisabled = false;
      this.convertdgvControl1.Size = new System.Drawing.Size(822, 268);
      this.convertdgvControl1.TabIndex = 4;
      this.convertdgvControl1.UseWaitCursor = true;
      // 
      // panelTop
      // 
      this.panelTop.Controls.Add(this.grpBoxDownload);
      this.panelTop.Controls.Add(this.grpBoxExport);
      this.panelTop.Controls.Add(this.grpBoxProfiles);
      this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelTop.Location = new System.Drawing.Point(0, 0);
      this.panelTop.Name = "panelTop";
      this.panelTop.Size = new System.Drawing.Size(822, 107);
      this.panelTop.TabIndex = 1;
      this.panelTop.UseWaitCursor = true;
      // 
      // grpBoxDownload
      // 
      this.grpBoxDownload.Controls.Add(this.comBoxDnldQual);
      this.grpBoxDownload.Controls.Add(this.label5);
      this.grpBoxDownload.Controls.Add(this.ckBoxRefresh);
      this.grpBoxDownload.Controls.Add(this.ckBoxUpdLib);
      this.grpBoxDownload.Controls.Add(this.btnDnldDir);
      this.grpBoxDownload.Controls.Add(this.comBoxSort);
      this.grpBoxDownload.Controls.Add(this.label1);
      this.grpBoxDownload.Controls.Add(this.ckBoxKeepEncrypted);
      this.grpBoxDownload.Controls.Add(this.ckBoxOpenDlg);
      this.grpBoxDownload.Controls.Add(this.ckBoxAdult);
      this.grpBoxDownload.Controls.Add(this.ckBoxMultiPart);
      this.grpBoxDownload.Location = new System.Drawing.Point(132, 0);
      this.grpBoxDownload.Name = "grpBoxDownload";
      this.grpBoxDownload.Size = new System.Drawing.Size(409, 107);
      this.grpBoxDownload.TabIndex = 2;
      this.grpBoxDownload.TabStop = false;
      this.grpBoxDownload.Text = "Download settings";
      this.grpBoxDownload.UseWaitCursor = true;
      // 
      // comBoxDnldQual
      // 
      this.comBoxDnldQual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comBoxDnldQual.FormattingEnabled = true;
      this.comBoxDnldQual.Location = new System.Drawing.Point(147, 30);
      this.comBoxDnldQual.Name = "comBoxDnldQual";
      this.comBoxDnldQual.Size = new System.Drawing.Size(111, 21);
      this.comBoxDnldQual.TabIndex = 5;
      this.comBoxDnldQual.UseWaitCursor = true;
      this.comBoxDnldQual.SelectedIndexChanged += new System.EventHandler(this.comBoxDnldQual_SelectedIndexChanged);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(147, 13);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(118, 13);
      this.label5.TabIndex = 9;
      this.label5.Text = "Audio download quality";
      this.label5.UseWaitCursor = true;
      // 
      // ckBoxRefresh
      // 
      this.ckBoxRefresh.AutoSize = true;
      this.ckBoxRefresh.Location = new System.Drawing.Point(6, 19);
      this.ckBoxRefresh.Name = "ckBoxRefresh";
      this.ckBoxRefresh.Size = new System.Drawing.Size(90, 17);
      this.ckBoxRefresh.TabIndex = 1;
      this.ckBoxRefresh.Text = "Auto connect";
      this.ckBoxRefresh.UseVisualStyleBackColor = true;
      this.ckBoxRefresh.UseWaitCursor = true;
      this.ckBoxRefresh.CheckedChanged += new System.EventHandler(this.ckBoxRefresh_CheckedChanged);
      // 
      // ckBoxUpdLib
      // 
      this.ckBoxUpdLib.AutoSize = true;
      this.ckBoxUpdLib.Location = new System.Drawing.Point(6, 38);
      this.ckBoxUpdLib.Name = "ckBoxUpdLib";
      this.ckBoxUpdLib.Size = new System.Drawing.Size(125, 17);
      this.ckBoxUpdLib.TabIndex = 2;
      this.ckBoxUpdLib.Text = "Auto update book lib";
      this.ckBoxUpdLib.UseVisualStyleBackColor = true;
      this.ckBoxUpdLib.UseWaitCursor = true;
      this.ckBoxUpdLib.CheckedChanged += new System.EventHandler(this.ckBoxUpdLib_CheckedChanged);
      // 
      // btnDnldDir
      // 
      this.btnDnldDir.Location = new System.Drawing.Point(286, 74);
      this.btnDnldDir.Name = "btnDnldDir";
      this.btnDnldDir.Size = new System.Drawing.Size(110, 23);
      this.btnDnldDir.TabIndex = 9;
      this.btnDnldDir.Text = "Download Folder …";
      this.btnDnldDir.UseVisualStyleBackColor = true;
      this.btnDnldDir.UseWaitCursor = true;
      this.btnDnldDir.Click += new System.EventHandler(this.btnDnldDir_Click);
      // 
      // comBoxSort
      // 
      this.comBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comBoxSort.FormattingEnabled = true;
      this.comBoxSort.Location = new System.Drawing.Point(285, 30);
      this.comBoxSort.Name = "comBoxSort";
      this.comBoxSort.Size = new System.Drawing.Size(111, 21);
      this.comBoxSort.TabIndex = 8;
      this.comBoxSort.UseWaitCursor = true;
      this.comBoxSort.SelectedIndexChanged += new System.EventHandler(this.comBoxSort_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(286, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(69, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "Initial sorting";
      this.label1.UseWaitCursor = true;
      // 
      // ckBoxKeepEncrypted
      // 
      this.ckBoxKeepEncrypted.AutoSize = true;
      this.ckBoxKeepEncrypted.Location = new System.Drawing.Point(6, 78);
      this.ckBoxKeepEncrypted.Name = "ckBoxKeepEncrypted";
      this.ckBoxKeepEncrypted.Size = new System.Drawing.Size(124, 17);
      this.ckBoxKeepEncrypted.TabIndex = 4;
      this.ckBoxKeepEncrypted.Text = "Keep encrypted files";
      this.ckBoxKeepEncrypted.UseVisualStyleBackColor = true;
      this.ckBoxKeepEncrypted.UseWaitCursor = true;
      this.ckBoxKeepEncrypted.CheckedChanged += new System.EventHandler(this.ckBoxKeepEncrypted_CheckedChanged);
      // 
      // ckBoxOpenDlg
      // 
      this.ckBoxOpenDlg.AutoSize = true;
      this.ckBoxOpenDlg.Location = new System.Drawing.Point(6, 58);
      this.ckBoxOpenDlg.Name = "ckBoxOpenDlg";
      this.ckBoxOpenDlg.Size = new System.Drawing.Size(125, 17);
      this.ckBoxOpenDlg.TabIndex = 3;
      this.ckBoxOpenDlg.Text = "Auto open download";
      this.ckBoxOpenDlg.UseVisualStyleBackColor = true;
      this.ckBoxOpenDlg.UseWaitCursor = true;
      this.ckBoxOpenDlg.CheckedChanged += new System.EventHandler(this.ckBoxOpenDlg_CheckedChanged);
      // 
      // grpBoxExport
      // 
      this.grpBoxExport.Controls.Add(this.btnExprtDir);
      this.grpBoxExport.Controls.Add(this.ckBoxExport);
      this.grpBoxExport.Location = new System.Drawing.Point(549, 0);
      this.grpBoxExport.Name = "grpBoxExport";
      this.grpBoxExport.Size = new System.Drawing.Size(148, 107);
      this.grpBoxExport.TabIndex = 3;
      this.grpBoxExport.TabStop = false;
      this.grpBoxExport.Text = "Export settings";
      this.grpBoxExport.UseWaitCursor = true;
      // 
      // btnExprtDir
      // 
      this.btnExprtDir.Location = new System.Drawing.Point(16, 74);
      this.btnExprtDir.Name = "btnExprtDir";
      this.btnExprtDir.Size = new System.Drawing.Size(110, 23);
      this.btnExprtDir.TabIndex = 2;
      this.btnExprtDir.Text = "Export Folder …";
      this.btnExprtDir.UseVisualStyleBackColor = true;
      this.btnExprtDir.UseWaitCursor = true;
      this.btnExprtDir.Click += new System.EventHandler(this.btnExprtDir_Click);
      // 
      // ckBoxExport
      // 
      this.ckBoxExport.AutoSize = true;
      this.ckBoxExport.Location = new System.Drawing.Point(16, 38);
      this.ckBoxExport.Name = "ckBoxExport";
      this.ckBoxExport.Size = new System.Drawing.Size(97, 17);
      this.ckBoxExport.TabIndex = 1;
      this.ckBoxExport.Text = "Export as .aax";
      this.ckBoxExport.UseVisualStyleBackColor = true;
      this.ckBoxExport.UseWaitCursor = true;
      this.ckBoxExport.CheckedChanged += new System.EventHandler(this.ckBoxExport_CheckedChanged);
      // 
      // grpBoxProfiles
      // 
      this.grpBoxProfiles.Controls.Add(this.btnProfiles);
      this.grpBoxProfiles.Location = new System.Drawing.Point(0, 0);
      this.grpBoxProfiles.Name = "grpBoxProfiles";
      this.grpBoxProfiles.Size = new System.Drawing.Size(124, 107);
      this.grpBoxProfiles.TabIndex = 1;
      this.grpBoxProfiles.TabStop = false;
      this.grpBoxProfiles.Text = "Profile settings";
      this.grpBoxProfiles.UseWaitCursor = true;
      // 
      // btnProfiles
      // 
      this.btnProfiles.Location = new System.Drawing.Point(22, 74);
      this.btnProfiles.Name = "btnProfiles";
      this.btnProfiles.Size = new System.Drawing.Size(75, 23);
      this.btnProfiles.TabIndex = 1;
      this.btnProfiles.Text = "Profiles …";
      this.btnProfiles.UseVisualStyleBackColor = true;
      this.btnProfiles.UseWaitCursor = true;
      this.btnProfiles.Click += new System.EventHandler(this.btnProfiles_Click);
      // 
      // panelBottom
      // 
      this.panelBottom.Controls.Add(this.label4);
      this.panelBottom.Controls.Add(this.label3);
      this.panelBottom.Controls.Add(this.label2);
      this.panelBottom.Controls.Add(this.progressBarItems);
      this.panelBottom.Controls.Add(this.progressBarConvert);
      this.panelBottom.Controls.Add(this.progressBarDnld);
      this.panelBottom.Controls.Add(this.btnAbort);
      this.panelBottom.Controls.Add(this.btnConvert);
      this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panelBottom.Location = new System.Drawing.Point(0, 375);
      this.panelBottom.Name = "panelBottom";
      this.panelBottom.Size = new System.Drawing.Size(822, 88);
      this.panelBottom.TabIndex = 5;
      this.panelBottom.UseWaitCursor = true;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(114, 11);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(54, 13);
      this.label4.TabIndex = 2;
      this.label4.Text = "Download";
      this.label4.UseWaitCursor = true;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(114, 31);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(45, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Decrypt";
      this.label3.UseWaitCursor = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(114, 64);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(39, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Export";
      this.label2.UseWaitCursor = true;
      // 
      // progressBarItems
      // 
      this.progressBarItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.progressBarItems.Location = new System.Drawing.Point(171, 31);
      this.progressBarItems.Name = "progressBarItems";
      this.progressBarItems.Size = new System.Drawing.Size(541, 14);
      this.progressBarItems.TabIndex = 1;
      this.progressBarItems.UseWaitCursor = true;
      // 
      // progressBarConvert
      // 
      this.progressBarConvert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.progressBarConvert.Location = new System.Drawing.Point(171, 64);
      this.progressBarConvert.Name = "progressBarConvert";
      this.progressBarConvert.Size = new System.Drawing.Size(541, 14);
      this.progressBarConvert.TabIndex = 1;
      this.progressBarConvert.UseWaitCursor = true;
      // 
      // progressBarDnld
      // 
      this.progressBarDnld.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.progressBarDnld.Location = new System.Drawing.Point(171, 11);
      this.progressBarDnld.Name = "progressBarDnld";
      this.progressBarDnld.Size = new System.Drawing.Size(541, 14);
      this.progressBarDnld.TabIndex = 1;
      this.progressBarDnld.UseWaitCursor = true;
      // 
      // btnAbort
      // 
      this.btnAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAbort.Location = new System.Drawing.Point(735, 11);
      this.btnAbort.Name = "btnAbort";
      this.btnAbort.Size = new System.Drawing.Size(75, 34);
      this.btnAbort.TabIndex = 2;
      this.btnAbort.Text = "Abort";
      this.btnAbort.UseVisualStyleBackColor = true;
      this.btnAbort.UseWaitCursor = true;
      this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
      // 
      // btnConvert
      // 
      this.btnConvert.Location = new System.Drawing.Point(22, 11);
      this.btnConvert.Name = "btnConvert";
      this.btnConvert.Size = new System.Drawing.Size(75, 34);
      this.btnConvert.TabIndex = 1;
      this.btnConvert.Text = "Run";
      this.btnConvert.UseVisualStyleBackColor = true;
      this.btnConvert.UseWaitCursor = true;
      this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
      // 
      // timer1
      // 
      this.timer1.Interval = 1500;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(822, 463);
      this.Controls.Add(this.convertdgvControl1);
      this.Controls.Add(this.panelTop);
      this.Controls.Add(this.panelBottom);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MinimumSize = new System.Drawing.Size(710, 320);
      this.Name = "MainForm";
      this.Text = "Audible Connect";
      this.UseWaitCursor = true;
      this.panelTop.ResumeLayout(false);
      this.grpBoxDownload.ResumeLayout(false);
      this.grpBoxDownload.PerformLayout();
      this.grpBoxExport.ResumeLayout(false);
      this.grpBoxExport.PerformLayout();
      this.grpBoxProfiles.ResumeLayout(false);
      this.panelBottom.ResumeLayout(false);
      this.panelBottom.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.CheckBox ckBoxAdult;
    private System.Windows.Forms.CheckBox ckBoxMultiPart;
    private connect.ui.ConvertDGVControl convertdgvControl1;
    private System.Windows.Forms.Panel panelTop;
    private System.Windows.Forms.CheckBox ckBoxOpenDlg;
    private System.Windows.Forms.Panel panelBottom;
    private System.Windows.Forms.Button btnAbort;
    private System.Windows.Forms.Button btnConvert;
    private System.Windows.Forms.ProgressBar progressBarDnld;
    private System.Windows.Forms.Button btnDnldDir;
    private System.Windows.Forms.ProgressBar progressBarItems;
    private System.Windows.Forms.CheckBox ckBoxKeepEncrypted;
    private System.Windows.Forms.Button btnExprtDir;
    private System.Windows.Forms.ProgressBar progressBarConvert;
    private System.Windows.Forms.ComboBox comBoxSort;
    private System.Windows.Forms.Button btnProfiles;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.CheckBox ckBoxExport;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.GroupBox grpBoxDownload;
    private System.Windows.Forms.GroupBox grpBoxExport;
    private System.Windows.Forms.GroupBox grpBoxProfiles;
    private System.Windows.Forms.CheckBox ckBoxRefresh;
    private System.Windows.Forms.CheckBox ckBoxUpdLib;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.ComboBox comBoxDnldQual;
    private System.Windows.Forms.Label label5;
  }
}

