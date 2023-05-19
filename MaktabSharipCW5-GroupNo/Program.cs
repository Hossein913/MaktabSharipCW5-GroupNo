using MaktabSharipCW5_GroupNo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaktabSharipCW5_GroupNo.Services;

namespace MaktabSharipCW5_GroupNo
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonServices person = new PersonServices();

            Print(person.getFemalByAge(30));
            Console.WriteLine();            
            Print(person.getRipoSortedByAge());
            Console.WriteLine();
            PrintString(person.getRipoByCity("shiraz"));
            Console.WriteLine();
            Print(person.getByNameStartChar("A"));
            Console.WriteLine();
            PrintString(person.getInvalidEmail());
            Console.WriteLine();




            Console.ReadKey();
        }

        public static void Print (List<Person> people)
        {
            foreach (var item in people)
            {
                Console.WriteLine(item.ToWrite());
                
            }
        }

        public static void PrintString(List<string> people)
        {
            foreach (var item in people)
            {
                Console.WriteLine(item);

            }
        }
    }
}
