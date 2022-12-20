namespace Refactoring.Animals;

public class Cow : Animal
{
    public Cow(string name) : base(name)
    {
        base.Makenoise = "says woof";
    }


    public override string MakeNoise()
    {
        return Name + Makenoise;
    }
}