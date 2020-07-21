using StaffStuff.Common.Interfaces;
using StaffStuff.Common.Models;
using Stylet;
using System.Collections.Generic;

namespace StaffStuff.ViewModels
{
    public class StaffViewModel : Screen
    {
        private readonly IStaffData _staffData;

        public StaffViewModel(IStaffData staffData)
        {
            _staffData = staffData;
        }

        private List<Employee> _employees;
        public List<Employee> Employees
        {
            get => _employees;
            set => SetAndNotify(ref _employees, value);
        }

        protected override void OnInitialActivate()
        {
            Employees = _staffData.GetEmployees();
        }

        public void StaffDetails(Employee employee)
        {
            var staffDetailsVM = new StaffDetailsViewModel { Employee = employee };
            ((ShellViewModel)this.Parent).ActivateItem(staffDetailsVM);
        }
    }
}
