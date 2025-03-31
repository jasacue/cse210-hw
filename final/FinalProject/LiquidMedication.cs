public class LiquidMedication : Medication
{
    private string _flavor;



    public LiquidMedication(string name, string purpose, int dosage, string dosageUnit, string flavor)
        :base (name, purpose, dosage, dosageUnit)
    {
        _name = name;
        _purpose = purpose;
        _dosage = dosage;
        _dosageUnit = dosageUnit;
        _flavor = flavor;
    }


}