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
           
            log($"{player.Name}: {player.HitPoints} \n {goblin.Name}: {goblin.HitPoints} ");
            //Player turn

           
		playerDecision1:
            string input = Console.ReadLine();
			player.ResetProperties();
			
			switch (input)
            {
                case "1": player.DealAttack(goblin); break;
                case "2": player.ChangeStance(Battler.PowerStance.Defend); break;
                case "3": player.ChangeStance(Battler.PowerStance.Parry); break;
                default: goto playerDecision1; 
            }
			goblin.ResetProperties();
			switch (rnd.Next(1,4))
            {
				case 1: goblin.DealAttack(player); break;
				case 2: goblin.ChangeStance(Battler.PowerStance.Defend); log("2"); break;
				case 3: goblin.ChangeStance(Battler.PowerStance.Parry); log("3"); break;
                default: log("Это ROFLS"); break;
			}
            Console.ReadLine();
			Console.Clear();
		}
    }
}
