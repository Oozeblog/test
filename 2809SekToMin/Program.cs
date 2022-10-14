// Перевод секунд в минуты. На englishе из-за окончаний :)

Console.WriteLine("Input seconds: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int Res;

Res = numberA / 60;

Console.WriteLine($"{numberA} seconds = {Res} minutes {numberA % 60} seconds");