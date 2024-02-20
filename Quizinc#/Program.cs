







    static void Main(string[] args)
    {
        int temp = 0;
        int score = 0;

        string[] suallar = new string[]
        {
            "Berlin hansi olkenin paytaxtidir?" ,
            "Paris hansi olkenin paytaxtidir?",
            "Adin nedir?",
            "5-5 neceye beraberdir?",
            "Dunyanin en yaxshi futbolchusu kimdir?",
            "Indi necenci ildir?",
            "Butun renglerin menbesi hansidir?",
            "Indi hansi aydir?",
            "Men kimem?",
            "En yaxshi superqehreman hansidir?"
        };

        string[] dogruCavablar = new string[]
        {
            "Germany",
            "France",
            "Copilot",
            "0",
            "Lionel Messi",
            "2024",
            "Sun",
            "February",
            "User",
            "Superman"
        };

        string[,] cavablar = new string[,]
        {
            { "A==> Germany","B==>France","Italy"},
            { "France","Germany","Italy"},
            { "Copilot","Siri","Alexa"},
            { "0","10","25"},
            { "Lionel Messi","Cristiano Ronaldo","Neymar"},
            { "2024","2023","2022"},
            { "Sun","Moon","Stars"},
            { "February","March","April"},
            { "User","Assistant","Admin"},
            { "Superman","Batman","Spiderman"}
        };

        // Shuffle answers
        Random rnd = new Random();
        for (int i = 0; i < cavablar.GetLength(0); i++)
        {
            for (int j = 0; j < cavablar.GetLength(1); j++)
            {
                int randomIndex = rnd.Next(cavablar.GetLength(1));
                string tempCavab = cavablar[i, j];
                cavablar[i, j] = cavablar[i, randomIndex];
                cavablar[i, randomIndex] = tempCavab;
            }
        }

        for (int i = 0; i < suallar.Length; i++)
        {
            do
            {
                Console.Clear();
                Console.WriteLine(suallar[i]);
                for (int j = 0; j < 3; j++)
                {
                    if (temp == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(cavablar[i, j]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                        Console.WriteLine(cavablar[i, j]);
                }
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.UpArrow)
                {
                    if (temp == 0)
                    {
                        temp = 2;
                    }
                    else
                        temp--;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    if (temp == 2)
                        temp = 0;
                    else
                        temp++;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    if (cavablar[i, temp] == dogruCavablar[i])
                    {
                        score++;
                        Console.WriteLine("Doğru cavab! Sizin xalınız: " + score);
                    }
                    else
                    {
                        Console.WriteLine("Yanlış cavab. Doğru cavab " + dogruCavablar[i] + " idi.");
                    }

                    break;
                }
            } while (true);
        }
    















































































































