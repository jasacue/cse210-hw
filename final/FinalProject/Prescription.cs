using System.Collections;
using System.Data;

public class Prescription
{
    private List<Medication> _meds = new List<Medication>();
    private string _startDate;

    private int _refills;

    private string _condition;

    private Doctor _prescribingDoctor;

    private int _refilled;

    public Prescription(string condition, string startDate, int refills, Doctor prescribingDoctor, int refilled)
    {
        if (startDate == "t")
        {
            _startDate = DateTime.Today.ToString();
        }
        else
        {
            _startDate = startDate;
        }
        _refills = refills;
        _condition = condition;
        _prescribingDoctor = prescribingDoctor;
        _refilled = refilled;
    }
        public Prescription(string condition, string startDate, int refills, Doctor prescribingDoctor)
    {
        if (startDate == "t")
        {
            _startDate = DateTime.Today.ToString("MM/dd/yyy");
        }
        else
        {
            _startDate = startDate;
        }
        _refills = refills;
        _condition = condition;
        _prescribingDoctor = prescribingDoctor;
    }

    public void MakeMed(int numOfMeds) //Adds medications and their informaiton to the list
    {
        int i = 0;
        while (i != numOfMeds)
        {
            Console.WriteLine("What kind of medication is it?\n  1. Oral Medication\n  2. Injected Medication");
            int type = Convert.ToInt32(Console.ReadLine());
            switch(type)
            {
                case 1://oral
                {
                    Console.Clear();
                    Console.Write("Enter Medication Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Dosage(ex. 35ml): ");
                    string dosage = Console.ReadLine();
                    Console.Write("Enter the amount of doses per refill: ");
                    int doses = Convert.ToInt32(Console.ReadLine());
                    Console.Write("How is the medication taken?(ex. pills, inhaled, liqud): ");
                    string how = Console.ReadLine();
                    Console.WriteLine("Does the medication have a flavor? (type yes or no)");
                    string y = Console.ReadLine();
                    if (y == "yes")
                    {
                        Console.Write("Enter Flavor: ");
                        string flavor = Console.ReadLine();
                        OralMedication m = new OralMedication(name, dosage, doses, how, flavor);
                        _meds.Add(m);
                    }
                    else
                    {
                        OralMedication m = new OralMedication(name, dosage, doses, how);
                        _meds.Add(m);
                    }
                    Console.WriteLine("Medication Succsessfully Added");
                    Thread.Sleep(2000);
                    break;
                }
                case 2://needle
                {
                    Console.Clear();
                    Console.Write("Enter Medication Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Dosage(ex. 35ml): ");
                    string dosage = Console.ReadLine();
                    Console.Write("Enter the amount of doses per refill: ");
                    int doses = Convert.ToInt32(Console.ReadLine());
                    Console.Write("What Kind of Syrnige is it? (ex. micro, angled, steel): ");
                    string syringeType = Console.ReadLine();
                    Console.Write("What is the length of the syrnige?: ");
                    string syringeLength = Console.ReadLine();
                    Console.WriteLine("Do you need someone to assist in the inject? (type yes or no)");
                    string y = Console.ReadLine();
                    if (y == "yes")
                    {
                        Console.Write("Please Enter their name: ");
                        string asssist = Console.ReadLine();
                        InjectedMedication I = new InjectedMedication(name, dosage, doses, syringeType, syringeLength, asssist);
                        _meds.Add(I);
                    }
                    else
                    {
                        InjectedMedication I = new InjectedMedication(name, dosage, doses, syringeType, syringeLength);
                        _meds.Add(I);
                    }
                    Console.WriteLine("Medication Succsessfully Added");
                    Thread.Sleep(2000);
                    break;
                }
            }
            i +=1;
        }
    }
    
    public string GetPrescInfo()
    {
        return $"{_startDate},{_refills},{_condition},{_refilled}";
    }
    public Doctor GetDoctor()
    {
        return _prescribingDoctor;
    }
    public List<Medication> GetMeds()
    {
        return _meds;
    }
    public void DisplayAllMedInfo()
    {
        int i =1;
        foreach (var m in _meds)
        {
            Console.WriteLine($"Medication Name{m.GetMedicationName()} you have {_refills - _refilled} remaining.");
            Console.WriteLine($"It was starterd on {_startDate}, was prescribed by {_prescribingDoctor.GetName()}, and is to treat {_condition}");
            i += 1;
        }
    }
    public void DisplayMedications()
    {
        int i =1;
        foreach (var m in _meds)
        {
        Console.WriteLine($"  {i}. {m.GetMedicationName()}");
        i += 1;
        }
    }
    public void AddMedication(Medication m)
    {
        _meds.Add(m);
    }
    public void WhenRefill()
    {
        foreach (var m in _meds)
        {
            TimeSpan diff = DateTime.Now - DateTime.Parse(_startDate);
            double dosesleft = m.GetMedsPerRefill()-Math.Abs(Math.Round(diff.TotalDays));
            if (dosesleft < 0)
            {
                Console.WriteLine($"You are out of {m.GetMedicationName()} and need to refill it");
            }
            else
            {
                Console.WriteLine($"You have {dosesleft} daily doses of {m.GetMedicationName()} left.");
            }
        }
        
    }
    
}