using System;
using System.Windows.Forms;

namespace Autoclicker.Model
{
    public class Clicker
    {
        private static Timer timer = new Timer();
        private static bool clicking = false;

        private static bool timerInitialized = false;

        public static void switchClicking()
        {
            if (!timerInitialized)
            {
                initializeTimer();
            }

            clicking = !clicking;
            if (clicking)
            {
                startClicking();
            }
            else
            {
                stopClicking();
            }
        }

        private static void startClicking()
        {
            Console.WriteLine("Clicking started");
            timer.Start();
        }
        
        private static void stopClicking()
        {
            Console.WriteLine("Clicking stopped");
            timer.Stop();
        }

        private static void TimerEventProcessor(object sender, EventArgs args)
        {
            Console.WriteLine("Click!");
            var model = DataModel.getInstance();
            LowLevelClickHandler.click(model.savedPoint.X, model.savedPoint.Y);
        }

        private static void initializeTimer()
        {
            timerInitialized = true;
            timer.Tick += new EventHandler(TimerEventProcessor);
            timer.Interval = 1000;
        }
    }
}
