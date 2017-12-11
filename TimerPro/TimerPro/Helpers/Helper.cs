using TimerPro.Interfaces;
using Xamarin.Forms;

namespace TimerPro.Helpers
{
    public class Helper
    {
        public static IHelper helper= DependencyService.Get<IHelper>();
    }
}