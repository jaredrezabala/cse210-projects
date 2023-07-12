public class Reception : Event
{
    private string _rsvpEmail;

    public string RSVPEmail
    {
        get { return _rsvpEmail; }
        set { _rsvpEmail = value; }
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nRSVP Email: {_rsvpEmail}";
    }
}
