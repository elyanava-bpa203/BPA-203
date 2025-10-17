using System.Diagnostics.Tracing;

namespace Practica
{
    internal class Program
    {

        //Task 1

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Sozu daxil edin:");
        //    string soz = Console.ReadLine();
        //    string tersSoz = "";
        //    for (int i = soz.Length - 1; i >= 0; i--)
        //    {
        //        tersSoz += soz[i];
        //    }
        //    Console.WriteLine("Ters soz:" + tersSoz);
        //    Console.ReadKey();
        //}



        //Task 2
        //static void Main(string[] args)
        //{
        //    int[] fibArr = new int[10];
        //    fibArr[0] = 0;
        //    fibArr[1] = 1;
        //    for (int i = 2; i < 10; i++)
        //    {
        //        fibArr[i] = fibArr[i - 2] + fibArr[i - 1];
        //        Console.Writeline(fibArr[i]);
        //    }


        //}








        //Task 3
        //static void Main(string[] args) 
        //{
        //    int[] arr = { 3, 5, 7, 2, 8 };
        //    FindMax(arr);
        //}



        //public static void FindMax(int[] arr)
        //{
        //    int[] numbers = { 3, 5, 7, 2, 8 };
        //    int max = arr[0];
        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (arr[i] > max)
        //        {
        //            max = arr[i];
        //        }
        //    }
        //    Console.WriteLine($"Massivin max elementi: {max}");

        //}




        //Task 4
        //static void Main(string[] args)
        //{
        //    int[] arr = { 3, 5, 7, 2, 8 };
        //    FindMax(arr);

        //}

        //public static void FindMax(int[] arr)
        //{
        //    int[] numbers = { 3, 5, 7, 2, 8,6,11,15,2,17};
        //    int min = arr[0];
        //    int smallIndex=0;
        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (arr[i] > min)
        //        {
        //            min = arr[i];
        //            smallIndex = i;
        //        }
        //    }
        //    Console.WriteLine($"Massivin min elementinin indexi: {smallIndex}");

        //}





        //Task 5
        //static void Main(string[] args) 
        //{
        //    int[] arr = { 3, 5, 7, 2, 8 };
        //    int sum = 0;
        //    for (int i = 2; i < arr.Length; i++)
        //    {
        //        for (int j = 2; j < arr[i]; j++) 
        //        {
        //            if (arr[i] % j == 0)
        //            {
        //            sum+= arr[i];
        //                break;
        //            }
        //        }
        //    }
        //    Console.WriteLine(sum);
        //}





        //Task 6
        //static void Main(string[] args)
        //{

        //    string cumle = Console.ReadLine();

        //    string enboyuk_soz = EnBoyukSoz(cumle);

        //    Console.WriteLine(enboyuk_soz);
        //}


        //public static string EnBoyukSoz(string cumle)
        //{

        //    string[] words = cumle.Split(' ');
        //    string longest = words[0];
        //    foreach (var word in words)
        //    {

        //        if (word.Length > longest.Length)
        //        {

        //            longest = word;
        //        }
        //    }





        }


    }

}

