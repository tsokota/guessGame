using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamers
{
    public abstract class Gamer
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public abstract int GetNumber();

        public abstract GamerTypesEnum Type { get; }

        internal readonly Random random = new Random((int)DateTime.Now.Ticks);

        internal static List<int> used = new List<int>();

        public List<int> localMem { get; set; }

        public Gamer(string name, int age)
        {
            Name = name;
            Age = age;
            localMem = new List<int>();
        }

        public int MakeStep()
        {
            used.Add(GetNumber());
            return used[used.Count - 1];
        }
    }
}
