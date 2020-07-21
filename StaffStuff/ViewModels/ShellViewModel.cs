using Stylet;

namespace StaffStuff.ViewModels
{
    public class ShellViewModel : Conductor<IScreen>.StackNavigation
    {        
        public ShellViewModel(StaffViewModel staffViewModel)
        {
            this.DisplayName = string.Empty;
            this.ActivateItem(staffViewModel);
        }
    }
}
