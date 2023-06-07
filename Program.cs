using System.Diagnostics.CodeAnalysis;

namespace TurnRPG;

static class Program
{
    static void log(string message) => Console.WriteLine(message);
    static void Main(string[] args)
    {
        Player player = new Player();
        Goblin goblin = new Goblin();
        Random rnd = new Random();
        while (player.IsAlive() && goblin.IsAlive())
        {
        
        }
    }
}
