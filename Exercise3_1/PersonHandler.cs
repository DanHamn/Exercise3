using System;

namespace Exercise3_1
{
    internal class PersonHandler
    {
        public Person CreatePerson(int age, string fName, string lName, int height, int weight)
        {
            Person person = new();
            SetAge(person, age);
            SetFName(person, fName);
            SetLName(person, lName);
            SetHeight(person, height);
            SetWeight(person, weight);
            return person;
        }
        public void SetAge(Person pers, int age)
        {
            try
            {
                pers.Age = age;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Try another input");
                _ = int.TryParse(Console.ReadLine(), out int input);
                SetAge(pers, input);
            }
        }
        public void SetFName(Person pers, string fName)
        {
            try
            {
                pers.FName = fName;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Try another input");
                SetFName(pers, Console.ReadLine());
            }
        }
        public void SetLName(Person pers, string LName)
        {
            try
            {
                pers.LName = LName;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Try another input");
                SetLName(pers, Console.ReadLine());
            }
        }
        public void SetHeight(Person pers, int height)
        {
            try
            {
                pers.Height = height;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Try another input");
                _ = int.TryParse(Console.ReadLine(), out int input);
                SetHeight(pers, input);
            }
        }
        public void SetWeight(Person pers, int weight)
        {
            try
            {
                pers.Weight = weight;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Try another input");
                _ = int.TryParse(Console.ReadLine(), out int input);
                SetWeight(pers, input);
            }
        }

        public int GetAge(Person pers)
        {
            return pers.Age;
        }
        public string GetFName(Person pers)
        {
            return pers.FName;
        }
        public string GetLName(Person pers)
        {
            return pers.LName;
        }
        public int GetHeight(Person pers)
        {
            return pers.Height;
        }
        public int GetWeight(Person pers)
        {
            return pers.Weight;
        }


        public void WriteAge(Person pers)
        {
            Console.WriteLine(pers.Age);
        }
        public void WriteFName(Person pers)
        {
            Console.WriteLine(pers.FName);
        }
        public void WriteLName(Person pers)
        {
            Console.WriteLine(pers.LName);
        }
        public void WriteHeight(Person pers)
        {
            Console.WriteLine(pers.Height);
        }
        public void WriteWeight(Person pers)
        {
            Console.WriteLine(pers.Weight);
        }


    }
}