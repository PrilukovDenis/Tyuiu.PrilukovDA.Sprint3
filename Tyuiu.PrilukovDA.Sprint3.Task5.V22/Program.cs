using Tyuiu.PrilukovDA.Sprint3.Task5.V22.Lib;

DataService ds = new DataService();

Console.Write("Введите x ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите startValue1 ");
int startValue1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите startValue2 ");
int startValue2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите stopValue1 ");
int stopValue1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите stopValue2 ");
int stopValue2 = Convert.ToInt32(Console.ReadLine());

Console.Write(ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));