using System;

namespace _08.ObjectClassConstructorInheritanceThisKeyword
{
    internal class  Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string Email;
        public string ID;




        public Person(string firstName, string lastName, int age, string email, string id) //constructor with parameters
        {
            this. FirstName = firstName;
            this .LastName = lastName;
            this .Age = age;
            this .Email= email;
            this. ID = id;

        }
         
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public void ShowBasicInfo()
        {
            Console.WriteLine($"Ad: {FirstName}, Soyad: {LastName}, Yaş= {Age}, Email: {Email}, ID: {ID}");
        }
    }
}