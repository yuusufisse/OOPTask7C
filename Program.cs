using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPTask7C
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Jaako Laaksonen", "Sammonkatu 5", new DateTime(1995,11,23)),
                new Student("Minna Jaakkola", "Patteristonkatu 10", new DateTime(1991,10,25)),
                new Student("Asko Liukkonen", "Kettukuja 15", new DateTime(1976,10,25)),
                new Student("Elina Savela", "Kasarminkatu 10", new DateTime(2001,107,14)),
                new Student("Santeri Kilpeläinen", "Porrassalmenkatu 30", new DateTime(1968,12,18)),
                new Student("Sari Karasti", "Saimaannorpantie 30", new DateTime(1985,04,15)),
                new Student("Marja Kosonen", "Saattotie 35", new DateTime(1957,08,12)),
                new Student("Riikko Lappalainen", "Savilahdenkatu 40", new DateTime(2002,05,20)),
                new Student("Onerva Rantanen", "Jääkkärinkatu 13", new DateTime(1988,08,18)),
                new Student("Tuulia Rantanen", "Kuistinkatu 47", new DateTime(1979,11,12)),
                new Student("Pyry Ojala", "Suur-Savonkatu 17", new DateTime(1994,06,23)),
                new Student("Touko Hiltonen", "Tykkimiehenkatu 17", new DateTime(1965,12,12)),
                new Student("Kerkko Kauppinen", "Sointukatu 12", new DateTime(1963,06,06)),
                new Student("Visa Lahti", "Brahenkatu 9", new DateTime(1959,09,29)),
                new Student("Ohto Lahti", "Brahenkatu 7", new DateTime(1958,08,16)),
                new Student("Vanamo Lindholm", "Arkistokatu 91", new DateTime(1966,09,22)),
                new Student("Kuisma Vuorinen", "Hanhikankaankatu 29", new DateTime(1988,01,01)),
                new Student("Päivö Mäki", "Kokkamäenkatu 3", new DateTime(1992,12,02)),
                new Student("Salla Laaksonen", "Laiturikatu 59", new DateTime(2000,11,09)),
            };
            //Younger than...
            DateTime dateTime = new DateTime(1989, 11, 25);
            //Linq Query syntax
            //var chosen = from item in students
            //             where item.DateOfBirth > dateTime
            //             select item;
            //foreach (var s in chosen)        
            //Console.WriteLine("Name: " + s.Name + ", Date of birth: " + s.DateOfBith.ToString());
            //var chosen = from Student item in students
            //             where item.DateOfBirth > dateTime
            //             select new
            //             {
            //                 item.Name
            //             };

            //Alphabetical
            var chosen = from Student item in students
                         where item.DateOfBirth > dateTime
                         orderby item.Name descending
                         select new
                         {
                             item.Name
                         };

            foreach (var s in chosen)
                Console.WriteLine("Name: " + s.Name);
        }
    }
}
