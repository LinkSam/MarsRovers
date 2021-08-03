
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MarsRoversUI.Models
{
    public class MarsRoversTestModel
    {
        [Required]
        [Display(Name = "Region Width")]
        [Range(1, int.MaxValue, ErrorMessage ="Must be a value greater than 0")]
        public int RegionWidth { get; set; }

        [Required]
        [Display(Name = "Region Height")]
        [Range(1, int.MaxValue, ErrorMessage = "Must be a value greater than 0")]
        public int RegionHeight { get; set; }
        
        public IList<MarsRoverModel> MarsRoverList { get;}

        public MarsRoversTestModel() {
            MarsRoverList = new List<MarsRoverModel>();
        }
    }
}