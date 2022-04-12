using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week08_2
{
    public class Dog : IComparable
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string species { get; set; }
        public int score { get; set; }

        public Dog()
        {
            init(-1, "Unnamed Dog", "Unknown species", 0);
        }

        public Dog(int id)
        {
            init(id, "Dog " + id, "Unknown species", 0);
        }

        public Dog(int id, string fullName, string species)
        {
            init(id, fullName, species, 0);
        }

        private void init (int id, string fullName, string species, int score)
        {
            this.id = id;
            this.fullName = fullName;
            this.species = species;
            this.score = score;
        }

        public int Run100meters()
        {
            RandomNumberGenerator random = RandomNumberGenerator.getInstance();

            this.score = random.Next(15, 30 + 1);
            return this.score;
        }

        public override string ToString()
        {

            return $"({id}) {fullName} ({species}) -> {score}";
        }

        public int CompareTo(object obj)
        {
            var dog = obj as Dog;
            if (dog == null)
                return 0;
            return this.score.CompareTo(dog.score);
        }
    }
}
