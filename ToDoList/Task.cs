public class Task
{
    private string title;
    private string assigned = "";
    private int priority; // 1-4

    public Task(string title, int priority)
    {
        this.title = title;
        this.InitPriority(priority);
    }

    private void InitPriority(int priority)
    {
        if (priority < 1 || priority > 4)
        {
            throw new Exception("Invalid Priority");
        }
        this.priority = priority;
    }

    public void Delegate(string name)
    {
        this.assigned = name;
    }

    public override string ToString()
    {
        return String.Format("({0}) {1} [{2}]", this.priority, this.title, this.assigned);
    }
}