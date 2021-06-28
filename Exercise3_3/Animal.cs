using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Basklassen för animals
namespace Exercise3_3
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }

        //Specifierar att alla underklasser ska ha en metod som returner ljudet djuret gör
        public abstract void Dosound();
        //och en metod som returnerar en string med stats
        public abstract string Stats();

        //Basinformationen för alla animals
        public Animal(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }
    }

}
