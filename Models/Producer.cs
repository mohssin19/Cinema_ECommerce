using Cinema_ECommerce.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema_ECommerce.Models
{
    public class Producer : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Profile Picture")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Producer Name")]
        public string FullName { get; set; }
        public string Bio {get; set;}

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
