using System;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;

namespace WpfApplication1
{
    public class EmployeeViewModel : INotifyPropertyChanged
    {
        private string _employeeName = null;
        private string _firstName = null;
        private string _lastName = null;
        public event PropertyChangedEventHandler PropertyChanged;
        public DelegateCommand<EmployeeViewModel> SubmitCommand { get; private set; }
                
        private void OnSubmit(object arg) 
        { 
            EmployeeName = "Entered employee: " + FirstName + " " + LastName; 
        }
        
        private bool CanSubmit(object arg) 
        { 
            return !(String.IsNullOrEmpty(FirstName) || String.IsNullOrEmpty(LastName)); 
        }

        public EmployeeViewModel()
        {
            this.SubmitCommand = new DelegateCommand<EmployeeViewModel>(this.OnSubmit, this.CanSubmit);
        }

        public string EmployeeName
        {
            get
            {
                return this._employeeName;
            }

            set
            {
                this._employeeName = value;
                RaisePropertyChanged("EmployeeName");
            }
        }

        public string FirstName
        {
            get
            {
                return this._firstName;
            }

            set
            {
                this._firstName = value;
                RaisePropertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get
            {
                return this._lastName;
            }

            set
            {
                this._lastName = value;
                RaisePropertyChanged("LastName");
            }
        }

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
            SubmitCommand.RaiseCanExecuteChanged();
        }
    }
}
