// Итоговая проверочная работа
using System.Linq;

string[] SetInitial = new string[]{"roof", ";)", "to", "for", "street", "home", "count", "str", "42"};

string[] ArraySample(string[] Array, int max = 3)
{
    return Array.Where(i => i.Length <= max).ToArray();
}

string[] SetFinal = ArraySample(SetInitial);



