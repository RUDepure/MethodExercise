using System;
using System.Collections.Generic;
using System.Text;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            getStand();
            double value;
            value = Add(2, 4);
            Console.WriteLine(value);
            value = Add(2, 4, 6);
            Console.WriteLine(value);
            value = Add(1, 1, 1, 1, 1);
            Console.WriteLine(value);
        }

        static void getStand()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("What is your band?");
            string band = Console.ReadLine();

            Console.WriteLine($"You, {name} are a Stand user. Your Stand is called {band} and it looks like a humanoid {color} {animal}.");
        }

        static double Add(params double[] nums)
        {
            double c = nums[0]; 
            for (int i = 1; i < nums.Length; i++)
            {
                c += nums[i];
            }

            return c;
        }

        static double Subtract(params double[] nums)
        {
            double c = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                c -= nums[i];
            }

            return c;
        }

        static double Multiply(params double[] nums)
        {
            double c = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                c *= nums[i];
            }

            return c;
        }

        static double Divide(params double[] nums)
        {
            double c = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                c /= nums[i];
            }

            return c;
        }

        static double Modulus(params double[] nums)
        {
            double c = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                c %= nums[i];
            }

            return c;
        }

    }
}
