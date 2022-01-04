// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;
using TowardToLinq;

Console.WriteLine("Hello, World!");
var order = new Order
{
    OrderId = "sqw",
    Customer = new Customer
    {
        Name = "Jon",
        Address = "Uk"
    },
    Items =
    {
    new OrderItem{ ItemId="12121",Quantity=1},
    new OrderItem{ ItemId="12344",Quantity=2},
     }
};

Console.WriteLine(order.OrderId);

var palyer = new
{
    Name = "S"
};
Console.WriteLine(palyer.Name);

/// <summary>
/// Variable capturee
/// </summary>
var actions = LambdaCapturingVariable.CreateActions();
foreach (var action in actions)
{
    action();
}

//Expresion trees 

Expression<Func<int, int, int>> adder = (x, y) => x + y;
Console.WriteLine(adder);

string[] words = { "kesys", "coat", "laptop", "bottle" };
IEnumerable<string> query = words
    .Where(word => word.Length > 4)
    .OrderBy(word => word)
    .Select(word => word.ToUpper());
foreach (string word in query)
{
    Console.WriteLine(word);
}
//Introductory query expression
IEnumerable<string> queryExpretion = from word in words
                                     where word.Length > 4
                                     orderby word
                                     select word.ToUpper();

foreach (string word in queryExpretion)
{
    Console.WriteLine(word);
}

//Range variables
var queryExpretion1 = from word in words
                      let l = word.Length
                      where l > 4
                      orderby l
                      select string.Format("{0} : {1}", l, word.ToUpper());
foreach (string word in queryExpretion1)
{
    Console.WriteLine(word);
}