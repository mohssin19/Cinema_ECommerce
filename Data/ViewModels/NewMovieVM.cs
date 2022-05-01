using Cinema_ECommerce.Data;
using Cinema_ECommerce.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema_ECommerce.Models
{
    public class NewMovieVM 
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is required")]
        [Display(Name = "Movie Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description is required")]
        [Display(Name = "Movie Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Price is required")]
        [Display(Name = "Price in £")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Movie Poster is required")]
        [Display(Name = "Movie Poster")]
        public string ImageURL { get; set; }
        [Required(ErrorMessage = "Movie Start Date is required")]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "Movie End Date is required")]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }
        [Required(ErrorMessage = "Category is required")]
        [Display(Name = "Select a Category")]
        public MovieCategory MovieCategory { get; set; }
        //Relationships
        [Required(ErrorMessage = "Actor/s is required")]
        [Display(Name = "Select Actor/s")]
        public List<int> ActorIds { get; set; }
        [Required(ErrorMessage = "Cinema is required")]
        [Display(Name = "Select Cinema")]
        public int CinemaId { get; set; }
        [Required(ErrorMessage = "Producer is required")]
        [Display(Name = "Select Producer")]
        public int ProducerId { get; set; }
    }
}
