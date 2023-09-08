using System.ComponentModel.DataAnnotations;

namespace Test1.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        [Required(ErrorMessage = "First Name is Required")]
		[StringLength(100, MinimumLength = 1)]
        public string FirstName { get; set; }
		[Required(ErrorMessage = "Last Name is Required")]
		[StringLength(100, MinimumLength = 1)]
		public string LastName { get; set; }

		public string? Address { get; set; }
		[Required(ErrorMessage = "Tax ID is Required")]
		[StringLength(20, MinimumLength = 5, ErrorMessage = "Invalid Tax ID")]
		public string TaxId { get; set; }
		[Required(ErrorMessage = "Phone Number is Required")]
		[DataType(DataType.PhoneNumber)]
		public string ContactNumber { get; set; }
		[Required(ErrorMessage = "Email is Required")]
		[DataType(DataType.EmailAddress)]
		[EmailAddress(ErrorMessage = "Invalid Email Address")]
		public string EmailAddress { get; set; }

        public virtual List<Booking>? Bookings { get; set; }

    }
}