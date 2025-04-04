public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _responces = new List<string>();

    public ListingActivity(string description, string name, string endDescription, int duration)
        :base(description, name, endDescription, duration)
        {
            _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
            _name = "Listing Activity";
            _prompts.Add("Who are people that you appreciate?");
            _prompts.Add("What are personal strengths of yours?");
            _prompts.Add("Who are people that you have helped this week?");
            _prompts.Add("When have you felt the Holy Ghost this month?");
            _prompts.Add("Who are some of your personal heroes?");
            SetDuration();
        }
    public void ListActive()
    {
        Random r = new Random();
        int i = r.Next(0, _prompts.Count());
        bool z = false;
        StartActivity();
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);
        Console.WriteLine(_prompts[i]);
        while (z != true)
        {
            Console.Write("> ");
            _responces.Add(Console.ReadLine());
            if (TimeUp(end))
            {
                break;
            }
        }
        int p = 0;
        Console.WriteLine("Here is what you entered: \n");
        while (p != _responces.Count())
        {
            Console.WriteLine(_responces[p]);
            Thread.Sleep(500);
            p++;
        }
        Console.WriteLine(_endMessage);
        Thread.Sleep(3000);
    }
}