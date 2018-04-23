Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Namespace ScheduledTasksAPIClientDemo
    Partial Public Class SchedulerJobViewerForm
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
            Me.recurrencyInfo = New DevExpress.XtraEditors.MemoEdit()
            Me.scheduledJobName = New DevExpress.XtraEditors.TextEdit()
            Me.label1 = New DevExpress.XtraEditors.LabelControl()
            Me.scheduledJobEnabled = New DevExpress.XtraEditors.CheckEdit()
            Me.label2 = New DevExpress.XtraEditors.LabelControl()
            Me.scheduledJobStartDate = New DevExpress.XtraEditors.DateEdit()
            Me.label3 = New DevExpress.XtraEditors.LabelControl()
            Me.label4 = New DevExpress.XtraEditors.LabelControl()
            Me.label5 = New DevExpress.XtraEditors.LabelControl()
            Me.label7 = New DevExpress.XtraEditors.LabelControl()
            Me.externalSubscribers = New DevExpress.XtraEditors.MemoEdit()
            Me.label8 = New DevExpress.XtraEditors.LabelControl()
            Me.exportToSharedFolder = New DevExpress.XtraEditors.MemoEdit()
            Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
            Me.btnUpdate = New DevExpress.XtraEditors.SimpleButton()
            Me.btnCreate = New DevExpress.XtraEditors.SimpleButton()
            Me.label6 = New DevExpress.XtraEditors.LabelControl()
            Me.reportId = New DevExpress.XtraEditors.TextEdit()
            Me.label9 = New DevExpress.XtraEditors.LabelControl()
            Me.id = New DevExpress.XtraEditors.TextEdit()
            Me.btnExecute = New DevExpress.XtraEditors.SimpleButton()
            Me.reportParametersGrid = New DevExpress.XtraGrid.GridControl()
            Me.reportParametersView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.parametersBindingGrid = New DevExpress.XtraGrid.GridControl()
            Me.parametersBindingView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.recurrencyInfoGrid = New DevExpress.XtraGrid.GridControl()
            Me.recurrencyInfoView = New DevExpress.XtraGrid.Views.Grid.GridView()
            CType(Me.recurrencyInfo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.scheduledJobName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.scheduledJobEnabled.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.scheduledJobStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.scheduledJobStartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.externalSubscribers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.exportToSharedFolder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.reportId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.reportParametersGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.reportParametersView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.parametersBindingGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.parametersBindingView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.recurrencyInfoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.recurrencyInfoView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' recurrencyInfo
            ' 
            Me.recurrencyInfo.Location = New System.Drawing.Point(12, 130)
            Me.recurrencyInfo.Name = "recurrencyInfo"
            Me.recurrencyInfo.Properties.Appearance.Font = New System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.recurrencyInfo.Properties.Appearance.Options.UseFont = True
            Me.recurrencyInfo.Properties.ReadOnly = True
            Me.recurrencyInfo.Size = New System.Drawing.Size(434, 41)
            Me.recurrencyInfo.TabIndex = 0
            ' 
            ' scheduledJobName
            ' 
            Me.scheduledJobName.Location = New System.Drawing.Point(84, 24)
            Me.scheduledJobName.Name = "scheduledJobName"
            Me.scheduledJobName.Size = New System.Drawing.Size(279, 20)
            Me.scheduledJobName.TabIndex = 1
            ' 
            ' label1
            ' 
            Me.label1.Location = New System.Drawing.Point(81, 8)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(27, 13)
            Me.label1.TabIndex = 2
            Me.label1.Text = "Name"
            ' 
            ' scheduledJobEnabled
            ' 
            Me.scheduledJobEnabled.Location = New System.Drawing.Point(381, 26)
            Me.scheduledJobEnabled.Name = "scheduledJobEnabled"
            Me.scheduledJobEnabled.Properties.Caption = "Enabled"
            Me.scheduledJobEnabled.Size = New System.Drawing.Size(65, 19)
            Me.scheduledJobEnabled.TabIndex = 4
            ' 
            ' label2
            ' 
            Me.label2.Location = New System.Drawing.Point(12, 58)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(50, 13)
            Me.label2.TabIndex = 5
            Me.label2.Text = "Start Date"
            ' 
            ' scheduledJobStartDate
            ' 
            Me.scheduledJobStartDate.EditValue = New Date(2016, 9, 22, 0, 0, 0, 0)
            Me.scheduledJobStartDate.Location = New System.Drawing.Point(12, 74)
            Me.scheduledJobStartDate.Name = "scheduledJobStartDate"
            Me.scheduledJobStartDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.scheduledJobStartDate.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True
            Me.scheduledJobStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.scheduledJobStartDate.Properties.DisplayFormat.FormatString = "g"
            Me.scheduledJobStartDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.scheduledJobStartDate.Properties.EditFormat.FormatString = "g"
            Me.scheduledJobStartDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.scheduledJobStartDate.Properties.Mask.EditMask = "g"
            Me.scheduledJobStartDate.Size = New System.Drawing.Size(196, 20)
            Me.scheduledJobStartDate.TabIndex = 6
            ' 
            ' label3
            ' 
            Me.label3.Location = New System.Drawing.Point(12, 108)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(78, 13)
            Me.label3.TabIndex = 7
            Me.label3.Text = "Recurrency Info"
            ' 
            ' label4
            ' 
            Me.label4.Location = New System.Drawing.Point(12, 180)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(92, 13)
            Me.label4.TabIndex = 9
            Me.label4.Text = "Parameters Binding"
            ' 
            ' label5
            ' 
            Me.label5.Location = New System.Drawing.Point(12, 286)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(91, 13)
            Me.label5.TabIndex = 11
            Me.label5.Text = "Report Parameters"
            ' 
            ' label7
            ' 
            Me.label7.Location = New System.Drawing.Point(12, 413)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(98, 13)
            Me.label7.TabIndex = 15
            Me.label7.Text = "External Subscribers"
            ' 
            ' externalSubscribers
            ' 
            Me.externalSubscribers.Location = New System.Drawing.Point(12, 429)
            Me.externalSubscribers.Name = "externalSubscribers"
            Me.externalSubscribers.Properties.Appearance.Font = New System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.externalSubscribers.Properties.Appearance.Options.UseFont = True
            Me.externalSubscribers.Size = New System.Drawing.Size(434, 44)
            Me.externalSubscribers.TabIndex = 14
            ' 
            ' label8
            ' 
            Me.label8.Location = New System.Drawing.Point(12, 487)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(115, 13)
            Me.label8.TabIndex = 17
            Me.label8.Text = "Export to Shared Folder"
            ' 
            ' exportToSharedFolder
            ' 
            Me.exportToSharedFolder.Location = New System.Drawing.Point(12, 503)
            Me.exportToSharedFolder.Name = "exportToSharedFolder"
            Me.exportToSharedFolder.Properties.Appearance.Font = New System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.exportToSharedFolder.Properties.Appearance.Options.UseFont = True
            Me.exportToSharedFolder.Size = New System.Drawing.Size(434, 42)
            Me.exportToSharedFolder.TabIndex = 16
            ' 
            ' btnDelete
            ' 
            Me.btnDelete.Location = New System.Drawing.Point(244, 580)
            Me.btnDelete.Name = "btnDelete"
            Me.btnDelete.Size = New System.Drawing.Size(84, 23)
            Me.btnDelete.TabIndex = 0
            Me.btnDelete.Text = "Delete task"
            ' 
            ' btnUpdate
            ' 
            Me.btnUpdate.Location = New System.Drawing.Point(128, 580)
            Me.btnUpdate.Name = "btnUpdate"
            Me.btnUpdate.Size = New System.Drawing.Size(84, 23)
            Me.btnUpdate.TabIndex = 1
            Me.btnUpdate.Text = "Update task"
            ' 
            ' btnCreate
            ' 
            Me.btnCreate.Location = New System.Drawing.Point(12, 580)
            Me.btnCreate.Name = "btnCreate"
            Me.btnCreate.Size = New System.Drawing.Size(84, 23)
            Me.btnCreate.TabIndex = 18
            Me.btnCreate.Text = "Create task"
            ' 
            ' label6
            ' 
            Me.label6.Location = New System.Drawing.Point(260, 58)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(46, 13)
            Me.label6.TabIndex = 20
            Me.label6.Text = "Report Id"
            ' 
            ' reportId
            ' 
            Me.reportId.Location = New System.Drawing.Point(260, 74)
            Me.reportId.Name = "reportId"
            Me.reportId.Size = New System.Drawing.Size(186, 20)
            Me.reportId.TabIndex = 19
            ' 
            ' label9
            ' 
            Me.label9.Location = New System.Drawing.Point(12, 8)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(10, 13)
            Me.label9.TabIndex = 21
            Me.label9.Text = "Id"
            ' 
            ' id
            ' 
            Me.id.Location = New System.Drawing.Point(12, 24)
            Me.id.Name = "id"
            Me.id.Properties.ReadOnly = True
            Me.id.Size = New System.Drawing.Size(52, 20)
            Me.id.TabIndex = 22
            ' 
            ' btnExecute
            ' 
            Me.btnExecute.Location = New System.Drawing.Point(360, 580)
            Me.btnExecute.Name = "btnExecute"
            Me.btnExecute.Size = New System.Drawing.Size(84, 23)
            Me.btnExecute.TabIndex = 23
            Me.btnExecute.Text = "Execute task"
            ' 
            ' reportParametersGrid
            ' 
            Me.reportParametersGrid.Location = New System.Drawing.Point(12, 301)
            Me.reportParametersGrid.MainView = Me.reportParametersView
            Me.reportParametersGrid.Name = "reportParametersGrid"
            Me.reportParametersGrid.Size = New System.Drawing.Size(434, 105)
            Me.reportParametersGrid.TabIndex = 24
            Me.reportParametersGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.reportParametersView})
            ' 
            ' reportParametersView
            ' 
            Me.reportParametersView.GridControl = Me.reportParametersGrid
            Me.reportParametersView.Name = "reportParametersView"
            Me.reportParametersView.OptionsBehavior.Editable = False
            Me.reportParametersView.OptionsView.ShowColumnHeaders = False
            Me.reportParametersView.OptionsView.ShowGroupPanel = False
            Me.reportParametersView.OptionsView.ShowIndicator = False
            ' 
            ' parametersBindingGrid
            ' 
            Me.parametersBindingGrid.Location = New System.Drawing.Point(12, 195)
            Me.parametersBindingGrid.MainView = Me.parametersBindingView
            Me.parametersBindingGrid.Name = "parametersBindingGrid"
            Me.parametersBindingGrid.Size = New System.Drawing.Size(434, 85)
            Me.parametersBindingGrid.TabIndex = 25
            Me.parametersBindingGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.parametersBindingView})
            ' 
            ' parametersBindingView
            ' 
            Me.parametersBindingView.GridControl = Me.parametersBindingGrid
            Me.parametersBindingView.Name = "parametersBindingView"
            Me.parametersBindingView.OptionsBehavior.Editable = False
            Me.parametersBindingView.OptionsView.ShowColumnHeaders = False
            Me.parametersBindingView.OptionsView.ShowGroupPanel = False
            Me.parametersBindingView.OptionsView.ShowIndicator = False
            ' 
            ' recurrencyInfoGrid
            ' 
            Me.recurrencyInfoGrid.Location = New System.Drawing.Point(12, 123)
            Me.recurrencyInfoGrid.MainView = Me.recurrencyInfoView
            Me.recurrencyInfoGrid.Name = "recurrencyInfoGrid"
            Me.recurrencyInfoGrid.Size = New System.Drawing.Size(434, 45)
            Me.recurrencyInfoGrid.TabIndex = 26
            Me.recurrencyInfoGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.recurrencyInfoView})
            ' 
            ' recurrencyInfoView
            ' 
            Me.recurrencyInfoView.GridControl = Me.recurrencyInfoGrid
            Me.recurrencyInfoView.Name = "recurrencyInfoView"
            Me.recurrencyInfoView.OptionsBehavior.Editable = False
            Me.recurrencyInfoView.OptionsView.ShowColumnHeaders = False
            Me.recurrencyInfoView.OptionsView.ShowGroupPanel = False
            Me.recurrencyInfoView.OptionsView.ShowIndicator = False
            ' 
            ' SchedulerJobViewerForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(463, 612)
            Me.Controls.Add(Me.recurrencyInfoGrid)
            Me.Controls.Add(Me.parametersBindingGrid)
            Me.Controls.Add(Me.reportParametersGrid)
            Me.Controls.Add(Me.btnExecute)
            Me.Controls.Add(Me.id)
            Me.Controls.Add(Me.label9)
            Me.Controls.Add(Me.label6)
            Me.Controls.Add(Me.reportId)
            Me.Controls.Add(Me.btnCreate)
            Me.Controls.Add(Me.btnUpdate)
            Me.Controls.Add(Me.btnDelete)
            Me.Controls.Add(Me.label8)
            Me.Controls.Add(Me.exportToSharedFolder)
            Me.Controls.Add(Me.label7)
            Me.Controls.Add(Me.externalSubscribers)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.scheduledJobStartDate)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.scheduledJobEnabled)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.scheduledJobName)
            Me.Controls.Add(Me.recurrencyInfo)
            Me.Name = "SchedulerJobViewerForm"
            Me.Text = "Scheduler Task Viewer"
            CType(Me.recurrencyInfo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.scheduledJobName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.scheduledJobEnabled.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.scheduledJobStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.scheduledJobStartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.externalSubscribers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.exportToSharedFolder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.reportId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.reportParametersGrid, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.reportParametersView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.parametersBindingGrid, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.parametersBindingView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.recurrencyInfoGrid, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.recurrencyInfoView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private recurrencyInfo As MemoEdit
        Private scheduledJobName As TextEdit
        Private label1 As LabelControl
        Private scheduledJobEnabled As CheckEdit
        Private label2 As LabelControl
        Private scheduledJobStartDate As DateEdit
        Private label3 As LabelControl
        Private label4 As LabelControl
        Private label5 As LabelControl
        Private label7 As LabelControl
        Private externalSubscribers As MemoEdit
        Private label8 As LabelControl
        Private exportToSharedFolder As MemoEdit
        Private WithEvents btnDelete As SimpleButton
        Private WithEvents btnUpdate As SimpleButton
        Private WithEvents btnCreate As SimpleButton
        Private label6 As LabelControl
        Private reportId As TextEdit
        Private label9 As LabelControl
        Private id As TextEdit
        Private WithEvents btnExecute As SimpleButton
        Private reportParametersGrid As GridControl
        Private reportParametersView As GridView
        Private parametersBindingGrid As GridControl
        Private parametersBindingView As GridView
        Private recurrencyInfoGrid As GridControl
        Private recurrencyInfoView As GridView

    End Class
End Namespace