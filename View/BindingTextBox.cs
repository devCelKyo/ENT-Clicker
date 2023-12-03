using System;
using System.Windows.Forms;
using WindowsInput.Events;
using WindowsInput.Events.Sources;

namespace Autoclicker
{
    public class BindingTextBox : TextBox
    {
        IKeyboardEventSource Keyboard;

        public BindingField bindingField;
        public KeyCode registeredKey;

        public event EventHandler<BindingModifiedEventArgs> BindingModified;

        public BindingTextBox(BindingField bindingField)
        {
            this.bindingField = bindingField;
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            Keyboard = WindowsInput.Capture.Global.KeyboardAsync();
            Keyboard.KeyEvent += Keyboard_KeyEvent;
        }

        private void Keyboard_KeyEvent(object sender, EventSourceEventArgs<KeyboardEvent> e)
        {
            if (e.Data.KeyDown != null)
            {
                registeredKey = e.Data.KeyDown.Key;
                Invoke(new Action(() =>
                {
                    Text = registeredKey.ToString();
                }));
            }
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            Keyboard.Dispose();

            OnBindingModified(new BindingModifiedEventArgs(bindingField, registeredKey));
        }

        protected virtual void OnBindingModified(BindingModifiedEventArgs e)
        {
            var handler = BindingModified;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }

    public enum BindingField
    {
        None,
        startRecording,
        stopRecording,
        switchClickingState
    }

    public class BindingModifiedEventArgs : EventArgs
    {
        public BindingField field;
        public KeyCode key;

        public BindingModifiedEventArgs(BindingField field, KeyCode key)
        {
            this.field = field;
            this.key = key;
        }
    }
}
