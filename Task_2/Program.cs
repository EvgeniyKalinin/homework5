void RandomMass(int[] numbers)
{
for (int i = 0; i < numbers.Length; i++)
{
numbers[i] = new Random().Next(-20, 21); //Уменьшил числа для удобной проверки задания
}
}
void ArrayPrint(int[] numbers)
{
for (int i = 0; i < numbers.Length; i++)
{
Console.Write($"{numbers[i]} ");
}
Console.WriteLine();
}
void SumEvenNumbers(int[] numbers)
{
int sum = 0;

for (int j = 0; j < numbers.Length; j++)
{
if (j % 2 == 1)
{
sum = sum + numbers[j];
}

}


Console.WriteLine($"Сумма нечетных элементов массива равна {sum}.");
}
try
{
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
RandomMass(numbers);
Console.WriteLine();
ArrayPrint(numbers);
Console.WriteLine();
SumEvenNumbers(numbers);
}
catch
{
    Console.WriteLine("Ошибка ввода! Введите целое число.");
}