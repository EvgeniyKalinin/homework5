void RandomMass(double[] numbers)
{
for(int i = 0; i < numbers.Length; i++)
{
numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
}
}
void ArrayPrint(double[] numbers)
{
for(int i = 0; i < numbers.Length; i++)
{
Console.Write($"{numbers[i]} ");
}
Console.WriteLine();
}

try
{
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
RandomMass(array);
ArrayPrint(array);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < array.Length; i++)
{
if (array[i] > max)
{
max = array[i];
}
if (array[i] < min)
{
min = array[i];
}
}
Console.WriteLine($"Максимальное значение = {max}");
Console.WriteLine($"Минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {max - min}");
}
catch
{
    Console.WriteLine("Ошибка ввода! Введите целое число.");
}