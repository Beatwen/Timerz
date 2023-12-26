using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

public class Timer
{
    public DateTime Time { get; set; }
    public string ClockTime
    {
        get
        {
            int day = Time.Day - 1;
            string time = $"{day:D2}:{Time.Hour:D2}:{Time.Minute:D2}:{Time.Second:D2}";
            return time;
        }
    }
    public string Name { get; set; }
    public bool isOn { get; set; } = false;
    public void Start()
    {
        Thread timerThread = new Thread(TimerThread);
        timerThread.Start();
        isOn = true;
    }
    private void TimerThread()
    {
        while (isOn)
        {
            Time = Time.AddSeconds(1);
            Thread.Sleep(1000);
        }

    }

    public void Stop()
    {
        isOn = false;
    }


}

