using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema_ECommerce.Models
{
    public class Actor_Movie
    {
        // This class for the many to many relationship between Actor and Movies
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
