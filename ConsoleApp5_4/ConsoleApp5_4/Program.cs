using System;

namespace ConsoleApp5_4
{
    class Program
    {
        public struct Mario
        {
            public enum Size
            {
                small
                ,large
            }
            public int numberOfLives;
            public string currentLevel;
            public Size sizeOfMario;
            public bool canShootFireBalls;
            public bool isJumping;
            public int numbberOfCoins;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 5.4 Lab: Creating Mario");

            Mario mario = new Mario();
            mario.numberOfLives = 3;
            mario.currentLevel = "World 1-1";
            mario.sizeOfMario = Mario.Size.small;
            mario.canShootFireBalls = false;
            mario.isJumping = false;
            mario.numbberOfCoins = 100;

            Console.WriteLine("Mario is running through the level and meets a Gooba. Set Mario to jumping so he can kill it");
            mario.isJumping = true;
            Console.WriteLine(mario.isJumping);

            Console.WriteLine("Mario squashes the Gooba. Now he needs to land!");
            mario.isJumping = false;
            Console.WriteLine(mario.isJumping);

            Console.WriteLine("Mario hits a block and finds a 1UP. Increase Mario's life by one.");
            mario.numberOfLives = mario.numberOfLives + 1;
            Console.Write(mario.numberOfLives);

            Console.WriteLine("Mario finds a secret Fire Flower and can now shoot fireballs. Change mario!");
            mario.canShootFireBalls = true;
            Console.WriteLine(mario.canShootFireBalls);

            Console.WriteLine("Mario finds another power up mushroom and gets big. Change Mario");
            mario.sizeOfMario = Mario.Size.large;
            Console.WriteLine(mario.sizeOfMario);

            Console.WriteLine("Mario finds a stash of gold coins. Give Mario 10 coins.");
            mario.numbberOfCoins = mario.numbberOfCoins + 10;
            Console.WriteLine(mario.numbberOfCoins);

            Console.WriteLine("Mario finshes the level! Change Mario's current level to World 1-2");
            mario.currentLevel = "World 1-2";
            Console.WriteLine(mario.currentLevel);

        }
    }
}
