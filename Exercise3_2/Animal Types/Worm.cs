using System;

namespace Exercise3_2
{
    public class Worm : Animal
    {
        public int Length { get; set; }
        public Worm(string name, int age, int weight, int length) : base(name, age, weight)
        {
            Length = length;
        }
        public override void Dosound()
        {
            Console.WriteLine($"The sound that a {GetType().Name} makes is nothing"); ;
        }
    }

}
