using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_2
{
    public delegate void TickHandler(object sendery);
    public delegate void AlarmHandler(object sender,int x,int y);
    public class Clock
    {
        public event TickHandler StartTick; 
        public event AlarmHandler StartAlarm;
        public void Start(int hour,int minute) {
            while (true) {
                System.Threading.Thread.Sleep(1000);
                StartTick(this);
                if (DateTime.Now.Hour == hour && DateTime.Now.Minute == minute&&DateTime.Now.Second==0)
                    StartAlarm(this, hour, minute);
            }
        }
    }
    public class ClockSubscriber
    {
        public Clock clock = new Clock();
        public ClockSubscriber()
        {
            clock.StartTick += Tick;
            clock.StartAlarm += Alarm;
        }
        void Tick(object sender)
        {
            Console.WriteLine("滴答");
        }
        void Alarm(object sender,int hour,int minute)
        {
            Console.WriteLine("响铃!!!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int hour, minute;
            Console.WriteLine("设置闹钟为几时？");
            hour = int.Parse(Console.ReadLine());
            Console.WriteLine("设置闹钟为几分？");
            minute = int.Parse(Console.ReadLine());
            ClockSubscriber clockSubscriber = new ClockSubscriber();
            clockSubscriber.clock.Start(hour,minute);
        }
    }

    
}
