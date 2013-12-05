using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace WCF_firstService
{
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        IList<Employee> GetAll();

        [OperationContract]
        Employee GetEmployeeById(Guid id);

        [OperationContract]
        void AddEmployee(Employee employee);

        [OperationContract]
        void RemoveEmployee(Employee employee);
    }
}
