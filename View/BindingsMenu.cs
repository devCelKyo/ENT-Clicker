using System;
using System.Collections.Generic;
using System.Windows.Media;

namespace Autoclicker.View
{
    public partial class BindingsMenu : BaseWindow
    {
        List<BindingTextBox> bindingTextBoxes;

        public BindingsMenu(BindingsDataModel model)
        {
            InitializeComponent();

            retrieveTextBoxes();
            foreach (var box in bindingTextBoxes)
            {
                box.BindingModified += BindingModified;
                box.Text = model.getKey(box.bindingField).ToString();
            }
        }

        private void retrieveTextBoxes()
        {
            bindingTextBoxes = new List<BindingTextBox>();
            foreach (var control in Controls)
            {
                if (control is BindingTextBox)
                {
                    bindingTextBoxes.Add(control as BindingTextBox);
                }
            }
        }

        static void BindingModified(object sender, BindingModifiedEventArgs e)
        {
            var model = BindingsDataModel.getInstance();
            model.setKey(e.field, e.key);
        }
    }
}
