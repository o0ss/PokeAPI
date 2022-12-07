public class NamedAPIResource
{
    public string name {get; set;}
    public string url {get; set;}

    public override string ToString()
    {
        return name;
    }
}