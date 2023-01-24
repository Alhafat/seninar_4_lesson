// Напишите программу, которая принимает на вход число A
// и выдаёт сумму чисел от 1 до A

Console.Clear();


int GetSum(int A)                       // int GetSum(int A)
{
      int sum=0;                          //     int sum = 0;
    if (A>=1)                            //     if (A > 1) 
    {
        for (int i=0; i<=A; i++)        // for (int i = 1; i <= A; i++)
        {
        sum+=i;                         // sum += i;
        }
    }
    return sum;                         //return sum;
}

Console.Write("Введите число: ");               // Console.Write("Введите А: ");
int number=int.Parse(Console.ReadLine()!);      // int n = int.Parse(Console.ReadLine()!);
int sum=GetSum(number);                         // int sum = GetSum(n);
Console.WriteLine($"{sum}");                    // Console.WriteLine($"{sum}");