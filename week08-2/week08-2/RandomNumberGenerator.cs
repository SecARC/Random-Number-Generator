using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week08_2
{
    public class RandomNumberGenerator : Random
    {
        //Singleton Pattern
        private static RandomNumberGenerator _instance;

        private RandomNumberGenerator()
        {

        }

        public static RandomNumberGenerator getInstance()
        {
            if (_instance == null)
                _instance = new RandomNumberGenerator();

            return _instance;
        }
    }
}
