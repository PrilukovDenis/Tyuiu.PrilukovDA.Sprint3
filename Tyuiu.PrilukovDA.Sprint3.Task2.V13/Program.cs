using Tyuiu.PrilukovDA.Sprint3.Task2.V13.Lib;

Console.WriteLine("Вычисление суммы ряда");
Console.WriteLine("t = 7");

DataService ds = new DataService();

Console.Write("Введите начальное значение k (startValue): ");
int startValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите конечное значение k (stopValue): ");
int stopValue = Convert.ToInt32(Console.ReadLine());

double result = ds.GetSumSeries(7, startValue, stopValue);

Console.WriteLine($"Сумма ряда от {startValue} до {stopValue} = {result}");
