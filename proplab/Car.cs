internal class Car
{
    private string licenseNumber;
    private string color;

    public string GetLicenseNumber()
    {
        return $"*** {licenseNumber.ToUpper()} ***";
    }

    public void SetLicenseNumber(string lNumber)
    {
        bool numberPartOk;
        numberPartOk = int.TryParse(lNumber.Substring(3), out int result);

        if (lNumber.Length > 6 || !numberPartOk) throw new ArgumentException();
        else if(result < 000 || result > 999) throw new ArgumentException();
        else licenseNumber = lNumber;
    }

    public void SetColor(string color)
    {
        if (color.ToLower() == "red" || color.ToLower() == "green" || color.ToLower() == "blue" || color.ToLower() == "yellow")
            this.color = color;
        else
            throw new ArgumentException();
    }

    public string GetColor()
    {
        if (color.ToLower() == "red")
            return "Röd";
        else if (color.ToLower() == "green")
            return "Grön";
        else if (color.ToLower() == "blue")
            return "Blå";
        else if(color.ToLower() == "yellow")
            return "Gul";
        else
            throw new ArgumentException();
    }

    public Car AddCar()
    {
        return new Car();
    }

}