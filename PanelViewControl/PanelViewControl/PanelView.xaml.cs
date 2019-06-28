using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PanelViewControl
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PanelView : ContentView
	{
		public PanelView ()
		{
			InitializeComponent ();
		}

        public static readonly BindableProperty PanelVisibleProperty = BindableProperty.Create(
                                propertyName: nameof(PanelVisible),
                                returnType: typeof(bool),
                                declaringType: typeof(PanelView),
                                defaultBindingMode: BindingMode.OneWay,
                                defaultValue: false,
                                propertyChanged: (bindable, oldValue, newValue) =>
                                {
                                    if ((bool)newValue)
                                    {
                                        ((PanelView)bindable).Showing.Execute(true);
                                    }
                                });

        public bool PanelVisible
        {
            get { return (bool)base.GetValue(PanelVisibleProperty); }
            set { base.SetValue(PanelVisibleProperty, value); }
        }

        public static readonly BindableProperty ShowingProperty = BindableProperty.Create(
                                    propertyName: nameof(Showing),
                                    returnType: typeof(Command),
                                    declaringType: typeof(PanelView),
                                    defaultBindingMode: BindingMode.OneWay);

        public Command Showing
        {
            get { return (Command)base.GetValue(ShowingProperty); }
            set { base.SetValue(ShowingProperty, value); }
        }
    }
}