namespace iJunior;

class Program
{
    static void Main(string[] args)
    {
        const string AttackCommand = "1";
        const string FireBallCommand = "2";
        const string TreatmentCommand = "3";
        const string ExplosionCommand = "4";

        string notEnoughManaText = "You don't have enough mana";
        string unkownCommandText = "Unknown command. Please try again.";

        Random random = new Random();
        int maxHeroHealth = 240;
        int minHeroHealth = 150;
        int maxHeroMana = 100;
        int minHeroMana = 50;
        int maxBossHelth = 300;
        int minBossHelth = 200;
        int maxHeroAttack = 100;
        int minHeroAttack = 25;
        int maxFireBallAttack = 150;
        int minFireBallAttack = 10;
        int maxFireBallCost = 15;
        int minFireBallCost = 2;
        int maxExplosionAttack = 250;
        int minExplosionAttack = 25;
        int maxExplosionCost = 30;
        int minExplosionCost = 15;
        int maxHealthRestored = 75;
        int minHealthRestored = 5;
        int maxTreatmentCost = 20;
        int minTreatmentCost = 5;
        int maxBossAttack = 150;
        int minBossAttack = 75;
        int heroHealth = random.Next(minHeroHealth, maxHeroHealth + 1);
        int heroMana = random.Next(minHeroMana, maxHeroMana + 1);
        int bossHelth = random.Next(minBossHelth, maxBossHelth + 1);
        int fireBallCost = random.Next(minFireBallCost, maxFireBallCost + 1);
        int explosionCost = random.Next(minExplosionCost, maxExplosionCost + 1);
        int treatmentCost = random.Next(minTreatmentCost, maxTreatmentCost + 1);

        bool canUseExplosion = false;

        int bossAttack;
        int heroAttack;
        string userInput;

        while (bossHelth > 0 && heroHealth > 0)
        {
            Console.WriteLine($"Your helth: {heroHealth}. Your mana: {heroMana} Boss helth: {bossHelth}");
            Console.Write("FIGHT!");
            Console.WriteLine("Chouse your next step:");
            Console.WriteLine($"{AttackCommand}. Use simple attack.");
            Console.WriteLine($"{FireBallCommand}. Use fire ball. After that you can use explosion.");
            Console.WriteLine($"{TreatmentCommand}. Restore some health.");

            if (canUseExplosion)
            {
                Console.WriteLine($"{ExplosionCommand}. Now you can use explosion. Let do it!");
            }

            userInput = Console.ReadLine();

            switch (userInput)
            {
                case AttackCommand:
                    heroAttack = random.Next(minHeroAttack, maxHeroAttack);
                    bossHelth -= heroAttack;
                    canUseExplosion = false;

                    Console.WriteLine($"Dealt {heroAttack} damage to the boss");
                    Console.ReadKey();
                    break;

                case FireBallCommand:
                    if (heroMana >= fireBallCost)
                    {
                        heroAttack = random.Next(minFireBallAttack, maxFireBallAttack);
                        heroMana -= fireBallCost;
                        bossHelth -= heroAttack;

                        canUseExplosion = true;

                        Console.WriteLine($"Dealt {heroAttack} damage to the boss");
                    }
                    else
                    {
                        Console.WriteLine(notEnoughManaText);
                    }
                    break;

                case TreatmentCommand:
                    if (heroMana >= treatmentCost)
                    {
                        heroAttack = random.Next(minHealthRestored, maxHealthRestored);
                        heroMana -= treatmentCost;

                        if ((heroHealth + heroAttack) < maxHeroHealth)
                        {
                            heroHealth += heroAttack;

                            Console.WriteLine($"You have restored {heroAttack} health");
                        }
                        else
                        {
                            heroHealth = maxHeroHealth;

                            Console.WriteLine("You have restored your health to maximum");
                        }

                        canUseExplosion = false;
                    }
                    else
                    {
                        Console.WriteLine(notEnoughManaText);
                    }
                    break;

                case ExplosionCommand:
                    if (canUseExplosion)
                    {
                        if (heroMana >= explosionCost)
                        {
                            heroAttack = random.Next(minExplosionAttack, maxExplosionAttack);
                            heroMana -= explosionCost;
                            bossHelth -= heroAttack;
                            canUseExplosion = false;

                            Console.WriteLine($"Dealt {heroAttack} damage to the boss");
                        }
                        else
                        {
                            Console.WriteLine(notEnoughManaText);
                        }
                    }
                    else
                    {
                        Console.WriteLine(unkownCommandText);
                    }
                    break;

                default:
                    Console.WriteLine(unkownCommandText);
                    break;
            }

            Console.ReadKey();

            bossAttack = random.Next(minBossAttack, maxBossAttack);
            heroHealth -= bossAttack;

            Console.WriteLine($"The boss deals {bossAttack} damage to you");
            Console.ReadKey();
        }

        if (heroHealth < 0 && bossHelth < 0)
        {
            Console.WriteLine("Draw!");
        }
        else if (bossHelth < 0)
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("Boss win!");
        }

        Console.ReadKey();
    }
}
