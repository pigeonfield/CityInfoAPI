using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfoAPI.Models
{
    public class PointOfInterestForCreationDTO
    {
       [Required(ErrorMessage="Name is required")]
       [MaxLength(50)]
       public string Name { get; set; }

       [MaxLength(200)]
       public string Description { get; set; }

    }

    // System.ComponentModel.DataAnnotations.  - for checking possible type of validation
}
