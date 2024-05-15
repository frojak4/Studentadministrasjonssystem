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
            Frode.SkrivUtInfo();
            Matte.SkrivUtInfo();

            karakter.SkrivUtInfo();
        }
    }
}
