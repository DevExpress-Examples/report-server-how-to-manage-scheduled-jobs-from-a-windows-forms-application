Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Namespace ScheduledTasksAPIClientDemo
    Partial Public Class MainForm
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
            Me.showScheduledJobButton = New DevExpress.XtraEditors.SimpleButton()
            Me.label1 = New DevExpress.XtraEditors.LabelControl()
            Me.splashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.ScheduledTasksAPIClientDemo.WaitForm1), True, True)
            Me.scheduledJobsGrid = New DevExpress.XtraGrid.GridControl()
            Me.scheduledJobsView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.showScheduledJobResultsButton = New DevExpress.XtraEditors.SimpleButton()
            CType(Me.scheduledJobsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.scheduledJobsView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' showScheduledJobButton
            ' 
            Me.showScheduledJobButton.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.showScheduledJobButton.Enabled = False
            Me.showScheduledJobButton.Location = New System.Drawing.Point(150, 350)
            Me.showScheduledJobButton.Name = "showScheduledJobButton"
            Me.showScheduledJobButton.Size = New System.Drawing.Size(196, 23)
            Me.showScheduledJobButton.TabIndex = 0
            Me.showScheduledJobButton.Text = "Show Scheduled Task Parameters"
            ' 
            ' label1
            ' 
            Me.label1.Location = New System.Drawing.Point(12, 9)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(122, 13)
            Me.label1.TabIndex = 2
            Me.label1.Text = "Available scheduled tasks"
            ' 
            ' scheduledJobsGrid
            ' 
            Me.scheduledJobsGrid.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.scheduledJobsGrid.Location = New System.Drawing.Point(15, 25)
            Me.scheduledJobsGrid.MainView = Me.scheduledJobsView
            Me.scheduledJobsGrid.Name = "scheduledJobsGrid"
            Me.scheduledJobsGrid.Size = New System.Drawing.Size(550, 305)
            Me.scheduledJobsGrid.TabIndex = 5
            Me.scheduledJobsGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.scheduledJobsView})
            ' 
            ' scheduledJobsView
            ' 
            Me.scheduledJobsView.GridControl = Me.scheduledJobsGrid
            Me.scheduledJobsView.Name = "scheduledJobsView"
            Me.scheduledJobsView.OptionsBehavior.Editable = False
            Me.scheduledJobsView.OptionsView.BestFitUseErrorInfo = DevExpress.Utils.DefaultBoolean.True
            Me.scheduledJobsView.OptionsView.ShowGroupPanel = False
            Me.scheduledJobsView.OptionsView.ShowIndicator = False
            ' 
            ' showScheduledJobResultsButton
            ' 
            Me.showScheduledJobResultsButton.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.showScheduledJobResultsButton.Enabled = False
            Me.showScheduledJobResultsButton.Location = New System.Drawing.Point(369, 350)
            Me.showScheduledJobResultsButton.Name = "showScheduledJobResultsButton"
            Me.showScheduledJobResultsButton.Size = New System.Drawing.Size(196, 23)
            Me.showScheduledJobResultsButton.TabIndex = 4
            Me.showScheduledJobResultsButton.Text = "Show Scheduled Task Results"
            ' 
            ' MainForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(578, 385)
            Me.Controls.Add(Me.showScheduledJobResultsButton)
            Me.Controls.Add(Me.scheduledJobsGrid)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.showScheduledJobButton)
            Me.Name = "MainForm"
            Me.Text = "Main Form"
            CType(Me.scheduledJobsGrid, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.scheduledJobsView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private WithEvents showScheduledJobButton As SimpleButton
        Private label1 As LabelControl
        Private splashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
        Private scheduledJobsGrid As GridControl
        Private WithEvents showScheduledJobResultsButton As SimpleButton
        Private WithEvents scheduledJobsView As GridView
    End Class
End Namespace

