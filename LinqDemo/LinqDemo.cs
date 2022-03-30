using System;
using System.Collections.Generic;
using System.Linq;
namespace LinqDemo
{
    public class LinqDemo
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> countryList = new Dictionary<int, string> ();
            countryList.Add(1, "India");
            countryList.Add(2, "USA");
            countryList.Add(3, "Japan");

            string usa = countryList.Where(country => country.Value == "USA").Select(country => country.Value).First();
            Console.WriteLine("Country : "+usa);


            var numbers = Enumerable.Range(1, 4);
            IEnumerable<int> squares = numbers.Select(x => x * x);
           foreach(int square in squares)
            {
                Console.WriteLine(square);
            }
            string Sentance = "This is new World";
            var wordsWithLength = Sentance.Split().Select(word => new { Word=word, Size = word.Length });
            foreach(object word in wordsWithLength)
            {
                Console.WriteLine(word);
            }


            var Sequences = new[] {"red,green,blue","orange","white,pink" };

            var allWords = Sequences.SelectMany(words => words.Split(','));

            foreach(string words in allWords)
            {
                Console.Write(" "+words);

            }

            string[] objects = { "house","car","bicycle" };
            string[] colors = {"red","green","grey"};
            var pairs = colors.SelectMany(_ => objects, (c, o) => $"{c}{o}");
            foreach(object pair in pairs)
            {
                Console.WriteLine(pair);
            }
            var numberz = Enumerable.Range(1, 10);
            var evenNumberz = numbers.Where(n => n % 2 == 0);

            var oddSquarez = numbers.Select(x => x * x).Where(y => y % 2 == 1);
            foreach (int oddSquare in oddSquarez)
            {
                Console.WriteLine(oddSquare);
            }

            object[] values = { 1, 2.5, 3,4.56 };
            Console.WriteLine("------------------------");
            foreach (var item in values.OfType<double>())
            {
                Console.WriteLine(item);
            }
                













            
        }
    }
}
