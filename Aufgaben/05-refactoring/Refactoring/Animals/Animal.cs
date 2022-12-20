namespace Refactoring.Animals;

public abstract class Animal
{
    public string Name { get; }

    public string Makenoise { get; set; }

    public Animal(string name)
    {
        this.Name = name;
    }

    public abstract string MakeNoise();
}