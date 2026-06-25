using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Threading;

namespace CyberSecurityChatbot
{
    class TaskItem
    {
        public string Title;
        public string Description;
        public string Reminder;
        public bool Completed = false;
    }

    class QuizQuestion
    {
        public string Question;
        public string[] Options;
        public int Correct;
        public string Explanation;
    }

    class Program
    {
        static List<TaskItem> tasks = new List<TaskItem>();
        static int score = 0;

        static Dictionary<string, string> keywords =
            new Dictionary<string, string>()
        {
            {"add task","TASK"},
            {"create task","TASK"},
            {"remind me","TASK"},

            {"quiz","QUIZ"},
            {"start quiz","QUIZ"},

            {"password","PASSWORD"},
            {"phishing","PHISHING"},
            {"safe browsing","SAFE"},
            {"purpose","PURPOSE"},
            {"how are you","STATUS"}
        };

        static void Main()
        {
            Console.Title = "Cybersecurity Awareness Bot";

            PlayVoiceGreeting();
            ShowAsciiArt();
            StartChat();
        }

        // AUDIO GREETING
        static void PlayVoiceGreeting()
        {
            try
            {
                string path =
                    Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "greeting.wav");

                SoundPlayer player =
                    new SoundPlayer(path);

                player.Load();
                player.PlaySync();
            }
            catch
            {
                Console.WriteLine(
                    "⚠️ greeting.wav not found.");
            }
        }

        // ASCII ART
        static void ShowAsciiArt()
        {
            Console.ForegroundColor =
                ConsoleColor.Cyan;

            Console.WriteLine(@"
 ____            _                  _____
/ ___| _   _ ___| |_ ___ _ __ ___  | ____|
| |    | | | / __| __/ _ \ '_ ` _ \ |  _|
| |___ | |_| \__ \ ||  __/ | | | | || |___
\____| \__, |___/\__\___|_| |_| |_||_____|
       |___|

CYBERSECURITY AWARENESS CHATBOT
");

            Console.ResetColor();
        }

        // CHAT START
        static void StartChat()
        {
            Console.Write(
                "\nEnter your name: ");

            string name =
                Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
                name = "User";

            Console.ForegroundColor =
                ConsoleColor.Green;

            TypeText(
                $"\nHello {name}! Welcome.\n");

            Console.ResetColor();

            ShowMenu();

            while (true)
            {
                Console.Write(
                    "\nYou: ");

                string input =
                    Console.ReadLine()
                    ?.ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Unknown();
                    continue;
                }

                if (input == "exit")
                {
                    Console.WriteLine(
                        "\nGoodbye! Stay safe online 👋");

                    break;
                }

                HandleInput(input);
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine(
                "\nAvailable Commands:");

            Console.WriteLine(
                "• Add Task");

            Console.WriteLine(
                "• Start Quiz");

            Console.WriteLine(
                "• Password Tips");

            Console.WriteLine(
                "• Phishing Tips");

            Console.WriteLine(
                "• Safe Browsing");

            Console.WriteLine(
                "• Purpose");

            Console.WriteLine(
                "\nType EXIT to close.");
        }

        static void HandleInput(string input)
        {
            foreach (var item in keywords)
            {
                if (input.Contains(item.Key))
                {
                    ExecuteIntent(
                        item.Value);

                    return;
                }
            }

            Unknown();
        }

        static void ExecuteIntent(string intent)
        {
            switch (intent)
            {
                case "TASK":
                    AddTask();
                    break;

                case "QUIZ":
                    StartQuiz();
                    break;

                case "PASSWORD":
                    PasswordAdvice();
                    break;

                case "PHISHING":
                    PhishingAdvice();
                    break;

                case "SAFE":
                    SafeBrowsing();
                    break;

                case "PURPOSE":
                    Purpose();
                    break;

                case "STATUS":
                    Console.WriteLine(
                        "\nI'm running securely 😄");
                    break;
            }
        }

        // TASKS
        static void AddTask()
        {
            Console.Write(
                "\nTask Title: ");

            string title =
                Console.ReadLine();

            Console.Write(
                "Description: ");

            string desc =
                Console.ReadLine();

            Console.Write(
                "Reminder: ");

            string reminder =
                Console.ReadLine();

            tasks.Add(
                new TaskItem
                {
                    Title = title,
                    Description = desc,
                    Reminder = reminder
                });

            Console.WriteLine(
                "\nTask Added.");

            ShowTasks();
        }

        static void ShowTasks()
        {
            Console.WriteLine(
                "\nTASK LIST");

            if (tasks.Count == 0)
            {
                Console.WriteLine(
                    "No tasks.");
                return;
            }

            foreach (var t in tasks)
            {
                Console.WriteLine(
                    $"\nTitle: {t.Title}");

                Console.WriteLine(
                    $"Description: {t.Description}");

                Console.WriteLine(
                    $"Reminder: {t.Reminder}");
            }
        }

        // QUIZ
        static void StartQuiz()
        {
            score = 0;

            List<QuizQuestion> quiz =
                new List<QuizQuestion>()
            {
                new QuizQuestion
                {
                    Question="What is phishing?",
                    Options=new[]
                    {"Fake Email","VPN","Firewall"},
                    Correct=1,
                    Explanation="Phishing tricks users."
                },

                new QuizQuestion
                {
                    Question="Reuse passwords?",
                    Options=new[]
                    {"Yes","No"},
                    Correct=2,
                    Explanation="Always use unique passwords."
                }
            };

            foreach (var q in quiz)
            {
                Console.WriteLine(
                    "\n" + q.Question);

                for (int i = 0;
                    i < q.Options.Length;
                    i++)
                {
                    Console.WriteLine(
                        $"{i + 1}. {q.Options[i]}");
                }

                int answer =
                    Convert.ToInt32(
                        Console.ReadLine());

                if (answer == q.Correct)
                {
                    score++;

                    Console.WriteLine(
                        "Correct!");
                }
                else
                {
                    Console.WriteLine(
                        "Incorrect!");
                }

                Console.WriteLine(
                    q.Explanation);
            }

            Console.WriteLine(
                $"\nFinal Score: {score}");
        }

        // ADVICE
        static void PasswordAdvice()
        {
            Console.WriteLine(
                "\nPASSWORD TIPS");

            Console.WriteLine(
                "• Use strong passwords");

            Console.WriteLine(
                "• Enable 2FA");

            Console.WriteLine(
                "• Never reuse passwords");
        }

        static void PhishingAdvice()
        {
            Console.WriteLine(
                "\nPHISHING TIPS");

            Console.WriteLine(
                "• Verify sender");

            Console.WriteLine(
                "• Avoid suspicious links");
        }

        static void SafeBrowsing()
        {
            Console.WriteLine(
                "\nSAFE BROWSING");

            Console.WriteLine(
                "• Use HTTPS");

            Console.WriteLine(
                "• Avoid unsafe sites");
        }

        static void Purpose()
        {
            Console.WriteLine(
                "\nI help users stay safe online.");
        }

        static void Unknown()
        {
            Console.WriteLine(
                "\nCommand not recognised.");
        }

        static void TypeText(
            string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);

                Thread.Sleep(30);
            }
        }
    }
}
