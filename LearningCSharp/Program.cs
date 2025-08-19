using System;

namespace LearningCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name = "Deepak Negi";
            char grade = 'A';
            int age = 28;
            bool isMale = false;

            //string name = Console.ReadLine();

            //Console.WriteLine(name);
            //Convert.ToString(age);

             SayHi(name);


        }

        static void SayHi(string name)
        {
            Console.WriteLine("Hi"+ name);
        }
    }
}