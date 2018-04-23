// Developer Express Code Central Example:
// How to get the list of available reports, export to PDF and display a report preview in a Windows Forms application
// 
// The sample demonstrates how to use the Report Server WCF API in a Windows Forms
// application.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E5062

// Developer Express Code Central Example:
// How to connect to a Report Server from a Windows Forms application
// 
// The sample demonstrates how to use the Report Server WCF API in a Windows Forms
// application.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E5062

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraWaitForm;

namespace ScheduledTasksAPIClientDemo
{
    public partial class WaitForm1 : WaitForm
    {
        public WaitForm1()
        {
            InitializeComponent();
            this.progressPanel1.AutoHeight = true;
        }

        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            this.progressPanel1.Caption = caption;
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            this.progressPanel1.Description = description;
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion
    }
}
