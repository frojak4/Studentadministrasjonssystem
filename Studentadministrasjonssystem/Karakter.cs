using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjonssystem
{
    internal class Karakter
    {
        public Student Student;
        public Fag Fag;
        public int KarakterVerdi;

        public Karakter(Student student, Fag fag, int karakterVerdi)
        {
            Student = student;
            Fag = fag;
            KarakterVerdi = karakterVerdi;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Navn: {Student.Navn}");
            Console.WriteLine($"Fag: {Fag.Fagnavn}");
            Console.WriteLine($"Karakter: {this.KarakterVerdi}");
        }
    }
}
