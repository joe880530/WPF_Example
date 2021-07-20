using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;

namespace MVVM_ListBox_Example
{
    class EmployeeViewModel : ObservableCollection<Employee>
    {
        public EmployeeViewModel()
        {
            //객체 추가.
            Add(new Employee() { EmpNo = 1, EmpName = "A", EmpJob = "Alpha" });
            Add(new Employee() { EmpNo = 2, EmpName = "B", EmpJob = "Alpha" });
            Add(new Employee() { EmpNo = 3, EmpName = "C", EmpJob = "Gamma" });
            Add(new Employee() { EmpNo = 4, EmpName = "D", EmpJob = "Alpha" });
            Add(new Employee() { EmpNo = 5, EmpName = "E", EmpJob = "Delta" });
            Add(new Employee() { EmpNo = 6, EmpName = "F", EmpJob = "Alpha" });
        }
    }
}
