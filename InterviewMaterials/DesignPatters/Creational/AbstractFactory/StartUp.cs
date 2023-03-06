using AbstractFactory.Factories;

namespace AbstractFactory;

public class StartUp
{
    private static void Main()
    {
        ContinentFactory africa = new AfricaFactory();
        AnimalWorld world = new(africa);
        world.RunFoodChain();

        ContinentFactory america = new AmericaFactory();
        world = new AnimalWorld(america);
        world.RunFoodChain();
    }
}