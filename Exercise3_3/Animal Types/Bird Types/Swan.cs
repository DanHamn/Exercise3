using System;

namespace Exercise3_3
{
    public class Swan : Bird
    {
        public string Angry { get; set; }
        public Swan(string name, int age, double weight, double wingSpan, string angry) : base(name, age, weight, wingSpan)
        {
            Angry = angry;
        }
        public override void Dosound()
        {
            Console.WriteLine($"The sound that a {GetType().Name} makes is a chaw"); ;
        }
        public override string Stats()
        {
            return base.Stats() + $", Angry: {Angry}";
        }
    }

}