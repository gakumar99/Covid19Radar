using System.Collections.Generic;
using Covid19Radar.Model;
using Prism.Navigation;
using Xamarin.Forms;

namespace Covid19Radar.ViewModels
{
    public class DescriptionPageViewModel : ViewModelBase
    {
        public List<StepModel> Steps { get; set; }

        public DescriptionPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = Resources.AppResources.TitleHowItWorks;
            SetData();
        }

        public Command OnClickNext => new Command(async () =>
        {
            await NavigationService.NavigateAsync("ConsentByUserPage");
        });


        private void SetData()
        {
            Steps = new List<StepModel>
            {
                new StepModel
                {
                    Title = Resources.AppResources.DescriptionPageTitleTextStep1,
                    Image = Resources.AppResources.DescriptionPageStep1Image1,
                    Image2 = Resources.AppResources.DescriptionPageStep1Image2,
                    Description = Resources.AppResources.DescriptionPageTextStep1Description,
                    Description2 = Resources.AppResources.DescriptionPageTextStep1Description2,
                    StepNumber = 1
                },
                new StepModel
                {
                    Title = Resources.AppResources.DescriptionPageTitleTextStep2,
                    Image = Resources.AppResources.DescriptionPageStep2Image1,
                    Image2 = Resources.AppResources.DescriptionPageStep2Image2,
                    Description = Resources.AppResources.DescriptionPageTextStep2Description,
                    Description2 = Resources.AppResources.DescriptionPageTextStep2Description2,
                    StepNumber = 2
                },
                new StepModel
                {
                    Title = Resources.AppResources.DescriptionPageTitleTextStep3,
                    Image = Resources.AppResources.DescriptionPageStep3Image1,
                    Description = Resources.AppResources.DescriptionPageTextStep3Description,
                    StepNumber = 3
                },
                new StepModel
                {
                    Title = Resources.AppResources.DescriptionPageTitleTextStep4,
                    Image = Resources.AppResources.DescriptionPageStep4Image1,
                    Description = Resources.AppResources.DescriptionPageTextStep4Description
                }
            };

        }
    }
}
