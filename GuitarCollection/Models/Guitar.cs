using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GuitarCollection.Models
{
    public class Guitar
    {
        public int ID { get; set; }
		[StringLength(60, MinimumLength = 1)]
		[Required]
		//acoustic or electric
		[System.ComponentModel.DataAnnotations.Display(Name = "Guitar Type")]
		public string GuitarType { get; set; }
		[System.ComponentModel.DataAnnotations.Display(Name = "Guitar Brand")]
		[StringLength(60, MinimumLength = 1)]
		[Required]
		public string GuitarBrand { get; set; }
		[System.ComponentModel.DataAnnotations.Display(Name = "Number of Strings")]
		[RegularExpression("^[0-9]*$")]
		public int NumStrings { get; set; }
		[System.ComponentModel.DataAnnotations.Display(Name = "String Brand")]
		[StringLength(60, MinimumLength = 1)]
		[Required]
		public string StringBrand { get; set; }
    }
}
