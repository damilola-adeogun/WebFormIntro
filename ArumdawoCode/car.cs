using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArumdawoCode
{
    class car
    {
        private int NoOfTyres;
        public int tyres {
            get {
                return NoOfTyres;
            }
            set {
                NoOfTyres = value * 4;
            }
        }


        public readonly int year;

        public int getTyres()
        {
            return NoOfTyres;
        }

        public void greet(string name, out int calculatedAge, int? age = null, params string[] args)
        {
            calculatedAge = 5;
            if (age != null)
            {
                calculatedAge = (int)age + 5;
            }
            if (args.Count() > 0)
            {
                foreach (var item in args)
                {
                    name += " " + item;
                }
            }
            
            //var greeting = "Good afternoon dear " + name;
            //greeting = string.Format("Good afternoon dear {0}", name);
            var greeting = $"Good afternoon dear {name}, you are {age}";
            Console.WriteLine(greeting);
        }

        public List<int> add(int a, int b)
        {
            List<int> g = new List<int>();

            return g;
        }
    }
}
