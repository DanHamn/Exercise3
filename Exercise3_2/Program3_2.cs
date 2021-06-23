using System;

namespace Exercise3_2
{
    class Program3_2
    {
        /*F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut,
     *   i vilken klass bör vi lägga det?
     *   I subklasses "Bird"
    F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
         I subklassen "Animal"
    */
        static void Main()
        {
            Horse horse = new("Hela", 10, 500, "yes");
            horse.Dosound();

            Dog dog = new("Trollet", 15, 30, "yes");
            dog.Dosound();

            Hedgehog hedgehog = new("Kotten", 7, 5, 5000);
            hedgehog.Dosound();

            Pelican pelican = new("Rosa", 5, 10, 2, 2);
            pelican.Dosound();

            Wolfman wolfman = new("Carn", 35, 90, "No", "Leave before I get hungry");
            wolfman.Talk();
        }
    }
}
