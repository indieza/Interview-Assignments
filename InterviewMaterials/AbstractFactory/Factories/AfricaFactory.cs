using AbstractFactory.AnimalGroups;
using AbstractFactory.Animals;

namespace AbstractFactory.Factories
{
    public class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}