using AbstractFactory.AnimalGroups;

namespace AbstractFactory;

public abstract class ContinentFactory
{
    public abstract Herbivore CreateHerbivore();

    public abstract Carnivore CreateCarnivore();
}