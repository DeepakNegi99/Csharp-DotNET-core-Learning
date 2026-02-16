using System;

namespace LearningCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int yint = 10;
            bool xbool = true;
            test obj = new test();
            obj.Name = "Himmy";
            obj.Age = 25;
        }

       class Test
        {
            public string Name { get; set; }
            public int Age { get; set; }

            
        }
    }
}