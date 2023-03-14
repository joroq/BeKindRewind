List<string> movies = new List<string>();

string command = "";

while (!command.Equals("QUIT"))
{
    Console.WriteLine("");
    Console.WriteLine("Command: ");
    string? line = Console.ReadLine();

    if (line == null)
    {
        command = "QUIT";
        continue;
    }

    command = line.ToUpper();

    if (command.Equals("ADD"))
    {
        Console.WriteLine("");
        Console.WriteLine("Title: ");
        string? movie = Console.ReadLine();

        if (movie != null)
        {
            movies.Add(movie);
        }
    }
    else if (command.Equals("LIST"))
    {
        Console.WriteLine("");
        foreach (string movie in movies)
        {
            Console.WriteLine(movie);
        }
    }
}