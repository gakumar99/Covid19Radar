using System.Collections.Generic;
using System.ComponentModel;
using Covid19Radar.Model;
using Covid19Radar.Resources;
using Covid19Radar.Services;
using Prism.Navigation;
using Xamarin.Forms;

namespace Covid19Radar.ViewModels
{
    public class DesignSamplePageViewModel : ViewModelBase, INotifyPropertyChanged
    {
        public List<HomeMenuModel> MainMenus { get; private set; }

        public DesignSamplePageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "DesignSample";
        }
    }
}
