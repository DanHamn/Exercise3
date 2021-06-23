using System;

namespace Exercise3_3
{
    public class Flamingo : Bird
    {
        public int LegsOnGround { get; set; }
        public Flamingo(string name, int age, double weight, double wingSpan, int legsOnGround) : base(name, age, weight, wingSpan)
        {
            LegsOnGround = legsOnGround;
        }
        public override void Dosound()
        {
            Console.WriteLine($"The sound that a {GetType().Name} makes is a chaw"); ;
        }
        public override string Stats()
        {
            string stats = $"Stats for a {GetType().Name}:" + Environment.NewLine +
                $"Namn: {Name}, Age: {Age}, Weight: {Weight}, WingSpan: {WingSpan}, Legs On Ground: {LegsOnGround}";
            return stats;
        }
    }

}