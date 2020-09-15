using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Theatermoviemanagement._00data
{
    public class Movie
    {

        public int MovieID { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = " Please enter movie name ")]

        public string Title { get; set; }
        public string PublisherTitle { get; set; }
        
        public string Author { get; set; }


    }

    public class Pubg
    {

        public int PubgID { get; set; }
        [StringLength(50)]
        [Required]

        public string Title { get; set; }
        public string PublisherTitle { get; set; }

        public string Author { get; set; }
    }
}