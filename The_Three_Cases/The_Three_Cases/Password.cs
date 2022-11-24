using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace The_Three_Cases
{
    public class Password
    {
        /*
         * En variabel har typen string som datatype og kan tilgås i hele projektet. Den benyttes som brugerens sti.
         */
        public string filePath = "Users.txt";
        // En variabel der tager et char array med som har typen static readonly og kan kun tilgås i klassen. Strengen på højre side bliver konverteret til
        private static readonly char[] specialCharacters = "!#$ % & '  ( ) * + , - . / : ; < = > ? @ [  ] ^ _ ` { | } ~".ToCharArray();
        // En variabel har typen int som datatype og kan tilgås i hele projektet. Den får tildelt en negativ heltalsværdi.
        public int notASpecialCharacters = -1;

        // To variabeler med datatypen string som kun kan tilgås i klassen.
        private string userName;
        private string password;

        // Der bliver oprettet getters og setters for variablet.
        public string UserName { get; set; }
        // Der bliver oprettet getters og setters for variablet.
        public string NewPassword { get; set; }

        // Der bliver oprettet en constructor.
        public Password()
        {

        }

        // Der bliver oprettet en constructor der tager to string parametrer.
        public Password(string UserName, string NewPassword)
        {
            UserName = UserName;
            password = NewPassword;
        }

        /*
         * En metode der kun tager string parametrer og har en masse hændelser.
         * Hændelse 1: Password skal være mindre end 12 for at blive opfyldt. Den vil returnerer en string output.
         * Hændelse 2: Hvis den første hændelse ikke er opfyldt så vil den køre Hændelse 2. Hændelse 2 vil returnerer en tekst output hvor man mangler noget.
         * Hændelse 3: Hvis de første hændelser ikke er opfyldt, så vil den køre Hændelse 3. Hændelse 3 vil returnerer en tekst output hvor man mangler noget.
         * Hændelse 4: Hvis de første hændelser ikke er opfyldt, så vil den køre Hændelse 4. Hændelse 4 vil returnerer en tekst output hvor man mangler noget.
         * Hændelse 5: Hvis de første hændelser ikke er opfyldt, så vil den køre Hændelse 5. Hændelse 5 vil returnerer en tekst output hvor man mangler noget.
         * Hændelse 6: Hvis de første hændelser ikke er opfyldt, så vil den køre Hændelse 6. Hændelse 6 vil returnerer en tekst output hvor man mangler noget.
         * Hændelse 7: Hvis de første hændelser ikke er opfyldt, så vil den køre Hændelse 7. Hændelse 7 vil returnerer en tekst output hvor man mangler noget.
         * Hændelse 8: Hvis de første hændelser ikke er opfyldt, så vil den køre Hændelse 8. Hændelse 8 vil returnerer en tekst output hvor man mangler noget.
         * Hændelse 9: Hvis de første hændelser ikke er opfyldt, så vil den køre Hændelse 9. Hændelse 9 vil returnerer en tekst output hvor man mangler noget.
         * Hændelse 10: Hvis de første hændelser ikke er opfyldt, så vil den køre Hændelse 10. Hændelse 10 vil returnerer en tekst output hvor man mangler noget.
         */
        public string CreatePassword(string UserName, string password)
        {

            if (password.Length < 12)
            {
                return "Password skal være på minimum 12 tegn";
            }

            else if (!password.Any(char.IsUpper))
            {
                return "Der skal være mindst et stort bogstav";
            }

            else if (!password.Any(char.IsLower))
            {
                return "Der skal være mindst et lille bogstav";
            }

            else if (!password.Any(char.IsDigit))
            {
                return "Der skal være mindst et tal";
            }

            else if (password.IndexOfAny(specialCharacters) == notASpecialCharacters)
            {
                return "Password skal mindst indeholde et special tegn";
            }

            if (password.Substring(password.Length - 1).Any(char.IsDigit))
            {
                return "Sidste karakter i password må ikke være et tal";
            }

            if (password.Substring(0, 1).Any(char.IsDigit))
            {
                return "Første karakter i password må ikke være et tal";
            }

            if (String.IsNullOrWhiteSpace(password) || String.IsNullOrEmpty(UserName))
            {
                return "UserName and Password må ikke indelholder nul eller mellemrum";
            }

            if (UserName == password)
            {
                return "UserName og password må ikke være ens";
            }
            else
            {
                File.AppendAllText(filePath, (UserName + " " + password) + Environment.NewLine);
                return "Tillyke - dit nye password er nu oprettet";
            }
        }

        // Metode til at beregne login processen.
        public bool Login(string UserName, string password)
        {
            bool result = false;
            string input = File.ReadAllText("Users.txt");


            string[] lines = File.ReadAllLines("Users.txt");


            for (int i = 0; i < lines.Length; i++)
            {
                string[] field = lines[i].Split(' ');
                if (field[0].Equals(UserName) && field[1].Equals(password))
                {

                    return result = true;
                }
            }
            return result = false;
        }
        // Metode til at gøre det muligt for brugeren at ændrer deres password.
        public string ChangePassword(string Password, string NewPassword)
        {
            string input = File.ReadAllText("Users.txt");

            input = input.Replace(Password, NewPassword);
            File.WriteAllText(filePath, input);
            return "Your password has been changed succesfully";
        }
    }
}