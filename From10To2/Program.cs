// Перевод числа из десятичной системы счисления в двоичную
//Вариант 1: с помощью массива
/*
int x = 18;
int Res = 0;
int index = 0;
int[] b = new int[10];

while(x  >= 1)
{
    Res = (x % 2);
    b[index] = Res;
    index++;
    x = x/2;
}

for (index = (b.Length - 1); index >= 0; index--)
{
    Console.Write(b[index]);
}
*/

//Вариант 2: 
Console.Write("Введите число: ");
void From10To2( int num)
{
    int des = num;
    int res = 0;
    int result = 0;
    if(des % 2 == 0)
    {
        while(des >= 1)
        {
            res = (des % 2);
            des = des / 2;

            result = result*10 + res;
        }
        
        res = 0;
        while(result > 0)
        {
            res = res*10 + result % 10;
            result = result / 10;
        }
        res = res * 10;
        Console.WriteLine(($"Если перевести число {num} из десятичной системы счисления в двоичную, получится число {res}")); // переворачиваем число из остатков деления
    }
    else
    {
        while(des >= 1)
        {
            res = (des % 2);
            des = des / 2;

            result = result*10 + res;
        }

        res = 0;
        
        while(result > 0)
        {
            res = res*10 + result % 10;
            result = result / 10;
        }
        Console.WriteLine($"Если перевести число {num} из десятичной системы счисления в двоичную, получится число {res}");
    }
}
int num = Convert.ToInt32(Console.ReadLine());

From10To2(num);

