﻿using System;

namespace Exercise3_3
{
    public class Pelican : Bird
    {
        public double MouthVolume { get; set; }
        public Pelican(string name, int age, double weight, double wingSpan, double mouthVolume) : base(name, age, weight, wingSpan)
        {
            MouthVolume = mouthVolume;
        }
        public override void Dosound()
        {
            Console.WriteLine($"The sound that a {GetType().Name} makes is a chaw"); ;
        }
        public override string Stats()
        {
            string stats = $"Stats for a {GetType().Name}:" + Environment.NewLine +
                $"Namn: {Name}, Age: {Age}, Weight: {Weight}, WingSpan: {WingSpan}, Mouth Volume: {MouthVolume}";
            return stats;
        }
    }

}