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
            //Loop through each element and show its value in a table
            foreach (var i in Enumerable.Range(0, _objectToVisualise.IntArray.GetUpperBound(0)))
            {
                foreach (var j in Enumerable.Range(0, _objectToVisualise.IntArray.GetUpperBound(1)))
                {
                    arrayContents.Text += _objectToVisualise.IntArray[i, j].ToString() + '\t';
                }
                arrayContents.Text += Environment.NewLine;
            }
            //visualise the colour
            colourBox.BackColor = _objectToVisualise.Colour;
        }

        private void colourBox_Click(object sender, EventArgs e)
        {
            //When the colour is clicked, show the dialog to change it
            var colordialog = new ColorDialog();
            var result = colordialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                colourBox.BackColor = colordialog.Color;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //This form is shown modally; hiding it allows 
            //control to be handed back to the calling routine
            //while retaining it in memory
            this.Hide();
        }

    }

    /// <summary>
    /// An instance of this is created and called by the debugger
    /// </summary>
    public class DemoObjectVisualiser : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            //make sure the object is the correct type
            var objectToVisualise = objectProvider.GetObject() as DemoObject;
            
            //Show the visualiser
            var form = new DemoObjectVisualiserForm(objectToVisualise);
            windowService.ShowDialog(form);
            
            //If the object is replaceable, update the colour
            if (objectProvider.IsObjectReplaceable)
            {
                objectToVisualise.Colour = form.colourBox.BackColor;
                objectProvider.ReplaceObject(objectToVisualise);
            }
        }
    }
}
