using WindowsInput.Events;

namespace Autoclicker.Model
{
    internal class BindingDelegator
    {
        static public void delegateTask(KeyCode key)
        {
            var model = BindingsDataModel.getInstance();
            BindingField task = model.getTaskFromKey(key);

            if (task != BindingField.None)
            {
                switch (task)
                {
                    case BindingField.startRecording:
                        CursorRecording.startRecording();
                        break;
                    case BindingField.stopRecording:
                        CursorRecording.stopRecording();
                        break;
                    case BindingField.switchClickingState:
                        Clicker.switchClicking();
                        break;
                }
            }
        }
    }
}
