using System; 

public class Ying : Yang, Tao
{
    public Ying(string secretStyle) : base(secretStyle)
    {

    }

    public void Learn()
    {
        Console.WriteLine("Embody the subtle nature of Yin energy.");
    }
}