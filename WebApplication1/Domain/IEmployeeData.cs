using System;
using System.Collections.Generic;
using WebApplication1.Entity;

namespace WebApplication1.Domain

{
     public interface IEmployeeData
    {
        //get all employee
        List<Employee> GetEmployee();

        //get single employee
        Employee GetSingleEmployee(Guid id);

        //create employee
        Employee AddEmployee(Employee emp);

        //delete employee
        void DeleteEmployee(Employee emp);

        //edit employee data
        Employee EditEmployee(Employee emp);
    }
}
