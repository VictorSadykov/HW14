using System;
using System.Collections.Generic;
using System.Linq;

namespace HW14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  создаём пустой список с типом данных Contact
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            while (true)
            {
                int key = int.Parse(Console.ReadLine());
                var phonesToPrint = phoneBook
                                    .Skip(2 * ((key - 1) % 3))
                                    .Take(2)
                                    .OrderBy(x => x.Name)
                                    .ThenBy(x => x.LastName);

                /*var phonesToPrint = phoneBook
                                    .OrderBy(x => x.Name)
                                    .ThenBy(x => x.LastName);*/

                foreach (var item in phonesToPrint)
                {
                    Console.WriteLine(item.Name + " " + item.LastName);
                }

                
            }
        }
    }
    public class Contact // модель класса
    {
        public Contact(string name, string lastName, long phoneNumber, String email) // метод-конструктор
        {
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public String Name { get; }
        public String LastName { get; }
        public long PhoneNumber { get; }
        public String Email { get; }
    }
}
    