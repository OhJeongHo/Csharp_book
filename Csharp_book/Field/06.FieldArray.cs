using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 필드에는 변수, 배열 등 데이터 구조가 올 수 있다.
class Schedule
{
    // 필드에 배열 사용
    private string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

    public void PrintWeekDays()
    {
        foreach (var day in weekDays)
        {
            Console.Write($"{day}\t");
        }
        Console.WriteLine();
    }
}

class FieldArray
{
    static void Main()
    {
        Schedule schedule = new Schedule();
        schedule.PrintWeekDays();
    }
}