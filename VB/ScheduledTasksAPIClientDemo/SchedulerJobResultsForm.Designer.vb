Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Namespace ScheduledTasksAPIClientDemo
    Partial Public Class SchedulerJobResultsForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.id = New DevExpress.XtraEditors.TextEdit()
            Me.splashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.ScheduledTasksAPIClientDemo.WaitForm1), True, True)
            Me.label9 = New DevExpress.XtraEditors.LabelControl()
            Me.label1 = New DevExpress.XtraEditors.LabelControl()
            Me.scheduledJobName = New DevExpress.XtraEditors.TextEdit()
            Me.logsLabel = New DevExpress.XtraEditors.LabelControl()
            Me.jobLogsGrid = New DevExpress.XtraGrid.GridControl()
            Me.jobLogsView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.jobResultsGrid = New DevExpress.XtraGrid.GridControl()
            Me.jobResultsView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.resultsLabel = New DevExpress.XtraEditors.LabelControl()
            Me.previewDocumentButton = New DevExpress.XtraEditors.SimpleButton()
            Me.label3 = New DevExpress.XtraEditors.LabelControl()
            Me.resultInfoGrid = New DevExpress.XtraGrid.GridControl()
            Me.resultInfoView = New DevExpress.XtraGrid.Views.Grid.GridView()
            CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.scheduledJobName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.jobLogsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.jobLogsView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.jobResultsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.jobResultsView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.resultInfoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.resultInfoView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' id
            ' 
            Me.id.Location = New System.Drawing.Point(16, 25)
            Me.id.Name = "id"
            Me.id.Properties.ReadOnly = True
            Me.id.Size = New System.Drawing.Size(52, 20)
            Me.id.TabIndex = 26
            ' 
            ' label9
            ' 
            Me.label9.Location = New System.Drawing.Point(16, 9)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(10, 13)
            Me.label9.TabIndex = 25
            Me.label9.Text = "Id"
            ' 
            ' label1
            ' 
            Me.label1.Location = New System.Drawing.Point(84, 9)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(27, 13)
            Me.label1.TabIndex = 24
            Me.label1.Text = "Name"
            ' 
            ' scheduledJobName
            ' 
            Me.scheduledJobName.Location = New System.Drawing.Point(87, 25)
            Me.scheduledJobName.Name = "scheduledJobName"
            Me.scheduledJobName.Properties.ReadOnly = True
            Me.scheduledJobName.Size = New System.Drawing.Size(363, 20)
            Me.scheduledJobName.TabIndex = 23
            ' 
            ' logsLabel
            ' 
            Me.logsLabel.Location = New System.Drawing.Point(16, 56)
            Me.logsLabel.Name = "logsLabel"
            Me.logsLabel.Size = New System.Drawing.Size(22, 13)
            Me.logsLabel.TabIndex = 27
            Me.logsLabel.Text = "Logs"
            ' 
            ' jobLogsGrid
            ' 
            Me.jobLogsGrid.Location = New System.Drawing.Point(16, 72)
            Me.jobLogsGrid.MainView = Me.jobLogsView
            Me.jobLogsGrid.Name = "jobLogsGrid"
            Me.jobLogsGrid.Size = New System.Drawing.Size(434, 153)
            Me.jobLogsGrid.TabIndex = 28
            Me.jobLogsGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.jobLogsView})
            ' 
            ' jobLogsView
            ' 
            Me.jobLogsView.GridControl = Me.jobLogsGrid
            Me.jobLogsView.Name = "jobLogsView"
            Me.jobLogsView.OptionsBehavior.Editable = False
            Me.jobLogsView.OptionsView.ShowGroupPanel = False
            Me.jobLogsView.OptionsView.ShowIndicator = False
            ' 
            ' jobResultsGrid
            ' 
            Me.jobResultsGrid.Location = New System.Drawing.Point(16, 253)
            Me.jobResultsGrid.MainView = Me.jobResultsView
            Me.jobResultsGrid.Name = "jobResultsGrid"
            Me.jobResultsGrid.Size = New System.Drawing.Size(434, 153)
            Me.jobResultsGrid.TabIndex = 30
            Me.jobResultsGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.jobResultsView})
            ' 
            ' jobResultsView
            ' 
            Me.jobResultsView.GridControl = Me.jobResultsGrid
            Me.jobResultsView.Name = "jobResultsView"
            Me.jobResultsView.OptionsBehavior.Editable = False
            Me.jobResultsView.OptionsView.ShowGroupPanel = False
            Me.jobResultsView.OptionsView.ShowIndicator = False
            ' 
            ' resultsLabel
            ' 
            Me.resultsLabel.Location = New System.Drawing.Point(16, 237)
            Me.resultsLabel.Name = "resultsLabel"
            Me.resultsLabel.Size = New System.Drawing.Size(35, 13)
            Me.resultsLabel.TabIndex = 29
            Me.resultsLabel.Text = "Results"
            ' 
            ' previewDocumentButton
            ' 
            Me.previewDocumentButton.Enabled = False
            Me.previewDocumentButton.Location = New System.Drawing.Point(375, 523)
            Me.previewDocumentButton.Name = "previewDocumentButton"
            Me.previewDocumentButton.Size = New System.Drawing.Size(75, 23)
            Me.previewDocumentButton.TabIndex = 31
            Me.previewDocumentButton.Text = "Preview"
            ' 
            ' label3
            ' 
            Me.label3.Location = New System.Drawing.Point(16, 420)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(53, 13)
            Me.label3.TabIndex = 33
            Me.label3.Text = "Result Info"
            ' 
            ' resultInfoGrid
            ' 
            Me.resultInfoGrid.Location = New System.Drawing.Point(16, 432)
            Me.resultInfoGrid.MainView = Me.resultInfoView
            Me.resultInfoGrid.Name = "resultInfoGrid"
            Me.resultInfoGrid.Size = New System.Drawing.Size(434, 75)
            Me.resultInfoGrid.TabIndex = 34
            Me.resultInfoGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.resultInfoView})
            ' 
            ' resultInfoView
            ' 
            Me.resultInfoView.GridControl = Me.resultInfoGrid
            Me.resultInfoView.Name = "resultInfoView"
            Me.resultInfoView.OptionsBehavior.Editable = False
            Me.resultInfoView.OptionsView.ColumnAutoWidth = False
            Me.resultInfoView.OptionsView.ShowColumnHeaders = False
            Me.resultInfoView.OptionsView.ShowGroupPanel = False
            Me.resultInfoView.OptionsView.ShowIndicator = False
            ' 
            ' SchedulerJobResultsForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(467, 558)
            Me.Controls.Add(Me.resultInfoGrid)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.previewDocumentButton)
            Me.Controls.Add(Me.jobResultsGrid)
            Me.Controls.Add(Me.resultsLabel)
            Me.Controls.Add(Me.jobLogsGrid)
            Me.Controls.Add(Me.logsLabel)
            Me.Controls.Add(Me.id)
            Me.Controls.Add(Me.label9)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.scheduledJobName)
            Me.Name = "SchedulerJobResultsForm"
            Me.Text = "Scheduler Job Results"
            CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.scheduledJobName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.jobLogsGrid, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.jobLogsView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.jobResultsGrid, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.jobResultsView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.resultInfoGrid, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.resultInfoView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private id As TextEdit
        Private label9 As LabelControl
        Private label1 As LabelControl
        Private scheduledJobName As TextEdit
        Private logsLabel As LabelControl
        Private jobLogsGrid As GridControl
        Private jobResultsGrid As GridControl
        Private resultsLabel As LabelControl
        Private WithEvents previewDocumentButton As SimpleButton
        Private label3 As LabelControl
        Private splashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
        Private WithEvents jobLogsView As DevExpress.XtraGrid.Views.Grid.GridView
        Private WithEvents jobResultsView As DevExpress.XtraGrid.Views.Grid.GridView
        Private resultInfoGrid As GridControl
        Private resultInfoView As DevExpress.XtraGrid.Views.Grid.GridView
    End Class
End Namespace