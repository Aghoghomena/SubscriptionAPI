using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entity;

namespace WebApplication1.Domain
{
    public class sqlEmployee : IEmployeeData
    {
        //get employee context

        private SubContext _employeeContext;
        public sqlEmployee(SubContext employeeContext)
        {

            _employeeContext = employeeContext;
        }
        public Employee AddEmployee(Employee emp)
        {
            emp.Id = Guid.NewGuid();
            _employeeContext.Employees.Add(emp);
            _employeeContext.SaveChanges();
            return emp;
        }

        public void DeleteEmployee(Employee emp)
        {
            var existingemployee = _employeeContext.Employees.Find(emp.Id);
            if (existingemployee != null)
            {
                _employeeContext.Employees.Remove(existingemployee);
                _employeeContext.SaveChanges();
            }
        }

        public Employee EditEmployee(Employee emp)
        {
            var existingeemployee = _employeeContext.Employees.Find(emp.Id);
            if(existingeemployee != null)
            {
                _employeeContext.Employees.Update(existingeemployee);
                _employeeContext.SaveChanges();
               
            }
            return emp;
        }

        public List<Employee> GetEmployee()
        {
            return _employeeContext.Employees.ToList();
        }

        public Employee GetSingleEmployee(Guid id)
        {
            //another way
            //var employe = _employeeContext.Find(id);
            //return employe

            return _employeeContext.Employees.SingleOrDefault(x => x.Id == id);
     
        }
    }
}
