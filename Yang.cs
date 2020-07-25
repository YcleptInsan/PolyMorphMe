using System; 

public abstract class Yang : Tao
{
    private string _asiri;
    private string _awo;
    
    public string An {get; set;}
    public string Lu {get; set;}

    public string Secrets(string An, string Lu)
    {
        _asiri = An;
        _awo = Lu;

        return An + " " + Lu;
    }
    protected Yang() {}

    protected Yang(string secretStyle)
    {
        _asiri = secretStyle;
    } 

    protected Yang(string secretStyle, string secretAwo)
    {
        _asiri = secretStyle;
        _awo = secretAwo;
    } 

    // Polymorphism

    public virtual void Technique()
    {
        Console.WriteLine($"This is the first technique that comes down from {_asiri}");
    }

    public virtual void Technique(string immortalBreath)
    {
        Console.WriteLine($"The {immortalBreath} imbues the specie with the consciousness of {_asiri}");
    }

    public virtual void Technique(string immortalBreath, string immortalTouch)
    {
        Console.WriteLine($"The {immortalBreath} and {immortalTouch} imbues the specie with the consciousness of {_awo}");
    }
    
    public void Learn()
    {
        Console.WriteLine("Embody the nature of force with Yang energy.");
    }
    
}
