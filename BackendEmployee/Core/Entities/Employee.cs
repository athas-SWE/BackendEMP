using System.ComponentModel.DataAnnotations;

namespace BackendEmployee.Core.Entities
{
	public class Employee : BaseEntity
	{
		[Required]
		[MaxLength(50)]
		public string FirstName { get; set; }

		[Required]
		[MaxLength(50)]
		public string LastName { get; set; }

		[Required]
		[EmailAddress(ErrorMessage = "Invalid Email Address")]
		public string Email { get; set; }

		[Required]
		[Phone(ErrorMessage = "Invalid Phone Number")]
		public string Phone { get; set; }

		[Required]
		public DateTime DateOfBirth { get; set; }

		public int Age
		{
			get
			{
				DateTime currentDate = DateTime.Now;
				int age = currentDate.Year - DateOfBirth.Year;

				if (currentDate < DateOfBirth.AddYears(age))
				{
					age--;
				}

				if (age < 18 || age > 65)
				{
					throw new ValidationException("Age must be between 18 and 65.");
				}

				return age;
			}
		}

		[Required]
		[Range(1000000, double.MaxValue, ErrorMessage = "Salary must be greater than 1,000,000 LKR.")]
		public decimal Salary { get; set; }

		[Required]
		[MaxLength(100)]
		public string Department { get; set; }
	}
}
