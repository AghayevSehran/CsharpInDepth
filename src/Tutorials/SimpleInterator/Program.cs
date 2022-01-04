// See https://aka.ms/new-console-template for more information
using SimpleInterator;

Console.WriteLine("Hello, World!");
/*
foreach (var item in IteratorClass.CreateSimpleIterator())
{
    Console.WriteLine(item);
}
*/

IEnumerable<int> enumerable = IteratorClass.CreateSimpleIterator();
using (IEnumerator<int> enumerator = enumerable.GetEnumerator())
{
    while (enumerator.MoveNext())
    {
        int value = enumerator.Current;
        Console.WriteLine(value);
    }
}