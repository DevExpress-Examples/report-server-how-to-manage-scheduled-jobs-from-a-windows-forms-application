' Developer Express Code Central Example:
' How to get the list of available reports, export to PDF and display a report preview in a Windows Forms application
' 
' The sample demonstrates how to use the Report Server WCF API in a Windows Forms
' application.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E5062

' Developer Express Code Central Example:
' How to connect to a Report Server from a Windows Forms application
' 
' The sample demonstrates how to use the Report Server WCF API in a Windows Forms
' application.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E5062

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraWaitForm

Namespace ScheduledTasksAPIClientDemo
    Partial Public Class WaitForm1
        Inherits WaitForm

        Public Sub New()
            InitializeComponent()
            Me.progressPanel1.AutoHeight = True
        End Sub

        #Region "Overrides"

        Public Overrides Sub SetCaption(ByVal caption As String)
            MyBase.SetCaption(caption)
            Me.progressPanel1.Caption = caption
        End Sub
        Public Overrides Sub SetDescription(ByVal description As String)
            MyBase.SetDescription(description)
            Me.progressPanel1.Description = description
        End Sub
        Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
            MyBase.ProcessCommand(cmd, arg)
        End Sub

        #End Region
    End Class
End Namespace
