using System;

class Program
{

    static void DisplayFirst() //first one to be displayed with the cool aski art
    {
        Console.WriteLine("======================================================================================");
        Console.WriteLine("    ___                       _____                    _               ");
        Console.WriteLine("   /   \\ _ __  _   _   __ _  /__   \\ _ __  __ _   ___ | | __ ___  _ __ ");
        Console.WriteLine("  / /\\ /| '__|| | | | / _` |   / /\\/| '__|/ _` | / __|| |/ // _ \\| '__|");
        Console.WriteLine(" / /_// | |   | |_| || (_| |  / /   | |  | (_| || (__ |   <|  __/| |   ");
        Console.WriteLine("/___,'  |_|    \\__,_| \\__, |  \\/    |_|   \\__,_| \\___||_|\\_\\___| |_|   ");
        Console.WriteLine("                      |___/                                            ");
        Console.WriteLine("1. Add A New Prescription     2. Load Logs from file\n3. Save Logs to file          4. Display Drugs from prescriptions");
        Console.WriteLine("5. Make Change Form           6. Check for Refill           \n7. Quit");
        Console.WriteLine("======================================================================================");
    }

    static void DisplayMenu() //More usable smaller version of the start screen

    {
        Console.WriteLine("======================================================================================");
        Console.WriteLine("1. Add A New Prescription     2. Load Logs from file\n3. Save Logs to file          4. Display Drugs from prescriptions");
        Console.WriteLine("5. Make Change Form           6. Check for Refill           \n7. Quit");
        Console.WriteLine("======================================================================================");
    }


    static void Main(string[] args)
    {
        PaitentLog log = new PaitentLog();
        Console.WriteLine("Welcome to the med tracker.\n(press enter to continue)");
        Console.ReadLine();
        Console.Clear();
        DisplayFirst();
        int choice = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        while (choice != 7)
        {
            switch (choice)
            {
                case 1: //Add Presciption
                    {
                        Console.WriteLine("Who is your doctor?");
                        string doctorname = Console.ReadLine();
                        Console.WriteLine("When did you start seeing them?(write \"t\" for today)");
                        string startedSeeing = Console.ReadLine();
                        Console.WriteLine("Where is their office Located");
                        string officeLocation = Console.ReadLine();
                        Doctor d = new Doctor(doctorname, startedSeeing, officeLocation);
                        Console.WriteLine("What condition is the prescription treating?");
                        string con = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("How many medications have been prescribed?");
                        int numOfMeds = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("When are you starting this Prescription? (type \"t\" for today)");
                        string startDate = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("How many refills do you get for this Prescription?");
                        int refills = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Prescription p = new Prescription(con, startDate, refills, d);
                        Console.WriteLine("You will now be asked to input the medicaiton information for this prescription");
                        Thread.Sleep(2000);
                        Console.Clear();
                        p.MakeMed(numOfMeds);
                        log.AddPrescription(p);
                        break;
                    }
                case 2: //Load paitient log
                    {
                        Console.WriteLine("Please Enter the filename you want to laod from: ");
                        string fn = Console.ReadLine();
                        log.LoadFromFile(fn);
                        break;
                    }
                case 3: //Save Paiteint Log
                    {
                        Console.Write("Enter File Name to Save To: ");
                        string filename = Console.ReadLine();
                        log.SaveToFile(filename);
                        break;
                    }
                case 4: //Display all of the drugs
                    {
                        Console.WriteLine("All Prescriptions: ");
                        log.DisplayPrescriptions();
                        break;
                    }
                case 5: //drug change form
                    {
                        Console.WriteLine("Which Prescription Would You like to change?");
                        log.DisplayPrescriptions();
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Which Medication do you want to change from that Prescription");
                        List<Prescription> prescs =  log.GetPrescriptions();
                        prescs[c-1].DisplayMedications();
                        int b = Convert.ToInt32(Console.ReadLine());
                        List<Medication> med = prescs[c-1].GetMeds();
                        Console.WriteLine("What email Adress should this be mailed too?");
                        string address = Console.ReadLine();
                        ChangeForm cf = new ChangeForm(prescs[c-1].GetDoctor(), med[b-1],address);
                        break;
                    }

                case 6: //Check for refill
                    {
                        log.CheckRefill();
                        break;
                    }
                case 7: //quit
                {
                    
                    break;
                }
                default:
                    {

                        Console.WriteLine("Not a menu option");
                        break;
                    }


            }
            DisplayMenu();
            choice = Convert.ToInt32(Console.ReadLine());
        }
        
    }
}