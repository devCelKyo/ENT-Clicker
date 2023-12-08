using System.Collections.Generic;
using System.Windows.Forms;

namespace Autoclicker.Model
{
    internal class CursorRecording
    {
        static bool recording = false;
        static List<ICoordinatesListener> listeners = new List<ICoordinatesListener> { MainWindow.getInstance() };

        static public void startRecording()
        {
            if (!recording)
            {
                recording = true;
            }
        }

        static public void stopRecording()
        {
            if (recording)
            {
                recording = false;
                DataModel.getInstance().savedPoint = Cursor.Position;
                notifyListeners();
            }
        }

        static private void notifyListeners()
        {
            foreach (var listener in listeners)
            {
                listener.onCoordinatesChanged();
            }
        }
    }
}
