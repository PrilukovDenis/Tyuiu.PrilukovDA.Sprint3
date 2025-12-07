using Tyuiu.PrilukovDA.Sprint3.Task3.V10.Lib;

DataService ds = new DataService();

Console.Write("Введите строку ");
string value = Convert.ToString(Console.ReadLine());

Console.Write("Введите символ ");
char chr = Convert.ToChar(Console.ReadLine());

Console.Write(ds.DeleteCharInString(value, chr));