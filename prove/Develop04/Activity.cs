public class Activity
{
    protected string _description;
    
    protected string _name;

    protected string _endMessage;

    protected int _duration;

    public Activity(string description, string name, string endMessage, int duration)
    {
        _description = description;
        _name = name;
        _endMessage = "Thank you for taking some time to be mindufl";
        _duration = duration;        
    }
        public void StartActivity()
    {
        Console.WriteLine($"The name of this activity is{_name}\n{_description}, you have decide to do it for {_duration} seconds.");
    }
    public void SetDuration()
    {
        Console.Write("Please Enter the Duration you would like to do this activity: ");
        _duration = Convert.ToInt32(Console.ReadLine());
    }
    public void PrintTimer(int i) /*counts by 1 and prints out each second until it hits the amount of seconds input */
    {
        int z = 1;
        while (z != i+1)
        {
            Console.WriteLine($"{z}");
            Thread.Sleep(1000);
            z+=1;
        }
    }
    public void Spinner(int i)
    {
        int z = 0;
        while (z != i)
        {
            Console.Write("|");

            Thread.Sleep(500);

            Console.Write("\b \b"); // Erase the + character
            Console.Write("/"); // Replace it with the \ character
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b\b");
            z ++;
        }

    }
    public bool TimeUp(DateTime end)
    {
        DateTime current = DateTime.Now;
        if (current > end)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}