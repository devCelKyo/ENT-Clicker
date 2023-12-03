using System.Windows.Forms;

namespace Autoclicker.Model
{
    internal class CursorRecording
    {
        static bool recording = false;

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
            }
        }
    }
}
