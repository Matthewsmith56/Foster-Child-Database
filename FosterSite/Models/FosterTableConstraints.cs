using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FosterSite.Models
{
    [MetadataType(typeof(FosterTableMetaData))]
    public partial class FosterTable
    {
    }

    public class FosterTableMetaData
    {
        public int Family_ID { get; set; }

        [Required(ErrorMessage = "Family Name is required")]
        public string Foster_Family { get; set; }

        //[Required(ErrorMessage = "Home type is required")]
        public string Type_of_Home { get; set; }

        [Range(0, 10), Required(ErrorMessage = "Number of licensed beds is required")]
        public Nullable<int> Licensed_Beds { get; set; }

        [Range (0, 10), Required(ErrorMessage = "Number of occupied beds is required")]
        public Nullable<int> Occupied_Beds { get; set; }

        [Range(0, 10), Required(ErrorMessage = "Number of available beds is required")]
        public Nullable<int> Available_Beds { get; set; }

        [Range(0, 18)]
        public Nullable<int> Min_Age { get; set; }

        [Range(0, 18)]
        public Nullable<int> Max_Age { get; set; }
        public string Preferred_Gender { get; set; }

        [Required(ErrorMessage = "Agency is required")]
        public string Agency { get; set; }

        [Required(ErrorMessage = "A point of contact is required")]
        public string POC { get; set; }

        public string Comments { get; set; }
    }
}