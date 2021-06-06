


using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Entity;

namespace WebApplication1.Domain
{
    //implementation of the IEmployeeData
    public class EmployeeImplementation 


    {

        private List<Employee> Mockdata = new List<Employee>()
        {
            new Employee()
            {
                Id = Guid.NewGuid(),
                name ="Employee one"
            },
            new Employee()
            {
                Id = Guid.NewGuid(),
                name ="Employee two"
            }
        };
        public Employee AddEmployee(Employee emp)
        {
            emp.Id = Guid.NewGuid();
            Mockdata.Add(emp);
            return emp;
            //throw new NotImplementedException();
        }

        public void DeleteEmployee(Employee emp)
        {
            
            Mockdata.Remove(emp);
        }

        public Employee EditEmployee(Employee emp)
        {
            var existingeemployee = GetSingleEmployee(emp.Id);
            existingeemployee.name = emp.name;
            return existingeemployee;
        }

        public List<Employee> GetEmployee()
        {
            //throw new NotImplementedException();
            return Mockdata;
        }

        public Employee GetSingleEmployee(Guid id)
        {
            return Mockdata.SingleOrDefault(x => x.Id == id);
        }
    }
}
