using FreshMvvm;
using Xamarin.Forms;

namespace PanelViewControl
{
    public class MainPageModel : FreshBasePageModel
    {
        public Command ShowPanelView
        {
            get
            {
                return new Command(() =>
                {
                    PanelViewVisible = true;
                });
            }
        }

        public bool PanelViewVisible { get; set; }

        public Command PanelShowing
        {
            get
            {
                return new Command(() =>
                {
                });
            }
        }
    }
}