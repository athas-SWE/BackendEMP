 using BackendEmployee.Core.Enums;

namespace BackendEmployee.Core.Entities
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public DepartmentCode Code { get; set; }


		// Navigation property for related Employees
		//public ICollection<Employee> Employees { get; set; }

	}
}
