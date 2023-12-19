namespace Demo_Manish.Models
{
    public interface IEmployeeRepo
    {
        List<EmployeeModel> EmployeeGet();
        dbResponseModel AddEmployee(EmployeeModel model);
        EmployeeModel GetEmployeeinfo(int id);
        dbResponseModel UpdateEmployee(EmployeeModel model);
        dbResponseModel DeleteEmployee(int id);
    }
}
