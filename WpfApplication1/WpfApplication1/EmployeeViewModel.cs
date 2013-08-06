using System;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
//using Microsoft.Practices.Composite.Presentation.Commands;


namespace WpfApplication1
{
    public class EmployeeViewModel : INotifyPropertyChanged
    {
        private string _employeeName = null;
        private string _firstName = null;
        private string _lastName = null;
        public event PropertyChangedEventHandler PropertyChanged;
        public DelegateCommand<EmployeeViewModel> SubmitCommand { get; private set; }
        public bool SubmitEnabled { get; private set; }
        
        private void OnSubmit(object arg) 
        { 
            EmployeeName = "Entered employee: " + FirstName + " " + LastName; 
        }
        
        private bool CanSubmit(object arg) 
        { 
            bool test = !(String.IsNullOrEmpty(FirstName) || String.IsNullOrEmpty(LastName));
            return test; 
        }

        public EmployeeViewModel()
        {
            this.SubmitCommand = new DelegateCommand<EmployeeViewModel>(this.OnSubmit, this.CanSubmit);
            SubmitCommand.CanExecuteChanged += tester;
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
            this.SubmitEnabled = this.SubmitCommand.CanExecute(null);
            SubmitCommand.RaiseCanExecuteChanged();
            CommandManager.InvalidateRequerySuggested();
        }

        public void tester(object sender, EventArgs e)
        {
            MessageBox.Show("Test worked");
        }
    }
}
