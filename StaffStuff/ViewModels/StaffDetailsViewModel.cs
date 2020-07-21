using StaffStuff.Common.Models;
using Stylet;

namespace StaffStuff.ViewModels
{
    public class StaffDetailsViewModel : Screen
    {
        public StaffDetailsViewModel() { }

        private Employee _employee;
        public Employee Employee
        {
            get => _employee;
            set => SetAndNotify(ref _employee, value);
        }

        public void GoBack()
        {
            this.RequestClose();
        }
    }
}
