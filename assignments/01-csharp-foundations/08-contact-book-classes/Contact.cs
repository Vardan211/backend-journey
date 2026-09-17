using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _08_contact_book_classes
{
    class Contact
    {
        public string Name { get; }
        public string Number { get; }
        public string Email { get; }

        public Contact(string name, string number, string email)
        {
            ValidateObject(name, number, email);
            Name = name;
            Number = number;
            Email = email;
        }
        public bool ValidateObject(string name, string number, string email)
        {
            if (ValidateEmail(email) == false || ValidateName(name) == false || ValidateNumber(number) == false)
            {
                return false;
            }
            return true;
        }
        public bool ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Поле имя пустое");
                return false;
            }
            return true;
        }
        public bool ValidateNumber(string number)
        {
            if (string.IsNullOrWhiteSpace(number))
            {
                Console.WriteLine("Поле номер пустое");
                return false;
            }
            else if (!int.TryParse(number, out int parsedNumber))
            {
                Console.WriteLine("Номер должен состоять из цифр");
                return false;
            }
                return true;
        }
        public bool ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("Поле мэйл пустое");
                return false;
            }
            else if (!email.Contains("@") || !email.Contains("."))
            {
                Console.WriteLine("Поле Mail выглядит неправильно");
                return false;
            }
                return true;
        }
    }
}