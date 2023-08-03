using System;

namespace DZCamp
{
    class Program
    {
        private static void Main(string[] args)
        {
            Unit defensiveUnit = new Unit(25, 100f, 10f, Unit.Factions.Evil, true);
            Unit attackingUnit = new Unit(25, 100f, 10f, Unit.Factions.Neutral, true);
            GetDamage(defensiveUnit, attackingUnit);

            Console.ReadKey();
        }

        public static void GetDamage(Unit defensiveUnit, Unit attackingUnit)
        {
            if (defensiveUnit.faction == attackingUnit.faction)
            {
                if (attackingUnit.berserkStatus)
                {
                    defensiveUnit.health -= (attackingUnit.baseDamage / 2) * 2 * (1f - (defensiveUnit.armor * 0.2f / 100));
                }
                else defensiveUnit.health -= (attackingUnit.baseDamage / 2) * (1f - (defensiveUnit.armor / 100));
            }

            if (defensiveUnit.faction != attackingUnit.faction && (attackingUnit.faction != Unit.Factions.Neutral && defensiveUnit.faction != Unit.Factions.Neutral))
            {
                if (attackingUnit.berserkStatus)
                {
                    defensiveUnit.health -= (attackingUnit.baseDamage * 2) * 2 * (1f - (defensiveUnit.armor * 0.2f / 100));


                }
                else defensiveUnit.health -= (attackingUnit.baseDamage * 2) * (1f - (defensiveUnit.armor / 100));
            }

            if (defensiveUnit.faction != attackingUnit.faction && (attackingUnit.faction == Unit.Factions.Neutral || defensiveUnit.faction == Unit.Factions.Neutral))
            {
                if (attackingUnit.berserkStatus)
                {
                    defensiveUnit.health -= attackingUnit.baseDamage * 2 * (1f - (defensiveUnit.armor * 0.2f / 100));


                }
                else defensiveUnit.health -= attackingUnit.baseDamage * (1f - (defensiveUnit.armor / 100));
            }


            Console.WriteLine($"Здоровье защищающегося юнита после атаки: {defensiveUnit.health}");
        }
    }
}

class Unit
{
    public float armor;
    public float baseDamage;
    public Factions faction;
    public float health;
    public bool berserkStatus;

    public Unit(float Damage, float Health, float Armor, Factions Faction, bool BerserkStatus)
    {
        baseDamage = Damage;
        health = Health;
        armor = Armor;
        faction = Faction;
        berserkStatus = BerserkStatus;
    }


    public enum Factions
    {
        Good,
        Evil,
        Neutral
    }

}