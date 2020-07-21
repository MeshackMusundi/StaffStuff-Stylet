using StaffStuff.Services;
using StaffStuff.ViewModels;
using Stylet;
using StyletIoC;

namespace StaffStuff
{
    public class Bootstrapper : Bootstrapper<ShellViewModel>
    {
        protected override void ConfigureIoC(IStyletIoCBuilder builder)
        {
            builder.AddModule(new ServicesModule());
        }
    }
}
