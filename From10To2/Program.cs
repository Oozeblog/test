// Перевод числа из десятичной системы счисления в двоичную
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

int des = 17;
int res = 0;
int result = 0;

if(des % 2 == 0)
{
    Console.Write("Надо подумать над этим");
}
else
{
    while(des >= 1)
    {
    
        res = (des % 2);
        des = des / 2;

        result = result*10 + res;

        Console.WriteLine("Остаток от деления - " + res + ", прибавляем остаток к числу = " + result + ", ");
    }
    
    while(result > 0)
    {
        res = 0;
        res = res*10 + result % 10;
        result = result / 10;
        Console.Write(res);
    }
}


  