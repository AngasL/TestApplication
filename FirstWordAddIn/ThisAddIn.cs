﻿using System;

namespace FirstWordAddIn
{
    public partial class ThisAddIn
    {
        private TaskPaneControl taskPaneControl1;
        private Microsoft.Office.Tools.CustomTaskPane taskPaneValue;

        public Microsoft.Office.Tools.CustomTaskPane TaskPane
        {
            get
            {
                return taskPaneValue;
            }
        }

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            taskPaneControl1 = new TaskPaneControl();
            taskPaneValue = this.CustomTaskPanes.Add(
                taskPaneControl1, "MyCustomTaskPane");
            taskPaneValue.VisibleChanged +=
                new EventHandler(taskPaneValue_VisibleChanged);

            
        }

        private void taskPaneValue_VisibleChanged(object sender, System.EventArgs e)
        {
            Globals.Ribbons.ManageTaskPaneRibbon.toggleButton1.Checked =
                taskPaneValue.Visible;
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }


        #endregion
    }
}
