// Напишите программу, которая принимает на вход число A
// и выдаёт сумму чисел от 1 до A

// int GetSum(int A)
// {
//     int sum = 0;
//     if (A > 1) 
//     {
//         for (int i = 1; i <= A; i++) // i = i + 1 // i += 1
//         {
//             sum += i; // sum = sum + i
//         }
//     }

//     return sum;
// }

// Console.Write("Введите А: ");
// int n = int.Parse(Console.ReadLine()!);
// int sum = GetSum(n);
// Console.WriteLine($"{sum}");

Console.Clear();


int GetSum(int A)
{
    int sum=0;
    if (A>1)
    {
        for (int i=0; i<=A; i++)
        {
        sum+=i;
        }
    }
    return sum;
}

Console.Write("Введите число: ");
int number=int.Parse(Console.ReadLine()!);
int sum=GetSum(number);
Console.WriteLine($"{sum}");