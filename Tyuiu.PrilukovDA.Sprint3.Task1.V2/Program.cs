// See https://aka.ms/new-console-template for more information

using Tyuiu.PrilukovDA.Sprint3.Task1.V2.Lib;

Console.WriteLine("Программа вычисления суммы ряда S = Σ sin(i) * 1/2");

DataService ds = new DataService();

int start = 1;
int stop = 15;

double result = ds.GetSumSeries(start, stop);

Console.WriteLine($"Сумма ряда от {start} до {stop} равна: {result}");
