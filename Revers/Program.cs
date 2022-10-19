//Написать программу "разворота" числа:
/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = number;
int digits = 0; // кол-во цифр
while (number2 > 0)
{
  digits++;
  number2 = (number2/10);
}

int result = 0;
int index = 0;

while(index < digits)
{

    result = result*10 + number % 10;
    number = number / 10;
    index++;
}
Console.WriteLine(result + " осталось от числа " + number );
*/


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;

while(number > 0)
{
    result = result*10 + number % 10;
    number = number / 10;
}

Console.WriteLine(result);