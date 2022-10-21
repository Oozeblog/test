bool DayWeek(int dayNum)
{
    if(dayNum == 6 || dayNum == 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("Введите цифру соответствующую дню недели(от 1 до 7): ");
var tostring = Console.ReadLine();

    if (int.TryParse(tostring, out var num))
    {
        if(num > 7)
        {
            Console.WriteLine ("Эта цифра не соотвтствует дню недели!");
        }
        else
        {
            bool result = DayWeek(num);
            Console.Write("Этот день является выходным - ");
            Console.WriteLine(result);
        }
    }
    else
    {
        Console.WriteLine("Некорректный ввод");
    }

