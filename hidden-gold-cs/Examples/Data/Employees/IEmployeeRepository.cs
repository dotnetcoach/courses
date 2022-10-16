namespace DotNetCoach.CSTricks.Data.Employees;

public interface IEmployeeRepository
{
    IEnumerable<Employee> GetAll();
    void Add(Employee employee);
}
