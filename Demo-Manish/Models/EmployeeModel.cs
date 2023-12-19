using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System.Net;
using System.Reflection;

namespace Demo_Manish.Models
{
    public class EmployeeModel
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }      
    }
}
