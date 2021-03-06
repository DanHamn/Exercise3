using System;

namespace Exercise3_1
{
    internal class PersonHandler
    {
        //Skapar en "Person"
        public Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {
            Person person = new();
            SetAge(person, age);
            SetFName(person, fName);
            SetLName(person, lName);
            SetHeight(person, height);
            SetWeight(person, weight);
            return person;
        }

        //"Set..." koderna sätter dem olika värdena
        //och hanterar ArgumentException från "Person" tills en korrekt input ges
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
        public void SetHeight(Person pers, double height)
        {
            try
            {
                pers.Height = height;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Try another input");
                _ = double.TryParse(Console.ReadLine(), out double input);
                SetHeight(pers, input);
            }
        }
        public void SetWeight(Person pers, double weight)
        {
            try
            {
                pers.Weight = weight;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Try another input");
                _ = double.TryParse(Console.ReadLine(), out double input);
                SetWeight(pers, input);
            }
        }

        //"Get..." koderna returnerar det specifika värdet
        public static int GetAge(Person pers)
        {
            return pers.Age;
        }
        public static string GetFName(Person pers)
        {
            return pers.FName;
        }
        public static string GetLName(Person pers)
        {
            return pers.LName;
        }
        public static double GetHeight(Person pers)
        {
            return pers.Height;
        }
        public static double GetWeight(Person pers)
        {
            return pers.Weight;
        }

        //"Write..." koderna skriver ut värderna i konsolen med en text.
        public static void WriteAge(Person pers)
        {
            Console.WriteLine($"The persons age is {GetAge(pers)}");
        }
        public static void WriteFName(Person pers)
        {
            Console.WriteLine($"The persons first name is {GetFName(pers)}");
        }
        public static void WriteLName(Person pers)
        {
            Console.WriteLine($"The persons last name is {GetLName(pers)}");
        }
        public static void WriteHeight(Person pers)
        {
            Console.WriteLine($"The persons height is {GetHeight(pers)}");
        }
        public static void WriteWeight(Person pers)
        {
            Console.WriteLine($"The persons wight is {GetWeight(pers)}");
        }


    }
}