using System.ComponentModel.DataAnnotations;
using System.Web.ModelBinding;

namespace SACLA.Models.Data
{
	public class Paper
	{
		[Key]
		[BindNever] //Makes the id auto increment

		public int id { get; set; }

		[Required(ErrorMessage = "Paper Title Required"),
			Display(Name = "Title")]

		public string title { get; set; }

		[Display(Name = "Abstract")]
		public string paperAbstract { get; set; }

	}
}