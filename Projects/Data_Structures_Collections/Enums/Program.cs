using System;

using static System.Enum;






try
{

    foreach (string s in GetNames(typeof(Weekdays)))
    {

        Console.WriteLine(s);
    }


}
catch (Exception ex)
{
    Console.WriteLine(ex.Message, ex.StackTrace);
}

enum Weekdays { Monday = 5, Tuesday, Wednesday, Friday, kkkkk, kkkkkk, jjj };

