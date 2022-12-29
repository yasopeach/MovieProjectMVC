using MovieProject.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieProject.WebUI.Models
{
    public class Movie
    {

        public int MovieId { get; set; }
        public string MovieName { get; set; }

        [DataType(DataType.Date)]
        public DateTime MovieDate { get; set; }

        [Range(0, 10)]
        public int MovieImdb { get; set; }

        public int MovieTime { get; set; }

        public List<Category> SelectedCategory { get; set; }


    }
}
