﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal =  employeeDal;
        }

        public IDataResult<Employee> GetById(int employeeId)
        {
            return new SuccessDataResult<Employee>(_employeeDal.Get(filter: p => p.EmployeeId == employeeId));
        }

        public IDataResult<List<Employee>> GetList()
        {
            return new SuccessDataResult<List<Employee>>(_employeeDal.GetList().ToList());
        }

        public IResult Add(Employee employee)
        {   _employeeDal.Add(employee);
            return new SuccessResult(Messages.EmployeeAdded); 
        }

        public IResult Delete(Employee employee)
        {
            _employeeDal.Delete(employee);
            return new SuccessResult(Messages.EmployeeDeleted);
        }

        public IResult Update(Employee employee)
        {
            _employeeDal.Update(employee);
            return new SuccessResult(Messages.EmployeeUpdated);
        }
    }
}