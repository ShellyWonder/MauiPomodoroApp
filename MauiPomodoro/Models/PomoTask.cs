using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MauiPomodoro.Models
{
    public class PomoTask

    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public  int Pomodoro { get; set; }
        public int ShortBreak { get; set; }
        public int LongBreak { get; set; }
        public bool IsCompleted { get; set; }
    }
}
