// Найти количество решений уравнения x + y + z = 12 в неотрицательных числах.
/*
int resh = 0;
for (int x = 0; x < 13; x++)
{
    for (int y = 0; y < 13; y++)
    {
        for (int z = 0; z < 13; z++)
        {
            if(x + y + z == 12)
            {
                resh++;
            }
        }
    }
}
Console.WriteLine($"У уравнения x + y + z = 12 может быть {resh} вариант решений");
*/
// Найти наибольший общий делитель двух чисел и наименьшее общее кратное

int GCD(int a, int b)  // Greatest Common Divisor
{
    int a1;
    if(a > b)
    {
        while(a % b != 0)  // Алгоритм Евклида
        {
            a1 = b;
            b = a % b;
            a = a1;
        }
    return b;
    }
    else
    {
        while(b % a != 0)
        {
            a1 = a;
            a = b % a;
            b = a1;
        }
        return a;
    }
    
}
Console.WriteLine("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());
int res = GCD(x, y);
Console.WriteLine($"Наибольшим общим делителем чисел {x} и {y} является {res}");
int lsm = (x * y) / res;
Console.WriteLine($"Наименьшим общим кратным чисел {x} и {y} является {lsm}");