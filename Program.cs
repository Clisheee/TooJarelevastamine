namespace TooJarelevastamine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tee valik");
            Console.WriteLine("1. GroupByLINQ");
            Console.WriteLine("2. FirstOrDefault");
            Console.WriteLine("3. Püramiid");
            Console.WriteLine("4. FailiKirjutamine");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    GroupByLINQ();
                    break;

                case "2":
                    FirstOrDefault();
                    break;
                case "3":
                    Pyramid();
                    break;
                case "4":
                    FileWrite();
                    break;
            }
        }

        static void GroupByLINQ()
        {
            var result = PeopleList.peoples
                .GroupBy(x => x.Age);

            foreach (var age in result)
            {
                Console.WriteLine("Age group " + age.Key);

                foreach (var p in age)
                {
                    Console.WriteLine("People name: " + p.Name);
                }
            }
        }
        public static void FirstOrDefault()
        {
            string firstLongName = PeopleList.peoples
                .FirstOrDefault(person => person.Name.Length > 5)?.Name;

            Console.WriteLine("The first long name is " + firstLongName);
        }
        static void FileWrite()
        {
            Console.WriteLine("Sisesta tekst, mida soovid salvestada:");
            string text = Console.ReadLine();
            Console.WriteLine("sisesta failitee:");
            string path = Console.ReadLine();
            int a = 0;



            if (a == 0)
            {
                try
                {
                    File.WriteAllText(path, text);
                }
                catch (Exception e)
                {
                    
                    Console.WriteLine($"Tekkis viga: {e.Message}");

                }
            }
        }
        static void Pyramid()
        {
            int i, j, n;
            Console.WriteLine("Sisesta püramiidi suurus");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
