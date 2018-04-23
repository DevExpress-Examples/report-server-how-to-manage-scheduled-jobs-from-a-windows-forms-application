using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
namespace ScheduledTasksAPIClientDemo {
    partial class SchedulerJobResultsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.id = new DevExpress.XtraEditors.TextEdit();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ScheduledTasksAPIClientDemo.WaitForm1), true, true);
            this.label9 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.scheduledJobName = new DevExpress.XtraEditors.TextEdit();
            this.logsLabel = new DevExpress.XtraEditors.LabelControl();
            this.jobLogsGrid = new DevExpress.XtraGrid.GridControl();
            this.jobLogsView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.jobResultsGrid = new DevExpress.XtraGrid.GridControl();
            this.jobResultsView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.resultsLabel = new DevExpress.XtraEditors.LabelControl();
            this.previewDocumentButton = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.resultInfoGrid = new DevExpress.XtraGrid.GridControl();
            this.resultInfoView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduledJobName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobLogsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobLogsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobResultsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobResultsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultInfoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultInfoView)).BeginInit();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(16, 25);
            this.id.Name = "id";
            this.id.Properties.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(52, 20);
            this.id.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(16, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Id";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Name";
            // 
            // scheduledJobName
            // 
            this.scheduledJobName.Location = new System.Drawing.Point(87, 25);
            this.scheduledJobName.Name = "scheduledJobName";
            this.scheduledJobName.Properties.ReadOnly = true;
            this.scheduledJobName.Size = new System.Drawing.Size(363, 20);
            this.scheduledJobName.TabIndex = 23;
            // 
            // logsLabel
            // 
            this.logsLabel.Location = new System.Drawing.Point(16, 56);
            this.logsLabel.Name = "logsLabel";
            this.logsLabel.Size = new System.Drawing.Size(22, 13);
            this.logsLabel.TabIndex = 27;
            this.logsLabel.Text = "Logs";
            // 
            // jobLogsGrid
            // 
            this.jobLogsGrid.Location = new System.Drawing.Point(16, 72);
            this.jobLogsGrid.MainView = this.jobLogsView;
            this.jobLogsGrid.Name = "jobLogsGrid";
            this.jobLogsGrid.Size = new System.Drawing.Size(434, 153);
            this.jobLogsGrid.TabIndex = 28;
            this.jobLogsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.jobLogsView});
            // 
            // jobLogsView
            // 
            this.jobLogsView.GridControl = this.jobLogsGrid;
            this.jobLogsView.Name = "jobLogsView";
            this.jobLogsView.OptionsBehavior.Editable = false;
            this.jobLogsView.OptionsView.ShowGroupPanel = false;
            this.jobLogsView.OptionsView.ShowIndicator = false;
            this.jobLogsView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.jobLogsView_FocusedRowChanged);
            // 
            // jobResultsGrid
            // 
            this.jobResultsGrid.Location = new System.Drawing.Point(16, 253);
            this.jobResultsGrid.MainView = this.jobResultsView;
            this.jobResultsGrid.Name = "jobResultsGrid";
            this.jobResultsGrid.Size = new System.Drawing.Size(434, 153);
            this.jobResultsGrid.TabIndex = 30;
            this.jobResultsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.jobResultsView});
            // 
            // jobResultsView
            // 
            this.jobResultsView.GridControl = this.jobResultsGrid;
            this.jobResultsView.Name = "jobResultsView";
            this.jobResultsView.OptionsBehavior.Editable = false;
            this.jobResultsView.OptionsView.ShowGroupPanel = false;
            this.jobResultsView.OptionsView.ShowIndicator = false;
            this.jobResultsView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.jobResultsView_FocusedRowChanged);
            // 
            // resultsLabel
            // 
            this.resultsLabel.Location = new System.Drawing.Point(16, 237);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(35, 13);
            this.resultsLabel.TabIndex = 29;
            this.resultsLabel.Text = "Results";
            // 
            // previewDocumentButton
            // 
            this.previewDocumentButton.Enabled = false;
            this.previewDocumentButton.Location = new System.Drawing.Point(375, 523);
            this.previewDocumentButton.Name = "previewDocumentButton";
            this.previewDocumentButton.Size = new System.Drawing.Size(75, 23);
            this.previewDocumentButton.TabIndex = 31;
            this.previewDocumentButton.Text = "Preview";
            this.previewDocumentButton.Click += new System.EventHandler(this.previewDocumentButton_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Result Info";
            // 
            // resultInfoGrid
            // 
            this.resultInfoGrid.Location = new System.Drawing.Point(16, 432);
            this.resultInfoGrid.MainView = this.resultInfoView;
            this.resultInfoGrid.Name = "resultInfoGrid";
            this.resultInfoGrid.Size = new System.Drawing.Size(434, 75);
            this.resultInfoGrid.TabIndex = 34;
            this.resultInfoGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.resultInfoView});
            // 
            // resultInfoView
            // 
            this.resultInfoView.GridControl = this.resultInfoGrid;
            this.resultInfoView.Name = "resultInfoView";
            this.resultInfoView.OptionsBehavior.Editable = false;
            this.resultInfoView.OptionsView.ColumnAutoWidth = false;
            this.resultInfoView.OptionsView.ShowColumnHeaders = false;
            this.resultInfoView.OptionsView.ShowGroupPanel = false;
            this.resultInfoView.OptionsView.ShowIndicator = false;
            // 
            // SchedulerJobResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 558);
            this.Controls.Add(this.resultInfoGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.previewDocumentButton);
            this.Controls.Add(this.jobResultsGrid);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.jobLogsGrid);
            this.Controls.Add(this.logsLabel);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scheduledJobName);
            this.Name = "SchedulerJobResultsForm";
            this.Text = "Scheduler Job Results";
            this.Load += new System.EventHandler(this.SchedulerJobResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduledJobName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobLogsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobLogsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobResultsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobResultsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultInfoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultInfoView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextEdit id;
        private LabelControl label9;
        private LabelControl label1;
        private TextEdit scheduledJobName;
        private LabelControl logsLabel;
        private GridControl jobLogsGrid;
        private GridControl jobResultsGrid;
        private LabelControl resultsLabel;
        private SimpleButton previewDocumentButton;
        private LabelControl label3;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraGrid.Views.Grid.GridView jobLogsView;
        private DevExpress.XtraGrid.Views.Grid.GridView jobResultsView;
        private GridControl resultInfoGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView resultInfoView;
    }
}