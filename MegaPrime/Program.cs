// See https://aka.ms/new-console-template for more information


uint n; int i;
List<uint> megaPrimeList=new List<uint>();
Console.Write("Enter the limit ");
n = uint.Parse(Console.ReadLine());
for (i = 2; i <= n; i++)
{
    if (IsPrime(i))
    {
        bool isMegaPrime;
        isMegaPrime = IsMegaPrime(i);
        if (isMegaPrime)
        {
            megaPrimeList.Add((uint)i);
        }
    }
}

if (megaPrimeList.Count == 0)
{
    Console.WriteLine("There is no megaprime numbers...");
}
else
{
    Console.Write("Mega prime numbers are....\n");
    foreach (var megaPrime in megaPrimeList)
    {
        Console.WriteLine(megaPrime);
        Console.WriteLine();

    }
}
Console.ReadLine();


bool IsPrime(int n)
{
    
    if(n==2)
    {
        return true;
    }

    int m = (int)(n / 2);
    for (int i = 2; i <= m; i++)
    {
        if (n % i == 0)
        {
            return false;
        }

    }
    return true;
}

bool IsMegaPrime(int n)
{
    int temp;
    bool isPrime = false;
    while (n != 0)
    {
        temp = (int)n % 10;
        if (temp == 1)
            return false;
        isPrime = IsPrime((int)temp);
        if (isPrime == false)
            return false;
        n /= 10;
        isPrime = true;
    }
    return isPrime;
}