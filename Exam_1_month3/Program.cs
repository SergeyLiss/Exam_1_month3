// Итоговая проверочная работа
using System.Linq;

string[] SetInitial = new string[]{"roof", ";)", "to", "for", "street", "home", "count", "str", "42"};

string[] ArraySample(string[] Array, int max = 3)
{
    return Array.Where(i => i.Length <= max).ToArray();
}

void PrintArray(string[] Array)
{
    foreach(string i in Array)
    {
        Console.Write($"{i}\t");
    }
    Console.WriteLine();
}


string[] SetFinal = ArraySample(SetInitial);
PrintArray(SetInitial);
PrintArray(SetFinal);

