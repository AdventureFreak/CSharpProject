using System;

namespace ConsoleApplication
{
    public class Program
    {

        public static PowerUps Health = new PowerUps();
        public static PowerUps Ammo;
        public static void Main(string[] args)
        {
            Health.RunPowerUp();
            //Console.WriteLine(myString);
        }
    }
}
