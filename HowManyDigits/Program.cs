// Программа получает от пользователя число, выдаёт количество цифр в числе (работает до 10 знаков).

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digits = 0; 

while (number > 0)
{
  digits++;
  number = (number/10);
}

Console.WriteLine($"В этом числе {digits} цифр.");