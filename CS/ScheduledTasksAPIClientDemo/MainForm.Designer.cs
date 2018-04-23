
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
namespace ScheduledTasksAPIClientDemo
{
    partial class MainForm
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
            this.showScheduledJobButton = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ScheduledTasksAPIClientDemo.WaitForm1), true, true);
            this.scheduledJobsGrid = new DevExpress.XtraGrid.GridControl();
            this.scheduledJobsView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.showScheduledJobResultsButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.scheduledJobsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduledJobsView)).BeginInit();
            this.SuspendLayout();
            // 
            // showScheduledJobButton
            // 
            this.showScheduledJobButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.showScheduledJobButton.Enabled = false;
            this.showScheduledJobButton.Location = new System.Drawing.Point(150, 350);
            this.showScheduledJobButton.Name = "showScheduledJobButton";
            this.showScheduledJobButton.Size = new System.Drawing.Size(196, 23);
            this.showScheduledJobButton.TabIndex = 0;
            this.showScheduledJobButton.Text = "Show Scheduled Task Parameters";
            this.showScheduledJobButton.Click += new System.EventHandler(this.showScheduledJobButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Available scheduled tasks";
            // 
            // scheduledJobsGrid
            // 
            this.scheduledJobsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scheduledJobsGrid.Location = new System.Drawing.Point(15, 25);
            this.scheduledJobsGrid.MainView = this.scheduledJobsView;
            this.scheduledJobsGrid.Name = "scheduledJobsGrid";
            this.scheduledJobsGrid.Size = new System.Drawing.Size(550, 305);
            this.scheduledJobsGrid.TabIndex = 5;
            this.scheduledJobsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.scheduledJobsView});
            // 
            // scheduledJobsView
            // 
            this.scheduledJobsView.GridControl = this.scheduledJobsGrid;
            this.scheduledJobsView.Name = "scheduledJobsView";
            this.scheduledJobsView.OptionsBehavior.Editable = false;
            this.scheduledJobsView.OptionsView.BestFitUseErrorInfo = DevExpress.Utils.DefaultBoolean.True;
            this.scheduledJobsView.OptionsView.ShowGroupPanel = false;
            this.scheduledJobsView.OptionsView.ShowIndicator = false;
            this.scheduledJobsView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.scheduledJobsView_FocusedRowChanged);
            // 
            // showScheduledJobResultsButton
            // 
            this.showScheduledJobResultsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.showScheduledJobResultsButton.Enabled = false;
            this.showScheduledJobResultsButton.Location = new System.Drawing.Point(369, 350);
            this.showScheduledJobResultsButton.Name = "showScheduledJobResultsButton";
            this.showScheduledJobResultsButton.Size = new System.Drawing.Size(196, 23);
            this.showScheduledJobResultsButton.TabIndex = 4;
            this.showScheduledJobResultsButton.Text = "Show Scheduled Task Results";
            this.showScheduledJobResultsButton.Click += new System.EventHandler(this.showScheduledJobResultsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 385);
            this.Controls.Add(this.showScheduledJobResultsButton);
            this.Controls.Add(this.scheduledJobsGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showScheduledJobButton);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scheduledJobsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduledJobsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SimpleButton showScheduledJobButton;
        private LabelControl label1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private GridControl scheduledJobsGrid;
        private SimpleButton showScheduledJobResultsButton;
        private GridView scheduledJobsView;
    }
}

