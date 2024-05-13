using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;

namespace Social_media
{
    internal class User
    {
        internal string Name;
        internal int Age;
        internal string AboutMe;
        internal string Hobbies;
        internal List<User?> FriendList = new List<User?>();
        internal static List<User> Everyone = new List<User>();

        public User(string name, int age, string about, string hobbies)
        {
            Name = name;
            Age = age;
            AboutMe = about;
            Hobbies = hobbies;
            Everyone.Add(this);
        }

        internal void AddFriend()
        {
            Console.WriteLine("Who do you wish to add?");
            var friendinput = Console.ReadLine();
            var newfriend = Everyone.Find(f=> f.Name == friendinput);
            FriendList.Add(newfriend);
        }

        internal void RemoveFriend()
        {
            Console.WriteLine("who do you wish to remove?");
            var friendinput = Console.ReadLine();
            var enemy = FriendList.FirstOrDefault(f => f.Name == friendinput);
            FriendList.Remove(enemy);
        }

        internal void PrintFriendList()
        {
            foreach(User? friend in FriendList)
            {
                Console.WriteLine($"my friend: {friend.Name}");
            }
        }

        internal void ChooseFriendPage()
        {
            var count = 0;
            foreach (User? friend in FriendList)
            {
                Console.WriteLine($"{count} show {friend.Name} page");
                count++;
            }

            var userinput = Console.ReadLine();
            ShowProfile(userinput);
        }

        internal void ShowProfile(string choice)
        {
            int num;
            int.TryParse(choice, out num);
            var Friend = FriendList[num];
            Console.WriteLine("friend's profile");
            Console.WriteLine($"{Friend.Name}");
            Console.WriteLine($"{Friend.Age}");
            Console.WriteLine($"{Friend.AboutMe}");
            Console.WriteLine($"{Friend.Hobbies}");
            Console.WriteLine();
        }

        public void ShowMenu()
        {
            string[] menu = new[] { "1. add friend", "2. remove friend", "3. show friendlist", "4. show a friends page"};
            Console.WriteLine($"Hey {Name}");
            Console.WriteLine($"what would you like to do?");
            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine(menu[i]);
            }
            Console.WriteLine();

            var userinput = Console.ReadLine();

            switch (userinput)
            {
                case "1":
                    AddFriend();
                    break;
                case "2":
                    RemoveFriend();
                    break;
                case "3":
                    PrintFriendList();
                    break;
                case "4":
                    ChooseFriendPage();
                    break;
                default:
                    Console.WriteLine("logged out");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
