public class PaitentLog
{
    private List<Prescription> _prescs = new List<Prescription>();

    public void DisplayPrescriptions()
    {
        int i = 0;
        while (i != _prescs.Count())
        {
            Console.WriteLine($"Presctipion #{i + 1}");
            _prescs[i].DisplayMedications();
            i +=1;
        }

    }
    public void CheckRefill()
    {
        foreach (var l in _prescs)
        {
            l.WhenRefill();
        }
    }

    public void AddPrescription(Prescription presc)
    {
        _prescs.Add(presc);
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter writetext = new StreamWriter(filename))
        {
            foreach (var p in _prescs)
            {
                List<Medication> meds = p.GetMeds();
                foreach (var m in meds)
                {
                    writetext.WriteLine($"{m.GetMedType()},{m.GetMedicationName()},{m.GetDosage()},{m.GetMedsPerRefill()},{m.GetExtraInfo()}");
                }
                writetext.WriteLine($"p,{p.GetPrescInfo()},{p.GetDoctor().GetName()},{p.GetDoctor().GetLocation()},{p.GetDoctor().GetStartDate()}");
            }
        }
    }
public void LoadFromFile(string filename)
{
    string[] lines = System.IO.File.ReadAllLines(filename);
    List<Medication> tempmeds = new List<Medication>();
    foreach (var line in lines)
    {
        string[] parts = line.Split(",");
        if (parts[0] == "o")
        {
            OralMedication o = new OralMedication(parts[1],parts[2],Convert.ToInt32(parts[3]),parts[4],parts[5]);
            tempmeds.Add(o);
        }

        else if (parts[0] == "i")
        {
            InjectedMedication i = new InjectedMedication(parts[1],parts[2],Convert.ToInt32(parts[3]),parts[4],parts[5],parts[6]);
            tempmeds.Add(i);
        }
        else if (parts[0] == "p")
        {

            Doctor d = new Doctor(parts[5],parts[7],parts[6]);
            Prescription p = new Prescription(parts[3],parts[1],Convert.ToInt32(parts[2]),d,Convert.ToInt32(parts[4]));
            foreach (var m in tempmeds)
            {
                p.AddMedication(m);
            }
            _prescs.Add(p);
            tempmeds.Clear();
            
        }
    }
}
public List<Prescription> GetPrescriptions()
{
    return _prescs;
}
}