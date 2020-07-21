using StaffStuff.Common.Interfaces;
using StaffStuff.Services.Services;
using StyletIoC;

namespace StaffStuff.Services
{
    public class ServicesModule : StyletIoCModule
    {
        protected override void Load()
        {
            Bind<IStaffData>().To<StaffData>().InSingletonScope();
        }
    }
}
