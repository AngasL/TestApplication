using System;
using System.Windows.Forms;

namespace FirstWordAddIn
{
    public partial class TaskPaneControl : UserControl
    {
        public TaskPaneControl()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currRange = Globals.ThisAddIn.Application.Selection.Range;
            var text = ((ComboBox)sender).SelectedItem.ToString();

            currRange.Text = text;
        }
    }
}
