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
        [Display(Name = "Family ID")]
        public int Family_ID { get; set; }

        [Required(ErrorMessage = "Family Name is required")]
        [Display(Name = "Foster Family")]
        public string Foster_Family { get; set; }

        //[Required(ErrorMessage = "Home type is required")]
        [Display(Name = "Type of Home")]
        public string Type_of_Home { get; set; }

        [Range(0, 10)]
        [Required(ErrorMessage = "Number of licensed beds is required")]
        [Display (Name = "Licensed Beds")]
        public Nullable<int> Licensed_Beds { get; set; }

        [Range (0, 10)]
        [Display(Name = "Occupied Beds")]
        [Required(ErrorMessage = "Number of occupied beds is required")]
        public Nullable<int> Occupied_Beds { get; set; }

        [Range(0, 10)]
        [Required(ErrorMessage = "Number of available beds is required")]
        [Display(Name = "Available Beds")]
        public Nullable<int> Available_Beds { get; set; }

        [Range(0, 18)]
        [Display(Name = "Min Age")]
        public Nullable<int> Min_Age { get; set; }

        [Range(0, 18)]
        [Display(Name = "Max Age")]
        public Nullable<int> Max_Age { get; set; }

        [Display(Name = "Preferred Gender")]
        public string Preferred_Gender { get; set; }

        [Display(Name = "Agency")]
        [Required(ErrorMessage = "Agency is required")]
        public string Agency { get; set; }

        [Display(Name = "Point of Contact")]
        [Required(ErrorMessage = "A point of contact is required")]
        public string POC { get; set; }

        public string Comments { get; set; }
    }
}