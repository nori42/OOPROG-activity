using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game.Classes
{
    static class WaitEvent
    {

        static public void Wait(int milliseconds)
        {
            var waitTimer = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            waitTimer.Interval = milliseconds;
            waitTimer.Enabled = true;
            waitTimer.Start();

            waitTimer.Tick += (s, e) =>
            {
                waitTimer.Enabled = false;
                waitTimer.Stop();
            };

            while (waitTimer.Enabled)
            {
                Application.DoEvents();
            }
        }
    }
}
