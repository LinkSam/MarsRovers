using System;

using System.ComponentModel.DataAnnotations;

namespace MarsRoversUI.Models
{
    public class MarsRoverModel
    {
        [Display(Name = "Position (X)")]
        [Range(0, int.MaxValue, ErrorMessage ="Must be a value greater than or equal to 0")]
        public int X { get; set; }

        [Display(Name = "Position (Y)")]
        [Range(0, int.MaxValue, ErrorMessage ="Must be a value greater than or equal to 0")]
        public int Y { get; set; }



        [Display(Name = "Heading")]
        [MaxLength(1, ErrorMessage = "Heading should be a single character")]
        [RegularExpression("^[s,n,e,w,S,N,E,W]{1}", ErrorMessage = "Allowed values are N,S,W,E.")]
        public String Heading { get; set; }

        [Display(Name = "Instructions Set")]
        public String Instructions { get; set; }

        [Display(Name = "Information")]

        public String Information { get; set; }

    }
}