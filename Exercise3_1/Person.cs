using System;

namespace Exercise3_1
{
    internal class Person
    {
        private int age;
        private string fName;
        private string lName;
        private int height;
        private int weight;
        public Person() { }
        public Person(int _age, string _fName, string _lName, int _height, int _weight)
        {
            age = _age;
            fName = _fName;
            lName = _lName;
            height = _height;
            weight = _weight;
        }
        public int Age
        {
            get => age;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Age)} cannot be 0 or less");
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
                    throw new ArgumentException($"{nameof(FName)} cannot be null or empty");
                }
                else if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException($"{nameof(FName)} cannot be shorter then 2 char. or longer then 10 char.");

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
                    throw new ArgumentException($"{nameof(LName)} cannot be null or empty");
                }
                else if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException($"{nameof(LName)} cannot be shorter then 3 char. or longer then 15 char.");

                }
                lName = value;
            }
        }
        public int Height
        {
            get => height;
            set => height = value;
        }
        public int Weight
        {
            get => weight;
            set => weight = value;
        }
    }
}