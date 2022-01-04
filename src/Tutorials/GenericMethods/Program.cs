// See https://aka.ms/new-console-template for more information
using GenericMethods;

List<int> list = new List<int>();
list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);
list.Add(5);
List<int> list2 = Methods.CopyAtMost(list, 20);
Console.WriteLine(list2.Count);