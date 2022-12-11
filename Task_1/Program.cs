void RandomMass(int[] numbers)
{
for (int i = 0; i < numbers.Length; i++)
{
numbers[i] = new Random().Next(100, 1000);
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
void EvenNumbers(int[] numbers)
{
int count = 0;

for (int j = 0; j < numbers.Length; j++)
if (numbers[j] % 2 == 0)
count++;

Console.WriteLine($"В массиве {count} четных чисел.");
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
EvenNumbers(numbers);
}
catch
{
    Console.WriteLine("Ошибка ввода! Введите целое число.");
}