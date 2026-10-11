namespace TaskManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("=== TaskManager ===");

                Console.Write("  1) Добави");

                Console.Write("  2) Покажи");

                Console.Write("  3) Изход  ");


                string choice = Console.ReadLine();

                Console.Write("\n");


                if (choice == "3")
                {
                    break;
                }

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("(тук ще добавяме задача)");
                        Console.Write("\n");
                        break;
                    case "2":
                        Console.WriteLine("(тук ще показваме задачите)");
                        Console.Write("\n");
                       
                        break;
                    default:
                        Console.WriteLine("Невалиден избор.");
                        Console.Write("\n");
                        break;
                }
                Console.Clear();
            }
            Console.WriteLine("Довиждане!");

        }
    }
}