public class OralMedication : Medication
{
    private string _flavor;

    private string _type; //pills or liquid




    public OralMedication(string name, string dosage, int medsPerRefill, string type, string flavor)
    : base(name, dosage, medsPerRefill)
    {
        _name = name;
        _dosage = dosage;
        _flavor = flavor;
        _type = type;
        _medsPerRefill = medsPerRefill;
        _medType = "o";

    }
    public OralMedication(string name, string dosage, int medsPerRefill, string type) //flavorless
    : base(name, dosage, medsPerRefill)
    {
        _name = name;
        _dosage = dosage;
        _type = type;
        _medsPerRefill = medsPerRefill;
        _medType = "o";

    }
    public override string GetExtraInfo()
    {
        return $"{_type},{_flavor}";
    }



}