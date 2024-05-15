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


        public Student(string navn, int alder, string studieprogram, int studieID)
        {
            Navn = navn;
            Alder = alder;
            Studieprogram = studieprogram;
            StudieID = studieID;
        }
        public void SkrivUtInfo()
        {
            Console.WriteLine($"Navn:{this.Navn}");
            Console.WriteLine($"Alder:{this.Alder}");
            Console.WriteLine($"Studieprogram:{this.Studieprogram}");
            Console.WriteLine($"StudieID:{this.StudieID}");
        }


    }
}
