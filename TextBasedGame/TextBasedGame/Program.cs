using System;

class Program
{
    static int oyuncuCan = 100;
    static int dusmanCan = 50;
    static Random random = new Random();

    static void Main()
    {
        dusmanCan = 50;

        Console.WriteLine("Welcome to the My Text-Based Fighting and Adventure Game!  Eyup Ensar Ozcen 205040091 \n");
        Console.WriteLine("The day has come for you to set out on a journey to find the rare treasure. The entire village awaits your success in defeating all your enemies, discovering the treasure, \n and saving the lives of the people in the village. Good luck!\n");

        MaceraOyunu();
    }

    static void MaceraOyunu()
    {
        Console.WriteLine("You bid farewell to your family. You are leaving the village. The entire village is looking at you with pride. You set out on the road, and the path ahead splits into two. Which path will you choose?\n");
        Console.WriteLine("1. Choose the forest path");
        Console.WriteLine("2. Choose the mountain path");

        int secim = SecimAl(2);

        if (secim == 1)
        {
            OrmanYolu();
        }
        else
        {
            DagYolu();
        }
    }

    static void OrmanYolu()
    {
        Console.WriteLine("You are on the forest path. Everything is very quiet and eerie. A strong river stands in your way. On the other side, eerie sounds emanate from the forest. What will you do?\n");
        Console.WriteLine("1. Attempt to cross the river.");
        Console.WriteLine("2.Try to find another path through the forest");

        int secim = SecimAl(2);

        if (secim == 1)
        {
            Console.WriteLine("My friend, the river's current swept you away, and you fell down the waterfall, hitting a rock. Unfortunately, you have died... Your family will miss you dearly... Game over!");
        }
        else
        {
            Console.WriteLine("You acted like a brave warrior and headed towards the forest. As you traversed through the forest, you found a different path and continued on safely.");

            DusmanlaKarsilasma("Goblin");
            if (oyuncuCan > 0)
            {
                Console.WriteLine("A large cave appears before you, its interior dark and ominous. Will you enter the cave?\n");
                Console.WriteLine("1. Yes, enter the cave");
                Console.WriteLine("2. No, move away from the cave.");

                secim = SecimAl(2);

                if (secim == 1)
                {
                    Console.WriteLine("You entered the cave and lit your torch. While exploring the cave, a spider jumped at you. In your attempt to shake it off, you hit the wall and found a mysterious door. And WHAT IS THAT!!!\n You've found the long sought-after treasure. Your family is proud of you! You won the game!");
                }
                else
                {
                    Console.WriteLine("The cave frightened you, and you ran away. Suddenly, a pack of wolves appeared, and unfortunately, you died... Game over!");
                }
            }
            else
            {
                Console.WriteLine("You were defeated in the battle against the enemy. Game over!");
            }
        }
    }

    static void DagYolu()
    {
        Console.WriteLine("You are on the mountain path. The surroundings are getting cold, and it's hard to see due to heavy snowfall. A glacier stands in your way. You can either climb it or find another path.\n");
        Console.WriteLine("1. Attempt to climb the glacier.");
        Console.WriteLine("2. Try to find another path around the mountain.");

        int secim = SecimAl(2);

        if (secim == 1)
        {
            Console.WriteLine("Bravely attempting to climb the glacier didn't lead to a favorable outcome. Your hand slipped, and you fell from a great height. You couldn't succeed. Game over!\n");
        }
        else
        {
            Console.WriteLine("Despite the challenging weather conditions, you are doing your best to find that treasure. Somehow, you found a different path around the mountain and continued on safely.\n");

            DusmanlaKarsilasma("Draconian");
            if (oyuncuCan > 0)
            {
                Console.WriteLine("A colossal dragon cave stands before you. It looks extremely eerie and frightening. Will you enter the cave?");
                Console.WriteLine("1. Yes, enter the cave");
                Console.WriteLine("2. No, move away from the cave.");

                secim = SecimAl(2);

                if (secim == 1)
                {
                    Console.WriteLine("You entered the cave and lit your torch. While exploring the cave, a spider jumped at you. In your attempt to shake it off, you hit the wall and found a mysterious door.\n And WHAT IS THAT!!! You've found the long sought-after treasure. Your family is proud of you! You won the game!");
                }
                else
                {
                    Console.WriteLine("You fled in fear! You heard a roar from behind, and as you looked back while running, you saw nothing. However, when you looked ahead, the only thing you saw was that you had jumped off a cliff.\n You died... Game over!\n");
                }
            }
            else
            {
                Console.WriteLine("You were defeated in the battle against the enemy. You are the shame of the village. Disgraceful... Game over!\n");
            }
        }
    }

    static void DusmanlaKarsilasma(string dusmanAdi)
    {
        Console.WriteLine($"\n You encountered {dusmanAdi} Now is the opportunity to prove the worth of years of combat training. The battle begins...");

        while (oyuncuCan > 0)
        {
            Console.WriteLine($"Player Health: {oyuncuCan}  {dusmanAdi} Health: {dusmanCan}\n");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Run");

            int secim = SecimAl(2);

            if (secim == 1)
            {
                Saldır(dusmanAdi);
            }
            else
            {
                Console.WriteLine($"You escaped from {dusmanAdi}  and out of fear, you wet yourself. ");
                break;
            }

            if (oyuncuCan <= 0)
            {
                Console.WriteLine($"Player Health: 0  {dusmanAdi} Health: {dusmanCan}");
                Console.WriteLine("You were defeated in the battle against the enemy... Game over!");
                break;
            }
            if (dusmanCan <= 0)
            {
                Console.WriteLine($"Enemy Health: 0 ");
                Console.WriteLine("You emerged victorious in the battle against the enemy. You showcased your warrior spirit.\n");
                break;
            }

            DusmanSaldır(dusmanAdi);
            if (oyuncuCan <= 0)
            {
                Console.WriteLine($"Player Health: 0  {dusmanAdi} Health: {dusmanCan}");
                Console.WriteLine("You were defeated in the battle against the enemy. Game over!");
                break;
            }
        }
    }

    static void Saldır(string dusmanAdi)
    {
        int oyuncuHasar = random.Next(5, 15);



        if (oyuncuCan > 0)
        {
            dusmanCan -= oyuncuHasar;
            Console.WriteLine($"\nAttack! Player damaged {oyuncuHasar} .");
        }
    }

    static void DusmanSaldır(string dusmanAdi)
    {
        int dusmanHasar = random.Next(3, 10);
        oyuncuCan -= dusmanHasar;

        Console.WriteLine($"{dusmanAdi} attacking! {dusmanAdi} {dusmanHasar} damaged.");
    }

    static int SecimAl(int maksSecim)
    {
        int secim;
        while (true)
        {
            Console.Write("\nChoose (1-" + maksSecim + "): ");
            if (int.TryParse(Console.ReadLine(), out secim) && secim >= 1 && secim <= maksSecim)
            {
                break;
            }
            else
            {
                Console.WriteLine("\nInvalid input. Please try again.\n");
            }
        }
        return secim;
    }
}

