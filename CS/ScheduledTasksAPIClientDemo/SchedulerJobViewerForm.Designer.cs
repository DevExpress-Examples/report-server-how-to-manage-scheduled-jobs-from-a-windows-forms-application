
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
namespace ScheduledTasksAPIClientDemo
{
    partial class SchedulerJobViewerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.recurrencyInfo = new DevExpress.XtraEditors.MemoEdit();
            this.scheduledJobName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.scheduledJobEnabled = new DevExpress.XtraEditors.CheckEdit();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.scheduledJobStartDate = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.label5 = new DevExpress.XtraEditors.LabelControl();
            this.label7 = new DevExpress.XtraEditors.LabelControl();
            this.externalSubscribers = new DevExpress.XtraEditors.MemoEdit();
            this.label8 = new DevExpress.XtraEditors.LabelControl();
            this.exportToSharedFolder = new DevExpress.XtraEditors.MemoEdit();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new DevExpress.XtraEditors.LabelControl();
            this.reportId = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new DevExpress.XtraEditors.LabelControl();
            this.id = new DevExpress.XtraEditors.TextEdit();
            this.btnExecute = new DevExpress.XtraEditors.SimpleButton();
            this.reportParametersGrid = new DevExpress.XtraGrid.GridControl();
            this.reportParametersView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.parametersBindingGrid = new DevExpress.XtraGrid.GridControl();
            this.parametersBindingView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.recurrencyInfoGrid = new DevExpress.XtraGrid.GridControl();
            this.recurrencyInfoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.recurrencyInfo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduledJobName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduledJobEnabled.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduledJobStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduledJobStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalSubscribers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportToSharedFolder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportParametersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportParametersView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametersBindingGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametersBindingView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recurrencyInfoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recurrencyInfoView)).BeginInit();
            this.SuspendLayout();
            // 
            // recurrencyInfo
            // 
            this.recurrencyInfo.Location = new System.Drawing.Point(12, 130);
            this.recurrencyInfo.Name = "recurrencyInfo";
            this.recurrencyInfo.Properties.Appearance.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recurrencyInfo.Properties.Appearance.Options.UseFont = true;
            this.recurrencyInfo.Properties.ReadOnly = true;
            this.recurrencyInfo.Size = new System.Drawing.Size(434, 41);
            this.recurrencyInfo.TabIndex = 0;
            // 
            // scheduledJobName
            // 
            this.scheduledJobName.Location = new System.Drawing.Point(84, 24);
            this.scheduledJobName.Name = "scheduledJobName";
            this.scheduledJobName.Size = new System.Drawing.Size(279, 20);
            this.scheduledJobName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(81, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // scheduledJobEnabled
            // 
            this.scheduledJobEnabled.Location = new System.Drawing.Point(381, 26);
            this.scheduledJobEnabled.Name = "scheduledJobEnabled";
            this.scheduledJobEnabled.Properties.Caption = "Enabled";
            this.scheduledJobEnabled.Size = new System.Drawing.Size(65, 19);
            this.scheduledJobEnabled.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Start Date";
            // 
            // scheduledJobStartDate
            // 
            this.scheduledJobStartDate.EditValue = new System.DateTime(2016, 9, 22, 0, 0, 0, 0);
            this.scheduledJobStartDate.Location = new System.Drawing.Point(12, 74);
            this.scheduledJobStartDate.Name = "scheduledJobStartDate";
            this.scheduledJobStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.scheduledJobStartDate.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.scheduledJobStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.scheduledJobStartDate.Properties.DisplayFormat.FormatString = "g";
            this.scheduledJobStartDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.scheduledJobStartDate.Properties.EditFormat.FormatString = "g";
            this.scheduledJobStartDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.scheduledJobStartDate.Properties.Mask.EditMask = "g";
            this.scheduledJobStartDate.Size = new System.Drawing.Size(196, 20);
            this.scheduledJobStartDate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Recurrency Info";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Parameters Binding";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Report Parameters";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "External Subscribers";
            // 
            // externalSubscribers
            // 
            this.externalSubscribers.Location = new System.Drawing.Point(12, 429);
            this.externalSubscribers.Name = "externalSubscribers";
            this.externalSubscribers.Properties.Appearance.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.externalSubscribers.Properties.Appearance.Options.UseFont = true;
            this.externalSubscribers.Size = new System.Drawing.Size(434, 44);
            this.externalSubscribers.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 487);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Export to Shared Folder";
            // 
            // exportToSharedFolder
            // 
            this.exportToSharedFolder.Location = new System.Drawing.Point(12, 503);
            this.exportToSharedFolder.Name = "exportToSharedFolder";
            this.exportToSharedFolder.Properties.Appearance.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exportToSharedFolder.Properties.Appearance.Options.UseFont = true;
            this.exportToSharedFolder.Size = new System.Drawing.Size(434, 42);
            this.exportToSharedFolder.TabIndex = 16;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(244, 580);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete task";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(128, 580);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update task";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 580);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(84, 23);
            this.btnCreate.TabIndex = 18;
            this.btnCreate.Text = "Create task";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(260, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Report Id";
            // 
            // reportId
            // 
            this.reportId.Location = new System.Drawing.Point(260, 74);
            this.reportId.Name = "reportId";
            this.reportId.Size = new System.Drawing.Size(186, 20);
            this.reportId.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(12, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Id";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(12, 24);
            this.id.Name = "id";
            this.id.Properties.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(52, 20);
            this.id.TabIndex = 22;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(360, 580);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(84, 23);
            this.btnExecute.TabIndex = 23;
            this.btnExecute.Text = "Execute task";
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // reportParametersGrid
            // 
            this.reportParametersGrid.Location = new System.Drawing.Point(12, 301);
            this.reportParametersGrid.MainView = this.reportParametersView;
            this.reportParametersGrid.Name = "reportParametersGrid";
            this.reportParametersGrid.Size = new System.Drawing.Size(434, 105);
            this.reportParametersGrid.TabIndex = 24;
            this.reportParametersGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.reportParametersView});
            // 
            // reportParametersView
            // 
            this.reportParametersView.GridControl = this.reportParametersGrid;
            this.reportParametersView.Name = "reportParametersView";
            this.reportParametersView.OptionsBehavior.Editable = false;
            this.reportParametersView.OptionsView.ShowColumnHeaders = false;
            this.reportParametersView.OptionsView.ShowGroupPanel = false;
            this.reportParametersView.OptionsView.ShowIndicator = false;
            // 
            // parametersBindingGrid
            // 
            this.parametersBindingGrid.Location = new System.Drawing.Point(12, 195);
            this.parametersBindingGrid.MainView = this.parametersBindingView;
            this.parametersBindingGrid.Name = "parametersBindingGrid";
            this.parametersBindingGrid.Size = new System.Drawing.Size(434, 85);
            this.parametersBindingGrid.TabIndex = 25;
            this.parametersBindingGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.parametersBindingView});
            // 
            // parametersBindingView
            // 
            this.parametersBindingView.GridControl = this.parametersBindingGrid;
            this.parametersBindingView.Name = "parametersBindingView";
            this.parametersBindingView.OptionsBehavior.Editable = false;
            this.parametersBindingView.OptionsView.ShowColumnHeaders = false;
            this.parametersBindingView.OptionsView.ShowGroupPanel = false;
            this.parametersBindingView.OptionsView.ShowIndicator = false;
            // 
            // recurrencyInfoGrid
            // 
            this.recurrencyInfoGrid.Location = new System.Drawing.Point(12, 123);
            this.recurrencyInfoGrid.MainView = this.recurrencyInfoView;
            this.recurrencyInfoGrid.Name = "recurrencyInfoGrid";
            this.recurrencyInfoGrid.Size = new System.Drawing.Size(434, 45);
            this.recurrencyInfoGrid.TabIndex = 26;
            this.recurrencyInfoGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.recurrencyInfoView});
            // 
            // recurrencyInfoView
            // 
            this.recurrencyInfoView.GridControl = this.recurrencyInfoGrid;
            this.recurrencyInfoView.Name = "recurrencyInfoView";
            this.recurrencyInfoView.OptionsBehavior.Editable = false;
            this.recurrencyInfoView.OptionsView.ShowColumnHeaders = false;
            this.recurrencyInfoView.OptionsView.ShowGroupPanel = false;
            this.recurrencyInfoView.OptionsView.ShowIndicator = false;
            // 
            // SchedulerJobViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 612);
            this.Controls.Add(this.recurrencyInfoGrid);
            this.Controls.Add(this.parametersBindingGrid);
            this.Controls.Add(this.reportParametersGrid);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.reportId);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.exportToSharedFolder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.externalSubscribers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scheduledJobStartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scheduledJobEnabled);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scheduledJobName);
            this.Controls.Add(this.recurrencyInfo);
            this.Name = "SchedulerJobViewerForm";
            this.Text = "Scheduler Task Viewer";
            this.Load += new System.EventHandler(this.SchedulerJobViewerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recurrencyInfo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduledJobName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduledJobEnabled.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduledJobStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduledJobStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalSubscribers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportToSharedFolder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportParametersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportParametersView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametersBindingGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametersBindingView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recurrencyInfoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recurrencyInfoView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MemoEdit recurrencyInfo;
        private TextEdit scheduledJobName;
        private LabelControl label1;
        private CheckEdit scheduledJobEnabled;
        private LabelControl label2;
        private DateEdit scheduledJobStartDate;
        private LabelControl label3;
        private LabelControl label4;
        private LabelControl label5;
        private LabelControl label7;
        private MemoEdit externalSubscribers;
        private LabelControl label8;
        private MemoEdit exportToSharedFolder;
        private SimpleButton btnDelete;
        private SimpleButton btnUpdate;
        private SimpleButton btnCreate;
        private LabelControl label6;
        private TextEdit reportId;
        private LabelControl label9;
        private TextEdit id;
        private SimpleButton btnExecute;
        private GridControl reportParametersGrid;
        private GridView reportParametersView;
        private GridControl parametersBindingGrid;
        private GridView parametersBindingView;
        private GridControl recurrencyInfoGrid;
        private GridView recurrencyInfoView;

    }
}