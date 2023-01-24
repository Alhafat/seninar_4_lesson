// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void FillArray(int[] nums) 
{
    int len=nums.Length;
    int index=0;
    while (index<len)
    {
        nums[index]=new Random().Next(0,2); //добавляет случайные элементы в массив
        index++;
    }
}


void PrintArray(int[] col)
{
    int count=col.Length;
    int position=0;
    while (position<count)
    {
        col[position]=new Random().Next(0,2);
        Console.WriteLine(col[position]);
        position++;
    }
}


Console.Write("Введите number: ");
int number = int.Parse(Console.ReadLine()!);
int[] numbers=new int[number]; //определяет массив из number элементов

FillArray(numbers); //заполняет массив
PrintArray(numbers); //выводит(печатает массив)
Console.WriteLine(String.Join(", ", numbers));