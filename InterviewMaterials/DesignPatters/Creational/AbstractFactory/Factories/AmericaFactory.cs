using AbstractFactory.AnimalGroups;
using AbstractFactory.Animals;

namespace AbstractFactory.Factories;

public class AmericaFactory : ContinentFactory
{
    public override Herbivore CreateHerbivore()
    {
        return new Bison();
    }

    public override Carnivore CreateCarnivore()
    {
        return new Wolf();
    }
}