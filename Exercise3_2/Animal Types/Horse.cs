using System;

namespace Exercise3_2
{
    public class Horse : Animal
    {
        public string Tame { get; set; }
        public Horse(string name, int age, int weight, string tame) : base(name, age, weight)
        {
            Tame = tame;
        }
        public override void Dosound()
        {
            Console.WriteLine($"The sound that a {GetType().Name} makes is a Neigh"); ;
        }
    }

}
