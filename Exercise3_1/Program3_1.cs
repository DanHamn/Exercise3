using System;

namespace Exercise3_1
{
    class Program3_1
    {
        static void Main()
        {
            //Person person = new(29, "Daniel", "Hamnevik", 182, 125);
            //ValuesToTestException(person);

            PersonHandler pers = new();
            Person person = pers.CreatePerson(29, "Daniel", "Hamnevik", 182, 125);
            int age = pers.GetAge(person);
            pers.SetAge(person, -1);

            Console.WriteLine(person.Age);
            Console.WriteLine(age);
            pers.WriteAge(person);
        }

        private static void ValuesToTestException(Person person)
        {
            NewFName(person, "D");
            NewLName(person, "Hamnevik01234567890123");
            NewAge(person, 0);
        }

        private static void NewAge(Person person, int age)
        {
            try
            {
                person.Age = age;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Try another input");
                _ = int.TryParse(Console.ReadLine(), out int input);
                NewAge(person, input);
            }
        }

        private static void NewFName(Person person, string newFName)
        {
            try
            {
                person.FName = newFName;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Try another input");
                NewFName(person, Console.ReadLine());
            }
        }

        private static void NewLName(Person person, string newLName)
        {
            try
            {
                person.LName = newLName;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Try another input");
                NewLName(person, Console.ReadLine());
            }
        }
    }
}
