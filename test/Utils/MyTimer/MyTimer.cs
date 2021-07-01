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

        internal delegate void MyEventHandler(int timerID, int bindPara);

        public event MyEventHandler myEventHandler;

        public void SetTimer(int timerID, int elapse, int repeat, int bindPara)
        {
            Console.WriteLine("设置计时器 timerID : {0} 间隔(ms) : {1} 循环次数 : {2} 绑定参数 : {3}",
                timerID, elapse, repeat, bindPara);
            repeatMax = repeat;
            Elapsed += MyEvent;
            Interval = elapse;
            this.timerID = timerID;
            this.bindPara = bindPara;
        }

        public void MyEvent(object sender, ElapsedEventArgs e)
        {
            repeatNow++;
            Console.WriteLine("当前运行次数 : {0}次", repeatNow);
            myEventHandler(timerID, bindPara);
            if (repeatNow >= repeatMax)
            {
                Console.WriteLine("计时器结束\n停止计时器");
                StopTimer();
                Console.WriteLine("释放计时器资源");
                Dispose();
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
    }
}
