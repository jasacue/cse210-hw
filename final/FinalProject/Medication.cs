public class Medication
{
    protected string _name;
    protected string _dosage;
    protected int _medsPerRefill;
    protected string _medType;


public Medication(string name, string dosage, int medsPerRefill)
{
    _name = name;
    _dosage = dosage;
    _medsPerRefill = medsPerRefill;
}
public Medication()
{

}
    public string GetMedType()
    {
        return _medType;
    }
    public string GetDosage()
    {
        return _dosage;
    }
    public string GetMedicationName()
    {
        return _name;
    }
    public int GetMedsPerRefill()
    {
        return _medsPerRefill;
    }
    public virtual string GetExtraInfo()
    {
        return "";
    }
    


}