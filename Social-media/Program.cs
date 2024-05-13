// See https://aka.ms/new-console-template for more information

using Social_media;

Console.WriteLine("Social media!");


User Kåre = new("kåre", 32, "chill dude just chilling", "cycling");
User Oskar  = new("oskar", 19, "just here because i need to contact my mom sometimes", "gaming");
User Kine  = new("kine", 28, "omg new website I need to join", "horseriding");

while (true)
{
    Kåre.ShowMenu();
}
