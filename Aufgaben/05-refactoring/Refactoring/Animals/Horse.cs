namespace Refactoring.Animals;

public class Horse : Animal
{
    public Horse(string name) : base(name)
    {
        base.Makenoise = " says 'neigh'";
    }

    public override string MakeNoise()
    {
        return Name + Makenoise;
    }
}