namespace TaskManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> tasks = new List<string>();

            while (true)
            {

                Console.WriteLine("=== TaskManager ===");

                Console.WriteLine("Избери:\n 1) Добави\n 2) Покажи\n 3) Изтрий\n 4) Изход");

                string choice = Console.ReadLine();

                if (choice == "4")
                {
                    break;
                }

                switch (choice)
                {
                    
                    case "1":
                        Console.WriteLine("Име на задачата: ");
                        string title = Console.ReadLine();
                        tasks.Add(title);
                        Console.WriteLine($"Добавена е. Общ брой задачи: {tasks.Count}");
                        break;

                    case "2":
                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("Нама въведени задачи");
                        }

                        else
                        {
                            for (int i = 0; i < tasks.Count; i++) 
                            {
                                Console.WriteLine($"{i + 1}) {tasks[i]}");
                            }
                        }
                         break;

                    case "3":
                        for (int i = 0; i < tasks.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}) {tasks[i]}");
                        }
                        Console.Write("Номер за изтриване: ");
                        int nDelete = int.Parse(Console.ReadLine());
                        if (nDelete > 0 && nDelete <= tasks.Count)
                        {
                            tasks.RemoveAt(nDelete - 1);
                            Console.WriteLine($"Изтрита: {tasks[nDelete - 1]}");
                        }
                        else 
                        {
                        Console.WriteLine("Невалидно число");
                        }
                        break ;

                    default:
                        Console.WriteLine("Невалиден избор.");
                        Console.Write("\n");
                        break;
                }

            }
            Console.WriteLine("Довиждане!");

        }
    }
}