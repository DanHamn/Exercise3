using System;

namespace Exercise3_3
{
    public class Wolfman : Wolf, IPerson
    {
        public string Saying { get; private set; }
        public Wolfman(string name, int age, int weight, string hungry, string saying) : base(name, age, weight, hungry)
        {
            Saying = saying;
        }

        public void Talk()
        {
            Console.WriteLine($"{Name}, the {GetType().Name} is saying \"{Saying}\""); ;
        }
        public override string Stats()
        {
            return base.Stats() + $", Is saying: \"{Saying}\"";
        }
    }

}
