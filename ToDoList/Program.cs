List<Task> tasks = new List<Task>();

string command = "";

Func<string, string> prompt = (prompt) =>
{
    Console.WriteLine("");
    Console.WriteLine(prompt + ": ");
    string? line = Console.ReadLine();
    if (line == null)
    {
        return "";
    }
    return line;
};

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
        string title = prompt("Title");
        int priority = Int32.Parse(prompt("Priority"));
        string assigned = prompt("Assigned");

        Task task = new Task(title, priority);
        task.Delegate(assigned);
       
        tasks.Add(task);
        
    }
    else if (command.Equals("LIST"))
    {
        Console.WriteLine("");
        foreach (Task task in tasks)
        {
            Console.WriteLine(task.ToString());
        }
    }
}