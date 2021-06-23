using System;

namespace Exercise3_3
{
    public class Worm : Animal
    {
        public double Length { get; set; }
        public Worm(string name, int age, double weight, double length) : base(name, age, weight)
        {
            Length = length;
        }
        public override void Dosound()
        {
            Console.WriteLine($"The sound that a {GetType().Name} makes is nothing");
        }
        public override string Stats()
        {
            string stats = $"Stats for a {GetType().Name}.@" +
                $"Namn: {Name}, Age: {Age}, Weight: {Weight}, Length: {Length}";
            stats = stats.Replace("@", "@" + Environment.NewLine);
            return stats;
        }

    }

}
