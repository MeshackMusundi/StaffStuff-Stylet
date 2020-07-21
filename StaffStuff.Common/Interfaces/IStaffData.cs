using StaffStuff.Common.Models;
using System.Collections.Generic;

namespace StaffStuff.Common.Interfaces
{
    public interface IStaffData
    {
        List<Employee> GetEmployees();
    }
}
