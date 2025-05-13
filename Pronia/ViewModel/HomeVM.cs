using Pronia.ViewModel.ServiceViewModel;
using Pronia.ViewModel.SliderViewModel;

namespace Pronia.ViewModel
{
	public class HomeVM
	{
        public List<SliderGetVM> Sliders { get; set; }
		public List<ServiceGetVM> Services { get; set; }
    }
}
