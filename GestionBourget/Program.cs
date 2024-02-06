using GestionBourget;
internal class Program
{
    
    private static void Main(string[] args)
    {
        List<Company> companies = new List<Company>();

         void displayMenu()
         {
            Console.Clear();
            Console.WriteLine("################");
            Console.WriteLine("#GestionBourget#");
            Console.WriteLine("################");
            Console.WriteLine("1 - Saisir un emplacement");
            Console.WriteLine("2 - Saisir une entreprise");
            Console.WriteLine("3 - Saisir un contact");
            Console.WriteLine("4 - Afficher les exposants");
            Console.WriteLine("0 - Quitter l'application");

        }

        void inputCompany()
        {
            Console.Clear();
            Console.WriteLine("Saisir un numéro de SIRET");
            string siret = Console.ReadLine();
            Console.WriteLine("Saisir un nom");
            string name = Console.ReadLine();
            Company newCompany = new Company(siret, name);
            companies.Add(newCompany);
        }

        bool menuOn = true;

        while (menuOn)
        {
            displayMenu();
            int userEntry = int.Parse(Console.ReadLine());
            switch (userEntry)
            {
                case 1:
                    Console.WriteLine("Saisie Emplacement");
                    Console.Read();
                    break;
                case 2:
                    inputCompany();
                    Console.Read();
                    break;
                case 3:
                    Console.WriteLine("Saisie Contact");
                    Console.Read();
                    break;
                case 4:
                    Console.WriteLine("Affichage Exposants");
                    Console.Read();
                    break;
                case 0:
                    menuOn = false;
                    break;
            }
        }

    }
}