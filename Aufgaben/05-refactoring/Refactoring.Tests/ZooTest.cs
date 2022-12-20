using Refactoring.Animals;
using Xunit;

namespace Refactoring.Tests;

public class ZooTest
{
    [Fact]
    public void MakeNoise_CorrectAnimal_CorrectNoise()
    {
        Animal animal = new Dog("Ben");
        var expected = "Ben says 'neigh'";

        var actual = animal.MakeNoise();

        Assert.Equal(expected, actual);
    }
}