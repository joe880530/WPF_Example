using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace MVVM_ListBox_Example
{
    public class Employee : INotifyPropertyChanged
    {
        private int _empNo;
        private string _empName;
        private string _empJob;

        public event PropertyChangedEventHandler PropertyChanged;

        public int EmpNo {
            get { return _empNo; }
            set {
                _empNo = value;
                OnPropertyChanged("EmpNo");
            }
        }

        public string EmpName {
            get { return _empName; }
            set {
                _empName = value;
                OnPropertyChanged("EmpName");
            }
        }
        public string EmpJob {
            get { return _empJob; }
            set {
                _empJob = value;
                OnPropertyChanged("EmpJob");
            }
        }

        private void OnPropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));

            //if (PropertyChanged != null)
            //{
            //    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(PropertyName));
            //}
        }
    }
}
