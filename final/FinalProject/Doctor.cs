public class Doctor
{
    private string _name;
    private string _officeLocation;
    private string _startedSeeing;

    public Doctor(string name, string officeLocation, string startedSeeing)
    {

        if (startedSeeing == "t")
        {
            _startedSeeing = DateTime.Today.ToString("MM/dd/yyyy");
        }
        else
        {
            _startedSeeing = startedSeeing;
        }
        _name = name;
        _officeLocation = officeLocation;
        
    }
    public string GetName()
    {
        return _name;
    }
    public string GetLocation()
    {
        return _officeLocation;
    }
    public string GetStartDate()
    {
        return _startedSeeing;
    }


}