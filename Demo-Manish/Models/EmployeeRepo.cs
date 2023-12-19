using Demo_Manish.DataLayer;
using System.Net;
using System.Reflection;
using static Demo_Manish.Models.EmployeeRepo;

namespace Demo_Manish.Models
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly IDapperOrm _dapperOrm;

        public EmployeeRepo(IDapperOrm dapperOrm)
        {
            _dapperOrm = dapperOrm;
        }

        public List<EmployeeModel> EmployeeGet()
        {
            var param = new
            {
                @id = 0
            };
            var employees = _dapperOrm.Returnlist<EmployeeModel, dynamic>("EmployeeGet", param);
            return employees.ToList();
        }
        public dbResponseModel AddEmployee(EmployeeModel model)
        {
            var param = new
            {
                @Name = model.Name,
                @Mobile = model.Mobile,
                @Email = model.Email,
                @Address = model.Address
            };
            var res = _dapperOrm.Returnlist<dbResponseModel, dynamic>("EmpInsert", param);
            return res.FirstOrDefault();
        }
        public EmployeeModel GetEmployeeinfo(int id)
        {
            var param = new
            {
                @id = id
            };
            var departmentlist = _dapperOrm.Returnlist<EmployeeModel, dynamic>("EmployeeInfo", param);
            return departmentlist.FirstOrDefault();
        }
        public dbResponseModel UpdateEmployee(EmployeeModel model)
        {
            var param = new
            {
                @id=model.id,
                @Name = model.Name,
                @Mobile = model.Mobile,
                @Email = model.Email,
                @Address = model.Address,
            };
            var res = _dapperOrm.Returnlist<dbResponseModel, dynamic>("UpdateEmployee", param);
            return res.FirstOrDefault();
        }
        public dbResponseModel DeleteEmployee(int id)
        {
            var param = new
            {
                @id = id
            };
            var res = _dapperOrm.Returnlist<dbResponseModel, dynamic>("DeleteEmployee", param);
            return res.FirstOrDefault();
        }
    }
}

