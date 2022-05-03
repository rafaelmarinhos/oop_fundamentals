using oop_fundamentals.ContentContext;

Console.WriteLine("Hello, World!");

var careerItem = new CareerItem(1, "Teste", "Teste", new Course("Teste", "teste.com"));

if (careerItem.IsInvalid)
{
    Console.WriteLine(careerItem.Notifications.FirstOrDefault()?.Message);
}