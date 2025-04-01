using System.Reflection;

public class Medication
{
    protected string _name;

    protected string _purpose;

    protected int _dosage;

    protected string _dosageUnit;

    public virtual int getDosage()
    {
        return _dosage;
    }

    public Medication(string name, string purpose, int dosage, string dosageUnit)
    {
        _name = name;
        _purpose = purpose;
        _dosage = dosage;
        _dosageUnit = dosageUnit;
    }


}