int x = 18;
int Res = 0;

if(x == 0)
{
Console.WriteLine(Res);
}
else
{
    Res = (x % 2) + Res;
    x = x / 2;
}