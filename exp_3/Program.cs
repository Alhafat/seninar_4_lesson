// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120



int GetProduct (int number)
{
    int Product = 1;
    if (number > 1) 
    {
        for (int i = 1; i <= number; i++) // i = i + 1 // i += 1
        {
            Product *= i; // sum = sum * i
        }
    }

    return Product ;
}

Console.Write("Введите number: ");
int number = int.Parse(Console.ReadLine()!);
int Product  = GetProduct(number);
Console.WriteLine($"{Product}");