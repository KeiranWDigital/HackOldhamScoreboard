using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Scores_store
    {
        public struct People
        {
            public string Name;
            public int Score;
        };

        public People[] peoples = new People[17];
        public int numberpeople = 0;
    }
}
