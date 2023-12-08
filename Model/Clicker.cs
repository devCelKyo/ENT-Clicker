using System;
using System.Threading;

namespace Autoclicker.Model
{
    public class Clicker
    {
        private static bool clicking = false;

        public static void startClicking()
        {
            clicking = !clicking;
        }
    }
}
