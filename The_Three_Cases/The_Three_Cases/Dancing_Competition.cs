using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Three_Cases
{
    public class Dancing_Competition
    {
        // Opretter to variabler med datatypen int som er tilgængelig for hele projektet. Der er oprettet getters og setters.
        public int Points { get; set; }
        public string Name { get; set; }
        // Der oprettes en constructor.
        public Dancing_Competition()
        {
        }

        // Der oprettes en metode med parametrerne for string og int.
        public Dancing_Competition(string name, int points)
        {
            this.Name = name;
            Points = points;
        }
        // En metode der anvender operator.
        public static Dancing_Competition operator +(Dancing_Competition Dancing_Competition1, Dancing_Competition Dancing_Competition2)
        {
            Dancing_Competition Dancing_Competition = new Dancing_Competition();
            Dancing_Competition.Points = Dancing_Competition1.Points + Dancing_Competition2.Points;
            Dancing_Competition.Name = Dancing_Competition1.Name + " og " + Dancing_Competition2.Name;

            return Dancing_Competition;
        }
    }
}