Console.WriteLine("Привет, как тебя зовут?");
var name = Console.ReadLine();
if (name =="")
{
    Console.WriteLine("Поле имени не может быть пустой");
    Console.ReadLine();
    return;
}
Console.WriteLine("Сколько тебе лет?");
var agetext = Console.ReadLine();
if (!int.TryParse(agetext, out int age))
{
    Console.WriteLine("Возраст должен быть числом");
    Console.ReadLine();
    return;
}
if (age <0 || age >120)
{
    Console.WriteLine("Возраст должен быть от 0 до 120");
    Console.ReadLine();
    return;
}
var age1 = age + 1;
Console.WriteLine("Привет " + name + " тебе будет " + age1 + " через год");
Console.ReadLine();