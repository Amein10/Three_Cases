using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Three_Cases
{
    public class Football
    {
        // En variabel der har typen string som datatype og kan tilgås i hele projektet. 
        public string goalAttempts;
        // En variabel der har typen string som datatype og kan tilgås i hele projektet. 
        public string amountsOfPasses;

        /* En metode der er af string typen og som tager kun int værdier. Den kan tilgås i hele projektet. 
           Metoden har 3 hændelser:
           1. Hvis parameteret (PassingTheBaller) er mindre end 1, så vil der blive returneret en string: "Shh".
           2. Hvis parameteret (PassingTheBaller) er større eller ligemed 10, så vil der blive returneret en string: "High Five – Jubel!!!".
           3. Hvis de første to hændelser fejler så vil den sidste else blive kørt som har en forløkke der vil returnerer en string med: "Huh!", hver gang amountsOfPasses iterarer.
         */
        public string PassingTheBall(int PassingTheBaller)
        {
            if (PassingTheBaller < 1)
            {
                return "Shh";
            }

            else if (PassingTheBaller >= 10)
            {
                return "High Five – Jubel!!!";
            }
            else
            {
                for (int i = 0; i < PassingTheBaller; i++)

                    amountsOfPasses += "Huh!";

                return amountsOfPasses;
            }
        }
        /* En metode der er af string typen og som tager kun int og string parametrer. Den kan tilgås i hele projektet. 
           Metoden har 2 hændelser:
           1 Hvis goalAttempts er ligemed strengen: "Goal", så skal den returnerer stringen: "Ole ole ole!"
           2. Hvis hændelse 1 ikke indfrier konditionen, så vil metoden PassingTheBall returneret i stedet for.
         */
        public string Goal(int PassingTheBaller, string goalAttempts)
        {
            if (goalAttempts == "Goal")
            {
                return "Ole ole ole!";
            }
            else
            {
                return PassingTheBall(PassingTheBaller);
            }
        }
    }
}
