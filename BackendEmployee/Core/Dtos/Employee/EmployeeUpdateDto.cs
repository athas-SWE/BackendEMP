using System.ComponentModel.DataAnnotations;

namespace BackendEmployee.Core.Dtos.Employee
{
    public class EmployeeUpdateDto
    {
        public long ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
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

        public decimal Salary { get; set; }
        public string Department { get; set; }
    }
}
