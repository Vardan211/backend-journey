using _08_contact_book_classes;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
var contacs = new List<Contact>();
while (true)
{
    Console.WriteLine("1.Добавить контакт" +
        "2.Показать контакты");
    var answer = Console.ReadLine();
    switch (answer)
    {
        case "1":
            Console.WriteLine("Напишите имя");
            var name = Console.ReadLine();
            Console.WriteLine("Мейл");
            var email = Console.ReadLine();
            Console.WriteLine("Напишите номер");
            var number = Console.ReadLine();
            var contactObject = new Contact(name, number, email);
            contacs.Add(contactObject);
            break;

        case "2":
            Console.WriteLine("Вот все контакты");
            foreach (var contact in contacs)
            {
                Console.WriteLine($"{contact.Name} - {contact.Number} - {contact.Email}");

            }
            break;
    
    }

}
