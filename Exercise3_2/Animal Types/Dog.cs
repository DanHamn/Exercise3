using System;

namespace Exercise3_2
{
    public class Dog : Animal
    {
        private string goodDog;
        public string GoodDog
        {
            get
            {
                return goodDog;
            }
            set
            {
                if (goodDog != "YES")
                {
                    goodDog = "YES";
                }
            }
        }
        public Dog(string name, int age, int weight, string goodBoy) : base(name, age, weight)
        {
            GoodDog = goodBoy;
        }
        public override void Dosound()
        {
            Console.WriteLine($"The sound that a {GetType().Name} makes is a bark"); ;
        }
    }

}
