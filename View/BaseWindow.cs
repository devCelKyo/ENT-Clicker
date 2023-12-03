using System.Drawing;
using System.Windows.Forms;

namespace Autoclicker.View
{
    public partial class BaseWindow : Form
    {
        public BaseWindow()
        {
            InitializeComponent();
        }

        // Dragging window
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void DraggablePart_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void DraggablePart_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void DraggablePart_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        //
    }
}
