namespace Social_media
{
    public class User()
    {
        internal string Name { get; set; }
        internal int Age { get; set; }
        internal string AboutMe { get; set; }
        internal string Hobbies { get; set; }

        public User(string name, int age, string aboutMe, string hobbies)
        {
            Name = name;
            Age = age;
            AboutMe = aboutMe;
            Hobbies = hobbies;
        }

        public User(string name)
        {
            Name = name;
        }

        //public void MakeAboutMe()
        //{
        //    Console.Write("Tell us something about you.");
        //    var userinput = Console.ReadLine();
        //    AboutMe = userinput;
        //}

        //public void MakeHobbies()
        //{
        //    Console.Write("What hobbies do you have?");
        //    var userinput = Console.ReadLine();
        //    Hobbies = userinput;
        //}
    }
}
