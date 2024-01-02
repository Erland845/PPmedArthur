namespace PPmedArthur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hpcharacter Harry = new Hpcharacter("Harry", "Griffindor", new List<string> {"Tryllestav", "Nimbus2000", "briller"});
            Harry.PrintInfo();

            Butikk HPbutikk = new Butikk(new List<string> { "Ugle", "Rotte", "Katt", "Tryllestav" });


            Console.WriteLine("Har du lyst til å kjøpe items til karakteren din?");
            var input = Console.ReadLine(); 

            if (input == "Ja")
            {
                HPbutikk.PrintInfo();
            }
            else
            {
                Console.WriteLine("Ok");
            }
        }

    }
}