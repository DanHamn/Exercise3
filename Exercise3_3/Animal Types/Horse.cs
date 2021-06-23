using System;

namespace Exercise3_3
{
    public class Horse : Animal
    {
        public string Tame { get; set; }
        public Horse(string name, int age, double weight, string tame) : base(name, age, weight)
        {
            Tame = tame;
        }
        public override void Dosound()
        {
            Console.WriteLine($"The sound that a {GetType().Name} makes is a Neigh"); ;
        }
        public override string Stats()
        {
            string stats = $"Stats for a {GetType().Name}:" + Environment.NewLine +
                $"Namn: {Name}, Age: {Age}, Weight: {Weight}, Tame: {Tame}";
            return stats;
        }
    }

}
