using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TimersData
{
    public List<TimerData> Timerz { get; set; } = new List<TimerData>();
}
public class TimerData
{
    public string Name { get; set; }
    public DateTime Time { get; set; }
}
