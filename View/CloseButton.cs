using System.Windows.Forms;

namespace Autoclicker
{
    public partial class CloseButton : UserControl
    {
        public CloseButton()
        {
            InitializeComponent();
        }

        private void onClicked(object sender, System.EventArgs e)
        {
            ((Form)Parent).Close();
        }
    }
}
