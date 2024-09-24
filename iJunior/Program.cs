namespace iJunior;

class Program
{
    static void Main(string[] args)
    {
    const string AttackCommand = "1";
    const string FireBallCommand = "2";
    const string TreatmentCommand = "3";
    const string ExplosionCommand = "4";

    string fightText = "FIGHT!";
    string nextAttackText = "Chouse your next step:";
    string simpleAttackText = "Use simple attack.";
    string fireBallText = "Use fire ball. After that you can use explosion.";
    string treatmentText = "Restore some health.";
    string explosionText = "Now you can use explosion. Let do it!";
    string maxHealthText = "You have restored your health to maximum";
    string notEnoughManaText = "You don't have enough mana";
    string unkownCommandText = "Unknown command. Please try again.";
    string drawText = "Draw!";
    string heroWinText = "You win!";
    string bossWinText = "Boss win!";

    Random random = new Random();
    int maxHeroHelth = 241;
    int minHeroHelth = 150;
    int maxHeroMana = 101;
    int minHeroMana = 50;
    int maxBossHelth = 301;
    int minBossHelth = 200;
    int maxHeroAttack = 101;
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
    int heroHelth = random.Next(minHeroHelth, maxHeroHelth);
    int heroMana = random.Next(minHeroMana,maxHeroMana);
    int bossHelth = random.Next(minBossHelth, maxBossHelth);
    int fireBallCost = random.Next(minFireBallCost, maxFireBallCost);
    int explosionCost = random.Next(minExplosionCost, maxExplosionCost);
    int treatmentCost = random.Next(minTreatmentCost, maxTreatmentCost);

    bool canUseExplosion = false;

    int bossAttack;
    int heroAttack;
    string userInput;

    while (bossHelth > 0 && heroHelth > 0)
    {
        Console.WriteLine($"Your helth: {heroHelth}. Your mana: {heroMana} Boss helth: {bossHelth}");
        Console.Write(fightText);
        Console.WriteLine(nextAttackText);
        Console.WriteLine($"{AttackCommand}. {simpleAttackText}");
        Console.WriteLine($"{FireBallCommand}. {fireBallText}");
        Console.WriteLine($"{TreatmentCommand}. {treatmentText}");

        if (canUseExplosion) {
            Console.WriteLine($"{ExplosionCommand}. {explosionText}");
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
                if (heroMana > fireBallCost)
                {
                    heroAttack = random.Next(minFireBallAttack, maxFireBallAttack);
                    heroMana -= fireBallCost;
                    bossHelth -= heroAttack;
                    
                    canUseExplosion = true;

                    Console.WriteLine($"Dealt {heroAttack} damage to the boss");
                    Console.ReadKey();
                } 
                else
                {
                    Console.WriteLine(notEnoughManaText);
                    Console.ReadKey();
                } 

                break;
            case TreatmentCommand:
                if (heroMana > treatmentCost)
                {
                    heroAttack = random.Next(minHealthRestored, maxHealthRestored);
                    heroMana -= treatmentCost;

                    if ((heroHelth + heroAttack) < maxHeroHelth) 
                    {
                    heroHelth += heroAttack;

                    Console.WriteLine($"You have restored {heroAttack} health");
                    Console.ReadKey();
                    } 
                    else 
                    {
                    heroHelth = maxHeroHelth;

                    Console.WriteLine(maxHealthText);
                    Console.ReadKey();
                    }
                    canUseExplosion = false;
                } 
                else
                {
                    Console.WriteLine(notEnoughManaText);
                    Console.ReadKey();
                }

                break;
            case ExplosionCommand:
                if (canUseExplosion)
                {
                    if (heroMana > explosionCost) 
                    {
                        heroAttack = random.Next(minExplosionAttack, maxExplosionAttack);
                        heroMana -= explosionCost;
                        bossHelth -= heroAttack;
                        canUseExplosion = false;

                        Console.WriteLine($"Dealt {heroAttack} damage to the boss");
                        Console.ReadKey();
                    }
                    else 
                    {
                        Console.WriteLine(notEnoughManaText);
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine(unkownCommandText);
                    Console.ReadKey();
                }

                break;
            default:
                Console.WriteLine(unkownCommandText);
                Console.ReadKey();

                break;
        }

        bossAttack = random.Next(minBossAttack, maxBossAttack);
        heroHelth -= bossAttack;

        Console.WriteLine($"The boss deals {bossAttack} damage to you");
        Console.ReadKey();
    }

    if (heroHelth < 0 && bossHelth < 0)
    {
        Console.WriteLine(drawText);
    }
    else if (bossHelth < 0)
    {
        Console.WriteLine(heroWinText);
    }
    else 
    {
        Console.WriteLine(bossWinText);
    }

    Console.ReadKey();
    }
}
