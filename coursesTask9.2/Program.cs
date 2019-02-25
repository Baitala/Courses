using System;

namespace coursesTask9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Ввести два цілих числа a  та b і перевірити чи вони є однієї парності – 
            вивести true чи false
            * Ввести дійсне число r і обчислити довжину кола, площу круга та об’єм кулі 
            цього радіуса
            * Ввести два цілих числа h  та m, які представляють час доби (година 
            та хвилина). Залежності від часу доби вивести привітання 
            («Доброго ранку!», «Доброго дня!», «Доброго вечора!», «Доброї ночі!»)
             */
            
            //nubmers of one parity
            Console.WriteLine("Please enter number 'a'");
            string a = System.Console.ReadLine();
            int aint = System.Convert.ToInt32(a);
            Console.WriteLine("Please enter number 'b'");
            string b = System.Console.ReadLine();
            int bint = System.Convert.ToInt32(b);
            bool rez = ((aint % 2) == 0) && (aint > 0) && ((bint % 2) == 0) && (bint > 0);
            Console.WriteLine("The numbers parity is " + rez);
            
            //radius task
            Console.WriteLine("Plese enter radius");
            string r = System.Console.ReadLine();
            double rfloat = System.Convert.ToDouble(r);
            



        }
    }
}
