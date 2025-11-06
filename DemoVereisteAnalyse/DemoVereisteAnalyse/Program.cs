namespace DemoVereisteAnalyse
{
    internal class Program
    {
        static void Main(string[] args)
        {
                const string user = "Admin", password = "P@sswoord123";
                int poging = 0;
                while (poging < 3)
                {
                    Console.Write("Gebruikersnaam: ");
                    string Gebruiker = Console.ReadLine();
                    Console.Write("Wachtwoord: ");
                    string inputPassword = Console.ReadLine();
                    if (Gebruiker == user && inputPassword == password)
                    {
                        Console.WriteLine($"Welkom, {Gebruiker}!");
                        return;
                    }
                    poging++;
                    Console.WriteLine($"login is fout.{3 - poging} pogingen over.");
                }
                Console.WriteLine("Te veel pogingen. Toegang geweigerd.");
            }
        }
    }

