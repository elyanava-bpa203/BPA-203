
using System;
namespace _08.ObjectClassConstructorInheritanceThisKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Elyana", "Alizade", 19, "elyana@edu.az" , "S01" , "101" , "SABAH" , 88.5,3)
            Student student2 = new Student ("Zema","Sirelyeva" , 19, "zema@edu.az" ,"S02" , "102" ,"SABAH" , 92.5 ,3 )
            Student student3 = new Student ("Aytaj" "Garibova", 19,"aitaj@edu.az" , "S03", "103" "Applied Marhematics and Cybernetics",68.5 , 3)

            Teacher teacher1 = new Teacher ("Seid", "Nurullayev" ,45, "seid@edu.az" , "T01" ,"IT" , "FullStack" ,7000, 15)
            Teacher teacher2= new Teacher ("Rashad" ,"Memmedov",32, "reshad@edu.az" ,"T02" , "IT", "Backend",3200,8)


            Adminstrator admin= new Adminstrator ("Leylan" ,"Alizade" , 32, "lailan@edu.az" , "A01", "Dekan", "Computer science", 4.5)

            Console.WriteLine("------Telebeler-------");
            student1.ShowStudentInfo();
            Console.WriteLine($"Teqaud:{student1.CalculateScolarship()} AZN\n");
            student2.ShowStudentInfo();
            Console.WriteLine($"Teqaud:{student2.CalculateScolarShip()} AZN\n");
            student3.ShowStudentInfo();
            Console.WriteLine($"Teqaud: {student3.CalculateScolarShip()} AZN\n");

            Console.WriteLine("------Müəllimlər-------");
            teacher1.ShowTeacherInfo();
            Console.WriteLine($"Maas: {teacher1.CalculateSalary()} AZN\n");
            teacher2.ShowTeacherInfo();
            Console.WriteLine($"Maas: {teacher2.CalculateSalary()} AZN\n");

            Console.WriteLine("------İdarəçi-------");
            admin.ShowAdminInfo();
            admin,GrantAccess(s1);


            //Statistika
            Console.WriteLine("------Statistika-------");
            Console.WriteLine($"Umumi teqaud xerci: {totalScholarship} AZN");
            Console.WriteLine($"Umumi maas xerci:{totalSalary} AZN");



        }
    }
}
