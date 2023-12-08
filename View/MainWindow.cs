using System;
using System.Windows.Forms;
using Autoclicker.Model;
using Autoclicker.View;

namespace Autoclicker
{
    public partial class MainWindow : BaseWindow, ICoordinatesListener
    {
        private static MainWindow instance;

        DataModel model;
        KeyListener listener;

        public static MainWindow getInstance()
        {
            if (instance == null)
            {
                instance = new MainWindow();
            }
            return instance;
        }

        private MainWindow()
        {
            InitializeComponent();
            model = DataModel.getInstance();
            listener = new KeyListener(model.bindingsDataModel);
        }

        private void onBindingMenuClicked(object sender, EventArgs e)
        {
            listener.deactivate();
            var menu = new BindingsMenu(model.bindingsDataModel);
            menu.StartPosition = FormStartPosition.CenterParent;
            menu.ShowDialog();
            listener.activate();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            listener.deactivate();
        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            if (ClickingCoordinatesLabel.InvokeRequired)
            {
                var callback = new SetTextCallback(SetText);
                Invoke(callback, new object[] { text });
            }
            else
            {
                ClickingCoordinatesLabel.Text = text;
            }
        }

        public void onCoordinatesChanged()
        {
            var coordinates = DataModel.getInstance().savedPoint;
            SetText("(" + coordinates.X + ", " + coordinates.Y + ")");
        }
    }
}
