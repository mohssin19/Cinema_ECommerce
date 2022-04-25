using Cinema_ECommerce.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema_ECommerce.Models
{
    public class Actor : IEntityBase
    {   [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage ="Profile Picture is required")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Actor Name")]
        [Required(ErrorMessage = "Actor Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="Full name must have more than 3 charecters")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Actor Name is required")]
        public string Bio { get; set; }
        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
