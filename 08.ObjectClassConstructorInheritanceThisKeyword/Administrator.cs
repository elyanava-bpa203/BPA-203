using System;

namespace _08.ObjectClassConstructorInheritanceThisKeyword 
{
    internal class Adminstrator : Person 
    {
        public string Position { get; set; }
        public string Departament { get; set; }
        public int AccessLevel { get; set; }

        public Adminstrator(string firstName, string lastName, int age, string email, string id,
                             string position, string departament, int accessLevel) : base(firstName, lastName, age, email, id)
        {

            this.Position = position;
            this.Departament = departament;
            this.AccessLevel = accessLevel;
        }

        public void ShowAdminInfo() 
        {
            Console.WriteLine($"Idareci: {GetFullName()} , Vezife: {Position}, Giris seviyyesi : {AccessLevel}");
        
        } 
        public void GrantAccess(Student student)
        {

            Console.WriteLine($"{GetFullName()} ({Position}) {student.GetFullName()} telebesine sistem girisi icaze verildi");
        }
    
    }

}
