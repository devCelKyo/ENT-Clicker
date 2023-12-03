using System.Collections.Generic;
using WindowsInput.Events;

namespace Autoclicker
{
    public class BindingsDataModel
    {
        private static BindingsDataModel instance;

        private Dictionary<BindingField, KeyCode> bindings;
        
        private BindingsDataModel()
        {
            bindings = new Dictionary<BindingField, KeyCode>();
            bindings.Add(BindingField.startRecording, KeyCode.None);
            bindings.Add(BindingField.stopRecording, KeyCode.None);
            bindings.Add(BindingField.switchClickingState, KeyCode.None);
        }

        public static BindingsDataModel getInstance()
        {
            if (instance == null)
            {
                instance = new BindingsDataModel();
            }
            return instance;
        }

        public void setKey(BindingField field, KeyCode key)
        {
            bindings[field] = key;
        }

        public KeyCode getKey(BindingField field)
        {
            return bindings[field];
        }

        public BindingField getTaskFromKey(KeyCode key)
        {
            foreach (var entry in bindings)
            {
                if (entry.Value.Equals(key))
                    return entry.Key;
            }
            return BindingField.None;
        }
    }
}
