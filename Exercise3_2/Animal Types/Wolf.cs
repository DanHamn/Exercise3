using System;

namespace Exercise3_2
{
    public class Wolf : Animal
    {
        public string Hungry { get; set; }
        public Wolf(string name, int age, int weight, string hungry) : base(name, age, weight)
        {
            Hungry = hungry;
        }
        public override void Dosound()
        {
            Console.WriteLine($"The sound that a {GetType().Name} makes is a bark"); ;
        }
    }

}
