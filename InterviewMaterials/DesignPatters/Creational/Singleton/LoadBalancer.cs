namespace Singleton;

public sealed class LoadBalancer
{
    private static LoadBalancer? instance;
    private readonly List<string> servers = new();
    private readonly Random random = new();
    private static readonly object locker = new();

    private LoadBalancer()
    {
        this.servers.Add("Server I");
        this.servers.Add("Server II");
        this.servers.Add("Server III");
        this.servers.Add("Server IV");
        this.servers.Add("Server V");
    }

    public string Server
    {
        get
        {
            int r = this.random.Next(this.servers.Count);
            return this.servers[r].ToString();
        }
    }

    public static LoadBalancer GetLoadBalancer()
    {
        if (instance == null)
        {
            lock (locker)
            {
                instance ??= new LoadBalancer();
            }
        }

        return instance;
    }
}