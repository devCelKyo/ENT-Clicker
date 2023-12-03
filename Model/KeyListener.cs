using Autoclicker.Model;
using System;
using WindowsInput.Events;
using WindowsInput.Events.Sources;

namespace Autoclicker
{
    internal class KeyListener
    {
        BindingsDataModel model;
        IKeyboardEventSource Keyboard;

        bool activated = true;

        public KeyListener(BindingsDataModel model)
        {
            this.model = model;
            activate();
        }

        public void activate()
        {
            Keyboard = WindowsInput.Capture.Global.KeyboardAsync();
            activated = true;

            Keyboard.KeyDown += proceedKeyDown;
        }

        public void deactivate()
        {
            Keyboard.Dispose();
            activated = false;
        }

        private void proceedKeyDown(object sender, EventSourceEventArgs<KeyDown> e)
        {
            if (activated && e.Data != null)
            {
                BindingDelegator.delegateTask(e.Data.Key);
            }
        }
    }
}
