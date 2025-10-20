using System;
using System.ComponentModel.Design;
namespace _08.ObjectClassConstructorInheritanceThisKeyword
{
    internal class Student : Person 
    {
        public string StudentNumber { get; set; }
        public string Faculty; { get; set; }
        public double GPA;{ get; set; }
        public int Year; { get; set; }


    
        public Student(string firstName, string lastName, int age, string email, string id,
                         string studentNumber, string faculty, double gpa, int year) : base(firstName, lastName, age, email, id)
       
        
        {
            this.StudentNumber = studentNumber;
            this.Faculty = faculty;
            this.GPA = gpa;
            this.Year = year;
        }


        public void ShowStudentInfo() 
        {
            Console.WriteLine($"Tələbə: {GetFullName()}, Fakültə: {Faculty}, GPA: {GPA}, Kurs: {Year}");

        }



        public double CalculateScholarship() 
        {
            if (GPA >= 90)
            {
                return 500;

            }
            else if (GPA >= 80)
                
            {
                return 350;
            }
            else if ( GPA >=70)
            {
                return 200;
            }
            else
            {
                return 0;
            }
        }
        


    }
    
}
