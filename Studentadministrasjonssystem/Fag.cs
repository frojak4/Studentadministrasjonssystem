using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace Studentadministrasjonssystem
{
    internal class Fag
    {
        public string Fagnavn;
        public int Fagkode;
        public int StudiePoeng;


        public Fag(string fagnavn, int fagkode, int studiePoeng)
        {
            Fagnavn = fagnavn;
            Fagkode = fagkode;
            StudiePoeng = studiePoeng;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"FagNavn: {this.Fagnavn}");
            Console.WriteLine($"FagKode: {this.Fagkode}");
            Console.WriteLine($"StudiePoeng: {this.StudiePoeng}");
        }
    }
}
