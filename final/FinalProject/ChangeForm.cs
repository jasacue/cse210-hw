using System.Net.Mail;

public class ChangeForm   //class to help paitent request to change their meds
{
    private Doctor _doc;

    private DateTime _changeDate;

    private string _mailingAddress;

    private Medication _requestedMedToChange;

    public ChangeForm(Doctor doc, Medication med, string mailingAddress)
    {
        _doc = doc;
        _requestedMedToChange =med;
        _mailingAddress = mailingAddress;
        _changeDate = DateTime.Today;
        MakeChangeForm();
    }

    public void MakeChangeForm()
    {
        Console.WriteLine("Why do you want to change this drug?");
        string why = Console.ReadLine();
        Console.WriteLine("Has it caused any side affects that have casued you to become mentally or physically ill, if so please list them");
        string effects = Console.ReadLine();
        Console.WriteLine("Is there anything else you want to say about the drug (if not simply type no)");
        string other = Console.ReadLine();
        Console.Write("Please Enter the name of the file you would like to write this form too: ");
        string filename = Console.ReadLine();
        using (StreamWriter writetext = new StreamWriter(filename))
        {
            writetext.WriteLine($"Please Send to {_doc.GetName()} at {_mailingAddress}\n");
            writetext.WriteLine($"Dear {_doc.GetName()}, I would like to change my {_requestedMedToChange.GetMedicationName()}");
            writetext.WriteLine($"Reasons for Change:\n{why}\nSide Effects Caused by drug:\n{effects}");
            if (other != "no")
            {
                Console.WriteLine($"Other Information: \n{other}");
            }
        }
    }


}   