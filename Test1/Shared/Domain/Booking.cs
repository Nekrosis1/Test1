using System.ComponentModel.DataAnnotations;

namespace Test1.Shared.Domain
{
    public class Booking : BaseDomainModel, IValidatableObject
    {
        public int VehicleId { get; set; }
        public virtual Vehicle? Vehicle { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOut { get; set; }
		public DateTime? DateIn { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (DateIn != null)
            {
                if(DateIn <= DateOut)
                {
                    yield return new ValidationResult("Date In must be greate than Date Out", new[] { "DateIn" });
                }
            }
        }

    }
}