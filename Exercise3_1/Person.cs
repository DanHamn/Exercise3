using System;

namespace Exercise3_1
{
    internal class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;
        public Person() { }
        public Person(int _age, string _fName, string _lName, double _height, double _weight)
        {
            age = _age;
            fName = _fName;
            lName = _lName;
            height = _height;
            weight = _weight;
        }
        //De olika get/set metoderna och deras olika exceptions
        public int Age
        {
            get => age;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age most be an integer and cannot be 0 or less");
                }
                age = value;
            }
        }
        public string FName
        {
            get => fName;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be null or empty");
                }
                else if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException("First name cannot be shorter then 2 char. or longer then 10 char.");

                }
                fName = value;
            }
        }
        public string LName
        {
            get => lName;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name cannot be null or empty");
                }
                else if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Last name cannot be shorter then 3 char. or longer then 15 char.");

                }
                lName = value;
            }
        }
        public double Height
        {
            get => height;
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height most be a number and cannot be 0 or less");
                }
                height = value;
            }
        }
        public double Weight
        {
            get => weight;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Weight most be a number and cannot be 0 or less");
                }
                weight = value;
            }
        }
    }
}