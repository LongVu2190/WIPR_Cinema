using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class Movie_Object
    {
        public string movie_id { get; set; }
        public int cost { get; set; } = 0;

        public List<int> SEATS = new List<int>();
        public Movie_Object() { }
        ~Movie_Object() { }
    }

}
