using Tyuiu.PrilukovDA.Sprint3.Task6.V9.Lib;

DataService ds = new DataService();

Console.Write("Введите startValue ");
int startValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите stopValue ");
int stopValue = Convert.ToInt32(Console.ReadLine());  

Console.Write(ds.GetSumTheDivisors(startValue, stopValue));