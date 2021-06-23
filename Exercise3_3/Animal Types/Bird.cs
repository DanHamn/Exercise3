using System;

namespace Exercise3_3
{
    public class Bird : Animal
    {
        public double WingSpan { get; set; }
        public Bird(string name, int age, double weight, double wingSpan) : base(name, age, weight)
        {
            WingSpan = wingSpan;
        }
        public override void Dosound()
        {
            Console.WriteLine($"The sound that a {GetType().Name} makes is a chirp"); ;
        }
        public override string Stats()
        {
            string stats = $"Stats for a {GetType().Name}:" + Environment.NewLine +
                $"Namn: {Name}, Age: {Age}, Weight: {Weight}, WingSpan: {WingSpan}";
            return stats;
        }
    }

}