public class Address
{
    private string streetAddress;
    private string city;
    private string stateProvince;
    private string country;

    public void SetStreetAddress(string streetAddress)
    {
        this.streetAddress = streetAddress;
    }

    public string GetStreetAddress()
    {
        return streetAddress;
    }

    public void SetCity(string city)
    {
        this.city = city;
    }

    public string GetCity()
    {
        return city;
    }

    public void SetStateProvince(string stateProvince)
    {
        this.stateProvince = stateProvince;
    }

    public string GetStateProvince()
    {
        return stateProvince;
    }

    public void SetCountry(string country)
    {
        this.country = country;
    }

    public string GetCountry()
    {
        return country;
    }

    public bool IsInUSA()
    {
        return country == "USA";
    }

    public string GetFullAddress()
    {
        return $"{streetAddress}, {city}, {stateProvince}, {country}";
    }
}
