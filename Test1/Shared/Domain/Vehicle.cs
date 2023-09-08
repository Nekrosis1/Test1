using System.ComponentModel.DataAnnotations;

namespace Test1.Shared.Domain
{
    public class Vehicle : BaseDomainModel
    {
        public int? Year { get; set; }
		[Required(ErrorMessage = "Model ID is Required")]
		public int ModelId { get; set; }
        public virtual Model? Model { get; set; }
		[Required(ErrorMessage = "Model ID is Required")]
		public int MakeId { get; set; }
        public virtual Make? Make { get; set; }
		[Required(ErrorMessage = "Color ID is Required")]
		public int ColorId { get; set; }
        public virtual Color? Color { get; set; }
		[Required(ErrorMessage = "Vehicle Identification Number is Required")]
		public string Vin { get; set; }
		[Required(ErrorMessage = "License Plate Number is Required")]
		public string LicensePlateNumber { get; set; }
		[Required(ErrorMessage = "Rental Rate is Required")]
		public double RentalRate { get; set; }
        public virtual List<Booking>? Bookings { get; set; }


    }
}
