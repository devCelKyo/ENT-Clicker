using System.Drawing;

namespace Autoclicker
{
    internal class DataModel
    {
        private static DataModel instance;

        public Point savedPoint;
        public BindingsDataModel bindingsDataModel;

        private DataModel()
        {
            bindingsDataModel = BindingsDataModel.getInstance();
        }

        public static DataModel getInstance()
        {
            if (instance == null)
            {
                instance = new DataModel();
            }
            return instance;
        }
    }
}
