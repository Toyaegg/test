using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace test
{
    class MyTimer : Timer
    {
        private int repeatMax;
        private int repeatNow = 0;
        private int timerID;
        private int bindPara;
        private bool isBind = false;
        private bool autoClose;
        private bool autoStart;

        public bool AutoClose
        {
            get
            {
                return autoClose;
            }
            set
            {
                autoClose = value;
            }
        }
        public bool AutoStart
        {
            get
            {
                return autoStart;
            }
            set
            {
                autoStart = value;
            }
        }

        internal delegate void MyEventHandler(int timerID, int bindPara);

        public event MyEventHandler myEventHandler;

        public MyTimer()
        {

        }

        public MyTimer(bool autoStart, bool autoClose)
        {
            this.autoStart = autoStart;
            this.autoClose = autoClose;
        }

        public void SetTimer(int timerID, int elapse, int repeat, int bindPara)
        {
            ClearTimer();
            BindElapse();
            repeatMax = repeat;
            Interval = elapse;
            this.timerID = timerID;
            this.bindPara = bindPara;
            if (autoStart)
            {
                StartTimer();
            }
        }

        private void BindElapse()
        {
            isBind = true;
            Elapsed += MyEvent;
        }

        private void ClearTimer()
        {
            if(isBind)
            {
                Elapsed -= MyEvent;
                isBind = false;
            }
        }

        public void MyEvent(object sender, ElapsedEventArgs e)
        {
            repeatNow++;
            myEventHandler(timerID, bindPara);
            if (repeatNow >= repeatMax)
            {
                StopTimer();
                if (autoClose)
                {
                    CloseTimer();
                }
            }
        }

        public void StartTimer()
        {
            Enabled = true;
        }

        public void StopTimer()
        {
            Enabled = false;
        }

        public void DisposeTimer()
        {
            Dispose();
        }

        public void CloseTimer()
        {
            Close();
        }
    }
}

