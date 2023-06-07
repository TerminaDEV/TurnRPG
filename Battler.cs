namespace TurnRPG;

public abstract class Battler
{
    public string Name { get; protected set; } = "";

    public int HitPoints { get; protected set; }

    public int MaxHitPoints { get; protected set; }

    public int Defence { get; protected set; }

	public int Attack { get; protected set; }

    public int DefendedAttacks { get; protected set; }

    public bool IsAttacked { get; protected set; }

    public PowerStance Stance { get; protected set; }

	public Battler()
    {
        SetDefaults();
        Resurrect();
    }

    protected abstract void SetDefaults();

    public bool IsAlive() => this.HitPoints > 0;

    public bool DealAttack(Battler target)
    {
        if (this.Stance != PowerStance.Still) return false;
        switch (target.Stance)
        {
            //TODO: Сделай события чтобы не делать колхоз пэжэ
            case PowerStance.Still:

                if (this.Attack - target.Defence < 0) break;
                target.HitPoints -= this.Attack - target.Defence;
                //Вот этот колхоз ес чо :downArrow:
                Console.WriteLine($"{this.Name} наносит {this.Attack - target.Defence} урона!");
                break;

            case PowerStance.Defend:

                if (target.DefendedAttacks >= 3)
                {
					target.DefendedAttacks = 0;
					target.HitPoints -= Attack;
					Console.WriteLine($"{this.Name} пробивает защиту {target.Name}\n" +
									  $"и наносит {this.Attack} чистого урона!");
				}
                else 
                {
					target.DefendedAttacks++;
					Console.WriteLine($"{this.Name} не пробивает защиту {target.Name}!");
				}
                break;

            case PowerStance.Parry:

                if (target.DefendedAttacks >= 3) 
                {
					Console.WriteLine($"{target.Name} не удаётся парировать!");
					target.DefendedAttacks = 0;
					target.HitPoints -= Attack;
				}
                else 
                {
					target.DefendedAttacks++;
					Console.WriteLine($"{this.Name} не пробивает защиту {target.Name}!");
					this.HitPoints -= target.Attack;
					Console.WriteLine($"{target.Name} парирует атаку {this.Name}\n" +
						$"и наносит {target.Attack} единиц чистого урона!");
				}
                
				break;
        }
        return true;
    }

    public virtual void ChangeStance(PowerStance stance)
    {
        this.Stance = stance;
    }

    public void ResetProperties()
    {
        this.Stance = PowerStance.Still;
        this.IsAttacked = false;
    }

    public void Resurrect()
    {
        HitPoints = MaxHitPoints;
    }
    public enum PowerStance
    { 
        Still,
        Defend,
        Parry
    }

}
