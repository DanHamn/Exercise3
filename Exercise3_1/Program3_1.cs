using System;

namespace Exercise3_1
{
    class Program3_1
    {
        static void Main()
        {
            UserInput(out int age, out string fName, out string lName, out double height, out double weight);

            CodeOutput(age, fName, lName, height, weight);
        }
        //Den här koden skriver i konsolen vilken input som ska lägga till och returerar den
        private static void UserInput(out int age, out string fName, out string lName, out double height, out double weight)
        {
            Console.WriteLine("To Create a Person input: Age, First Name, Last Name, Height and Weight");
            Console.WriteLine("Input Age:");
            string ageTest = (Console.ReadLine());
            while (!int.TryParse(ageTest, out age))
            {
                Console.WriteLine("Most input an integer");
                ageTest = Console.ReadLine();
            }
            Console.WriteLine("Input First Name:");
            fName = Console.ReadLine();
            Console.WriteLine("Input Last Name");
            lName = Console.ReadLine();
            Console.WriteLine("Input Height (\",\" for decimals)");
            string heightTest = Console.ReadLine();
            while (!double.TryParse(heightTest, out height))
            {
                Console.WriteLine("Most input a number");
                heightTest = Console.ReadLine();
            }

            Console.WriteLine("Input Weight (\",\" for decimals)");
            string weightTest = Console.ReadLine();
            while (!double.TryParse(weightTest, out weight))
            {
                Console.WriteLine("Most input a number");
                weightTest = Console.ReadLine();
            }
        }
        
        //Den här koden tar inputen från användaren och skappar en "Person" genom "PersonHandler"
        //och returnerar resultatet när alla exceptions är hanterade
        private static void CodeOutput(int age, string fName, string lName, double height, double weight)
        {
            PersonHandler pers = new();
            Person person = pers.CreatePerson(age, fName, lName, height, weight);
            PersonHandler.WriteAge(person);
            PersonHandler.WriteFName(person);
            PersonHandler.WriteLName(person);
            PersonHandler.WriteHeight(person);
            PersonHandler.WriteWeight(person);
        }


        // Nedanför är den första koden för undantagshantering.
        // Den nuvarande koden är i "PersonHandler".

        //private static void NewAge(Person person, int age)
        //{
        //    try
        //    {
        //        person.Age = age;
        //    }
        //    catch (ArgumentException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        Console.WriteLine("Try another input");
        //        _ = int.TryParse(Console.ReadLine(), out int input);
        //        NewAge(person, input);
        //    }
        //}

        //private static void NewFName(Person person, string newFName)
        //{
        //    try
        //    {
        //        person.FName = newFName;
        //    }
        //    catch (ArgumentException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        Console.WriteLine("Try another input");
        //        NewFName(person, Console.ReadLine());
        //    }
        //}

        //private static void NewLName(Person person, string newLName)
        //{
        //    try
        //    {
        //        person.LName = newLName;
        //    }
        //    catch (ArgumentException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        Console.WriteLine("Try another input");
        //        NewLName(person, Console.ReadLine());
        //    }
        //}
    }
}
