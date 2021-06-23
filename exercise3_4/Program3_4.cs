﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace exercise3_4
{
    class Program3_4
    {
/*      F: Varför är polymorfism viktigt att behärska?
                S: För att redusera upprepande kod.
        F: Hur kan polymorfism förändra och förbättra kod via en bra struktur?
                S: Det gör det enkelt att se likheterna och skillnaderna mellan olika klasser och
                se vad som är beroende av vad.
        F: Vad är det för en skillnad på en Abstrakt klass och ett Interface?
                En abstrakt klass visar både på vad alla subklasser minst kommer behöva som input och 
                vilka metoder som subklasserna kan override.
                Ett interface implementerar ingenting och kan inte användas som den är, utan den är 
                mer som en ritning som visar på vad som klassen som baseras på interfacet ska ha med*/
        static void Main()
        {
            List<UserError> userErrors = MakeUserErrorList();

            PrintUEMessages(userErrors);
        }

        private static void PrintUEMessages(List<UserError> userErrors)
        {
            int i = 0;
            foreach (UserError userError in userErrors)
            {
                Console.WriteLine($"{i + 1}:" + userError.UEMessage());
                i++;
            }
        }

        private static List<UserError> MakeUserErrorList()
        {
            List<UserError> userErrors = new();
            for (int i = 1; i < 16; i++)
            {
                if (i % 2 == 0)
                {
                    userErrors.Add(new NumericInputError());
                }
                else if (i % 3 == 0)
                {
                    userErrors.Add(new TextInputError());
                }
                else if (i % 5 == 0)
                {
                    userErrors.Add(new SymbolicInputError());
                }
                else if (i % 7 == 0)
                {
                    userErrors.Add(new TooLargeInputError());
                }
                else
                {
                    userErrors.Add(new NullInputError());
                }
            }

            return userErrors;
        }
    }
}
