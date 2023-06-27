Console.Clear();
Console.Write("Enter the numbers?: ");
int M = Convert.ToInt32(Console.ReadLine());
int Count = 0;
for (int i = 0; i < M; i++)
{
    Console.WriteLine($"Enter {i+1} number");
    int m = Convert.ToInt32(Console.ReadLine());
    if (m > 0)
    {
        Count = Count + 1;
    }
}
Console.WriteLine($"Numbers greater than 0 {Count}");