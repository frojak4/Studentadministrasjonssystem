using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjonssystem
{
    internal class Student
    {
        public string Navn;
        public int Alder;
        public string Studieprogram;
        public int StudieID;
        public Fag Fag1;
        public Fag Fag2;
        public Fag Fag3;
        public int Karakter1;
        public int Karakter2;
        public int Karakter3;



        public Student(string navn, int alder, string studieprogram, int studieID, 
            Fag fag1, Fag fag2, Fag fag3, int karakter1, int karakter2, int karakter3)
        {
            Navn = navn;
            Alder = alder;
            Studieprogram = studieprogram;
            StudieID = studieID;
            Fag1 = fag1;
            Fag2 = fag2;
            Fag3 = fag3;
            Karakter1 = karakter1;
            Karakter2 = karakter2;
            Karakter3 = karakter3;

        }
        public void SkrivUtInfo()
        {
            


            Console.WriteLine();
            Console.WriteLine($"Navn:{this.Navn}");
            Console.WriteLine($"Alder:{this.Alder}");
            Console.WriteLine($"Studieprogram:{this.Studieprogram}");
            Console.WriteLine($"StudieID:{this.StudieID}");
            Console.WriteLine();
            Console.WriteLine($"{Fag1.Fagnavn} Karakter: {Karakter1}");
            Console.WriteLine($"{Fag2.Fagnavn} Karakter: {Karakter2}");
            Console.WriteLine($"{Fag3.Fagnavn} Karakter: {Karakter3}");
            Console.WriteLine();
            Console.WriteLine($"Gjennomsnitts Karakter: {averageGrade()}");
            Console.WriteLine($"Studiepoeng: {studiePoeng()}");
            Console.WriteLine();
        }

        public double averageGrade()
        {
            double allGrades = Karakter1 + Karakter2 + Karakter3;

            double averagegrade = allGrades / 3;

            return averagegrade;
        }

        public int studiePoeng()
        {
            int studiepoeng = Fag1.StudiePoeng + Fag2.StudiePoeng + Fag3.StudiePoeng;

            return studiepoeng;
        }

    }
}
