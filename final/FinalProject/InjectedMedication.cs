public class InjectedMedication : Medication
{
    private string _syringeType;

    private string _syringeLength;

    public InjectedMedication(string name, string purpose, int dosage, string dosageUnit, string syringeType, string syringeLength)
    : base(name,purpose,dosage,dosageUnit)
    {
        _name = name;
        _purpose = purpose;
        _dosage = dosage;
        _dosageUnit = dosageUnit;
        _syringeType = syringeType;
        _syringeLength = syringeLength;
    }


}