using System;
using System.Diagnostics.Contracts;
using _08.ObjectClassConstructorInheritanceThisKeyword;

namespace _08.ClassConstructorInheritanceThisKeyword
{
    internal class Teacher : Person 
    {

        public string Departament { get; set; }
        public string MainSubject { get; set; }
        public decimal BaseSalary { get; set; }
        public int ExperienceYears { get; set; }

        public Teachers(string firstname, string lastName, int age, string email, string id,
                         string departament, string mainsubject, decimal basesalary, int experienceYears) : base(firstname, lastName, age, email, id)
        {
            this.Departament = departament;
            this.MainSubject = mainsubject;
            this.BaseSalary = basesalary;
            this.ExperiencYears = experienceYears;


        }

        public void ShowTeacherInfo()
        {
            Console.WriteLine($"Müəllim: {GetFullName()}, Kafedra: {Departament}, Fenn: {MainSubject}");

        }
        public decimal CalculateSalary()
        {
            return BaseSalary + (ExperienceYears * 50);

        }

    }
}