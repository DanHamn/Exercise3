using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Basklassen för animals
namespace Exercise3_2
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }

        //Specifierar att alla underklasser ska ha en metod som returner ljudet djuret gör
        public abstract void Dosound();

        //Basinformationen för alla animals
        public Animal(string name, int age, int weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }
    }

}
