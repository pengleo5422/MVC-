using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Display(Name = "標題")]
        public string Title { get; set; }

        [Display(Name = "釋出日期")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "種類")]
        public string Genre { get; set; }
        [Display(Name = "價格")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [Display(Name = "分級")]
        public string Rating { get; set; }
    }
}