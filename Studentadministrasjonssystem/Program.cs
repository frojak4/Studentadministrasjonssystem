using System.Dynamic;

namespace Studentadministrasjonssystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Fag> FagList = new List<Fag>
            {
                new Fag("Matte", 69, 50),
                new Fag("Kunst og Håndverk", 420, 0),
                new Fag ("Norsk", 55, 20),
                new Fag ("Naturfag", 1313, 60)
                
        };
            Student Frode = new Student("Frode", 22, "Get", 456,
                FagList[1], FagList[0], FagList[2], 4, 1, 2);
            Student Hubert = new Student("Hubert", 10, "Barneskole", 123,
                FagList[1], FagList[3], FagList[2], 3, 5, 6);

            

            Frode.SkrivUtInfo();
            
            Hubert.SkrivUtInfo();
            
            
        }
    }
}
