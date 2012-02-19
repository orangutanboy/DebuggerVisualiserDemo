using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualStudio.DebuggerVisualizers;

namespace VisualiserDemo
{
    public partial class DemoObjectVisualiserForm : Form
    {
        private DemoObject _objectToVisualise;

        public DemoObjectVisualiserForm()
        {
            InitializeComponent();
        }

        public DemoObjectVisualiserForm(DemoObject objectToVisualise)
            : this()
        {
            _objectToVisualise = objectToVisualise;
            ShowObject();
        }

        private void ShowObject()
        {
            foreach (var i in Enumerable.Range(0, _objectToVisualise.IntArray.GetUpperBound(0)))
            {
                foreach (var j in Enumerable.Range(0, _objectToVisualise.IntArray.GetUpperBound(1)))
                {
                    arrayContents.Text += _objectToVisualise.IntArray[i, j].ToString() + '\t';
                }
                arrayContents.Text += Environment.NewLine;
            }
            colourBox.BackColor = _objectToVisualise.Colour;
        }

        private void colourBox_Click(object sender, EventArgs e)
        {
            var colordialog = new ColorDialog();
            var result = colordialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                colourBox.BackColor = colordialog.Color;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }

    public class DemoObjectVisualiser : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            var objectToVisualise = objectProvider.GetObject() as DemoObject;
            var form = new DemoObjectVisualiserForm(objectToVisualise);
            windowService.ShowDialog(form);
            if (objectProvider.IsObjectReplaceable)
            {
                objectToVisualise.Colour = form.colourBox.BackColor;
                objectProvider.ReplaceObject(objectToVisualise);
            }
        }
    }
}
