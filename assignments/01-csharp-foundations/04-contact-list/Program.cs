// надо что бы программа показывала меню
// ждет ответа пользователя 
// надо создать что бы меню работала
// программа хранит добавленый контакт 
// что бы пользователь мог посмотреть какие контакты есть 
var contacts = new List<string>();
while (true)
{
    
    Console.WriteLine("1. Добавить контакт\r\n2. Показать все контакты\r\n3. Найти контакт по имени\r\n0. Выйти");
    string answer = Console.ReadLine();
    switch (answer)
   
    {
        case "1":
        Console.WriteLine("Напишите новый контакт");
        contacts.Add(Console.ReadLine());
          break;
        
        
        case "2":
      
        Console.WriteLine("Вот все контакты ");
        foreach (var contact in contacts)
        {
            Console.WriteLine(contact);

        }
            break;

        case "3":
        Console.WriteLine("Напишите какой контакт вам нужен!");
        string search = Console.ReadLine();
        bool isFinded = false; 
        foreach(string contact in contacts)
        {
            if(search == contact)
                {
                isFinded = true;
            }

        }
        if (isFinded == true)
        {
            Console.WriteLine("Результат:\r\n" + contacts);

        }
        else
                {
            Console.WriteLine("Такого контакта не существует");
        }
            break;

             
           case "0":
            
                Console.WriteLine("Выход из программы");
                Console.ReadLine();
                return;


        default:
            Console.WriteLine("Такой команды нету");
            break;



    }






   

}















