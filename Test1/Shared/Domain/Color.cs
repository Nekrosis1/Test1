using System.ComponentModel.DataAnnotations;

namespace Test1.Shared.Domain
{
    public class Color : BaseDomainModel
    {
		[Required(ErrorMessage = "Name is Required")]
		[StringLength(100, MinimumLength = 1)]
		public string Name { get; set; }
    }
}
