// See https://aka.ms/new-console-template for more information
long sq = 1;
long sqn = 1;
while(sqn < int.MaxValue)
{
    sq++;
    sqn = sq * sq;
}

Console.WriteLine($"{(sq - 1) * (sq - 1)}");
