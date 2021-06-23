﻿using System;
using System.Drawing;

namespace Exercise3_3
{
    public class Dog : Animal
    { 
    
        public string Color { get; set; }
        public Dog(string name, int age, double weight, string color) : base(name, age, weight)
        {
            Color = color;
        }
        public override void Dosound()
        {
            Console.WriteLine($"The sound that a {GetType().Name} makes is a bark"); ;
        }
        public override string Stats()
        {
            string stats = $"Stats for a {GetType().Name}:" + Environment.NewLine +
                $"Namn: {Name}, Age: {Age}, Weight: {Weight}, Color: {Color}";
            return stats;
        }
        public void GoodDog()
        {
            Console.WriteLine($"Are {Name} a good dog? Yes, they are");
        }
    }

}
