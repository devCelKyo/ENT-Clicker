using System;
using System.Windows.Forms;
using Autoclicker.View;

namespace Autoclicker
{
    public partial class MainWindow : BaseWindow
    {
        DataModel model;
        KeyListener listener;

        public MainWindow()
        {
            InitializeComponent();
            model = DataModel.getInstance();
            listener = new KeyListener(model.bindingsDataModel);
        }

        private void onBindingMenuClicked(object sender, EventArgs e)
        {
            listener.deactivate();
            var menu = new BindingsMenu(model.bindingsDataModel);
            menu.ShowDialog();
            listener.activate();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            listener.deactivate();
        }
    }
}
