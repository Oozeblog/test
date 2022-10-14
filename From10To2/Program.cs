
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
