using System;

namespace Exercise3_3
{
    public class Hedgehog : Animal
    {
        public int NrOfSpikes { get; set; }
        public Hedgehog(string name, int age, double weight, int nrOfSpikes) : base(name, age, weight)
        {
            NrOfSpikes = nrOfSpikes;
        }
        public override void Dosound()
        {
            Console.WriteLine($"The sound that a {GetType().Name} makes is a snuffling"); ;
        }
        public override string Stats()
        {
            return base.Stats() + $", Number of spikes: {NrOfSpikes}";
        }
    }

}
