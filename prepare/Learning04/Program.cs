using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Assighnment a = new Assighnment("Jake", "math");
        Console.WriteLine(a.GetSummary());
        MathAssighnment b = new MathAssighnment("Jake", "math", "algebra book", "10-15");
        Console.WriteLine(b.GetSummary()+b.GetHomeworkList());
        WritingAssighnment c = new WritingAssighnment("Jake","English", "Book title");
        Console.WriteLine(c.GetWritingInformation());
    }
}




