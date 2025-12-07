using Tyuiu.PrilukovDA.Sprint3.Task7.V6.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнил: Прилуков Д.А. | НТм-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #6                                                              *");
Console.WriteLine("* Выполнил: Прилуков Денис Алексеевич | НТм-24-1                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("*Написать консольную программу на C#                                      *");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("*                                                                         *");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите startValue: ");
int startValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите stopValue: ");
int stopValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

double[] result = ds.GetMassFunction(startValue, stopValue);

Console.WriteLine("Массив значений функции:");
for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine($"F({startValue + i}) = {result[i]}");
}

// Или в одну строку:
Console.WriteLine("[" + string.Join("; ", result) + "]");
