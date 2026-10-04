namespace TaskManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Напиши заглавие: ");
            string title = Console.ReadLine();
            Console.Write("Напиши описание: ");
            string description = Console.ReadLine();
            Console.Write("Избери преоритет (1.Low/2.Medium/3.High): ");
            int prioritet = int.Parse(Console.ReadLine());

            string priorityName;
            switch (prioritet)
            {
                case 1:
                    priorityName = "Low";
                    break;
                case 2:
                    priorityName = "Medium";
                    break;
                case 3:
                    priorityName = "High";
                    break;
                default:
                    priorityName = "";
                    Console.WriteLine("Грешка: приоритетът е число от 1 до 3.");
                    break;
            }


            Console.Write("Колко часа ще отнеме: ");
            int time = int.Parse(Console.ReadLine());

            Console.Write("Спешна ли е? (y/n): ");
            string urgent = Console.ReadLine();
            bool isUrgent = urgent == "y";


            Console.WriteLine($"Заглавие: {title}\nОписание: {description}\nПриоритет: {priorityName}\nВреме: {time} часа({time * 60} минути)\nСпешна ли е: {isUrgent}");
        
        }
    }
}
