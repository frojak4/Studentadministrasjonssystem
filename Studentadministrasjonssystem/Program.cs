using System.Dynamic;

namespace Studentadministrasjonssystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student Frode = new Student("Frode", 22, "Get", 456);
            Fag Matte = new Fag("Matte", 69, 50);
            Karakter karakter = new Karakter(Frode, Matte, 6);

            Student Hubert = new Student("Hubert", 10, "Barneskole", 123);
            Fag Kunst = new Fag("Kunst og Håndverk", 420, 0);
            Karakter karakter2 = new Karakter(Hubert, Kunst, 2);

            Frode.SkrivUtInfo();
            Matte.SkrivUtInfo();
            karakter.SkrivUtInfo();
            Console.WriteLine();
            Hubert.SkrivUtInfo();
            Kunst.SkrivUtInfo();
            karakter2.SkrivUtInfo();
        }
    }
}
