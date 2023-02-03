using AbstractFactory.AnimalGroups;

namespace AbstractFactory
{
    public class AnimalWorld
    {
        private readonly Herbivore herbivore;
        private readonly Carnivore carnivore;

        public AnimalWorld(ContinentFactory factory)
        {
            this.carnivore = factory.CreateCarnivore();
            this.herbivore = factory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            this.carnivore.Eat(herbivore);
        }
    }
}