public class InjectedMedication : Medication
{
    private string _syringeType; // micro needle vs normal needle
    private string _syringeLength;
    private string _attendant; //for if someone needs to inject it other than user
    

    public InjectedMedication(string name, string doseage, int medsPerRefill, string syringeType, string syringeLength)
    :base(name, doseage, medsPerRefill)
    {
        _name = name;
        _dosage = doseage;
        _syringeLength = syringeLength;
        _syringeType = syringeType;
        _medsPerRefill = medsPerRefill;
        _medType = "i";
    }

    public InjectedMedication(string name, string doseage, int medsPerRefill, string syringeType, string syringeLength, string attendant)
    :base(name, doseage, medsPerRefill)
    {
        _name = name;
        _dosage = doseage;
        _syringeLength = syringeLength;
        _syringeType = syringeType;
        _attendant = attendant;
        _medsPerRefill = medsPerRefill;
        _medType = "i";
    }

    public string GetSyringeType()
    {
        return _syringeType;
    }
    public string GetSyringeLength()
    {
        return _syringeLength;
    }
    public string GetAttendant()
    {
        return _attendant;
    }
    public override string GetExtraInfo()
    {
        return $"{_syringeType},{_syringeLength},{_attendant}";
    }
    
}