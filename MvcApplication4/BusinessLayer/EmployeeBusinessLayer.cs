using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplication4.Data_Access_Layer;
using MvcApplication4.Models;

namespace MvcApplication4.BusinessLayer
{
    public class EmployeeBusinessLayer
    {
         public List<Employee> GetEmployees()
         {
            SalesERPDAL salesDal = new SalesERPDAL();
            return salesDal.Employees.ToList();
          }


         public Employee SaveEmployee(Employee e)
         {
             SalesERPDAL salesDal = new SalesERPDAL();
             salesDal.Employees.Add(e);
             salesDal.SaveChanges();
             return e;
         }
    }
}