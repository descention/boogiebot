using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.InteropServices;


namespace BenderBot.Common
{

    public class UpdateTimer
    {
        private int _last_update_time;
        private int _update_frequency;
        public int Runs { get; private set; }

        public UpdateTimer(int frequency)
        {
            _update_frequency = frequency;
            _last_update_time = Environment.TickCount;
        }


        public void SetFrequency(int frequency)
        {
            _update_frequency = frequency;
        }

        public int Update()
        {
            int diff = Environment.TickCount - _last_update_time;
            if (diff >= _update_frequency)
            {
                Runs++;
                _last_update_time = Environment.TickCount;
                return diff;
            }
            if (_last_update_time > Environment.TickCount)
            {
                // Wrap around.

                _last_update_time = Environment.TickCount;
            }

            return 0;
        }


    }

    partial class BenderCore
    {
        private static UpdateTimer heartbeat_timer = new UpdateTimer(0);

        private void Update(uint difference)
        {
            uint SleepTime = 10;
            try
            {
                if (Player == null)
                {
                    Thread.Sleep((int)SleepTime);
                    return;
                }

                if (Player.Location == null)
                {
                    Thread.Sleep((int)SleepTime);
                    return;
                }

                uint diff = 0;

                diff = (uint)heartbeat_timer.Update();

                if (diff > 0)
                {
                    SleepTime = Mover.Pulse(diff);
                }
            }
            catch (Exception) { }

            if ((int)SleepTime <= 0)
                Thread.Sleep((int)1);
            else
                Thread.Sleep((int)SleepTime);

        }
    }
}
