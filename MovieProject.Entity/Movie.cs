using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Entity
{
    public class Movie
    {
        public int MovieId { get; set; }

        public string MovieName { get; set; }

        [DataType(DataType.Date)]
        public DateTime MovieDate { get; set; }

        [Range(0, 10)]
        public int MovieImdb { get; set; }


        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
