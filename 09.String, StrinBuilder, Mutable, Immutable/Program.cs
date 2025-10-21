namespace _09.String__StrinBuilder__Mutable__Immutable
{
    internal class Program
    {


        //Task 1
        //static void Main(string[] args)
        //{
        //    string str = "I am Backend DEVELOPER I LEARN C# ";
        //    int count = 0;

        //    for ( int i = 0; i < str.Length; i++) 
        //    {
        //        char c = char.ToLower(str[i]);

        //        if (c == 'a' || c == 'ə' || c == 'e' || c == 'i' ||
        //            c == 'o' || c == 'ö' || c == 'u' || c == 'ü')


        //        {
        //            Console.WriteLine($"Sait herf: {str[i]} ");
        //            count++;
        //        }
        //    }
        //    Console.WriteLine($"\nCumledeki umumi sait sayi: {count}");

        //}







        //Task 2
        //static void Main(string[] args) 
        //{
        //    string str = "I am Backend DEVELOPER I LEARN C#";

        //    string[] words = str.Split(' ');
        //    Console.WriteLine("Soz sayi:" + words.Length);

        //    for (int i = 0; i < words.Length-1; i++)
        //    {
        //        Console.WriteLine(words[i]);

        //    }


        //}




        //Task 3
        //static void Main(string[] args) 
        //{
        //    string str = "I am Backend DEVELOPER I LEARN C#";
        //    string[] words = str.Split(' ');
        //    string longestWord = "";
        //    int maxLength = 0;
        //    for (int i = 0; i < words.Length; i++)
        //    {
        //        if (words[i].Length > maxLength)
        //        {
        //            maxLength = words[i].Length;  
        //            longestWord = words[i];       
        //        }
        //    }
        //    Console.WriteLine("En uzun soz:" + longestWord);

        //}




        //Task 4


        //static void Main(string[] args)
        //{
        //    string s = "I am Backend DEVELOPER I LEARN C#";

        //    string[] words = s.Split(' ');

        //    for (int i = 0; i < words.Length; i++)
        //    {
        //        string word = words[i];


        //        if (word == word.ToUpper())
        //        {
        //            Console.WriteLine($"Böyük herflerle olan söz: '{word}' — indeks: {i}");
        //        }
        //    }
        //}





        //Task 5
        //static void Main()
        //{
        //    string s = "I am Backend DEVELOPER I LEARN C#";

        //    string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        //    for (int i = 0; i < words.Length; i++)
        //    {
        //        string word = words[i];
        //        int upperCount = 0;


        //        for (int j = 0; j < word.Length; j++)
        //        {
        //            if (char.IsUpper(word[j]))
        //            {
        //                upperCount++;
        //            }
        //        }


        //        if (upperCount > 2)
        //        {
        //            Console.WriteLine($"2-den çox böyük herfi olan söz: '{word}' — indeks: {i}");
        //        }
        //    }
        //}
    }
}

