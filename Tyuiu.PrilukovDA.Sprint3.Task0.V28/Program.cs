using Tyuiu.PrilukovDA.Sprint3.Task0.V28.Lib;

Console.WriteLine("Вычисление произведения ряда:");

DataService ds = new DataService();

double x = 0.25;
int start = 1;
int stop = 17;

double result = ds.GetMultiplySeries(x, start, stop);

Console.WriteLine($"Результат: {result}");