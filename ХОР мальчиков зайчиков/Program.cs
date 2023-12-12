Console.WriteLine("Размер массива?");
int n = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[n];

Random rnd= new Random();
int index = rnd.Next(0, n);

int count = 0;
for (int i = 0; count < mass.Length/2; i++)
{
    if (i != index)
    { 
        mass[i] = count;
        count++;
    }
    else
    { 
        i++;
        mass[i] = count;
        count++;
    }
}

count = 0;
for (int i = 0; count < mass.Length / 2; i++)
{
    if ((n - 1) - i != index)
    {
        mass[(n - 1) - i] = count;
        count++;
    }
    else
    {
        i++;
        mass[(n - 1) - i] = count;
        count++;
    }
}

mass[index] = rnd.Next(0,n);

for (int i = 0;i < mass.Length;i++)
{
    Console.Write(mass[i] + " ");
}

int res = 0;
for (int i = 0; i < mass.Length; i++)
{
    res ^= mass[i];
}
Console.WriteLine("\nБез пары: ");
Console.Write(res);