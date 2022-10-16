using static System.Console;
using DotNetCoach.CSTricks.Data.Employees;

IEmployeeRepository repository = new EmployeeRepository();
IEnumerable<Employee> all = repository.GetAll();

//repository.Add(null);

//repository.Add(new Employee { FirstName = "Anders", LastName = "Hejlsberg" });

repository
    .GetAll()
    .ToList()
    .ForEach(WriteLine);
