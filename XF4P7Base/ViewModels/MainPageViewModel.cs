using Prism.Navigation;

namespace XF4P7Base.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "MainPage";
        }
    }
}
