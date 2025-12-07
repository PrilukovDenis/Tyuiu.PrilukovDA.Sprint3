using Tyuiu.PrilukovDA.Sprint3.Task4.V10.Lib;

DataService ds = new DataService();

Console.Write("Введите начало ");
int startValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите конец ");
int stopValue = Convert.ToInt32(Console.ReadLine());

Console.Write(ds.Calculate(startValue, stopValue));