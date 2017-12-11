using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimerPro.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModListView : ListView

    {
        public ModListView(ListViewCachingStrategy strategy) : base(strategy)

        {
            InitializeComponent();

            ItemSelected += (sender, e) => SelectedItem = null;
        }
    }
}