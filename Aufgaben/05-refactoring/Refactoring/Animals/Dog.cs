namespace Refactoring.Animals;

public class Dog : Animal
{
    public Dog(string name) 
        : base(name) 
    {
        base.Makenoise = " says 'neigh'";
    }

    public override string MakeNoise()
    {
        return Name + Makenoise;
    }
}