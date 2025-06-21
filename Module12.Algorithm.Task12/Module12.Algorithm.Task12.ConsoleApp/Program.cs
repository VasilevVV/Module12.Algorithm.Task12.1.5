namespace Module12;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите количество пользователей:");
        int countUser;
        while (!(int.TryParse(Console.ReadLine(), out countUser) && countUser > 0))
        {
            Console.WriteLine("Количество пользователей введено не правильно.\nПопробуйте снова:");
        }
        User[] users = new User[countUser];
        //ввод пользователей
        for (int i = 0; i < users.Length; i++)
        {
            users[i] = new User();
            Console.WriteLine($"Введите Login пользователя №{i + 1}:");
            users[i].Login = Console.ReadLine();
            Console.WriteLine($"Введите Name пользователя №{i + 1}:");
            users[i].Name = Console.ReadLine();
            Console.WriteLine($"Введите IsPremium (true/false) для пользователя №{i + 1}:");
            string readIsPremium = Console.ReadLine();
            while (readIsPremium != "true" && readIsPremium != "false")
            {
                Console.WriteLine("IsPremium пользователя введен не правильно.\nПопробуйте снова 'true' или 'false':");
                readIsPremium = Console.ReadLine();
            }
            if (readIsPremium == "true")
            {
                users[i].IsPremium = true;
            }
            else if (readIsPremium == "false")
            {
                users[i].IsPremium = false;
            }
        }
        //приветствие по имени
        for (int i = 0; i < users.Length; i++)
        {
            Console.WriteLine();
            if (users[i].IsPremium == false) ShowAds();            
            Console.WriteLine($"Приветствую {users[i].Name}");
            Console.WriteLine();
        }

        
        Console.ReadKey();
    }


    /// <summary>
    /// Метод для показа рекламы
    /// </summary>
    public static void ShowAds()
    {
        Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        // Остановка на 1 с
        Thread.Sleep(1000);

        Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
        // Остановка на 2 с
        Thread.Sleep(2000);

        Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
        // Остановка на 3 с
        Thread.Sleep(3000);
    }
}
